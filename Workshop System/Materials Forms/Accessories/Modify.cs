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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string id = ID.Text;
            if(!string.IsNullOrEmpty(id)) 
            {
                string SName = AName.Text;
                string SSize = Size.Text;
                string SCategory = Category.Text;
                string SPrice = Price.Text;
                string SColor = Color.Text;
                string SType = Type.Text;
                string SStatus = Status.Text;
                if (!string.IsNullOrEmpty(SName) || !string.IsNullOrEmpty(SCategory) || !string.IsNullOrEmpty(SSize) || !string.IsNullOrEmpty(SPrice) || !string.IsNullOrEmpty(SColor) || !string.IsNullOrEmpty(SType) || !string.IsNullOrEmpty(SStatus))
                {
                    AccessoriesClass accessoriesClass  = new AccessoriesClass();
                    accessoriesClass.ID = Convert.ToInt32(id);
                    if(!string.IsNullOrEmpty(SName))
                        accessoriesClass.Name = SName;
                    if(!string.IsNullOrEmpty(SCategory))
                        accessoriesClass.Category = SCategory;
                    if(!string.IsNullOrEmpty(SSize))
                        accessoriesClass.Size = Convert.ToInt32(SSize);
                    if(!string.IsNullOrEmpty(SPrice))
                        accessoriesClass.Price = float.Parse(SPrice);
                    if (!string.IsNullOrEmpty(SColor))
                        accessoriesClass.Color = SColor;
                    if(!string.IsNullOrEmpty(SType))
                        accessoriesClass.Type = SType;
                    if(!string.IsNullOrEmpty(SStatus))
                        accessoriesClass.Status = SStatus;
                    if (accessoriesClass.Modify())
                    {
                        MessageBox.Show("تم تعديل البيانات بنجاح");
                    }
                    else
                    {
                        MessageBox.Show("عفوا حدث خطا في تحديث البيانات");
                    }
                }
                else
                {
                    MessageBox.Show("عفوا يجب ادخال بيانات للتعديل");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال الرقم الكودي اولا");
            }
        }
    }
}
