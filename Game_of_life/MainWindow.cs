﻿using System;
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
    public class AreaCanvas
    {
        private Panel panel;
        public Panel Panel
        {
            set
            {
                panel = value;
            }
        }




        //private 
    }

    public partial class MainWindow : Form
    {
        private const float PANEL_HEIGHT = 600.0F;
        private const float PANEL_WIDTH = 600.0F;

        private const int DIED_CELL = -1;
        private const int EMPTY_CELL = 0;
        private const int LIVE_CELL = 1;
        private const int CREATED_CELL = 2;

        private int LifeSizeHeight;
        private int LifeSizeWidth;

        //GetLenth 0-width  1-heigth
        private int[,] LifeGrid;
        private int Generation;
        private int Population;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LifeSizeHeight = 30;
            LifeSizeWidth = 30;

            Generation = 0;
            Population = 0;

            LifeGrid = new int[LifeSizeHeight, LifeSizeWidth];

            panel_PlaingArea.Height = (int)PANEL_HEIGHT;
            panel_PlaingArea.Width = (int)PANEL_WIDTH;

            RefreshLabels(LifeGrid);
        }

        // main game logic
        private void NextGeneration(int[,] grid)
        {
            ++Generation;

            int[,] future = new int[LifeSizeHeight, LifeSizeWidth];

            grid = RevertToEmptyAndLiveCells(grid);

            for (int line = 0; line < LifeSizeHeight; ++line)
            {
                for (int column = 0; column < LifeSizeWidth; ++column)
                {
                    int aliveNeighbours = 0;
                    for (int i = -1; i <= 1; ++i)
                        for (int j = -1; j <= 1; ++j)
                        {
                            int row = line + i;
                            int col = column + j;

                            if (col == -1) col = LifeSizeHeight - 1; // above grid limit
                            if (row == -1) row = LifeSizeWidth - 1; // on the left limit

                            if (col == LifeSizeHeight) col = 0; // lower grid limit
                            if (row == LifeSizeWidth) row = 0; // on the right limit

                            aliveNeighbours += (int)grid[row, col];
                        }

                    aliveNeighbours -= (int)grid[line, column];

                    // Implementing the Rules of Life 

                    // Cell is lonely and dies 
                    if ((grid[line, column] == LIVE_CELL) && (aliveNeighbours < 2))
                    {
                        future[line, column] = DIED_CELL;
                    }
                    // Cell dies due to over population 
                    else if ((grid[line, column] == LIVE_CELL) && (aliveNeighbours > 3))
                    {
                        future[line, column] = DIED_CELL;
                    }
                    // A new cell is born 
                    else if ((grid[line, column] == EMPTY_CELL) && (aliveNeighbours == 3))
                    {
                        future[line, column] = CREATED_CELL;
                    }
                    // Remains the same 
                    else future[line, column] = grid[line, column];
                }
            }
            DrawCanvas(future);
            SaveToLifeGrid(future);
            RefreshLabels(future);
        }

        // replace DIED_CELL with EMPTY_CELL
        // replace CREATED_CELL with LIVE_CELL
        private int[,] RevertToEmptyAndLiveCells(int[,] grid)
        {
            int widht = grid.GetLength(0);
            int height = grid.GetLength(1);
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < widht; ++j)
                {
                    if (grid[i, j] == DIED_CELL) grid[i, j] = EMPTY_CELL;
                    else if (grid[i, j] == CREATED_CELL) grid[i, j] = LIVE_CELL;
                }
            }

            return grid;
        }
        // copies input grid in Global grid
        private void SaveToLifeGrid(int[,] grid)
        {
            int widht = grid.GetLength(0);
            int height = grid.GetLength(1);

            LifeGrid = new int[height, widht];
            LifeGrid = grid;
        }

        #region canva
        private void DrawCanvas(int[,] grid)
        {
            // TODO : Drawing
            /*
             * crate graphcis
             * grid size (length) (send Draw)
             * 
             * get GraphicsPath and use in graphics
             * 
             */
            try
            {
                panel_PlaingArea.Refresh();

                Graphics graphics = panel_PlaingArea.CreateGraphics();

                DrawCell(graphics, grid, EMPTY_CELL);
                DrawCell(graphics, grid, DIED_CELL);
                DrawCell(graphics, grid, LIVE_CELL);
                DrawCell(graphics, grid, CREATED_CELL);

                DrawGrid(graphics);

                graphics.Dispose();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        // draws cells from Grid
        private void DrawCell(Graphics graphics, int[,] grid, int type)
        {
            SolidBrush brush = new SolidBrush(Color.Empty);

            if (checkBox_ShowDeadCell.Checked && type == DIED_CELL)
                brush.Color = pictureBox_DeadCell.BackColor;

            else if (type == EMPTY_CELL)
                brush.Color = pictureBox_AreaBackground.BackColor;

            else if (type == LIVE_CELL)
                brush.Color = pictureBox_LivingCell.BackColor;

            else if (checkBox_ShowCreatedCell.Checked && type == CREATED_CELL)
                brush.Color = pictureBox_CreatedCell.BackColor;

            else return;

            float currentHeight = 0;
            float currentWigth = 0;

            float cellHeight = PANEL_HEIGHT / LifeSizeHeight;
            float cellWidth = PANEL_WIDTH / LifeSizeWidth;

            for (int i = 0; i < LifeSizeHeight; ++i)
            {
                for (int j = 0; j < LifeSizeWidth; ++j)
                {
                    if ((type == LIVE_CELL) && (grid[i, j] == LIVE_CELL || grid[i, j] == CREATED_CELL))
                    {
                        graphics.FillRectangle(brush,
                           currentWigth, currentHeight,
                           cellWidth, cellHeight);
                    }
                    else if (grid[i, j] == type)
                    {
                        graphics.FillRectangle(brush,
                           currentWigth, currentHeight,
                           cellWidth, cellHeight);
                    }
                    // for debuging or showing grid content
                    if (checkBox19.Checked)
                    {
                        graphics.DrawString(grid[i, j].ToString(),
                            new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                            new SolidBrush(Color.Red),
                            currentWigth + 4,
                            currentHeight + 4);
                    }
                    currentHeight += cellHeight;
                }
                currentWigth += cellWidth;
                currentHeight = 0;
            }
        }

        // drawing cells and grid in panel
        private void DrawGrid(Graphics graphics)
        {
            if (checkBox_DisplayGrid.Checked)
            {
                Pen gridPan = new Pen(pictureBox_Grid.BackColor, 1);

                // multiply by 2 because one line have 2 ponts
                PointF[] points = new PointF[LifeSizeWidth * 2];
                byte[] types = new byte[LifeSizeWidth * 2];
                float point = 0;
                for (int i = 0; i < points.GetLength(0) - 1; i += 2, point += (PANEL_HEIGHT / LifeSizeHeight))
                {
                    points[i] = new PointF(point, 0);
                    points[i + 1] = new PointF(point, PANEL_HEIGHT);

                    types[i] = 0; // start point
                    types[i + 1] = 1; // line
                }
                graphics.DrawPath(gridPan, new GraphicsPath(points, types));

                points = new PointF[LifeSizeHeight * 2];
                types = new byte[LifeSizeHeight * 2];
                point = 0;
                for (int i = 0; i < points.GetLength(0) - 1; i += 2, point += (PANEL_WIDTH / LifeSizeWidth))
                {
                    points[i] = new PointF(0, point);
                    points[i + 1] = new PointF(PANEL_WIDTH, point);

                    types[i] = 0;
                    types[i + 1] = 1;
                }
                graphics.DrawPath(gridPan, new GraphicsPath(points, types));
            }
        }
        #endregion


        private void Button_ClearArea_Click(object sender, EventArgs e)
        {
            TimerStop();
            Generation = 0;
            SaveToLifeGrid(new int[LifeSizeHeight, LifeSizeWidth]);
            RefreshLabels(LifeGrid);
            DrawCanvas(LifeGrid);
        }
        private void Button_RandomFiling_Click(object sender, EventArgs e)
        {
            TimerStop();
            Generation = 0;
            SaveToLifeGrid(RandomGrid(LifeSizeWidth, LifeSizeHeight));
            RefreshLabels(LifeGrid);
            DrawCanvas(LifeGrid);
        }

        // generates random grid
        private int[,] RandomGrid(int width, int height)
        {
            int[,] grid = new int[height, width];
            Random random = new Random();

            for (int i = 0; i < height; ++i)
                for (int j = 0; j < width; ++j)
                    grid[i, j] = 0;// TODO random.Next(1, 100) % 2;

            return grid;
        }

        // sets new value into labels
        private void RefreshLabels(int[,] grid)
        {
            label_Generation.Text = Generation.ToString();
            Population = CalculateCells(grid, LIVE_CELL);
            label_Population.Text = Population.ToString();

            label_Created.Text = CalculateCells(grid, CREATED_CELL).ToString();
            label_Died.Text = CalculateCells(grid, DIED_CELL).ToString();
        }
        // counts and return this count of typed cells in input grid
        private int CalculateCells(int[,] grid, int type)
        {
            int count = 0;

            for (int i = 0; i < LifeSizeHeight; ++i)
            {
                for (int j = 0; j < LifeSizeWidth; ++j)
                {
                    if (type == LIVE_CELL)
                    {
                        if (grid[i, j] == LIVE_CELL || grid[i, j] == CREATED_CELL)
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
        private void NextTick()
        {
            try
            {
                if (LifeGrid.GetLength(0) < trackBar_AreaSize.Minimum)
                { // LifeGrid doesn't initialized
                    throw new NullReferenceException();
                }
                if (Population == 0)
                {
                    throw new NullReferenceException();
                }
                NextGeneration(LifeGrid);
                return;
            }
            catch (NullReferenceException)
            {
                SaveToLifeGrid(RandomGrid(LifeSizeWidth, LifeSizeHeight));
                RefreshLabels(LifeGrid);
                DrawCanvas(LifeGrid);
            }
        }

        private void TrackBar_AreaSize_Scroll(object sender, EventArgs e)
        {
            bool timerWasWorking = timer1.Enabled;
            TimerStop();

            LifeSizeHeight = trackBar_AreaSize.Value;
            LifeSizeWidth = trackBar_AreaSize.Value;

            try
            {
                LifeGrid = ChangeSize(LifeGrid, LifeSizeWidth, LifeSizeHeight);
                DrawCanvas(LifeGrid);
            }
            catch (NullReferenceException)
            {
                SaveToLifeGrid(new int[LifeSizeHeight, LifeSizeWidth]);
                DrawCanvas(LifeGrid);
            }
            finally
            {
                RefreshLabels(LifeGrid);
            }

            if (timerWasWorking) TimerStart();
        }
        // changes grid size
        private int[,] ChangeSize(int[,] grid, int width, int height)
        {
            int[,] gridCopy = grid;
            int oldHeight = grid.GetLength(1);
            int oldWidth = grid.GetLength(0);
            grid = new int[height, width];

            for (int i = 0; i < oldHeight && i < height; ++i)
                for (int j = 0; j < oldWidth && j < width; ++j)
                    grid[i, j] = gridCopy[i, j];

            return grid;
        }

        // add or remove cell from grid
        private void Panel_PlaingArea_MouseClick(object sender, MouseEventArgs e)
        {
            int cellWidth = panel_PlaingArea.Width / LifeSizeWidth;
            int cellHeight = panel_PlaingArea.Height / LifeSizeHeight;

            int row = e.X / cellHeight;
            int col = e.Y / cellWidth;

            try
            {
                LifeGrid[row, col] = LifeGrid[row, col];

                if (LifeGrid[row, col] == EMPTY_CELL || LifeGrid[row, col] == DIED_CELL)
                {
                    LifeGrid[row, col] = LIVE_CELL;
                }
                else
                {
                    LifeGrid[row, col] = EMPTY_CELL; // LIVE_CELL or CREATED_CELL
                }

                RefreshLabels(LifeGrid);
                DrawCanvas(LifeGrid);
            }
            catch (NullReferenceException) // when array doesn't initialized
            {
                SaveToLifeGrid(new int[LifeSizeHeight, LifeSizeWidth]);
                return;
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }



        private void PictureBox_SelectColor_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (colorDialog_SelectColor.ShowDialog() == DialogResult.Cancel)
                return;

            pictureBox.BackColor = colorDialog_SelectColor.Color;
            DrawCanvas(LifeGrid);
        }


        private void CheckBox_Display_CheckedChanged(object sender, EventArgs e)
        {
            DrawCanvas(LifeGrid);
        }
    }
}
