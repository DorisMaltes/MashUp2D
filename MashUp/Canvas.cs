using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mashUp
{
    public class Canvas
    {
        static Bitmap bmp, foreground;
        static Graphics g;
        int stride;
        int pixelFormatSize;
        public byte[] bits;
        PictureBox pct;

        public Canvas(PictureBox pct)
        {
            this.pct = pct;
            foreground = new Bitmap(pct.Width, pct.Height);
            bmp = new Bitmap(pct.Width, pct.Height);

            Init();
        }

        private void Init()
        {
            PixelFormat format;
            GCHandle handle;
            IntPtr bitPtr;
            int padding;

            format = PixelFormat.Format32bppArgb;

            pixelFormatSize = Image.GetPixelFormatSize(format) / 8; 
            stride = bmp.Width * pixelFormatSize;              
            padding = (stride % 4);                         
            stride += padding == 0 ? 0 : 4 - padding;       
            bits = new byte[stride * bmp.Height];
            handle = GCHandle.Alloc(bits, GCHandleType.Pinned);
            bitPtr = Marshal.UnsafeAddrOfPinnedArrayElement(bits, 0);
            bmp = new Bitmap(bmp.Width, bmp.Height, stride, format, bitPtr);

            g = Graphics.FromImage(bmp);
            g.Clear(Color.Black);
            pct.Image = bmp;
            pct.Invalidate();
        }

        public void DrawPixel(int x, int y, Color c)
        {
            int res = (int)((x * pixelFormatSize) + (y * stride));

            bits[res + 0] = c.B;
            bits[res + 1] = c.G;
            bits[res + 2] = c.R;
            bits[res + 3] = c.A;

            pct.Invalidate();
        }

        private void FastClear()
        {
            unsafe
            {
                BitmapData bitmapData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(bmp.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* bits = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        bits[x + 0] = 0;
                        bits[x + 1] = 0;
                        bits[x + 2] = 0;
                        bits[x + 3] = 0;
                    }
                });
                bmp.UnlockBits(bitmapData);
            }
            pct.Invalidate();
        }

        public void Render(Scene scene) // This function creates the visual element of the figure generated from the points added
        {
            FastClear();
            for (int f = 0; f < scene.Figures.Count; f++)
            {
                if (scene.Figures[f].Pts.Count > 1)
                {
                    g.FillPolygon(Brushes.Coral, scene.Figures[f].Pts.ToArray());//cambia el color de relleno de la figura 
                    g.DrawPolygon(Pens.White, scene.Figures[f].Pts.ToArray());
                    g.FillEllipse(Brushes.Crimson, scene.Figures[f].Pts[scene.Figures[f].Pts.Count - 1].X - 3, scene.Figures[f].Pts[scene.Figures[f].Pts.Count - 1].Y - 3, 6, 6);
                    g.FillEllipse(Brushes.White, scene.Figures[f].Centroid.X - 3, scene.Figures[f].Centroid.Y - 3, 6, 6);//*/
                }
            }
            pct.Invalidate();
        }

    }
}
