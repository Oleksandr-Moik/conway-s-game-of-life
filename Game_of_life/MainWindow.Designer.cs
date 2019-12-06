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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Grid = new System.Windows.Forms.PictureBox();
            this.pictureBox_AreaBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox_LivingCell = new System.Windows.Forms.PictureBox();
            this.pictureBox_CreatedCell = new System.Windows.Forms.PictureBox();
            this.pictureBox_DeadCell = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Time = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_TimerTick)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(15, 9);
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
            this.label2.Location = new System.Drawing.Point(15, 34);
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
            this.label3.Location = new System.Drawing.Point(201, 34);
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
            this.label4.Location = new System.Drawing.Point(201, 9);
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
            this.label_Population.Location = new System.Drawing.Point(135, 9);
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
            this.label_Generation.Location = new System.Drawing.Point(135, 34);
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
            this.label_Died.Location = new System.Drawing.Point(319, 34);
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
            this.label_Created.Location = new System.Drawing.Point(319, 9);
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
            this.panel_PlaingArea.Location = new System.Drawing.Point(391, 7);
            this.panel_PlaingArea.Name = "panel_PlaingArea";
            this.panel_PlaingArea.Size = new System.Drawing.Size(500, 500);
            this.panel_PlaingArea.TabIndex = 2;
            this.panel_PlaingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_PlaingArea_Paint);
            this.panel_PlaingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_PlaingArea_MouseClick);
            // 
            // trackBar_TimerTick
            // 
            this.trackBar_TimerTick.LargeChange = 2;
            this.trackBar_TimerTick.Location = new System.Drawing.Point(71, 122);
            this.trackBar_TimerTick.Maximum = 9;
            this.trackBar_TimerTick.Name = "trackBar_TimerTick";
            this.trackBar_TimerTick.Size = new System.Drawing.Size(314, 45);
            this.trackBar_TimerTick.TabIndex = 1;
            this.trackBar_TimerTick.TickFrequency = 0;
            this.trackBar_TimerTick.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_TimerTick.Value = 4;
            this.trackBar_TimerTick.Scroll += new System.EventHandler(this.TrackBar_TimerTick_Scroll);
            // 
            // button_RandomFiling
            // 
            this.button_RandomFiling.Location = new System.Drawing.Point(18, 193);
            this.button_RandomFiling.Name = "button_RandomFiling";
            this.button_RandomFiling.Size = new System.Drawing.Size(166, 32);
            this.button_RandomFiling.TabIndex = 7;
            this.button_RandomFiling.Text = "Випадково";
            this.button_RandomFiling.UseVisualStyleBackColor = true;
            this.button_RandomFiling.Click += new System.EventHandler(this.Button_RandomFiling_Click);
            // 
            // button_ClearArea
            // 
            this.button_ClearArea.Location = new System.Drawing.Point(213, 195);
            this.button_ClearArea.Name = "button_ClearArea";
            this.button_ClearArea.Size = new System.Drawing.Size(172, 32);
            this.button_ClearArea.TabIndex = 7;
            this.button_ClearArea.Text = "Очистити";
            this.button_ClearArea.UseVisualStyleBackColor = true;
            this.button_ClearArea.Click += new System.EventHandler(this.Button_ClearArea_Click);
            // 
            // button_StartTime
            // 
            this.button_StartTime.Location = new System.Drawing.Point(213, 84);
            this.button_StartTime.Name = "button_StartTime";
            this.button_StartTime.Size = new System.Drawing.Size(172, 32);
            this.button_StartTime.TabIndex = 10;
            this.button_StartTime.Text = "Почати";
            this.button_StartTime.UseVisualStyleBackColor = true;
            this.button_StartTime.Click += new System.EventHandler(this.Button_StartTime_Click);
            // 
            // button_NextTick
            // 
            this.button_NextTick.Location = new System.Drawing.Point(19, 84);
            this.button_NextTick.Name = "button_NextTick";
            this.button_NextTick.Size = new System.Drawing.Size(166, 32);
            this.button_NextTick.TabIndex = 10;
            this.button_NextTick.Text = "Наступне";
            this.button_NextTick.UseVisualStyleBackColor = true;
            this.button_NextTick.Click += new System.EventHandler(this.Button_NextTick_Click);
            // 
            // checkBox_DisplayGrid
            // 
            this.checkBox_DisplayGrid.AutoSize = true;
            this.checkBox_DisplayGrid.Checked = true;
            this.checkBox_DisplayGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DisplayGrid.Location = new System.Drawing.Point(12, 3);
            this.checkBox_DisplayGrid.Name = "checkBox_DisplayGrid";
            this.checkBox_DisplayGrid.Size = new System.Drawing.Size(79, 27);
            this.checkBox_DisplayGrid.TabIndex = 14;
            this.checkBox_DisplayGrid.Text = "Сітку";
            this.checkBox_DisplayGrid.UseVisualStyleBackColor = true;
            this.checkBox_DisplayGrid.CheckedChanged += new System.EventHandler(this.CheckBox_Display_CheckedChanged);
            // 
            // checkBox_ShowDeadCell
            // 
            this.checkBox_ShowDeadCell.AutoSize = true;
            this.checkBox_ShowDeadCell.Location = new System.Drawing.Point(182, 3);
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
            this.checkBox_ShowCreatedCell.Location = new System.Drawing.Point(182, 36);
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
            this.trackBar_AreaSize.Location = new System.Drawing.Point(62, 233);
            this.trackBar_AreaSize.Maximum = 120;
            this.trackBar_AreaSize.Minimum = 10;
            this.trackBar_AreaSize.Name = "trackBar_AreaSize";
            this.trackBar_AreaSize.Size = new System.Drawing.Size(322, 45);
            this.trackBar_AreaSize.SmallChange = 10;
            this.trackBar_AreaSize.TabIndex = 10;
            this.trackBar_AreaSize.TickFrequency = 0;
            this.trackBar_AreaSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_AreaSize.Value = 20;
            this.trackBar_AreaSize.Scroll += new System.EventHandler(this.TrackBar_AreaSize_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(238, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 23);
            this.label17.TabIndex = 19;
            this.label17.Text = "Живі";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 33);
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
            this.panel2.Location = new System.Drawing.Point(18, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 115);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox_Grid
            // 
            this.pictureBox_Grid.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox_Grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Grid.Location = new System.Drawing.Point(97, 3);
            this.pictureBox_Grid.Name = "pictureBox_Grid";
            this.pictureBox_Grid.Size = new System.Drawing.Size(52, 27);
            this.pictureBox_Grid.TabIndex = 17;
            this.pictureBox_Grid.TabStop = false;
            this.pictureBox_Grid.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_AreaBackground
            // 
            this.pictureBox_AreaBackground.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_AreaBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_AreaBackground.Location = new System.Drawing.Point(97, 36);
            this.pictureBox_AreaBackground.Name = "pictureBox_AreaBackground";
            this.pictureBox_AreaBackground.Size = new System.Drawing.Size(52, 27);
            this.pictureBox_AreaBackground.TabIndex = 17;
            this.pictureBox_AreaBackground.TabStop = false;
            this.pictureBox_AreaBackground.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_LivingCell
            // 
            this.pictureBox_LivingCell.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox_LivingCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_LivingCell.Location = new System.Drawing.Point(314, 69);
            this.pictureBox_LivingCell.Name = "pictureBox_LivingCell";
            this.pictureBox_LivingCell.Size = new System.Drawing.Size(52, 27);
            this.pictureBox_LivingCell.TabIndex = 17;
            this.pictureBox_LivingCell.TabStop = false;
            this.pictureBox_LivingCell.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_CreatedCell
            // 
            this.pictureBox_CreatedCell.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox_CreatedCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_CreatedCell.Location = new System.Drawing.Point(315, 36);
            this.pictureBox_CreatedCell.Name = "pictureBox_CreatedCell";
            this.pictureBox_CreatedCell.Size = new System.Drawing.Size(52, 27);
            this.pictureBox_CreatedCell.TabIndex = 17;
            this.pictureBox_CreatedCell.TabStop = false;
            this.pictureBox_CreatedCell.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox_DeadCell
            // 
            this.pictureBox_DeadCell.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox_DeadCell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_DeadCell.Location = new System.Drawing.Point(314, 3);
            this.pictureBox_DeadCell.Name = "pictureBox_DeadCell";
            this.pictureBox_DeadCell.Size = new System.Drawing.Size(52, 27);
            this.pictureBox_DeadCell.TabIndex = 17;
            this.pictureBox_DeadCell.TabStop = false;
            this.pictureBox_DeadCell.Click += new System.EventHandler(this.PictureBox_SelectColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Game_of_life.Properties.Resources.grid;
            this.pictureBox1.Location = new System.Drawing.Point(18, 233);
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
            this.pictureBox_Time.Location = new System.Drawing.Point(19, 122);
            this.pictureBox_Time.Name = "pictureBox_Time";
            this.pictureBox_Time.Size = new System.Drawing.Size(46, 45);
            this.pictureBox_Time.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Time.TabIndex = 12;
            this.pictureBox_Time.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Поле гри";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Клітини";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(36, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Налаштувати відображення";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 526);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel_PlaingArea);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_Time);
            this.Controls.Add(this.button_NextTick);
            this.Controls.Add(this.button_StartTime);
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
        private System.Windows.Forms.Button button_RandomFiling;
        private System.Windows.Forms.Button button_ClearArea;
        private System.Windows.Forms.Button button_StartTime;
        private System.Windows.Forms.Button button_NextTick;
        private System.Windows.Forms.PictureBox pictureBox_Time;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

