using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Workshop_System.App_Class;
using Workshop_System.Materials_Forms;
using Workshop_System.App_Class.Offer_Prices.Windows;
using Workshop_System.App_Class.Discounts_Classes;
using Workshop_System.App_Class.Offer_Prices;

namespace Workshop_System.Offer_Price_Forms.Windows
{
    public partial class WindowsOfferPrice : Form
    {
        OfferPriceWindows offerpricewindows = new OfferPriceWindows();
        int RowNum = 1;
        public WindowsOfferPrice()
        {
            InitializeComponent();
            Update();
        }
        public WindowsOfferPrice(int S)
        {
            InitializeComponent();
            offerpricewindows.OfferID = S;
            OfferID.Text = Convert.ToString(offerpricewindows.OfferID);
            Update();
        }
        public void Update()
        {
            DataBase DB = new DataBase("Materials", "Types");
            Section.DisplayMember = "Value";
            Section.ValueMember = "Value";
            if (DB.GetData("فرع العمل") != null)
            {
                Section.DataSource = DB.GetData("فرع العمل"); Section.Enabled = true;
            }
            else
                Section.Enabled = false;

            Type.DisplayMember = "Value";
            Type.ValueMember = "Value";
            if (DB.GetData("نوع العمل") != null)
            {
                Type.DataSource = DB.GetData("نوع العمل"); Type.Enabled = true;
            }
            else
                Type.Enabled = false;

            
            Desciption.DisplayMember = "Value";
            Desciption.ValueMember = "Value";
            if (DB.GetData("وصف العمل") != null)
            {
                Desciption.DataSource = DB.GetData("وصف العمل"); Desciption.Enabled = true;
            }
            else
                Desciption.Enabled = false;

            RollsNumber.DisplayMember = "Value";
            RollsNumber.ValueMember = "Value";
            if (DB.GetData("عدد الدرفات") != null)
            {
                RollsNumber.DataSource = DB.GetData("عدد الدرفات"); RollsNumber.Enabled = true;
            }
            else
                RollsNumber.Enabled = false;
        }
        private void Details_Click(object sender, EventArgs e)
        {
            Details NewForm = new Details();
            NewForm.ShowDialog();
            Update();
        }
        private void AddWindow_Click(object sender, EventArgs e)
        {
            string SHeight = Height.Text;
            string SWidth = Width.Text;
            string SNumber = Number.Text;
            string SSection = Section.Text;
            string SType = Type.Text;
            string SDescription = Desciption.Text;
            string SRollsNumber  = RollsNumber.Text;
            string SALPrice = AlPrice.Text;
            if (!string.IsNullOrEmpty(SHeight)
                && !string.IsNullOrEmpty(SWidth)
                && !string.IsNullOrEmpty(SNumber)
                && !string.IsNullOrEmpty(SSection)
                && !string.IsNullOrEmpty(SType)
                && !string.IsNullOrEmpty(SDescription)
                && !string.IsNullOrEmpty(SRollsNumber)
                && !string.IsNullOrEmpty(SALPrice))
            {
                offerpricewindows.Height = float.Parse(SHeight);
                offerpricewindows.Width = float.Parse(SWidth);
                offerpricewindows.Area = ((float.Parse(SHeight)/100) * (float.Parse(SWidth)/100));
                offerpricewindows.Number = Convert.ToInt32(SNumber);
                offerpricewindows.ALPrice = float.Parse(SALPrice);
                offerpricewindows.Rolls = int.Parse(SRollsNumber);
                offerpricewindows.GState = SDescription;
                offerpricewindows.RowNumber = RowNum;
                WindowsClass windowsclass = new WindowsClass();
                windowsclass.Category = "شبابيك";
                windowsclass.Section = SSection;
                windowsclass.Description = SDescription;
                windowsclass.Type = SType;
                windowsclass.RollsNumber = Convert.ToInt32(SRollsNumber);
                int Discountid = windowsclass.ReturnID();
                if(Discountid > 0)
                {
                    offerpricewindows.DiscountID = Discountid;
                    if (offerpricewindows.Insert())
                    {
                        MessageBox.Show("تم الاضافة بنجاح");
                        SelectedRows.DataSource = offerpricewindows.GetData();
                        Total.Text = offerpricewindows.TotalPrice().ToString();
                        RowNum++;
                    }
                    else
                    {
                        MessageBox.Show("عفوا لم تتم عملية الاضافة بنجاح");
                    }
                }
                else
                {
                    MessageBox.Show("عفوا لا يوجد تخصيمي لهذا الشباك");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع البيانات المطلوبة ");
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Height.Text = string.Empty;
            Width.Text = string.Empty;
            Number.Text = string.Empty;
            Section.SelectedItem = null;
            Type.SelectedItem = null;
            Desciption.SelectedItem = null;
            RollsNumber.SelectedItem = null;
        }
        private void SelectedRows_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            SelectedID.Text = SelectedRows.Rows[index].Cells[8].Value.ToString();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            string id = SelectedID.Text;
            if (!string.IsNullOrEmpty(id))
            {
                bool R = offerpricewindows.GetRow(id);
                if (R)
                {
                    Height.Text = offerpricewindows.Height.ToString();
                    Width.Text = offerpricewindows.Width.ToString();
                    Number.Text = offerpricewindows.Number.ToString();
                    RollsNumber.Text = offerpricewindows.windowsclass.RollsNumber.ToString();
                    Section.Text = offerpricewindows.windowsclass.Section.ToString();
                    Desciption.Text = offerpricewindows.windowsclass.Description.ToString();
                    Type.Text = offerpricewindows.windowsclass.Type.ToString();
                }
                else
                {
                    MessageBox.Show("عفوا حدث خطا ما");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب اختيار شباك للتعديل");
            }
        }
        private void Editing_Click(object sender, EventArgs e)
        {
            string SHeight = Height.Text;
            string SWidth = Width.Text;
            string SNumber = Number.Text;
            string SSection = Section.Text;
            string SType = Type.Text;
            string SDescription = Desciption.Text;
            string SRollsNumber = RollsNumber.Text;
            string SALPrice = AlPrice.Text;
            if (!string.IsNullOrEmpty(SHeight)
                && !string.IsNullOrEmpty(SWidth)
                && !string.IsNullOrEmpty(SNumber)
                && !string.IsNullOrEmpty(SSection)
                && !string.IsNullOrEmpty(SType)
                && !string.IsNullOrEmpty(SDescription)
                && !string.IsNullOrEmpty(SRollsNumber)
                && !string.IsNullOrEmpty(SALPrice))
            {
                offerpricewindows.Height = float.Parse(SHeight);
                offerpricewindows.Width = float.Parse(SWidth);
                offerpricewindows.Area = ((float.Parse(SHeight) / 100) * (float.Parse(SWidth) / 100));
                offerpricewindows.Number = Convert.ToInt32(SNumber);
                offerpricewindows.ALPrice = float.Parse(SALPrice);
                offerpricewindows.Rolls = int.Parse(SRollsNumber);
                offerpricewindows.GState = SDescription;
                WindowsClass windowsclass = new WindowsClass();
                windowsclass.Category = "شبابيك";
                windowsclass.Section = SSection;
                windowsclass.Description = SDescription;
                windowsclass.Type = SType;
                windowsclass.RollsNumber = Convert.ToInt32(SRollsNumber);
                int Discountid = windowsclass.ReturnID();
                if (Discountid > 0)
                {
                    offerpricewindows.DiscountID = Discountid;
                    if (offerpricewindows.Update())
                    {
                        MessageBox.Show("تم التحديث بنجاح");
                        SelectedRows.DataSource = offerpricewindows.GetData();
                        Total.Text = offerpricewindows.TotalPrice().ToString();
                    }
                    else
                    {
                        MessageBox.Show("عفوا لم تتم عملية التحديث بنجاح");
                    }
                }
                else
                {
                    MessageBox.Show("عفوا لا يوجد تخصيمي لهذا الشباك");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع البيانات للتحديث ");
            }
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            string id = SelectedID.Text;
            if (!string.IsNullOrEmpty(id))
            {
                offerpricewindows.RowNumber = int.Parse(id);
                DialogResult result = MessageBox.Show("هل انت  متاكد من حذف المقاس", "رسالة تاكيدية ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    if (offerpricewindows.Remove())
                    {
                        MessageBox.Show("تم الحذف بنجاح");
                        Total.Text = offerpricewindows.TotalPrice().ToString();
                    }
                    else
                    {
                        MessageBox.Show("عفوا حدث خط ا ما");
                    }
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب اختيار شباك للتعديل");
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            offerpricewindows.offerprice.ID = offerpricewindows.OfferID;
            int TI = offerpricewindows.TotalItems();
            float TP = offerpricewindows.TotalPrice();
            bool Saving = offerpricewindows.offerprice.Increasing(TI, TP) ;
            bool Inc = offerpricewindows.offerprice.UpdateCustomrtID();
            if (Saving)
            {
                if (Inc)
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                }
                else
                {
                    MessageBox.Show("عفوا لم يتم الحفظ بنجاح1");
                }
            }
            else
            {
                MessageBox.Show("عفوا لم يتم الحفظ بنجاح2");
            }
        }
    }
}
