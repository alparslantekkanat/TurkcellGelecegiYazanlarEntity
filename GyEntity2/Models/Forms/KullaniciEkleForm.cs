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
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        eticaretDbContext context = new eticaretDbContext();

      

        
        public void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            var listBl = context.Bloods.ToList();
            var listCoun = context.Countries.ToList();
            var listGn = context.Genders.ToList();
            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";
            comboBox3.DisplayMember = "Text";
            comboBox3.ValueMember = "Value";
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            foreach (var coun in listCoun)
            {
                comboBox2.Items.Add(new { Text = coun.Name, Value = coun.Id });

            }
            foreach (var bl in listBl)
            {
                comboBox3.Items.Add(new { Text = bl.Name, Value = bl.Id });

            }
            foreach (var gn in listGn)
            {
                comboBox1.Items.Add(new { Text = gn.Name, Value = gn.Id });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = textBox1.Text,
                Surname = textBox2.Text,
                FullName = textBox3.Text,
                Mail = textBox4.Text,
                GSM = textBox5.Text,
                Address = textBox6.Text,
                GenderId = comboBox1.SelectedIndex+1,
                CountryId = comboBox2.SelectedIndex+1,
                BloodId = comboBox3.SelectedIndex+1,
            };
            context.Users.Add(user);
            int result = context.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var listBl = context.Bloods.ToList();
            //comboBox1.DisplayMember = "Text";
            //comboBox1.ValueMember = "Value";
            //foreach (var bl in listBl)
            //{
            //    comboBox1.Items.Add(new { Text = bl.Name, Value = bl.Id });

            //}
        }
    }
}
