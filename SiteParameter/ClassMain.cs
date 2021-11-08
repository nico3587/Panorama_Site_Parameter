using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using CODRA.SDK.DotNetUtils.COM;
using CODRA.Panorama.Persist;
using System.Drawing;

namespace SiteParameter
{
    public class ClassMain : IObjectWithSite
    {
        private IPrsObject MyPrsObject;
        private IPrsObject NewPrsObject;
        private IPrsUnit MyPrsUnit;
        private IPrsApplication MyPrsApplication;
        private IPrsProperty MyProperty;
        private string MyFullName;

        FormParameter configForm = new FormParameter();

        

        public bool PropertiesEx(bool bIsInstance, int iWnd)
        {
            configForm.buttonCreateSite_ClickEvent += buttonCreateSite_Click;
            configForm.buttonCancel_ClickEvent += buttonCancel_Click;
            try
            {
                configForm.site["siteName"] = MyPrsObject.Value["siteName", 0];
                configForm.site["description"] = MyPrsObject.Value["description", 0];
                configForm.site["addressStreet"] = MyPrsObject.Value["addressStreet", 0];
                configForm.site["addressPostalCode"] = MyPrsObject.Value["addressPostalCode", 0];
                configForm.site["addressCity"] = MyPrsObject.Value["addressCity", 0];
                configForm.site["phone"] = MyPrsObject.Value["phone", 0];
                configForm.site["latitude"] = MyPrsObject.Value["latitude", 0];
                configForm.site["longitude"] = MyPrsObject.Value["longitude", 0];
                configForm.site["imagePath"] = MyPrsObject.Value["imagePath", 0];
                switch (MyPrsObject.Value["type", 0])
                {
                    case "WindTurbine":
                        configForm.site["type"] = "WindTurbine";
                        break;
                    case "DataCenter":
                        configForm.site["type"] = "DataCenter";
                        break;
                    case "GTB":
                        configForm.site["type"] = "GTB";
                        break;
                    default:
                        break;
                }

            }
            catch
            {

            }
            configForm.ShowDialog();
            return true;
        }

        private void SetProperty(string property)
        {
            try
            {
                MyProperty = MyPrsObject.ClassEx.OwnPropertiesEx.get_ItemEx(property);
                MyPrsObject.Value[property, 0] = configForm.site[property];
            }
            catch
            {
                MyProperty = MyPrsObject.ClassEx.OwnPropertiesEx.AddEx(property);
                MyProperty.Type = PropType.T_STRING;
                MyProperty.Categorie = PropCategory.C_CARACTERISTIC;
                MyPrsObject.Value[property, 0] = configForm.site[property];
            }
        }

        public void buttonCreateSite_Click (Object source, EventArgs e)
        {
            string errorMessage = "";

            if (configForm.site["siteName"] == "")
                errorMessage = errorMessage + "Nom du site, ";
            if (configForm.site["description"] == "")
                errorMessage = errorMessage + "description, ";
            if (configForm.site["addressStreet"] == "")
                errorMessage = errorMessage + "Rue, ";
            if (configForm.site["addressPostalCode"] == "")
                errorMessage = errorMessage + "code postal, ";
            if (configForm.site["addressCity"] == "")
                errorMessage = errorMessage + "ville, ";
            if (configForm.site["phone"] == "")
                errorMessage = errorMessage + "téléphone, ";
            if (configForm.site["latitude"] == "")
                errorMessage = errorMessage + "latitude, ";
            if (configForm.site["longitude"] == "")
                errorMessage = errorMessage + "longitude, ";
            if (configForm.site["imagePath"] == "")
                errorMessage = errorMessage + "image, ";

            if (errorMessage != "")
            {
                errorMessage = errorMessage.Substring(0, errorMessage.Length - 2) + ".";
                configForm.SendMsgBox($"Il manque les champs suivant : {errorMessage}");
            }
            else
            {
                //Add site ID property
                SetProperty("siteName");
                SetProperty("description");
                SetProperty("addressStreet");
                SetProperty("addressPostalCode");
                SetProperty("addressCity");
                SetProperty("phone");
                SetProperty("latitude");
                SetProperty("longitude");
                SetProperty("type");

                //Save site image to disk
                string imagePath = @MyPrsApplication.Name + @"\IMAGES\" + configForm.site["siteName"] + ".jpg";
                if (imagePath != configForm.site["imagePath"])
                {
                    if (System.IO.File.Exists(imagePath))
                        System.IO.File.Delete(imagePath);

                    Image image = Image.FromFile(configForm.site["imagePath"]);
                    new Bitmap(image, 95, 95).Save(imagePath);
                }

                //Set image path property
                configForm.site["imagePath"] = imagePath;
                SetProperty("imagePath");
                
                switch (configForm.site["type"])
                {
                    case "WindTurbine":
                        CreateWindTurbineApp();
                        break;
                    case "DataCenter":
                        CreateDataCenterApp();
                        break;
                    case "GTB":
                        CreateGtbApp();
                        break;
                    default:
                        break;
                }

                configForm.Close();
            }
        }

