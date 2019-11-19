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

        private List<CheckBox> survivalRules;
        private List<CheckBox> creationRules;
        private int[,] presentArea;
        private int lifeTime = 0;

        private const string CHAOTIC = "Хаотичний";
        private const string STABLE = "Стабільний";
        private const string EXTENSIONS = "Розширюваний";
        private const string EXPLOSIVE = "Вибухаючий";

        private void MainWindow_Load(object sender, EventArgs e)
        {
            initCheckBoxList();
            setPictureColorFromColorDialog();

            panel_PlaingArea.Height = 600;
            panel_PlaingArea.Width = 600;

            comboBox_RulesSets.SelectedIndex = 0;

            RandomFiiling(ref presentArea);
            DrawGrid();
        }

        #region initialization
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
        private void setPictureColorFromColorDialog()
        {
            pictureBox_Grid.BackColor = colorDialog_Grid.Color;
            pictureBox_DeadCell.BackColor = colorDialog_DeadCell.Color;
            pictureBox_CreatedCell.BackColor = colorDialog_CreatedCell.Color;
            pictureBox_LivingCell.BackColor = colorDialog_LivingCell.Color;
            pictureBox_AreaBackground.BackColor = colorDialog_AreaBackground.Color;
        }

        #endregion

        private void Button_RandomFiiling_Click(object sender, EventArgs e)
        {

        }

        private void RandomFiiling(ref int[,] area)
        {
            int size = trackBar_AreaSize.Value;
            area = new int[size, size];
            Random random = new Random();
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    area[i, j] = random.Next(0, 1);
        }

        private void ClearArea(ref int[,] area)
        {
            int size = trackBar_AreaSize.Value;
            area = new int[size, size];
        }

        private void ComboBox_RulesSets_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // show information about CHAOTIC, STABLE, EXTENSIONS and EXPLOSIVE types
        private void Button_RulesTypeInfo_Click(object sender, EventArgs e)
        {
            if(label_RulesType.Text == CHAOTIC)
            {
                MessageBox.Show(this,
                    
                    "Для досягнення найкращих результатів використовуйте " +
                    "випадковим чином розкидане поле для ініціалізації " +
                    "моделювання. Вам може знадобитися втрутитись в гру, " +
                    "щоб взаємодіяти з полем, або інакше взаємодії клітин " +
                    "за часом припиняться.", 
                    
                    "Інформація про " + CHAOTIC.ToLower());
            }
            else if (label_RulesType.Text == STABLE) // стабільний
            {
                MessageBox.Show(this,

                    "При стабільних правилах форми рідко взаємодіють " +
                    "між собою. Можливо, Вам буде потрібно побудувати " +
                    "великий блоб, або ж поєднання кілька менших блобів, " +
                    "щоб побачити розвиток шаблону.", 

                    "Інформація про " + STABLE.ToLower());

            }
            else if (label_RulesType.Text == EXTENSIONS) // розширюваний
            {
                MessageBox.Show(this,

                    "Для досягнення найкращих результатів, почніть " +
                    "з пустого поля, і побудуйте деякі живі клітини " +
                    "перед початком моделювання. Для деяких правил, " +
                    "можливо буде потрібно побудувати великий блоб, " +
                    "або ж поєднання кілька менших блобів, щоб " +
                    "побачити розвиток шаблону.", 

                    "Інформація про " + EXTENSIONS.ToLower());

            }
            else if (label_RulesType.Text == EXPLOSIVE) // вибахаючий
            {
                MessageBox.Show(this,

                    "Для досягнення найкращих результатів, почніть " +
                    "з пустого поля, і побудуйте одну-дві живі " +
                    "клітини перед початком моделювання. Деякі " +
                    "правила (наприклад, Пам'ять) найкраще працюють " +
                    "з простою формою або буквою в якосі відправного " +
                    "шаблону.",
                    
                    "Інформація про " + EXPLOSIVE.ToLower());

            }
        }

        private void DrawGrid()
        {
            panel_PlaingArea.Refresh();

            Graphics dc = panel_PlaingArea.CreateGraphics();
            Pen gridPan = new Pen(colorDialog_Grid.Color, 1);

            int width = panel_PlaingArea.Width;
            int height = panel_PlaingArea.Height;
            int size = trackBar_AreaSize.Value;

            for (int i = 0; i <= width; i += (width / size))
            {
                dc.DrawLine(gridPan, new Point(i, 0), new Point(i, height));
                dc.DrawLine(gridPan, new Point(0, i), new Point(width, i));
            }

            //dc.Dispose();
        }

        private void Button_ClearArea_Click(object sender, EventArgs e)
        {

        }

        private void Button_NextTick_Click(object sender, EventArgs e)
        {

        }
    }
}
