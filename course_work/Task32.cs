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
    public partial class Task32 : Form
    {
        public Task32()
        {
            InitializeComponent();
        }

        private void Task32_Load(object sender, EventArgs e)
        {
            this.stocksTableAdapter.Fill(this.hWDataSet.Stocks);
            this.shippingTableAdapter.Fill(this.hWDataSet.Shipping);
            this.directory_detailsTableAdapter.Fill(this.hWDataSet.Directory_details);
            ZADACHA3();
        }

        void ZADACHA3()
        {
            bool aT, eR;
            this.Text = " Запрос, содержащий подзапросы (Record)";
            hWDataSet.Task3.Clear();
            foreach (HWDataSet.Directory_detailsRow pRow in hWDataSet.Directory_details.Rows)
            {
                if (Convert.ToInt32(pRow["priсe"]) >= Convert.ToInt32(txtPrice.Text)) 
                {
                    aT = true; //любой товар
                    foreach (HWDataSet.StocksRow tRow in hWDataSet.Stocks.Rows)
                    {
                        {
                            eR = false;
                            foreach (HWDataSet.ShippingRow rRow in hWDataSet.Shipping.Rows)
                            {
                                eR = (Convert.ToInt32(rRow["Kol_vo"]) >= Convert.ToInt32(txtAmount.Text)) && (pRow["ID"].ToString() ==
                                rRow["DetailID"].ToString());
                                if (eR)
                                    break;
                            }
                            aT = eR;
                        }
                        if (!aT)
                            break;
                    }
                    if (aT)
                    {
                        HWDataSet.Task3Row zRow = hWDataSet.Task3.NewTask3Row();
                        zRow["detail_name"] = pRow["detail_name"];
                        zRow["ID"] = pRow["ID"];
                        zRow["detail_type"] = pRow["detail_type"];
                        zRow["Directory_units"] = pRow["Directory_units"];
                        zRow["priсe"] = pRow["priсe"];
                        hWDataSet.Task3.Rows.Add(zRow);
                    }
                }
            }
            dataGridView1.Refresh();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                var price = int.Parse(txtPrice.Text);
                var amount = int.Parse(txtAmount.Text);
                ZADACHA3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
