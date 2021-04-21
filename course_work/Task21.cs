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
    public partial class Task21 : Form
    {
        public Task21()
        {
            InitializeComponent();
        }

        private void Task21_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hWDataSet.Directory_details". При необходимости она может быть перемещена или удалена.
            this.directory_detailsTableAdapter.Fill(this.hWDataSet.Directory_details);
            this.stocksTableAdapter.Fill(this.hWDataSet.Stocks);
            this.shippingTableAdapter.Fill(this.hWDataSet.Shipping);
            dataGridView1.AutoGenerateColumns = true;
            QueryZ2();

        }

        public void QueryZ2()
        {
            hWDataSet.Task2.Clear();
            int sum = 0;
            int kod = -1;
            int kod2 = -1;
            string name = "";
            HWDataSet.Task2Row zRow = null;
            foreach (HWDataSet.ShippingRow rRow in hWDataSet.Shipping.Rows)
            {
                if ((rRow.date_shipping >= Convert.ToDateTime(txtDate1.Text)) &&
                    (rRow.date_shipping <= Convert.ToDateTime(txtDate2.Text)))
                {
                    if (zRow == null)
                    {
                        kod = rRow.StockId;
                        name = hWDataSet.Stocks.FindById_stock(kod).LastName;
                        kod2 = rRow.DetailId;
                        sum = rRow.Kol_vo;
                        zRow = hWDataSet.Task2.NewTask2Row();
                    }
                    else
                    if (kod == rRow.StockId && kod2 == rRow.DetailId)
                    {
                        sum += rRow.Kol_vo;
                    }
                    else
                    {
                        zRow = hWDataSet.Task2.NewTask2Row();
                        zRow.Id_stock = hWDataSet.Stocks.FindById_stock(kod).Id_stock;
                        zRow.LastName = hWDataSet.Stocks.FindById_stock(kod).LastName;
                        zRow.DetailId = hWDataSet.Directory_details.FindByID(kod2).ID;
                        zRow.sum = sum;
                        hWDataSet.Task2.Rows.Add(zRow);
                        kod = rRow.StockId;
                        kod2 = rRow.DetailId;
                        sum = rRow.Kol_vo;
                        name = hWDataSet.Stocks.FindById_stock(kod).LastName;
                    }
                }
            }
            if (zRow != null)
            {
                zRow = hWDataSet.Task2.NewTask2Row();
                zRow.Id_stock = hWDataSet.Stocks.FindById_stock(kod).Id_stock;
                zRow.LastName = hWDataSet.Stocks.FindById_stock(kod).LastName;
                zRow.DetailId = hWDataSet.Directory_details.FindByID(kod2).ID;
                zRow.sum = sum;
                hWDataSet.Task2.AddTask2Row(zRow);
            }
            dataGridView1.Refresh();
        }

private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                var date1 = Convert.ToString(txtDate1.Text);
                var date2 = Convert.ToString(txtDate2.Text);
                QueryZ2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
