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
    public partial class FrmStatistics : Form
    {
        EgitimKampiEfTravelDbEntities1 db = new EgitimKampiEfTravelDbEntities1();
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region En Son Eklenen Ülke Kodu 
            var maxLocationId = db.TblLocation.Max(x => x.LocationId).ToString();
            var lastCountry = db.TblLocation.Where(x => x.LocationId.ToString() == maxLocationId)
                              .Select(x => x.Country)
                              .FirstOrDefault();
            #endregion

            #region Roma Gezisinin Rehberinin İsmi Kodu
            var romeGuidId = db.TblLocation.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            #endregion

            #region En Yüksek Kapasiteli Tur Kodu
            var maxCapacity = db.TblLocation.Max(x => x.Capacity);
            #endregion

            #region En Pahalı Tur
            var mostExpensiveTour = db.TblLocation.Max(x => x.Price);
            #endregion

            #region Ayşegül Çınar Adlı Rehberin Tur Sayısı Kodu
            var guideIdCount = db.TblLocation.Where(x => x.GuideId == 2).Count();
            #endregion

            lblLocationCount.Text = db.TblLocation.Count().ToString();
            lblSumCapacity.Text = ((decimal)db.TblLocation.Sum(x => x.Capacity)).ToString("F2");
            lblGuideCount.Text = db.TblGuide.Count().ToString();
            lblAverageCapacity.Text = db.TblLocation.Average(x => x.Capacity).ToString();
            lblAverageTourPrice.Text = (db.TblLocation.Average(x => x.Price) ?? 0).ToString("F2") + " ₺";
            lblCapadociaCapacity.Text = db.TblLocation.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkeyCapacityAverage.Text = db.TblLocation.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
            lblRomeGuideName.Text = db.TblGuide.Where(x => x.GuideId == romeGuidId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault();
            lblMaxCapacityLocation.Text = db.TblLocation.Where(x => x.Capacity == maxCapacity).Select(y => y.Country + " " + y.City).FirstOrDefault().ToString();
            lblMostExpensiveTour.Text = db.TblLocation.Where(x => x.Price == mostExpensiveTour).Select(y => y.Country + " " + y.City).FirstOrDefault().ToString();
            lblGuideLocationCount.Text = guideIdCount.ToString();
            lblLastCountryName.Text = lastCountry;


        }









       
    }
}
