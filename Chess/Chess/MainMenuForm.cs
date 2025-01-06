using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Chess
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();

            
            startForm.TopLevel = false;
            startForm.FormBorderStyle = FormBorderStyle.None;
            startForm.Anchor = AnchorStyles.None;

            this.Controls.Add(startForm);

            startForm.BringToFront();           
            startForm.Show();         
        }

        private void btnOption_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();     
            Application.Exit();
        }
    }
}
