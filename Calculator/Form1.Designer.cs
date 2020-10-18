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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Display = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_clear_entry = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_times = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_change_sign = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_decimal = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Calculator.Properties.Resources.wallpaper_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Display, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_clear, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_clear_entry, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_equal, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_divide, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_times, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_minus, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_change_sign, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_decimal, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_plus, 3, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.91781F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61644F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61644F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61644F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61644F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61644F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 436);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Display, 4);
            this.Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(3, 0);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(456, 95);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_clear
            // 
            this.button_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(3, 98);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(109, 62);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // button_clear_entry
            // 
            this.button_clear_entry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_clear_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_entry.Location = new System.Drawing.Point(118, 98);
            this.button_clear_entry.Name = "button_clear_entry";
            this.button_clear_entry.Size = new System.Drawing.Size(109, 62);
            this.button_clear_entry.TabIndex = 2;
            this.button_clear_entry.Text = "CE";
            this.button_clear_entry.UseVisualStyleBackColor = true;
            this.button_clear_entry.Click += new System.EventHandler(this.Button_clear_entry_Click);
            // 
            // button_equal
            // 
            this.button_equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.Location = new System.Drawing.Point(348, 98);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(111, 62);
            this.button_equal.TabIndex = 3;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.Button_equal_Click);
            // 
            // button_7
            // 
            this.button_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(3, 166);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(109, 62);
            this.button_7.TabIndex = 4;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.Button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(118, 166);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(109, 62);
            this.button_8.TabIndex = 5;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.Button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(233, 166);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(109, 62);
            this.button_9.TabIndex = 6;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.Button_9_Click);
            // 
            // button_divide
            // 
            this.button_divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.Location = new System.Drawing.Point(348, 166);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(111, 62);
            this.button_divide.TabIndex = 7;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.Button_divide_Click);
            // 
            // button_4
            // 
            this.button_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(3, 234);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(109, 62);
            this.button_4.TabIndex = 8;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.Button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(118, 234);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(109, 62);
            this.button_5.TabIndex = 9;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.Button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(233, 234);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(109, 62);
            this.button_6.TabIndex = 10;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.Button_6_Click);
            // 
            // button_times
            // 
            this.button_times.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_times.Location = new System.Drawing.Point(348, 234);
            this.button_times.Name = "button_times";
            this.button_times.Size = new System.Drawing.Size(111, 62);
            this.button_times.TabIndex = 11;
            this.button_times.Text = "x";
            this.button_times.UseVisualStyleBackColor = true;
            this.button_times.Click += new System.EventHandler(this.Button_times_Click);
            // 
            // button_1
            // 
            this.button_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(3, 302);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(109, 62);
            this.button_1.TabIndex = 12;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.Button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(118, 302);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(109, 62);
            this.button_2.TabIndex = 13;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.Button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(233, 302);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(109, 62);
            this.button_3.TabIndex = 14;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.Button_3_Click);
            // 
            // button_minus
            // 
            this.button_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(348, 302);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(111, 62);
            this.button_minus.TabIndex = 15;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.Button_minus_Click);
            // 
            // button_change_sign
            // 
            this.button_change_sign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_change_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change_sign.Location = new System.Drawing.Point(3, 370);
            this.button_change_sign.Name = "button_change_sign";
            this.button_change_sign.Size = new System.Drawing.Size(109, 63);
            this.button_change_sign.TabIndex = 16;
            this.button_change_sign.Text = "+/-";
            this.button_change_sign.UseVisualStyleBackColor = true;
            this.button_change_sign.Click += new System.EventHandler(this.Button_change_sign_Click);
            // 
            // button_0
            // 
            this.button_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(118, 370);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(109, 63);
            this.button_0.TabIndex = 17;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.Button_0_Click);
            // 
            // button_decimal
            // 
            this.button_decimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_decimal.Location = new System.Drawing.Point(233, 370);
            this.button_decimal.Name = "button_decimal";
            this.button_decimal.Size = new System.Drawing.Size(109, 63);
            this.button_decimal.TabIndex = 18;
            this.button_decimal.Text = ".";
            this.button_decimal.UseVisualStyleBackColor = true;
            this.button_decimal.Click += new System.EventHandler(this.Button_decimal_Click);
            // 
            // button_plus
            // 
            this.button_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(348, 370);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(111, 63);
            this.button_plus.TabIndex = 19;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.Button_plus_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 24);
            this.toolStripMenuItem1.Text = "Change Skin";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(222, 24);
            this.toolStripMenuItem2.Text = "Change Display Bckgrnd Color";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_clear_entry;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_times;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_change_sign;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_decimal;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

