namespace Quanlybanhangcomputer
{
    partial class quanlynhanvien
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvquanlynhanvien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbltimkiem = new System.Windows.Forms.Button();
            this.tblxoa = new System.Windows.Forms.Button();
            this.tblsua = new System.Windows.Forms.Button();
            this.tblthem = new System.Windows.Forms.Button();
            this.tblreset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtchucvu = new System.Windows.Forms.ComboBox();
            this.txtphucap = new System.Windows.Forms.TextBox();
            this.txtluongcoban = new System.Windows.Forms.TextBox();
            this.txtennhanvien = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblquaylai = new System.Windows.Forms.Button();
            this.tbldangxuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlynhanvien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvquanlynhanvien);
            this.panel4.Location = new System.Drawing.Point(17, 338);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1062, 353);
            this.panel4.TabIndex = 9;
            // 
            // dgvquanlynhanvien
            // 
            this.dgvquanlynhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlynhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvquanlynhanvien.Location = new System.Drawing.Point(0, 0);
            this.dgvquanlynhanvien.Name = "dgvquanlynhanvien";
            this.dgvquanlynhanvien.RowHeadersWidth = 51;
            this.dgvquanlynhanvien.RowTemplate.Height = 24;
            this.dgvquanlynhanvien.Size = new System.Drawing.Size(1062, 353);
            this.dgvquanlynhanvien.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tbltimkiem);
            this.panel3.Controls.Add(this.tblxoa);
            this.panel3.Controls.Add(this.tblsua);
            this.panel3.Controls.Add(this.tblthem);
            this.panel3.Controls.Add(this.tblreset);
            this.panel3.Location = new System.Drawing.Point(17, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 79);
            this.panel3.TabIndex = 8;
            // 
            // tbltimkiem
            // 
            this.tbltimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbltimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbltimkiem.Location = new System.Drawing.Point(882, 22);
            this.tbltimkiem.Name = "tbltimkiem";
            this.tbltimkiem.Size = new System.Drawing.Size(142, 42);
            this.tbltimkiem.TabIndex = 4;
            this.tbltimkiem.Text = "Tìm kiếm";
            this.tbltimkiem.UseVisualStyleBackColor = true;
            // 
            // tblxoa
            // 
            this.tblxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblxoa.Location = new System.Drawing.Point(672, 22);
            this.tblxoa.Name = "tblxoa";
            this.tblxoa.Size = new System.Drawing.Size(142, 42);
            this.tblxoa.TabIndex = 3;
            this.tblxoa.Text = "Xóa";
            this.tblxoa.UseVisualStyleBackColor = true;
            // 
            // tblsua
            // 
            this.tblsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblsua.Location = new System.Drawing.Point(462, 22);
            this.tblsua.Name = "tblsua";
            this.tblsua.Size = new System.Drawing.Size(142, 42);
            this.tblsua.TabIndex = 2;
            this.tblsua.Text = "Sửa";
            this.tblsua.UseVisualStyleBackColor = true;
            // 
            // tblthem
            // 
            this.tblthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblthem.Location = new System.Drawing.Point(251, 22);
            this.tblthem.Name = "tblthem";
            this.tblthem.Size = new System.Drawing.Size(142, 42);
            this.tblthem.TabIndex = 1;
            this.tblthem.Text = "Thêm";
            this.tblthem.UseVisualStyleBackColor = true;
            // 
            // tblreset
            // 
            this.tblreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblreset.Location = new System.Drawing.Point(42, 22);
            this.tblreset.Name = "tblreset";
            this.tblreset.Size = new System.Drawing.Size(142, 42);
            this.tblreset.TabIndex = 0;
            this.tblreset.Text = "Reset";
            this.tblreset.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtchucvu);
            this.panel2.Controls.Add(this.txtphucap);
            this.panel2.Controls.Add(this.txtluongcoban);
            this.panel2.Controls.Add(this.txtennhanvien);
            this.panel2.Controls.Add(this.txtmanhanvien);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(17, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 99);
            this.panel2.TabIndex = 7;
            // 
            // txtchucvu
            // 
            this.txtchucvu.FormattingEnabled = true;
            this.txtchucvu.Location = new System.Drawing.Point(799, 22);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(226, 24);
            this.txtchucvu.TabIndex = 2;
            // 
            // txtphucap
            // 
            this.txtphucap.Location = new System.Drawing.Point(487, 56);
            this.txtphucap.Name = "txtphucap";
            this.txtphucap.Size = new System.Drawing.Size(222, 22);
            this.txtphucap.TabIndex = 4;
            // 
            // txtluongcoban
            // 
            this.txtluongcoban.Location = new System.Drawing.Point(138, 56);
            this.txtluongcoban.Name = "txtluongcoban";
            this.txtluongcoban.Size = new System.Drawing.Size(222, 22);
            this.txtluongcoban.TabIndex = 3;
            // 
            // txtennhanvien
            // 
            this.txtennhanvien.Location = new System.Drawing.Point(487, 19);
            this.txtennhanvien.Name = "txtennhanvien";
            this.txtennhanvien.Size = new System.Drawing.Size(222, 22);
            this.txtennhanvien.TabIndex = 1;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(138, 19);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(222, 22);
            this.txtmanhanvien.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(734, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phụ cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lương cơ bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(39, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tblquaylai);
            this.panel1.Controls.Add(this.tbldangxuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 131);
            this.panel1.TabIndex = 6;
            // 
            // tblquaylai
            // 
            this.tblquaylai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblquaylai.Location = new System.Drawing.Point(61, 45);
            this.tblquaylai.Name = "tblquaylai";
            this.tblquaylai.Size = new System.Drawing.Size(160, 49);
            this.tblquaylai.TabIndex = 1;
            this.tblquaylai.Text = "Quay lại";
            this.tblquaylai.UseVisualStyleBackColor = true;
            // 
            // tbldangxuat
            // 
            this.tbldangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbldangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbldangxuat.Location = new System.Drawing.Point(835, 47);
            this.tbldangxuat.Name = "tbldangxuat";
            this.tbldangxuat.Size = new System.Drawing.Size(152, 49);
            this.tbldangxuat.TabIndex = 1;
            this.tbldangxuat.Text = "Đăng xuất";
            this.tbldangxuat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 703);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "quanlynhanvien";
            this.Text = "quanlynhanvien";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlynhanvien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvquanlynhanvien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button tbltimkiem;
        private System.Windows.Forms.Button tblxoa;
        private System.Windows.Forms.Button tblsua;
        private System.Windows.Forms.Button tblthem;
        private System.Windows.Forms.Button tblreset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox txtchucvu;
        private System.Windows.Forms.TextBox txtphucap;
        private System.Windows.Forms.TextBox txtluongcoban;
        private System.Windows.Forms.TextBox txtennhanvien;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tblquaylai;
        private System.Windows.Forms.Button tbldangxuat;
        private System.Windows.Forms.Label label1;
    }
}