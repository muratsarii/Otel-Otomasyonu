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
    public partial class frmBirimTip : Form
    {
        public frmBirimTip()
        {
            InitializeComponent();
        }
        BirimTipORM birimtipOrm = new BirimTipORM();
        private void frmBirimTip_Load(object sender, EventArgs e)
        {
            dtgrBirimTip.DataSource = birimtipOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BirimTipleri birimTipleri = new BirimTipleri();
            birimTipleri.Adi = txtBirimTipleriAdi.Text;
            bool sonuc = birimtipOrm.Insert(birimTipleri);
            if (sonuc)
            {
                MessageBox.Show("Birim tip ekleme başarılı");
                dtgrBirimTip.DataSource = birimtipOrm.Select();
            }
            else
                MessageBox.Show("Birim tip ekleme başarısız");
        }
    }
}
