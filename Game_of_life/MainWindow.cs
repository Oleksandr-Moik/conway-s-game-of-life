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

        List<CheckBox> survivalRules;
        List<CheckBox> creationRules;

        private void MainWindow_Load(object sender, EventArgs e)
        {
            initCheckBoxList();
        }

        private void drawPlayingArea()
        {
            Graphics dc = panel_PlaingArea.CreateGraphics();

            Pen blackPen = new Pen(Color.Black, 2);

            Point startPoint = new Point(0, 0);
            Point endPoint = new Point(panel_PlaingArea.Width, panel_PlaingArea.Height);

            dc.DrawLine(blackPen, startPoint, endPoint);
        }

        private void initCheckBoxList()
        {
            survivalRules = new List<CheckBox>();
            this.survivalRules.Insert(0, checkBox1);
            this.survivalRules.Insert(1, checkBox2);
            this.survivalRules.Insert(2, checkBox3);
            this.survivalRules.Insert(3, checkBox4);
            this.survivalRules.Insert(4, checkBox5);
            this.survivalRules.Insert(5, checkBox6);
            this.survivalRules.Insert(6, checkBox7);
            this.survivalRules.Insert(7, checkBox8);
            this.survivalRules.Insert(8, checkBox9);

            creationRules = new List<CheckBox>();
            this.creationRules.Insert(0, checkBox10);
            this.creationRules.Insert(1, checkBox11);
            this.creationRules.Insert(2, checkBox12);
            this.creationRules.Insert(3, checkBox13);
            this.creationRules.Insert(4, checkBox14);
            this.creationRules.Insert(5, checkBox15);
            this.creationRules.Insert(6, checkBox16);
            this.creationRules.Insert(7, checkBox17);
            this.creationRules.Insert(8, checkBox18);
        }

    }
}
