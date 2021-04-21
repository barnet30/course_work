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
    public partial class Task22 : Form
    {
        public Task22()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                var date1 = Convert.ToString(txtDate1.Text);
                var date2 = Convert.ToString(txtDate2.Text);
                this.task2TableAdapter.Fill(this.hWDataSet.Task2, date1, date2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
