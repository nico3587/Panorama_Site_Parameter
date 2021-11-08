using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SiteParameter
{
    public partial class FormParameter : Form
    {
        public delegate void CreateSiteEventHandler(object source, EventArgs e);
        public delegate void CancelEventHandler(object source, EventArgs e);

        public event CreateSiteEventHandler buttonCreateSite_ClickEvent;
        public event CancelEventHandler buttonCancel_ClickEvent;

        public Dictionary<string, string> site = new Dictionary<string, string>();

        public static GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
        private class ConfigSite
        {
            string siteName { get; set; }
        }
        public FormParameter()
        {
            InitializeComponent();
            site.Add("siteName", "");
            site.Add("description", "");
            site.Add("addressStreet", "");
            site.Add("addressPostalCode", "");
            site.Add("addressCity", "");
            site.Add("phone", "");
            site.Add("latitude", "");
            site.Add("longitude", "");
            site.Add("imagePath", "");
            site.Add("type", "");
        }

        private void FormParameter_Load(object sender, EventArgs e)
        {
            double latitude = 48.8617774, longitude = 2.349272;

            this.Width = 1050;

            textBoxSiteName.Text = site["siteName"];
            textBoxDescription.Text = site["description"];
            textBoxStreet.Text = site["addressStreet"];
            textBoxPostalCode.Text = site["addressPostalCode"];
            textBoxCity.Text = site["addressCity"];
            textBoxPhone.Text = site["phone"];
            textBoxLatitude.Text = site["latitude"];
            textBoxLongitude.Text = site["longitude"];
            textBoxImagePath.Text = site["imagePath"];

            switch (site["type"])
            {
                case "WindTurbine":
                    radioButtonTypeWindTurbine.Checked = true;
                    radioButtonTypeWindTurbine.Enabled = false;
                    radioButtonTypeDataCenter.Enabled = false;
                    radioButtonTypeGtb.Enabled = false;
                    break;
                case "DataCenter":
                    radioButtonTypeDataCenter.Checked = true;
                    radioButtonTypeDataCenter.Enabled = false;
                    radioButtonTypeWindTurbine.Enabled = false;
                    radioButtonTypeGtb.Enabled = false;
                    break;
                case "GTB":
                    radioButtonTypeGtb.Checked = true;
                    radioButtonTypeGtb.Enabled = false;
                    radioButtonTypeWindTurbine.Enabled = false;
                    radioButtonTypeDataCenter.Enabled = false;
                    break;
                default:
                    site["type"] = "WindTurbine";
                    break;
            }

            if (site["imagePath"] != "")
            {
                using (FileStream fs = new FileStream(@site["imagePath"], FileMode.Open))
                {
                    pictureBoxSite.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }
                //pictureBoxSite.Image = Image.FromFile(@site["imagePath"]);

            //gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            //gMap.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            gMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            if (site["latitude"] != "")
                latitude = Convert.ToDouble(site["latitude"]);

            if (site["longitude"] != "")
                longitude = Convert.ToDouble(site["longitude"]);

            GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(latitude, longitude), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker);
            gMap.Overlays.Add(markers);

            gMap.MinZoom = 0;
            gMap.MaxZoom = 30;
            // whole world zoom
            gMap.Zoom = 4;
            // lets the map use the mousewheel to zoom
            gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            // lets the user drag the map
            gMap.CanDragMap = true;
            // lets the user drag the map with the left mouse button
            gMap.DragButton = MouseButtons.Left;
        }

        private void gMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                double lat = gMap.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gMap.FromLocalToLatLng(e.X, e.Y).Lng;
                textBoxLatitude.Text = lat.ToString();
                textBoxLongitude.Text = lng.ToString();

                GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(lat, lng), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
                markers.Markers.Clear();
                markers.Markers.Add(marker);
                gMap.Overlays.Add(markers);
            }
        }

        private void buttonCreateSite_Click(object sender, EventArgs e)
        {
            site["siteName"] = textBoxSiteName.Text;
            site["description"] = textBoxDescription.Text;
            site["addressStreet"] = textBoxStreet.Text;
            site["addressPostalCode"] = textBoxPostalCode.Text;
            site["addressCity"] = textBoxCity.Text;
            site["phone"] = textBoxPhone.Text;
            site["latitude"] = textBoxLatitude.Text;
            site["longitude"] = textBoxLongitude.Text;
            site["imagePath"] = textBoxImagePath.Text;

            buttonCreateSite_ClickEvent?.Invoke(this, EventArgs.Empty);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonCancel_ClickEvent?.Invoke(this, EventArgs.Empty);
        }

        private void buttonImg_Click(object sender, EventArgs e)
        {
            //var filePath = string.Empty;

            using (OpenFileDialog openFileDialog= new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxImagePath.Text = openFileDialog.FileName;
                    pictureBoxSite.Image = Image.FromFile(@openFileDialog.FileName);
                }
            }
        }

        public void SendMsgBox(string text)
        {
            MessageBox.Show(text, "Erreur sur le formulaire", MessageBoxButtons.OK);
        }

        private void radioButtonTypeWindTurbine_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTypeWindTurbine.Checked)
            {
                site["type"] = "WindTurbine";
            }
        }

        private void radioButtonTypeDataCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTypeDataCenter.Checked)
            {
                site["type"] = "DataCenter";
            }
        }

        private void radioButtonTypeGtb_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTypeGtb.Checked)
            {
                site["type"] = "GTB";
            }
        }
    }
}
