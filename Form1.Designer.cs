namespace Forms
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
            this.pan = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.S1 = new System.Windows.Forms.Button();
            this.Log1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pan);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 209);
            this.panel1.TabIndex = 0;
            // 
            // pan
            // 
            this.pan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan.BackgroundImage")));
            this.pan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pan.Location = new System.Drawing.Point(584, 3);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(153, 117);
            this.pan.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.S1);
            this.panel2.Controls.Add(this.Log1);
            this.panel2.Location = new System.Drawing.Point(-1, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 284);
            this.panel2.TabIndex = 1;
            // 
            // S1
            // 
            this.S1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S1.Image = ((System.Drawing.Image)(resources.GetObject("S1.Image")));
            this.S1.Location = new System.Drawing.Point(581, 125);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(117, 30);
            this.S1.TabIndex = 1;
            this.S1.UseVisualStyleBackColor = true;
            this.S1.Click += new System.EventHandler(this.S1_Click);
            // 
            // Log1
            // 
            this.Log1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Log1.BackgroundImage")));
            this.Log1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Log1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Log1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Log1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Log1.Image = ((System.Drawing.Image)(resources.GetObject("Log1.Image")));
            this.Log1.Location = new System.Drawing.Point(468, 125);
            this.Log1.Name = "Log1";
            this.Log1.Size = new System.Drawing.Size(93, 30);
            this.Log1.TabIndex = 0;
            this.Log1.UseVisualStyleBackColor = true;
            this.Log1.Click += new System.EventHandler(this.Log1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(740, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Log1;
        private System.Windows.Forms.Button S1;
        private System.Windows.Forms.Panel pan;
    }
}

