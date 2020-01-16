using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recursion_but_the_program_works
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Double sum = 0;
            res.Clear();
            recursion hey = new recursion();
            switch (f.SelectedIndex)
            {
                case 1:
                    res.AppendText("=-=-=-|   Nth Order: " + hey.geometric_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString() + "   |-=-=-=\r\n");
                    for(ulong i = 1; i < ulong.Parse(Nth_order.Text); i++)
                    {
                        if(Double.MaxValue < hey.geometric_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), i) || Double.MinValue > hey.geometric_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), i))
                            break;
                        res.AppendText("Order " + i + ": " + hey.geometric_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), i).ToString() + "\r\n");
                        sum = sum + hey.geometric_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), i);
                    }
                    if(Double.MaxValue < hey.geometric_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)) || Double.MinValue > hey.geometric_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)))
                        res.AppendText("\r\n////Overflow. Please try with a lower order/ratio.\\\\\\\\");
                    else
                    {
                        res.AppendText("Order " + Nth_order.Text + ": " + hey.geometric_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString());
                        sum = sum + hey.geometric_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text));
                        res.AppendText("\r\n=-=-=-|   Total sum: " + sum + "   |-=-=-=\r\n");
                        res.AppendText("=-=-=-|   Nth Order: " + hey.geometric_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString() + "   |-=-=-="); 
                    }
                    break;
                case 3:
                    res.AppendText("=-=-=-|   Nth Order: " + hey.geometric_progression_percentage_positive_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString() + "   |-=-=-=\r\n");
                    for(ulong i = 1; i < ulong.Parse(Nth_order.Text); i++)
                    {
                        if(Double.MaxValue < hey.geometric_progression_percentage_positive_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), i) || Double.MinValue > hey.geometric_progression_percentage_positive_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), i))
                            break;
                        res.AppendText("Order " + i + ": " + hey.geometric_progression_percentage_positive_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), i).ToString() + "\r\n");
                        sum = sum + hey.geometric_progression_percentage_positive_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), i);
                    }
                    if(Double.MaxValue < hey.geometric_progression_percentage_positive_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)) || Double.MinValue > hey.geometric_progression_percentage_positive_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)))
                        res.AppendText("\r\n////Overflow. Please try with a lower order/ratio.\\\\\\\\");
                    else
                    {
                        res.AppendText("Order " + Nth_order.Text + ": " + hey.geometric_progression_percentage_positive_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString());
                        sum = sum + hey.geometric_progression_percentage_positive_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text));
                        res.AppendText("\r\n=-=-=-|   Total sum: " + sum + "   |-=-=-=\r\n");
                        res.AppendText("=-=-=-|   Nth Order: " + hey.geometric_progression_percentage_positive_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString() + "   |-=-=-="); 
                    }
                    break;
                case 2:
                    res.AppendText("=-=-=-|   Nth Order: " + hey.geometric_progression_percentage_negative_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString() + "   |-=-=-=\r\n");
                    for(ulong i = 1; i < ulong.Parse(Nth_order.Text); i++)
                    {
                        if(Double.MaxValue < hey.geometric_progression_percentage_negative_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), i) || Double.MinValue > hey.geometric_progression_percentage_negative_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), i))
                            break;
                        res.AppendText("Order " + i + ": " + hey.geometric_progression_percentage_negative_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), i).ToString() + "\r\n");
                        sum = sum + hey.geometric_progression_percentage_negative_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), i);
                    }
                    if(Double.MaxValue < hey.geometric_progression_percentage_negative_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)) || Double.MinValue > hey.geometric_progression_percentage_negative_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)))
                        res.AppendText("\r\n////Overflow. Please try with a lower order/ratio.\\\\\\\\");
                    else
                    {
                        res.AppendText("Order " + Nth_order.Text + ": " + hey.geometric_progression_percentage_negative_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString());
                        sum = sum + hey.geometric_progression_percentage_negative_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text));
                        res.AppendText("\r\n=-=-=-|   Total sum: " + sum + "   |-=-=-=\r\n");
                        res.AppendText("=-=-=-|   Nth Order: " + hey.geometric_progression_percentage_negative_growth(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString() + "   |-=-=-="); 
                    }
                    break;
                case 0:
                    res.AppendText("=-=-=-|   Nth Order: " + hey.arithmetic_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString() + "   |-=-=-=\r\n");
                    for(ulong i = 1; i < ulong.Parse(Nth_order.Text); i++)
                    {
                        if(Double.MaxValue < hey.arithmetic_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), i) || Double.MinValue > hey.arithmetic_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), i))
                            break;
                        res.AppendText("Order " + i + ": " + hey.arithmetic_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), i).ToString() + "\r\n");
                        sum = sum + hey.arithmetic_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), i);
                    }
                    if(Double.MaxValue < hey.arithmetic_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)) || Double.MinValue > hey.arithmetic_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)))
                        res.AppendText("\r\n////Overflow. Please try with a lower order/ratio.\\\\\\\\");
                    else
                    {
                        res.AppendText("Order " + Nth_order.Text + ": " + hey.arithmetic_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString());
                        sum = sum + hey.arithmetic_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text));
                        res.AppendText("\r\n=-=-=-|   Total sum: " + sum + "   |-=-=-=\r\n");
                        res.AppendText("=-=-=-|   Nth Order: " + hey.arithmetic_progression(double.Parse(order_1.Text), double.Parse(Ratio.Text), ulong.Parse(Nth_order.Text)).ToString() + "   |-=-=-=");
                    }
                    break;
            }
        }
    }
}
