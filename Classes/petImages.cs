using System;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace tamogoji.Classes
{
    public class petImages
    {
        public string name;
        public ImageSource active;
        public ImageSource calmness;

        public petImages(string name, string activePath, string calmnessPath)
        {
            this.name = name;
            this.active = LoadImage(activePath);
            this.calmness = LoadImage(calmnessPath);
        }

        private static BitmapImage LoadImage(string path)
        {
            var full = Path.GetFullPath(path);
            var bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(full, UriKind.Absolute);
            bi.CacheOption = BitmapCacheOption.OnLoad;
            bi.EndInit();
            bi.Freeze();
            return bi;
        }
    }
}