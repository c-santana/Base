using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Base.Libs
{
    public class ByteImageConverter
    {
        static ByteImageConverter()
        {
        }

        private static byte[] StreamToByteArray(Stream stream)
        {
            byte[] buffer = null;
            int bytesRead = 0;
            int bytesToRead = Convert.ToInt32(stream.Length);

            try
            {
                buffer = new byte[bytesToRead];
                bytesRead = stream.Read(buffer, 0, bytesToRead);
                if (bytesRead.Equals(bytesToRead))
                {
                    return buffer;
                }

                return null;
            }
            catch (Exception ex)
            {
                Type type = ex.GetType();
                switch (type)
                {
                    default:
                        throw ex;
                }
            }
            finally
            {
                stream.Close();
            }
        }

        public static Image StreamToImage(Stream stream)
        {
            try
            {
                BitmapImage biImg = new BitmapImage();
                MemoryStream ms = new MemoryStream(StreamToByteArray(stream));
                biImg.BeginInit();
                biImg.StreamSource = ms;
                biImg.EndInit();

                Image img = new Image();
                img.Source = biImg;

                return img;
            }
            catch (Exception ex)
            {
                Type type = ex.GetType();
                switch (type)
                {
                    default:
                        throw ex;
                }
            }
        }

        public static ImageSource ByteToImage(byte[] imageData)
        {
            try
            {
                BitmapImage biImg = new BitmapImage();
                MemoryStream ms = new MemoryStream(imageData);
                biImg.BeginInit();
                biImg.StreamSource = ms;
                biImg.EndInit();

                ImageSource imgSrc = biImg as ImageSource;

                return imgSrc;
            }
            catch (Exception ex)
            {
                Type type = ex.GetType();
                switch (type)
                {
                    default:
                        throw ex;
                }
            }
        }
    }
}