using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Game_of_life
{
    public partial class PlayingArea : UserControl
    {
        private static Color DEFAULT_BACK_COLOR = Color.Silver;
        private static Color DEFAULT_GRID_COLOR = Color.DimGray;
        private static Color DEFAULT_DIED_COLOR = Color.Salmon;
        private static Color DEFAULT_LIVE_COLOR = Color.PaleGreen;
        private static Color DEFAULT_CREATE_COLOR = Color.LimeGreen;

        public Color GridColor { get; set; }
        public Color DiedColor { get; set; }
        public Color LiveColor { get; set; }
        public Color CreateColor { get; set; }

        private MainWindow main;

        public PlayingArea(MainWindow mainWindow)
        {
            InitializeComponent();

            main = mainWindow;
            BackColor = DEFAULT_BACK_COLOR;

            SetDefaultColors();
        }

        public void SetDefaultColors()
        {
            BackColor = DEFAULT_BACK_COLOR;

            GridColor = DEFAULT_GRID_COLOR;
            DiedColor = DEFAULT_DIED_COLOR;
            LiveColor = DEFAULT_LIVE_COLOR;
            CreateColor = DEFAULT_CREATE_COLOR;

            main.pictureBox_AreaBackground.BackColor = DEFAULT_BACK_COLOR;

            main.pictureBox_Grid.BackColor = DEFAULT_GRID_COLOR;
            main.pictureBox_DeadCell.BackColor = DEFAULT_DIED_COLOR;
            main.pictureBox_LivingCell.BackColor = DEFAULT_LIVE_COLOR;
            main.pictureBox_CreatedCell.BackColor = DEFAULT_CREATE_COLOR;
        }

        // drawing cells and grid in panel
        private void DrawGrid(Graphics graphics)
        {
            if (main.checkBox_DisplayGrid.Checked)
            {
                Pen gridPan = new Pen(GridColor, 1);

                // multiply by 2 because one line have 2 ponts
                PointF[] points = new PointF[main.LifeSizeWidth * 2];
                byte[] types = new byte[main.LifeSizeWidth * 2];
                float point = 0;
                for (int i = 0; i < points.GetLength(0) - 1; i += 2, point += ((float)Height / main.LifeSizeHeight))
                {
                    points[i] = new PointF(point, 0);
                    points[i + 1] = new PointF(point, Height);

                    types[i] = 0; // start point
                    types[i + 1] = 1; // line
                }
                graphics.DrawPath(gridPan, new GraphicsPath(points, types));

                points = new PointF[main.LifeSizeHeight * 2];
                types = new byte[main.LifeSizeHeight * 2];
                point = 0;
                for (int i = 0; i < points.GetLength(0) - 1; i += 2, point += ((float)Width / main.LifeSizeWidth))
                {
                    points[i] = new PointF(0, point);
                    points[i + 1] = new PointF(Width, point);

                    types[i] = 0;
                    types[i + 1] = 1;
                }
                graphics.DrawPath(gridPan, new GraphicsPath(points, types));
            }
        }
        private void DrawCell(Graphics graphics)
        {
            float currentHeight = 0;
            float currentWigth = 0;

            float cellHeight = (float)Height / main.LifeSizeHeight;
            float cellWidth = (float)Width / main.LifeSizeWidth;

            for (int i = 0; i < main.LifeSizeHeight; ++i)
            {
                for (int j = 0; j < main.LifeSizeWidth; ++j)
                {
                    if (main.LifeGrid[i, j] == Cells.DIED_CELL && main.checkBox_ShowDeadCell.Checked)
                        graphics.FillRectangle(new SolidBrush(DiedColor), currentWigth + 0.5F, currentHeight + 0.5F, cellWidth - 1, cellHeight - 1);
                    if (main.LifeGrid[i, j] == Cells.EMPTY_CELL)
                        graphics.FillRectangle(new SolidBrush(BackColor), currentWigth + 0.5F, currentHeight + 0.5F, cellWidth - 1, cellHeight - 1);
                    if (main.LifeGrid[i, j] == Cells.LIVE_CELL || (main.LifeGrid[i, j] == Cells.CREATED_CELL && !main.checkBox_ShowCreatedCell.Checked))
                        graphics.FillRectangle(new SolidBrush(LiveColor), currentWigth + 0.5F, currentHeight + 0.5F, cellWidth - 1, cellHeight - 1);
                    if (main.LifeGrid[i, j] == Cells.CREATED_CELL && main.checkBox_ShowCreatedCell.Checked)
                        graphics.FillRectangle(new SolidBrush(CreateColor), currentWigth + 0.5F, currentHeight + 0.5F, cellWidth - 1, cellHeight - 1);


                    currentHeight += cellHeight;
                }
                currentWigth += cellWidth;
                currentHeight = 0;
            }
        }

        private void PlayingArea_Paint(object sender, PaintEventArgs e)
        {
            DrawCell(e.Graphics);
            DrawGrid(e.Graphics);
        }

        private void PlayingArea_MouseClick(object sender, MouseEventArgs e)
        {
            float cellWidth = (float)Width / main.LifeSizeWidth;
            float cellHeight = (float)Height / main.LifeSizeHeight;

            // TODO : fix adding elements

            int row = e.X / (int)cellHeight;
            int col = e.Y / (int)cellWidth;

            try
            {
                main.LifeGrid[row, col] = main.LifeGrid[row, col];

                if (main.LifeGrid[row, col] == Cells.EMPTY_CELL || main.LifeGrid[row, col] == Cells.DIED_CELL)
                {
                    main.LifeGrid[row, col] = Cells.LIVE_CELL;
                }
                else
                {
                    main.LifeGrid[row, col] = Cells.EMPTY_CELL; // Cells.LIVE_CELL or Cells.CREATED_CELL
                }

                main.RefreshLabels();
                Draw();
            }
            catch (NullReferenceException) // when array doesn't initialized
            {
                main.SaveToLifeGrid(new int[main.LifeSizeHeight, main.LifeSizeWidth]);
                return;
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }

        private void Draw()
        {
            Invalidate();
        }
    }
}
