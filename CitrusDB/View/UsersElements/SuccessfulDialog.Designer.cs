namespace CitrusDB.View.UsersElements
{
    partial class SuccessfulDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessfulDialog));
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.messageTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iconPictureBox.Image")));
            this.iconPictureBox.Location = new System.Drawing.Point(-81, -47);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(515, 269);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = null;
            this.bunifuDragControl.Vertical = true;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1550;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageTextBox.ForeColor = System.Drawing.Color.White;
            this.messageTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.messageTextBox.Location = new System.Drawing.Point(37, 153);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(282, 22);
            this.messageTextBox.TabIndex = 0;
            this.messageTextBox.TabStop = false;
            this.messageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SuccessfulDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 208);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.iconPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccessfulDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessfulDialog";
            this.Load += new System.EventHandler(this.SuccessfulDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconPictureBox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}