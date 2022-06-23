using Bookshop.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FormMainMenu()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelBookSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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
            List<Control> controls = new List<Control>();

            foreach (Control c1 in panelMenu.Controls)
            {
                foreach (Control c2 in panelBookSubMenu.Controls)
                {
                    controls.Add(c1);
                    controls.Add(c2);
                }
            }

            foreach (Control previousBtn in controls)
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

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            showSubMenu(panelBookSubMenu);
        }
        
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomersForm(), sender);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrdersForm(), sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnBookInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BooksForm(), sender);
            hideSubMenu();
        }

        private void btnGenresEtc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GenresAuthorsPublishersForm(), sender);
            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            this.Hide();
            form.Show();
        }
    }
}
