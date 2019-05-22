using OtelOtomasyonu.ORM.Entities;
using OtelOtomasyonu.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu.WinFormUI
{
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }
        KasaORM kasaOrm = new KasaORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kasa ksa = new Kasa();
            ksa.Adi = txtKasaAdi.Text;
            ksa.Aciklama = txtAciklama.Text;
            bool sonuc = kasaOrm.Insert(ksa);
            if (sonuc)
            {
                MessageBox.Show("Kasa ekleme başarılı");
                dtgrKasa.DataSource = kasaOrm.Select();
            }
            else
                MessageBox.Show("Kasa ekleme başarısiz");
        }

        private void frmKasa_Load(object sender, EventArgs e)
        {
            dtgrKasa.DataSource = kasaOrm.Select();
        }
    }
}
