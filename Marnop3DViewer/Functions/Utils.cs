using Marnop3DViewer.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marnop3DViewer
{
    static class Utils
    {
        public static Object3D readObj(StreamReader sr)
        {
            Object3D obj = new Object3D();
            String[] s,s1;
            Face f;
            String line = sr.ReadLine();

            while(line != null)
            {
                s = line.Split(' ');
                //add vertex
                if (s[0].Equals("v"))
                {
					obj.addOriginals(new Vertex(Convert.ToDouble(s[1].Replace(".", ",")), Convert.ToDouble(s[2].Replace(".", ",")), Convert.ToDouble(s[3].Replace(".", ","))));
				}
                    
                //add face
                else if (s[0].Equals("f"))
                {
                    f = new Face();
					if (s[s.Length - 1] == "")
						Array.Resize(ref s, 3);
					for (int i = 1; i < s.Length; i++)
                    {
                        s1 = s[i].Split('/');
						
						f.addVertex(Convert.ToInt32(s1[0]) - 1);
                    }
                    obj.addFaces(f);
                }
                //add texture
                //else if ()

                line = sr.ReadLine();
            }
            obj.setActuals(obj.getOriginals());

            return obj;
        }

        public static Bitmap drawObject(Object3D obj,Bitmap b)
        {
			int x1, x2, y1, y2;
			BitmapData bdma = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			foreach (Face f in obj.getFaces())
            {
                for (int i = 0;  i< f.getVertexs().Count - 1; i++)
                {
					x1 = (int)(330+obj.getActuals()[f.getVertexs()[i]].getX());
					y1 = (int)(250+obj.getActuals()[f.getVertexs()[i]].getY());
					x2 = (int)(330+obj.getActuals()[f.getVertexs()[i+1]].getX());
					y2 = (int)(250+obj.getActuals()[f.getVertexs()[i+1]].getY());
					bresenham(bdma, x1, y1, x2, y2);
                }
				x1 = (int)(330+obj.getActuals()[f.getVertexs()[f.getVertexs().Count-1]].getX());
				y1 = (int)(250+obj.getActuals()[f.getVertexs()[f.getVertexs().Count-1]].getY());
				x2 = (int)(330+obj.getActuals()[f.getVertexs()[0]].getX());
				y2 = (int)(250+obj.getActuals()[f.getVertexs()[0]].getY());
				bresenham(bdma, x1, y1, x2, y2);
			}

			b.UnlockBits(bdma);

			return b;
		}

		private static int limiter(int limmin, int limmax, int number)
        {
			if (number > limmax)
				number = limmax;
			else if (number < limmin)
				number = limmin;

			return number;
        }

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
					catch (Exception) { }
			}

			return b;
		}

		private static void bresenham(BitmapData b, int x1, int y1, int x2, int y2)
		{
			double dx = x2 - x1;
			double dy = y2 - y1;

			if (dx != 0 && dy != 0)
			{
				if (Math.Abs(dy) > Math.Abs(dx))
				{
					if (x1 < x2)
					{
						if (y1 < y2)
							GraphicPrimitives.BresenhamHigh(x1, y1, b, dx, dy, 1, 1);
						else
						{
							dy *= -1;
							GraphicPrimitives.BresenhamHigh(x1, y1, b, dx, dy, 1, -1);
						}
					}
					else
					{
						dx *= -1;
						if (y1 < y2)
							GraphicPrimitives.BresenhamHigh(x1, y1, b, dx, dy, -1, 1);
						else
						{
							dy *= -1;
							GraphicPrimitives.BresenhamHigh(x1, y1, b, dx, dy, -1, -1);
						}
					}
				}
				else
				{
					if (x1 < x2)
					{
						if (y1 < y2)
							GraphicPrimitives.BresenhamLow(x1, y1, b, dx, dy, 1, 1);
						else
						{
							dy *= -1;
							GraphicPrimitives.BresenhamLow(x1, y1, b, dx, dy, 1, -1);
						}
					}
					else
					{
						dx *= -1;
						if (y1 < y2)
							GraphicPrimitives.BresenhamLow(x1, y1, b, dx, dy, -1, 1);
						else
						{
							dy *= -1;
							GraphicPrimitives.BresenhamLow(x1, y1, b, dx, dy, -1, -1);
						}
					}
				}
			}
		}

		public static void scanLine(Object3D obj, Color cor, Bitmap b)
		{
			int y = 0;
			List<Vertex> lv = obj.getActuals();
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
					retaDda(b, (int)aet[i - 1].Xmin, (int)aet[i].Xmin, (int)(y + primy), (int)(y + primy), color);
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