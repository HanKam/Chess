using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class SingleForm : Form
    {
        public SingleForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int timeMove = (int)((minTimerMoves.Value * 60) + secTimerMoves.Value);
            int timeAdd = (int)((minTimerAdd.Value * 60) + secTimerAdd.Value);

            ChessBoardForm chessBoardForm = new ChessBoardForm(timeMove, timeAdd);


            chessBoardForm.TopLevel = false;
            chessBoardForm.FormBorderStyle = FormBorderStyle.None;
            chessBoardForm.Anchor = AnchorStyles.None;

            this.Controls.Add(chessBoardForm);

            chessBoardForm.BringToFront();
            chessBoardForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
