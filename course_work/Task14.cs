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
    public partial class Task14 : Form
    {
        public Task14()
        {
            InitializeComponent();
        }

        private void Task14_Load(object sender, EventArgs e)
        {
            this.stocksTableAdapter.Fill(this.hWDataSet.Stocks);
            this.shippingTableAdapter.Fill(this.hWDataSet.Shipping);
            this.directory_detailsTableAdapter.Fill(this.hWDataSet.Directory_details);
            QueryZapr3();
        }

        private void QueryZapr3()
        {
            hWDataSet.Task1.Clear();
            foreach (HWDataSet.ShippingRow rRow in hWDataSet.Shipping.Rows)
            {
                if ((rRow.date_shipping >= Convert.ToDateTime(txtDate1.Text)) &&
                    (rRow.date_shipping <= Convert.ToDateTime(txtDate2.Text)))
                {
                    HWDataSet.StocksRow sRow = rRow.GetParentRow("fk_shipping_to_Stocks")
                        as HWDataSet.StocksRow;
                    HWDataSet.Directory_detailsRow dRow = rRow.GetParentRow("fk_shipping_to_Directory_details") 
                        as HWDataSet.Directory_detailsRow;
                    HWDataSet.Task1Row zRow = hWDataSet.Task1.NewTask1Row();
                    zRow.Id_stock = sRow.Id_stock;
                    zRow.LastName = sRow.LastName;
                    zRow.ID = dRow.ID;
                    zRow.kol_vo = rRow.Kol_vo;
                    zRow.date_shipping = rRow.date_shipping;
                    hWDataSet.Task1.AddTask1Row(zRow);
                }

            }
            dataGridView1.Refresh();
            this.Text = "Запрос через DataRelation";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                var date1 = Convert.ToString(txtDate1.Text);
                var date2 = Convert.ToString(txtDate2.Text);
                QueryZapr3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
