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
    public partial class Task13 : Form
    {
        public Task13()
        {
            InitializeComponent();
        }

        private void Task13_Load(object sender, EventArgs e)
        {
            this.stocksTableAdapter.Fill(this.hWDataSet.Stocks);
            this.shippingTableAdapter.Fill(this.hWDataSet.Shipping);
            this.directory_detailsTableAdapter.Fill(this.hWDataSet.Directory_details);
            QueryZapr2();
        }

        private void QueryZapr2()
        {
            hWDataSet.Task1.Clear();
            foreach (HWDataSet.ShippingRow rRow in hWDataSet.Shipping.Rows)
            {
                if ((rRow.date_shipping >= Convert.ToDateTime(txtDate1.Text)) &&
                        (rRow.date_shipping <= Convert.ToDateTime(txtDate2.Text)))
                {
                    HWDataSet.StocksRow sRow = hWDataSet.Stocks.Rows.Find(rRow.StockId) as HWDataSet.StocksRow;

                    HWDataSet.Task1Row zRow = hWDataSet.Task1.NewTask1Row();
                    zRow.Id_stock = sRow.Id_stock;
                    zRow.LastName = sRow.LastName;
                    zRow.ID = rRow.DetailId;
                    zRow.kol_vo = rRow.Kol_vo;
                    zRow.date_shipping = rRow.date_shipping;
                    hWDataSet.Task1.AddTask1Row(zRow);
                }
            }
            dataGridView1.Refresh();
            this.Text = "Запрос через поиск по ключу";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                var date1 = Convert.ToString(txtDate1.Text);
                var date2 = Convert.ToString(txtDate2.Text);
                QueryZapr2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
