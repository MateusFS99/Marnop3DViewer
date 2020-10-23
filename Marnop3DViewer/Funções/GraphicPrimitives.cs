using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marnop3DViewer
{
	class GraphicPrimitives
	{

		public unsafe static void BresenhamLow(int x1, int y1, BitmapData b, double dx, double dy, int fx, int fy)
		{
			
			byte* p;
			int incE, incNE, d;
			incE = (int)(2 * dy);
			incNE = (int)(2 * dy - 2 * dx);
			d = (int)(2 * dy - dx);

			int rowsize = (b.Width * 3);
			try
			{
				for (int x = 0; x < dx; x++)
				{
					p = (byte*)b.Scan0.ToPointer();
					p += rowsize * y1 + 3*(x1 + x * fx);
					*p = 255;
					*p = 255;
					*p = 255;

					if (d > 0)
					{
						y1 = y1 + fy;
						d += incNE;
					}
					else
						d += incE;
				}
			}
			catch (Exception)
			{ }
			
		}

		public unsafe static void BresenhamHigh(int x1, int y1, BitmapData b, double dx, double dy, int fx, int fy)
		{

			byte* p;
			int incE, incNE, d;
			incE = (int)(2 * dx);
			incNE = (int)(2 * dx - 2 * dy);
			d = (int)(2 * dx - dy);

			int rowsize = (b.Width * 3);

			for (int y = 0; y < dy; y++)
			{
				p = (byte*)b.Scan0.ToPointer();
				p += rowsize * (y1 + y * fy) + ((3 * x1)-1);
				int i = *p;
				*(p) = (byte)255;
				*(p) = (byte)255;
				*(p) = (byte)255;

				if (d > 0)
				{
					x1 = x1 + fx;
					d += incNE;
				}
				else
					d += incE;
			}
		}
	}
}