namespace Микрорайон
{
    partial class ulica
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
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label gORODLabel;
            System.Windows.Forms.Label uLICALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ulica));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ulicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulicaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.nACHDANNBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ulicaDataGridView = new System.Windows.Forms.DataGridView();
            this.iDУлицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNDEXGORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gORODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLICADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uLICATextBox = new System.Windows.Forms.TextBox();
            this.gORODTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.MenuVert = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nACH_DANNTableAdapter = new Микрорайон.AKTDataSetTableAdapters.NACH_DANNTableAdapter();
            this.tableAdapterManager1 = new Микрорайон.AKTDataSetTableAdapters.TableAdapterManager();
            названиеLabel = new System.Windows.Forms.Label();
            gORODLabel = new System.Windows.Forms.Label();
            uLICALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ulicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulicaBindingNavigator)).BeginInit();
            this.ulicaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nACHDANNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulicaDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.MenuVert.SuspendLayout();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            названиеLabel.ForeColor = System.Drawing.Color.White;
            названиеLabel.Location = new System.Drawing.Point(3, 51);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(73, 21);
            названиеLabel.TabIndex = 31;
            названиеLabel.Text = "Индекс:";
            // 
            // gORODLabel
            // 
            gORODLabel.AutoSize = true;
            gORODLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            gORODLabel.ForeColor = System.Drawing.Color.White;
            gORODLabel.Location = new System.Drawing.Point(3, 84);
            gORODLabel.Name = "gORODLabel";
            gORODLabel.Size = new System.Drawing.Size(61, 21);
            gORODLabel.TabIndex = 32;
            gORODLabel.Text = "Город:";
            // 
            // uLICALabel
            // 
            uLICALabel.AutoSize = true;
            uLICALabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            uLICALabel.ForeColor = System.Drawing.Color.White;
            uLICALabel.Location = new System.Drawing.Point(3, 117);
            uLICALabel.Name = "uLICALabel";
            uLICALabel.Size = new System.Drawing.Size(64, 21);
            uLICALabel.TabIndex = 33;
            uLICALabel.Text = "Улица:";
            // 
            // ulicaBindingSource
            // 
            this.ulicaBindingSource.DataMember = "Ulica";
            // 
            // ulicaBindingNavigator
            // 
            this.ulicaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ulicaBindingNavigator.BindingSource = this.nACHDANNBindingSource;
            this.ulicaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ulicaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ulicaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.ulicaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ulicaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ulicaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ulicaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ulicaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ulicaBindingNavigator.Name = "ulicaBindingNavigator";
            this.ulicaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ulicaBindingNavigator.Size = new System.Drawing.Size(978, 25);
            this.ulicaBindingNavigator.TabIndex = 0;
            this.ulicaBindingNavigator.Text = "bindingNavigator1";
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
            // nACHDANNBindingSource
            // 
            this.nACHDANNBindingSource.DataMember = "NACH_DANN";
            this.nACHDANNBindingSource.DataSource = this.aKTDataSet;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Редактирование";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ulicaDataGridView
            // 
            this.ulicaDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ulicaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ulicaDataGridView.AutoGenerateColumns = false;
            this.ulicaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ulicaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ulicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ulicaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDУлицаDataGridViewTextBoxColumn,
            this.iNDEXGORDataGridViewTextBoxColumn,
            this.gORODDataGridViewTextBoxColumn,
            this.uLICADataGridViewTextBoxColumn});
            this.ulicaDataGridView.DataSource = this.nACHDANNBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ulicaDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ulicaDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ulicaDataGridView.Location = new System.Drawing.Point(0, 25);
            this.ulicaDataGridView.Name = "ulicaDataGridView";
            this.ulicaDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ulicaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ulicaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ulicaDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ulicaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ulicaDataGridView.Size = new System.Drawing.Size(978, 382);
            this.ulicaDataGridView.TabIndex = 1;
            this.ulicaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ulicaDataGridView_CellContentClick);
            // 
            // iDУлицаDataGridViewTextBoxColumn
            // 
            this.iDУлицаDataGridViewTextBoxColumn.DataPropertyName = "ID_Улица";
            this.iDУлицаDataGridViewTextBoxColumn.HeaderText = "ID_Улица";
            this.iDУлицаDataGridViewTextBoxColumn.Name = "iDУлицаDataGridViewTextBoxColumn";
            this.iDУлицаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDУлицаDataGridViewTextBoxColumn.Visible = false;
            // 
            // iNDEXGORDataGridViewTextBoxColumn
            // 
            this.iNDEXGORDataGridViewTextBoxColumn.DataPropertyName = "INDEX_GOR";
            this.iNDEXGORDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.iNDEXGORDataGridViewTextBoxColumn.Name = "iNDEXGORDataGridViewTextBoxColumn";
            this.iNDEXGORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gORODDataGridViewTextBoxColumn
            // 
            this.gORODDataGridViewTextBoxColumn.DataPropertyName = "GOROD";
            this.gORODDataGridViewTextBoxColumn.HeaderText = "Город";
            this.gORODDataGridViewTextBoxColumn.Name = "gORODDataGridViewTextBoxColumn";
            this.gORODDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uLICADataGridViewTextBoxColumn
            // 
            this.uLICADataGridViewTextBoxColumn.DataPropertyName = "ULICA";
            this.uLICADataGridViewTextBoxColumn.HeaderText = "Улица";
            this.uLICADataGridViewTextBoxColumn.Name = "uLICADataGridViewTextBoxColumn";
            this.uLICADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 407);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(978, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(uLICALabel);
            this.panel1.Controls.Add(this.uLICATextBox);
            this.panel1.Controls.Add(gORODLabel);
            this.panel1.Controls.Add(this.gORODTextBox);
            this.panel1.Controls.Add(названиеLabel);
            this.panel1.Controls.Add(this.названиеTextBox);
            this.panel1.Controls.Add(this.MenuVert);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 189);
            this.panel1.TabIndex = 29;
            this.panel1.Visible = false;
            // 
            // uLICATextBox
            // 
            this.uLICATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nACHDANNBindingSource, "ULICA", true));
            this.uLICATextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.uLICATextBox.Location = new System.Drawing.Point(137, 114);
            this.uLICATextBox.Name = "uLICATextBox";
            this.uLICATextBox.Size = new System.Drawing.Size(213, 27);
            this.uLICATextBox.TabIndex = 34;
            this.uLICATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gORODTextBox_KeyPress);
            // 
            // gORODTextBox
            // 
            this.gORODTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nACHDANNBindingSource, "GOROD", true));
            this.gORODTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gORODTextBox.Location = new System.Drawing.Point(137, 81);
            this.gORODTextBox.Name = "gORODTextBox";
            this.gORODTextBox.Size = new System.Drawing.Size(213, 27);
            this.gORODTextBox.TabIndex = 33;
            this.gORODTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gORODTextBox_KeyPress);
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nACHDANNBindingSource, "INDEX_GOR", true));
            this.названиеTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.названиеTextBox.Location = new System.Drawing.Point(137, 48);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(213, 27);
            this.названиеTextBox.TabIndex = 32;
            this.названиеTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.названиеTextBox_KeyPress_1);
            // 
            // MenuVert
            // 
            this.MenuVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVert.Controls.Add(this.panel5);
            this.MenuVert.Controls.Add(this.button1);
            this.MenuVert.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuVert.Location = new System.Drawing.Point(784, 0);
            this.MenuVert.Name = "MenuVert";
            this.MenuVert.Size = new System.Drawing.Size(194, 189);
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
            this.label1.Location = new System.Drawing.Point(361, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Добавление ";
            // 
            // nACH_DANNTableAdapter
            // 
            this.nACH_DANNTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AKTTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DOMTableAdapter = null;
            this.tableAdapterManager1.KlassRukTableAdapter = null;
            this.tableAdapterManager1.KlassTableAdapter = null;
            this.tableAdapterManager1.NACH_DANNTableAdapter = this.nACH_DANNTableAdapter;
            this.tableAdapterManager1.PROJ_VMESTETableAdapter = null;
            this.tableAdapterManager1.RODSTVOTableAdapter = null;
            this.tableAdapterManager1.UCHATableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Микрорайон.AKTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Xar_uchTableAdapter = null;
            // 
            // ulica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(978, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ulicaDataGridView);
            this.Controls.Add(this.ulicaBindingNavigator);
            this.Name = "ulica";
            this.Text = "ulica";
            this.Load += new System.EventHandler(this.ulica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ulicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulicaBindingNavigator)).EndInit();
            this.ulicaBindingNavigator.ResumeLayout(false);
            this.ulicaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nACHDANNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulicaDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuVert.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

   //     private GBUDataSet gBUDataSet;
        private System.Windows.Forms.BindingSource ulicaBindingSource;
     //   private GBUDataSetTableAdapters.UlicaTableAdapter ulicaTableAdapter;
       // private GBUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ulicaBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView ulicaDataGridView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.Panel MenuVert;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
        private AKTDataSet aKTDataSet;
        private System.Windows.Forms.BindingSource nACHDANNBindingSource;
        private AKTDataSetTableAdapters.NACH_DANNTableAdapter nACH_DANNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDУлицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNDEXGORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gORODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLICADataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox uLICATextBox;
        private System.Windows.Forms.TextBox gORODTextBox;
        private AKTDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}