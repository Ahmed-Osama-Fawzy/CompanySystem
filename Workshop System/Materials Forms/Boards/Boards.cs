using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_System.Prices_Options.Addtions
{
    public partial class Boards : Form
    {
        public Boards()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddBoard_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }

        private void ModifyBoard_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            modify.ShowDialog();
        }

        private void ShowBoard_Click(object sender, EventArgs e)
        {
            ShowBoard showBoard = new ShowBoard();
            showBoard.ShowDialog();
        }

        private void ShowBoards_Click(object sender, EventArgs e)
        {
            ShowBoards showBoards = new ShowBoards();
            showBoards.ShowDialog();
        }

        private void RemoveBoard_Click(object sender, EventArgs e)
        {
            Remove remove  = new Remove();
            remove.ShowDialog();
        }
    }
}
