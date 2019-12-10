using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_life
{
    public partial class MainWindow : Form
    {
        /// panel
        private const int PANEL_HEIGHT = 500;
        private const int PANEL_WIDTH = 500;

        /// GetLenth 1-width  0-heigth
        public int[,] LifeGrid;
        public int LifeSizeHeight;
        public int LifeSizeWidth;

        public int Generation;
        public int Population;

        PlayingArea playingArea;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            panel_PlaingArea.Height = PANEL_HEIGHT;
            panel_PlaingArea.Width = PANEL_WIDTH;

            playingArea = new PlayingArea(this);
            playingArea.Parent = panel_PlaingArea;
            playingArea.Size = panel_PlaingArea.Size;
            playingArea.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left |
                AnchorStyles.Right | AnchorStyles.Top);

            trackBar_AreaSize.Value = 10;
            SetGridSize();

            RefreshLabels();
        }

        // main life game logic
        private void NextGeneration()
        {
            ++Generation;

            int[,] future = new int[LifeSizeHeight, LifeSizeWidth];

            LifeGrid = RevertToEmptyAndLiveCells(LifeGrid);

            for (int Row = 0; Row < LifeSizeHeight; ++Row)
            {
                for (int Column = 0; Column < LifeSizeWidth; ++Column)
                {
                    int aliveNeighbours = 0;
                    for (int i = -1; i <= 1; ++i)
                    {
                        for (int j = -1; j <= 1; ++j)
                        {
                            int row = Row + i;
                            int col = Column + j;

                            if (col == -1) col = LifeSizeWidth- 1; // above grid limit
                            if (row == -1) row = LifeSizeHeight - 1; // on the left limit

                            if (col == LifeSizeWidth) col = 0; // lower grid limit
                            if (row == LifeSizeHeight) row = 0; // on the right limit

                            aliveNeighbours += LifeGrid[row, col];
                        }
                    }
                    aliveNeighbours -= LifeGrid[Row, Column];

                    // Implementing the Rules of Life 

                    // Cell is lonely and dies 
                    if ((LifeGrid[Row, Column] == Cells.LIVE_CELL) && (aliveNeighbours < 2))
                    {
                        future[Row, Column] = Cells.DIED_CELL;
                    }
                    // Cell dies due to over population 
                    else if ((LifeGrid[Row, Column] == Cells.LIVE_CELL) && (aliveNeighbours > 3))
                    {
                        future[Row, Column] = Cells.DIED_CELL;
                    }
                    // A new cell is born 
                    else if ((LifeGrid[Row, Column] == Cells.EMPTY_CELL) && (aliveNeighbours == 3))
                    {
                        future[Row, Column] = Cells.CREATED_CELL;
                    }
                    // Remains the same 
                    else future[Row, Column] = LifeGrid[Row, Column];
                }
            }
            SaveToLifeGrid(future);
            PlayingAreaInvalidate();
            RefreshLabels();
        }

        // replace Cells.DIED_CELL with Cells.EMPTY_CELL
        // replace Cells.CREATED_CELL with Cells.LIVE_CELL
        private int[,] RevertToEmptyAndLiveCells(int[,] grid)
        {
            int widht = grid.GetLength(0);
            int height = grid.GetLength(1);
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < widht; ++j)
                {
                    if (grid[i, j] == Cells.DIED_CELL) grid[i, j] = Cells.EMPTY_CELL;
                    else if (grid[i, j] == Cells.CREATED_CELL) grid[i, j] = Cells.LIVE_CELL;
                }
            }

            return grid;
        }
        
        // copies input grid in Global grid
        public void SaveToLifeGrid(int[,] grid)
        {
            int widht = grid.GetLength(1);
            int height = grid.GetLength(0);

            LifeGrid = new int[height, widht];
            LifeGrid = grid;
        }

        private void PlayingAreaInvalidate()
        {
            playingArea.Invalidate();
        }

        private void Button_ClearArea_Click(object sender, EventArgs e)
        {
            TimerStop();
            Generation = 0;
            SaveToLifeGrid(new int[LifeSizeHeight, LifeSizeWidth]);
            RefreshLabels();
            PlayingAreaInvalidate();
        }
        private void Button_RandomFiling_Click(object sender, EventArgs e)
        {
            TimerStop();
            Generation = 0;
            SaveToLifeGrid(RandomGrid(LifeSizeWidth, LifeSizeHeight));
            RefreshLabels();
            PlayingAreaInvalidate();
        }

        // generates random grid
        private int[,] RandomGrid(int height, int width)
        {
            int[,] grid = new int[height, width];
            Random random = new Random();
            for (int i = 0; i < width; ++i)
                grid[0, i] = 1;// random.Next(1, 100) % 2;


            for (int i = 1; i < height; ++i)
                for (int j = 0; j < width; ++j)
                    grid[i, j] = random.Next(1, 100) % 2;

            return grid;
        }

        // sets new value into labels
        public void RefreshLabels()
        {
            label_Generation.Text = Generation.ToString();
            Population = CalculateCells(LifeGrid, Cells.LIVE_CELL);
            label_Population.Text = Population.ToString();

            label_Created.Text = CalculateCells(LifeGrid, Cells.CREATED_CELL).ToString();
            label_Died.Text = CalculateCells(LifeGrid, Cells.DIED_CELL).ToString();
        }

        // counts and return this count of typed cells in input grid
        private int CalculateCells(int[,] grid, int type)
        {
            int count = 0;

            for (int i = 0; i < LifeSizeHeight; ++i)
            {
                for (int j = 0; j < LifeSizeWidth; ++j)
                {
                    if (type == Cells.LIVE_CELL)
                    {
                        if (grid[i, j] == Cells.LIVE_CELL || grid[i, j] == Cells.CREATED_CELL)
                        {
                            ++count;
                        }
                    }
                    else
                    {
                        if (grid[i, j] == type)
                        {
                            ++count;
                        }
                    }
                }
            }
            return count;
        }

        private void Button_StartTime_Click(object sender, EventArgs e)
        {
            SetTimerInterval();
            if (timer1.Enabled) TimerStop();
            else TimerStart();
        }
        private void TrackBar_TimerTick_Scroll(object sender, EventArgs e)
        {
            SetTimerInterval();
        }

        // set timer interval (update speed)
        private void SetTimerInterval()
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

        private void Button_NextTick_Click(object sender, EventArgs e)
        {
            NextTick();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            NextTick();
        }

        // create next generation or initializes new grid generation
        public void NextTick()
        {
            try
            {
                if (LifeGrid.GetLength(0) < trackBar_AreaSize.Minimum)
                { // LifeGrid doesn't initialized
                    throw new NullReferenceException();
                }
                if (Population == 0)
                {
                    if (Generation == 0)
                        throw new NullReferenceException();

                    TimerStop();
                    MessageBox.Show("Гру закінчено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                NextGeneration();
                return;
            }
            catch (NullReferenceException)
            {
                SaveToLifeGrid(RandomGrid(LifeSizeHeight, LifeSizeWidth));
                RefreshLabels();
                PlayingAreaInvalidate();
            }
        }

        private void TrackBar_AreaSize_Scroll(object sender, EventArgs e)
        {
            SetGridSize();
        }

        private void SetGridSize()
        {
            bool timerWasWorking = timer1.Enabled;
            TimerStop();

            LifeSizeHeight = trackBar_AreaSize.Value;
            LifeSizeWidth = trackBar_AreaSize.Value;

            try
            {
                LifeGrid = ChangeSize(LifeGrid, LifeSizeHeight, LifeSizeWidth);
            }
            catch (NullReferenceException)
            {
                SaveToLifeGrid(new int[LifeSizeHeight, LifeSizeWidth]);
            }
            finally
            {
                PlayingAreaInvalidate();
                RefreshLabels();
            }

            if (timerWasWorking) TimerStart();
        }

        // changes grid size
        private int[,] ChangeSize(int[,] grid, int height, int width)
        {
            int[,] gridCopy = grid;
            int oldHeight = grid.GetLength(0);
            int oldWidth = grid.GetLength(1);
            grid = new int[height, width];

            for (int i = 0; i < oldHeight && i < height; ++i)
                for (int j = 0; j < oldWidth && j < width; ++j)
                    grid[i, j] = gridCopy[i, j];

            return grid;
        }


        private void CheckBox_Display_CheckedChanged(object sender, EventArgs e)
        {
            PlayingAreaInvalidate();
        }

        
        private void Button_SetDefaultColors_Click(object sender, EventArgs e)
        {
            playingArea.SetDefaultColors();
            PlayingAreaInvalidate();
        }

        private void PictureBox_SelectColor_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (colorDialog_SelectColor.ShowDialog() == DialogResult.Cancel)
                return;

            pictureBox.BackColor = colorDialog_SelectColor.Color;

            PlayingAreaInvalidate();
        }

        private void PictureBox_AreaBackground_BackColorChanged(object sender, EventArgs e)
        {
            playingArea.BackColor = pictureBox_AreaBackground.BackColor;
        }

        private void PictureBox_Grid_BackColorChanged(object sender, EventArgs e)
        {
            playingArea.GridColor = pictureBox_Grid.BackColor;
        }

        private void PictureBox_DeadCell_BackColorChanged(object sender, EventArgs e)
        {
            playingArea.DiedColor = pictureBox_DeadCell.BackColor;
        }

        private void PictureBox_CreatedCell_BackColorChanged(object sender, EventArgs e)
        {
            playingArea.CreateColor = pictureBox_CreatedCell.BackColor;
        }

        private void PictureBox_LivingCell_BackColorChanged(object sender, EventArgs e)
        {
            playingArea.LiveColor = pictureBox_LivingCell.BackColor;
        }
    }
}
