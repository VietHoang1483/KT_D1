namespace De01
{
    partial class frmSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDontsave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvQLSV = new System.Windows.Forms.DataGridView();
            this.txtFindname = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin chi tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lớp học:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(133, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(439, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 1;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(439, 68);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(191, 24);
            this.cmbClass.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(203, 102);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 57);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(318, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(428, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(541, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 27);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(661, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDontsave
            // 
            this.btnDontsave.Location = new System.Drawing.Point(755, 117);
            this.btnDontsave.Name = "btnDontsave";
            this.btnDontsave.Size = new System.Drawing.Size(75, 27);
            this.btnDontsave.TabIndex = 5;
            this.btnDontsave.Text = "K. lưu";
            this.btnDontsave.UseVisualStyleBackColor = true;
            this.btnDontsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(861, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvQLSV
            // 
            this.dgvQLSV.AllowUserToAddRows = false;
            this.dgvQLSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.birth,
            this.Class});
            this.dgvQLSV.Location = new System.Drawing.Point(12, 170);
            this.dgvQLSV.Name = "dgvQLSV";
            this.dgvQLSV.RowHeadersWidth = 51;
            this.dgvQLSV.RowTemplate.Height = 24;
            this.dgvQLSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLSV.Size = new System.Drawing.Size(924, 213);
            this.dgvQLSV.TabIndex = 6;
            this.dgvQLSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSV_CellClick);
            this.dgvQLSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSV_CellContentClick);
            // 
            // txtFindname
            // 
            this.txtFindname.Location = new System.Drawing.Point(14, 117);
            this.txtFindname.Name = "txtFindname";
            this.txtFindname.Size = new System.Drawing.Size(183, 22);
            this.txtFindname.TabIndex = 7;
            this.txtFindname.TextChanged += new System.EventHandler(this.txtFindname_TextChanged);
            // 
            // dtpBirth
            // 
            this.dtpBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirth.Location = new System.Drawing.Point(133, 70);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(191, 22);
            this.dtpBirth.TabIndex = 8;
            this.dtpBirth.Value = new System.DateTime(2004, 10, 20, 0, 0, 0, 0);
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã sinh viên";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 130;
            // 
            // name
            // 
            this.name.HeaderText = "Họ tên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 190;
            // 
            // birth
            // 
            this.birth.HeaderText = "Ngày sinh";
            this.birth.MinimumWidth = 6;
            this.birth.Name = "birth";
            this.birth.Width = 150;
            // 
            // Class
            // 
            this.Class.HeaderText = "Lớp";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            this.Class.Width = 170;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 387);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.txtFindname);
            this.Controls.Add(this.dgvQLSV);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDontsave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhVien";
            this.Text = "DANH SÁCH SINH VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSinhVien_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSinhVien_FormClosed);
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDontsave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvQLSV;
        private System.Windows.Forms.TextBox txtFindname;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
    }
}

