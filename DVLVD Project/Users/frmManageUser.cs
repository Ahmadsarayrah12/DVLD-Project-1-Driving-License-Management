using System;
using System.Data;
using System.Windows.Forms;
using LibraryProject.BussinessLogic;

namespace DVLVD_Project
{
    public partial class frmManageUser : Form
    {
        private static DataTable _dtAllUsers;

        public frmManageUser()
        {
            InitializeComponent();
            clsModernUI.ApplyModernTitleBar(this);
        }

        private void _RefreshUsersList()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvPeopleData.DataSource = _dtAllUsers;
            _FormatUsersGrid();
        }

        private void SetupColumn(string name, string headerText, int width, int displayIndex)
        {
            if (dgvPeopleData.Columns.Contains(name))
            {
                var col = dgvPeopleData.Columns[name];
                col.Visible = true;
                col.HeaderText = headerText;
                col.Width = width;
                col.DisplayIndex = displayIndex;
            }
        }

        private void _FormatUsersGrid()
        {
            if (dgvPeopleData.Columns.Count == 0) return;

            foreach (DataGridViewColumn c in dgvPeopleData.Columns)
                c.Visible = false;

            SetupColumn("UserID", "User ID", 110, 0);
            SetupColumn("PersonID", "Person ID", 110, 1);
            SetupColumn("FullName", "Full Name", 330, 2);
            SetupColumn("UserName", "UserName", 160, 3);
            SetupColumn("IsActive", "Is Active", 100, 4);
        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();

            if (cbFilter.Items.Count > 0)
                cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbFilter.Text != "None");

            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilter.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Is Active":
                    FilterColumn = "IsActive";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "UserID" || FilterColumn == "PersonID")
            {
                if (!int.TryParse(txtFilter.Text.Trim(), out int result))
                {
                    _dtAllUsers.DefaultView.RowFilter = "";
                    return;
                }
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, result);
            }
            else if (FilterColumn == "IsActive")
            {
                string val = txtFilter.Text.Trim().ToLower();
                if (val == "1" || val == "yes" || val == "true")
                    _dtAllUsers.DefaultView.RowFilter = "[IsActive] = 1";
                else if (val == "0" || val == "no" || val == "false")
                    _dtAllUsers.DefaultView.RowFilter = "[IsActive] = 0";
                else
                    _dtAllUsers.DefaultView.RowFilter = "";
            }
            else
            {
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim().Replace("'", "''"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void TsmiDetails_Click(object sender, EventArgs e)
        {
            if (dgvPeopleData.CurrentRow != null)
            {
                int userID = (int)dgvPeopleData.CurrentRow.Cells["UserID"].Value;
                frmUserInfo frm = new frmUserInfo(userID);
                frm.ShowDialog();
                _RefreshUsersList();
            }
        }

        private void TsmiAdd_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void TsmiEdit_Click(object sender, EventArgs e)
        {
            if (dgvPeopleData.CurrentRow != null)
            {
                int userID = (int)dgvPeopleData.CurrentRow.Cells["UserID"].Value;
                frmAddEditUser frm = new frmAddEditUser(userID);
                frm.ShowDialog();
                _RefreshUsersList();
            }
        }

        private void TsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgvPeopleData.CurrentRow != null)
            {
                int userID = (int)dgvPeopleData.CurrentRow.Cells["UserID"].Value;

                if (MessageBox.Show("Are you sure you want to delete User ID [" + userID + "]?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsUser.DeleteUser(userID))
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshUsersList();
                    }
                    else
                    {
                        MessageBox.Show("Could not delete user. It might be linked to other data in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TsmiChangePassword_Click(object sender, EventArgs e)
        {
            if (dgvPeopleData.CurrentRow != null)
            {
                int userID = (int)dgvPeopleData.CurrentRow.Cells["UserID"].Value;
                frmChangePassword frm = new frmChangePassword(userID);
                frm.ShowDialog();
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(Coming Soon!)", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(Coming Soon!)", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
