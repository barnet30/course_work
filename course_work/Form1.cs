using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hWDataSet.Shipping". При необходимости она может быть перемещена или удалена.
            this.shippingTableAdapter.Fill(this.hWDataSet.Shipping);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hWDataSet.Directory_details". При необходимости она может быть перемещена или удалена.
            this.directory_detailsTableAdapter.Fill(this.hWDataSet.Directory_details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hWDataSet.Stocks". При необходимости она может быть перемещена или удалена.
            this.stocksTableAdapter.Fill(this.hWDataSet.Stocks);

        }

        private void StocksDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StocksDgv_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = stocksBindingSource;
            lblTable.Text = "Stocks";
            ShippingDgv.DataSource = fkshippingtoStocksBindingSource;
        }

        private void DetailsDgv_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = directorydetailsBindingSource;
            lblTable.Text = "DirectoryDetails";
            ShippingDgv.DataSource = fkshippingtoDirectorydetailsBindingSource;
        }

        private void ShippingDgv_Click(object sender, EventArgs e)
        {
            ShippingDgv.DataSource = shippingBindingSource;
            lblTable.Text = "Shipping";
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Shipping";
            var col = ShippingDgv.CurrentCell.ColumnIndex;
            ShippingDgv.CurrentCell = ShippingDgv[col, 0];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Shipping";
            var col = ShippingDgv.CurrentCell.ColumnIndex;
            ShippingDgv.CurrentCell = ShippingDgv[col, ShippingDgv.RowCount - 2];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Shipping";

            var row = ShippingDgv.CurrentCell.RowIndex;
            var col = ShippingDgv.CurrentCell.ColumnIndex;

            if (row < ShippingDgv.RowCount - 2)
                ShippingDgv.CurrentCell = ShippingDgv[col, row + 1];
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lblTable.Text = "Shipping";

            var row = ShippingDgv.CurrentCell.RowIndex;
            var col = ShippingDgv.CurrentCell.ColumnIndex;

            if (row > 0)
                ShippingDgv.CurrentCell = ShippingDgv[col, row - 1];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.shippingTableAdapter.Fill(this.hWDataSet.Shipping);
            this.stocksTableAdapter.Fill(this.hWDataSet.Stocks);
            this.directory_detailsTableAdapter.Fill(this.hWDataSet.Directory_details);

            MessageBox.Show("Изменения были отменены");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.shippingTableAdapter.Update(this.hWDataSet.Shipping);
                this.stocksTableAdapter.Update(this.hWDataSet.Stocks);
                this.directory_detailsTableAdapter.Update(this.hWDataSet.Directory_details);

                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            try
            {
                String unit = DetailsDgv.CurrentRow.Cells["directoryunitsDataGridViewTextBoxColumn"].Value.ToString();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.HWConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getPrice";
                cmd.Parameters.AddWithValue("@unit", unit);
                SqlParameter param1 = new SqlParameter("@minPrice", SqlDbType.Int);
                SqlParameter param2 = new SqlParameter("@maxPrice", SqlDbType.Int);
                param1.Direction = ParameterDirection.Output;
                param2.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                //cmd.Parameters.Add(new SqlParameter("@price", price));
                con.Open();
                cmd.ExecuteNonQuery();
                var min = cmd.Parameters["@minPrice"].Value.ToString();
                var max = cmd.Parameters["@maxPrice"].Value.ToString();
                con.Close();
                label1.Text = "Минимальная цена " + min;
                label2.Text = "Максимальная цена " + max;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void альтернативнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();
        }

        private void вариант1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form task11 = new Task11();
            task11.ShowDialog();
        }

        private void вариант2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form task12 = new Task12();
            task12.ShowDialog();
        }

        private void вариант3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form task13 = new Task13();
            task13.ShowDialog();
        }

        private void вариант4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form task14 = new Task14();
            task14.ShowDialog();
        }

        private void вариант5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form task15 = new Task15();
            task15.ShowDialog();
        }

        private void общееПредставлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new GeneralView();
            form3.ShowDialog();
        }

        private void вариант1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form task21 = new Task21();
            task21.ShowDialog();
        }

        private void вариант2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form task22 = new Task22();
            task22.ShowDialog();
        }

        private void вариант1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form task31 = new Task31();
            task31.ShowDialog();
        }

        private void вариант2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form task32 = new Task32();
            task32.ShowDialog();
        }
    }
}
