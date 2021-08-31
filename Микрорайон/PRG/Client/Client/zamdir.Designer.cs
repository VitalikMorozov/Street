namespace Микрорайон
{
    partial class zamdir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zamdir));
            this.tmMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Panel();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.MenuVert = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelData = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSved = new System.Windows.Forms.Button();
            this.TOPPAnel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnnRest = new System.Windows.Forms.PictureBox();
            this.btnnMin = new System.Windows.Forms.PictureBox();
            this.btnnMax = new System.Windows.Forms.PictureBox();
            this.btnnExit = new System.Windows.Forms.PictureBox();
            this.tmOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.btnExit.SuspendLayout();
            this.MenuVert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TOPPAnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnnRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnExit.Controls.Add(this.panelcontent);
            this.btnExit.Controls.Add(this.MenuVert);
            this.btnExit.Controls.Add(this.TOPPAnel);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(1300, 650);
            this.btnExit.TabIndex = 5;
            // 
            // panelcontent
            // 
            this.panelcontent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.Location = new System.Drawing.Point(184, 38);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(1116, 612);
            this.panelcontent.TabIndex = 11;
            // 
            // MenuVert
            // 
            this.MenuVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVert.Controls.Add(this.pictureBox1);
            this.MenuVert.Controls.Add(this.panelData);
            this.MenuVert.Controls.Add(this.panel3);
            this.MenuVert.Controls.Add(this.buttonSved);
            this.MenuVert.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVert.Location = new System.Drawing.Point(0, 38);
            this.MenuVert.Name = "MenuVert";
            this.MenuVert.Size = new System.Drawing.Size(184, 612);
            this.MenuVert.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-37, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelData
            // 
            this.panelData.Location = new System.Drawing.Point(12, 577);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(208, 35);
            this.panelData.TabIndex = 3;
            this.panelData.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 55);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonSved
            // 
            this.buttonSved.FlatAppearance.BorderSize = 0;
            this.buttonSved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSved.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSved.ForeColor = System.Drawing.Color.White;
            this.buttonSved.Image = ((System.Drawing.Image)(resources.GetObject("buttonSved.Image")));
            this.buttonSved.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSved.Location = new System.Drawing.Point(3, 185);
            this.buttonSved.Name = "buttonSved";
            this.buttonSved.Size = new System.Drawing.Size(205, 55);
            this.buttonSved.TabIndex = 2;
            this.buttonSved.Text = "Списки учеников";
            this.buttonSved.UseVisualStyleBackColor = true;
            this.buttonSved.Click += new System.EventHandler(this.buttonSved_Click_1);
            // 
            // TOPPAnel
            // 
            this.TOPPAnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.TOPPAnel.Controls.Add(this.button7);
            this.TOPPAnel.Controls.Add(this.btnnRest);
            this.TOPPAnel.Controls.Add(this.btnnMin);
            this.TOPPAnel.Controls.Add(this.btnnMax);
            this.TOPPAnel.Controls.Add(this.btnnExit);
            this.TOPPAnel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOPPAnel.Location = new System.Drawing.Point(0, 0);
            this.TOPPAnel.Name = "TOPPAnel";
            this.TOPPAnel.Size = new System.Drawing.Size(1300, 38);
            this.TOPPAnel.TabIndex = 10;
            this.TOPPAnel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOPPAnel_MouseDown);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(719, 32);
            this.button7.TabIndex = 14;
            this.button7.Text = "Заместитель директора по воспитательной работе - Добровольская Ирина Владимировна" +
    "\r\n\r\n";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnnRest
            // 
            this.btnnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnRest.Image = ((System.Drawing.Image)(resources.GetObject("btnnRest.Image")));
            this.btnnRest.Location = new System.Drawing.Point(1232, 7);
            this.btnnRest.Name = "btnnRest";
            this.btnnRest.Size = new System.Drawing.Size(25, 25);
            this.btnnRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnnRest.TabIndex = 3;
            this.btnnRest.TabStop = false;
            this.btnnRest.Visible = false;
            this.btnnRest.Click += new System.EventHandler(this.btnnRest_Click);
            // 
            // btnnMin
            // 
            this.btnnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnnMin.Image")));
            this.btnnMin.Location = new System.Drawing.Point(1201, 7);
            this.btnnMin.Name = "btnnMin";
            this.btnnMin.Size = new System.Drawing.Size(25, 25);
            this.btnnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnnMin.TabIndex = 2;
            this.btnnMin.TabStop = false;
            this.btnnMin.Click += new System.EventHandler(this.btnnMin_Click);
            // 
            // btnnMax
            // 
            this.btnnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnnMax.Image")));
            this.btnnMax.Location = new System.Drawing.Point(1232, 7);
            this.btnnMax.Name = "btnnMax";
            this.btnnMax.Size = new System.Drawing.Size(25, 25);
            this.btnnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnnMax.TabIndex = 1;
            this.btnnMax.TabStop = false;
            this.btnnMax.Click += new System.EventHandler(this.btnnMax_Click_1);
            // 
            // btnnExit
            // 
            this.btnnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnnExit.Image")));
            this.btnnExit.Location = new System.Drawing.Point(1263, 7);
            this.btnnExit.Name = "btnnExit";
            this.btnnExit.Size = new System.Drawing.Size(25, 25);
            this.btnnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnnExit.TabIndex = 0;
            this.btnnExit.TabStop = false;
            this.btnnExit.Click += new System.EventHandler(this.btnnExit_Click);
            // 
            // zamdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "zamdir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zamdir";
            this.Load += new System.EventHandler(this.zamdir_Load);
            this.btnExit.ResumeLayout(false);
            this.MenuVert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TOPPAnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnnRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmMostrarMenu;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Panel btnExit;
        private System.Windows.Forms.Timer tmOcultarMenu;
        public System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Panel MenuVert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSved;
        private System.Windows.Forms.Panel TOPPAnel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox btnnRest;
        private System.Windows.Forms.PictureBox btnnMin;
        private System.Windows.Forms.PictureBox btnnMax;
        private System.Windows.Forms.PictureBox btnnExit;
    }
}