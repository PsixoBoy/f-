using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class Edit_Form : Form
    {
        public Edit_Form()
        {
            InitializeComponent();
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            int index = -1;
            bool isNum = true;
            double num;
            int Num;
            if (Code_Box.Text != "")
            {
                foreach (Product item in GeneralForm.table_of_products)
                {
                    if (item.code_product == Convert.ToInt16(Code_Box.Text))
                    {
                        index = item.code_product;



                        if (Name_Box.Text != "")
                        {
                            GeneralForm.table_of_products[index - 1].bank_name = Name_Box.Text;
                            item.bank_name = Name_Box.Text;
                        }

                        if (Selling_Box.Text != "")
                        {
                            if (isNum == double.TryParse(Selling_Box.Text, out num))
                            {
                                GeneralForm.table_of_products[index - 1].selling_rate = Double.Parse(Selling_Box.Text);
                                item.selling_rate = Double.Parse(Selling_Box.Text);

                            }
                            else
                                MessageBox.Show("В поле должы быть только числа");
                        }

                        if (Purchase_Box.Text != "")
                        {
                            if (isNum == double.TryParse(Purchase_Box.Text, out num))
                            {

                                GeneralForm.table_of_products[index - 1].purchase_rate = Double.Parse(Purchase_Box.Text);
                                item.purchase_rate = Double.Parse(Purchase_Box.Text);
                            }
                            else
                                MessageBox.Show("В поле должы быть только числа");
                        }


                        if (scu_Box.Text != "")
                        {
                            if (isNum == int.TryParse(scu_Box.Text, out Num))
                            {
                                GeneralForm.table_of_products[index - 1].selled_cu = Int16.Parse(scu_Box.Text);
                                item.selled_cu = Int16.Parse(scu_Box.Text);
                            }
                            else
                                MessageBox.Show("В поле должны быть только целые числа");
                        }

                        if (pcu_Box.Text != "")
                        {
                            if (isNum == int.TryParse(pcu_Box.Text, out Num))
                            {
                                GeneralForm.table_of_products[index - 1].purchased_cu = Int16.Parse(pcu_Box.Text);
                                item.purchased_cu = Int16.Parse(pcu_Box.Text);
                            }
                            else
                                MessageBox.Show("В поле должны быть только целые числа");
                        }
                    }
                    
                }
                if (index == -1)
                    MessageBox.Show("Такого поля нет");
                else
                this.Close();
            }
            else
                MessageBox.Show("Вы не ввели код товара");
        }

        private void Name_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purchase_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
