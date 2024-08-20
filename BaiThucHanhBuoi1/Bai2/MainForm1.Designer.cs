namespace Bai2
{
    partial class MainForm1
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
            this.grbGT = new System.Windows.Forms.GroupBox();
            this.rbntNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.grbmau = new System.Windows.Forms.GroupBox();
            this.rbtnGreen = new System.Windows.Forms.RadioButton();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.bntColor = new System.Windows.Forms.Button();
            this.txtHopMAu = new System.Windows.Forms.TextBox();
            this.grbGT.SuspendLayout();
            this.grbmau.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGT
            // 
            this.grbGT.Controls.Add(this.rbntNu);
            this.grbGT.Controls.Add(this.rbtnNam);
            this.grbGT.Location = new System.Drawing.Point(55, 126);
            this.grbGT.Name = "grbGT";
            this.grbGT.Size = new System.Drawing.Size(200, 100);
            this.grbGT.TabIndex = 0;
            this.grbGT.TabStop = false;
            this.grbGT.Text = "Chọn Giới Tính";
            // 
            // rbntNu
            // 
            this.rbntNu.AutoSize = true;
            this.rbntNu.Location = new System.Drawing.Point(7, 44);
            this.rbntNu.Name = "rbntNu";
            this.rbntNu.Size = new System.Drawing.Size(39, 17);
            this.rbntNu.TabIndex = 1;
            this.rbntNu.Text = "Nữ";
            this.rbntNu.UseVisualStyleBackColor = true;
            this.rbntNu.CheckedChanged += new System.EventHandler(this.rbntNu_CheckedChanged);
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Checked = true;
            this.rbtnNam.Location = new System.Drawing.Point(7, 20);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(47, 17);
            this.rbtnNam.TabIndex = 0;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            this.rbtnNam.CheckedChanged += new System.EventHandler(this.rbtnNam_CheckedChanged);
            // 
            // grbmau
            // 
            this.grbmau.Controls.Add(this.bntColor);
            this.grbmau.Controls.Add(this.rbtnGreen);
            this.grbmau.Controls.Add(this.rbtnRed);
            this.grbmau.Location = new System.Drawing.Point(55, 279);
            this.grbmau.Name = "grbmau";
            this.grbmau.Size = new System.Drawing.Size(200, 100);
            this.grbmau.TabIndex = 2;
            this.grbmau.TabStop = false;
            this.grbmau.Text = "chọn màu";
            // 
            // rbtnGreen
            // 
            this.rbtnGreen.AutoSize = true;
            this.rbtnGreen.Location = new System.Drawing.Point(7, 44);
            this.rbtnGreen.Name = "rbtnGreen";
            this.rbtnGreen.Size = new System.Drawing.Size(72, 17);
            this.rbtnGreen.TabIndex = 1;
            this.rbtnGreen.Text = "Màu xanh";
            this.rbtnGreen.UseVisualStyleBackColor = true;
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.Checked = true;
            this.rbtnRed.Location = new System.Drawing.Point(7, 20);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(62, 17);
            this.rbtnRed.TabIndex = 0;
            this.rbtnRed.TabStop = true;
            this.rbtnRed.Text = "Màu đỏ";
            this.rbtnRed.UseVisualStyleBackColor = true;
            // 
            // bntColor
            // 
            this.bntColor.Location = new System.Drawing.Point(99, 38);
            this.bntColor.Name = "bntColor";
            this.bntColor.Size = new System.Drawing.Size(75, 23);
            this.bntColor.TabIndex = 2;
            this.bntColor.Text = "Tô màu";
            this.bntColor.UseVisualStyleBackColor = true;
            this.bntColor.Click += new System.EventHandler(this.bntColor_Click);
            // 
            // txtHopMAu
            // 
            this.txtHopMAu.BackColor = System.Drawing.SystemColors.Window;
            this.txtHopMAu.Location = new System.Drawing.Point(318, 255);
            this.txtHopMAu.Multiline = true;
            this.txtHopMAu.Name = "txtHopMAu";
            this.txtHopMAu.Size = new System.Drawing.Size(218, 145);
            this.txtHopMAu.TabIndex = 3;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHopMAu);
            this.Controls.Add(this.grbmau);
            this.Controls.Add(this.grbGT);
            this.Name = "MainForm1";
            this.Text = "Bài Tập 2";
            this.grbGT.ResumeLayout(false);
            this.grbGT.PerformLayout();
            this.grbmau.ResumeLayout(false);
            this.grbmau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGT;
        private System.Windows.Forms.RadioButton rbntNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.GroupBox grbmau;
        private System.Windows.Forms.RadioButton rbtnGreen;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.Button bntColor;
        private System.Windows.Forms.TextBox txtHopMAu;
    }
}

