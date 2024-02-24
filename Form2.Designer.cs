namespace TestThreeLayerProject2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            sinhvienDgrd = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            ColTenSV = new DataGridViewTextBoxColumn();
            ColDiaChi = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dangNhapBusBindingSource = new BindingSource(components);
            msvTXT = new TextBox();
            tenSVtxt = new TextBox();
            diaChitxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sinhvienDgrd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dangNhapBusBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 711);
            panel1.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 190);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(250, 0);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "iconButton1";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 190);
            panel2.TabIndex = 0;
            // 
            // sinhvienDgrd
            // 
            sinhvienDgrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sinhvienDgrd.Columns.AddRange(new DataGridViewColumn[] { colMaSV, ColTenSV, ColDiaChi });
            sinhvienDgrd.Location = new Point(324, 89);
            sinhvienDgrd.Name = "sinhvienDgrd";
            sinhvienDgrd.RowHeadersWidth = 51;
            sinhvienDgrd.Size = new Size(678, 497);
            sinhvienDgrd.TabIndex = 3;
            // 
            // colMaSV
            // 
            colMaSV.DataPropertyName = "MaSinhVien";
            colMaSV.HeaderText = "Mã sinh viên";
            colMaSV.MinimumWidth = 6;
            colMaSV.Name = "colMaSV";
            colMaSV.Resizable = DataGridViewTriState.False;
            colMaSV.Width = 125;
            // 
            // ColTenSV
            // 
            ColTenSV.DataPropertyName = "TenSinhVien";
            ColTenSV.HeaderText = "Tên sinh viên";
            ColTenSV.MinimumWidth = 6;
            ColTenSV.Name = "ColTenSV";
            ColTenSV.Width = 200;
            // 
            // ColDiaChi
            // 
            ColDiaChi.DataPropertyName = "DiaChi";
            ColDiaChi.HeaderText = "Địa Chỉ";
            ColDiaChi.MinimumWidth = 6;
            ColDiaChi.Name = "ColDiaChi";
            ColDiaChi.Width = 300;
            // 
            // button3
            // 
            button3.Location = new Point(652, 632);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(794, 632);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(939, 632);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "Thêm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1087, 632);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 7;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dangNhapBusBindingSource
            // 
            dangNhapBusBindingSource.DataSource = typeof(BUSS.DangNhapBus);
            // 
            // msvTXT
            // 
            msvTXT.Location = new Point(1140, 143);
            msvTXT.Name = "msvTXT";
            msvTXT.Size = new Size(147, 27);
            msvTXT.TabIndex = 8;
            // 
            // tenSVtxt
            // 
            tenSVtxt.Location = new Point(1140, 215);
            tenSVtxt.Name = "tenSVtxt";
            tenSVtxt.Size = new Size(147, 27);
            tenSVtxt.TabIndex = 9;
            // 
            // diaChitxt
            // 
            diaChitxt.Location = new Point(1140, 286);
            diaChitxt.Name = "diaChitxt";
            diaChitxt.Size = new Size(147, 27);
            diaChitxt.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1030, 146);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 11;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1030, 215);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 12;
            label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1030, 286);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 13;
            label3.Text = "Địa chỉ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 711);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(diaChitxt);
            Controls.Add(tenSVtxt);
            Controls.Add(msvTXT);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(sinhvienDgrd);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sinhvienDgrd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dangNhapBusBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private DataGridView sinhvienDgrd;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private BindingSource dangNhapBusBindingSource;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn ColTenSV;
        private DataGridViewTextBoxColumn ColDiaChi;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox msvTXT;
        private TextBox tenSVtxt;
        private TextBox diaChitxt;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}