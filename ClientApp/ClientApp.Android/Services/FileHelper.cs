using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ClientApp.Droid.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace ClientApp.Droid.Services
{
    using ClientApp.Droid.Services;
    using Xamarin.Forms;
    using System.IO;
    using ClientApp.Services;

    public class FileHelper:IFileHelper
    {
        public FileHelper()
        {

        }

        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
    }
}