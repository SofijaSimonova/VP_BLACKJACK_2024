namespace Blackjack
{
    partial class Payment
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_cardnumber = new System.Windows.Forms.Label();
            this.lbl_expirationdate = new System.Windows.Forms.Label();
            this.lbl_ccv = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.mtb_cardnumber = new System.Windows.Forms.MaskedTextBox();
            this.mtb_expirationdate = new System.Windows.Forms.MaskedTextBox();
            this.mtb_ccv = new System.Windows.Forms.MaskedTextBox();
            this.nud_amount = new System.Windows.Forms.NumericUpDown();
            this.lbl_dollar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_deposit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(12, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(362, 20);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Please enter your payment card information:";
            // 
            // lbl_cardnumber
            // 
            this.lbl_cardnumber.AutoSize = true;
            this.lbl_cardnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cardnumber.Location = new System.Drawing.Point(32, 71);
            this.lbl_cardnumber.Name = "lbl_cardnumber";
            this.lbl_cardnumber.Size = new System.Drawing.Size(119, 20);
            this.lbl_cardnumber.TabIndex = 1;
            this.lbl_cardnumber.Text = "Card Number:";
            // 
            // lbl_expirationdate
            // 
            this.lbl_expirationdate.AutoSize = true;
            this.lbl_expirationdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expirationdate.Location = new System.Drawing.Point(32, 148);
            this.lbl_expirationdate.Name = "lbl_expirationdate";
            this.lbl_expirationdate.Size = new System.Drawing.Size(138, 20);
            this.lbl_expirationdate.TabIndex = 2;
            this.lbl_expirationdate.Text = "Expiration Date:";
            // 
            // lbl_ccv
            // 
            this.lbl_ccv.AutoSize = true;
            this.lbl_ccv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ccv.Location = new System.Drawing.Point(240, 148);
            this.lbl_ccv.Name = "lbl_ccv";
            this.lbl_ccv.Size = new System.Drawing.Size(50, 20);
            this.lbl_ccv.TabIndex = 3;
            this.lbl_ccv.Text = "CCV:";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(32, 231);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(76, 20);
            this.lbl_amount.TabIndex = 4;
            this.lbl_amount.Text = "Amount:";
            // 
            // mtb_cardnumber
            // 
            this.mtb_cardnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cardnumber.Location = new System.Drawing.Point(36, 94);
            this.mtb_cardnumber.Mask = "0000 0000 0000 0000";
            this.mtb_cardnumber.Name = "mtb_cardnumber";
            this.mtb_cardnumber.PromptChar = '0';
            this.mtb_cardnumber.Size = new System.Drawing.Size(291, 26);
            this.mtb_cardnumber.TabIndex = 5;
            // 
            // mtb_expirationdate
            // 
            this.mtb_expirationdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_expirationdate.Location = new System.Drawing.Point(36, 171);
            this.mtb_expirationdate.Mask = "00/0000";
            this.mtb_expirationdate.Name = "mtb_expirationdate";
            this.mtb_expirationdate.PromptChar = '0';
            this.mtb_expirationdate.Size = new System.Drawing.Size(134, 26);
            this.mtb_expirationdate.TabIndex = 6;
            // 
            // mtb_ccv
            // 
            this.mtb_ccv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_ccv.Location = new System.Drawing.Point(244, 171);
            this.mtb_ccv.Mask = "000";
            this.mtb_ccv.Name = "mtb_ccv";
            this.mtb_ccv.PromptChar = '0';
            this.mtb_ccv.Size = new System.Drawing.Size(78, 26);
            this.mtb_ccv.TabIndex = 7;
            // 
            // nud_amount
            // 
            this.nud_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_amount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_amount.Location = new System.Drawing.Point(114, 225);
            this.nud_amount.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.nud_amount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_amount.Name = "nud_amount";
            this.nud_amount.Size = new System.Drawing.Size(120, 26);
            this.nud_amount.TabIndex = 8;
            this.nud_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_amount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_dollar
            // 
            this.lbl_dollar.AutoSize = true;
            this.lbl_dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dollar.Location = new System.Drawing.Point(240, 227);
            this.lbl_dollar.Name = "lbl_dollar";
            this.lbl_dollar.Size = new System.Drawing.Size(19, 20);
            this.lbl_dollar.TabIndex = 9;
            this.lbl_dollar.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "min - 5$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "max - 2,000,000$";
            // 
            // btn_deposit
            // 
            this.btn_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit.Location = new System.Drawing.Point(124, 299);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(123, 32);
            this.btn_deposit.TabIndex = 12;
            this.btn_deposit.Text = "DEPOSIT";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 359);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dollar);
            this.Controls.Add(this.nud_amount);
            this.Controls.Add(this.mtb_ccv);
            this.Controls.Add(this.mtb_expirationdate);
            this.Controls.Add(this.mtb_cardnumber);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_ccv);
            this.Controls.Add(this.lbl_expirationdate);
            this.Controls.Add(this.lbl_cardnumber);
            this.Controls.Add(this.lbl_header);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_cardnumber;
        private System.Windows.Forms.Label lbl_expirationdate;
        private System.Windows.Forms.Label lbl_ccv;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.MaskedTextBox mtb_cardnumber;
        private System.Windows.Forms.MaskedTextBox mtb_expirationdate;
        private System.Windows.Forms.MaskedTextBox mtb_ccv;
        private System.Windows.Forms.NumericUpDown nud_amount;
        private System.Windows.Forms.Label lbl_dollar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deposit;
    }
}