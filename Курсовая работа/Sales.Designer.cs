namespace Курсовая_работа
{
    partial class Sales
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kursDataSet = new Курсовая_работа.KursDataSet();
            this.salesidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sales_idTableAdapter = new Курсовая_работа.KursDataSetTableAdapters.Sales_idTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продукт1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количество1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продукт2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количество2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продукт3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количество3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продукт4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количество4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.способОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.клиентDataGridViewTextBoxColumn,
            this.сотрудникDataGridViewTextBoxColumn,
            this.датаПродажиDataGridViewTextBoxColumn,
            this.продукт1DataGridViewTextBoxColumn,
            this.количество1DataGridViewTextBoxColumn,
            this.продукт2DataGridViewTextBoxColumn,
            this.количество2DataGridViewTextBoxColumn,
            this.продукт3DataGridViewTextBoxColumn,
            this.количество3DataGridViewTextBoxColumn,
            this.продукт4DataGridViewTextBoxColumn,
            this.количество4DataGridViewTextBoxColumn,
            this.итогоDataGridViewTextBoxColumn,
            this.способОплатыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesidBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1052, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesidBindingSource
            // 
            this.salesidBindingSource.DataMember = "Sales+id";
            this.salesidBindingSource.DataSource = this.kursDataSet;
            // 
            // sales_idTableAdapter
            // 
            this.sales_idTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            // 
            // сотрудникDataGridViewTextBoxColumn
            // 
            this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
            // 
            // датаПродажиDataGridViewTextBoxColumn
            // 
            this.датаПродажиDataGridViewTextBoxColumn.DataPropertyName = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.Name = "датаПродажиDataGridViewTextBoxColumn";
            // 
            // продукт1DataGridViewTextBoxColumn
            // 
            this.продукт1DataGridViewTextBoxColumn.DataPropertyName = "Продукт1";
            this.продукт1DataGridViewTextBoxColumn.HeaderText = "Продукт1";
            this.продукт1DataGridViewTextBoxColumn.Name = "продукт1DataGridViewTextBoxColumn";
            // 
            // количество1DataGridViewTextBoxColumn
            // 
            this.количество1DataGridViewTextBoxColumn.DataPropertyName = "Количество1";
            this.количество1DataGridViewTextBoxColumn.HeaderText = "Количество1";
            this.количество1DataGridViewTextBoxColumn.Name = "количество1DataGridViewTextBoxColumn";
            // 
            // продукт2DataGridViewTextBoxColumn
            // 
            this.продукт2DataGridViewTextBoxColumn.DataPropertyName = "Продукт2";
            this.продукт2DataGridViewTextBoxColumn.HeaderText = "Продукт2";
            this.продукт2DataGridViewTextBoxColumn.Name = "продукт2DataGridViewTextBoxColumn";
            // 
            // количество2DataGridViewTextBoxColumn
            // 
            this.количество2DataGridViewTextBoxColumn.DataPropertyName = "Количество2";
            this.количество2DataGridViewTextBoxColumn.HeaderText = "Количество2";
            this.количество2DataGridViewTextBoxColumn.Name = "количество2DataGridViewTextBoxColumn";
            // 
            // продукт3DataGridViewTextBoxColumn
            // 
            this.продукт3DataGridViewTextBoxColumn.DataPropertyName = "Продукт3";
            this.продукт3DataGridViewTextBoxColumn.HeaderText = "Продукт3";
            this.продукт3DataGridViewTextBoxColumn.Name = "продукт3DataGridViewTextBoxColumn";
            // 
            // количество3DataGridViewTextBoxColumn
            // 
            this.количество3DataGridViewTextBoxColumn.DataPropertyName = "Количество3";
            this.количество3DataGridViewTextBoxColumn.HeaderText = "Количество3";
            this.количество3DataGridViewTextBoxColumn.Name = "количество3DataGridViewTextBoxColumn";
            // 
            // продукт4DataGridViewTextBoxColumn
            // 
            this.продукт4DataGridViewTextBoxColumn.DataPropertyName = "Продукт4";
            this.продукт4DataGridViewTextBoxColumn.HeaderText = "Продукт4";
            this.продукт4DataGridViewTextBoxColumn.Name = "продукт4DataGridViewTextBoxColumn";
            // 
            // количество4DataGridViewTextBoxColumn
            // 
            this.количество4DataGridViewTextBoxColumn.DataPropertyName = "Количество4";
            this.количество4DataGridViewTextBoxColumn.HeaderText = "Количество4";
            this.количество4DataGridViewTextBoxColumn.Name = "количество4DataGridViewTextBoxColumn";
            // 
            // итогоDataGridViewTextBoxColumn
            // 
            this.итогоDataGridViewTextBoxColumn.DataPropertyName = "Итого";
            this.итогоDataGridViewTextBoxColumn.HeaderText = "Итого";
            this.итогоDataGridViewTextBoxColumn.Name = "итогоDataGridViewTextBoxColumn";
            // 
            // способОплатыDataGridViewTextBoxColumn
            // 
            this.способОплатыDataGridViewTextBoxColumn.DataPropertyName = "Способ оплаты";
            this.способОплатыDataGridViewTextBoxColumn.HeaderText = "Способ оплаты";
            this.способОплатыDataGridViewTextBoxColumn.Name = "способОплатыDataGridViewTextBoxColumn";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesidBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource salesidBindingSource;
        private KursDataSetTableAdapters.Sales_idTableAdapter sales_idTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продукт1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количество1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продукт2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количество2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продукт3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количество3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продукт4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количество4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn способОплатыDataGridViewTextBoxColumn;
    }
}