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
    public partial class Task12 : Form
    {
        public Task12()
        {
            InitializeComponent();
        }

        private void Task12_Load(object sender, EventArgs e)
        {
            this.shippingTableAdapter.Fill(this.hWDataSet.Shipping);
            this.stocksTableAdapter.Fill(this.hWDataSet.Stocks);
            this.directory_detailsTableAdapter.Fill(this.hWDataSet.Directory_details);
            QueryZapr1();
        }

        private void QueryZapr1()
        {
            hWDataSet.Task1.Clear();

            foreach (HWDataSet.ShippingRow rRow in hWDataSet.Shipping.Rows)
            {
                if ((rRow.date_shipping >= Convert.ToDateTime(txtDate1.Text)) &&
                        (rRow.date_shipping <= Convert.ToDateTime(txtDate2.Text)))
                {
                    foreach (HWDataSet.StocksRow tRow in hWDataSet.Stocks.Rows)
                    {
                        if (tRow.Id_stock == rRow.StockId)
                        {
                            foreach (HWDataSet.Directory_detailsRow dRow in hWDataSet.Directory_details.Rows)
                            {
                                if (rRow.DetailId == dRow.ID)
                                {
                                    HWDataSet.Task1Row zRow = hWDataSet.Task1.NewTask1Row();
                                    zRow.Id_stock = tRow.Id_stock;
                                    zRow.LastName = tRow.LastName;
                                    zRow.ID = rRow.DetailId;
                                    zRow.kol_vo = rRow.Kol_vo;
                                    zRow.date_shipping = rRow.date_shipping;
                                    hWDataSet.Task1.AddTask1Row(zRow);
                                }
                            }
                        }
                    }
                }
            }
            dataGridView1.Refresh();
            this.Text = "Запрос через двойной цикл";

        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                var date1 = Convert.ToString(txtDate1.Text);
                var date2 = Convert.ToString(txtDate2.Text);
                QueryZapr1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
