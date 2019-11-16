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


        public LifeArea(AreaBuilder builder)
        {
            TickSpeed = builder.TickSpeed;
            Size = builder.Size;
            GridColor = builder.GridColor;
            DiedCellColor = builder.DiedCellColor;
            LivingCellColor = builder.LivingCellColor;
            CreatedCellColor = builder.CreatedCellColor;
            AreaColor = builder.AreaColor;
            PlayingArea = builder.PlayingArea;
        }

        public AreaBuilder builder()
        {
            return new AreaBuilder();
        }

        public void updateAreaColor()
        {
            PlayingArea.BackColor = AreaColor;
        }

        public void drawGrid()
        {
            PlayingArea.Refresh();
            randomFilling();
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

        public void randomFilling()
        {
            presentArea = new int[Size, Size];
            Random random = new Random();
            for (int i = 0; i < Size; ++i)
                for (int j = 0; j < Size; ++j)
                    presentArea[i, j] = random.Next(-5, 5);

            drawCell();
        }

        public void clearCells()
        {
            presentArea = new int[Size, Size];
            for (int i = 0; i < Size; ++i)
                for (int j = 0; j < Size; ++j)
                    presentArea[i, j] = -1;
        }

        public class AreaBuilder
        {
            public int TickSpeed;
            public int Size;
            public Color GridColor;
            public Color DiedCellColor;
            public Color LivingCellColor;
            public Color CreatedCellColor;
            public Color AreaColor;
            public Panel PlayingArea;

            public AreaBuilder tickSpeed(int tick)
            {
                TickSpeed = tick;
                return this;
            }
            public AreaBuilder size(int size)
            {
                Size = size;
                return this;
            }
            public AreaBuilder gridColor(Color color)
            {
                GridColor = color;
                return this;
            }
            public AreaBuilder diedCellColor(Color color)
            {
                DiedCellColor = color;
                return this;
            }
            public AreaBuilder livingCellColor(Color color)
            {
                LivingCellColor = color;
                return this;
            }
            public AreaBuilder createdCellColor(Color color)
            {
                CreatedCellColor = color;
                return this;
            }
            public AreaBuilder areaColor(Color color)
            {
                AreaColor = color;
                return this;
            }
            public AreaBuilder playingArea(Panel panel)
            {
                PlayingArea = panel;
                return this;
            }
            public LifeArea build()
            {
                return new LifeArea(this);
            }
        }
    }
}
