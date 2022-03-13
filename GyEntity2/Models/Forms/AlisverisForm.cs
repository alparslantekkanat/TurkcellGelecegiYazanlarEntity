using GyEntity2.Data;
using GyEntity2.Forms;
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
    public partial class AlisverisForm : Form
    {
        public AlisverisForm()
        {
            InitializeComponent();
        }

        eticaretDbContext context = new eticaretDbContext();

        public void AlisverisForm_Load(object sender, EventArgs e)
        {
            var listPro = context.Products.ToList();
            var listUser=context.Users.ToList();

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            
            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";
            foreach (var pro in listPro)
            {
                comboBox2.Items.Add(new {Text = pro.Name, Value=pro.Id});

            }
            foreach (var use in listUser)
            {
                comboBox1.Items.Add(new { Text = use.FullName, value = use.Id });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayiqu = int.Parse(textBox1.Text);
            Cart cart = new Cart
            {
                
                UserId = comboBox1.SelectedIndex +1,
                ProductId = comboBox2.SelectedIndex +1,
                Quantity = sayiqu,
            };
            context.Carts.Add(cart);
            int result = context.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
