
namespace SiteParameter
{
    partial class FormParameter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonTypeGtb = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeWindTurbine = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeDataCenter = new System.Windows.Forms.RadioButton();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreateSite = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSiteName = new System.Windows.Forms.TextBox();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.labelImg = new System.Windows.Forms.Label();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.buttonImg = new System.Windows.Forms.Button();
            this.pictureBoxSite = new System.Windows.Forms.PictureBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.groupBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSite)).BeginInit();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(1, 2);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1018, 1050);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            this.gMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseClick);
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonTypeGtb);
            this.groupBoxType.Controls.Add(this.radioButtonTypeWindTurbine);
            this.groupBoxType.Controls.Add(this.radioButtonTypeDataCenter);
            this.groupBoxType.Font = new System.Drawing.Font("Palatino Linotype", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxType.Location = new System.Drawing.Point(1495, 509);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(274, 246);
            this.groupBoxType.TabIndex = 30;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Type";
            // 
            // radioButtonTypeGtb
            // 
            this.radioButtonTypeGtb.AutoSize = true;
            this.radioButtonTypeGtb.Location = new System.Drawing.Point(34, 147);
            this.radioButtonTypeGtb.Name = "radioButtonTypeGtb";
            this.radioButtonTypeGtb.Size = new System.Drawing.Size(85, 32);
            this.radioButtonTypeGtb.TabIndex = 9;
            this.radioButtonTypeGtb.Text = "GTB";
            this.radioButtonTypeGtb.UseVisualStyleBackColor = true;
            this.radioButtonTypeGtb.CheckedChanged += new System.EventHandler(this.radioButtonTypeGtb_CheckedChanged);
            // 
            // radioButtonTypeWindTurbine
            // 
            this.radioButtonTypeWindTurbine.AutoSize = true;
            this.radioButtonTypeWindTurbine.Checked = true;
            this.radioButtonTypeWindTurbine.Location = new System.Drawing.Point(34, 48);
            this.radioButtonTypeWindTurbine.Name = "radioButtonTypeWindTurbine";
            this.radioButtonTypeWindTurbine.Size = new System.Drawing.Size(170, 32);
            this.radioButtonTypeWindTurbine.TabIndex = 8;
            this.radioButtonTypeWindTurbine.TabStop = true;
            this.radioButtonTypeWindTurbine.Text = "Wind turbine";
            this.radioButtonTypeWindTurbine.UseVisualStyleBackColor = true;
            this.radioButtonTypeWindTurbine.CheckedChanged += new System.EventHandler(this.radioButtonTypeWindTurbine_CheckedChanged);
            // 
            // radioButtonTypeDataCenter
            // 
            this.radioButtonTypeDataCenter.AutoSize = true;
            this.radioButtonTypeDataCenter.Location = new System.Drawing.Point(34, 98);
            this.radioButtonTypeDataCenter.Name = "radioButtonTypeDataCenter";
            this.radioButtonTypeDataCenter.Size = new System.Drawing.Size(153, 32);
            this.radioButtonTypeDataCenter.TabIndex = 6;
            this.radioButtonTypeDataCenter.Text = "DataCenter";
            this.radioButtonTypeDataCenter.UseVisualStyleBackColor = true;
            this.radioButtonTypeDataCenter.CheckedChanged += new System.EventHandler(this.radioButtonTypeDataCenter_CheckedChanged);
            // 
            // labelStreet
            // 
            this.labelStreet.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreet.Location = new System.Drawing.Point(1112, 343);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(260, 35);
            this.labelStreet.TabIndex = 29;
            this.labelStreet.Text = "Rue";
            this.labelStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStreet.Location = new System.Drawing.Point(1108, 382);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(264, 44);
            this.textBoxStreet.TabIndex = 3;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(1112, 239);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(260, 36);
            this.labelDescription.TabIndex = 27;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(1108, 278);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(264, 44);
            this.textBoxDescription.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Palatino Linotype", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(1568, 861);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(198, 80);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreateSite
            // 
            this.buttonCreateSite.Font = new System.Drawing.Font("Palatino Linotype", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSite.Location = new System.Drawing.Point(1309, 861);
            this.buttonCreateSite.Name = "buttonCreateSite";
            this.buttonCreateSite.Size = new System.Drawing.Size(198, 80);
            this.buttonCreateSite.TabIndex = 9;
            this.buttonCreateSite.Text = "Save";
            this.buttonCreateSite.UseVisualStyleBackColor = true;
            this.buttonCreateSite.Click += new System.EventHandler(this.buttonCreateSite_Click);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(1112, 125);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(260, 36);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Nom du site";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSiteName
            // 
            this.textBoxSiteName.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSiteName.Location = new System.Drawing.Point(1108, 168);
            this.textBoxSiteName.Name = "textBoxSiteName";
            this.textBoxSiteName.Size = new System.Drawing.Size(264, 44);
            this.textBoxSiteName.TabIndex = 1;
            // 
            // labelLongitude
            // 
            this.labelLongitude.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLongitude.Location = new System.Drawing.Point(1489, 363);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(260, 50);
            this.labelLongitude.TabIndex = 21;
            this.labelLongitude.Text = "Longitude";
            this.labelLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLatitude
            // 
            this.labelLatitude.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatitude.Location = new System.Drawing.Point(1489, 249);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(260, 46);
            this.labelLatitude.TabIndex = 20;
            this.labelLatitude.Text = "Latitude";
            this.labelLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(1025, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(997, 69);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Formulaire d\'ajout de site";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLongitude.Location = new System.Drawing.Point(1485, 416);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(264, 44);
            this.textBoxLongitude.TabIndex = 9;
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLatitude.Location = new System.Drawing.Point(1485, 298);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(264, 44);
            this.textBoxLatitude.TabIndex = 8;
            // 
            // labelImg
            // 
            this.labelImg.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImg.Location = new System.Drawing.Point(1489, 131);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(260, 36);
            this.labelImg.TabIndex = 32;
            this.labelImg.Text = "Image";
            this.labelImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImagePath.Location = new System.Drawing.Point(1485, 170);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(264, 44);
            this.textBoxImagePath.TabIndex = 7;
            // 
            // buttonImg
            // 
            this.buttonImg.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImg.Location = new System.Drawing.Point(1763, 170);
            this.buttonImg.Name = "buttonImg";
            this.buttonImg.Size = new System.Drawing.Size(53, 44);
            this.buttonImg.TabIndex = 33;
            this.buttonImg.Text = "...";
            this.buttonImg.UseVisualStyleBackColor = true;
            this.buttonImg.Click += new System.EventHandler(this.buttonImg_Click);
            // 
            // pictureBoxSite
            // 
            this.pictureBoxSite.Location = new System.Drawing.Point(1859, 119);
            this.pictureBoxSite.Name = "pictureBoxSite";
            this.pictureBoxSite.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSite.TabIndex = 34;
            this.pictureBoxSite.TabStop = false;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostalCode.Location = new System.Drawing.Point(1112, 450);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(260, 35);
            this.labelPostalCode.TabIndex = 36;
            this.labelPostalCode.Text = "Code postal";
            this.labelPostalCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostalCode.Location = new System.Drawing.Point(1108, 489);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(264, 44);
            this.textBoxPostalCode.TabIndex = 4;
            // 
            // labelCity
            // 
            this.labelCity.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(1112, 544);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(260, 35);
            this.labelCity.TabIndex = 38;
            this.labelCity.Text = "Ville";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(1108, 583);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(264, 44);
            this.textBoxCity.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(1112, 672);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(260, 35);
            this.labelPhone.TabIndex = 40;
            this.labelPhone.Text = "Phone";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(1108, 711);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(264, 44);
            this.textBoxPhone.TabIndex = 6;
            // 
            // FormParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2026, 1049);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.pictureBoxSite);
            this.Controls.Add(this.buttonImg);
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.textBoxImagePath);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreateSite);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSiteName);
            this.Controls.Add(this.labelLongitude);
            this.Controls.Add(this.labelLatitude);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxLongitude);
            this.Controls.Add(this.textBoxLatitude);
            this.Controls.Add(this.gMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormParameter";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormParameter_Load);
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioButtonTypeWindTurbine;
        private System.Windows.Forms.RadioButton radioButtonTypeDataCenter;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreateSite;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSiteName;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.Label labelImg;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.Button buttonImg;
        private System.Windows.Forms.PictureBox pictureBoxSite;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.RadioButton radioButtonTypeGtb;
    }
}