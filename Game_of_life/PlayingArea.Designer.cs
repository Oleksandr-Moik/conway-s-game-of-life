﻿namespace Game_of_life
{
    partial class PlayingArea
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PlayingArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "PlayingArea";
            this.Size = new System.Drawing.Size(247, 243);
            this.Load += new System.EventHandler(this.PlayingArea_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayingArea_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayingArea_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayingArea_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayingArea_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayingArea_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
