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
    public partial class GeneralView : Form
    {
        public GeneralView()
        {
            InitializeComponent();
        }

        private void GeneralView_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hWDataSet.StocksDirectorydetailsShipping". При необходимости она может быть перемещена или удалена.
            this.stocksDirectorydetailsShippingTableAdapter.Fill(this.hWDataSet.StocksDirectorydetailsShipping);

        }
    }
}
