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
        
        private MainWindow main;
        private int[,] LifeGrid;
        private Size LifeGridSize;
        private float CellSizeWidth;
        private float CellSizeHeight;
        // add point
        private bool IsMouseDown;
        private int lastX;
        private int lastY;

        public Color GridColor { get; set; }
        public Color DiedColor { get; set; }
        public Color LiveColor { get; set; }
        public Color CreateColor { get; set; }


        public PlayingArea(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }

        private void PlayingArea_Load(object sender, EventArgs e)
        {
            BackColor = DEFAULT_BACK_COLOR;
            SetDefaultColors();

            lastX = -1;
            lastY = -1;
            IsMouseDown = false;
        }

        public void SetLifeGrid(int[,] grid, Size size)
        {
            LifeGrid = grid;

            SetLifeSize(size);
            SetCellSize(LifeGridSize);
        }

        private void SetCellSize(Size size)
        {
            CellSizeWidth = (float)Width / size.Width;
            CellSizeHeight = (float)Height / size.Height;
        }

        private void SetLifeSize(Size size)
        {
            LifeGridSize = size;
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

       

        private void PlayingArea_Paint(object sender, PaintEventArgs e)
        {
            DrawCell(e.Graphics);
            DrawGrid(e.Graphics);
        }

        private void PlayingArea_MouseClick(object sender, MouseEventArgs e)
        {
            AddPoint(PointInGrid(e));
        }

        private void PlayingArea_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
        }
        private void PlayingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                // -1 для коригування координат
                // перед виходом 

                Point point = PointInGrid(e);

                if (lastX!=point.X || lastY != point.Y)
                {
                    AddPoint(point);
                }
            }
        }
        private void PlayingArea_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            Invalidate();
        }

        private Point PointInGrid(MouseEventArgs e)
        {
            int h = -1;
            float i = 0;
            do
            {
                ++h;
                i += CellSizeHeight;
            } while (i <= e.Y);

            int w = -1;
            i = 0;
            do
            {
                ++w;
                i += CellSizeWidth;
            } while (i <= e.X);
            return new Point(h, w);
        }
        private void AddPoint(Point point)
        {
            lastX = point.X;
            lastY = point.Y;
            try
            {
                Graphics g = CreateGraphics();
                if (LifeGrid[lastX, lastY] == Cells.EMPTY_CELL || LifeGrid[lastX, lastY] == Cells.DIED_CELL)
                {
                    LifeGrid[lastX, lastY] = Cells.LIVE_CELL;
                    g.FillRectangle(new SolidBrush(LiveColor), CellSizeWidth * lastY + 0.5F, CellSizeHeight * lastX + 0.5F, CellSizeWidth - 1, CellSizeHeight - 1);
                }
                else
                {
                    LifeGrid[lastX, lastY] = Cells.EMPTY_CELL; // Cells.LIVE_CELL or Cells.CREATED_CELL
                    g.FillRectangle(new SolidBrush(BackColor), CellSizeWidth * lastY + 0.5F, CellSizeHeight * lastX + 0.5F, CellSizeWidth - 1, CellSizeHeight - 1);
                }
            }
            catch (NullReferenceException) // when array doesn't initialized
            {
                SetLifeGrid(new int[LifeGridSize.Height, LifeGridSize.Width], LifeGridSize);
            }
            finally
            {
                main.SetLifeGrid(LifeGrid, LifeGridSize);
                main.RefreshLabels(LifeGrid, LifeGridSize);
            }
        }
        // drawing cells and grid in panel
        private void DrawGrid(Graphics graphics)
        {
            if (main.checkBox_DisplayGrid.Checked)
            {
                Pen gridPan = new Pen(GridColor, 1);

                // multiply by 2 because one line have 2 ponts
                PointF[] points = new PointF[LifeGridSize.Width * 2];
                byte[] types = new byte[LifeGridSize.Width * 2];
                float point = 0;
                // vertival lines
                for (int column = 0; column < points.GetLength(0) - 1; column += 2, point += ((float)Width / LifeGridSize.Width))
                {
                    points[column] = new PointF(point, 0);
                    points[column + 1] = new PointF(point, Height);

                    types[column] = 0; // start point
                    types[column + 1] = 1; // line
                }
                // debug
                graphics.DrawPath(gridPan, new GraphicsPath(points, types));
                //graphics.DrawPath(Pens.Red, new GraphicsPath(points, types));

                points = new PointF[LifeGridSize.Height * 2];
                types = new byte[LifeGridSize.Height * 2];
                point = 0;
                // horizontal lines
                for (int row = 0; row < points.GetLength(0) - 1; row += 2, point += ((float)Height / LifeGridSize.Height))
                {
                    points[row] = new PointF(0, point);
                    points[row + 1] = new PointF(Width, point);

                    types[row] = 0;
                    types[row + 1] = 1;
                }
                // debug
                graphics.DrawPath(gridPan, new GraphicsPath(points, types));
                //graphics.DrawPath(Pens.White, new GraphicsPath(points, types));
            }
        }
        private void DrawCell(Graphics graphics)
        {
            float currentHeight = 0;
            float currentWigth = 0;

            for (int row = 0; row < LifeGridSize.Height; ++row)
            {
                for (int col = 0; col < LifeGridSize.Width; ++col)
                {
                    if (LifeGrid[row, col] == Cells.DIED_CELL && main.checkBox_ShowDeadCell.Checked)
                        graphics.FillRectangle(new SolidBrush(DiedColor), currentWigth + 0.5F, currentHeight + 0.5F, CellSizeWidth - 1, CellSizeHeight - 1);
                    if (LifeGrid[row, col] == Cells.EMPTY_CELL)
                        graphics.FillRectangle(new SolidBrush(BackColor), currentWigth + 0.5F, currentHeight + 0.5F, CellSizeWidth - 1, CellSizeHeight - 1);
                    if (LifeGrid[row, col] == Cells.LIVE_CELL || (LifeGrid[row, col] == Cells.CREATED_CELL && !main.checkBox_ShowCreatedCell.Checked))
                        graphics.FillRectangle(new SolidBrush(LiveColor), currentWigth + 0.5F, currentHeight + 0.5F, CellSizeWidth - 1, CellSizeHeight - 1);
                    if (LifeGrid[row, col] == Cells.CREATED_CELL && main.checkBox_ShowCreatedCell.Checked)
                        graphics.FillRectangle(new SolidBrush(CreateColor), currentWigth + 0.5F, currentHeight + 0.5F, CellSizeWidth - 1, CellSizeHeight - 1);

                    // debug
                    //graphics.DrawString($"r{row} c{col}", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.Red), currentWigth + 0.5F, currentHeight + 0.5F);
                    //graphics.DrawString($"t {main.LifeGrid[row, col]}", new Font(FontFamily.GenericMonospace, 10), new SolidBrush(Color.Red), currentWigth + 0.5F, currentHeight + 0.5F + 10);
                    currentWigth += CellSizeWidth;
                }
                currentHeight += CellSizeHeight;
                currentWigth = 0;
            }
        }
    }
}
