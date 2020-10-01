namespace QuanLiKho.User
{
    partial class XuatHangUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.ML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaLoHang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ML,
            this.MH,
            this.NH,
            this.NS,
            this.HS,
            this.SL,
            this.GI});
            this.dgView.Location = new System.Drawing.Point(15, 163);
            this.dgView.Margin = new System.Windows.Forms.Padding(2);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersVisible = false;
            this.dgView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgView.RowTemplate.Height = 24;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(1097, 492);
            this.dgView.TabIndex = 16;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // ML
            // 
            this.ML.DataPropertyName = "MaLoHang";
            this.ML.FillWeight = 85.27919F;
            this.ML.HeaderText = "Mã lô hàng";
            this.ML.MinimumWidth = 6;
            this.ML.Name = "ML";
            // 
            // MH
            // 
            this.MH.DataPropertyName = "MaHH";
            this.MH.FillWeight = 85.27919F;
            this.MH.HeaderText = "Mã hàng hóa";
            this.MH.MinimumWidth = 6;
            this.MH.Name = "MH";
            // 
            // NH
            // 
            this.NH.DataPropertyName = "NgayXuat";
            this.NH.HeaderText = "Ngày xuất";
            this.NH.Name = "NH";
            // 
            // NS
            // 
            this.NS.DataPropertyName = "NSX";
            this.NS.FillWeight = 85.27919F;
            this.NS.HeaderText = "NSX";
            this.NS.MinimumWidth = 6;
            this.NS.Name = "NS";
            // 
            // HS
            // 
            this.HS.DataPropertyName = "HSD";
            this.HS.FillWeight = 85.27919F;
            this.HS.HeaderText = "HSD";
            this.HS.MinimumWidth = 6;
            this.HS.Name = "HS";
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SoLuong";
            this.SL.FillWeight = 85.27919F;
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            // 
            // GI
            // 
            this.GI.DataPropertyName = "Gia";
            this.GI.FillWeight = 85.27919F;
            this.GI.HeaderText = "Giá";
            this.GI.Name = "GI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.NgayNhap);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.SoLuong);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.MaLoHang);
            this.panel2.Location = new System.Drawing.Point(15, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 135);
            this.panel2.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(914, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 35);
            this.button3.TabIndex = 18;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(914, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NgayNhap
            // 
            this.NgayNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayNhap.Location = new System.Drawing.Point(417, 76);
            this.NgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Size = new System.Drawing.Size(150, 29);
            this.NgayNhap.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(914, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(307, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ngày xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(534, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số lượng";
            // 
            // SoLuong
            // 
            this.SoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SoLuong.Location = new System.Drawing.Point(616, 24);
            this.SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(177, 29);
            this.SoLuong.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(45, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã lô hàng";
            // 
            // MaLoHang
            // 
            this.MaLoHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaLoHang.Location = new System.Drawing.Point(156, 27);
            this.MaLoHang.Margin = new System.Windows.Forms.Padding(2);
            this.MaLoHang.Name = "MaLoHang";
            this.MaLoHang.Size = new System.Drawing.Size(144, 29);
            this.MaLoHang.TabIndex = 5;
            // 
            // XuatHangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLiKho.Properties.Resources.hinh_nen_powerpoint_cong_nghe_10_min_600x375;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgView);
            this.Name = "XuatHangUC";
            this.Size = new System.Drawing.Size(1137, 680);
            this.Load += new System.EventHandler(this.XuatHangUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker NgayNhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaLoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ML;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GI;
    }
}
