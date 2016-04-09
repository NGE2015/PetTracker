using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//using Portable.Data;
using Portable.Data.Sqlite;
using SQLitePCL;
namespace PetTracker
{
    public interface IConfig
    {
        string DirectoryDB { get; }
        //SQLitePCL.IPlatform Platform { get; }
    }
}
