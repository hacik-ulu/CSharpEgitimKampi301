using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        private readonly EgitimKampiEfTravelDbEntities1 _db;
        private readonly TblLocation _tblLocation;
        public FrmLocation(EgitimKampiEfTravelDbEntities1 db, TblLocation tblLocation)
        {
            InitializeComponent();
            _db = db;
            _tblLocation = tblLocation;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _db.TblLocation.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = _db.TblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();

            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _tblLocation.Capacity = byte.Parse(nudCapacity.Value.ToString());
            _tblLocation.City = txtCity.Text;
            _tblLocation.Country = txtCountry.Text;
            _tblLocation.Price = decimal.Parse(txtPrice.Text);
            _tblLocation.DayNight = txtDayNight.Text;
            _tblLocation.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            _db.TblLocation.Add(_tblLocation);
            _db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarıyla Gerçekleştirildi");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = _db.TblLocation.Find(id);
            _db.TblLocation.Remove(deletedValue);
            _db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = _db.TblLocation.Find(id);
            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updatedValue.City = txtCity.Text;
            updatedValue.Country = txtCountry.Text;
            updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            _db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleştirildi!");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = _db.TblLocation.Where(x => x.LocationId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
