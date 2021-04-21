
namespace course_work
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StocksDgv = new System.Windows.Forms.DataGridView();
            this.idstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hWDataSet = new course_work.HWDataSet();
            this.stocksTableAdapter = new course_work.HWDataSetTableAdapters.StocksTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.DetailsDgv = new System.Windows.Forms.DataGridView();
            this.detailnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryunitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priсeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorydetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directory_detailsTableAdapter = new course_work.HWDataSetTableAdapters.Directory_detailsTableAdapter();
            this.ShippingDgv = new System.Windows.Forms.DataGridView();
            this.documentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idcustomersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateshippingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingunitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippingTableAdapter = new course_work.HWDataSetTableAdapters.ShippingTableAdapter();
            this.lblTable = new System.Windows.Forms.Label();
            this.fkshippingtoStocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fkshippingtoDirectorydetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общееПредставлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.задача3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.StocksDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorydetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippingDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkshippingtoStocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkshippingtoDirectorydetailsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StocksDgv
            // 
            this.StocksDgv.AutoGenerateColumns = false;
            this.StocksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StocksDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstockDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.StocksDgv.DataSource = this.stocksBindingSource;
            this.StocksDgv.Location = new System.Drawing.Point(12, 62);
            this.StocksDgv.Name = "StocksDgv";
            this.StocksDgv.RowHeadersWidth = 51;
            this.StocksDgv.RowTemplate.Height = 24;
            this.StocksDgv.Size = new System.Drawing.Size(582, 207);
            this.StocksDgv.TabIndex = 0;
            this.StocksDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StocksDataGridView1_CellContentClick);
            this.StocksDgv.Click += new System.EventHandler(this.StocksDgv_Click);
            // 
            // idstockDataGridViewTextBoxColumn
            // 
            this.idstockDataGridViewTextBoxColumn.DataPropertyName = "Id_stock";
            this.idstockDataGridViewTextBoxColumn.HeaderText = "Номер склада";
            this.idstockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstockDataGridViewTextBoxColumn.Name = "idstockDataGridViewTextBoxColumn";
            this.idstockDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstockDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Ответственное лицо";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.hWDataSet;
            // 
            // hWDataSet
            // 
            this.hWDataSet.DataSetName = "HWDataSet";
            this.hWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.stocksBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 28);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1113, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // DetailsDgv
            // 
            this.DetailsDgv.AutoGenerateColumns = false;
            this.DetailsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailnameDataGridViewTextBoxColumn,
            this.detailtypeDataGridViewTextBoxColumn,
            this.directoryunitsDataGridViewTextBoxColumn,
            this.priсeDataGridViewTextBoxColumn});
            this.DetailsDgv.DataSource = this.directorydetailsBindingSource;
            this.DetailsDgv.Location = new System.Drawing.Point(12, 275);
            this.DetailsDgv.Name = "DetailsDgv";
            this.DetailsDgv.RowHeadersWidth = 51;
            this.DetailsDgv.RowTemplate.Height = 24;
            this.DetailsDgv.Size = new System.Drawing.Size(851, 254);
            this.DetailsDgv.TabIndex = 2;
            this.DetailsDgv.Click += new System.EventHandler(this.DetailsDgv_Click);
            // 
            // detailnameDataGridViewTextBoxColumn
            // 
            this.detailnameDataGridViewTextBoxColumn.DataPropertyName = "detail_name";
            this.detailnameDataGridViewTextBoxColumn.HeaderText = "Наименование детали";
            this.detailnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailnameDataGridViewTextBoxColumn.Name = "detailnameDataGridViewTextBoxColumn";
            this.detailnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailtypeDataGridViewTextBoxColumn
            // 
            this.detailtypeDataGridViewTextBoxColumn.DataPropertyName = "detail_type";
            this.detailtypeDataGridViewTextBoxColumn.HeaderText = "Тип детали";
            this.detailtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailtypeDataGridViewTextBoxColumn.Name = "detailtypeDataGridViewTextBoxColumn";
            this.detailtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // directoryunitsDataGridViewTextBoxColumn
            // 
            this.directoryunitsDataGridViewTextBoxColumn.DataPropertyName = "Directory_units";
            this.directoryunitsDataGridViewTextBoxColumn.HeaderText = "Ед. измерения";
            this.directoryunitsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directoryunitsDataGridViewTextBoxColumn.Name = "directoryunitsDataGridViewTextBoxColumn";
            this.directoryunitsDataGridViewTextBoxColumn.Width = 125;
            // 
            // priсeDataGridViewTextBoxColumn
            // 
            this.priсeDataGridViewTextBoxColumn.DataPropertyName = "priсe";
            this.priсeDataGridViewTextBoxColumn.HeaderText = "Цена за шт.";
            this.priсeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priсeDataGridViewTextBoxColumn.Name = "priсeDataGridViewTextBoxColumn";
            this.priсeDataGridViewTextBoxColumn.Width = 125;
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
            // ShippingDgv
            // 
            this.ShippingDgv.AutoGenerateColumns = false;
            this.ShippingDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShippingDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentIdDataGridViewTextBoxColumn,
            this.detail_name,
            this.idcustomersDataGridViewTextBoxColumn,
            this.dateshippingDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.shippingunitsDataGridViewTextBoxColumn});
            this.ShippingDgv.DataSource = this.shippingBindingSource;
            this.ShippingDgv.Location = new System.Drawing.Point(12, 535);
            this.ShippingDgv.Name = "ShippingDgv";
            this.ShippingDgv.RowHeadersWidth = 51;
            this.ShippingDgv.RowTemplate.Height = 24;
            this.ShippingDgv.Size = new System.Drawing.Size(1038, 239);
            this.ShippingDgv.TabIndex = 3;
            this.ShippingDgv.Click += new System.EventHandler(this.ShippingDgv_Click);
            // 
            // documentIdDataGridViewTextBoxColumn
            // 
            this.documentIdDataGridViewTextBoxColumn.DataPropertyName = "DocumentId";
            this.documentIdDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.documentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentIdDataGridViewTextBoxColumn.Name = "documentIdDataGridViewTextBoxColumn";
            this.documentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // detail_name
            // 
            this.detail_name.DataPropertyName = "DetailId";
            this.detail_name.DataSource = this.directorydetailsBindingSource;
            this.detail_name.DisplayMember = "detail_name";
            this.detail_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail_name.HeaderText = "Наименование детали";
            this.detail_name.MinimumWidth = 6;
            this.detail_name.Name = "detail_name";
            this.detail_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detail_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detail_name.ValueMember = "ID";
            this.detail_name.Width = 125;
            // 
            // idcustomersDataGridViewTextBoxColumn
            // 
            this.idcustomersDataGridViewTextBoxColumn.DataPropertyName = "Id_customers";
            this.idcustomersDataGridViewTextBoxColumn.HeaderText = "Код покупателя";
            this.idcustomersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcustomersDataGridViewTextBoxColumn.Name = "idcustomersDataGridViewTextBoxColumn";
            this.idcustomersDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateshippingDataGridViewTextBoxColumn
            // 
            this.dateshippingDataGridViewTextBoxColumn.DataPropertyName = "date_shipping";
            this.dateshippingDataGridViewTextBoxColumn.HeaderText = "Дата отправки";
            this.dateshippingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateshippingDataGridViewTextBoxColumn.Name = "dateshippingDataGridViewTextBoxColumn";
            this.dateshippingDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "Количетсво";
            this.kolvoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            this.kolvoDataGridViewTextBoxColumn.Width = 125;
            // 
            // shippingunitsDataGridViewTextBoxColumn
            // 
            this.shippingunitsDataGridViewTextBoxColumn.DataPropertyName = "Shipping_units";
            this.shippingunitsDataGridViewTextBoxColumn.HeaderText = "Ед. измерения";
            this.shippingunitsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shippingunitsDataGridViewTextBoxColumn.Name = "shippingunitsDataGridViewTextBoxColumn";
            this.shippingunitsDataGridViewTextBoxColumn.Width = 125;
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
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTable.Location = new System.Drawing.Point(336, 24);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(72, 25);
            this.lblTable.TabIndex = 4;
            this.lblTable.Text = "Stocks";
            // 
            // fkshippingtoStocksBindingSource
            // 
            this.fkshippingtoStocksBindingSource.DataMember = "fk_shipping_to_Stocks";
            this.fkshippingtoStocksBindingSource.DataSource = this.stocksBindingSource;
            // 
            // fkshippingtoDirectorydetailsBindingSource
            // 
            this.fkshippingtoDirectorydetailsBindingSource.DataMember = "fk_shipping_to_Directory_details";
            this.fkshippingtoDirectorydetailsBindingSource.DataSource = this.directorydetailsBindingSource;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(50, 780);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(85, 62);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(141, 780);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(85, 62);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(232, 780);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 62);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(323, 780);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(85, 62);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 780);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 62);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(600, 780);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 62);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnProc
            // 
            this.btnProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProc.Location = new System.Drawing.Point(686, 62);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(149, 63);
            this.btnProc.TabIndex = 16;
            this.btnProc.Text = "Процедура:";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(878, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Минимальная цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(878, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Максимальная цена";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формыToolStripMenuItem,
            this.задача1ToolStripMenuItem,
            this.задача2ToolStripMenuItem,
            this.задача3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основнаяToolStripMenuItem,
            this.альтернативнаяToolStripMenuItem,
            this.общееПредставлениеToolStripMenuItem});
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.формыToolStripMenuItem.Text = "Формы";
            // 
            // основнаяToolStripMenuItem
            // 
            this.основнаяToolStripMenuItem.Name = "основнаяToolStripMenuItem";
            this.основнаяToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.основнаяToolStripMenuItem.Text = "Основная";
            // 
            // альтернативнаяToolStripMenuItem
            // 
            this.альтернативнаяToolStripMenuItem.Name = "альтернативнаяToolStripMenuItem";
            this.альтернативнаяToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.альтернативнаяToolStripMenuItem.Text = "Альтернативная";
            this.альтернативнаяToolStripMenuItem.Click += new System.EventHandler(this.альтернативнаяToolStripMenuItem_Click);
            // 
            // общееПредставлениеToolStripMenuItem
            // 
            this.общееПредставлениеToolStripMenuItem.Name = "общееПредставлениеToolStripMenuItem";
            this.общееПредставлениеToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.общееПредставлениеToolStripMenuItem.Text = "Общее представление";
            this.общееПредставлениеToolStripMenuItem.Click += new System.EventHandler(this.общееПредставлениеToolStripMenuItem_Click);
            // 
            // задача1ToolStripMenuItem
            // 
            this.задача1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вариант1ToolStripMenuItem,
            this.вариант2ToolStripMenuItem,
            this.вариант3ToolStripMenuItem,
            this.вариант4ToolStripMenuItem,
            this.вариант5ToolStripMenuItem});
            this.задача1ToolStripMenuItem.Name = "задача1ToolStripMenuItem";
            this.задача1ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.задача1ToolStripMenuItem.Text = "Задача 1";
            // 
            // вариант1ToolStripMenuItem
            // 
            this.вариант1ToolStripMenuItem.Name = "вариант1ToolStripMenuItem";
            this.вариант1ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.вариант1ToolStripMenuItem.Text = "Вариант 1";
            this.вариант1ToolStripMenuItem.Click += new System.EventHandler(this.вариант1ToolStripMenuItem_Click);
            // 
            // вариант2ToolStripMenuItem
            // 
            this.вариант2ToolStripMenuItem.Name = "вариант2ToolStripMenuItem";
            this.вариант2ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.вариант2ToolStripMenuItem.Text = "Вариант 2";
            this.вариант2ToolStripMenuItem.Click += new System.EventHandler(this.вариант2ToolStripMenuItem_Click);
            // 
            // вариант3ToolStripMenuItem
            // 
            this.вариант3ToolStripMenuItem.Name = "вариант3ToolStripMenuItem";
            this.вариант3ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.вариант3ToolStripMenuItem.Text = "Вариант 3";
            this.вариант3ToolStripMenuItem.Click += new System.EventHandler(this.вариант3ToolStripMenuItem_Click);
            // 
            // вариант4ToolStripMenuItem
            // 
            this.вариант4ToolStripMenuItem.Name = "вариант4ToolStripMenuItem";
            this.вариант4ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.вариант4ToolStripMenuItem.Text = "Вариант 4";
            this.вариант4ToolStripMenuItem.Click += new System.EventHandler(this.вариант4ToolStripMenuItem_Click);
            // 
            // вариант5ToolStripMenuItem
            // 
            this.вариант5ToolStripMenuItem.Name = "вариант5ToolStripMenuItem";
            this.вариант5ToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.вариант5ToolStripMenuItem.Text = "Вариант 5";
            this.вариант5ToolStripMenuItem.Click += new System.EventHandler(this.вариант5ToolStripMenuItem_Click);
            // 
            // задача2ToolStripMenuItem
            // 
            this.задача2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вариант1ToolStripMenuItem1,
            this.вариант2ToolStripMenuItem1});
            this.задача2ToolStripMenuItem.Name = "задача2ToolStripMenuItem";
            this.задача2ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.задача2ToolStripMenuItem.Text = "Задача 2";
            // 
            // вариант1ToolStripMenuItem1
            // 
            this.вариант1ToolStripMenuItem1.Name = "вариант1ToolStripMenuItem1";
            this.вариант1ToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.вариант1ToolStripMenuItem1.Text = "Вариант 1";
            this.вариант1ToolStripMenuItem1.Click += new System.EventHandler(this.вариант1ToolStripMenuItem1_Click);
            // 
            // вариант2ToolStripMenuItem1
            // 
            this.вариант2ToolStripMenuItem1.Name = "вариант2ToolStripMenuItem1";
            this.вариант2ToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.вариант2ToolStripMenuItem1.Text = "Вариант 2";
            this.вариант2ToolStripMenuItem1.Click += new System.EventHandler(this.вариант2ToolStripMenuItem1_Click);
            // 
            // задача3ToolStripMenuItem
            // 
            this.задача3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вариант1ToolStripMenuItem2,
            this.вариант2ToolStripMenuItem2});
            this.задача3ToolStripMenuItem.Name = "задача3ToolStripMenuItem";
            this.задача3ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.задача3ToolStripMenuItem.Text = "Задача 3";
            // 
            // вариант1ToolStripMenuItem2
            // 
            this.вариант1ToolStripMenuItem2.Name = "вариант1ToolStripMenuItem2";
            this.вариант1ToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.вариант1ToolStripMenuItem2.Text = "Вариант 1";
            this.вариант1ToolStripMenuItem2.Click += new System.EventHandler(this.вариант1ToolStripMenuItem2_Click);
            // 
            // вариант2ToolStripMenuItem2
            // 
            this.вариант2ToolStripMenuItem2.Name = "вариант2ToolStripMenuItem2";
            this.вариант2ToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.вариант2ToolStripMenuItem2.Text = "Вариант 2";
            this.вариант2ToolStripMenuItem2.Click += new System.EventHandler(this.вариант2ToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 887);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.ShippingDgv);
            this.Controls.Add(this.DetailsDgv);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StocksDgv);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StocksDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorydetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippingDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkshippingtoStocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkshippingtoDirectorydetailsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StocksDgv;
        private HWDataSet hWDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private HWDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
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
        private System.Windows.Forms.DataGridView DetailsDgv;
        private System.Windows.Forms.BindingSource directorydetailsBindingSource;
        private HWDataSetTableAdapters.Directory_detailsTableAdapter directory_detailsTableAdapter;
        private System.Windows.Forms.DataGridView ShippingDgv;
        private System.Windows.Forms.BindingSource shippingBindingSource;
        private HWDataSetTableAdapters.ShippingTableAdapter shippingTableAdapter;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.BindingSource fkshippingtoStocksBindingSource;
        private System.Windows.Forms.BindingSource fkshippingtoDirectorydetailsBindingSource;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoryunitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priсeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn detail_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateshippingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingunitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem формыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общееПредставлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вариант2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem задача3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem вариант2ToolStripMenuItem2;
    }
}

