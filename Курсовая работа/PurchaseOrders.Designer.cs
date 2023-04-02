namespace Курсовая_работа
{
    partial class PurchaseOrders
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet = new Курсовая_работа.KursDataSet();
            this.purchaseOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_OrdersTableAdapter = new Курсовая_работа.KursDataSetTableAdapters.Purchase_OrdersTableAdapter();
            this.orders_idTableAdapter = new Курсовая_работа.KursDataSetTableAdapters.Orders_idTableAdapter();
            this.ordersidBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersidBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersidBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 223);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersidBindingSource
            // 
            this.ordersidBindingSource.DataMember = "Orders+id";
            this.ordersidBindingSource.DataSource = this.kursDataSet;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseOrdersBindingSource
            // 
            this.purchaseOrdersBindingSource.DataMember = "Purchase Orders";
            this.purchaseOrdersBindingSource.DataSource = this.kursDataSet;
            // 
            // purchase_OrdersTableAdapter
            // 
            this.purchase_OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // orders_idTableAdapter
            // 
            this.orders_idTableAdapter.ClearBeforeFill = true;
            // 
            // ordersidBindingSource1
            // 
            this.ordersidBindingSource1.DataMember = "Orders+id";
            this.ordersidBindingSource1.DataSource = this.kursDataSet;
            // 
            // PurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PurchaseOrders";
            this.Text = "PurchaseOrders";
            this.Load += new System.EventHandler(this.PurchaseOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersidBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource purchaseOrdersBindingSource;
        private KursDataSetTableAdapters.Purchase_OrdersTableAdapter purchase_OrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersidBindingSource;
        private KursDataSetTableAdapters.Orders_idTableAdapter orders_idTableAdapter;
        private System.Windows.Forms.BindingSource ordersidBindingSource1;
    }
}