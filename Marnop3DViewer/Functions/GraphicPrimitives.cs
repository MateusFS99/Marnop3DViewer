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

		public static void scanLine(List<Vertex> lv, Color cor, BitmapData b)
		{
			int y = 0;

			double ymin = lv[0].getY(), ymax = lv[0].getY(), xmin = 0, primy, incx = 0;
			Vertex p1, p2;
			Color color = Color.FromArgb(cor.ToArgb());

			for (int i = 1; i < lv.Count; i++)
			{
				if (ymin > lv[i].getY())
					ymin = lv[i].getY();
				if (ymax < lv[i].getY())
					ymax = lv[i].getY();
			}
			primy = ymin;

			List<NoScan>[] et = new List<NoScan>[(int)(ymax - ymin + 1)];

			for (int i = 0; i < (int)(ymax - ymin + 1); i++)
				et[i] = new List<NoScan>();
			for (int i = 1; i < lv.Count; i++)
			{
				p1 = lv[i - 1];
				p2 = lv[i];
				if (p1.getY() != p2.getY())
				{
					if (p1.getY() < p2.getY())
					{
						ymin = p1.getY();
						ymax = p2.getY();
						xmin = p1.getX();
					}
					else if (p1.getY() > p2.getY())
					{
						ymin = p2.getY();
						ymax = p1.getY();
						xmin = p2.getX();
					}
					incx = (double)(p2.getX() - p1.getX()) / (p2.getY() - p1.getY());
					et[(int)(ymin - primy)].Add(new NoScan(ymax, xmin, incx));
				}
			}
			p1 = lv[0];
			p2 = lv[lv.Count - 1];
			if (p1.getY() != p2.getY())
			{
				if (p1.getY() < p2.getY())
				{
					ymin = p1.getY();
					ymax = p2.getY();
					xmin = p1.getX();
				}
				else if (p1.getY() > p2.getY())
				{
					ymin = p2.getY();
					ymax = p1.getY();
					xmin = p2.getX();
				}
				incx = (double)(p2.getX() - p1.getX()) / (p2.getY() - p1.getY());
				et[(int)(ymin - primy)].Add(new NoScan(ymax, xmin, incx));
			}

			List<NoScan> aet = et[y];

			while (y < et.Length)
			{
				for (int i = 0; i < aet.Count; i++)
					if (y + primy == aet[i].Ymax)
						aet.RemoveAt(i);
				aet.Sort((o1, o2) => o1.Xmin.CompareTo(o2.Xmin));
				for (int i = 1; i < aet.Count; i += 2)
					bresenham(b, (int)aet[i - 1].Xmin, (int)(y + primy), (int)aet[i].Xmin, (int)(y + primy));
				for (int i = 0; i < aet.Count; i++)
					aet[i].Xmin += aet[i].Incx;
				y++;
				if (y < et.Length)
					for (int pos2 = 0; pos2 < et[y].Count; pos2++)
						aet.Add(et[y][pos2]);
			}
		}
	}
}