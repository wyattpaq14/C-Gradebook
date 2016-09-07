namespace Lab_7_Gradebook_Accumulate_Test_Score
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtScoreCount = new System.Windows.Forms.Label();
            this.txtScoreAvg = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score Total:";
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.AutoSize = true;
            this.txtScoreCount.Location = new System.Drawing.Point(24, 121);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.Size = new System.Drawing.Size(69, 13);
            this.txtScoreCount.TabIndex = 2;
            this.txtScoreCount.Text = "Score Count:";
            // 
            // txtScoreAvg
            // 
            this.txtScoreAvg.AutoSize = true;
            this.txtScoreAvg.Location = new System.Drawing.Point(24, 157);
            this.txtScoreAvg.Name = "txtScoreAvg";
            this.txtScoreAvg.Size = new System.Drawing.Size(50, 13);
            this.txtScoreAvg.TabIndex = 3;
            this.txtScoreAvg.Text = "Average:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Enabled = false;
            this.txtScoreTotal.Location = new System.Drawing.Point(117, 80);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.Size = new System.Drawing.Size(43, 20);
            this.txtScoreTotal.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(117, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(117, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 20);
            this.textBox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Display Scores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear Scores";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(197, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Add Scores";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtScoreAvg);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Accumaltive Gradebook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtScoreCount;
        private System.Windows.Forms.Label txtScoreAvg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

