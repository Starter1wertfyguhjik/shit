namespace Kill_Stars
{
    partial class nameKillStars
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginString = new System.Windows.Forms.TextBox();
            this.loginStr = new System.Windows.Forms.Label();
            this.passwordTex = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textWar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kill_Stars.Properties.Resources.War;
            this.pictureBox2.Location = new System.Drawing.Point(271, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(532, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::Kill_Stars.Properties.Resources.kill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginString
            // 
            this.loginString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(166)))), ((int)(((byte)(160)))));
            this.loginString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginString.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginString.Location = new System.Drawing.Point(419, 134);
            this.loginString.Name = "loginString";
            this.loginString.Size = new System.Drawing.Size(202, 55);
            this.loginString.TabIndex = 0;
            // 
            // loginStr
            // 
            this.loginStr.AutoSize = true;
            this.loginStr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginStr.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStr.ForeColor = System.Drawing.SystemColors.Desktop;
            this.loginStr.Location = new System.Drawing.Point(473, 94);
            this.loginStr.Name = "loginStr";
            this.loginStr.Size = new System.Drawing.Size(89, 37);
            this.loginStr.TabIndex = 3;
            this.loginStr.Text = "Login";
            // 
            // passwordTex
            // 
            this.passwordTex.AutoSize = true;
            this.passwordTex.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordTex.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordTex.Location = new System.Drawing.Point(449, 214);
            this.passwordTex.Name = "passwordTex";
            this.passwordTex.Size = new System.Drawing.Size(144, 37);
            this.passwordTex.TabIndex = 4;
            this.passwordTex.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(166)))), ((int)(((byte)(160)))));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(419, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 55);
            this.textBox1.TabIndex = 5;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // textWar
            // 
            this.textWar.AutoSize = true;
            this.textWar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textWar.Font = new System.Drawing.Font("Snap ITC", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textWar.Location = new System.Drawing.Point(12, 314);
            this.textWar.Name = "textWar";
            this.textWar.Size = new System.Drawing.Size(224, 43);
            this.textWar.TabIndex = 6;
            this.textWar.Text = "Star Wars";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(663, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exite";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameKillStars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textWar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passwordTex);
            this.Controls.Add(this.loginStr);
            this.Controls.Add(this.loginString);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "nameKillStars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kill Stars";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginString;
        private System.Windows.Forms.Label loginStr;
        private System.Windows.Forms.Label passwordTex;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textWar;
        private System.Windows.Forms.Label label1;
    }
}

