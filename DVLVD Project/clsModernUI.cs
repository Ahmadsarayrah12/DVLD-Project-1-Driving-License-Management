using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DVLVD_Project
{
    // åÐÇ ÇáßáÇÓ (Class) æÙíÝÊå ÈÓíØÉ ÌÏÇð: ÅÖÇÝÉ ÔÑíØ Úáæí ÍÏíË ÞÇÈá ááÓÍÈ áÃí ÔÇÔÉ
    public static class clsModernUI
    {
        // åÐå ÇáÃÓØÑ ÊÓÊÏÚí ãßÊÈÇÊ äÙÇã æíäÏæÒ ÇáÃÓÇÓíÉ áßí ÊÓãÍ áäÇ ÈÓÍÈ ÇáÔÇÔÉ ÈÇáãÇæÓ 
        // (áÇ ÊÞáÞ ãä ÔßáåÇ¡ åí ãÌÑÏ ÃßæÇÏ ÞíÇÓíÉ ÊõÓÊÎÏã ÏÇÆãÇð Ýí ÇáäæÇÝÐ ÇáÊí áíÓ áåÇ ÅØÇÑ)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // ÇáÏÇáÉ ÇáÑÆíÓíÉ ÇáÊí äãÑÑ áåÇ Ãí ÝæÑã áíÕÈÍ ÈÔÑíØ ÍÏíË
        public static void ApplyModernTitleBar(Form frm)
        {
            // ÃæáÇð: äáÛí ÅØÇÑ ÇáæíäÏæÒ ÇáÊÞáíÏí
            frm.FormBorderStyle = FormBorderStyle.None;

            // ËÇäíÇð: äÞæã ÈÏÝÚ ÌãíÚ ãÍÊæíÇÊ ÇáÔÇÔÉ ááÃÓÝá ÈãÞÏÇÑ 35 ÈßÓá 
            // áßí áÇ íÛØí ÇáÔÑíØ ÇáÚáæí Úáì ÇáÚäÇÕÑ ÇáãæÌæÏÉ ÃÕáÇð
            int barHeight = 35;
            foreach (Control ctrl in frm.Controls)
            {
                ctrl.Top += barHeight;
            }
            frm.Height += barHeight;

            // ËÇáËÇð: äÕãã ÇáÔÑíØ ÇáÚáæí (Panel) æäÚØíå áæä ÏÇßä
            Panel topPanel = new Panel();
            topPanel.Height = barHeight;
            topPanel.Dock = DockStyle.Top;
            topPanel.BackColor = Color.FromArgb(24, 43, 73); 

            // ÑÇÈÚÇð: äßÊÈ ÚäæÇä ÇáÔÇÔÉ Úáì ÇáÔÑíØ
            Label lblTitle = new Label();
            lblTitle.Text = frm.Text;
            lblTitle.ForeColor = Color.FromArgb(212, 175, 55); 
            lblTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(10, 7);

            // ÎÇãÓÇð: åÐå ÇáÏÇáÉ ÇáÈÓíØÉ ÊÊÃßÏ Ãä ÇáãÓÊÎÏã ÚäÏ ÖÛØå ÈÇáãÇæÓ íãßäå ÓÍÈ ÇáÔÇÔÉ
            MouseEventHandler dragHandler = (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(frm.Handle, 0x112, 0xf012, 0);
                }
            };

            // äÑÈØ ÎÇÕíÉ ÇáÓÍÈ ÈÇáÔÑíØ æÇáÚäæÇä
            topPanel.MouseDown += dragHandler;
            lblTitle.MouseDown += dragHandler;

            // ÃÎíÑÇð: äÖíÝ ÇáÚäæÇä ÏÇÎá ÇáÔÑíØ¡ Ëã äÖíÝ ÇáÔÑíØ äÝÓå ÏÇÎá ÇáÔÇÔÉ
            topPanel.Controls.Add(lblTitle);
            frm.Controls.Add(topPanel);

            // ÅÖÇÝÉ ÅØÇÑ ÑÝíÚ ÌÏÇð (Border) Íæá ÇáÔÇÔÉ ÈÇááæä ÇáÐåÈí áíÚØí ÔßáÇð ÌãÇáíÇð
            frm.Paint += (s, e) => 
            {
                ControlPaint.DrawBorder(e.Graphics, frm.ClientRectangle, Color.FromArgb(212, 175, 55), ButtonBorderStyle.Solid);
            };
        }
    }
}
