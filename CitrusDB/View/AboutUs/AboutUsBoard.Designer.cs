namespace CitrusDB.View.AboutUs
{
  partial class AboutUsBoard
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.buttonTelegram = new System.Windows.Forms.Button();
      this.buttonTwitter = new System.Windows.Forms.Button();
      this.buttonInsta = new System.Windows.Forms.Button();
      this.buttonFaceBook = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.SystemColors.Control;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Enabled = false;
      this.textBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic,
        System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.textBox1.Location = new System.Drawing.Point(39, 62);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(599, 284);
      this.textBox1.TabIndex = 0;
      this.textBox1.TabStop = false;
      this.textBox1.Text = "\"This program was designed to facilitate the work of the personnel department. Wi" +
                           "th its help, you can easily and conveniently manage information about students a" +
                           "nd staff of the university.\"";
      // 
      // textBox2
      // 
      this.textBox2.BackColor = System.Drawing.SystemColors.Control;
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.textBox2.Location = new System.Drawing.Point(39, 592);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(347, 30);
      this.textBox2.TabIndex = 2;
      this.textBox2.Text = "Student of NURE, Alexandr Torba.";
      // 
      // buttonTelegram
      // 
      this.buttonTelegram.FlatAppearance.BorderSize = 0;
      this.buttonTelegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonTelegram.Image = global::CitrusDB.Properties.Resources.icons8_Telegram_App_42px;
      this.buttonTelegram.Location = new System.Drawing.Point(783, 584);
      this.buttonTelegram.Name = "buttonTelegram";
      this.buttonTelegram.Size = new System.Drawing.Size(39, 38);
      this.buttonTelegram.TabIndex = 6;
      this.buttonTelegram.UseVisualStyleBackColor = true;
      // 
      // buttonTwitter
      // 
      this.buttonTwitter.FlatAppearance.BorderSize = 0;
      this.buttonTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonTwitter.Image = global::CitrusDB.Properties.Resources.icons8_Twitter_42px;
      this.buttonTwitter.Location = new System.Drawing.Point(828, 584);
      this.buttonTwitter.Name = "buttonTwitter";
      this.buttonTwitter.Size = new System.Drawing.Size(39, 38);
      this.buttonTwitter.TabIndex = 5;
      this.buttonTwitter.UseVisualStyleBackColor = true;
      // 
      // buttonInsta
      // 
      this.buttonInsta.FlatAppearance.BorderSize = 0;
      this.buttonInsta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonInsta.Image = global::CitrusDB.Properties.Resources.icons8_Instagram_42px;
      this.buttonInsta.Location = new System.Drawing.Point(738, 584);
      this.buttonInsta.Name = "buttonInsta";
      this.buttonInsta.Size = new System.Drawing.Size(39, 38);
      this.buttonInsta.TabIndex = 4;
      this.buttonInsta.UseVisualStyleBackColor = true;
      // 
      // buttonFaceBook
      // 
      this.buttonFaceBook.FlatAppearance.BorderSize = 0;
      this.buttonFaceBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonFaceBook.Image = global::CitrusDB.Properties.Resources.icons8_Facebook_42px;
      this.buttonFaceBook.Location = new System.Drawing.Point(693, 584);
      this.buttonFaceBook.Name = "buttonFaceBook";
      this.buttonFaceBook.Size = new System.Drawing.Size(39, 38);
      this.buttonFaceBook.TabIndex = 3;
      this.buttonFaceBook.UseVisualStyleBackColor = true;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(607, 174);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(285, 228);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // AboutUsBoard
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.AutoSize = true;
      this.Controls.Add(this.buttonTelegram);
      this.Controls.Add(this.buttonTwitter);
      this.Controls.Add(this.buttonInsta);
      this.Controls.Add(this.buttonFaceBook);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.textBox1);
      this.Name = "AboutUsBoard";
      this.Size = new System.Drawing.Size(928, 650);
      ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button buttonFaceBook;
    private System.Windows.Forms.Button buttonInsta;
    private System.Windows.Forms.Button buttonTwitter;
    private System.Windows.Forms.Button buttonTelegram;
  }
}
