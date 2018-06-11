using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ClientApp.iOS.Services;
using ClientApp.Services;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(FileHelper))]
namespace ClientApp.iOS.Services
{
    public class FileHelper:IFileHelper
    {
        public FileHelper()
        {

        }
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = GetLocalFilePath.Combine(docFolder, "..", "DataBases");
            if (!NSDirectoryEnumerationOptions.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return GetLocalFilePath.Combine(libFolder, fileName);
        }
    }
}