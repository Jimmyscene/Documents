using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.confirn_btn.Click += confirn_btn_Click;
            this.in_date.ValueChanged += this.datehandler;
            this.out_date.ValueChanged += this.datehandler;
            this.auto_box.CheckStateChanged+= delegate{this.UpdateAmount();};
            this.air_box.CheckStateChanged += delegate { this.UpdateAmount(); };
            this.make_box.SelectedValueChanged += delegate { this.UpdateAmount(); };
        }

        private void datehandler(Object o, EventArgs e){

                if (this.GetPeriod() < 0)
                {
                    if (selectioncount++ > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Check Out Date Precedes Check In Date. Please Fix.", "Error Detected", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                }
                else
                {

                    this.UpdateAmount();
                }

            }
        private void UpdateAmount()
        {
            this.amount_lbl.Text = GetAmount().ToString("C", System.Globalization.CultureInfo.CurrentCulture);
            this.car_label.Text = GetAmount().ToString("C", System.Globalization.CultureInfo.CurrentCulture);
        }
        private void MoveCar()
        {
            this.car.Location = new System.Drawing.Point(this.car.Location.X + 50, this.car.Location.Y);
            this.car_label.Location =new System.Drawing.Point(this.car_label.Location.X + 50, this.car_label.Location.Y);
        }
        private int GetPeriod()
        {
            return (this.out_date.Value - this.in_date.Value).Days;
        }
        private int GetOptions()
        {
            int amount = 0;
            if (this.auto_box.Checked)
            {
                amount += 1000;
            }
            if (this.air_box.Checked)
            {
                amount += 750;
            }
            return amount;
        }
        private int GetMake()
        {
            int amount =0;
            switch (make_box.Text)
            {
            case "BMW":
                amount += 5000;
                break;
            case "Ford":
                amount += 20000;
                break;
            case "Honda":
                amount += 12000;
                break;
            case "Nissan":
                amount += 6000000;
                break;
            case "Subaru":
                amount += 2000;
                break;
            case "Toyota":
                amount += 15000;
                break;
            };
            return amount;
        }
        private double GetAmount()
        {
            double amount = 0;
            amount+=GetMake();
            amount += GetPeriod() * 75;
            amount += GetOptions();
            return amount;
        }


    
        private int selectioncount = 0;

        

       

        private void confirn_btn_Click(object sender, EventArgs e)
        {
            UpdateAmount();
            this.car.Visible=true;
            this.car_label.Visible = true;
            this.confirn_btn.Text = "Move";
            this.confirn_btn.Click -= confirn_btn_Click;
            this.confirn_btn.Click += delegate
            {
                MoveCar();

            };
        }
    }
}
