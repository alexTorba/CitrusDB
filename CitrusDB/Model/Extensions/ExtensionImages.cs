using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.Model.Extensions
{
    public static class ExtensionImages
    {

        public static byte[] ConvertImageToByteArr(this Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.ToArray();
            }
        }

        public static Image ConvertByteArrToImage(this byte[] arr)
        {
            if (arr == null)
                return null;
            using (MemoryStream stream = new MemoryStream(arr))
            {
                return Image.FromStream(stream);
            }
        }

        public static byte[] SetPhoto(this Image editPhoto, byte[] initPhoto)
        {
            try
            {
                return editPhoto.ConvertImageToByteArr();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return initPhoto;
            }
        }

    }
}
