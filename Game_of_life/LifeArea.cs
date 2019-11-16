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
        public Color GridColor { get; set; }
        public Color DiedCellColor { get; set; }
        public Color LivingCellColor { get; set; }
        public Color CreatedCellColor { get; set; }
        public Color AreaColor { get; set; }
        public Panel PlayingArea { get; set; }

        public LifeArea(AreaBuilder builder)
        {
            TickSpeed = builder.TickSpeed;
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


        public class AreaBuilder
        {
            public int TickSpeed;
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
