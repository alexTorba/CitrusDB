using CitrusDB.View.UsersElements;

namespace CitrusDB.View.Students.StudentsView.AddedStudentView
{
    partial class AddedStudentViewBoard
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(AddedStudentViewBoard));
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new CitrusDB.View.UsersElements.CirclusButton();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(12, 7);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(87, 23);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lastNameTextBox.Location = new System.Drawing.Point(105, 7);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(87, 23);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Image = ((System.Drawing.Image) (resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(208, 3);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(31, 29);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddedStudentViewBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddedStudentViewBoard";
            this.Size = new System.Drawing.Size(250, 38);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddedStudentViewBoard_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private CitrusDB.View.UsersElements.CirclusButton cancelButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
    }
}
