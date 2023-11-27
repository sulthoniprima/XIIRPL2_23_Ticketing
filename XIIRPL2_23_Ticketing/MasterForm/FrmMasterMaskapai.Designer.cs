namespace XIIRPL1_12_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            btnSimpan = new Button();
            btnBatal = new Button();
            rtxtDeskripsi = new RichTextBox();
            label8 = new Label();
            label5 = new Label();
            txtPerusahaan = new TextBox();
            label4 = new Label();
            txtNama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtvMaskapai = new DataGridView();
            nJumlahKru = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtvMaskapai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nJumlahKru).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.Location = new Point(825, 438);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(83, 30);
            btnSimpan.TabIndex = 33;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            btnBatal.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBatal.Location = new Point(732, 438);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(87, 30);
            btnBatal.TabIndex = 32;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // rtxtDeskripsi
            // 
            rtxtDeskripsi.Location = new Point(601, 329);
            rtxtDeskripsi.Name = "rtxtDeskripsi";
            rtxtDeskripsi.Size = new Size(307, 82);
            rtxtDeskripsi.TabIndex = 31;
            rtxtDeskripsi.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(517, 331);
            label8.Name = "label8";
            label8.Size = new Size(64, 17);
            label8.TabIndex = 30;
            label8.Text = "Deksripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 422);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 24;
            label5.Text = "Jumlah Kru";
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(151, 372);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(305, 23);
            txtPerusahaan.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 374);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 22;
            label4.Text = "Perusahaan";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(151, 327);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(305, 23);
            txtNama.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 329);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 20;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 58);
            label2.Name = "label2";
            label2.Size = new Size(265, 13);
            label2.TabIndex = 19;
            label2.Text = "Semua Maskapai yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 32);
            label1.Name = "label1";
            label1.Size = new Size(193, 26);
            label1.TabIndex = 18;
            label1.Text = "Master Maskapai";
            // 
            // dtvMaskapai
            // 
            dtvMaskapai.BackgroundColor = SystemColors.ButtonFace;
            dtvMaskapai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvMaskapai.GridColor = SystemColors.ButtonFace;
            dtvMaskapai.Location = new Point(37, 87);
            dtvMaskapai.Name = "dtvMaskapai";
            dtvMaskapai.RowTemplate.Height = 25;
            dtvMaskapai.Size = new Size(929, 190);
            dtvMaskapai.TabIndex = 17;
            // 
            // nJumlahKru
            // 
            nJumlahKru.Location = new Point(151, 421);
            nJumlahKru.Name = "nJumlahKru";
            nJumlahKru.Size = new Size(305, 23);
            nJumlahKru.TabIndex = 34;
            // 
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 515);
            Controls.Add(nJumlahKru);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(rtxtDeskripsi);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(txtPerusahaan);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtvMaskapai);
            Name = "FrmMasterMaskapai";
            Text = "FrmMasterMaskapai";
            ((System.ComponentModel.ISupportInitialize)dtvMaskapai).EndInit();
            ((System.ComponentModel.ISupportInitialize)nJumlahKru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button btnBatal;
        private RichTextBox rtxtDeskripsi;
        private Label label8;
        private Label label5;
        private TextBox txtPerusahaan;
        private Label label4;
        private TextBox txtNama;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtvMaskapai;
        private NumericUpDown nJumlahKru;
    }
}