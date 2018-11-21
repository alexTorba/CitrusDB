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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.DoubleBuffered = false;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGrid.Location = new System.Drawing.Point(16, 61);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowHeadersWidth = 4;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(748, 706);
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
            this.buttonTables.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTables.Name = "buttonTables";
            this.buttonTables.Size = new System.Drawing.Size(285, 72);
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
            this.panelGroup.Location = new System.Drawing.Point(41, 0);
            this.panelGroup.Margin = new System.Windows.Forms.Padding(4);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(292, 811);
            this.panelGroup.TabIndex = 5;
            // 
            // flowGroupOptions
            // 
            this.flowGroupOptions.Controls.Add(this.panelTables);
            this.flowGroupOptions.Location = new System.Drawing.Point(4, 1);
            this.flowGroupOptions.Margin = new System.Windows.Forms.Padding(4);
            this.flowGroupOptions.Name = "flowGroupOptions";
            this.flowGroupOptions.Size = new System.Drawing.Size(289, 476);
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
            this.panelTables.Location = new System.Drawing.Point(4, 4);
            this.panelTables.Margin = new System.Windows.Forms.Padding(4);
            this.panelTables.MaximumSize = new System.Drawing.Size(285, 190);
            this.panelTables.MinimumSize = new System.Drawing.Size(285, 67);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(285, 190);
            this.panelTables.TabIndex = 6;
            this.panelTables.Tag = false;
            // 
            // radioButtonGroup
            // 
            this.radioButtonGroup.AutoSize = true;
            this.radioButtonGroup.Location = new System.Drawing.Point(246, 139);
            this.radioButtonGroup.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonGroup.Name = "radioButtonGroup";
            this.radioButtonGroup.Size = new System.Drawing.Size(17, 16);
            this.radioButtonGroup.TabIndex = 9;
            this.radioButtonGroup.TabStop = true;
            this.radioButtonGroup.UseVisualStyleBackColor = true;
            this.radioButtonGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonGroup_MouseClick);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(246, 81);
            this.radioButtonStudent.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(17, 16);
            this.radioButtonStudent.TabIndex = 7;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonStudent_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Groups :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Students :";
            // 
            // generPanelOptions
            // 
            this.generPanelOptions.Controls.Add(this.collapsedButton);
            this.generPanelOptions.Controls.Add(this.panelGroup);
            this.generPanelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.generPanelOptions.Location = new System.Drawing.Point(1050, 0);
            this.generPanelOptions.Margin = new System.Windows.Forms.Padding(4);
            this.generPanelOptions.MaximumSize = new System.Drawing.Size(334, 0);
            this.generPanelOptions.MinimumSize = new System.Drawing.Size(61, 0);
            this.generPanelOptions.Name = "generPanelOptions";
            this.generPanelOptions.Size = new System.Drawing.Size(61, 662);
            this.generPanelOptions.TabIndex = 6;
            this.generPanelOptions.Tag = false;
            // 
            // collapsedButton
            // 
            this.collapsedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.collapsedButton.FlatAppearance.BorderSize = 0;
            this.collapsedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapsedButton.Image = global::CitrusDB.Properties.Resources.left;
            this.collapsedButton.Location = new System.Drawing.Point(8, 486);
            this.collapsedButton.Margin = new System.Windows.Forms.Padding(4);
            this.collapsedButton.Name = "collapsedButton";
            this.collapsedButton.Size = new System.Drawing.Size(54, 56);
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
            this.contextMenuStrip.Size = new System.Drawing.Size(139, 76);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.changeToolStripMenuItem.Text = "Change";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // DataBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.generPanelOptions);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataBoard";
            this.Size = new System.Drawing.Size(1111, 662);
            this.Load += new System.EventHandler(this.DataBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panelGroup.ResumeLayout(false);
            this.flowGroupOptions.ResumeLayout(false);
            this.panelTables.ResumeLayout(false);
            this.panelTables.PerformLayout();
            this.generPanelOptions.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}
