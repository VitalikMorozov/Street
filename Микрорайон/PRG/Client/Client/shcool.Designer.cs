namespace Микрорайон
{
    partial class shcool
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
            System.Windows.Forms.Label nazLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shcool));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rODSTVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rODSTVOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.rODSTVOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aKTDataSet = new Микрорайон.AKTDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rODSTVODataGridView = new System.Windows.Forms.DataGridView();
            this.iDRODSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nazTextBox = new System.Windows.Forms.TextBox();
            this.MenuVert = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rODSTVOTableAdapter1 = new Микрорайон.AKTDataSetTableAdapters.RODSTVOTableAdapter();
            nazLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rODSTVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODSTVOBindingNavigator)).BeginInit();
            this.rODSTVOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rODSTVOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODSTVODataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.MenuVert.SuspendLayout();
            this.SuspendLayout();
            // 
            // nazLabel
            // 
            nazLabel.AutoSize = true;
            nazLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nazLabel.ForeColor = System.Drawing.Color.White;
            nazLabel.Location = new System.Drawing.Point(12, 68);
            nazLabel.Name = "nazLabel";
            nazLabel.Size = new System.Drawing.Size(91, 21);
            nazLabel.TabIndex = 31;
            nazLabel.Text = "Название:";
            // 
            // rODSTVOBindingSource
            // 
            this.rODSTVOBindingSource.DataMember = "RODSTVO";
            // 
            // rODSTVOBindingNavigator
            // 
            this.rODSTVOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rODSTVOBindingNavigator.BindingSource = this.rODSTVOBindingSource1;
            this.rODSTVOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rODSTVOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rODSTVOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.rODSTVOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rODSTVOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rODSTVOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rODSTVOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rODSTVOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rODSTVOBindingNavigator.Name = "rODSTVOBindingNavigator";
            this.rODSTVOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rODSTVOBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.rODSTVOBindingNavigator.TabIndex = 0;
            this.rODSTVOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // rODSTVOBindingSource1
            // 
            this.rODSTVOBindingSource1.DataMember = "RODSTVO";
            this.rODSTVOBindingSource1.DataSource = this.aKTDataSet;
            // 
            // aKTDataSet
            // 
            this.aKTDataSet.DataSetName = "AKTDataSet";
            this.aKTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rODSTVODataGridView
            // 
            this.rODSTVODataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rODSTVODataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rODSTVODataGridView.AutoGenerateColumns = false;
            this.rODSTVODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rODSTVODataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rODSTVODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rODSTVODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRODSTDataGridViewTextBoxColumn,
            this.nazDataGridViewTextBoxColumn});
            this.rODSTVODataGridView.DataSource = this.rODSTVOBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rODSTVODataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.rODSTVODataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.rODSTVODataGridView.Location = new System.Drawing.Point(0, 25);
            this.rODSTVODataGridView.Name = "rODSTVODataGridView";
            this.rODSTVODataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rODSTVODataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rODSTVODataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.rODSTVODataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rODSTVODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rODSTVODataGridView.Size = new System.Drawing.Size(800, 220);
            this.rODSTVODataGridView.TabIndex = 1;
            // 
            // iDRODSTDataGridViewTextBoxColumn
            // 
            this.iDRODSTDataGridViewTextBoxColumn.DataPropertyName = "ID_RODST";
            this.iDRODSTDataGridViewTextBoxColumn.HeaderText = "ID_RODST";
            this.iDRODSTDataGridViewTextBoxColumn.Name = "iDRODSTDataGridViewTextBoxColumn";
            this.iDRODSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRODSTDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazDataGridViewTextBoxColumn
            // 
            this.nazDataGridViewTextBoxColumn.DataPropertyName = "Naz";
            this.nazDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nazDataGridViewTextBoxColumn.Name = "nazDataGridViewTextBoxColumn";
            this.nazDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_RODST";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_RODST";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 245);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(800, 3);
            this.splitter1.TabIndex = 31;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(nazLabel);
            this.panel1.Controls.Add(this.nazTextBox);
            this.panel1.Controls.Add(this.MenuVert);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 205);
            this.panel1.TabIndex = 30;
            this.panel1.Visible = false;
            // 
            // nazTextBox
            // 
            this.nazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rODSTVOBindingSource1, "Naz", true));
            this.nazTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazTextBox.Location = new System.Drawing.Point(122, 65);
            this.nazTextBox.Name = "nazTextBox";
            this.nazTextBox.Size = new System.Drawing.Size(172, 27);
            this.nazTextBox.TabIndex = 32;
            this.nazTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nazTextBox_KeyPress);
            // 
            // MenuVert
            // 
            this.MenuVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVert.Controls.Add(this.panel5);
            this.MenuVert.Controls.Add(this.button1);
            this.MenuVert.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuVert.Location = new System.Drawing.Point(606, 0);
            this.MenuVert.Name = "MenuVert";
            this.MenuVert.Size = new System.Drawing.Size(194, 205);
            this.MenuVert.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(5, 68);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(186, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "   Подтвердить\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Добавление ";
            // 
            // rODSTVOTableAdapter1
            // 
            this.rODSTVOTableAdapter1.ClearBeforeFill = true;
            // 
            // shcool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rODSTVODataGridView);
            this.Controls.Add(this.rODSTVOBindingNavigator);
            this.Name = "shcool";
            this.Text = "shcool";
            this.Load += new System.EventHandler(this.shcool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rODSTVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODSTVOBindingNavigator)).EndInit();
            this.rODSTVOBindingNavigator.ResumeLayout(false);
            this.rODSTVOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rODSTVOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rODSTVODataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuVert.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    //    private GBUDataSet gBUDataSet;
        private System.Windows.Forms.BindingSource rODSTVOBindingSource;
      //  private GBUDataSetTableAdapters.RODSTVOTableAdapter rODSTVOTableAdapter;
      //  private GBUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rODSTVOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView rODSTVODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nazTextBox;
        private System.Windows.Forms.Panel MenuVert;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private AKTDataSet aKTDataSet;
        private System.Windows.Forms.BindingSource rODSTVOBindingSource1;
        private AKTDataSetTableAdapters.RODSTVOTableAdapter rODSTVOTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRODSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazDataGridViewTextBoxColumn;
    }
}