namespace tamogoji
{
    partial class Form1
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
            this.pet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pet)).BeginInit();
            this.SuspendLayout();
            // 
            // pet
            // 
            this.pet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pet.Location = new System.Drawing.Point(114, 112);
            this.pet.Name = "pet";
            this.pet.Size = new System.Drawing.Size(275, 355);
            this.pet.TabIndex = 0;
            this.pet.TabStop = false;
            this.pet.Click += new System.EventHandler(this.Danse);
            this.pet.DoubleClick += new System.EventHandler(this.MovePet);
            this.pet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Danse);
            this.pet.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.pet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePet);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(810, 503);
            this.Controls.Add(this.pet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tamogoji";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pet;
    }
}

