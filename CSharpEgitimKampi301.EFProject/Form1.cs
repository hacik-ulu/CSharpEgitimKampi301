using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        private readonly EgitimKampiEfTravelDbEntities1 _db;
        public Form1(EgitimKampiEfTravelDbEntities1 db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _db.TblGuide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _db.TblGuide.Add(new TblGuide
            {
                GuideName = txtName.Text,
                GuideSurname = txtSurname.Text,
            });
            _db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = _db.TblGuide.Find(id);
            _db.TblGuide.Remove(values);
            _db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silindi!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = _db.TblGuide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname = txtSurname.Text;
            _db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Güncellendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = _db.TblGuide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
