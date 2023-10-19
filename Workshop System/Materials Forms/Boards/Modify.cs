using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class;
using Workshop_System.Materials_Forms;

namespace Workshop_System.Prices_Options.Addtions
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
            Update();
        }
        public void Update()
        {
            DataBase DB = new DataBase("", "");
            BName.DisplayMember = "Value";
            BName.ValueMember = "Value";
            if (DB.GetData("") != null)
            {
                BName.DataSource = DB.GetData(""); BName.Enabled = true;
            }
            else
                BName.Enabled = false;

            Type.DisplayMember = "Value";
            Type.ValueMember = "Value";
            if (DB.GetData("") != null)
            {
                Type.DataSource = DB.GetData(""); Type.Enabled = true;
            }
            else
                Type.Enabled = false;
        }

        public Modify(string S)
        {
            InitializeComponent();
            ID.Text = S;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id))
            {
                string SName = BName.Text;
                string SType = Type.Text;
                string SColor = Color.Text;
                string SHeight = Height.Text;
                string SWidth = Width.Text;
                string SDeep = Deep.Text;
                string SFPrice = FPrice.Text;
                string SMPrice = MPrice.Text;
                if (!string.IsNullOrEmpty(SName) || !string.IsNullOrEmpty(SType) || !string.IsNullOrEmpty(SColor) || !string.IsNullOrEmpty(SHeight) || !string.IsNullOrEmpty(SWidth) || !string.IsNullOrEmpty(SDeep) || !string.IsNullOrEmpty(SFPrice) || !string.IsNullOrEmpty(SMPrice))
                {
                    BoardClass boardClass = new BoardClass();
                    boardClass.ID = Convert.ToInt32(id);
                    if(!string.IsNullOrEmpty(SName))
                        boardClass.Name = SName;
                    if(!string.IsNullOrEmpty(SType))
                        boardClass.Type = SType;
                    if(!string.IsNullOrEmpty(SColor))
                        boardClass.Color = SColor;
                    if(!string.IsNullOrEmpty(SHeight))
                        boardClass.Height = float.Parse(SHeight);
                    if(!string.IsNullOrEmpty(SWidth))
                        boardClass.Width = float.Parse(SWidth);
                    if(!string.IsNullOrEmpty(SDeep))
                        boardClass.Deep = float.Parse(SDeep);
                    if(!string.IsNullOrEmpty(SFPrice))
                        boardClass.FPrice = float.Parse(SFPrice);
                    if(!string.IsNullOrEmpty(SMPrice))
                        boardClass.MPrice = float.Parse(SMPrice);
                    if (boardClass.Update())
                    {
                        MessageBox.Show("تم تحديث البيانات بنجاح ");
                        ID.Text = string.Empty;
                        BName.Text = string.Empty;
                        Type.Text = string.Empty;
                        Color.Text = string.Empty;
                        Height.Text = string.Empty;
                        Width.Text = string.Empty;
                        Deep.Text = string.Empty;
                        FPrice.Text = string.Empty;
                        MPrice.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("عفوا حدث خطا في تحديث البيانات");
                    }

                }
                else
                {
                    MessageBox.Show("عفوا يجب ادخال بيانات للتحديث");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال الرقم الكودي اولا");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ID.Text = string.Empty;
            BName.Text = string.Empty;
            Type.Text = string.Empty;
            Color.Text = string.Empty;
            Height.Text = string.Empty;
            Width.Text = string.Empty;
            Deep.Text = string.Empty;
            FPrice.Text = string.Empty;
            MPrice.Text = string.Empty;
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void Details_Click(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
            Update();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
