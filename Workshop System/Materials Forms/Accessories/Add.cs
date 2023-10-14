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

namespace Workshop_System.Materials_Forms.Accessories
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            
        }

        private void add_Load(object sender, EventArgs e)
        {
            AName.Text = string.Empty;
            Size.Text = string.Empty;
            Category.Text = string.Empty;
            Price.Text = string.Empty;
            Color.Text = string.Empty;
            Type.Text = string.Empty;
            Status.Text = string.Empty;
        }

        private void Insert_Click_1(object sender, EventArgs e)
        {
            AccessoriesClass accessoriesClass = new AccessoriesClass();
            string SName = AName.Text;
            string SSize = Size.Text;
            string SCategory = Category.Text;
            string SPrice = Price.Text;
            string SColor = Color.Text;
            string SType = Type.Text;
            string SStatus = Status.Text;
            if (!string.IsNullOrEmpty(SName) && !string.IsNullOrEmpty(SCategory) && !string.IsNullOrEmpty(SSize) && !string.IsNullOrEmpty(SPrice) && !string.IsNullOrEmpty(SColor) && !string.IsNullOrEmpty(SType) && !string.IsNullOrEmpty(SStatus))
            {
                accessoriesClass.Name = SName;
                accessoriesClass.Size = float.Parse(SSize);
                accessoriesClass.Category = SCategory;
                accessoriesClass.Price = float.Parse(SPrice);
                accessoriesClass.Color = SColor;
                accessoriesClass.Type = SType;
                accessoriesClass.Status = SStatus;
                if (accessoriesClass.Insert())
                {
                    MessageBox.Show("تم جفظ البيانات بنجاح ");
                    AName.Text = string.Empty;
                    Size.Text = string.Empty;
                    Category.Text = string.Empty;
                    Price.Text = string.Empty;
                    Color.Text = string.Empty;
                    Type.Text = string.Empty;
                    Status.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("عفوا لم يتم حفظ البيانات حاول مرة اخري");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع البيانات");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
