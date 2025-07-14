using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProWash360.Forms;

namespace ProWash360
{
    public partial class frmMain : Form
    {

        private Button currentButton;
        private readonly Random random;
        private int tempIndex;
        private Form activeForm;
        private Color color;

        public frmMain()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Limit the maximize area to working area           
            object btnObject = (Button)btnDashBoard;
            btnDashBoard_Click(btnObject, EventArgs.Empty);

            // Insert Your codes here
        }

        #region Methods
        // Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void openChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktopPane.Controls.Add(childForm);
            this.pnlDesktopPane.Tag = childForm;
            lblTital.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTop.BackColor = color;
                    lblLogo.BackColor = color;
                    lblLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    lblTital.BackColor = color;
                    btnClose.BackColor = color;
                    btnMaximize.BackColor = color;
                    btnMinimize.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }

            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(11, 7, 17);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        #endregion

        #region MainButtonClicks
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmDashboard(), sender);
        }

        private void btnLiveData_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmLiveData(), sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmReports(), sender);
        }

        private void btnPLCConfig_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmPLCConfig(), sender);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmLogs(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.frmSettings(), sender);
        }
        #endregion


        #region ControlButtons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Form_Drag_Option

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParem, int IParam);

        // Drag from Logo
        private void pnlLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }

        private void picbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }

        // Drag from Main Logo name
        private void lblLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }
        // Drag from Version Lable
        private void lblVersion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }
        // Drag from Top Panel
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }
        private void lblTital_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }
        #endregion
    }
}
