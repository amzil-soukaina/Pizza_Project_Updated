using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float CalculateSizePrice()
        {
            if (rbSmall.Checked)            
                return Convert.ToSingle(rbSmall.Tag);

             else if (rbMedium.Checked)         
                return Convert.ToSingle(rbMedium.Tag);

             else           
                return Convert.ToSingle(rbLarg.Tag);

            
        }

        void UpdateLabelSize()
        {
            UpdateLabelPrice();

            if (rbSmall.Checked)
            {
                label1.Text = "Small";
                return;
            }

            if(rbMedium.Checked)
            {
                label1.Text = "Medium";
                return;
            }

            if(rbLarg.Checked)
            {
                label1.Text = "Larg";
                return;
            }
        }

        float CalculateCrustPrice()
        {
            if (rdThin.Checked)
                return Convert.ToSingle(rdThin.Tag);
            else
                return Convert.ToSingle(rdThick.Tag);
        }

        void UpdateLabelCrust()
        {
            UpdateLabelPrice();
            if (rdThin.Checked)
            {
                label3.Text = "Thin Crust";
                return;
            }

            if (rdThick.Checked)
            {
                label3.Text = "Thick Crust";
                return;
            }
        }

        float CalculateToppingsPrice()
        {
            float TotalToppings = 0;

            if (chkBox1.Checked)
                TotalToppings += Convert.ToSingle(chkBox1.Tag);

            if (chkBox2.Checked)
                TotalToppings += Convert.ToSingle(chkBox2.Tag);

            if (chkBox3.Checked)
                TotalToppings += Convert.ToSingle(chkBox3.Tag);

            if (chkOnion.Checked)
                TotalToppings += Convert.ToSingle(chkOnion.Tag);

            if (chkOlives.Checked)
                TotalToppings += Convert.ToSingle(chkOlives.Tag);

            if (chkGreenPeppers.Checked)
                TotalToppings += Convert.ToSingle(chkGreenPeppers.Tag);


            return TotalToppings;

        }

        void UpdateToppingsLabel()
        {
            UpdateLabelPrice();

            string ToppingsString = "";

            if (chkBox1.Checked)
                ToppingsString += "Extra Cheese";

            if (chkBox2.Checked)
                ToppingsString += ", Mushrooms";

            if (chkBox3.Checked)
                ToppingsString += ", Tomatoes";

            if (chkOnion.Checked)
                ToppingsString += ", Onion";

            if (chkOlives.Checked)
                ToppingsString += ", Olives";

            if (chkGreenPeppers.Checked)
                ToppingsString += ", Green Peppers";


            if (ToppingsString.StartsWith(","))
                ToppingsString = ToppingsString.Substring(1, ToppingsString.Length - 1);

            if (ToppingsString == "")
                ToppingsString = "No Toppings";

            label2.Text = ToppingsString;
        }

        void UpdateTakeInOutLabel()
        {
            UpdateLabelPrice();

            if (rdIn.Checked)
                label4.Text = "Eat In";
            else
                label4.Text = "Take Out";
        }

        float CalculateTotalePrice()
        {
            return CalculateSizePrice() + CalculateToppingsPrice() + CalculateCrustPrice();
        }

        void UpdateLabelPrice()
        {
            label5.Text = "$" + CalculateTotalePrice().ToString();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelSize();
        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelCrust();
        }

        private void rdThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabelCrust();
        }

        private void chkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
        }

        private void chkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
        }

        private void chkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
        }

        private void rdIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTakeInOutLabel();
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTakeInOutLabel();
        }

        void OrderButtn()
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    grBoxSize.Enabled = false;
                    grBoxToppings.Enabled = false;
                    grBoxCrust.Enabled = false;
                    grEatPlace.Enabled = false;
                    btnOrder.Enabled = false;           
            }else
                MessageBox.Show("Update Your Order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }


        void Resetbtn()
        {
            grBoxSize.Enabled = true;
            grBoxToppings.Enabled = true;
            grBoxCrust.Enabled = true;
            grEatPlace.Enabled = true;
            btnOrder.Enabled = true;

            chkBox1.Checked = false;
            chkBox2.Checked = false;
            chkBox3.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;

            rbMedium.Checked = true;
            rdThin.Checked = true;
            rdIn.Checked = true;
        }

        void UpdateOrderSummary()
        {
            UpdateLabelSize();
            UpdateLabelCrust();
            UpdateToppingsLabel();
            UpdateTakeInOutLabel();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderButtn();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Resetbtn();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

    }
}
