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
    public partial class NewFormLocation : Form
    {
        public NewFormLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void NewFormLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new 
            {
                FullName=x.GuideName+ " " + x.GuideSurname,
                x.GuideId,
            }
            ).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            location.LocationCity = txtCity.Text;
            location.LocationCountry = txtCountry.Text;
            location.LocationPrice = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Lokasyon ekleme işlemi yapıldı.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Lokasyon silme işlemi yapıldı.", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.LocationPrice = decimal.Parse(txtPrice.Text);
            updatedValue.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            updatedValue.LocationCity= txtCity.Text;
            updatedValue.LocationCountry= txtCountry.Text;
            updatedValue.GuideId=int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Lokasyon güncelleme işlemi yapıldı.");
        }
    }
}
