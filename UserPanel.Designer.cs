namespace Forms
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.lbUserName = new System.Windows.Forms.Label();
            this.Fino = new System.Windows.Forms.Label();
            this.pan = new System.Windows.Forms.Panel();
            this.Registered = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.Label();
            this.UCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SeatBox = new System.Windows.Forms.TextBox();
            this.FormCbox1 = new System.Windows.Forms.ComboBox();
            this.ToCBox2 = new System.Windows.Forms.ComboBox();
            this.Orderbutton = new System.Windows.Forms.Button();
            this.flightcombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbUserName.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(616, 18);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(64, 23);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Profile";
            this.lbUserName.Click += new System.EventHandler(this.lbUserName_Click);
            // 
            // Fino
            // 
            this.Fino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fino.ForeColor = System.Drawing.Color.Maroon;
            this.Fino.Location = new System.Drawing.Point(18, 55);
            this.Fino.Name = "Fino";
            this.Fino.Size = new System.Drawing.Size(121, 32);
            this.Fino.TabIndex = 1;
            this.Fino.Text = "Flight Info :";
            // 
            // pan
            // 
            this.pan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan.BackgroundImage")));
            this.pan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pan.Location = new System.Drawing.Point(737, 9);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(153, 117);
            this.pan.TabIndex = 25;
            // 
            // Registered
            // 
            this.Registered.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registered.ForeColor = System.Drawing.Color.Maroon;
            this.Registered.Location = new System.Drawing.Point(6, 346);
            this.Registered.Name = "Registered";
            this.Registered.Size = new System.Drawing.Size(133, 32);
            this.Registered.TabIndex = 32;
            this.Registered.Text = "Booking :";
            // 
            // Details
            // 
            this.Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.ForeColor = System.Drawing.Color.Maroon;
            this.Details.Location = new System.Drawing.Point(18, 90);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(133, 32);
            this.Details.TabIndex = 33;
            this.Details.Text = "Seats :";
            // 
            // UCancel
            // 
            this.UCancel.Image = ((System.Drawing.Image)(resources.GetObject("UCancel.Image")));
            this.UCancel.Location = new System.Drawing.Point(341, 549);
            this.UCancel.Name = "UCancel";
            this.UCancel.Size = new System.Drawing.Size(83, 34);
            this.UCancel.TabIndex = 35;
            this.UCancel.UseVisualStyleBackColor = true;
            this.UCancel.Click += new System.EventHandler(this.UCancel_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Hello";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(87, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mr. / Mrs. / Miss";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(281, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(556, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 40;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(9, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "* Status = A ( is available ) and NA ( is not available )";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(714, 177);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 381);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(730, 150);
            this.dataGridView2.TabIndex = 60;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(732, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 62;
            this.label1.Text = "From :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(732, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 32);
            this.label6.TabIndex = 64;
            this.label6.Text = "To  :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(732, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 32);
            this.label5.TabIndex = 67;
            this.label5.Text = "Order:";
            // 
            // SeatBox
            // 
            this.SeatBox.Location = new System.Drawing.Point(737, 254);
            this.SeatBox.Name = "SeatBox";
            this.SeatBox.Size = new System.Drawing.Size(153, 20);
            this.SeatBox.TabIndex = 68;
            // 
            // FormCbox1
            // 
            this.FormCbox1.FormattingEnabled = true;
            this.FormCbox1.Location = new System.Drawing.Point(737, 159);
            this.FormCbox1.Name = "FormCbox1";
            this.FormCbox1.Size = new System.Drawing.Size(153, 21);
            this.FormCbox1.TabIndex = 69;
            this.FormCbox1.SelectedIndexChanged += new System.EventHandler(this.FormCbox1_SelectedIndexChanged);
            // 
            // ToCBox2
            // 
            this.ToCBox2.FormattingEnabled = true;
            this.ToCBox2.Location = new System.Drawing.Point(737, 206);
            this.ToCBox2.Name = "ToCBox2";
            this.ToCBox2.Size = new System.Drawing.Size(153, 21);
            this.ToCBox2.TabIndex = 70;
            this.ToCBox2.SelectedIndexChanged += new System.EventHandler(this.ToCBox2_SelectedIndexChanged);
            // 
            // Orderbutton
            // 
            this.Orderbutton.Image = ((System.Drawing.Image)(resources.GetObject("Orderbutton.Image")));
            this.Orderbutton.Location = new System.Drawing.Point(818, 350);
            this.Orderbutton.Name = "Orderbutton";
            this.Orderbutton.Size = new System.Drawing.Size(72, 28);
            this.Orderbutton.TabIndex = 72;
            this.Orderbutton.UseVisualStyleBackColor = true;
            this.Orderbutton.Click += new System.EventHandler(this.Orderbutton_Click);
            // 
            // flightcombo
            // 
            this.flightcombo.FormattingEnabled = true;
            this.flightcombo.Location = new System.Drawing.Point(737, 318);
            this.flightcombo.Name = "flightcombo";
            this.flightcombo.Size = new System.Drawing.Size(153, 21);
            this.flightcombo.TabIndex = 73;
            this.flightcombo.SelectedIndexChanged += new System.EventHandler(this.flightcombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(732, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 32);
            this.label8.TabIndex = 74;
            this.label8.Text = "FlightName:";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(902, 639);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flightcombo);
            this.Controls.Add(this.Orderbutton);
            this.Controls.Add(this.ToCBox2);
            this.Controls.Add(this.FormCbox1);
            this.Controls.Add(this.SeatBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UCancel);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Registered);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.Fino);
            this.Controls.Add(this.lbUserName);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPanel_FormClosing);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label Fino;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Label Registered;
        private System.Windows.Forms.Label Details;
        private System.Windows.Forms.Button UCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SeatBox;
        private System.Windows.Forms.ComboBox FormCbox1;
        private System.Windows.Forms.ComboBox ToCBox2;
        private System.Windows.Forms.Button Orderbutton;
        private System.Windows.Forms.ComboBox flightcombo;
        private System.Windows.Forms.Label label8;

    }
}