
namespace RomFitness
{
    partial class Terms
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblMenubody = new System.Windows.Forms.Label();
            this.lblWPbody = new System.Windows.Forms.Label();
            this.btnsaveMenuTerms = new System.Windows.Forms.Button();
            this.btnSaveTermswp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Terms && Highlights";
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(1142, 39);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(85, 30);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(19, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(545, 424);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(728, 91);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(544, 424);
            this.listBox2.TabIndex = 3;
            // 
            // lblMenubody
            // 
            this.lblMenubody.AutoSize = true;
            this.lblMenubody.Location = new System.Drawing.Point(43, 147);
            this.lblMenubody.Name = "lblMenubody";
            this.lblMenubody.Size = new System.Drawing.Size(98, 20);
            this.lblMenubody.TabIndex = 4;
            this.lblMenubody.Text = "lblMenubody";
            // 
            // lblWPbody
            // 
            this.lblWPbody.AutoSize = true;
            this.lblWPbody.Location = new System.Drawing.Point(798, 147);
            this.lblWPbody.Name = "lblWPbody";
            this.lblWPbody.Size = new System.Drawing.Size(51, 20);
            this.lblWPbody.TabIndex = 5;
            this.lblWPbody.Text = "label2";
            // 
            // btnsaveMenuTerms
            // 
            this.btnsaveMenuTerms.Location = new System.Drawing.Point(148, 532);
            this.btnsaveMenuTerms.Name = "btnsaveMenuTerms";
            this.btnsaveMenuTerms.Size = new System.Drawing.Size(218, 45);
            this.btnsaveMenuTerms.TabIndex = 6;
            this.btnsaveMenuTerms.Text = "Save Terms";
            this.btnsaveMenuTerms.UseVisualStyleBackColor = true;
            this.btnsaveMenuTerms.Click += new System.EventHandler(this.btnsaveMenuTerms_Click);
            // 
            // btnSaveTermswp
            // 
            this.btnSaveTermswp.Location = new System.Drawing.Point(915, 521);
            this.btnSaveTermswp.Name = "btnSaveTermswp";
            this.btnSaveTermswp.Size = new System.Drawing.Size(218, 45);
            this.btnSaveTermswp.TabIndex = 7;
            this.btnSaveTermswp.Text = "Save Terms";
            this.btnSaveTermswp.UseVisualStyleBackColor = true;
            this.btnSaveTermswp.Click += new System.EventHandler(this.btnSaveTermswp_Click);
            // 
            // Terms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 667);
            this.Controls.Add(this.btnSaveTermswp);
            this.Controls.Add(this.btnsaveMenuTerms);
            this.Controls.Add(this.lblWPbody);
            this.Controls.Add(this.lblMenubody);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.lblTitle);
            this.Name = "Terms";
            this.Text = "Terms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblMenubody;
        private System.Windows.Forms.Label lblWPbody;
        private System.Windows.Forms.Button btnsaveMenuTerms;
        private System.Windows.Forms.Button btnSaveTermswp;
    }
}