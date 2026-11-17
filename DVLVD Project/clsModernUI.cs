using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DVLVD_Project
{
    public static class clsModernUI
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void ApplyModernTitleBar(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;

            int barHeight = 35;
            foreach (Control ctrl in frm.Controls)
            {
                ctrl.Top += barHeight;
            }
            frm.Height += barHeight;

            Panel topPanel = new Panel();
            topPanel.Height = barHeight;
            topPanel.Dock = DockStyle.Top;
            topPanel.BackColor = Color.FromArgb(24, 43, 73); 

            Label lblTitle = new Label();
            lblTitle.Text = frm.Text;
            lblTitle.ForeColor = Color.FromArgb(212, 175, 55); 
            lblTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(10, 7);

            // Enable dragging form with mouse
            MouseEventHandler dragHandler = (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(frm.Handle, 0x112, 0xf012, 0);
                }
            };

            topPanel.MouseDown += dragHandler;
            lblTitle.MouseDown += dragHandler;

            topPanel.Controls.Add(lblTitle);
            frm.Controls.Add(topPanel);
        }
    }
}
