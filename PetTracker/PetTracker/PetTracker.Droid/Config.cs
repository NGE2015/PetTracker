using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLitePCL;
using Xamarin.Forms;
[assembly: Dependency(typeof(PetTracker.Droid.Config))]
namespace PetTracker.Droid
{
    class Config : IConfig
    {
        private string directoryDB;
        public string DirectoryDB
        {
            get
            {
                if (string.IsNullOrEmpty(directoryDB))
                {
                    directoryDB = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return directoryDB;
            }
        }
    }
}