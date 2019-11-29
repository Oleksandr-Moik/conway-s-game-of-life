namespace Game_of_life
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Population = new System.Windows.Forms.Label();
            this.label_Generation = new System.Windows.Forms.Label();
            this.label_Died = new System.Windows.Forms.Label();
            this.label_Created = new System.Windows.Forms.Label();
            this.panel_PlaingArea = new System.Windows.Forms.Panel();
            this.trackBar_TimerTick = new System.Windows.Forms.TrackBar();
            this.groupBox_SurvivalRules = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox_CreationRules = new System.Windows.Forms.GroupBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_RandomFiling = new System.Windows.Forms.Button();
            this.button_ClearArea = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_RulesSets = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label_RulesType = new System.Windows.Forms.Label();
            this.button_ApplyRules = new System.Windows.Forms.Button();
            this.button_CancelChangeRules = new System.Windows.Forms.Button();
            this.button_StartTime = new System.Windows.Forms.Button();
            this.button_NextTick = new System.Windows.Forms.Button();
            this.button_ChangeRules = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_RulesTypeInfo = new System.Windows.Forms.Button();
            this.checkBox_DisplayGrid = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowDeadCell = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowCreatedCell = new System.Windows.Forms.CheckBox();
            this.trackBar_AreaSize = new System.Windows.Forms.TrackBar();
            this.colorDialog_SelectColor = new System.Windows.Forms.ColorDialog();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Grid = new System.Windows.Forms.PictureBox();
            this.pictureBox_AreaBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox_LivingCell = new System.Windows.Forms.PictureBox();
            this.pictureBox_CreatedCell = new System.Windows.Forms.PictureBox();
            this.pictureBox_DeadCell = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Time = new System.Windows.Forms.PictureBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TimerTick)).BeginInit();
            this.groupBox_SurvivalRules.SuspendLayout();
            this.groupBox_CreationRules.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AreaSize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AreaBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LivingCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CreatedCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DeadCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(380, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Населення:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(380, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Покоління:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(624, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Загинуло:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(624, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Створено:";
            // 
            // label_Population
            // 
            this.label_Population.AutoSize = true;
            this.label_Population.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Population.Location = new System.Drawing.Point(500, 24);
            this.label_Population.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Population.Name = "label_Population";
            this.label_Population.Size = new System.Drawing.Size(24, 25);
            this.label_Population.TabIndex = 1;
            this.label_Population.Text = "0";
            // 
            // label_Generation
            // 
            this.label_Generation.AutoSize = true;
            this.label_Generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Generation.Location = new System.Drawing.Point(500, 49);
            this.label_Generation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Generation.Name = "label_Generation";
            this.label_Generation.Size = new System.Drawing.Size(24, 25);
            this.label_Generation.TabIndex = 1;
            this.label_Generation.Text = "0";
            // 
            // label_Died
            // 
            this.label_Died.AutoSize = true;
            this.label_Died.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Died.Location = new System.Drawing.Point(742, 51);
            this.label_Died.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Died.Name = "label_Died";
            this.label_Died.Size = new System.Drawing.Size(24, 25);
            this.label_Died.TabIndex = 1;
            this.label_Died.Text = "0";
            // 
            // label_Created
            // 
            this.label_Created.AutoSize = true;
            this.label_Created.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Created.Location = new System.Drawing.Point(742, 26);
            this.label_Created.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Created.Name = "label_Created";
            this.label_Created.Size = new System.Drawing.Size(24, 25);
            this.label_Created.TabIndex = 1;
            this.label_Created.Text = "0";
            // 
            // panel_PlaingArea
            // 
            this.panel_PlaingArea.BackColor = System.Drawing.Color.Silver;
            this.panel_PlaingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PlaingArea.Location = new System.Drawing.Point(349, 80);
            this.panel_PlaingArea.Name = "panel_PlaingArea";
            this.panel_PlaingArea.Size = new System.Drawing.Size(600, 600);
            this.panel_PlaingArea.TabIndex = 2;
            this.panel_PlaingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_PlaingArea_MouseClick);
            // 
            // trackBar_TimerTick
            // 
            this.trackBar_TimerTick.LargeChange = 2;
            this.trackBar_TimerTick.Location = new System.Drawing.Point(64, 362);
            this.trackBar_TimerTick.Name = "trackBar_TimerTick";
            this.trackBar_TimerTick.Size = new System.Drawing.Size(270, 45);
            this.trackBar_TimerTick.TabIndex = 1;
            this.trackBar_TimerTick.TickFrequency = 0;
            this.trackBar_TimerTick.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_TimerTick.Value = 5;
            this.trackBar_TimerTick.Scroll += new System.EventHandler(this.TrackBar_TimerTick_Scroll);
            // 
            // groupBox_SurvivalRules
            // 
            this.groupBox_SurvivalRules.Controls.Add(this.checkBox8);
            this.groupBox_SurvivalRules.Controls.Add(this.checkBox7);
            this.groupBox_SurvivalRules.Controls.Add(this.checkBox6);
            this.groupBox_SurvivalRules.Controls.Add(this.checkBox9);
            this.groupBox_SurvivalRules.Controls.Add(this.checkBox5);
            this.groupBox_SurvivalRules.Controls.Add(this.checkBox4);
            this.groupBox_SurvivalRules.Controls.Add(this.checkBox3);
            this.groupBox_SurvivalRules.Controls.Add(this.checkBox2);
            this.groupBox_SurvivalRules.Controls.Add(this.checkBox1);
            this.groupBox_SurvivalRules.Enabled = false;
            this.groupBox_SurvivalRules.Location = new System.Drawing.Point(3, 3);
            this.groupBox_SurvivalRules.Name = "groupBox_SurvivalRules";
            this.groupBox_SurvivalRules.Size = new System.Drawing.Size(304, 58);
            this.groupBox_SurvivalRules.TabIndex = 3;
            this.groupBox_SurvivalRules.TabStop = false;
            this.groupBox_SurvivalRules.Text = "Правила виживання";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Enabled = false;
            this.checkBox8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox8.Location = new System.Drawing.Point(244, 30);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Tag = "7";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Enabled = false;
            this.checkBox7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox7.Location = new System.Drawing.Point(212, 30);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Tag = "6";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Enabled = false;
            this.checkBox6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox6.Location = new System.Drawing.Point(180, 30);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Tag = "5";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Enabled = false;
            this.checkBox9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox9.Location = new System.Drawing.Point(274, 30);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Tag = "8";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox5.Location = new System.Drawing.Point(148, 30);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Tag = "4";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4.Location = new System.Drawing.Point(116, 30);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Tag = "3";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(84, 30);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Tag = "2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(52, 30);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Tag = "1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(20, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "0";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox_CreationRules
            // 
            this.groupBox_CreationRules.Controls.Add(this.checkBox18);
            this.groupBox_CreationRules.Controls.Add(this.checkBox15);
            this.groupBox_CreationRules.Controls.Add(this.checkBox17);
            this.groupBox_CreationRules.Controls.Add(this.checkBox10);
            this.groupBox_CreationRules.Controls.Add(this.checkBox16);
            this.groupBox_CreationRules.Controls.Add(this.checkBox11);
            this.groupBox_CreationRules.Controls.Add(this.checkBox12);
            this.groupBox_CreationRules.Controls.Add(this.checkBox14);
            this.groupBox_CreationRules.Controls.Add(this.checkBox13);
            this.groupBox_CreationRules.Enabled = false;
            this.groupBox_CreationRules.Location = new System.Drawing.Point(3, 67);
            this.groupBox_CreationRules.Name = "groupBox_CreationRules";
            this.groupBox_CreationRules.Size = new System.Drawing.Size(304, 55);
            this.groupBox_CreationRules.TabIndex = 3;
            this.groupBox_CreationRules.TabStop = false;
            this.groupBox_CreationRules.Text = "Правила створення";
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Enabled = false;
            this.checkBox18.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox18.Location = new System.Drawing.Point(274, 30);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(15, 14);
            this.checkBox18.TabIndex = 0;
            this.checkBox18.Tag = "8";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Enabled = false;
            this.checkBox15.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox15.Location = new System.Drawing.Point(180, 30);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(15, 14);
            this.checkBox15.TabIndex = 0;
            this.checkBox15.Tag = "6";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Enabled = false;
            this.checkBox17.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox17.Location = new System.Drawing.Point(244, 30);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(15, 14);
            this.checkBox17.TabIndex = 0;
            this.checkBox17.Tag = "7";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Enabled = false;
            this.checkBox10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox10.Location = new System.Drawing.Point(20, 30);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Tag = "0";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Enabled = false;
            this.checkBox16.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox16.Location = new System.Drawing.Point(212, 30);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(15, 14);
            this.checkBox16.TabIndex = 0;
            this.checkBox16.Tag = "6";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Enabled = false;
            this.checkBox11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox11.Location = new System.Drawing.Point(52, 30);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(15, 14);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Tag = "1";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Enabled = false;
            this.checkBox12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox12.Location = new System.Drawing.Point(84, 30);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(15, 14);
            this.checkBox12.TabIndex = 0;
            this.checkBox12.Tag = "2";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Enabled = false;
            this.checkBox14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox14.Location = new System.Drawing.Point(148, 30);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(15, 14);
            this.checkBox14.TabIndex = 0;
            this.checkBox14.Tag = "4";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Checked = true;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.Enabled = false;
            this.checkBox13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox13.Location = new System.Drawing.Point(116, 30);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(15, 14);
            this.checkBox13.TabIndex = 0;
            this.checkBox13.Tag = "3";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "8";
            // 
            // button_RandomFiling
            // 
            this.button_RandomFiling.Location = new System.Drawing.Point(197, 286);
            this.button_RandomFiling.Name = "button_RandomFiling";
            this.button_RandomFiling.Size = new System.Drawing.Size(137, 32);
            this.button_RandomFiling.TabIndex = 7;
            this.button_RandomFiling.Text = "Випадково";
            this.button_RandomFiling.UseVisualStyleBackColor = true;
            this.button_RandomFiling.Click += new System.EventHandler(this.Button_RandomFiling_Click);
            // 
            // button_ClearArea
            // 
            this.button_ClearArea.Location = new System.Drawing.Point(197, 324);
            this.button_ClearArea.Name = "button_ClearArea";
            this.button_ClearArea.Size = new System.Drawing.Size(139, 32);
            this.button_ClearArea.TabIndex = 7;
            this.button_ClearArea.Text = "Очистити";
            this.button_ClearArea.UseVisualStyleBackColor = true;
            this.button_ClearArea.Click += new System.EventHandler(this.Button_ClearArea_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Моделі правил";
            // 
            // comboBox_RulesSets
            // 
            this.comboBox_RulesSets.Enabled = false;
            this.comboBox_RulesSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_RulesSets.FormattingEnabled = true;
            this.comboBox_RulesSets.Items.AddRange(new object[] {
            "Життя",
            "HighLife",
            "Губка клітини",
            "Повільно зростаюче шипіння",
            "Бури",
            "Конденсація",
            "Насіння",
            "Поширення",
            "Лабіринт",
            "Амеба",
            "Ді-амеба",
            "Корал",
            "Пам\'ять"});
            this.comboBox_RulesSets.Location = new System.Drawing.Point(16, 53);
            this.comboBox_RulesSets.Name = "comboBox_RulesSets";
            this.comboBox_RulesSets.Size = new System.Drawing.Size(211, 28);
            this.comboBox_RulesSets.TabIndex = 9;
            this.comboBox_RulesSets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_RulesSets_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(227, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 23);
            this.label15.TabIndex = 8;
            this.label15.Text = "Тип";
            // 
            // label_RulesType
            // 
            this.label_RulesType.AutoSize = true;
            this.label_RulesType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_RulesType.Location = new System.Drawing.Point(231, 56);
            this.label_RulesType.Name = "label_RulesType";
            this.label_RulesType.Size = new System.Drawing.Size(92, 20);
            this.label_RulesType.TabIndex = 8;
            this.label_RulesType.Text = "Хаотичний";
            // 
            // button_ApplyRules
            // 
            this.button_ApplyRules.Location = new System.Drawing.Point(16, 90);
            this.button_ApplyRules.Name = "button_ApplyRules";
            this.button_ApplyRules.Size = new System.Drawing.Size(137, 32);
            this.button_ApplyRules.TabIndex = 11;
            this.button_ApplyRules.Text = "Застосувати";
            this.button_ApplyRules.UseVisualStyleBackColor = true;
            this.button_ApplyRules.Visible = false;
            // 
            // button_CancelChangeRules
            // 
            this.button_CancelChangeRules.Location = new System.Drawing.Point(159, 90);
            this.button_CancelChangeRules.Name = "button_CancelChangeRules";
            this.button_CancelChangeRules.Size = new System.Drawing.Size(117, 32);
            this.button_CancelChangeRules.TabIndex = 11;
            this.button_CancelChangeRules.Text = "Скасувати";
            this.button_CancelChangeRules.UseVisualStyleBackColor = true;
            this.button_CancelChangeRules.Visible = false;
            // 
            // button_StartTime
            // 
            this.button_StartTime.Location = new System.Drawing.Point(16, 324);
            this.button_StartTime.Name = "button_StartTime";
            this.button_StartTime.Size = new System.Drawing.Size(134, 32);
            this.button_StartTime.TabIndex = 10;
            this.button_StartTime.Text = "Почати";
            this.button_StartTime.UseVisualStyleBackColor = true;
            this.button_StartTime.Click += new System.EventHandler(this.Button_StartTime_Click);
            // 
            // button_NextTick
            // 
            this.button_NextTick.Location = new System.Drawing.Point(16, 286);
            this.button_NextTick.Name = "button_NextTick";
            this.button_NextTick.Size = new System.Drawing.Size(134, 32);
            this.button_NextTick.TabIndex = 10;
            this.button_NextTick.Text = "Наступне";
            this.button_NextTick.UseVisualStyleBackColor = true;
            this.button_NextTick.Click += new System.EventHandler(this.Button_NextTick_Click);
            // 
            // button_ChangeRules
            // 
            this.button_ChangeRules.Enabled = false;
            this.button_ChangeRules.Location = new System.Drawing.Point(16, 90);
            this.button_ChangeRules.Name = "button_ChangeRules";
            this.button_ChangeRules.Size = new System.Drawing.Size(117, 32);
            this.button_ChangeRules.TabIndex = 11;
            this.button_ChangeRules.Text = "Змінити";
            this.button_ChangeRules.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_SurvivalRules);
            this.panel1.Controls.Add(this.groupBox_CreationRules);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(16, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 152);
            this.panel1.TabIndex = 13;
            // 
            // button_RulesTypeInfo
            // 
            this.button_RulesTypeInfo.Location = new System.Drawing.Point(281, 21);
            this.button_RulesTypeInfo.Name = "button_RulesTypeInfo";
            this.button_RulesTypeInfo.Size = new System.Drawing.Size(21, 28);
            this.button_RulesTypeInfo.TabIndex = 10;
            this.button_RulesTypeInfo.Text = "і";
            this.button_RulesTypeInfo.UseVisualStyleBackColor = true;
            this.button_RulesTypeInfo.Click += new System.EventHandler(this.Button_RulesTypeInfo_Click);
            // 
            // checkBox_DisplayGrid
            // 
            this.checkBox_DisplayGrid.AutoSize = true;
            this.checkBox_DisplayGrid.Checked = true;
            this.checkBox_DisplayGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DisplayGrid.Location = new System.Drawing.Point(12, 3);
            this.checkBox_DisplayGrid.Name = "checkBox_DisplayGrid";
            this.checkBox_DisplayGrid.Size = new System.Drawing.Size(245, 27);
            this.checkBox_DisplayGrid.TabIndex = 14;
            this.checkBox_DisplayGrid.Text = "Промальовувати сітку";
            this.checkBox_DisplayGrid.UseVisualStyleBackColor = true;
            this.checkBox_DisplayGrid.CheckedChanged += new System.EventHandler(this.CheckBox_Display_CheckedChanged);
            // 
            // checkBox_ShowDeadCell
            // 
            this.checkBox_ShowDeadCell.AutoSize = true;
            this.checkBox_ShowDeadCell.Location = new System.Drawing.Point(12, 79);
            this.checkBox_ShowDeadCell.Name = "checkBox_ShowDeadCell";
            this.checkBox_ShowDeadCell.Size = new System.Drawing.Size(230, 27);
            this.checkBox_ShowDeadCell.TabIndex = 15;
            this.checkBox_ShowDeadCell.Text = "Показувати вмерлих";
            this.checkBox_ShowDeadCell.UseVisualStyleBackColor = true;
            this.checkBox_ShowDeadCell.CheckedChanged += new System.EventHandler(this.CheckBox_Display_CheckedChanged);
            // 
            // checkBox_ShowCreatedCell
            // 
            this.checkBox_ShowCreatedCell.AutoSize = true;
            this.checkBox_ShowCreatedCell.Location = new System.Drawing.Point(12, 112);
            this.checkBox_ShowCreatedCell.Name = "checkBox_ShowCreatedCell";
            this.checkBox_ShowCreatedCell.Size = new System.Drawing.Size(248, 27);
            this.checkBox_ShowCreatedCell.TabIndex = 16;
            this.checkBox_ShowCreatedCell.Text = "Показувати створених";
            this.checkBox_ShowCreatedCell.UseVisualStyleBackColor = true;
            this.checkBox_ShowCreatedCell.CheckedChanged += new System.EventHandler(this.CheckBox_Display_CheckedChanged);
            // 
            // trackBar_AreaSize
            // 
            this.trackBar_AreaSize.LargeChange = 10;
            this.trackBar_AreaSize.Location = new System.Drawing.Point(64, 412);
            this.trackBar_AreaSize.Maximum = 150;
            this.trackBar_AreaSize.Minimum = 10;
            this.trackBar_AreaSize.Name = "trackBar_AreaSize";
            this.trackBar_AreaSize.Size = new System.Drawing.Size(270, 45);
            this.trackBar_AreaSize.SmallChange = 10;
            this.trackBar_AreaSize.TabIndex = 10;
            this.trackBar_AreaSize.TickFrequency = 0;
            this.trackBar_AreaSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_AreaSize.Value = 30;
            this.trackBar_AreaSize.Scroll += new System.EventHandler(this.TrackBar_AreaSize_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(200, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 23);
            this.label17.TabIndex = 19;
            this.label17.Text = "Живі";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(207, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 23);
            this.label18.TabIndex = 19;
            this.label18.Text = "Фон";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.pictureBox_Grid);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.checkBox_DisplayGrid);
            this.panel2.Controls.Add(this.pictureBox_AreaBackground);
            this.panel2.Controls.Add(this.checkBox_ShowDeadCell);
            this.panel2.Controls.Add(this.pictureBox_LivingCell);
            this.panel2.Controls.Add(this.checkBox_ShowCreatedCell);
            this.panel2.Controls.Add(this.pictureBox_CreatedCell);
            this.panel2.Controls.Add(this.pictureBox_DeadCell);
            this.panel2.Location = new System.Drawing.Point(16, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 202);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox_Grid
            // 
            this.pictureBox_Grid.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox_Grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Grid.Location = new System.Drawing.Point(265, 3);
            this.pictureBox_Grid.Name = "pictureBox_Grid";
            this.pictureBox_Grid.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_Grid.TabIndex = 17;
            this.pictureBox_Grid.TabStop = false;
            this.pictureBox_Grid.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_AreaBackground
            // 
            this.pictureBox_AreaBackground.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_AreaBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_AreaBackground.Location = new System.Drawing.Point(265, 36);
            this.pictureBox_AreaBackground.Name = "pictureBox_AreaBackground";
            this.pictureBox_AreaBackground.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_AreaBackground.TabIndex = 17;
            this.pictureBox_AreaBackground.TabStop = false;
            this.pictureBox_AreaBackground.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_LivingCell
            // 
            this.pictureBox_LivingCell.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox_LivingCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_LivingCell.Location = new System.Drawing.Point(265, 145);
            this.pictureBox_LivingCell.Name = "pictureBox_LivingCell";
            this.pictureBox_LivingCell.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_LivingCell.TabIndex = 17;
            this.pictureBox_LivingCell.TabStop = false;
            this.pictureBox_LivingCell.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_CreatedCell
            // 
            this.pictureBox_CreatedCell.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox_CreatedCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_CreatedCell.Location = new System.Drawing.Point(265, 112);
            this.pictureBox_CreatedCell.Name = "pictureBox_CreatedCell";
            this.pictureBox_CreatedCell.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_CreatedCell.TabIndex = 17;
            this.pictureBox_CreatedCell.TabStop = false;
            this.pictureBox_CreatedCell.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_DeadCell
            // 
            this.pictureBox_DeadCell.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox_DeadCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_DeadCell.Location = new System.Drawing.Point(265, 79);
            this.pictureBox_DeadCell.Name = "pictureBox_DeadCell";
            this.pictureBox_DeadCell.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_DeadCell.TabIndex = 17;
            this.pictureBox_DeadCell.TabStop = false;
            this.pictureBox_DeadCell.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Game_of_life.Properties.Resources.grid;
            this.pictureBox1.Location = new System.Drawing.Point(16, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_Time
            // 
            this.pictureBox_Time.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Time.Enabled = false;
            this.pictureBox_Time.Image = global::Game_of_life.Properties.Resources.speed_icon_png_3_jpg;
            this.pictureBox_Time.Location = new System.Drawing.Point(16, 362);
            this.pictureBox_Time.Name = "pictureBox_Time";
            this.pictureBox_Time.Size = new System.Drawing.Size(46, 45);
            this.pictureBox_Time.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Time.TabIndex = 12;
            this.pictureBox_Time.TabStop = false;
            // 
            // checkBox19
            // 
            this.checkBox19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox19.Location = new System.Drawing.Point(803, 27);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(202, 47);
            this.checkBox19.TabIndex = 22;
            this.checkBox19.Text = "show grid content (debug)";
            this.checkBox19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 687);
            this.Controls.Add(this.panel_PlaingArea);
            this.Controls.Add(this.checkBox19);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_Time);
            this.Controls.Add(this.button_CancelChangeRules);
            this.Controls.Add(this.button_ChangeRules);
            this.Controls.Add(this.button_ApplyRules);
            this.Controls.Add(this.button_RulesTypeInfo);
            this.Controls.Add(this.button_NextTick);
            this.Controls.Add(this.button_StartTime);
            this.Controls.Add(this.comboBox_RulesSets);
            this.Controls.Add(this.label_RulesType);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button_ClearArea);
            this.Controls.Add(this.button_RandomFiling);
            this.Controls.Add(this.trackBar_AreaSize);
            this.Controls.Add(this.trackBar_TimerTick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Created);
            this.Controls.Add(this.label_Died);
            this.Controls.Add(this.label_Generation);
            this.Controls.Add(this.label_Population);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "\"Гра життя\"";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TimerTick)).EndInit();
            this.groupBox_SurvivalRules.ResumeLayout(false);
            this.groupBox_SurvivalRules.PerformLayout();
            this.groupBox_CreationRules.ResumeLayout(false);
            this.groupBox_CreationRules.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AreaSize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AreaBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LivingCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CreatedCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DeadCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Population;
        private System.Windows.Forms.Label label_Generation;
        private System.Windows.Forms.Label label_Died;
        private System.Windows.Forms.Label label_Created;
        private System.Windows.Forms.Panel panel_PlaingArea;
        private System.Windows.Forms.TrackBar trackBar_TimerTick;
        private System.Windows.Forms.GroupBox groupBox_SurvivalRules;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox_CreationRules;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.Button button_RandomFiling;
        private System.Windows.Forms.Button button_ClearArea;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_RulesSets;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_RulesType;
        private System.Windows.Forms.Button button_ApplyRules;
        private System.Windows.Forms.Button button_CancelChangeRules;
        private System.Windows.Forms.Button button_StartTime;
        private System.Windows.Forms.Button button_NextTick;
        private System.Windows.Forms.Button button_ChangeRules;
        private System.Windows.Forms.PictureBox pictureBox_Time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_RulesTypeInfo;
        private System.Windows.Forms.CheckBox checkBox_DisplayGrid;
        private System.Windows.Forms.CheckBox checkBox_ShowDeadCell;
        private System.Windows.Forms.CheckBox checkBox_ShowCreatedCell;
        private System.Windows.Forms.PictureBox pictureBox_Grid;
        private System.Windows.Forms.TrackBar trackBar_AreaSize;
        private System.Windows.Forms.PictureBox pictureBox_DeadCell;
        private System.Windows.Forms.PictureBox pictureBox_CreatedCell;
        private System.Windows.Forms.ColorDialog colorDialog_SelectColor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox_LivingCell;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox_AreaBackground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox19;
    }
}

