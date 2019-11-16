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
        LifeRule[] rulesSets;
        LifeArea lifeArea;

        private void MainWindow_Load(object sender, EventArgs e)
        {
            initialization();
        }

        #region initialization
        private void initialization()
        {
            initCheckBoxList();
            setStartupColors();

            panel_PlaingArea.Height = 600;
            panel_PlaingArea.Width = 600;

            int size = trackBar_AreaSize.Value;

            lifeArea = new LifeArea.AreaBuilder()
                .size(size)
                .playingArea(panel_PlaingArea)
                .gridColor(pictureBox_Grid.BackColor)
                .diedCellColor(pictureBox_DeadCell.BackColor)
                .createdCellColor(pictureBox_CreatedCell.BackColor)
                .livingCellColor(pictureBox_LivingCell.BackColor)
                .areaColor(colorDialog_AreaBackground.Color)
                .build();

            lifeArea.drawGrid();

            setRulesSets();
        }
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
        private void setStartupColors()
        {
            colorDialog_Grid.Color = pictureBox_Grid.BackColor;
            colorDialog_DeadCell.Color = pictureBox_DeadCell.BackColor;
            colorDialog_CreatedCell.Color = pictureBox_CreatedCell.BackColor;
            colorDialog_LivingCell.Color = pictureBox_LivingCell.BackColor;
            colorDialog_AreaBackground.Color = pictureBox_AreaBackground.BackColor;
        }

        private void setRulesSets()
        {


            rulesSets = new LifeRule[]
            {
               new LifeRule("",1,new bool[]{ },new bool[]{ }),

            };
        }

        #endregion

        #region colorDialog select
        private void PictureBox_Grid_Click(object sender, EventArgs e)
        {
            if (colorDialog_Grid.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox_Grid.BackColor = colorDialog_Grid.Color;
            lifeArea.GridColor = colorDialog_Grid.Color;
            lifeArea.Size = trackBar_AreaSize.Value;
            lifeArea.drawGrid();
        }
        private void PictureBox_DeadCell_Click(object sender, EventArgs e)
        {
            if (colorDialog_DeadCell.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox_DeadCell.BackColor = colorDialog_DeadCell.Color;
            lifeArea.DiedCellColor = colorDialog_DeadCell.Color;
        }
        private void PictureBox_CreatedCell_Click(object sender, EventArgs e)
        {
            if (colorDialog_CreatedCell.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox_CreatedCell.BackColor = colorDialog_CreatedCell.Color;
            lifeArea.CreatedCellColor = colorDialog_CreatedCell.Color;
        }
        private void PictureBox_LivingCell_Click(object sender, EventArgs e)
        {
            if (colorDialog_LivingCell.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox_LivingCell.BackColor = colorDialog_LivingCell.Color;
            lifeArea.LivingCellColor = colorDialog_LivingCell.Color;
        }
        private void PictureBox_AreaBackground_Click(object sender, EventArgs e)
        {
            if (colorDialog_AreaBackground.ShowDialog() == DialogResult.Cancel)
                return;
            pictureBox_AreaBackground.BackColor = colorDialog_AreaBackground.Color;
            lifeArea.AreaColor = colorDialog_AreaBackground.Color;
            lifeArea.updateAreaColor();
        }
        #endregion

        #region displaying elements
        private void CheckBox_DisplayGrid_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_Grid.Enabled = checkBox_DisplayGrid.Checked;
        }
        private void CheckBox_ShowDeadCell_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_DeadCell.Enabled = checkBox_ShowDeadCell.Checked;
        }
        private void CheckBox_CreatedCell_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox_CreatedCell.Enabled = checkBox_ShowCreatedCell.Checked;
        }
        #endregion

        #region game rules
        
        private void Button_ChangeRules_Click(object sender, EventArgs e)
        {
            button_ChangeRules.Visible = false;
            button_ApplyRules.Visible = true;
            button_CancelChangeRules.Visible = true;
            comboBox_RulesSets.Enabled = true;

        }

        private void Button_ApplyRules_Click(object sender, EventArgs e)
        {
            button_ChangeRules.Visible = true;
            button_ApplyRules.Visible = false;
            button_CancelChangeRules.Visible = false;
            comboBox_RulesSets.Enabled = false;

        }

        private void Button_CancelChangeRules_Click(object sender, EventArgs e)
        {
            button_ChangeRules.Visible = true;
            button_ApplyRules.Visible = false;
            button_CancelChangeRules.Visible = false;
            comboBox_RulesSets.Enabled = false;

        }

        #endregion

        private void TrackBar_AreaSize_Scroll(object sender, EventArgs e)
        {
            label16.Text = trackBar_AreaSize.Value.ToString();
            lifeArea.Size = trackBar_AreaSize.Value;
            lifeArea.drawGrid();
        }
    }
}
