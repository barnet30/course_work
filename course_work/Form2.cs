using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hWDataSet.Stocks". При необходимости она может быть перемещена или удалена.
            this.stocksTableAdapter.Fill(this.hWDataSet.Stocks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hWDataSet.Shipping". При необходимости она может быть перемещена или удалена.
            this.shippingTableAdapter.Fill(this.hWDataSet.Shipping);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hWDataSet.Directory_details". При необходимости она может быть перемещена или удалена.
            this.directory_detailsTableAdapter.Fill(this.hWDataSet.Directory_details);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Stocks")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = stocksBindingSource;
                bindingNavigator1.BindingSource = stocksBindingSource;
                lblTableName.Text = "Stocks";
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Directory_details")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = directorydetailsBindingSource;
                bindingNavigator1.BindingSource = directorydetailsBindingSource;
                lblTableName.Text = "Directory_details";
            }
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Shipping")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = shippingBindingSource;
                bindingNavigator1.BindingSource = shippingBindingSource;
                lblTableName.Text = "Shipping";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.shippingTableAdapter.Update(this.hWDataSet.Shipping);
            this.directory_detailsTableAdapter.Update(this.hWDataSet.Directory_details);
            this.stocksTableAdapter.Update(this.hWDataSet.Stocks);
            MessageBox.Show("Изменения сохранены!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
