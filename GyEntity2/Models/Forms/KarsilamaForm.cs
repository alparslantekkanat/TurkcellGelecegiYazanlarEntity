using GyEntity2.Data;
using GyEntity2.Forms;
using GyEntity2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GyEntity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //eticaretDbContext db = new eticaretDbContext();
            //db.Database.EnsureCreated();

            //var allContext = db.Categories.Include(c => c.Name)
            //                                .Include(C=>C.Products)

            //var allContext = db.Products.Include(x => x.Category)
            //                            .Include(y => y.Name)
            //                            .Include(z => z.Price);

            //var data = allContext.Select(x => new
            //{
            //    UrunAdi=x.Name,
            //    UrunKategori=x.Category,
            //    UrunPrice=x.Price,
                

            //});

            //var list =data.ToList();
            //dataGridView1.DataSource = list;
        }

        private void UrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkleForm urunEkleForm = new UrunEkleForm();
            urunEkleForm.Show();
        }

        private void KisiEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm kullaniciEkleForm = new KullaniciEkleForm();
            kullaniciEkleForm.Show();
        }

        private void alisveris_Click(object sender, EventArgs e)
        {
            AlisverisForm alisverisForm = new AlisverisForm();
            alisverisForm.Show();
        }
    }
}
