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
		public static void BresenhamLow(int x1, int y1, BitmapData b, double dx, double dy, int fx, int fy)
		{
			int rowsize = (b.Width * 3);
			byte* p;
			int incE, incNE, d;
			incE = (int)(2 * dy);
			incNE = (int)(2 * dy - 2 * dx);
			d = (int)(2 * dy - dx);

			byte* lim = (byte*)b.Scan0.ToPointer();
			lim += rowsize * (b.Height - 1);
			bool t = true;
			int co;

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

		public static void BresenhamHigh(int x1, int y1, BitmapData b, double dx, double dy, int fx, int fy)
		{

			byte* p;
			int incE, incNE, d;
			incE = (int)(2 * dx);
			incNE = (int)(2 * dx - 2 * dy);
			d = (int)(2 * dx - dy);

			int rowsize = (b.Width * 3);
			byte* lim = (byte*)b.Scan0.ToPointer();
			lim += rowsize * (b.Height - 1);
			bool t = true;
			int co;

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
	}
}