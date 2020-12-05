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
	class Fill
	{
		public static void flat(List<Vertex> lv, Color cor, BitmapData b)
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
			for (int i = 0; i < lv.Count - 1; i++)
			{
				p1 = lv[i];
				p2 = lv[i + 1];
				
					if (p1.getY() < p2.getY())
					{
						ymin = p1.getY();
						ymax = p2.getY();
						xmin = p1.getX();
						incx = (double)(p2.getX() - p1.getX()) / (p2.getY() - p1.getY());
					}
					else
					{
						ymin = p2.getY();
						ymax = p1.getY();
						xmin = p2.getX();
						incx = (double)(p1.getX() - p2.getX()) / (p1.getY() - p2.getY());
					}
					
					et[(int)(ymin - primy)].Add(new NoScan(ymax, xmin, incx));
			}
			p1 = lv[0];
			p2 = lv[lv.Count - 1];
			if (p1.getY() < p2.getY())
			{
				ymin = p1.getY();
				ymax = p2.getY();
				xmin = p1.getX();
			}
			else
			{
				ymin = p2.getY();
				ymax = p1.getY();
				xmin = p2.getX();
			}
			incx = (double)(p2.getX() - p1.getX()) / (p2.getY() - p1.getY());
			et[(int)(ymin - primy)].Add(new NoScan(ymax, xmin, incx));

			List<NoScan> aet = et[y];

			while (aet.Count>0)
			{
				for (int i = 0; i < aet.Count; i++)
					if (y + primy + 1 >= aet[i].Ymax)
						aet.RemoveAt(i);
				aet.Sort((o1, o2) => o1.Xmin.CompareTo(o2.Xmin));
				for (int i = 0; i < aet.Count - 1; i += 2)
					GraphicPrimitives.drawLine((int)aet[i].Xmin, (int)aet[i + 1].Xmin, (y + primy), b, cor);
				for (int i = 0; i < aet.Count; i++)
					aet[i].Xmin += aet[i].Incx;
				y++;
				if (y < et.Length)
					for (int pos2 = 0; pos2 < et[y].Count; pos2++)
						aet.Add(et[y][pos2]);
			}
		}

		public static void gourard(List<Vertex> lv, Color cor, BitmapData b)
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
					GraphicPrimitives.bresenham(b, (int)aet[i - 1].Xmin, (int)(y + primy), (int)aet[i].Xmin, (int)(y + primy));
				for (int i = 0; i < aet.Count; i++)
					aet[i].Xmin += aet[i].Incx;
				y++;
				if (y < et.Length)
					for (int pos2 = 0; pos2 < et[y].Count; pos2++)
						aet.Add(et[y][pos2]);
			}
		}

		public static void phong(List<Vertex> lv, Color cor, BitmapData b)
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
					else
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
					GraphicPrimitives.bresenham(b, (int)aet[i - 1].Xmin, (int)(y + primy), (int)aet[i].Xmin, (int)(y + primy));
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