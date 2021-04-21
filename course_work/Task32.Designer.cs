
namespace course_work
{
    partial class Task32
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task32));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hWDataSet = new course_work.HWDataSet();
            this.directorydetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directory_detailsTableAdapter = new course_work.HWDataSetTableAdapters.Directory_detailsTableAdapter();
            this.shippingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippingTableAdapter = new course_work.HWDataSetTableAdapters.ShippingTableAdapter();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new course_work.HWDataSetTableAdapters.StocksTableAdapter();
            this.task3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task3TableAdapter = new course_work.HWDataSetTableAdapters.Task3TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryunitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priсeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorydetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.task3BindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1308, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.detailtypeDataGridViewTextBoxColumn,
            this.detailnameDataGridViewTextBoxColumn,
            this.directoryunitsDataGridViewTextBoxColumn,
            this.priсeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.task3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 269);
            this.dataGridView1.TabIndex = 1;
            // 
            // hWDataSet
            // 
            this.hWDataSet.DataSetName = "HWDataSet";
            this.hWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorydetailsBindingSource
            // 
            this.directorydetailsBindingSource.DataMember = "Directory_details";
            this.directorydetailsBindingSource.DataSource = this.hWDataSet;
            // 
            // directory_detailsTableAdapter
            // 
            this.directory_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // shippingBindingSource
            // 
            this.shippingBindingSource.DataMember = "Shipping";
            this.shippingBindingSource.DataSource = this.hWDataSet;
            // 
            // shippingTableAdapter
            // 
            this.shippingTableAdapter.ClearBeforeFill = true;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.hWDataSet;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // task3BindingSource
            // 
            this.task3BindingSource.DataMember = "Task3";
            this.task3BindingSource.DataSource = this.hWDataSet;
            // 
            // task3TableAdapter
            // 
            this.task3TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailtypeDataGridViewTextBoxColumn
            // 
            this.detailtypeDataGridViewTextBoxColumn.DataPropertyName = "detail_type";
            this.detailtypeDataGridViewTextBoxColumn.HeaderText = "detail_type";
            this.detailtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailtypeDataGridViewTextBoxColumn.Name = "detailtypeDataGridViewTextBoxColumn";
            this.detailtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailnameDataGridViewTextBoxColumn
            // 
            this.detailnameDataGridViewTextBoxColumn.DataPropertyName = "detail_name";
            this.detailnameDataGridViewTextBoxColumn.HeaderText = "detail_name";
            this.detailnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailnameDataGridViewTextBoxColumn.Name = "detailnameDataGridViewTextBoxColumn";
            this.detailnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // directoryunitsDataGridViewTextBoxColumn
            // 
            this.directoryunitsDataGridViewTextBoxColumn.DataPropertyName = "Directory_units";
            this.directoryunitsDataGridViewTextBoxColumn.HeaderText = "Directory_units";
            this.directoryunitsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directoryunitsDataGridViewTextBoxColumn.Name = "directoryunitsDataGridViewTextBoxColumn";
            this.directoryunitsDataGridViewTextBoxColumn.Width = 125;
            // 
            // priсeDataGridViewTextBoxColumn
            // 
            this.priсeDataGridViewTextBoxColumn.DataPropertyName = "priсe";
            this.priсeDataGridViewTextBoxColumn.HeaderText = "priсe";
            this.priсeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priсeDataGridViewTextBoxColumn.Name = "priсeDataGridViewTextBoxColumn";
            this.priсeDataGridViewTextBoxColumn.Width = 125;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmount.Location = new System.Drawing.Point(218, 350);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(109, 20);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Количество";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(222, 373);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(384, 350);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Цена";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(356, 373);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(531, 350);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(113, 55);
            this.btnFill.TabIndex = 8;
            this.btnFill.Text = "Заполнить";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // Task32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 542);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Task32";
            this.Text = "Task32";
            this.Load += new System.EventHandler(this.Task32_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorydetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private HWDataSet hWDataSet;
        private System.Windows.Forms.BindingSource directorydetailsBindingSource;
        private HWDataSetTableAdapters.Directory_detailsTableAdapter directory_detailsTableAdapter;
        private System.Windows.Forms.BindingSource shippingBindingSource;
        private HWDataSetTableAdapters.ShippingTableAdapter shippingTableAdapter;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private HWDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoryunitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priсeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource task3BindingSource;
        private HWDataSetTableAdapters.Task3TableAdapter task3TableAdapter;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnFill;
    }
}