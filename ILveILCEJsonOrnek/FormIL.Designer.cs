
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
            this.components = new System.ComponentModel.Container();
            this.lblILAdi = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.btnSec = new System.Windows.Forms.Button();
            this.comboBoxILSecimi = new System.Windows.Forms.ComboBox();
            this.groupBoxIL = new System.Windows.Forms.GroupBox();
            this.lblIL = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxIL = new System.Windows.Forms.RichTextBox();
            this.groupBoxIL.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(628, 359);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefon";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fax";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-posta";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Web Sitesi";
            this.columnHeader5.Width = 160;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(526, 31);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(94, 29);
            this.btnSec.TabIndex = 3;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // comboBoxILSecimi
            // 
            this.comboBoxILSecimi.FormattingEnabled = true;
            this.comboBoxILSecimi.Location = new System.Drawing.Point(87, 32);
            this.comboBoxILSecimi.Name = "comboBoxILSecimi";
            this.comboBoxILSecimi.Size = new System.Drawing.Size(433, 28);
            this.comboBoxILSecimi.TabIndex = 4;
            // 
            // groupBoxIL
            // 
            this.groupBoxIL.Controls.Add(this.richTextBoxIL);
            this.groupBoxIL.Controls.Add(this.lblIL);
            this.groupBoxIL.Location = new System.Drawing.Point(673, 35);
            this.groupBoxIL.Name = "groupBoxIL";
            this.groupBoxIL.Size = new System.Drawing.Size(347, 403);
            this.groupBoxIL.TabIndex = 5;
            this.groupBoxIL.TabStop = false;
            this.groupBoxIL.Text = "groupBox1";
            // 
            // lblIL
            // 
            this.lblIL.AutoSize = true;
            this.lblIL.Location = new System.Drawing.Point(16, 33);
            this.lblIL.Name = "lblIL";
            this.lblIL.Size = new System.Drawing.Size(134, 20);
            this.lblIL.TabIndex = 0;
            this.lblIL.Text = "İl Hakkında Bilgiler";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayGosterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 28);
            // 
            // detayGosterToolStripMenuItem
            // 
            this.detayGosterToolStripMenuItem.Name = "detayGosterToolStripMenuItem";
            this.detayGosterToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.detayGosterToolStripMenuItem.Text = "Detay Göster";
            this.detayGosterToolStripMenuItem.Click += new System.EventHandler(this.detayGosterToolStripMenuItem_Click);
            // 
            // richTextBoxIL
            // 
            this.richTextBoxIL.Location = new System.Drawing.Point(16, 68);
            this.richTextBoxIL.Name = "richTextBoxIL";
            this.richTextBoxIL.ReadOnly = true;
            this.richTextBoxIL.Size = new System.Drawing.Size(316, 329);
            this.richTextBoxIL.TabIndex = 3;
            this.richTextBoxIL.Text = "";
            // 
            // FormIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 462);
            this.Controls.Add(this.groupBoxIL);
            this.Controls.Add(this.comboBoxILSecimi);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblILAdi);
            this.Name = "FormIL";
            this.Text = "FormIL";
            this.Load += new System.EventHandler(this.FormIL_Load);
            this.groupBoxIL.ResumeLayout(false);
            this.groupBoxIL.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblILAdi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ComboBox comboBoxILSecimi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBoxIL;
        private System.Windows.Forms.Label lblIL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayGosterToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxIL;
    }
}