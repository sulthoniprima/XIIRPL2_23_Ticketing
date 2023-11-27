namespace XIIRPL1_12_Ticketing.TransactionForm
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            pictureBox7 = new PictureBox();
            txtBerangkatDari = new TextBox();
            txtTujuan = new TextBox();
            dtTanggalBerangkat = new DateTimePicker();
            nJumlahPenumpang = new NumericUpDown();
            pictureBox8 = new PictureBox();
            btnCariPenerbangan = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nJumlahPenumpang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 92);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(693, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(739, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 114);
            label1.Name = "label1";
            label1.Size = new Size(62, 26);
            label1.TabIndex = 1;
            label1.Text = "Halo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 140);
            label2.Name = "label2";
            label2.Size = new Size(243, 15);
            label2.TabIndex = 2;
            label2.Text = "Mau terbang kemana Hari ini [Nama Akun] ?";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(35, 200);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 197);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 4;
            label3.Text = "Berangkat Dari";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 270);
            label4.Name = "label4";
            label4.Size = new Size(109, 16);
            label4.TabIndex = 6;
            label4.Text = "Tanggal Berangkat";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(35, 273);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(21, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(417, 198);
            label5.Name = "label5";
            label5.Size = new Size(44, 16);
            label5.TabIndex = 8;
            label5.Text = "Tujuan";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(383, 200);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(21, 21);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(417, 270);
            label6.Name = "label6";
            label6.Size = new Size(114, 16);
            label6.TabIndex = 10;
            label6.Text = "Jumlah Penumpang";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(383, 273);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(21, 21);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // txtBerangkatDari
            // 
            txtBerangkatDari.Location = new Point(65, 219);
            txtBerangkatDari.Name = "txtBerangkatDari";
            txtBerangkatDari.Size = new Size(221, 23);
            txtBerangkatDari.TabIndex = 11;
            // 
            // txtTujuan
            // 
            txtTujuan.Location = new Point(414, 219);
            txtTujuan.Name = "txtTujuan";
            txtTujuan.Size = new Size(221, 23);
            txtTujuan.TabIndex = 12;
            // 
            // dtTanggalBerangkat
            // 
            dtTanggalBerangkat.Location = new Point(65, 292);
            dtTanggalBerangkat.Name = "dtTanggalBerangkat";
            dtTanggalBerangkat.Size = new Size(221, 23);
            dtTanggalBerangkat.TabIndex = 13;
            // 
            // nJumlahPenumpang
            // 
            nJumlahPenumpang.Location = new Point(414, 292);
            nJumlahPenumpang.Name = "nJumlahPenumpang";
            nJumlahPenumpang.Size = new Size(216, 23);
            nJumlahPenumpang.TabIndex = 14;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(592, 334);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(290, 126);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // btnCariPenerbangan
            // 
            btnCariPenerbangan.Location = new Point(65, 348);
            btnCariPenerbangan.Name = "btnCariPenerbangan";
            btnCariPenerbangan.Size = new Size(137, 36);
            btnCariPenerbangan.TabIndex = 16;
            btnCariPenerbangan.Text = "Cari Penerbangan";
            btnCariPenerbangan.UseVisualStyleBackColor = true;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 530);
            Controls.Add(btnCariPenerbangan);
            Controls.Add(pictureBox8);
            Controls.Add(nJumlahPenumpang);
            Controls.Add(dtTanggalBerangkat);
            Controls.Add(txtTujuan);
            Controls.Add(txtBerangkatDari);
            Controls.Add(label6);
            Controls.Add(pictureBox7);
            Controls.Add(label5);
            Controls.Add(pictureBox6);
            Controls.Add(label4);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmCustomer";
            Text = "FrmCustomer";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)nJumlahPenumpang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label5;
        private PictureBox pictureBox6;
        private Label label6;
        private PictureBox pictureBox7;
        private TextBox txtBerangkatDari;
        private TextBox txtTujuan;
        private DateTimePicker dtTanggalBerangkat;
        private NumericUpDown nJumlahPenumpang;
        private PictureBox pictureBox8;
        private Button btnCariPenerbangan;
    }
}