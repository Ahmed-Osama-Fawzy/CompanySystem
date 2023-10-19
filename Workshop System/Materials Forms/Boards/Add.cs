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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Workshop_System.Prices_Options.Addtions
{
    public partial class Add : Form
    {
        public Add()
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string SName = BName.Text;
            string SType = Type.Text;
            string SColor = Color.Text;
            string SHeight  = Height.Text;
            string SWidth = Width.Text;
            string SDeep = Deep.Text;
            string SFPrice = FPrice.Text;
            string SMPrice = MPrice.Text;
            if(!string.IsNullOrEmpty(SName) && !string.IsNullOrEmpty(SType) && !string.IsNullOrEmpty(SColor) && !string.IsNullOrEmpty(SHeight) && !string.IsNullOrEmpty(SWidth) && !string.IsNullOrEmpty(SDeep) && !string.IsNullOrEmpty(SFPrice) && !string.IsNullOrEmpty(SMPrice))
            {
                BoardClass boardClass = new BoardClass();
                boardClass.Name = SName;
                boardClass.Type = SType;
                boardClass.Color = SColor;
                boardClass.Height = float.Parse(SHeight);
                boardClass.Width = float.Parse(SWidth);
                boardClass.Deep = float.Parse(SDeep);
                boardClass.FPrice = float.Parse(SFPrice);
                boardClass.MPrice = float.Parse(SMPrice);
                if (boardClass.Insert())
                {
                    MessageBox.Show("تم اضافة البيانات بنجاح");
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
                    MessageBox.Show("عفوا لا يمكنك ادخال البيانات");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع البيانات اولا");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            BName.Text = string.Empty;
            Type.Text = string.Empty;
            Color.Text = string.Empty;
            Height.Text = string.Empty;
            Width.Text = string.Empty;
            Deep.Text = string.Empty;
            FPrice.Text = string.Empty;
            MPrice.Text = string.Empty;
        }

        private void Add_Load(object sender, EventArgs e)
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
