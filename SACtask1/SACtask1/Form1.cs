using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SACtask1
{
    public partial class Form1 : Form
    {
        float total;
        public Form1()
        {
            InitializeComponent();
        }

        private float CalculateCurrentValue(float purchasedValue, int age)
        {
            float depreciation = purchasedValue * 0.2f * age;
            if (depreciation > purchasedValue) return 0f;
            return purchasedValue - depreciation;
        }
        private void btn_cal_Click(object sender, EventArgs e)
        {
            float purchasedValue = (float)number_pay.Value;
            int age = (int)number_book.Value;
            if (purchasedValue == 0.0 | age == 0)
            {
                lbl_output.Text = "Please enter a valid price or year";
            }
            else
            {
                float currentValue = CalculateCurrentValue(purchasedValue, age);
                total += currentValue;
                lbl_output.Text = $"The item is worth ${currentValue}\n The collection so far is worth ${total}";
            }
            
        }

        private void resetInputs()
        {

            number_book.Value = 0;
            number_pay.Value = 0;
        }

            private void number_pay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            resetInputs();
            lbl_output.Text = "";
        }
    }
}
