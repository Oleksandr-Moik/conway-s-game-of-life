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
        private const int PANEL_HEIGHT = 600;
        private const int PANEL_WIDTH = 600;

        private const string CHAOTIC_TYPE = "Хаотичний";
        private const string STABLE_TYPE = "Стабільний";
        private const string EXTENSIONS_TYPE = "Розширюваний";
        private const string EXPLOSIVE_TYPE = "Вибухаючий";

        private const int DIED_CELL = -1;
        private const int EMPTY_CELL = 0;
        private const int LIVE_CELL = 1;
        private const int CREATED_CELL = 2;

        //private char[] LifeDefaultRules_Survival;
        //private char[] LifeDefaultRules_Create;
        //private char[] LifeRules_Survival;
        //private char[] LifeRules_Create;

        private int LifeSizeX;
        private int LifeSizeY;

        private int[,] LifeGrid;
        private int Generation;
        private int Population;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            SetPictureColorFromColorDialog();

            Init();



            panel_PlaingArea.Height = PANEL_HEIGHT;
            panel_PlaingArea.Width = PANEL_WIDTH;

            comboBox_RulesSets.SelectedIndex = 0;

            UpdateParamLabels(Generation, Population, 0, 0);
        }

        #region initialization
        private void Init()
        {
            //LifeDefaultRules_Survival = new char[] { '0', '0', '1', '1', '0', '0', '0', '0', '0' };
            //LifeDefaultRules_Create = new char[] { '0', '0', '0', '1', '0', '0', '0', '0', '0' };
            //LifeRules_Survival = new char[] { '0', '0', '1', '1', '0', '0', '0', '0', '0' };
            //LifeRules_Create = new char[] { '0', '0', '0', '1', '0', '0', '0', '0', '0' };

            LifeSizeX = 30;
            LifeSizeY = 30;

            Generation = 0;
            Population = 0;

            LifeGrid = new int[LifeSizeX,LifeSizeY];

        }
        private void SetPictureColorFromColorDialog()
        {
            pictureBox_Grid.BackColor = colorDialog_Grid.Color;
            pictureBox_DeadCell.BackColor = colorDialog_DeadCell.Color;
            pictureBox_CreatedCell.BackColor = colorDialog_CreatedCell.Color;
            pictureBox_LivingCell.BackColor = colorDialog_LivingCell.Color;
            pictureBox_AreaBackground.BackColor = colorDialog_AreaBackground.Color;
        }
        
        #endregion



        // main game logic
        private void NextGeneration(int[,] grid)
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
            DrawCanvas(future);

            future = RevertToEmptyAndLiveCells(future, size);
            SaveToLifeGrid(future);

            int population = CalculatePopulation(future);
            UpdateParamLabels(Generation, population, created_counter, died_counter);
            
        }

        // replace DIED_CELL with EMPTY_CELL
        // replace CREATED_CELL with LIVE_CELL
        private int[,] RevertToEmptyAndLiveCells(int[,] grid, int size)
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
        private void DrawCell(int[,] grid, int type)
        {
            int size = grid.GetLength(0);

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
        private void DrawGrid(int size)
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

        private void DrawCanvas(int[,] grid)
        {
            panel_PlaingArea.Refresh();

            DrawCell(grid, DIED_CELL);
            DrawCell(grid, LIVE_CELL);
            DrawCell(grid, CREATED_CELL);
            DrawCell(grid, EMPTY_CELL);

            DrawGrid(grid.GetLength(0));
        }

        // copies input grid in Global grid
        private void SaveToLifeGrid(int[,] grid)
        {
            int size = grid.GetLength(0);
            LifeGrid = new int[size, size];
            LifeGrid = grid;
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
            TimerStop();

            int size = trackBar_AreaSize.Value;

            SaveToLifeGrid(RandomGrid(size));
            UpdateParamLabels(0, CalculatePopulation(LifeGrid), 0, 0);

            DrawCanvas(LifeGrid);
        }

        private void Button_ClearArea_Click(object sender, EventArgs e)
        {
            TimerStop();
            int size = trackBar_AreaSize.Value;

            SaveToLifeGrid(new int[size, size]);
            UpdateParamLabels(0, 0, 0, 0);

            DrawCanvas(LifeGrid);
        }

        // TODO : create next calc type - created cells, deid cells
        // counts and return this count of alive cells in input grid
        private int CalculatePopulation(int[,] grid)
        {
            int size = grid.GetLength(0);

            int count = 0;
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    if (grid[i, j] == 1) ++count;
            return count;
        }


        // updates informatics labels
        private void UpdateParamLabels(int Generation, int Population, int Created, int Died)
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
                    "моделювання. \nВам може знадобитися втрутитись в гру, " +
                    "щоб взаємодіяти з полем, або інакше взаємодії клітин " +
                    "із часом припиняться.",

                    "Інформація про " + CHAOTIC_TYPE.ToLower());
            }
            else if (label_RulesType.Text == STABLE_TYPE) // стабільний
            {
                MessageBox.Show(this,

                    "При стабільних правилах форми рідко взаємодіють " +
                    "між собою. \nМожливо, Вам буде потрібно побудувати " +
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
                if (LifeGrid.GetLength(0) < trackBar_AreaSize.Minimum) throw new NullReferenceException();
                NextGeneration(LifeGrid);
            }
            catch (NullReferenceException)
            {
                SaveToLifeGrid(RandomGrid(size));
                UpdateParamLabels(0, CalculatePopulation(LifeGrid), 0, 0);
                DrawCanvas(LifeGrid);
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

        // changes grid size
        private void TrackBar_AreaSize_Scroll(object sender, EventArgs e)
        {
            bool timerWasWorking = timer1.Enabled;
            TimerStop();

            int size = trackBar_AreaSize.Value;
            try
            {
                LifeGrid = ChangeSize(LifeGrid, size);
                DrawCanvas(LifeGrid);
            }
            catch (NullReferenceException)
            {
                SaveToLifeGrid(new int[size, size]);
                DrawCanvas(LifeGrid);
            }
            finally
            {
                UpdateParamLabels(Generation, CalculatePopulation(LifeGrid), 0, 0);
            }
            if(timerWasWorking)TimerStart();
        }
        private int[,] ChangeSize(int[,] grid, int sizeNew)
        {
            int[,] gridCopy = grid;
            int sizeOld = gridCopy.GetLength(0);
            grid = new int[sizeNew, sizeNew];

            for (int i = 0; i < sizeOld && i < sizeNew; ++i)
                for (int j = 0; j < sizeOld && j < sizeNew; ++j)
                    grid[i, j] = gridCopy[i, j];

            return grid;
        }

        // TODO : draw cell and add cell
        // add or remove cell from grid
        private void Panel_PlaingArea_MouseClick(object sender, MouseEventArgs e)
        {
            int gridSize = trackBar_AreaSize.Value;

            int cellWidth = panel_PlaingArea.Width / gridSize;
            int cellHeight = panel_PlaingArea.Height / gridSize;

            int col = e.Y / cellWidth;
            int row = e.X / cellHeight;

            try
            {
                LifeGrid[col, row] = LifeGrid[col, row];
            }
            catch (NullReferenceException) // when array doesn't initialized
            {
                 SaveToLifeGrid(new int[gridSize, gridSize]);
            }
            catch (IndexOutOfRangeException)  
            {
                return;
            }

            if (LifeGrid[col, row] == EMPTY_CELL || LifeGrid[col, row] == DIED_CELL)
                LifeGrid[col, row] = LIVE_CELL;
            else 
                LifeGrid[col, row] = EMPTY_CELL; // LIVE_CELL or CREATED_CELL

            // TODO : use died calc and creted calc
            UpdateParamLabels(Generation, CalculatePopulation(LifeGrid), 0, 0);

            DrawCanvas(LifeGrid);
        }

        private void PictureBox_Grid_Click(object sender, EventArgs e)
        {
            if (colorDialog_Grid.ShowDialog() == DialogResult.OK)
                pictureBox_Grid.BackColor = colorDialog_Grid.Color;
        }

        private void PictureBox_AreaBackground_Click(object sender, EventArgs e)
        {
            if (colorDialog_AreaBackground.ShowDialog() == DialogResult.OK)
            {
                pictureBox_AreaBackground.BackColor = colorDialog_AreaBackground.Color;
                panel_PlaingArea.BackColor = colorDialog_AreaBackground.Color;
            }

        }

        private void PictureBox_DeadCell_Click(object sender, EventArgs e)
        {
            if (colorDialog_DeadCell.ShowDialog() == DialogResult.OK)
                pictureBox_DeadCell.BackColor = colorDialog_DeadCell.Color;
        }

        private void PictureBox_CreatedCell_Click(object sender, EventArgs e)
        {
            if (colorDialog_CreatedCell.ShowDialog() == DialogResult.OK)
                pictureBox_CreatedCell.BackColor = colorDialog_CreatedCell.Color;
        }

        private void PictureBox_LivingCell_Click(object sender, EventArgs e)
        {
            if (colorDialog_LivingCell.ShowDialog() == DialogResult.OK)
                pictureBox_LivingCell.BackColor = colorDialog_LivingCell.Color;
        }
    }
}
