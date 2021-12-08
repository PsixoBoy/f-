using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class thenewtable : Form
    {
        public thenewtable()
        {
            InitializeComponent();
        }

        private void thenewtable_Load(object sender, EventArgs e)
        {
            

                foreach (Product item in GeneralForm.table_of_products)
                    Newdata.Rows.Add(item.code_product, item.bank_name, item.selled_cu*item.selling_rate, item.selled_cu);
        }

        private void Newdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
