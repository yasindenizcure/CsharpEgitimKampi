using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpEgitimKampi301.EFProject
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FormStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x=>x.LocationCapacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = $"{db.Location.Average(x => x.LocationCapacity):F2}";
            lblAvgLocationPrice.Text = $"{db.Location.Average(x => x.LocationPrice):F2}₺";
            int lastCountryId = db.Location.Max(x=>x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x=> x.LocationId==lastCountryId).Select(y=>y.LocationCountry).FirstOrDefault();
            lblKapadokyaLocationCapacity.Text = db.Location.Where(x => x.LocationCity == "Kapadokya").Select(y=>y.LocationCapacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.Location.Where(x=>x.LocationCountry=="Türkiye").Average(y=>y.LocationCapacity).ToString();

            var romeGuideId= db.Location.Where(x=>x.LocationCity=="Roma").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName+ " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x=> x.LocationCapacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x=>x.LocationCapacity==maxCapacity).Select(y => y.LocationCity).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.LocationPrice);
            lblMaxPriceLocation.Text = db.Location.Where(x=>x.LocationPrice==maxPrice).Select(y=>y.LocationCity).FirstOrDefault().ToString();

            var guideIdByNameMKocaman = db.Guide.Where(x=> x.GuideName=="Muhammet" &&  x.GuideSurname=="Kocaman").Select(y=>y.GuideId).FirstOrDefault();
            lblMKocamanLocationCount.Text = db.Location.Where(x=>x.GuideId==guideIdByNameMKocaman).Count().ToString();

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void lblLocationCount_Click(object sender, EventArgs e)
        {

        }
    }
}
