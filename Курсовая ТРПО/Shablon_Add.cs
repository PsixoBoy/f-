using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class Shablon_Add : Form
    {
       
        public Shablon_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            int num;
            double Num;
            bool isNum = true;
            if ((isNum == double.TryParse(Selling_Box.Text, out Num)) && (isNum == double.TryParse(Purchase_Box.Text, out Num)) && (isNum == int.TryParse(scu_Box.Text, out num)) && (isNum == int.TryParse(pcu_Box.Text, out num)))
            {
                foreach (Product item in GeneralForm.table_of_products)
                {
                    if (item.code_product - index < 2)
                        index = item.code_product;
                }
                index++;

                Product product = new Product(index, Name_Box.Text, double.Parse(Selling_Box.Text), double.Parse(Purchase_Box.Text), int.Parse(scu_Box.Text), int.Parse(pcu_Box.Text));
                GeneralForm.table_of_products.Add(product);

                this.Close();
            }
            else
                MessageBox.Show("Неверный формат в полях для чисел");
            
            
        }

        private void Price_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Shablon_Add_Load(object sender, EventArgs e)
        {

        }

        private void Purchase_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
