﻿namespace Blackjack
{
    partial class Usercreation
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.left_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.btn_deposit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER NAME:";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.Window;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_name.Location = new System.Drawing.Point(241, 67);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(205, 26);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_name_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENTER BALANCE:";
            // 
            // start_btn
            // 
            this.start_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.start_btn.Location = new System.Drawing.Point(299, 227);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(96, 49);
            this.start_btn.TabIndex = 4;
            this.start_btn.Text = "START PLAYING";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // right_btn
            // 
            this.right_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.right_btn.Location = new System.Drawing.Point(141, 176);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(47, 33);
            this.right_btn.TabIndex = 6;
            this.right_btn.Text = ">>";
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // left_btn
            // 
            this.left_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.left_btn.Location = new System.Drawing.Point(60, 176);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(47, 33);
            this.left_btn.TabIndex = 7;
            this.left_btn.Text = "<<";
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Blackjack.Properties.Resources.PLAYER1;
            this.pictureBox1.InitialImage = global::Blackjack.Properties.Resources.PLAYER1;
            this.pictureBox1.Location = new System.Drawing.Point(60, 42);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(128, 128);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(128, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // tb_amount
            // 
            this.tb_amount.BackColor = System.Drawing.SystemColors.Window;
            this.tb_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_amount.Enabled = false;
            this.tb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_amount.ForeColor = System.Drawing.Color.ForestGreen;
            this.tb_amount.Location = new System.Drawing.Point(241, 163);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(104, 26);
            this.tb_amount.TabIndex = 9;
            this.tb_amount.Text = "0$";
            this.tb_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_deposit
            // 
            this.btn_deposit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_deposit.Location = new System.Drawing.Point(361, 158);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(85, 37);
            this.btn_deposit.TabIndex = 10;
            this.btn_deposit.Text = "DEPOSIT MONEY";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // Usercreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(486, 288);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.left_btn);
            this.Controls.Add(this.right_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Name = "Usercreation";
            this.Text = "Usercreation";
            this.Load += new System.EventHandler(this.Usercreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.TextBox tb_amount;
    }
}