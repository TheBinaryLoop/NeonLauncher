using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace NeonLauncher.Converter
{
    public class IconConverter : IValueConverter
    {
        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern bool DeleteObject(IntPtr hObject);


        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Icon)
            {
                Bitmap bitmap = ((Icon)value).ToBitmap();
                IntPtr hBitmap = bitmap.GetHbitmap();

                ImageSource wpfBitmap = Imaging.CreateBitmapSourceFromHBitmap(hBitmap, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

                if (!DeleteObject(hBitmap))
                {
                    throw new Win32Exception();
                }

                return wpfBitmap;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
