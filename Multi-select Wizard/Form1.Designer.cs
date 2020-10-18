namespace multiselectwizard
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
            this.leftListBox = new System.Windows.Forms.ListBox();
            this.rightListBox = new System.Windows.Forms.ListBox();
            this.allLeftButton = new System.Windows.Forms.Button();
            this.allRightButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftListBox
            // 
            this.leftListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftListBox.FormattingEnabled = true;
            this.leftListBox.ItemHeight = 31;
            this.leftListBox.Items.AddRange(new object[] {
            "Fruits",
            "Vegetables",
            "Meat",
            "Shoes",
            "Kurtis",
            "Leggings",
            "Dress",
            "Jewellery",
            "Cereals",
            "Hair & Makeup"});
            this.leftListBox.Location = new System.Drawing.Point(95, 96);
            this.leftListBox.Name = "leftListBox";
            this.leftListBox.Size = new System.Drawing.Size(371, 345);
            this.leftListBox.TabIndex = 0;
            // 
            // rightListBox
            // 
            this.rightListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightListBox.FormattingEnabled = true;
            this.rightListBox.ItemHeight = 31;
            this.rightListBox.Location = new System.Drawing.Point(712, 96);
            this.rightListBox.Name = "rightListBox";
            this.rightListBox.Size = new System.Drawing.Size(371, 345);
            this.rightListBox.TabIndex = 1;
            // 
            // allLeftButton
            // 
            this.allLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allLeftButton.Location = new System.Drawing.Point(489, 96);
            this.allLeftButton.Name = "allLeftButton";
            this.allLeftButton.Size = new System.Drawing.Size(60, 23);
            this.allLeftButton.TabIndex = 2;
            this.allLeftButton.Text = "All";
            this.allLeftButton.UseVisualStyleBackColor = true;
            this.allLeftButton.Click += new System.EventHandler(this.AllLeftButton_Click);
            // 
            // allRightButton
            // 
            this.allRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allRightButton.Location = new System.Drawing.Point(636, 418);
            this.allRightButton.Name = "allRightButton";
            this.allRightButton.Size = new System.Drawing.Size(60, 23);
            this.allRightButton.TabIndex = 3;
            this.allRightButton.Text = "All";
            this.allRightButton.UseVisualStyleBackColor = true;
            this.allRightButton.Click += new System.EventHandler(this.AllRightButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveRightButton.Location = new System.Drawing.Point(555, 193);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(75, 43);
            this.moveRightButton.TabIndex = 4;
            this.moveRightButton.Text = ">>>";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.MoveRightButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveLeftButton.Location = new System.Drawing.Point(554, 255);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(75, 43);
            this.moveLeftButton.TabIndex = 5;
            this.moveLeftButton.Text = "<<<";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.MoveLeftButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(350, 460);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(116, 43);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(712, 460);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(130, 43);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.moveLeftButton);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.allRightButton);
            this.Controls.Add(this.allLeftButton);
            this.Controls.Add(this.rightListBox);
            this.Controls.Add(this.leftListBox);
            this.Name = "Form1";
            this.Text = "Multi-Select Wizard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox leftListBox;
        private System.Windows.Forms.ListBox rightListBox;
        private System.Windows.Forms.Button allLeftButton;
        private System.Windows.Forms.Button allRightButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button submitButton;
    }
}

