using CitrusDB.View.UsersElements;

namespace CitrusDB.View.AddGroup.StudentView
{
    partial class StudentViewBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentViewBoard));
            this.studentViewPhoto = new System.Windows.Forms.PictureBox();
            this.fisrtNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addStudentButton = new CirclusButton();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // studentViewPhoto
            // 
            this.studentViewPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentViewPhoto.Location = new System.Drawing.Point(3, 3);
            this.studentViewPhoto.Name = "studentViewPhoto";
            this.studentViewPhoto.Size = new System.Drawing.Size(128, 137);
            this.studentViewPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentViewPhoto.TabIndex = 0;
            this.studentViewPhoto.TabStop = false;
            // 
            // fisrtNameTextBox
            // 
            this.fisrtNameTextBox.Location = new System.Drawing.Point(4, 146);
            this.fisrtNameTextBox.Name = "fisrtNameTextBox";
            this.fisrtNameTextBox.ReadOnly = true;
            this.fisrtNameTextBox.Size = new System.Drawing.Size(127, 22);
            this.fisrtNameTextBox.TabIndex = 1;
            this.fisrtNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(4, 174);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(127, 22);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addStudentButton.FlatAppearance.BorderSize = 0;
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("addStudentButton.Image")));
            this.addStudentButton.Location = new System.Drawing.Point(47, 201);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(34, 29);
            this.addStudentButton.TabIndex = 3;
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // StudentViewBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.fisrtNameTextBox);
            this.Controls.Add(this.studentViewPhoto);
            this.Name = "StudentViewBoard";
            this.Size = new System.Drawing.Size(135, 242);
            ((System.ComponentModel.ISupportInitialize)(this.studentViewPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox studentViewPhoto;
        public System.Windows.Forms.TextBox fisrtNameTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        private CirclusButton addStudentButton;
    }
}
