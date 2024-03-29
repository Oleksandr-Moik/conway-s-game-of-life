﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        public Size LifeGridSize;

        public int Generation;
        public int Population;

        PlayingArea playingArea;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Size ScreenSize = Screen.PrimaryScreen.Bounds.Size;
            if (ScreenSize.Height < Size.Height) SmalScreenResolution();

            panel_PlaingArea.Height = PANEL_HEIGHT;
            panel_PlaingArea.Width = PANEL_WIDTH;
            
            playingArea = new PlayingArea(this);
            playingArea.Parent = panel_PlaingArea;
            playingArea.Size = panel_PlaingArea.Size;
            playingArea.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left |
                AnchorStyles.Right | AnchorStyles.Top);

            SetLifeGridSize();
            playingArea.SetLifeGrid(LifeGrid, LifeGridSize);
        }

        private void SmalScreenResolution()
        {
            DialogResult result = MessageBox.Show("Розміри Вашого основного екрану меші за розмір вікна гри. \n \n" +
                "Продовжити користування чи завершити програму?", "Попередження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) return;
            else Close();
        }

        // main life game logic
        private void NextGeneration(int[,] grid, Size size)
        {
            ++Generation;

            int[,] future = new int[size.Height, size.Width];

            grid = RevertToEmptyAndLiveCells(grid, size);

            for (int Row = 0; Row < size.Height; ++Row)
            {
                for (int Column = 0; Column < size.Width; ++Column)
                {
                    int aliveNeighbours = 0;
                    for (int i = -1; i <= 1; ++i)
                    {
                        for (int j = -1; j <= 1; ++j)
                        {
                            int row = Row + i;
                            int col = Column + j;

                            if (col == -1) col = size.Width - 1; // above grid limit
                            if (row == -1) row = size.Height - 1; // on the left limit

                            if (col == size.Width) col = 0; // lower grid limit
                            if (row == size.Height) row = 0; // on the right limit

                            aliveNeighbours += grid[row, col];
                        }
                    }
                    aliveNeighbours -= grid[Row, Column];

                    // Implementing the Rules of Life 

                    // Cell is lonely and dies 
                    if ((grid[Row, Column] == Cells.LIVE_CELL) && (aliveNeighbours < 2))
                    {
                        future[Row, Column] = Cells.DIED_CELL;
                    }
                    // Cell dies due to over population 
                    else if ((grid[Row, Column] == Cells.LIVE_CELL) && (aliveNeighbours > 3))
                    {
                        future[Row, Column] = Cells.DIED_CELL;
                    }
                    // A new cell is born 
                    else if ((grid[Row, Column] == Cells.EMPTY_CELL) && (aliveNeighbours == 3))
                    {
                        future[Row, Column] = Cells.CREATED_CELL;
                    }
                    // Remains the same 
                    else future[Row, Column] = LifeGrid[Row, Column];
                }
            }
            SetLifeGrid(future, LifeGridSize);
            PlayingAreaInvalidate(future, LifeGridSize);
            RefreshLabels(future, LifeGridSize);
        }

        /* replace Cells.DIED_CELL with Cells.EMPTY_CELL
         * replace Cells.CREATED_CELL with Cells.LIVE_CELL
         */
        private int[,] RevertToEmptyAndLiveCells(int[,] grid, Size size)
        {
            for (int i = 0; i < size.Height; ++i)
            {
                for (int j = 0; j < size.Width; ++j)
                {
                    if (grid[i, j] == Cells.DIED_CELL) grid[i, j] = Cells.EMPTY_CELL;
                    else if (grid[i, j] == Cells.CREATED_CELL) grid[i, j] = Cells.LIVE_CELL;
                }
            }

            return grid;
        }

        // copies input grid in Global grid
        public void SetLifeGrid(int[,] grid, Size size)
        {
            LifeGrid = new int[size.Height, size.Width];
            LifeGrid = grid;
        }

        private void PlayingAreaInvalidate(int[,] grid, Size size)
        {
            playingArea.SetLifeGrid(grid, size);
            playingArea.Invalidate();
        }

        private void Button_ClearArea_Click(object sender, EventArgs e)
        {
            TimerStop();
            Generation = 0;
            SetLifeGrid( new int[LifeGridSize.Height, LifeGridSize.Width], LifeGridSize);
            RefreshLabels(LifeGrid, LifeGridSize);
            PlayingAreaInvalidate(LifeGrid, LifeGridSize);
        }
        private void Button_RandomFiling_Click(object sender, EventArgs e)
        {
            TimerStop();
            Generation = 0;
            SetLifeGrid(RandomGrid(LifeGridSize.Width, LifeGridSize.Height), LifeGridSize);
            RefreshLabels(LifeGrid, LifeGridSize);
            PlayingAreaInvalidate(LifeGrid, LifeGridSize);
        }

        // generates random grid
        private int[,] RandomGrid(int height, int width)
        {
            int[,] grid = new int[height, width];
            Random random = new Random();
            
            for (int i = 0; i < height; ++i)
                for (int j = 0; j < width; ++j)
                    grid[i, j] = random.Next(1, 100) % 2;

            return grid;
        }

        // sets new value into labels
        public void RefreshLabels(int[,] grid, Size size)
        {
            label_Generation.Text = Generation.ToString();
            Population = CalculateCells(grid, size, Cells.LIVE_CELL);
            label_Population.Text = Population.ToString();

            label_Created.Text = CalculateCells(grid, size, Cells.CREATED_CELL).ToString();
            label_Died.Text = CalculateCells(grid, size, Cells.DIED_CELL).ToString();
        }

        // counts and return this count of typed cells in input grid
        private int CalculateCells(int[,] grid, Size size, int type)
        {
            int count = 0;

            for (int i = 0; i < size.Height; ++i)
            {
                for (int j = 0; j < size.Width; ++j)
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
                if (LifeGridSize.Height < trackBar_AreaSize.Minimum)
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
                NextGeneration(LifeGrid, LifeGridSize);
                return;
            }
            catch (NullReferenceException)
            {
                SetLifeGrid(RandomGrid(LifeGridSize.Height, LifeGridSize.Width), LifeGridSize);
                PlayingAreaInvalidate(LifeGrid, LifeGridSize);
                RefreshLabels(LifeGrid, LifeGridSize);
            }
        }

        private void TrackBar_AreaSize_Scroll(object sender, EventArgs e)
        {
            SetLifeGridSize();
            playingArea.SetLifeGrid(LifeGrid, LifeGridSize);
            PlayingAreaInvalidate(LifeGrid, LifeGridSize);
        }

        private void SetLifeGridSize()
        {
            bool timerWasWorking = timer1.Enabled;
            TimerStop();

            LifeGridSize.Height = trackBar_AreaSize.Value;
            LifeGridSize.Width = trackBar_AreaSize.Value;

            try
            {
                LifeGrid = ChangeSize(LifeGrid, LifeGridSize.Height, LifeGridSize.Width);
            }
            catch (NullReferenceException)
            {
                SetLifeGrid(new int[LifeGridSize.Height, LifeGridSize.Width], LifeGridSize);
            }
            finally
            {
                RefreshLabels(LifeGrid, LifeGridSize);
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
            PlayingAreaInvalidate(LifeGrid, LifeGridSize);
        }

        private void Button_SetDefaultColors_Click(object sender, EventArgs e)
        {
            playingArea.SetDefaultColors();
            PlayingAreaInvalidate(LifeGrid, LifeGridSize);
        }
        private void PictureBox_SelectColor_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (colorDialog_SelectColor.ShowDialog() == DialogResult.Cancel)
                return;

            pictureBox.BackColor = colorDialog_SelectColor.Color;

            PlayingAreaInvalidate(LifeGrid, LifeGridSize);
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

        private void завершитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void правилаГриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form from = new GameRulesHelp();
            from.ShowDialog(this);
            from.Dispose();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form from = new AboutGame();
            from.ShowDialog(this);
            from.Dispose();
        }

        private void Save_Pole(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("pole.txt", false, Encoding.Unicode);
            writer.WriteLine(LifeGridSize.Height);
            for (int i = 0; i < LifeGridSize.Height; ++i)
            {
                for (int j = 0; j < LifeGridSize.Height; ++j)
                    writer.Write(LifeGrid[i, j] + "|");
                writer.WriteLine();
            }
            writer.Close();
        }

        private void Load_Pole(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("pole.txt", Encoding.Unicode);
            int size = Convert.ToInt16(reader.ReadLine());
            trackBar_AreaSize.Value = size;
            SetLifeGridSize();
            playingArea.SetLifeGrid(LifeGrid, LifeGridSize);
            PlayingAreaInvalidate(LifeGrid, LifeGridSize);
            int[,] grid = new int[size, size];
            for (int i = 0; i < size; ++i)
            {
                string[] c =  reader.ReadLine().Split('|');
                for (int j = 0; j < size; ++j)
                {
                    grid[i, j] = Convert.ToInt32(c[j]);
                }
            }
            SetLifeGrid(grid, new Size(size,size));
            playingArea.SetLifeGrid(LifeGrid, LifeGridSize);
            PlayingAreaInvalidate(LifeGrid, LifeGridSize);
            reader.Close();
        }
    }
}
