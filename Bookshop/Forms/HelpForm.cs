using System;
using System.Windows.Forms;

namespace Bookshop.Forms
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        //private void HelpForm_SizeChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void panelImage_AutoSizeChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void panelImage_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void panelImage_Click(object sender, EventArgs e)
        {
            if (panelText.Visible == true)
            {
                panelText.Visible = false;
                panelInfo.Visible = false;
                panelImage.BackgroundImage = Properties.Resources.instruction_min;
                panelImage.BackgroundImageLayout = ImageLayout.Center;
                panelImage.Dock = DockStyle.Fill;
            }
            else
            {
                panelText.Visible = true;
                panelInfo.Visible = true;
                panelImage.BackgroundImage = Properties.Resources.instruction_700;
                panelImage.BackgroundImageLayout = ImageLayout.None;
                panelImage.Dock = DockStyle.Right;
            }
        }
    }
}
