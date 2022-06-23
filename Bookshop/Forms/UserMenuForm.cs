using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshop.Forms
{
    public partial class UserMenuForm : Form
    {
        public string login;
        private Button currentButton;
        private Form activeForm;

        public UserMenuForm()
        {
            InitializeComponent();
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromName("BlueViolet");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromName("Indigo");
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm form = new CartForm();
            form._login = login;
            OpenChildForm(form, sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm form = new UserProfileForm();
            form._login = login;
            OpenChildForm(form, sender);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HelpForm(), sender);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            this.Hide();
            form.Show();
        }
    }
}
