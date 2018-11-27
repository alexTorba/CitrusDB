namespace CitrusDB.View.Students.StudentsView.EditStudentView
{
    partial class EditStudentViewBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentViewBoard));
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentViewPhoto = new System.Windows.Forms.PictureBox();
            this.editStudentButton = new CitrusDB.View.UsersElements.CirclusButton();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(4, 148);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(118, 22);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(4, 120);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(118, 22);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studentViewPhoto
            // 
            this.studentViewPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentViewPhoto.Location = new System.Drawing.Point(3, 3);
            this.studentViewPhoto.Name = "studentViewPhoto";
            this.studentViewPhoto.Size = new System.Drawing.Size(119, 110);
            this.studentViewPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentViewPhoto.TabIndex = 4;
            this.studentViewPhoto.TabStop = false;
            this.studentViewPhoto.DoubleClick += new System.EventHandler(this.studentViewPhoto_DoubleClick);
            // 
            // editStudentButton
            // 
            this.editStudentButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editStudentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editStudentButton.FlatAppearance.BorderSize = 0;
            this.editStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("editStudentButton.Image")));
            this.editStudentButton.Location = new System.Drawing.Point(47, 175);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(32, 28);
            this.editStudentButton.TabIndex = 7;
            this.editStudentButton.UseVisualStyleBackColor = false;
            this.editStudentButton.Click += new System.EventHandler(this.editStudentButton_Click);
            // 
            // EditStudentViewBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editStudentButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.studentViewPhoto);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.Name = "EditStudentViewBoard";
            this.Size = new System.Drawing.Size(126, 206);
            ((System.ComponentModel.ISupportInitialize)(this.studentViewPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UsersElements.CirclusButton editStudentButton;
        public System.Windows.Forms.TextBox lastNameTextBox;
        public System.Windows.Forms.TextBox firstNameTextBox;
        public System.Windows.Forms.PictureBox studentViewPhoto;
    }
}
