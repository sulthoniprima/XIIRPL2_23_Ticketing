namespace XIIRPL2_23_Ticketing.MasterForm
{
    partial class bandara
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
            txtAlamat = new RichTextBox();
            label8 = new Label();
            label5 = new Label();
            txtKodeIATA = new TextBox();
            label4 = new Label();
            txtNama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtKota = new TextBox();
            label6 = new Label();
            txtNegara = new ComboBox();
            txtJmlTerminal = new NumericUpDown();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimpan.Location = new Point(828, 484);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(83, 30);
            btnSimpan.TabIndex = 46;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBatal.Location = new Point(595, 484);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(87, 30);
            btnBatal.TabIndex = 45;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(595, 396);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(307, 82);
            txtAlamat.TabIndex = 44;
            txtAlamat.Text = "";
            txtAlamat.TextChanged += rtxtDeskripsi_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(516, 396);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 43;
            label8.Text = "alamat";
            label8.Click += label8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 428);
            label5.Name = "label5";
            label5.Size = new Size(33, 17);
            label5.TabIndex = 42;
            label5.Text = "kota";
            label5.Click += label5_Click;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(145, 373);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(305, 23);
            txtKodeIATA.TabIndex = 41;
            txtKodeIATA.TextChanged += txtPerusahaan_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 375);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 40;
            label4.Text = "kode IATA";
            label4.Click += label4_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(145, 328);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(305, 23);
            txtNama.TabIndex = 39;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 330);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 38;
            label3.Text = "Nama";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 59);
            label2.Name = "label2";
            label2.Size = new Size(260, 13);
            label2.TabIndex = 37;
            label2.Text = "semua bandara yang terdaftar akan muncul di sini";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 33);
            label1.Name = "label1";
            label1.Size = new Size(178, 26);
            label1.TabIndex = 36;
            label1.Text = "Master bandara";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(843, 203);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(145, 426);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(305, 23);
            txtKota.TabIndex = 49;
            txtKota.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(43, 484);
            label6.Name = "label6";
            label6.Size = new Size(48, 17);
            label6.TabIndex = 50;
            label6.Text = "negara";
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(145, 482);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(305, 23);
            txtNegara.TabIndex = 51;
            txtNegara.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // txtJmlTerminal
            // 
            txtJmlTerminal.Location = new Point(597, 330);
            txtJmlTerminal.Name = "txtJmlTerminal";
            txtJmlTerminal.Size = new Size(305, 23);
            txtJmlTerminal.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(463, 330);
            label7.Name = "label7";
            label7.Size = new Size(101, 17);
            label7.TabIndex = 53;
            label7.Text = "jumlah terminal";
            // 
            // bandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 528);
            Controls.Add(label7);
            Controls.Add(txtJmlTerminal);
            Controls.Add(txtNegara);
            Controls.Add(label6);
            Controls.Add(txtKota);
            Controls.Add(dataGridView1);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(txtKodeIATA);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "bandara";
            Text = "bandara";
            Load += bandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSimpan;
        private Button btnBatal;
        private RichTextBox txtAlamat;
        private Label label8;
        private Label label5;
        private TextBox txtKodeIATA;
        private Label label4;
        private TextBox txtNama;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtKota;
        private Label label6;
        private ComboBox txtNegara;
        private NumericUpDown txtJmlTerminal;
        private Label label7;
    }
}