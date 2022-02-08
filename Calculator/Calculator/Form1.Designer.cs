namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.list_model = new System.Windows.Forms.ListBox();
            this.cbx_car = new System.Windows.Forms.ComboBox();
            this.cbx_color = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Car";
            // 
            // Car
            // 
            this.Car.AutoSize = true;
            this.Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car.Location = new System.Drawing.Point(93, 184);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(39, 20);
            this.Car.TabIndex = 1;
            this.Car.Text = "Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(288, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.Red;
            this.txt_price.Location = new System.Drawing.Point(237, 538);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(321, 35);
            this.txt_price.TabIndex = 6;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // list_model
            // 
            this.list_model.FormattingEnabled = true;
            this.list_model.ItemHeight = 16;
            this.list_model.Location = new System.Drawing.Point(237, 359);
            this.list_model.Name = "list_model";
            this.list_model.Size = new System.Drawing.Size(321, 132);
            this.list_model.TabIndex = 7;
            this.list_model.SelectedIndexChanged += new System.EventHandler(this.list_model_SelectedIndexChanged);
            // 
            // cbx_car
            // 
            this.cbx_car.FormattingEnabled = true;
            this.cbx_car.Items.AddRange(new object[] {
            "Tata Nexon",
            "Nissan Magnite",
            "Hyundai Verna"});
            this.cbx_car.Location = new System.Drawing.Point(237, 180);
            this.cbx_car.Name = "cbx_car";
            this.cbx_car.Size = new System.Drawing.Size(321, 24);
            this.cbx_car.TabIndex = 8;
            this.cbx_car.Text = "select car";
            this.cbx_car.SelectedIndexChanged += new System.EventHandler(this.cbx_car_SelectedIndexChanged);
            // 
            // cbx_color
            // 
            this.cbx_color.FormattingEnabled = true;
            this.cbx_color.Items.AddRange(new object[] {
            "Red",
            "Silver",
            "Maroon"});
            this.cbx_color.Location = new System.Drawing.Point(237, 266);
            this.cbx_color.Name = "cbx_color";
            this.cbx_color.Size = new System.Drawing.Size(321, 24);
            this.cbx_color.TabIndex = 9;
            this.cbx_color.Text = "select color";
            this.cbx_color.SelectedIndexChanged += new System.EventHandler(this.cbx_color_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 763);
            this.Controls.Add(this.cbx_color);
            this.Controls.Add(this.cbx_car);
            this.Controls.Add(this.list_model);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Car;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.ListBox list_model;
        private System.Windows.Forms.ComboBox cbx_car;
        private System.Windows.Forms.ComboBox cbx_color;
    }
}