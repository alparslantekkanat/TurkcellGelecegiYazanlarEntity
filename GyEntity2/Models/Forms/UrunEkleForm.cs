using GyEntity2.Data;
using GyEntity2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GyEntity2.Forms
{
    public partial class UrunEkleForm : Form
    {
        public UrunEkleForm()
        {
            InitializeComponent();
        }

        eticaretDbContext context = new eticaretDbContext();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }



        private void UrunYukle_Click(object sender, EventArgs e)
        {

            int code1 = int.Parse(textBox2.Text);
            int price1 = int.Parse(textBox3.Text);
            Product product = new Product
            {
                Name = textBox1.Text,
                Code = code1,
                Price = price1,
                Description = textBox4.Text,
                CategoryId = comboBox1.SelectedIndex+1,

            };
            context.Products.Add(product);
            int result = context.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);
        }
        public void UrunEkleForm_Load(object sender, EventArgs e)
        {

            var listCat = context.Categories.ToList();

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            foreach (var cat in listCat)
            {
                comboBox1.Items.Add(new { Text = cat.Name, Value = cat.Id });
            }
        }
    }
}
