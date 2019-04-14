using System;
using System.Drawing;
using System.IO;

namespace CitrusDB.Model.Extensions
{
  public static class ExtensionImages
  {
    public static byte[] ConvertImageToByteArr(this Image image)
    {
      using (var memoryStream = new MemoryStream())
      {
        image.Save(memoryStream, image.RawFormat);
        return memoryStream.ToArray();
      }
    }

    public static Image ConvertByteArrToImage(this byte[] arr)
    {
      if (arr == null) return null;

      using (var stream = new MemoryStream(arr))
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
