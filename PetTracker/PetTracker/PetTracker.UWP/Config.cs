using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using Xamarin.Forms;
[assembly: Xamarin.Forms.Dependency(typeof(PetTracker.UWP.Config))]
namespace PetTracker.UWP
{
    class Config : IConfig
    {
        private string directoryDB;
        private SQLitePCL.IPlatform platform;
        public string DirectoryDB
        {
            get
            {
                Windows.ApplicationModel.Package package = Windows.ApplicationModel.Package.Current;
                Windows.Storage.StorageFolder installedLocation = package.InstalledLocation;
                directoryDB = Windows.Storage.ApplicationData.Current.LocalFolder.Path.ToString();
                return directoryDB;
            }
        }


    }
}