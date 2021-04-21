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
    public partial class Task15 : Form
    {
        public Task15()
        {
            InitializeComponent();
        }

        private void Task15_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            FillGridByReader();
        }
        private void FillGridByReader()
        {
            SqlConnection con = new SqlConnection(
            Properties.Settings.Default.HWConnectionString);
            // создаем объект связь с бд, строку соединения берём из
            // свойств проекта, можно задать самим строкой
            con.Open();
            // подключаемся к бд
            String m1 = Convert.ToString(txtDate1.Text);
            String m2 = Convert.ToString(txtDate2.Text);
            String str = "SELECT Stocks.Id_stock,Stocks.LastName,Shipping.date_shipping," +
                "Directory_details.ID,Shipping.kol_vo FROM Shipping, Stocks, Directory_details " +
                "WHERE Stocks.Id_stock = Shipping.StockId and Directory_details.ID = Shipping.DetailId and " +
                "date_shipping >= '"+ Convert.ToString(m1) +"'"+ " and date_shipping <= " + "'"+
                Convert.ToString(m2)+"'";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Refresh();
        }


        private void btnFill_Click(object sender, EventArgs e)
        {
            FillGridByReader();
        }
    }
}
