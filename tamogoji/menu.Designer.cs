namespace tamogoji
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canselButton = new System.Windows.Forms.Button();
            this.rollUp = new System.Windows.Forms.Button();
            this.dialogueButton = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.ILoveYouButton = new System.Windows.Forms.PictureBox();
            this.DialogeWindow = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.DialogeText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dialogueButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ILoveYouButton)).BeginInit();
            this.SuspendLayout();
            // 
            // canselButton
            // 
            this.canselButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.canselButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.canselButton.Location = new System.Drawing.Point(454, 12);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(35, 25);
            this.canselButton.TabIndex = 0;
            this.canselButton.Text = "X";
            this.canselButton.UseVisualStyleBackColor = true;
            this.canselButton.Click += new System.EventHandler(this.Exit);
            // 
            // rollUp
            // 
            this.rollUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rollUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollUp.Location = new System.Drawing.Point(413, 11);
            this.rollUp.Name = "rollUp";
            this.rollUp.Size = new System.Drawing.Size(35, 25);
            this.rollUp.TabIndex = 1;
            this.rollUp.Text = "_";
            this.rollUp.UseVisualStyleBackColor = true;
            this.rollUp.Click += new System.EventHandler(this.rollUp_Click);
            // 
            // dialogueButton
            // 
            this.dialogueButton.Image = global::tamogoji.Properties.Resources.dialogueButtonOff;
            this.dialogueButton.Location = new System.Drawing.Point(12, 44);
            this.dialogueButton.Name = "dialogueButton";
            this.dialogueButton.Size = new System.Drawing.Size(231, 73);
            this.dialogueButton.TabIndex = 2;
            this.dialogueButton.TabStop = false;
            this.dialogueButton.Click += new System.EventHandler(this.dialogueButton_Click);
            this.dialogueButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changeTextureDown);
            this.dialogueButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.changeTextureUp);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(-155, 168);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 50);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changeTextureDown);
            this.ExitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.changeTextureUp);
            // 
            // ILoveYouButton
            // 
            this.ILoveYouButton.Image = global::tamogoji.Properties.Resources.ILoveYouOff;
            this.ILoveYouButton.Location = new System.Drawing.Point(249, 44);
            this.ILoveYouButton.Name = "ILoveYouButton";
            this.ILoveYouButton.Size = new System.Drawing.Size(226, 76);
            this.ILoveYouButton.TabIndex = 4;
            this.ILoveYouButton.TabStop = false;
            this.ILoveYouButton.Visible = false;
            this.ILoveYouButton.Click += new System.EventHandler(this.ILoveYouButton_Click);
            this.ILoveYouButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changeTextureDown);
            this.ILoveYouButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.changeTextureUp);
            // 
            // DialogeWindow
            // 
            this.DialogeWindow.BackColor = System.Drawing.Color.Violet;
            this.DialogeWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DialogeWindow.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DialogeWindow.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DialogeWindow.ForeColor = System.Drawing.Color.Purple;
            this.DialogeWindow.Location = new System.Drawing.Point(12, 268);
            this.DialogeWindow.Multiline = true;
            this.DialogeWindow.Name = "DialogeWindow";
            this.DialogeWindow.Size = new System.Drawing.Size(476, 229);
            this.DialogeWindow.TabIndex = 5;
            this.DialogeWindow.UseWaitCursor = true;
            // 
            // backButton
            // 
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(35, 26);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DialogeText
            // 
            this.DialogeText.AutoSize = true;
            this.DialogeText.BackColor = System.Drawing.Color.Violet;
            this.DialogeText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DialogeText.ForeColor = System.Drawing.Color.Purple;
            this.DialogeText.Location = new System.Drawing.Point(16, 271);
            this.DialogeText.Name = "DialogeText";
            this.DialogeText.Size = new System.Drawing.Size(53, 23);
            this.DialogeText.TabIndex = 7;
            this.DialogeText.Text = "label1";
            // 
            // menu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tamogoji.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(501, 509);
            this.Controls.Add(this.DialogeText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.DialogeWindow);
            this.Controls.Add(this.ILoveYouButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dialogueButton);
            this.Controls.Add(this.rollUp);
            this.Controls.Add(this.canselButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dialogueButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ILoveYouButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button canselButton;
        private System.Windows.Forms.Button rollUp;
        private System.Windows.Forms.PictureBox dialogueButton;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.PictureBox ILoveYouButton;
        private System.Windows.Forms.TextBox DialogeWindow;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label DialogeText;
    }
}