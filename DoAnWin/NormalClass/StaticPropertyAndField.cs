using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWin.NormalClass
{
    public static class StaticPropertyAndField
    {
        public static string IncomeID { get; set; }
        public static string IncomeWorkID { get; set; }

        public static string IncomeName { get; set; }
        public static string[] listDefaultBackground;
        public static string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public static string defaultFolderPath = Path.Combine(root, "DefaultBackground"); // Tạo đường dẫn đầy đủ của thư mục hình ảnh
        static StaticPropertyAndField()
        {
            listDefaultBackground = Directory.GetFiles(defaultFolderPath);
        }
        public static Image[] LoadImagesFromFolder()
        {
            Image[] images = null;
            if (Directory.Exists(defaultFolderPath))
            {
                string[] files = Directory.GetFiles(defaultFolderPath);
                images = new Image[files.Length];
                for (int i = 0; i < files.Length; i++)
                    images[i] = Image.FromFile(files[i]);
            }
            return images;
        }
    }
}
