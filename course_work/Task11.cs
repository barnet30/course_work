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
    public partial class Task11 : Form
    {
        public Task11()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                var date1 = Convert.ToString(txtDate1.Text);
                var date2 = Convert.ToString(txtDate2.Text);
                task1TableAdapter.Fill(hWDataSet.Task1, date1, date2);
                this.Text = "Запрос на основании объекта TableAdapter";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Task11_Load(object sender, EventArgs e)
        {

        }
    }
}
