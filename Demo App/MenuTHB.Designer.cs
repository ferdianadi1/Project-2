﻿namespace Demo_App
{
    partial class MenuTHB
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
            this.btn_refund = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_refund
            // 
            this.btn_refund.Location = new System.Drawing.Point(460, 30);
            this.btn_refund.Name = "btn_refund";
            this.btn_refund.Size = new System.Drawing.Size(75, 23);
            this.btn_refund.TabIndex = 0;
            this.btn_refund.Text = "refund";
            this.btn_refund.UseVisualStyleBackColor = true;
            this.btn_refund.Click += new System.EventHandler(this.btn_refund_Click);
            // 
            // MenuTHB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 331);
            this.Controls.Add(this.btn_refund);
            this.Name = "MenuTHB";
            this.Text = "MenuTHB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_refund;
    }
}