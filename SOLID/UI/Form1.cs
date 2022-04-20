using BLL.UserService;
using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjeContext db = new ProjeContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            User user = new User();
            Admin admin = new Admin();

            //Category c1 = new Category();
            //Category c2 = new Category();
            //Category c3 = new Category();

            //c1.CategoryName = "Giyim";
            //c2.CategoryName = "Teknoloji";
            //c3.CategoryName = "Takı";

            //admin.Create(c1);
            //admin.Create(c2);
            //admin.Create(c3);

            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = admin.GetCategoryList();



        }
        private void GetProductList()
        {
            listView1.Items.Clear();

            foreach (Product product in db.products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.Id.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitStock.ToString());
                lvi.SubItems.Add(product.Category.CategoryName);
                lvi.Tag = product;
                listView1.Items.Add(lvi);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            Product p = new Product();
            p.ProductName = txtProductName.Text;
            p.UnitPrice = nudUnitPrice.Value;
            p.UnitStock = Convert.ToInt16(nudUnitsInStock.Value);
            p.CategoryId = (int)cmbCategory.SelectedValue;
            admin.Create(p);
            GetProductList();
        }
        private void GetCategories()
        {
            listView2.Items.Clear();
            foreach (Category category in db.categories)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = category.Id.ToString();
                lvi.SubItems.Add(category.CategoryName);
                listView2.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            admin.Create(category);
            GetCategories();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetProductList();
            GetCategories();
        }
    }
}
