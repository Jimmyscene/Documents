namespace Homework7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.make_lbl = new System.Windows.Forms.Label();
            this.make_box = new System.Windows.Forms.ComboBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.amount_lbl = new System.Windows.Forms.Label();
            this.confirn_btn = new System.Windows.Forms.Button();
            this.air_box = new System.Windows.Forms.CheckBox();
            this.auto_box = new System.Windows.Forms.CheckBox();
            this.out_date = new System.Windows.Forms.DateTimePicker();
            this.in_date = new System.Windows.Forms.DateTimePicker();
            this.check_out = new System.Windows.Forms.Label();
            this.check_in = new System.Windows.Forms.Label();
            this.car_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.car_label);
            this.panel1.Controls.Add(this.make_lbl);
            this.panel1.Controls.Add(this.make_box);
            this.panel1.Controls.Add(this.car);
            this.panel1.Controls.Add(this.amount_lbl);
            this.panel1.Controls.Add(this.confirn_btn);
            this.panel1.Controls.Add(this.air_box);
            this.panel1.Controls.Add(this.auto_box);
            this.panel1.Controls.Add(this.out_date);
            this.panel1.Controls.Add(this.in_date);
            this.panel1.Controls.Add(this.check_out);
            this.panel1.Controls.Add(this.check_in);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 508);
            this.panel1.TabIndex = 0;
            // 
            // make_lbl
            // 
            this.make_lbl.AutoSize = true;
            this.make_lbl.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_lbl.Location = new System.Drawing.Point(25, 144);
            this.make_lbl.Name = "make_lbl";
            this.make_lbl.Size = new System.Drawing.Size(86, 29);
            this.make_lbl.TabIndex = 10;
            this.make_lbl.Text = "Maker:";
            
            // 
            // make_box
            // 
            this.make_box.FormattingEnabled = true;
            this.make_box.Items.AddRange(new object[] {
            "BMW",
            "Ford",
            "Honda",
            "Nissan",
            "Subaru",
            "Toyota"});
            this.make_box.Location = new System.Drawing.Point(200, 153);
            this.make_box.Name = "make_box";
            this.make_box.Size = new System.Drawing.Size(200, 21);
            this.make_box.TabIndex = 9;
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.InitialImage = null;
            this.car.Location = new System.Drawing.Point(30, 253);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(739, 235);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car.TabIndex = 8;
            this.car.TabStop = false;
            this.car.Visible = false;
            // 
            // amount_lbl
            // 
            this.amount_lbl.AutoSize = true;
            this.amount_lbl.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_lbl.Location = new System.Drawing.Point(25, 203);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(105, 29);
            this.amount_lbl.TabIndex = 7;
            this.amount_lbl.Text = "Amount:";
            // 
            // confirn_btn
            // 
            this.confirn_btn.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirn_btn.Location = new System.Drawing.Point(369, 188);
            this.confirn_btn.Name = "confirn_btn";
            this.confirn_btn.Size = new System.Drawing.Size(207, 59);
            this.confirn_btn.TabIndex = 6;
            this.confirn_btn.Text = "Confirm Rental";
            this.confirn_btn.UseVisualStyleBackColor = true;
            // 
            // air_box
            // 
            this.air_box.AutoSize = true;
            this.air_box.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.air_box.Location = new System.Drawing.Point(471, 97);
            this.air_box.Name = "air_box";
            this.air_box.Size = new System.Drawing.Size(74, 33);
            this.air_box.TabIndex = 5;
            this.air_box.Text = "Air?";
            this.air_box.UseVisualStyleBackColor = true;
            
            // 
            // auto_box
            // 
            this.auto_box.AutoSize = true;
            this.auto_box.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auto_box.Location = new System.Drawing.Point(471, 39);
            this.auto_box.Name = "auto_box";
            this.auto_box.Size = new System.Drawing.Size(152, 33);
            this.auto_box.TabIndex = 4;
            this.auto_box.Text = "Automatic?";
            this.auto_box.UseVisualStyleBackColor = true;
            // 
            // out_date
            // 
            this.out_date.Location = new System.Drawing.Point(200, 97);
            this.out_date.Name = "out_date";
            this.out_date.Size = new System.Drawing.Size(200, 20);
            this.out_date.TabIndex = 3;
            // 
            // in_date
            // 
            this.in_date.Location = new System.Drawing.Point(200, 46);
            this.in_date.Name = "in_date";
            this.in_date.Size = new System.Drawing.Size(200, 20);
            this.in_date.TabIndex = 2;
            // 
            // check_out
            // 
            this.check_out.AutoSize = true;
            this.check_out.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_out.Location = new System.Drawing.Point(25, 91);
            this.check_out.Name = "check_out";
            this.check_out.Size = new System.Drawing.Size(132, 29);
            this.check_out.TabIndex = 1;
            this.check_out.Text = "Check Out:";
            // 
            // check_in
            // 
            this.check_in.AutoSize = true;
            this.check_in.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_in.Location = new System.Drawing.Point(25, 40);
            this.check_in.Name = "check_in";
            this.check_in.Size = new System.Drawing.Size(113, 29);
            this.check_in.TabIndex = 0;
            this.check_in.Text = "Check In:";
            // 
            // car_label
            // 
            this.car_label.AutoSize = true;
            this.car_label.BackColor = System.Drawing.Color.Black;
            this.car_label.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_label.ForeColor = System.Drawing.Color.White;
            this.car_label.Location = new System.Drawing.Point(374, 357);
            this.car_label.Name = "car_label";
            this.car_label.Size = new System.Drawing.Size(72, 29);
            this.car_label.TabIndex = 11;
            this.car_label.Text = "label1";
            this.car_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 532);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            this.ResumeLayout(false);

        }
       
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox air_box;
        private System.Windows.Forms.CheckBox auto_box;
        private System.Windows.Forms.DateTimePicker out_date;
        private System.Windows.Forms.DateTimePicker in_date;
        private System.Windows.Forms.Label check_out;
        private System.Windows.Forms.Label check_in;
        private System.Windows.Forms.Button confirn_btn;
        private System.Windows.Forms.Label amount_lbl;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Label make_lbl;
        private System.Windows.Forms.ComboBox make_box;
        private System.Windows.Forms.Label car_label;
        
       
    }
}

