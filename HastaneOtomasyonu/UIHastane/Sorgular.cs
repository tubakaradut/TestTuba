using DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIHastane
{
    public partial class Sorgular : Form
    {
        public Sorgular()
        {
            InitializeComponent();
        }
        HastaneOtomasyonuEntities db = new HastaneOtomasyonuEntities();
        private void Sorgular_Load(object sender, EventArgs e)
        {
            //1.select BransId,COUNT(BransId) from Doktor group by BransId

            var result = db.Doktor.GroupBy(x => x.Brans.BransAd).Select(x =>
               new { Brans = x.Key, DoktorSayısı = x.Count() }).ToList();
            foreach (var doktor in result)
            {
                listBox1.Items.Add($" Brans: {doktor.Brans} -- Doktor Sayısı: {doktor.DoktorSayısı}");
            }

            //2.
           
            var result2 = db.Randevu.GroupBy(x => x.Brans.BransAd).Select(x => new
            {
                Brans = x.Key,
                HastaSayısı = x.Count()
            }).ToList();

            foreach (var item in result2)
            {
                listBox2.Items.Add($"Brans: {item.Brans} -- Hasta Sayısı: {item.HastaSayısı}");
            }

            //3.// select d.DoktorAd, d.DoktorSoyad, b.BransAd, r.RandevuTarih,r.RandevuSaat, h.HastaAd,h.HastaSoyad
            //    from Randevu r
            //join Brans b on b.Id = r.BransId
            //join Doktor d on r.DoktorId = d.Id
            //join Hasta h on h.Id = r.HastaId

            var result3 = db.Randevu.Select(x => new
            {
                HastaAdSoyad = x.Hasta.HastaAd + " " + x.Hasta.HastaSoyad,
                DoktorAdSoyad=x.Doktor.DoktorAd+" "+x.Doktor.DoktorSoyad,
                x.RandevuTarih,
                x.RandevuSaat,
                x.Brans.BransAd

            });
            listBox3.DataSource = result3.ToList();

            //4.
            var result4 = db.Randevu.GroupBy(x => x.RandevuTarih).Select(x => new
            {
                RandevuTarih = x.Key,
                HastaSayısı = x.Count()
                
            }) ;
           listBox4.DataSource = result4.ToList();

            ////5.select b.BransAd, r.RandevuTarih,count(r.HastaId) as 'Hasta Sayısı'
            //from Randevu r
            //join Brans b on b.Id = r.BransId
            //group by b.BransAd, r.RandevuTarih


                        var result5 = from r in db.Randevu
                                      join b in db.Brans on r.BransId equals b.Id
                                      group r by r.HastaId into g
                                      select new
                                      {
                                          BransAd = g.FirstOrDefault().Brans.BransAd,
                                          RandevuTarih = g.FirstOrDefault().RandevuTarih,
                                          HastaSayısı = g.Count()
                                      };
            foreach (var item in result5)
            {
                listBox5.Items.Add($"Brans:{item.BransAd}--Randevu Tarihi:{item.RandevuTarih}--Hasta Sayısı:{item.HastaSayısı}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

