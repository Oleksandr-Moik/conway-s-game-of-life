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
    public class LifeArea
    {
        public int TickSpeed { get; set; }
        public int Size { get; set; }
        public Color GridColor { get; set; }
        public Color DiedCellColor { get; set; }
        public Color LivingCellColor { get; set; }
        public Color CreatedCellColor { get; set; }
        public Color AreaColor { get; set; }
        public Panel PlayingArea { get; set; }

        private int[,] presentArea;
        private int[,] nextArea;

        public void updateAreaColor()
        {
            PlayingArea.BackColor = AreaColor;
        }

        public void drawGrid()
        {
            PlayingArea.Refresh();
            drawCell();

            Graphics dc = PlayingArea.CreateGraphics();
            Pen gridPan = new Pen(GridColor, 1);

            int width = PlayingArea.Width;
            int height = PlayingArea.Height;

            for (int i = 0; i <= width; i += (width / Size))
            {
                dc.DrawLine(gridPan, new Point(i, 0), new Point(i, height));
                dc.DrawLine(gridPan, new Point(0, i), new Point(width, i));
            }

            dc.Dispose();
        }
        public void clearGrid()
        {
            PlayingArea.Refresh();
            GridColor = Color.Transparent;
            drawCell();
        }

        public void drawCell()
        {
            int width = PlayingArea.Width / Size;
            int height = PlayingArea.Height / Size;

            Graphics dc = PlayingArea.CreateGraphics();
            SolidBrush livingBrush = new SolidBrush(LivingCellColor);

            int currentHeight = 0;
            int currentWigth = 0;

            for (int i = 0; i < Size; ++i)
            {
                currentWigth += height;
                for (int j = 0; j < Size; ++j)
                {
                    currentHeight += width;
                    if (presentArea[i, j] == 0)
                        dc.FillRectangle(livingBrush,
                            currentHeight, currentWigth,
                            width, height);
                }
                currentHeight = 0;
            }
            dc.Dispose();
        }
    }
}
