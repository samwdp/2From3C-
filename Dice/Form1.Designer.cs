namespace Dice
{
    partial class Dice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dice));
            this.randomBtn = new System.Windows.Forms.Button();
            this.convertBtn = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.number3 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(198, 38);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(116, 23);
            this.randomBtn.TabIndex = 1;
            this.randomBtn.Text = "Random Number";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(221, 90);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 2;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(39, 41);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 20);
            this.number1.TabIndex = 3;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(39, 67);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 20);
            this.number2.TabIndex = 4;
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(39, 93);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(100, 20);
            this.number3.TabIndex = 5;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(39, 154);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(275, 96);
            this.output.TabIndex = 6;
            this.output.Text = "";
            // 
            // Dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 262);
            this.Controls.Add(this.output);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.randomBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dice";
            this.Text = "2 From 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox number3;
        private System.Windows.Forms.RichTextBox output;
    }
}

