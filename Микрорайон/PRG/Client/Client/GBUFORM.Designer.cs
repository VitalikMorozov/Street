namespace Микрорайон
{
    partial class GBUFORM
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.view_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
        //    this.GBUDataSet = new Микрорайон.GBUDataSet();
            this.OBSLEDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoditeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UlicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.OBSLEDTableAdapter = new Микрорайон.GBUDataSetTableAdapters.OBSLEDTableAdapter();
            //this.DetiTableAdapter = new Микрорайон.GBUDataSetTableAdapters.DetiTableAdapter();
            //this.RoditeliTableAdapter = new Микрорайон.GBUDataSetTableAdapters.RoditeliTableAdapter();
            //this.UlicaTableAdapter = new Микрорайон.GBUDataSetTableAdapters.UlicaTableAdapter();
            //this.view_2TableAdapter = new Микрорайон.GBUDataSetTableAdapters.View_2TableAdapter();
            //this.tableAdapterManager = new Микрорайон.GBUDataSetTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.alldaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aKTDataSet = new Микрорайон.AKTDataSet();
            this.alldaTableAdapter = new Микрорайон.AKTDataSetTableAdapters.alldaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.view_2BindingSource)).BeginInit();
      //      ((System.ComponentModel.ISupportInitialize)(this.GBUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBSLEDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoditeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alldaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // view_2BindingSource
            // 
            this.view_2BindingSource.DataMember = "View_2";
     //       this.view_2BindingSource.DataSource = this.GBUDataSet;
            // 
            // GBUDataSet
            // 
            //this.GBUDataSet.DataSetName = "GBUDataSet";
            //this.GBUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //// 
            // OBSLEDBindingSource
            // 
            this.OBSLEDBindingSource.DataMember = "OBSLED";
    //        this.OBSLEDBindingSource.DataSource = this.GBUDataSet;
            // 
            // DetiBindingSource
            // 
            this.DetiBindingSource.DataMember = "Deti";
         //   this.DetiBindingSource.DataSource = this.GBUDataSet;
            // 
            // RoditeliBindingSource
            // 
            this.RoditeliBindingSource.DataMember = "Roditeli";
           // this.RoditeliBindingSource.DataSource = this.GBUDataSet;
            // 
            // UlicaBindingSource
            // 
            this.UlicaBindingSource.DataMember = "Ulica";
           // this.UlicaBindingSource.DataSource = this.GBUDataSet;
            // 
            // OBSLEDTableAdapter
            // 
            //this.OBSLEDTableAdapter.ClearBeforeFill = true;
            //// 
            //// DetiTableAdapter
            //// 
            //this.DetiTableAdapter.ClearBeforeFill = true;
            //// 
            //// RoditeliTableAdapter
            //// 
            //this.RoditeliTableAdapter.ClearBeforeFill = true;
            //// 
            //// UlicaTableAdapter
            //// 
            //this.UlicaTableAdapter.ClearBeforeFill = true;
            //// 
            //// view_2TableAdapter
            //// 
            //this.view_2TableAdapter.ClearBeforeFill = true;
            //// 
            //// tableAdapterManager
            //// 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.DetiTableAdapter = this.DetiTableAdapter;
            //this.tableAdapterManager.DOMTableAdapter = null;
            //this.tableAdapterManager.KlassRukTableAdapter = null;
            //this.tableAdapterManager.KlassTableAdapter = null;
            //this.tableAdapterManager.OBSLEDTableAdapter = this.OBSLEDTableAdapter;
            //this.tableAdapterManager.RoditeliTableAdapter = this.RoditeliTableAdapter;
            //this.tableAdapterManager.RODSTVOTableAdapter = null;
            //this.tableAdapterManager.Strana_projTableAdapter = null;
            //this.tableAdapterManager.UlicaTableAdapter = this.UlicaTableAdapter;
            //this.tableAdapterManager.UpdateOrder = Микрорайон.GBUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //// 
            // reportViewer1
            // 
            this.reportViewer1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.alldaBindingSource, "ID_OBSLED", true));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.alldaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Микрорайон.reportttt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(746, 733);
            this.reportViewer1.TabIndex = 3;
            // 
            // alldaBindingSource
            // 
            this.alldaBindingSource.DataMember = "allda";
            this.alldaBindingSource.DataSource = this.aKTDataSet;
            // 
            // aKTDataSet
            // 
            this.aKTDataSet.DataSetName = "AKTDataSet";
            this.aKTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alldaTableAdapter
            // 
            this.alldaTableAdapter.ClearBeforeFill = true;
            // 
            // GBUFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(746, 733);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GBUFORM";
            this.Text = "GBUFORM";
            this.Load += new System.EventHandler(this.GBUFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_2BindingSource)).EndInit();
       //     ((System.ComponentModel.ISupportInitialize)(this.GBUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OBSLEDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoditeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UlicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alldaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource OBSLEDBindingSource;
    //    private GBUDataSet GBUDataSet;
        private System.Windows.Forms.BindingSource DetiBindingSource;
        private System.Windows.Forms.BindingSource RoditeliBindingSource;
        private System.Windows.Forms.BindingSource UlicaBindingSource;
        //private GBUDataSetTableAdapters.OBSLEDTableAdapter OBSLEDTableAdapter;
        //private GBUDataSetTableAdapters.DetiTableAdapter DetiTableAdapter;
        //private GBUDataSetTableAdapters.RoditeliTableAdapter RoditeliTableAdapter;
        //private GBUDataSetTableAdapters.UlicaTableAdapter UlicaTableAdapter;
        private System.Windows.Forms.BindingSource view_2BindingSource;
        //private GBUDataSetTableAdapters.View_2TableAdapter view_2TableAdapter;
        //private GBUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AKTDataSet aKTDataSet;
        private System.Windows.Forms.BindingSource alldaBindingSource;
        private AKTDataSetTableAdapters.alldaTableAdapter alldaTableAdapter;
    }
}