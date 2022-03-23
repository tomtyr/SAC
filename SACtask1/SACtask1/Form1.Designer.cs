namespace SACtask1
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
            this.number_book = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.number_pay = new System.Windows.Forms.NumericUpDown();
            this.btn_cal = new System.Windows.Forms.Button();
            this.lbl_worth2 = new System.Windows.Forms.Label();
            this.lbl_worth = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_end = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.number_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_pay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "How old is the textbook?";
            // 
            // number_book
            // 
            this.number_book.Location = new System.Drawing.Point(42, 77);
            this.number_book.Name = "number_book";
            this.number_book.Size = new System.Drawing.Size(178, 26);
            this.number_book.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "How much did you pay for it?";
            // 
            // number_pay
            // 
            this.number_pay.Location = new System.Drawing.Point(46, 248);
            this.number_pay.Name = "number_pay";
            this.number_pay.Size = new System.Drawing.Size(207, 26);
            this.number_pay.TabIndex = 3;
            this.number_pay.ValueChanged += new System.EventHandler(this.number_pay_ValueChanged);
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(46, 343);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(103, 34);
            this.btn_cal.TabIndex = 4;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // lbl_worth2
            // 
            this.lbl_worth2.AutoSize = true;
            this.lbl_worth2.Location = new System.Drawing.Point(494, 43);
            this.lbl_worth2.Name = "lbl_worth2";
            this.lbl_worth2.Size = new System.Drawing.Size(0, 20);
            this.lbl_worth2.TabIndex = 5;
            // 
            // lbl_worth
            // 
            this.lbl_worth.AutoSize = true;
            this.lbl_worth.Location = new System.Drawing.Point(498, 90);
            this.lbl_worth.Name = "lbl_worth";
            this.lbl_worth.Size = new System.Drawing.Size(0, 20);
            this.lbl_worth.TabIndex = 6;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(446, 34);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(13, 20);
            this.lbl_output.TabIndex = 7;
            this.lbl_output.Text = " ";
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(498, 248);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(112, 39);
            this.btn_end.TabIndex = 8;
            this.btn_end.Text = "End Quote";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_worth);
            this.Controls.Add(this.lbl_worth2);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.number_pay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number_book);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.number_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_pay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown number_book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown number_pay;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Label lbl_worth2;
        private System.Windows.Forms.Label lbl_worth;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_end;
    }
}

