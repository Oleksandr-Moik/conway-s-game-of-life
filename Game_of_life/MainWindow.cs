using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_life
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<CheckBox> survivalRules;
        private List<CheckBox> creationRules;

        private int[,] GlobalGrid;

        private int Generation;
        private bool endGame;

        private const string CHAOTIC_TYPE = "Хаотичний";
        private const string STABLE_TYPE = "Стабільний";
        private const string EXTENSIONS_TYPE = "Розширюваний";
        private const string EXPLOSIVE_TYPE = "Вибухаючий";

        private const int DIED_CELL = -1;
        private const int EMPTY_CELL = 0;
        private const int LIVE_CELL = 1;
        private const int CREATED_CELL = 2;

        private void MainWindow_Load(object sender, EventArgs e)
        {
            initCheckBoxList();
            setPictureColorFromColorDialog();

            panel_PlaingArea.Height = 600;
            panel_PlaingArea.Width = 600;

            comboBox_RulesSets.SelectedIndex = 0;

            Generation = 0;
            updateParamLabels(Generation, 0, 0, 0);

            endGame = false;
        }

        #region initialization
        private void initCheckBoxList()
        {
            survivalRules = new List<CheckBox>();
            survivalRules.Insert(0, checkBox1);
            survivalRules.Insert(1, checkBox2);
            survivalRules.Insert(2, checkBox3);
            survivalRules.Insert(3, checkBox4);
            survivalRules.Insert(4, checkBox5);
            survivalRules.Insert(5, checkBox6);
            survivalRules.Insert(6, checkBox7);
            survivalRules.Insert(7, checkBox8);
            survivalRules.Insert(8, checkBox9);

            creationRules = new List<CheckBox>();
            creationRules.Insert(0, checkBox10);
            creationRules.Insert(1, checkBox11);
            creationRules.Insert(2, checkBox12);
            creationRules.Insert(3, checkBox13);
            creationRules.Insert(4, checkBox14);
            creationRules.Insert(5, checkBox15);
            creationRules.Insert(6, checkBox16);
            creationRules.Insert(7, checkBox17);
            creationRules.Insert(8, checkBox18);
        }
        private void setPictureColorFromColorDialog()
        {
            pictureBox_Grid.BackColor = colorDialog_Grid.Color;
            pictureBox_DeadCell.BackColor = colorDialog_DeadCell.Color;
            pictureBox_CreatedCell.BackColor = colorDialog_CreatedCell.Color;
            pictureBox_LivingCell.BackColor = colorDialog_LivingCell.Color;
            pictureBox_AreaBackground.BackColor = colorDialog_AreaBackground.Color;
        }
        #endregion


        // main game logic
        private void nextGeneration(int[,] grid)
        {
            if (!endGame)
            {
                int died_counter = 0;
                int created_counter = 0;
                ++Generation;

                int size = grid.GetLength(0);

                int[,] future = new int[size, size];


                for (int line = 0; line < size; ++line)
                {
                    for (int column = 0; column < size; ++column)
                    {
                        int aliveNeighbours = 0;
                        for (int i = -1; i <= 1; ++i)
                            for (int j = -1; j <= 1; ++j)
                            {
                                int row = line + i; int col = column + j;

                                if (col == -1) col = size - 1; // above grid limit
                                if (row == -1) row = size - 1; // on the left limit

                                if (col == size) col = 0; // lower grid limit
                                if (row == size) row = 0; // on the right limit

                                aliveNeighbours += grid[row, col];
                            }

                        aliveNeighbours -= grid[line, column];

                        // Implementing the Rules of Life 

                        // Cell is lonely and dies 
                        if ((grid[line, column] == LIVE_CELL) && (aliveNeighbours < 2))
                        {
                            future[line, column] = DIED_CELL;
                            ++died_counter;
                        }
                        // Cell dies due to over population 
                        else if ((grid[line, column] == LIVE_CELL) && (aliveNeighbours > 3))
                        {
                            future[line, column] = DIED_CELL;
                            ++died_counter;
                        }
                        // A new cell is born 
                        else if ((grid[line, column] == EMPTY_CELL) && (aliveNeighbours == 3))
                        {
                            future[line, column] = CREATED_CELL;
                            ++created_counter;
                        }
                        // Remains the same 
                        else future[line, column] = grid[line, column];
                    }
                }
                drawCell(future, true, DIED_CELL);
                drawCell(future, false, LIVE_CELL);
                drawCell(future, false, CREATED_CELL);
                drawGrid(size);

                future = revertToEmptyAndLiveCells(future, size);
                saveToGlobalGrid(future);

                int population = calculatePopulation(future);
                checkEndGame(population, died_counter, created_counter);
                updateParamLabels(Generation, population, created_counter, died_counter);
            }
            else
            {
                TimerStop();
                MessageBox.Show("Симуляцію завершено, оскільки відсутні взаємодії клітин (смерть, рух, народження).", "Симуляцію завершено");
            }
        }

        // true - game ended
        // false - game may continue 
        private void checkEndGame(int population, int died, int created)
        {
            if (population == 0) endGame = true;
            else if (created == 0 && died == 0) endGame = true;
            else
            {
                int previous_died = Int32.Parse(label_Died.Text);
                int previous_created = Int32.Parse(label_Created.Text);
                int previous_population = Int32.Parse(label_Population.Text);

                if (population == previous_population) endGame = true;
                else if (died == previous_died && created == previous_created) endGame = true;

                endGame = false;
                //if(previous_created==created && )

            }
        }
        // replace DIED_CELL with EMPTY_CELL
        // replace CREATED_CELL with LIVE_CELL
        private int[,] revertToEmptyAndLiveCells(int[,] grid, int size)
        {
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                {
                    if (grid[i, j] == DIED_CELL) grid[i, j] = EMPTY_CELL;
                    else if (grid[i, j] == CREATED_CELL) grid[i, j] = LIVE_CELL;
                }

            return grid;
        }

        // draws cells from Grid
        // when refresh is true then area will be cleared
        // the type is what cells whow in area
        private void drawCell(int[,] grid, bool refresh, int type)
        {
            int size = grid.GetLength(0);

            if (refresh) panel_PlaingArea.Refresh();
            if (size == 0) return;

            Graphics graphics = panel_PlaingArea.CreateGraphics();

            SolidBrush brush = new SolidBrush(Color.Empty);

            if (checkBox_ShowDeadCell.Checked && type == DIED_CELL) brush.Color = colorDialog_DeadCell.Color;
            else if (type == EMPTY_CELL) brush.Color = colorDialog_AreaBackground.Color;
            else if (type == LIVE_CELL) brush.Color = colorDialog_LivingCell.Color;
            else if (checkBox_ShowCreatedCell.Checked && type == CREATED_CELL) brush.Color = colorDialog_CreatedCell.Color;
            else return;

            int currentHeight = 0;
            int currentWigth = 0;
            int cellSize = panel_PlaingArea.Width / size;

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    if (type == LIVE_CELL)
                    {
                        if (grid[i, j] == LIVE_CELL || grid[i, j] == CREATED_CELL)
                            graphics.FillRectangle(brush,
                               currentHeight, currentWigth,
                               cellSize, cellSize);
                    }
                    else
                    {
                        if (grid[i, j] == type)
                            graphics.FillRectangle(brush,
                               currentHeight, currentWigth,
                               cellSize, cellSize);
                    }
                    // for debuging or showing grid content
                    if (checkBox19.Checked)
                        graphics.DrawString(grid[i, j].ToString(),
                            new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                            new SolidBrush(Color.Red),
                            currentHeight + 4,
                            currentWigth + 4);

                    currentHeight += cellSize;
                }
                currentWigth += cellSize;
                currentHeight = 0;
            }
        }

        // drawing cells and grid in panel
        private void drawGrid(int size)
        {
            Graphics graphics = panel_PlaingArea.CreateGraphics();

            int width = panel_PlaingArea.Width;

            if (checkBox_DisplayGrid.Checked)
            {
                Pen gridPan = new Pen(colorDialog_Grid.Color, 1);

                for (int i = 0; i <= width; i += (width / size))
                {
                    graphics.DrawLine(gridPan, new Point(i, 0), new Point(i, width));
                    graphics.DrawLine(gridPan, new Point(0, i), new Point(width, i));
                }
            }
            graphics.Dispose();
        }

        // copies input grid in Global grid
        private void saveToGlobalGrid(int[,] grid)
        {
            int size = grid.GetLength(0);
            GlobalGrid = new int[size, size];
            GlobalGrid = grid;
        }

        // generates random grid
        private int[,] RandomGrid(int size)
        {
            int[,] grid = new int[size, size];
            Random random = new Random();

            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    grid[i, j] = random.Next(0, 10) % 2;

            return grid;
        }
        private void Button_RandomFiling_Click(object sender, EventArgs e)
        {
            endGame = false;
            TimerStop();

            int size = trackBar_AreaSize.Value;

            saveToGlobalGrid(RandomGrid(size));
            updateParamLabels(0, calculatePopulation(GlobalGrid), 0, 0);

            drawCell(GlobalGrid, true, LIVE_CELL);
            drawGrid(size);
        }

        private void Button_ClearArea_Click(object sender, EventArgs e)
        {
            endGame = false;
            TimerStop();
            int size = trackBar_AreaSize.Value;

            saveToGlobalGrid(new int[size, size]);
            updateParamLabels(0, 0, 0, 0);

            drawCell(GlobalGrid, true, EMPTY_CELL);
            drawGrid(size);
        }

        // counts and return this count of alive cells in input grid
        private int calculatePopulation(int[,] grid)
        {
            int size = grid.GetLength(0);

            int count = 0;
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    if (grid[i, j] == 1) ++count;
            return count;
        }



        // updates informatics labels
        private void updateParamLabels(int Generation, int Population, int Created, int Died)
        {
            label_Generation.Text = Generation.ToString();
            label_Population.Text = Population.ToString();

            label_Created.Text = Created.ToString();
            label_Died.Text = Died.ToString();
        }

        // does not allow editing comboBox
        private void ComboBox_RulesSets_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        // show information about CHAOTIC, STABLE, EXTENSIONS and EXPLOSIVE types
        private void Button_RulesTypeInfo_Click(object sender, EventArgs e)
        {
            if (label_RulesType.Text == CHAOTIC_TYPE)
            {
                MessageBox.Show(this,

                    "Для досягнення найкращих результатів використовуйте " +
                    "випадковим чином розкидане поле для ініціалізації " +
                    "моделювання. Вам може знадобитися втрутитись в гру, " +
                    "щоб взаємодіяти з полем, або інакше взаємодії клітин " +
                    "за часом припиняться.",

                    "Інформація про " + CHAOTIC_TYPE.ToLower());
            }
            else if (label_RulesType.Text == STABLE_TYPE) // стабільний
            {
                MessageBox.Show(this,

                    "При стабільних правилах форми рідко взаємодіють " +
                    "між собою. Можливо, Вам буде потрібно побудувати " +
                    "великий блоб, або ж поєднання кілька менших блобів, " +
                    "щоб побачити розвиток шаблону.",

                    "Інформація про " + STABLE_TYPE.ToLower());

            }
            else if (label_RulesType.Text == EXTENSIONS_TYPE) // розширюваний
            {
                MessageBox.Show(this,

                    "Для досягнення найкращих результатів, почніть " +
                    "з пустого поля, і побудуйте деякі живі клітини " +
                    "перед початком моделювання. Для деяких правил, " +
                    "можливо буде потрібно побудувати великий блоб, " +
                    "або ж поєднання кілька менших блобів, щоб " +
                    "побачити розвиток шаблону.",

                    "Інформація про " + EXTENSIONS_TYPE.ToLower());

            }
            else if (label_RulesType.Text == EXPLOSIVE_TYPE) // вибахаючий
            {
                MessageBox.Show(this,

                    "Для досягнення найкращих результатів, почніть " +
                    "з пустого поля, і побудуйте одну-дві живі " +
                    "клітини перед початком моделювання. Деякі " +
                    "правила (наприклад, Пам'ять) найкраще працюють " +
                    "з простою формою або буквою в якосі відправного " +
                    "шаблону.",

                    "Інформація про " + EXPLOSIVE_TYPE.ToLower());

            }
        }


        // create next generation or initializes new grid generation
        private void NextTick()
        {
            int size = trackBar_AreaSize.Value;
            try
            {
                if (GlobalGrid.GetLength(0) < trackBar_AreaSize.Minimum) throw new NullReferenceException();
                nextGeneration(GlobalGrid);
            }
            catch (NullReferenceException)
            {
                saveToGlobalGrid(RandomGrid(size));
                updateParamLabels(0, calculatePopulation(GlobalGrid), 0, 0);
                drawCell(GlobalGrid, true, LIVE_CELL);
                drawGrid(size);
            }
        }
        private void Button_NextTick_Click(object sender, EventArgs e)
        {
            NextTick();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            NextTick();
        }


        // set timer interval (update speed)
        private void setTimerInterval()
        {
            timer1.Interval = (10 - trackBar_TimerTick.Value) * 100 + 1;
        }
        // stop timer and changes other dependent parameters
        private void TimerStop()
        {
            timer1.Stop();
            button_StartTime.Text = "Почати";
            button_NextTick.Enabled = true;
        }
        // start timer and changes other dependent parameters
        private void TimerStart()
        {
            timer1.Start();
            button_StartTime.Text = "Зупинити";
            button_NextTick.Enabled = false;
        }
        private void Button_StartTime_Click(object sender, EventArgs e)
        {
            setTimerInterval();
            if (timer1.Enabled) TimerStop();
            else TimerStart();
        }
        private void TrackBar_TimerTick_Scroll(object sender, EventArgs e)
        {
            setTimerInterval();
        }

        private void TrackBar_AreaSize_Scroll(object sender, EventArgs e)
        {
            TimerStop();
            int size = trackBar_AreaSize.Value;
            try
            {
                GlobalGrid = changeSize(GlobalGrid, size);
                drawCell(GlobalGrid, true, LIVE_CELL);
            }
            catch (NullReferenceException)
            {
                saveToGlobalGrid(new int[size, size]);
                updateParamLabels(0, 0, 0, 0);
                drawCell(GlobalGrid, true, EMPTY_CELL);
            }
            finally
            {
                drawGrid(size);
            }

        }
        private int[,] changeSize(int[,] grid, int sizeNew)
        {
            int[,] gridCopy = grid;
            int sizeOld = gridCopy.GetLength(0);
            grid = new int[sizeNew, sizeNew];

            for (int i = 0; i < sizeOld && i < sizeNew; ++i)
                for (int j = 0; j < sizeOld && j < sizeNew; ++j)
                    grid[i, j] = gridCopy[i, j];

            return grid;
        }


        // testing blob patterns
        private void Button2_Click(object sender, EventArgs e)
        {
            trackBar_AreaSize.Value = trackBar_AreaSize.Minimum;
            GlobalGrid = new int[,] {
                  { 0,0,0,0,0,0,0,0,0,0},
                  { 0,0,1,1,0,0,0,0,0,0},
                  { 0,0,0,1,0,0,0,0,0,0},
                  { 0,0,0,0,0,0,0,0,0,0},
                  { 0,0,0,0,0,1,1,0,0,0},
                  { 0,0,0,0,0,1,0,0,0,0},
                  { 0,0,0,0,0,0,0,0,1,0},
                  { 0,0,0,0,0,0,0,1,0,1},
                  { 0,0,0,0,0,0,0,1,0,1},
                  { 0,0,0,0,0,0,0,0,1,0},
            };
            drawCell(GlobalGrid, true, 1);
            drawGrid(10);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            trackBar_AreaSize.Value = trackBar_AreaSize.Minimum;
            GlobalGrid = new int[,] {
                  {0,0,0,0,0,1,0,0,0,0},
                  {0,0,0,0,0,1,0,0,0,0},
                  {0,0,0,0,0,1,0,0,0,0},
                  {0,0,0,0,0,0,0,0,0,0},
                  {0,1,1,1,0,0,0,1,1,1},
                  {0,0,0,0,0,0,0,0,0,0},
                  {0,0,0,0,0,1,0,0,0,0},
                  {0,0,0,0,0,1,0,0,0,0},
                  {0,0,0,0,0,1,0,0,0,0},
                  {0,0,0,0,0,0,0,0,0,0},
            };
            drawCell(GlobalGrid, true, 1);
            drawGrid(10);
        }

        private void Panel_PlaingArea_MouseClick(object sender, MouseEventArgs e)
        {
            int wight = panel_PlaingArea.Width;
            int size = trackBar_AreaSize.Value;
            int step = wight / size;

            int col = e.Y / step;
            int row = e.X / step;

            try
            {
                GlobalGrid[col, row] = GlobalGrid[col, row];
            }
            catch (NullReferenceException)
            {
                 saveToGlobalGrid(new int[size, size]);
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }

            if (GlobalGrid[col, row] == EMPTY_CELL || GlobalGrid[col, row] == DIED_CELL)
                GlobalGrid[col, row] = LIVE_CELL;
            else
                GlobalGrid[col, row] = EMPTY_CELL;

            drawCell(GlobalGrid, true, LIVE_CELL);
            drawGrid(size);
            
        }
    }
}
