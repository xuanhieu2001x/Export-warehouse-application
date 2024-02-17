namespace DSPhieuxuatkho
{
    partial class frmXuatKho
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
            this.tabPhieuXuatKho = new System.Windows.Forms.TabControl();
            this.tabPhieuXuat = new System.Windows.Forms.TabPage();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNVLH = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.bntThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDSNV = new System.Windows.Forms.TabPage();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDXK = new System.Windows.Forms.TextBox();
            this.tabPhieuXuatKho.SuspendLayout();
            this.tabPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPhieuXuatKho
            // 
            this.tabPhieuXuatKho.Controls.Add(this.tabPhieuXuat);
            this.tabPhieuXuatKho.Controls.Add(this.tabDSNV);
            this.tabPhieuXuatKho.Location = new System.Drawing.Point(3, 4);
            this.tabPhieuXuatKho.Name = "tabPhieuXuatKho";
            this.tabPhieuXuatKho.SelectedIndex = 0;
            this.tabPhieuXuatKho.Size = new System.Drawing.Size(793, 447);
            this.tabPhieuXuatKho.TabIndex = 0;
            // 
            // tabPhieuXuat
            // 
            this.tabPhieuXuat.Controls.Add(this.txtIDXK);
            this.tabPhieuXuat.Controls.Add(this.label7);
            this.tabPhieuXuat.Controls.Add(this.txtTime);
            this.tabPhieuXuat.Controls.Add(this.label4);
            this.tabPhieuXuat.Controls.Add(this.cbNVLH);
            this.tabPhieuXuat.Controls.Add(this.btnXoa);
            this.tabPhieuXuat.Controls.Add(this.btnSua);
            this.tabPhieuXuat.Controls.Add(this.txtMaPhieu);
            this.tabPhieuXuat.Controls.Add(this.bntThem);
            this.tabPhieuXuat.Controls.Add(this.label3);
            this.tabPhieuXuat.Controls.Add(this.dataGridView1);
            this.tabPhieuXuat.Controls.Add(this.label2);
            this.tabPhieuXuat.Controls.Add(this.label1);
            this.tabPhieuXuat.Location = new System.Drawing.Point(4, 22);
            this.tabPhieuXuat.Name = "tabPhieuXuat";
            this.tabPhieuXuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuXuat.Size = new System.Drawing.Size(785, 421);
            this.tabPhieuXuat.TabIndex = 0;
            this.tabPhieuXuat.Text = "Phiếu Xuất kho";
            this.tabPhieuXuat.UseVisualStyleBackColor = true;
            this.tabPhieuXuat.Click += new System.EventHandler(this.tabPhieuXuat_Click);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(567, 69);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(166, 22);
            this.txtTime.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Thời gian";
            // 
            // cbNVLH
            // 
            this.cbNVLH.FormattingEnabled = true;
            this.cbNVLH.Location = new System.Drawing.Point(162, 109);
            this.cbNVLH.Name = "cbNVLH";
            this.cbNVLH.Size = new System.Drawing.Size(179, 21);
            this.cbNVLH.TabIndex = 21;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(439, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 38);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(306, 155);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 38);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(162, 69);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(179, 22);
            this.txtMaPhieu.TabIndex = 18;
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(162, 155);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(120, 38);
            this.bntThem.TabIndex = 17;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "NV lấy hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(795, 203);
            this.dataGridView1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh sách phiếu xuất kho";
            // 
            // tabDSNV
            // 
            this.tabDSNV.Controls.Add(this.btnThem1);
            this.tabDSNV.Controls.Add(this.txtNhanVien);
            this.tabDSNV.Controls.Add(this.label6);
            this.tabDSNV.Controls.Add(this.dataGridView2);
            this.tabDSNV.Controls.Add(this.label5);
            this.tabDSNV.Location = new System.Drawing.Point(4, 22);
            this.tabDSNV.Name = "tabDSNV";
            this.tabDSNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSNV.Size = new System.Drawing.Size(785, 421);
            this.tabDSNV.TabIndex = 1;
            this.tabDSNV.Text = "Nhân viên";
            this.tabDSNV.UseVisualStyleBackColor = true;
            // 
            // btnThem1
            // 
            this.btnThem1.Location = new System.Drawing.Point(503, 90);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(120, 38);
            this.btnThem1.TabIndex = 21;
            this.btnThem1.Text = "Thêm";
            this.btnThem1.UseVisualStyleBackColor = true;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(312, 98);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(166, 22);
            this.txtNhanVien.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tên Nhân viên";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 167);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(770, 244);
            this.dataGridView2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Danh sách nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mã phiếu xuất";
            // 
            // txtIDXK
            // 
            this.txtIDXK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDXK.Location = new System.Drawing.Point(567, 111);
            this.txtIDXK.Name = "txtIDXK";
            this.txtIDXK.ReadOnly = true;
            this.txtIDXK.Size = new System.Drawing.Size(166, 22);
            this.txtIDXK.TabIndex = 25;
            // 
            // frmXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPhieuXuatKho);
            this.Name = "frmXuatKho";
            this.Text = "Xuất kho";
            this.Load += new System.EventHandler(this.frmXuatKho_Load);
            this.tabPhieuXuatKho.ResumeLayout(false);
            this.tabPhieuXuat.ResumeLayout(false);
            this.tabPhieuXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabDSNV.ResumeLayout(false);
            this.tabDSNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPhieuXuatKho;
        private System.Windows.Forms.TabPage tabPhieuXuat;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNVLH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDSNV;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDXK;
        private System.Windows.Forms.Label label7;
    }
}

