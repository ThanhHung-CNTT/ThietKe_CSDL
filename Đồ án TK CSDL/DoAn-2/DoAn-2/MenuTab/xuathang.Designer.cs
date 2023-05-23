namespace DoAn_2.MenuTab
{
    partial class xuathang
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
            this.txtman = new System.Windows.Forms.TextBox();
            this.txttenn = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtiensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvsanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgiasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtsoluongsp = new System.Windows.Forms.TextBox();
            this.txtdongiasp = new System.Windows.Forms.TextBox();
            this.txtgiamphantramsp = new System.Windows.Forms.TextBox();
            this.txttiensp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxdonvisp = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnhuyHD = new FontAwesome.Sharp.IconButton();
            this.btnthanhtoan = new FontAwesome.Sharp.IconButton();
            this.btnsua = new FontAwesome.Sharp.IconButton();
            this.btnthem = new FontAwesome.Sharp.IconButton();
            this.btnxoa = new FontAwesome.Sharp.IconButton();
            this.btnhuy = new FontAwesome.Sharp.IconButton();
            this.comboBoxloaisp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtthanhtoan = new System.Windows.Forms.TextBox();
            this.txtcongphantramtong = new System.Windows.Forms.TextBox();
            this.txtcongtientong = new System.Windows.Forms.TextBox();
            this.txtgiamphantramtong = new System.Windows.Forms.TextBox();
            this.txtgiamtientong = new System.Windows.Forms.TextBox();
            this.txttongcongtiensp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtman
            // 
            this.txtman.Location = new System.Drawing.Point(120, 30);
            this.txtman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtman.Name = "txtman";
            this.txtman.Size = new System.Drawing.Size(187, 22);
            this.txtman.TabIndex = 0;
            this.txtman.TextChanged += new System.EventHandler(this.txtmakh_TextChanged);
            // 
            // txttenn
            // 
            this.txttenn.Location = new System.Drawing.Point(316, 30);
            this.txttenn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttenn.Name = "txttenn";
            this.txttenn.Size = new System.Drawing.Size(267, 22);
            this.txttenn.TabIndex = 1;
            this.txttenn.TextChanged += new System.EventHandler(this.txttenn_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluongsp,
            this.dongiasp,
            this.thanhtiensp,
            this.dvsanpham,
            this.loaisp,
            this.giamgiasp});
            this.dataGridView1.Location = new System.Drawing.Point(16, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(692, 334);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã hàng";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            this.masp.Width = 125;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên hàng";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            this.tensp.Width = 125;
            // 
            // soluongsp
            // 
            this.soluongsp.HeaderText = "SL";
            this.soluongsp.MinimumWidth = 6;
            this.soluongsp.Name = "soluongsp";
            this.soluongsp.ReadOnly = true;
            this.soluongsp.Width = 125;
            // 
            // dongiasp
            // 
            this.dongiasp.HeaderText = "Đơn giá";
            this.dongiasp.MinimumWidth = 6;
            this.dongiasp.Name = "dongiasp";
            this.dongiasp.ReadOnly = true;
            this.dongiasp.Width = 125;
            // 
            // thanhtiensp
            // 
            this.thanhtiensp.HeaderText = "Thành tiền";
            this.thanhtiensp.MinimumWidth = 6;
            this.thanhtiensp.Name = "thanhtiensp";
            this.thanhtiensp.ReadOnly = true;
            this.thanhtiensp.Width = 125;
            // 
            // dvsanpham
            // 
            this.dvsanpham.HeaderText = "Đơn vị";
            this.dvsanpham.MinimumWidth = 6;
            this.dvsanpham.Name = "dvsanpham";
            this.dvsanpham.ReadOnly = true;
            this.dvsanpham.Width = 125;
            // 
            // loaisp
            // 
            this.loaisp.HeaderText = "Loại";
            this.loaisp.MinimumWidth = 6;
            this.loaisp.Name = "loaisp";
            this.loaisp.ReadOnly = true;
            this.loaisp.Width = 125;
            // 
            // giamgiasp
            // 
            this.giamgiasp.HeaderText = "Giảm giá";
            this.giamgiasp.MinimumWidth = 6;
            this.giamgiasp.Name = "giamgiasp";
            this.giamgiasp.ReadOnly = true;
            this.giamgiasp.Width = 125;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(851, 84);
            this.txtmasp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(311, 22);
            this.txtmasp.TabIndex = 10;
            this.txtmasp.TextChanged += new System.EventHandler(this.txtmasp_TextChanged);
            this.txtmasp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmasp_KeyDown);
            // 
            // txtsohd
            // 
            this.txtsohd.Location = new System.Drawing.Point(840, 28);
            this.txtsohd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.ReadOnly = true;
            this.txtsohd.Size = new System.Drawing.Size(328, 22);
            this.txtsohd.TabIndex = 11;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(728, 117);
            this.txttensp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(433, 22);
            this.txttensp.TabIndex = 12;
            this.txttensp.TextChanged += new System.EventHandler(this.txttensp_TextChanged_1);
            this.txttensp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttensp_KeyDown);
            // 
            // txtsoluongsp
            // 
            this.txtsoluongsp.Location = new System.Drawing.Point(840, 162);
            this.txtsoluongsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsoluongsp.Name = "txtsoluongsp";
            this.txtsoluongsp.Size = new System.Drawing.Size(100, 22);
            this.txtsoluongsp.TabIndex = 13;
            this.txtsoluongsp.TextChanged += new System.EventHandler(this.txtsoluongsp_TextChanged);
            this.txtsoluongsp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluongsp_KeyPress);
            // 
            // txtdongiasp
            // 
            this.txtdongiasp.Location = new System.Drawing.Point(840, 194);
            this.txtdongiasp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdongiasp.Name = "txtdongiasp";
            this.txtdongiasp.ReadOnly = true;
            this.txtdongiasp.Size = new System.Drawing.Size(187, 22);
            this.txtdongiasp.TabIndex = 14;
            this.txtdongiasp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongiasp_KeyPress);
            // 
            // txtgiamphantramsp
            // 
            this.txtgiamphantramsp.Location = new System.Drawing.Point(840, 226);
            this.txtgiamphantramsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgiamphantramsp.Name = "txtgiamphantramsp";
            this.txtgiamphantramsp.Size = new System.Drawing.Size(187, 22);
            this.txtgiamphantramsp.TabIndex = 15;
            // 
            // txttiensp
            // 
            this.txttiensp.Location = new System.Drawing.Point(840, 258);
            this.txttiensp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttiensp.Name = "txttiensp";
            this.txttiensp.ReadOnly = true;
            this.txttiensp.Size = new System.Drawing.Size(187, 22);
            this.txttiensp.TabIndex = 16;
            this.txttiensp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttiensp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "SĐT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(724, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Mã sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(724, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(723, 199);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Đơn giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(724, 231);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "% giảm giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(721, 263);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Giá Trị ĐH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(720, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 40;
            this.label14.Text = "Số hóa đơn";
            // 
            // comboBoxdonvisp
            // 
            this.comboBoxdonvisp.FormattingEnabled = true;
            this.comboBoxdonvisp.Location = new System.Drawing.Point(949, 161);
            this.comboBoxdonvisp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxdonvisp.Name = "comboBoxdonvisp";
            this.comboBoxdonvisp.Size = new System.Drawing.Size(77, 24);
            this.comboBoxdonvisp.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1036, 263);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 43;
            this.label15.Text = "VNĐ";
            // 
            // btnhuyHD
            // 
            this.btnhuyHD.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnhuyHD.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnhuyHD.IconColor = System.Drawing.Color.Black;
            this.btnhuyHD.IconSize = 16;
            this.btnhuyHD.Location = new System.Drawing.Point(1060, 544);
            this.btnhuyHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhuyHD.Name = "btnhuyHD";
            this.btnhuyHD.Rotation = 0D;
            this.btnhuyHD.Size = new System.Drawing.Size(103, 43);
            this.btnhuyHD.TabIndex = 25;
            this.btnhuyHD.Text = "Hủy HĐ";
            this.btnhuyHD.UseVisualStyleBackColor = true;
            this.btnhuyHD.Click += new System.EventHandler(this.btnhuyHD_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnthanhtoan.IconColor = System.Drawing.Color.Black;
            this.btnthanhtoan.IconSize = 16;
            this.btnthanhtoan.Location = new System.Drawing.Point(728, 389);
            this.btnthanhtoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Rotation = 0D;
            this.btnthanhtoan.Size = new System.Drawing.Size(435, 95);
            this.btnthanhtoan.TabIndex = 24;
            this.btnthanhtoan.Text = "Xuất Hàng";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnsua
            // 
            this.btnsua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnsua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnsua.IconColor = System.Drawing.Color.Black;
            this.btnsua.IconSize = 16;
            this.btnsua.Location = new System.Drawing.Point(839, 302);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Rotation = 0D;
            this.btnsua.Size = new System.Drawing.Size(103, 68);
            this.btnsua.TabIndex = 23;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnthem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnthem.IconColor = System.Drawing.Color.Black;
            this.btnthem.IconSize = 20;
            this.btnthem.Location = new System.Drawing.Point(728, 302);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Rotation = 0D;
            this.btnthem.Size = new System.Drawing.Size(103, 68);
            this.btnthem.TabIndex = 22;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnxoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnxoa.IconColor = System.Drawing.Color.Black;
            this.btnxoa.IconSize = 16;
            this.btnxoa.Location = new System.Drawing.Point(949, 302);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Rotation = 0D;
            this.btnxoa.Size = new System.Drawing.Size(103, 68);
            this.btnxoa.TabIndex = 21;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnhuy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnhuy.IconColor = System.Drawing.Color.Black;
            this.btnhuy.IconSize = 16;
            this.btnhuy.Location = new System.Drawing.Point(1060, 302);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Rotation = 0D;
            this.btnhuy.Size = new System.Drawing.Size(103, 68);
            this.btnhuy.TabIndex = 20;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // comboBoxloaisp
            // 
            this.comboBoxloaisp.FormattingEnabled = true;
            this.comboBoxloaisp.Location = new System.Drawing.Point(1040, 161);
            this.comboBoxloaisp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxloaisp.Name = "comboBoxloaisp";
            this.comboBoxloaisp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxloaisp.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(480, 572);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = "VNĐ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(681, 474);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 18);
            this.label18.TabIndex = 64;
            this.label18.Text = "VNĐ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(355, 476);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 18);
            this.label17.TabIndex = 63;
            this.label17.Text = "VNĐ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(355, 444);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 18);
            this.label16.TabIndex = 62;
            this.label16.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 508);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "+ %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 476);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "+ Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 570);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "Giá trị sau khấu hao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 511);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "- %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "- Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tổng giá trị ĐH";
            // 
            // txtthanhtoan
            // 
            this.txtthanhtoan.Location = new System.Drawing.Point(284, 570);
            this.txtthanhtoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtthanhtoan.Name = "txtthanhtoan";
            this.txtthanhtoan.Size = new System.Drawing.Size(187, 22);
            this.txtthanhtoan.TabIndex = 55;
            // 
            // txtcongphantramtong
            // 
            this.txtcongphantramtong.Location = new System.Drawing.Point(491, 503);
            this.txtcongphantramtong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcongphantramtong.Name = "txtcongphantramtong";
            this.txtcongphantramtong.Size = new System.Drawing.Size(187, 22);
            this.txtcongphantramtong.TabIndex = 54;
            this.txtcongphantramtong.TextChanged += new System.EventHandler(this.txtcongphantramtong_TextChanged);
            this.txtcongphantramtong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcongphantramtong_KeyPress);
            // 
            // txtcongtientong
            // 
            this.txtcongtientong.Location = new System.Drawing.Point(491, 471);
            this.txtcongtientong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcongtientong.Name = "txtcongtientong";
            this.txtcongtientong.Size = new System.Drawing.Size(187, 22);
            this.txtcongtientong.TabIndex = 53;
            this.txtcongtientong.TextChanged += new System.EventHandler(this.txtcongtientong_TextChanged);
            this.txtcongtientong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcongtientong_KeyPress);
            // 
            // txtgiamphantramtong
            // 
            this.txtgiamphantramtong.Location = new System.Drawing.Point(159, 506);
            this.txtgiamphantramtong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgiamphantramtong.Name = "txtgiamphantramtong";
            this.txtgiamphantramtong.Size = new System.Drawing.Size(187, 22);
            this.txtgiamphantramtong.TabIndex = 52;
            this.txtgiamphantramtong.TextChanged += new System.EventHandler(this.txtgiamphantramtong_TextChanged);
            this.txtgiamphantramtong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiamphantramtong_KeyPress);
            // 
            // txtgiamtientong
            // 
            this.txtgiamtientong.Location = new System.Drawing.Point(159, 474);
            this.txtgiamtientong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgiamtientong.Name = "txtgiamtientong";
            this.txtgiamtientong.Size = new System.Drawing.Size(187, 22);
            this.txtgiamtientong.TabIndex = 51;
            this.txtgiamtientong.TextChanged += new System.EventHandler(this.txtgiamtientong_TextChanged);
            this.txtgiamtientong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiamtientong_KeyPress);
            // 
            // txttongcongtiensp
            // 
            this.txttongcongtiensp.Location = new System.Drawing.Point(159, 442);
            this.txttongcongtiensp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttongcongtiensp.Name = "txttongcongtiensp";
            this.txttongcongtiensp.Size = new System.Drawing.Size(187, 22);
            this.txttongcongtiensp.TabIndex = 50;
            this.txttongcongtiensp.TextChanged += new System.EventHandler(this.txttongcongtiensp_TextChanged);
            // 
            // xuathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 604);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtthanhtoan);
            this.Controls.Add(this.txtcongphantramtong);
            this.Controls.Add(this.txtcongtientong);
            this.Controls.Add(this.txtgiamphantramtong);
            this.Controls.Add(this.txtgiamtientong);
            this.Controls.Add(this.txttongcongtiensp);
            this.Controls.Add(this.comboBoxloaisp);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxdonvisp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhuyHD);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.txttiensp);
            this.Controls.Add(this.txtgiamphantramsp);
            this.Controls.Add(this.txtdongiasp);
            this.Controls.Add(this.txtsoluongsp);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttenn);
            this.Controls.Add(this.txtman);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "xuathang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtman;
        private System.Windows.Forms.TextBox txttenn;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtsoluongsp;
        private System.Windows.Forms.TextBox txtdongiasp;
        private System.Windows.Forms.TextBox txtgiamphantramsp;
        private System.Windows.Forms.TextBox txttiensp;
        private FontAwesome.Sharp.IconButton btnhuy;
        private FontAwesome.Sharp.IconButton btnxoa;
        private FontAwesome.Sharp.IconButton btnthem;
        private FontAwesome.Sharp.IconButton btnsua;
        private FontAwesome.Sharp.IconButton btnthanhtoan;
        private FontAwesome.Sharp.IconButton btnhuyHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxdonvisp;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxloaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtiensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgiasp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtthanhtoan;
        private System.Windows.Forms.TextBox txtcongphantramtong;
        private System.Windows.Forms.TextBox txtcongtientong;
        private System.Windows.Forms.TextBox txtgiamphantramtong;
        private System.Windows.Forms.TextBox txtgiamtientong;
        private System.Windows.Forms.TextBox txttongcongtiensp;
    }
}