        private void CreateWindTurbineApp()
        {
            //Create site unit
            try
            {
                MyPrsUnit = MyPrsApplication.UnitsEx.get_ItemEx(MyPrsObject.Name);
            }
            catch
            {
                MyPrsUnit = MyPrsApplication.UnitsEx.AddEx(MyPrsObject.Name);
            }
            //Instatiate components
            try
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.get_ItemEx("Farm_Est");
            }
            catch
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.AddEx("Farm_Est");
                NewPrsObject.ModuleName = "WindTurbine";
                NewPrsObject.ClassName = "Farm";
                NewPrsObject.Value["Label", 0] = "Ferme Est";
            }
            try
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.get_ItemEx("Farm_North");
            }
            catch
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.AddEx("Farm_North");
                NewPrsObject.ModuleName = "WindTurbine";
                NewPrsObject.ClassName = "Farm";
                NewPrsObject.Value["Label", 0] = "Ferme Nord";
            }
            try
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.get_ItemEx("Farm_South");
            }
            catch
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.AddEx("Farm_South");
                NewPrsObject.ModuleName = "WindTurbine";
                NewPrsObject.ClassName = "Farm";
                NewPrsObject.Value["Label", 0] = "Ferme Sud";
            }
            //Set in workstation unit
            MyPrsUnit = MyPrsApplication.UnitsEx.get_ItemEx("$_WORKSTATION");
            //Instatiate exploitation components
            try
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.get_ItemEx(MyPrsObject.Name);
            }
            catch
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.AddEx(MyPrsObject.Name);
                NewPrsObject.ModuleName = "WindTurbine";
                NewPrsObject.ClassName = "MainVue";
            }
        }

        private void CreateDataCenterApp()
        {
            //Create site unit
            try
            {
                MyPrsUnit = MyPrsApplication.UnitsEx.get_ItemEx(MyPrsObject.Name);
            }
            catch
            {
                MyPrsUnit = MyPrsApplication.UnitsEx.AddEx(MyPrsObject.Name);
            }
            //Instatiate components
            try
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.get_ItemEx("DataCenter");
            }
            catch
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.AddEx("DataCenter");
                NewPrsObject.ModuleName = "DataCenter";
                NewPrsObject.ClassName = "DataCenter";
            }
            //Set in workstation unit
            MyPrsUnit = MyPrsApplication.UnitsEx.get_ItemEx("$_WORKSTATION");
            //Instatiate exploitation components
            try
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.get_ItemEx(MyPrsObject.Name);
            }
            catch
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.AddEx(MyPrsObject.Name);
                NewPrsObject.ModuleName = "DataCenter";
                NewPrsObject.ClassName = "MainVue";
            }
        }

        private void CreateGtbApp()
        {
            //Create site unit
            try
            {
                MyPrsUnit = MyPrsApplication.UnitsEx.get_ItemEx(MyPrsObject.Name);
            }
            catch
            {
                MyPrsUnit = MyPrsApplication.UnitsEx.AddEx(MyPrsObject.Name);
            }
            //Instatiate functional components
            try
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.get_ItemEx("GTB");
            }
            catch
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.AddEx("GTB");
                NewPrsObject.ModuleName = "GTB";
                NewPrsObject.ClassName = "GTB";
            }
            //Set in workstation unit
            MyPrsUnit = MyPrsApplication.UnitsEx.get_ItemEx("$_WORKSTATION");
            //Instatiate exploitation components
            try
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.get_ItemEx(MyPrsObject.Name);
            }
            catch
            {
                NewPrsObject = MyPrsUnit.ObjectsEx.AddEx(MyPrsObject.Name);
                NewPrsObject.ModuleName = "GTB";
                NewPrsObject.ClassName = "MainVue";
            }
        }

        public void buttonCancel_Click(Object source, EventArgs e)
        {
            configForm.Close();
        }

        // Implementation of IObjectWithSite
        static void InternalReleaseSite(object pSite)
        {
            Marshal.ReleaseComObject(pSite);
        }

        public void SetSite([MarshalAs(UnmanagedType.IUnknown)][In] object pSite)
        {
            // Eventually, free previous site
            if (MyPrsObject != null && MyPrsObject.GetType().IsCOMObject)
                InternalReleaseSite(MyPrsObject);

            if (pSite != null)
            {
                MyPrsObject = pSite as IPrsObject;
                if (MyPrsObject != null)
                {
                    MyPrsApplication = MyPrsObject.Application;
                    MyFullName = MyPrsObject.FullName;
                }
            }
        }

        public void GetSite([In] ref Guid riid, [Out] out IntPtr pvSite)
        {
            // Initialize return value to NULL
            pvSite = System.IntPtr.Zero;

            // If no site, return E_FAIL
            if (MyPrsObject == null)
                Marshal.ThrowExceptionForHR(CODRA.SDK.DotNetUtils.COM.COMError.E_FAIL);

            // Otherwise, get requested interface
            IntPtr pUnk = Marshal.GetIUnknownForObject(MyPrsObject);

            Marshal.QueryInterface(pUnk, ref riid, out pvSite);

            Marshal.Release(pUnk);

            if (pvSite.Equals(IntPtr.Zero))
                Marshal.ThrowExceptionForHR(CODRA.SDK.DotNetUtils.COM.COMError.E_NOINTERFACE);
        }
    }
}
