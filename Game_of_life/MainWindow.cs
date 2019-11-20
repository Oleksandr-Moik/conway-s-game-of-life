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
        
        private const string CHAOTIC = "Хаотичний";
        private const string STABLE = "Стабільний";
        private const string EXTENSIONS = "Розширюваний";
        private const string EXPLOSIVE = "Вибухаючий";

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
        private void nextGeneration(int[,] grid, int size)
        {
            if (!endGame)
            {
                int Died = 0;
                int Created = 0;
                ++Generation;

                int[,] future = new int[size, size];

                // Loop through every cell 
                for (int l = 0; l < size; l++)
                {
                    for (int m = 0; m < size; m++)
                    {

                        // finding no Of Neighbours 
                        // that are alive 
                        int aliveNeighbours = 0;
                        for (int i = -1; i <= 1; i++)
                            for (int j = -1; j <= 1; j++)
                            {
                                int col = l + i;
                                int row = m + j;

                                if (col == -1) col = size - 1;
                                if (row == -1) row = size - 1;
                                if (col == size) col = 0;
                                if (row == size) row = 0;

                                aliveNeighbours += grid[col, row];
                            }

                        // The cell needs to be subtracted 
                        // from its neighbours as it was 
                        // counted before 
                        aliveNeighbours -= grid[l, m];

                        // Implementing the Rules of Life 

                        // Cell is lonely and dies 
                        if ((grid[l, m] == 1) && (aliveNeighbours < 2))
                        {
                            future[l, m] = 0;
                            ++Died;
                        }
                        // Cell dies due to over population 
                        else if ((grid[l, m] == 1) && (aliveNeighbours > 3))
                        {
                            future[l, m] = 0;
                            ++Died;
                        }
                        // A new cell is born 
                        else if ((grid[l, m] == 0) && (aliveNeighbours == 3))
                        {
                            future[l, m] = 1;
                            ++Created;
                        }
                        // Remains the same 
                        else
                            future[l, m] = grid[l, m];
                    }
                }
                updateParamLabels(Generation, getPopulation(future, size), Died, Created);
                saveToGlobalGrid(future, size);
                drawArea(future, size);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Симуляцію завершено, оскільки відсутні взаємодії клітин (смерть, рух, народження).","Симуляцію завершено");
            }
        }

        // drawing cells and grid in panel
        private void drawArea(int[,] grid, int size)
        {
            panel_PlaingArea.Refresh();

            Graphics graphics = panel_PlaingArea.CreateGraphics();

            int width = panel_PlaingArea.Width;

            // draw cells
            SolidBrush livingBrush = new SolidBrush(colorDialog_LivingCell.Color);

            int currentHeight = 0;
            int currentWigth = 0;
            int cellSize = width / size;

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    if (grid[i, j] == 1)
                        graphics.FillRectangle(livingBrush,
                            currentHeight, currentWigth,
                            cellSize, cellSize);
                    currentHeight += cellSize;
                }
                currentWigth += cellSize;
                currentHeight = 0;
            }

            // draw grid
            Pen gridPan = new Pen(colorDialog_Grid.Color, 1);

            for (int i = 0; i <= width; i += (width / size))
            {
                graphics.DrawLine(gridPan, new Point(i, 0), new Point(i, width));
                graphics.DrawLine(gridPan, new Point(0, i), new Point(width, i));
            }

            graphics.Dispose();
        }

        // copies input grid in Global grid
        private void saveToGlobalGrid(int[,] grid, int size)
        {
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
                    grid[i, j] = random.Next(0, 2);

            return grid;
        }
        private void Button_RandomFiiling_Click(object sender, EventArgs e)
        {
            endGame = false;
            TimerStop();

            int size = trackBar_AreaSize.Value;

            saveToGlobalGrid(RandomGrid(size), size);
            updateParamLabels(0, getPopulation(GlobalGrid, size), 0, 0);

            drawArea(GlobalGrid, size);
        }

        // create empty grid
        private int[,] ClearGrid()
        {
            updateParamLabels(0, 0, 0, 0);
            int[,] grid = new int[1, 1];
            grid[0, 0] = 0;
            return grid;
        }
        private void Button_ClearArea_Click(object sender, EventArgs e)
        {
            endGame = false;
            TimerStop();

            saveToGlobalGrid(ClearGrid(), 1);
            updateParamLabels(0, 0, 0, 0);

            drawArea(GlobalGrid, 1);
        }

        // counts and return this count of alive cells in input grid
        private int getPopulation(int[,] grid, int size)
        {
            if (size <= 0)
            {
                return -1;
            }
            else
            {
                int count = 0;
                for (int i = 0; i < size; ++i)
                    for (int j = 0; j < size; ++j)
                        if (grid[i, j] == 1) ++count;
                return count;
            }
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
            if(label_RulesType.Text == CHAOTIC)
            {
                MessageBox.Show(this,
                    
                    "Для досягнення найкращих результатів використовуйте " +
                    "випадковим чином розкидане поле для ініціалізації " +
                    "моделювання. Вам може знадобитися втрутитись в гру, " +
                    "щоб взаємодіяти з полем, або інакше взаємодії клітин " +
                    "за часом припиняться.", 
                    
                    "Інформація про " + CHAOTIC.ToLower());
            }
            else if (label_RulesType.Text == STABLE) // стабільний
            {
                MessageBox.Show(this,

                    "При стабільних правилах форми рідко взаємодіють " +
                    "між собою. Можливо, Вам буде потрібно побудувати " +
                    "великий блоб, або ж поєднання кілька менших блобів, " +
                    "щоб побачити розвиток шаблону.", 

                    "Інформація про " + STABLE.ToLower());

            }
            else if (label_RulesType.Text == EXTENSIONS) // розширюваний
            {
                MessageBox.Show(this,

                    "Для досягнення найкращих результатів, почніть " +
                    "з пустого поля, і побудуйте деякі живі клітини " +
                    "перед початком моделювання. Для деяких правил, " +
                    "можливо буде потрібно побудувати великий блоб, " +
                    "або ж поєднання кілька менших блобів, щоб " +
                    "побачити розвиток шаблону.", 

                    "Інформація про " + EXTENSIONS.ToLower());

            }
            else if (label_RulesType.Text == EXPLOSIVE) // вибахаючий
            {
                MessageBox.Show(this,

                    "Для досягнення найкращих результатів, почніть " +
                    "з пустого поля, і побудуйте одну-дві живі " +
                    "клітини перед початком моделювання. Деякі " +
                    "правила (наприклад, Пам'ять) найкраще працюють " +
                    "з простою формою або буквою в якосі відправного " +
                    "шаблону.",
                    
                    "Інформація про " + EXPLOSIVE.ToLower());

            }
        }


        // create next generation or initializes new grid generation
        private void NextTick()
        {
            int size = trackBar_AreaSize.Value;
            try
            {
                if (GlobalGrid.Length < 5) throw new NullReferenceException();
                nextGeneration(GlobalGrid, size);
            }
            catch (NullReferenceException)
            {
                saveToGlobalGrid(RandomGrid(size), size);
                updateParamLabels(0, getPopulation(GlobalGrid, size), 0, 0);
                drawArea(GlobalGrid, size);
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
            else  TimerStart();
        }
        private void TrackBar_TimerTick_Scroll(object sender, EventArgs e)
        {
            setTimerInterval();
        }

        
    }
}
