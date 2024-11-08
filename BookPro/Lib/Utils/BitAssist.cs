using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPro.Lib.Utils
{
  public static class BitAssist
  {
    public static String ImageToHexString(Image img)
    {
      if (img != null) {
        byte[] byteImage = ImageToByteArray(img);
        return ByteArrayToHexString(byteImage);
      } else {
        return "";
      }
    }

    public static Image HexStringToImage(String hex)
    {
      byte[] byteImage = HexStringToByteArray(hex);
      return ByteArrayToImage(byteImage);
    }

    public static byte[] ImageToByteArray(Image img)
    {
      using (MemoryStream ms = new MemoryStream())
      {
        img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        return ms.ToArray();
      }
    }
    public static string ByteArrayToHexString(byte[] ba)
    {
      StringBuilder hex = new StringBuilder(ba.Length * 2);
      foreach (byte b in ba)
      {
        hex.AppendFormat("{0:X2}", b);
      }
      return hex.ToString();
    }
    public static byte[] HexStringToByteArray(String hex)
    {
      int NumberChars = hex.Length;
      byte[] bytes = new byte[NumberChars / 2];
      if (NumberChars % 2 == 0)
      {
        for (int i = 0; i < NumberChars; i += 2)
        {
          bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        }
      }
      return bytes;
    }
    public static Image ByteArrayToImage(byte[] byteArray)
    {
      using (MemoryStream ms = new MemoryStream(byteArray))
      {
        return Image.FromStream(ms);
      }
    }

  }
}
