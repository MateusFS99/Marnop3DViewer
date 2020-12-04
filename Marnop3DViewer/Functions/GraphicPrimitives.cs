using Marnop3DViewer.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marnop3DViewer
{
	unsafe class GraphicPrimitives
	{
		public static Bitmap retaDda(Bitmap b, int x1, int x2, int y1, int y2, Color cor)
		{
			int length = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));
			Color color = Color.FromArgb(cor.ToArgb());

			if (length != 0)
			{
				float xinc = (float)(x2 - x1) / length;
				float yinc = (float)(y2 - y1) / length;

				for (float x = x1, y = y1; x < x2; x += xinc, y += yinc)
					try
					{

						b.SetPixel((int)Math.Round(x), (int)Math.Round(y), color);
					}
					catch (Exception e) { }
			}

			return b;
		}

		private static void BresenhamLow(int x1, int y1, BitmapData b, double dx, double dy, int fx, int fy)
		{
			int rowsize = (b.Width * 3), incE = (int)(2 * dy), incNE = (int)(2 * dy - 2 * dx);
			int	d = (int)(2 * dy - dx), co;
			bool t = true;
			byte* p, lim = (byte*)b.Scan0.ToPointer();

			lim += rowsize * (b.Height - 1);
			for (int x = 0; x < dx && t; x++)
			{
				co = 3 * (x1 + x * fx);
				if (co < rowsize && co > 0)
				{
					p = (byte*)b.Scan0.ToPointer();
					p += rowsize * y1 + co;
					if (p > (byte*)b.Scan0.ToPointer() && p < lim)
						*p = (byte)255;

					if (d > 0)
					{
						y1 = y1 + fy;
						d += incNE;
					}
					else
						d += incE;
				}
				else
					t = false;
			}
		}

		private static void BresenhamHigh(int x1, int y1, BitmapData b, double dx, double dy, int fx, int fy)
		{
			int incE = (int)(2 * dx), incNE = (int)(2 * dx - 2 * dy), d = (int)(2 * dx - dy);
			int rowsize = (b.Width * 3), co;
			bool t = true;
			byte* p, lim = (byte*)b.Scan0.ToPointer();

			lim += rowsize * (b.Height - 1);
			for (int y = 0; y < dy && t; y++)
			{
				co = 3 * x1;
				p = (byte*)b.Scan0.ToPointer();
				if (co < rowsize && co > 0)
				{
					p += rowsize * (y1 + y * fy) + co;

					if (p > (byte*)b.Scan0.ToPointer() && p < lim)
						*p = (byte)255;

					if (d > 0)
					{
						x1 = x1 + fx;
						d += incNE;
					}
					else
						d += incE;
				}
				else
					t = false;
			}
		}

		public static void bresenham(BitmapData b, int x1, int y1, int x2, int y2)
		{
			double dx = x2 - x1;
			double dy = y2 - y1;

				if (Math.Abs(dy) > Math.Abs(dx))
				{
					if (x1 < x2)
					{
						if (y1 < y2)
							BresenhamHigh(x1, y1, b, dx, dy, 1, 1);
						else
						{
							dy *= -1;
							BresenhamHigh(x1, y1, b, dx, dy, 1, -1);
						}
					}
					else
					{
						dx *= -1;
						if (y1 < y2)
							BresenhamHigh(x1, y1, b, dx, dy, -1, 1);
						else
						{
							dy *= -1;
							BresenhamHigh(x1, y1, b, dx, dy, -1, -1);
						}
					}
				}
				else
				{
					if (x1 < x2)
					{
						if (y1 < y2)
							BresenhamLow(x1, y1, b, dx, dy, 1, 1);
						else
						{
							dy *= -1;
							BresenhamLow(x1, y1, b, dx, dy, 1, -1);
						}
					}
					else
					{
						dx *= -1;
						if (y1 < y2)
							BresenhamLow(x1, y1, b, dx, dy, -1, 1);
						else
						{
							dy *= -1;
							BresenhamLow(x1, y1, b, dx, dy, -1, -1);
						}
					}
				}
		}
	}
}