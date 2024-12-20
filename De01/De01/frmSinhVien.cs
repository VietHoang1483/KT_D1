using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using De01.Models;

namespace De01
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void FillFalcultyCombobox(List<Lop> listClass)
        {
            this.cmbClass.DataSource = listClass;
            this.cmbClass.DisplayMember = "TenLop";
            this.cmbClass.ValueMember = "MaLop";
        }
        private void BindGrid(List<SinhVien> listStudent)
        {
            dgvQLSV.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvQLSV.Rows.Add();
                dgvQLSV.Rows[index].Cells[0].Value = item.MaSV;
                dgvQLSV.Rows[index].Cells[1].Value = item.HotenSV;
                dgvQLSV.Rows[index].Cells[2].Value = item.Ngaysinh;
                if (item.Lop != null)
                {
                    dgvQLSV.Rows[index].Cells[3].Value = item.Lop.TenLop;
                }
                else
                {
                    dgvQLSV.Rows[index].Cells[3].Value = "Công nghệ thông tin"; 
                }
            }
        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                SinhvienContextDB context = new SinhvienContextDB();
                List<Lop> listClass = context.Lops.ToList(); 
                List<SinhVien> listStudent = context.SinhViens.ToList(); 
                FillFalcultyCombobox(listClass);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtID.Text.Length > 6)
                {
                    MessageBox.Show("Mã số sinh viên phải có it hơn 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SinhvienContextDB db = new SinhvienContextDB();
                List<SinhVien> studentLst = db.SinhViens.ToList();
                if (studentLst.Any(s => s.MaSV == txtID.Text))
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newSV = new SinhVien
                {
                    MaSV = txtID.Text,
                    HotenSV = txtName.Text,
                    MaLop = cmbClass.SelectedValue.ToString(),
                    Ngaysinh = dtpBirth.Value
                };
                db.SinhViens.Add(newSV);
                db.SaveChanges();
                BindGrid(db.SinhViens.ToList());

                MessageBox.Show("Thêm sinh viên thành công!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvQLSV.Rows[e.RowIndex];
                txtID.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                dtpBirth.Text = selectedRow.Cells[2].Value.ToString();
                cmbClass.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtID.Text.Length >6)
                {
                    MessageBox.Show("Mã số sinh viên không được nhiều hơn 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SinhvienContextDB db = new SinhvienContextDB();
                List<SinhVien> students = db.SinhViens.ToList();
                var student = students.FirstOrDefault(s => s.MaSV == txtID.Text);
                if (student != null)
                {
                    if (students.Any(s => s.MaSV == txtID.Text && s.MaSV != student.MaSV))
                    {
                        MessageBox.Show("Mã SV đã tồn tại, vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    student.HotenSV = txtName.Text;
                    student.MaLop = cmbClass.SelectedValue.ToString();
                    student.Ngaysinh = dtpBirth.Value;

                    db.SaveChanges();

                    BindGrid(db.SinhViens.ToList());

                    MessageBox.Show("Chỉnh sửa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SinhvienContextDB db = new SinhvienContextDB();
                List<SinhVien> ListSV = db.SinhViens.ToList();
                var student = ListSV.FirstOrDefault(s => s.MaSV == txtID.Text);
                if (student != null)
                {
                    db.SinhViens.Remove(student);
                    db.SaveChanges();

                    BindGrid(db.SinhViens.ToList());

                    MessageBox.Show("Sinh viên đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try 
            { 
                SinhvienContextDB context = new SinhvienContextDB();
                string hoten = txtFindname.Text.Trim();
                var query = context.SinhViens.AsQueryable();
                if (!string.IsNullOrEmpty(hoten))
                    query = query.Where(s => s.HotenSV.Contains(hoten));


                List<SinhVien> students = query.ToList();
                BindGrid(students);
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }

        private void dgvQLSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvQLSV.Rows[e.RowIndex];
                txtID.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                dtpBirth.Text = selectedRow.Cells[2].Value.ToString();
                cmbClass.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void frmSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát?", "Câu hỏi thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFindname_TextChanged(object sender, EventArgs e)
        {
            if (txtFindname.Text == "")
            {
                SinhvienContextDB db = new SinhvienContextDB();
                List<SinhVien> ListSV = db.SinhViens.ToList();
                BindGrid(ListSV);
            }
        }
    }
}
