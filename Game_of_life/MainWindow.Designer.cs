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
            this.button_RandomFiling = new System.Windows.Forms.Button();
            this.button_ClearArea = new System.Windows.Forms.Button();
            this.button_StartTime = new System.Windows.Forms.Button();
            this.button_NextTick = new System.Windows.Forms.Button();
            this.checkBox_DisplayGrid = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowDeadCell = new System.Windows.Forms.CheckBox();
            this.checkBox_ShowCreatedCell = new System.Windows.Forms.CheckBox();
            this.trackBar_AreaSize = new System.Windows.Forms.TrackBar();
            this.colorDialog_SelectColor = new System.Windows.Forms.ColorDialog();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Grid = new System.Windows.Forms.PictureBox();
            this.pictureBox_AreaBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox_LivingCell = new System.Windows.Forms.PictureBox();
            this.pictureBox_CreatedCell = new System.Windows.Forms.PictureBox();
            this.pictureBox_DeadCell = new System.Windows.Forms.PictureBox();
            this.button_SetDefaultColors = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox_TimeValue = new System.Windows.Forms.PictureBox();
            this.pictureBox_GridSize = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.граToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.полеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заповнитиВипадковимЧиномToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаГриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TimerTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AreaSize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AreaBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LivingCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CreatedCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DeadCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TimeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GridSize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(237, 551);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Населення:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 551);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Покоління:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(683, 551);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Загинуло:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(457, 550);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Створено:";
            // 
            // label_Population
            // 
            this.label_Population.AutoSize = true;
            this.label_Population.BackColor = System.Drawing.SystemColors.Control;
            this.label_Population.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Population.Location = new System.Drawing.Point(357, 551);
            this.label_Population.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Population.Name = "label_Population";
            this.label_Population.Size = new System.Drawing.Size(24, 25);
            this.label_Population.TabIndex = 1;
            this.label_Population.Text = "0";
            // 
            // label_Generation
            // 
            this.label_Generation.AutoSize = true;
            this.label_Generation.BackColor = System.Drawing.SystemColors.Control;
            this.label_Generation.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_Generation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Generation.Location = new System.Drawing.Point(133, 551);
            this.label_Generation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Generation.Name = "label_Generation";
            this.label_Generation.Size = new System.Drawing.Size(24, 25);
            this.label_Generation.TabIndex = 1;
            this.label_Generation.Text = "0";
            // 
            // label_Died
            // 
            this.label_Died.AutoSize = true;
            this.label_Died.BackColor = System.Drawing.SystemColors.Control;
            this.label_Died.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_Died.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Died.Location = new System.Drawing.Point(801, 551);
            this.label_Died.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Died.Name = "label_Died";
            this.label_Died.Size = new System.Drawing.Size(24, 25);
            this.label_Died.TabIndex = 1;
            this.label_Died.Text = "0";
            // 
            // label_Created
            // 
            this.label_Created.AutoSize = true;
            this.label_Created.BackColor = System.Drawing.SystemColors.Control;
            this.label_Created.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_Created.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Created.Location = new System.Drawing.Point(577, 550);
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
            this.panel_PlaingArea.Location = new System.Drawing.Point(381, 37);
            this.panel_PlaingArea.Name = "panel_PlaingArea";
            this.panel_PlaingArea.Size = new System.Drawing.Size(500, 500);
            this.panel_PlaingArea.TabIndex = 2;
            // 
            // trackBar_TimerTick
            // 
            this.trackBar_TimerTick.LargeChange = 1;
            this.trackBar_TimerTick.Location = new System.Drawing.Point(72, 63);
            this.trackBar_TimerTick.Maximum = 9;
            this.trackBar_TimerTick.Name = "trackBar_TimerTick";
            this.trackBar_TimerTick.Size = new System.Drawing.Size(241, 45);
            this.trackBar_TimerTick.TabIndex = 1;
            this.trackBar_TimerTick.TickFrequency = 0;
            this.trackBar_TimerTick.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_TimerTick.Value = 4;
            this.trackBar_TimerTick.Scroll += new System.EventHandler(this.TrackBar_TimerTick_Scroll);
            // 
            // button_RandomFiling
            // 
            this.button_RandomFiling.Location = new System.Drawing.Point(18, 276);
            this.button_RandomFiling.Name = "button_RandomFiling";
            this.button_RandomFiling.Size = new System.Drawing.Size(126, 32);
            this.button_RandomFiling.TabIndex = 7;
            this.button_RandomFiling.Text = "Випадково";
            this.button_RandomFiling.UseVisualStyleBackColor = true;
            this.button_RandomFiling.Click += new System.EventHandler(this.Button_RandomFiling_Click);
            // 
            // button_ClearArea
            // 
            this.button_ClearArea.Location = new System.Drawing.Point(212, 278);
            this.button_ClearArea.Name = "button_ClearArea";
            this.button_ClearArea.Size = new System.Drawing.Size(128, 32);
            this.button_ClearArea.TabIndex = 7;
            this.button_ClearArea.Text = "Очистити";
            this.button_ClearArea.UseVisualStyleBackColor = true;
            this.button_ClearArea.Click += new System.EventHandler(this.Button_ClearArea_Click);
            // 
            // button_StartTime
            // 
            this.button_StartTime.Location = new System.Drawing.Point(211, 114);
            this.button_StartTime.Name = "button_StartTime";
            this.button_StartTime.Size = new System.Drawing.Size(126, 32);
            this.button_StartTime.TabIndex = 10;
            this.button_StartTime.Text = "Почати";
            this.button_StartTime.UseVisualStyleBackColor = true;
            this.button_StartTime.Click += new System.EventHandler(this.Button_StartTime_Click);
            // 
            // button_NextTick
            // 
            this.button_NextTick.Location = new System.Drawing.Point(18, 114);
            this.button_NextTick.Name = "button_NextTick";
            this.button_NextTick.Size = new System.Drawing.Size(126, 32);
            this.button_NextTick.TabIndex = 10;
            this.button_NextTick.Text = "Наступна";
            this.button_NextTick.UseVisualStyleBackColor = true;
            this.button_NextTick.Click += new System.EventHandler(this.Button_NextTick_Click);
            // 
            // checkBox_DisplayGrid
            // 
            this.checkBox_DisplayGrid.AutoSize = true;
            this.checkBox_DisplayGrid.Checked = true;
            this.checkBox_DisplayGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DisplayGrid.Location = new System.Drawing.Point(3, 3);
            this.checkBox_DisplayGrid.Name = "checkBox_DisplayGrid";
            this.checkBox_DisplayGrid.Size = new System.Drawing.Size(80, 27);
            this.checkBox_DisplayGrid.TabIndex = 14;
            this.checkBox_DisplayGrid.Text = "Сітки";
            this.checkBox_DisplayGrid.UseVisualStyleBackColor = true;
            this.checkBox_DisplayGrid.CheckedChanged += new System.EventHandler(this.CheckBox_Display_CheckedChanged);
            // 
            // checkBox_ShowDeadCell
            // 
            this.checkBox_ShowDeadCell.AutoSize = true;
            this.checkBox_ShowDeadCell.Location = new System.Drawing.Point(155, 3);
            this.checkBox_ShowDeadCell.Name = "checkBox_ShowDeadCell";
            this.checkBox_ShowDeadCell.Size = new System.Drawing.Size(113, 27);
            this.checkBox_ShowDeadCell.TabIndex = 15;
            this.checkBox_ShowDeadCell.Text = "Вмерлих";
            this.checkBox_ShowDeadCell.UseVisualStyleBackColor = true;
            this.checkBox_ShowDeadCell.CheckedChanged += new System.EventHandler(this.CheckBox_Display_CheckedChanged);
            // 
            // checkBox_ShowCreatedCell
            // 
            this.checkBox_ShowCreatedCell.AutoSize = true;
            this.checkBox_ShowCreatedCell.Location = new System.Drawing.Point(155, 36);
            this.checkBox_ShowCreatedCell.Name = "checkBox_ShowCreatedCell";
            this.checkBox_ShowCreatedCell.Size = new System.Drawing.Size(132, 27);
            this.checkBox_ShowCreatedCell.TabIndex = 16;
            this.checkBox_ShowCreatedCell.Text = "Створених";
            this.checkBox_ShowCreatedCell.UseVisualStyleBackColor = true;
            this.checkBox_ShowCreatedCell.CheckedChanged += new System.EventHandler(this.CheckBox_Display_CheckedChanged);
            // 
            // trackBar_AreaSize
            // 
            this.trackBar_AreaSize.LargeChange = 10;
            this.trackBar_AreaSize.Location = new System.Drawing.Point(62, 227);
            this.trackBar_AreaSize.Maximum = 120;
            this.trackBar_AreaSize.Minimum = 10;
            this.trackBar_AreaSize.Name = "trackBar_AreaSize";
            this.trackBar_AreaSize.Size = new System.Drawing.Size(251, 45);
            this.trackBar_AreaSize.SmallChange = 10;
            this.trackBar_AreaSize.TabIndex = 10;
            this.trackBar_AreaSize.TickFrequency = 0;
            this.trackBar_AreaSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_AreaSize.Value = 15;
            this.trackBar_AreaSize.Scroll += new System.EventHandler(this.TrackBar_AreaSize_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(201, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 23);
            this.label17.TabIndex = 19;
            this.label17.Text = "Живих";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 23);
            this.label18.TabIndex = 19;
            this.label18.Text = "Фону";
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
            this.panel2.Controls.Add(this.button_SetDefaultColors);
            this.panel2.Location = new System.Drawing.Point(17, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 135);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox_Grid
            // 
            this.pictureBox_Grid.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox_Grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Grid.Location = new System.Drawing.Point(91, 3);
            this.pictureBox_Grid.Name = "pictureBox_Grid";
            this.pictureBox_Grid.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_Grid.TabIndex = 17;
            this.pictureBox_Grid.TabStop = false;
            this.pictureBox_Grid.BackColorChanged += new System.EventHandler(this.PictureBox_Grid_BackColorChanged);
            this.pictureBox_Grid.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_AreaBackground
            // 
            this.pictureBox_AreaBackground.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_AreaBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_AreaBackground.Location = new System.Drawing.Point(91, 36);
            this.pictureBox_AreaBackground.Name = "pictureBox_AreaBackground";
            this.pictureBox_AreaBackground.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_AreaBackground.TabIndex = 17;
            this.pictureBox_AreaBackground.TabStop = false;
            this.pictureBox_AreaBackground.BackColorChanged += new System.EventHandler(this.PictureBox_AreaBackground_BackColorChanged);
            this.pictureBox_AreaBackground.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_LivingCell
            // 
            this.pictureBox_LivingCell.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox_LivingCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_LivingCell.Location = new System.Drawing.Point(291, 69);
            this.pictureBox_LivingCell.Name = "pictureBox_LivingCell";
            this.pictureBox_LivingCell.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_LivingCell.TabIndex = 17;
            this.pictureBox_LivingCell.TabStop = false;
            this.pictureBox_LivingCell.BackColorChanged += new System.EventHandler(this.PictureBox_LivingCell_BackColorChanged);
            this.pictureBox_LivingCell.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_CreatedCell
            // 
            this.pictureBox_CreatedCell.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox_CreatedCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_CreatedCell.Location = new System.Drawing.Point(291, 36);
            this.pictureBox_CreatedCell.Name = "pictureBox_CreatedCell";
            this.pictureBox_CreatedCell.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_CreatedCell.TabIndex = 17;
            this.pictureBox_CreatedCell.TabStop = false;
            this.pictureBox_CreatedCell.BackColorChanged += new System.EventHandler(this.PictureBox_CreatedCell_BackColorChanged);
            this.pictureBox_CreatedCell.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_DeadCell
            // 
            this.pictureBox_DeadCell.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox_DeadCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_DeadCell.Location = new System.Drawing.Point(291, 3);
            this.pictureBox_DeadCell.Name = "pictureBox_DeadCell";
            this.pictureBox_DeadCell.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_DeadCell.TabIndex = 17;
            this.pictureBox_DeadCell.TabStop = false;
            this.pictureBox_DeadCell.BackColorChanged += new System.EventHandler(this.PictureBox_DeadCell_BackColorChanged);
            this.pictureBox_DeadCell.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // button_SetDefaultColors
            // 
            this.button_SetDefaultColors.Location = new System.Drawing.Point(61, 99);
            this.button_SetDefaultColors.Name = "button_SetDefaultColors";
            this.button_SetDefaultColors.Size = new System.Drawing.Size(200, 32);
            this.button_SetDefaultColors.TabIndex = 7;
            this.button_SetDefaultColors.Text = "Скинути кольори";
            this.button_SetDefaultColors.UseVisualStyleBackColor = true;
            this.button_SetDefaultColors.Click += new System.EventHandler(this.Button_SetDefaultColors_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Поле гри";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Клітини";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(41, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Керування відображенням";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(41, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Керування генеруванням";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(48, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Керування полем";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(67, -116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(321, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Налаштувати відображення";
            // 
            // pictureBox_TimeValue
            // 
            this.pictureBox_TimeValue.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_TimeValue.Enabled = false;
            this.pictureBox_TimeValue.Image = global::Game_of_life.Properties.Resources.speed_icon_png_3_jpg;
            this.pictureBox_TimeValue.Location = new System.Drawing.Point(20, 63);
            this.pictureBox_TimeValue.Name = "pictureBox_TimeValue";
            this.pictureBox_TimeValue.Size = new System.Drawing.Size(46, 45);
            this.pictureBox_TimeValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TimeValue.TabIndex = 12;
            this.pictureBox_TimeValue.TabStop = false;
            // 
            // pictureBox_GridSize
            // 
            this.pictureBox_GridSize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_GridSize.Enabled = false;
            this.pictureBox_GridSize.Image = global::Game_of_life.Properties.Resources.grid;
            this.pictureBox_GridSize.Location = new System.Drawing.Point(18, 227);
            this.pictureBox_GridSize.Name = "pictureBox_GridSize";
            this.pictureBox_GridSize.Size = new System.Drawing.Size(46, 45);
            this.pictureBox_GridSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_GridSize.TabIndex = 12;
            this.pictureBox_GridSize.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.граToolStripMenuItem,
            this.полеToolStripMenuItem,
            this.допомогаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // граToolStripMenuItem
            // 
            this.граToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завершитиToolStripMenuItem1});
            this.граToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.граToolStripMenuItem.Name = "граToolStripMenuItem";
            this.граToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.граToolStripMenuItem.Text = "Гра";
            // 
            // завершитиToolStripMenuItem1
            // 
            this.завершитиToolStripMenuItem1.Name = "завершитиToolStripMenuItem1";
            this.завершитиToolStripMenuItem1.Size = new System.Drawing.Size(155, 24);
            this.завершитиToolStripMenuItem1.Text = "Завершити";
            this.завершитиToolStripMenuItem1.Click += new System.EventHandler(this.завершитиToolStripMenuItem1_Click);
            // 
            // полеToolStripMenuItem
            // 
            this.полеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заповнитиВипадковимЧиномToolStripMenuItem,
            this.очиститиToolStripMenuItem});
            this.полеToolStripMenuItem.Name = "полеToolStripMenuItem";
            this.полеToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.полеToolStripMenuItem.Text = "Поле";
            // 
            // заповнитиВипадковимЧиномToolStripMenuItem
            // 
            this.заповнитиВипадковимЧиномToolStripMenuItem.Name = "заповнитиВипадковимЧиномToolStripMenuItem";
            this.заповнитиВипадковимЧиномToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.заповнитиВипадковимЧиномToolStripMenuItem.Text = "Заповнити випадковим чином";
            this.заповнитиВипадковимЧиномToolStripMenuItem.Click += new System.EventHandler(this.Button_RandomFiling_Click);
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            this.очиститиToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.очиститиToolStripMenuItem.Text = "Очистити";
            this.очиститиToolStripMenuItem.Click += new System.EventHandler(this.Button_ClearArea_Click);
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаГриToolStripMenuItem,
            this.toolStripSeparator2,
            this.проПрограмуToolStripMenuItem});
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // правилаГриToolStripMenuItem
            // 
            this.правилаГриToolStripMenuItem.Name = "правилаГриToolStripMenuItem";
            this.правилаГриToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.правилаГриToolStripMenuItem.Text = "Правила гри";
            this.правилаГриToolStripMenuItem.Click += new System.EventHandler(this.правилаГриToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(893, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_Died);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_Created);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel_PlaingArea);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_GridSize);
            this.Controls.Add(this.pictureBox_TimeValue);
            this.Controls.Add(this.button_NextTick);
            this.Controls.Add(this.button_StartTime);
            this.Controls.Add(this.button_ClearArea);
            this.Controls.Add(this.button_RandomFiling);
            this.Controls.Add(this.trackBar_AreaSize);
            this.Controls.Add(this.trackBar_TimerTick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Generation);
            this.Controls.Add(this.label_Population);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "\"Гра життя\"";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TimerTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AreaSize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AreaBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LivingCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CreatedCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DeadCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TimeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GridSize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;

        private System.Windows.Forms.Panel panel_PlaingArea;

        private System.Windows.Forms.TrackBar trackBar_TimerTick;
        private System.Windows.Forms.TrackBar trackBar_AreaSize;

        private System.Windows.Forms.Button button_RandomFiling;
        private System.Windows.Forms.Button button_ClearArea;
        private System.Windows.Forms.Button button_StartTime;
        private System.Windows.Forms.Button button_NextTick;

        public System.Windows.Forms.CheckBox checkBox_DisplayGrid;
        public System.Windows.Forms.CheckBox checkBox_ShowDeadCell;
        public System.Windows.Forms.CheckBox checkBox_ShowCreatedCell;

        private System.Windows.Forms.ColorDialog colorDialog_SelectColor;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_SetDefaultColors;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.PictureBox pictureBox_Grid;
        public System.Windows.Forms.PictureBox pictureBox_AreaBackground;
        public System.Windows.Forms.PictureBox pictureBox_LivingCell;
        public System.Windows.Forms.PictureBox pictureBox_CreatedCell;
        public System.Windows.Forms.PictureBox pictureBox_DeadCell;
        public System.Windows.Forms.PictureBox pictureBox_TimeValue;
        public System.Windows.Forms.PictureBox pictureBox_GridSize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem граToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem полеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заповнитиВипадковимЧиномToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаГриToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
    }
}

