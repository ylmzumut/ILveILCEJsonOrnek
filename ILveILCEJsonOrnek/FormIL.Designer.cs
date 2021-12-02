
namespace ILveILCEJsonOrnek
{
    partial class FormIL
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
            this.lblILAdi = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSec = new System.Windows.Forms.Button();
            this.comboBoxILSecimi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblILAdi
            // 
            this.lblILAdi.AutoSize = true;
            this.lblILAdi.Location = new System.Drawing.Point(29, 35);
            this.lblILAdi.Name = "lblILAdi";
            this.lblILAdi.Size = new System.Drawing.Size(52, 20);
            this.lblILAdi.TabIndex = 0;
            this.lblILAdi.Text = "İL ADI:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(591, 359);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(526, 31);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(94, 29);
            this.btnSec.TabIndex = 3;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = true;
            // 
            // comboBoxILSecimi
            // 
            this.comboBoxILSecimi.FormattingEnabled = true;
            this.comboBoxILSecimi.Location = new System.Drawing.Point(87, 32);
            this.comboBoxILSecimi.Name = "comboBoxILSecimi";
            this.comboBoxILSecimi.Size = new System.Drawing.Size(433, 28);
            this.comboBoxILSecimi.TabIndex = 4;
            // 
            // FormIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 462);
            this.Controls.Add(this.comboBoxILSecimi);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblILAdi);
            this.Name = "FormIL";
            this.Text = "FormIL";
            this.Load += new System.EventHandler(this.FormIL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblILAdi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ComboBox comboBoxILSecimi;
    }
}