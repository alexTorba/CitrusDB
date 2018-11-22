using CitrusDB.Model.Entity;
using CitrusDB.View.UsersElements;

namespace CitrusDB.View.DataBoard
{
    partial class DataBoard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.buttonTables = new System.Windows.Forms.Button();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.flowGroupOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTables = new System.Windows.Forms.Panel();
            this.radioButtonGroup = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generPanelOptions = new System.Windows.Forms.Panel();
            this.collapsedButton = new CitrusDB.View.UsersElements.CirclusButton();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panelGroup.SuspendLayout();
            this.flowGroupOptions.SuspendLayout();
            this.panelTables.SuspendLayout();
            this.generPanelOptions.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.DoubleBuffered = false;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGrid.Location = new System.Drawing.Point(20, 49);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.RowHeadersWidth = 4;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(598, 580);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGrid_CellContextMenuStripNeeded);
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentDoubleClick);
            this.dataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_ColumnHeaderMouseClick);
            // 
            // buttonTables
            // 
            this.buttonTables.FlatAppearance.BorderSize = 0;
            this.buttonTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTables.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTables.ForeColor = System.Drawing.Color.White;
            this.buttonTables.Location = new System.Drawing.Point(0, 0);
            this.buttonTables.Name = "buttonTables";
            this.buttonTables.Size = new System.Drawing.Size(228, 58);
            this.buttonTables.TabIndex = 0;
            this.buttonTables.Text = "Tables :";
            this.buttonTables.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonTables.UseVisualStyleBackColor = true;
            this.buttonTables.Click += new System.EventHandler(this.buttonTables_Click);
            // 
            // panelGroup
            // 
            this.panelGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelGroup.Controls.Add(this.flowGroupOptions);
            this.panelGroup.Location = new System.Drawing.Point(33, 0);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(234, 649);
            this.panelGroup.TabIndex = 5;
            // 
            // flowGroupOptions
            // 
            this.flowGroupOptions.Controls.Add(this.panelTables);
            this.flowGroupOptions.Location = new System.Drawing.Point(3, 1);
            this.flowGroupOptions.Name = "flowGroupOptions";
            this.flowGroupOptions.Size = new System.Drawing.Size(231, 381);
            this.flowGroupOptions.TabIndex = 0;
            // 
            // panelTables
            // 
            this.panelTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTables.Controls.Add(this.radioButtonGroup);
            this.panelTables.Controls.Add(this.buttonTables);
            this.panelTables.Controls.Add(this.radioButtonStudent);
            this.panelTables.Controls.Add(this.label2);
            this.panelTables.Controls.Add(this.label1);
            this.panelTables.Location = new System.Drawing.Point(3, 3);
            this.panelTables.MaximumSize = new System.Drawing.Size(228, 152);
            this.panelTables.MinimumSize = new System.Drawing.Size(228, 54);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(228, 152);
            this.panelTables.TabIndex = 6;
            this.panelTables.Tag = false;
            // 
            // radioButtonGroup
            // 
            this.radioButtonGroup.AutoSize = true;
            this.radioButtonGroup.Location = new System.Drawing.Point(197, 111);
            this.radioButtonGroup.Name = "radioButtonGroup";
            this.radioButtonGroup.Size = new System.Drawing.Size(14, 13);
            this.radioButtonGroup.TabIndex = 9;
            this.radioButtonGroup.TabStop = true;
            this.radioButtonGroup.UseVisualStyleBackColor = true;
            this.radioButtonGroup.CheckedChanged += new System.EventHandler(this.radioButtonGroup_CheckedChanged);
            this.radioButtonGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonGroup_MouseClick);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(197, 65);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(14, 13);
            this.radioButtonStudent.TabIndex = 7;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.CheckedChanged += new System.EventHandler(this.radioButtonStudent_CheckedChanged);
            this.radioButtonStudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonStudent_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Groups :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Students :";
            // 
            // generPanelOptions
            // 
            this.generPanelOptions.Controls.Add(this.collapsedButton);
            this.generPanelOptions.Controls.Add(this.panelGroup);
            this.generPanelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.generPanelOptions.Location = new System.Drawing.Point(840, 0);
            this.generPanelOptions.MaximumSize = new System.Drawing.Size(267, 0);
            this.generPanelOptions.MinimumSize = new System.Drawing.Size(49, 0);
            this.generPanelOptions.Name = "generPanelOptions";
            this.generPanelOptions.Size = new System.Drawing.Size(49, 530);
            this.generPanelOptions.TabIndex = 6;
            this.generPanelOptions.Tag = false;
            // 
            // collapsedButton
            // 
            this.collapsedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.collapsedButton.FlatAppearance.BorderSize = 0;
            this.collapsedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapsedButton.Image = global::CitrusDB.Properties.Resources.left;
            this.collapsedButton.Location = new System.Drawing.Point(6, 389);
            this.collapsedButton.Name = "collapsedButton";
            this.collapsedButton.Size = new System.Drawing.Size(43, 45);
            this.collapsedButton.TabIndex = 7;
            this.collapsedButton.UseVisualStyleBackColor = false;
            this.collapsedButton.Click += new System.EventHandler(this.collapsedData_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.contextMenuStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(124, 70);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.changeToolStripMenuItem.Text = "Change";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(20, 15);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(171, 23);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.Text = "Search..";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // DataBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.generPanelOptions);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "DataBoard";
            this.Size = new System.Drawing.Size(889, 530);
            this.Load += new System.EventHandler(this.DataBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panelGroup.ResumeLayout(false);
            this.flowGroupOptions.ResumeLayout(false);
            this.panelTables.ResumeLayout(false);
            this.panelTables.PerformLayout();
            this.generPanelOptions.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid;
        private System.Windows.Forms.Button buttonTables;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.FlowLayoutPanel flowGroupOptions;
        private System.Windows.Forms.Panel panelTables;
        private System.Windows.Forms.RadioButton radioButtonGroup;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel generPanelOptions;
        private CirclusButton collapsedButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}
