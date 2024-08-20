namespace BaiTapThietKeForm
{
    partial class FrmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBai1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnyellow = new System.Windows.Forms.RadioButton();
            this.rbtnred = new System.Windows.Forms.RadioButton();
            this.rbtnwhite = new System.Windows.Forms.RadioButton();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 287);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnwhite);
            this.groupBox1.Controls.Add(this.rbtnred);
            this.groupBox1.Controls.Add(this.rbtnyellow);
            this.groupBox1.Location = new System.Drawing.Point(456, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu xe";
            // 
            // rbtnyellow
            // 
            this.rbtnyellow.AutoSize = true;
            this.rbtnyellow.Location = new System.Drawing.Point(11, 37);
            this.rbtnyellow.Name = "rbtnyellow";
            this.rbtnyellow.Size = new System.Drawing.Size(49, 17);
            this.rbtnyellow.TabIndex = 0;
            this.rbtnyellow.TabStop = true;
            this.rbtnyellow.Text = "vàng";
            this.rbtnyellow.UseVisualStyleBackColor = true;
            this.rbtnyellow.CheckedChanged += new System.EventHandler(this.rbtnyellow_CheckedChanged);
            // 
            // rbtnred
            // 
            this.rbtnred.AutoSize = true;
            this.rbtnred.Location = new System.Drawing.Point(11, 84);
            this.rbtnred.Name = "rbtnred";
            this.rbtnred.Size = new System.Drawing.Size(38, 17);
            this.rbtnred.TabIndex = 1;
            this.rbtnred.TabStop = true;
            this.rbtnred.Text = "đỏ";
            this.rbtnred.UseVisualStyleBackColor = true;
            this.rbtnred.CheckedChanged += new System.EventHandler(this.rbtnred_CheckedChanged);
            // 
            // rbtnwhite
            // 
            this.rbtnwhite.AutoSize = true;
            this.rbtnwhite.Location = new System.Drawing.Point(11, 135);
            this.rbtnwhite.Name = "rbtnwhite";
            this.rbtnwhite.Size = new System.Drawing.Size(49, 17);
            this.rbtnwhite.TabIndex = 2;
            this.rbtnwhite.TabStop = true;
            this.rbtnwhite.Text = "trắng";
            this.rbtnwhite.UseVisualStyleBackColor = true;
            this.rbtnwhite.CheckedChanged += new System.EventHandler(this.rbtnwhite_CheckedChanged);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(460, 256);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(46, 13);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn Giá";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(460, 286);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(53, 13);
            this.lbSL.TabIndex = 3;
            this.lbSL.Text = "Số Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "$";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(511, 253);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(144, 20);
            this.txtdongia.TabIndex = 5;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(511, 283);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(142, 20);
            this.txtsoluong.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng số tiền thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(728, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tính tiền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmBai1";
            this.Text = "Mua Bán xe";
            this.Load += new System.EventHandler(this.FrmBai1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnwhite;
        private System.Windows.Forms.RadioButton rbtnred;
        private System.Windows.Forms.RadioButton rbtnyellow;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}