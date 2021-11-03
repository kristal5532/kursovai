
namespace Kursach_V3
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cD_and_DVD_V2DataSet = new Kursach_V3.CD_and_DVD_V2DataSet();
            this.cDandDVDV2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodashaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodashaTableAdapter = new Kursach_V3.CD_and_DVD_V2DataSetTableAdapters.ProdashaTableAdapter();
            this.кодпродажыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataprodashiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaprodashiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodavecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.prodavecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodavecTableAdapter = new Kursach_V3.CD_and_DVD_V2DataSetTableAdapters.ProdavecTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarochdeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodashaProdavecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.prodashaScladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scladTableAdapter = new Kursach_V3.CD_and_DVD_V2DataSetTableAdapters.ScladTableAdapter();
            this.кодскладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapostupleniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cD_and_DVD_V2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDandDVDV2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodashaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodashaProdavecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodashaScladBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпродажыDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dataprodashiDataGridViewTextBoxColumn,
            this.cenaprodashiDataGridViewTextBoxColumn,
            this.colvoDataGridViewTextBoxColumn,
            this.prodavecDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodashaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // cD_and_DVD_V2DataSet
            // 
            this.cD_and_DVD_V2DataSet.DataSetName = "CD_and_DVD_V2DataSet";
            this.cD_and_DVD_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cDandDVDV2DataSetBindingSource
            // 
            this.cDandDVDV2DataSetBindingSource.DataSource = this.cD_and_DVD_V2DataSet;
            this.cDandDVDV2DataSetBindingSource.Position = 0;
            // 
            // prodashaBindingSource
            // 
            this.prodashaBindingSource.DataMember = "Prodasha";
            this.prodashaBindingSource.DataSource = this.cDandDVDV2DataSetBindingSource;
            // 
            // prodashaTableAdapter
            // 
            this.prodashaTableAdapter.ClearBeforeFill = true;
            // 
            // кодпродажыDataGridViewTextBoxColumn
            // 
            this.кодпродажыDataGridViewTextBoxColumn.DataPropertyName = "Код_продажы";
            this.кодпродажыDataGridViewTextBoxColumn.HeaderText = "Код_продажы";
            this.кодпродажыDataGridViewTextBoxColumn.Name = "кодпродажыDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dataprodashiDataGridViewTextBoxColumn
            // 
            this.dataprodashiDataGridViewTextBoxColumn.DataPropertyName = "Data_prodashi";
            this.dataprodashiDataGridViewTextBoxColumn.HeaderText = "Data_prodashi";
            this.dataprodashiDataGridViewTextBoxColumn.Name = "dataprodashiDataGridViewTextBoxColumn";
            // 
            // cenaprodashiDataGridViewTextBoxColumn
            // 
            this.cenaprodashiDataGridViewTextBoxColumn.DataPropertyName = "Cena_prodashi";
            this.cenaprodashiDataGridViewTextBoxColumn.HeaderText = "Cena_prodashi";
            this.cenaprodashiDataGridViewTextBoxColumn.Name = "cenaprodashiDataGridViewTextBoxColumn";
            // 
            // colvoDataGridViewTextBoxColumn
            // 
            this.colvoDataGridViewTextBoxColumn.DataPropertyName = "Col-vo";
            this.colvoDataGridViewTextBoxColumn.HeaderText = "Col-vo";
            this.colvoDataGridViewTextBoxColumn.Name = "colvoDataGridViewTextBoxColumn";
            // 
            // prodavecDataGridViewTextBoxColumn
            // 
            this.prodavecDataGridViewTextBoxColumn.DataPropertyName = "Prodavec";
            this.prodavecDataGridViewTextBoxColumn.HeaderText = "Prodavec";
            this.prodavecDataGridViewTextBoxColumn.Name = "prodavecDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.familiaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.pasportDataGridViewTextBoxColumn,
            this.datarochdeniaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.prodashaProdavecBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(646, 77);
            this.dataGridView2.TabIndex = 1;
            // 
            // prodavecBindingSource
            // 
            this.prodavecBindingSource.DataMember = "Prodavec";
            this.prodavecBindingSource.DataSource = this.cDandDVDV2DataSetBindingSource;
            // 
            // prodavecTableAdapter
            // 
            this.prodavecTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "Familia";
            this.familiaDataGridViewTextBoxColumn.HeaderText = "Familia";
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // pasportDataGridViewTextBoxColumn
            // 
            this.pasportDataGridViewTextBoxColumn.DataPropertyName = "Pasport";
            this.pasportDataGridViewTextBoxColumn.HeaderText = "Pasport";
            this.pasportDataGridViewTextBoxColumn.Name = "pasportDataGridViewTextBoxColumn";
            // 
            // datarochdeniaDataGridViewTextBoxColumn
            // 
            this.datarochdeniaDataGridViewTextBoxColumn.DataPropertyName = "Data_rochdenia";
            this.datarochdeniaDataGridViewTextBoxColumn.HeaderText = "Data_rochdenia";
            this.datarochdeniaDataGridViewTextBoxColumn.Name = "datarochdeniaDataGridViewTextBoxColumn";
            // 
            // prodashaProdavecBindingSource
            // 
            this.prodashaProdavecBindingSource.DataMember = "ProdashaProdavec";
            this.prodashaProdavecBindingSource.DataSource = this.prodashaBindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодскладаDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2,
            this.opisanieDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.datapostupleniaDataGridViewTextBoxColumn,
            this.colvoDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.prodashaScladBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(13, 267);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(645, 70);
            this.dataGridView3.TabIndex = 2;
            // 
            // prodashaScladBindingSource
            // 
            this.prodashaScladBindingSource.DataMember = "ProdashaSclad";
            this.prodashaScladBindingSource.DataSource = this.prodashaBindingSource;
            // 
            // scladTableAdapter
            // 
            this.scladTableAdapter.ClearBeforeFill = true;
            // 
            // кодскладаDataGridViewTextBoxColumn
            // 
            this.кодскладаDataGridViewTextBoxColumn.DataPropertyName = "Код_склада";
            this.кодскладаDataGridViewTextBoxColumn.HeaderText = "Код_склада";
            this.кодскладаDataGridViewTextBoxColumn.Name = "кодскладаDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // datapostupleniaDataGridViewTextBoxColumn
            // 
            this.datapostupleniaDataGridViewTextBoxColumn.DataPropertyName = "Data_postuplenia";
            this.datapostupleniaDataGridViewTextBoxColumn.HeaderText = "Data_postuplenia";
            this.datapostupleniaDataGridViewTextBoxColumn.Name = "datapostupleniaDataGridViewTextBoxColumn";
            // 
            // colvoDataGridViewTextBoxColumn1
            // 
            this.colvoDataGridViewTextBoxColumn1.DataPropertyName = "Col-vo";
            this.colvoDataGridViewTextBoxColumn1.HeaderText = "Col-vo";
            this.colvoDataGridViewTextBoxColumn1.Name = "colvoDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cD_and_DVD_V2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDandDVDV2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodashaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodashaProdavecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodashaScladBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cDandDVDV2DataSetBindingSource;
        private CD_and_DVD_V2DataSet cD_and_DVD_V2DataSet;
        private System.Windows.Forms.BindingSource prodashaBindingSource;
        private CD_and_DVD_V2DataSetTableAdapters.ProdashaTableAdapter prodashaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпродажыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataprodashiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaprodashiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodavecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource prodavecBindingSource;
        private CD_and_DVD_V2DataSetTableAdapters.ProdavecTableAdapter prodavecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarochdeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prodashaProdavecBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource prodashaScladBindingSource;
        private CD_and_DVD_V2DataSetTableAdapters.ScladTableAdapter scladTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодскладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapostupleniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvoDataGridViewTextBoxColumn1;
    }
}

