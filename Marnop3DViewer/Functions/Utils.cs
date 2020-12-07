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
			obj.setNFaces();

            return obj;
        }

		private static void desenha(Object3D obj, Face f, BitmapData bdma)
		{
			int x1, x2, y1, y2;

			for (int i = 0; i < f.getVertexs().Count - 1; i++)
			{
				x1 = (int)(330 + obj.getActuals()[f.getVertexs()[i]].getX());
				y1 = (int)(250 + obj.getActuals()[f.getVertexs()[i]].getY());
				x2 = (int)(330 + obj.getActuals()[f.getVertexs()[i + 1]].getX());
				y2 = (int)(250 + obj.getActuals()[f.getVertexs()[i + 1]].getY());
				GraphicPrimitives.bresenham(bdma, x1, y1, x2, y2);
			}
			x1 = (int)(330 + obj.getActuals()[f.getVertexs()[f.getVertexs().Count - 1]].getX());
			y1 = (int)(250 + obj.getActuals()[f.getVertexs()[f.getVertexs().Count - 1]].getY());
			x2 = (int)(330 + obj.getActuals()[f.getVertexs()[0]].getX());
			y2 = (int)(250 + obj.getActuals()[f.getVertexs()[0]].getY());
			GraphicPrimitives.bresenham(bdma, x1, y1, x2, y2);
		}

		public static Bitmap drawObjectWire(Object3D obj, Bitmap b, bool face)
		{
			BitmapData bdma = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			foreach (Face f in obj.getFaces())
			{
				if (!face)
                {
					if (f.getNormal().getZ() > 0)
						desenha(obj, f, bdma);
				}
				else
					desenha(obj, f, bdma);
			}

			b.UnlockBits(bdma);

			return b;
		}

		public static Bitmap drawObjectSolid(Object3D obj, Bitmap b, Vertex l, Color a, Color d, Color e,string fill, double [,]zbuffer)
		{
			BitmapData bdma = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);


			double[] argb = new double[] { a.R / 255.0, a.G * 0.9 / 255, a.B * 0.9 / 255 };
			double[] drgb = new double[] { d.R * 0.5 / 255, d.G * 0.7 / 255, d.B * 0.5 / 255 };
			double[] ergb = new double[] { e.R * 0.5 / 255, e.G * 0.5 / 255, e.B * 0.6 / 255 };

			Vertex h;
			double ln, hn;
			double n = Math.Sqrt(Math.Pow(l.getX(), 2) + Math.Pow(l.getX(), 2) + Math.Pow(l.getZ(), 2));

			l.setX(l.getX() / n);
			l.setY(l.getY() / n);
			l.setZ(l.getZ() / n);

			n = Math.Sqrt(Math.Pow(l.getX(), 2) + Math.Pow(l.getX(), 2) + Math.Pow((l.getZ() + 1), 2));
			h = new Vertex((l.getX())/n, (l.getY())/n, (l.getZ() + 1) / n);


			if (fill.Equals("Flat"))
				flat(obj,l,argb,drgb,ergb,h,bdma);
			//else if((fill.Equals("Flat")))

			
			b.UnlockBits(bdma);

			return b;
		}

		private static void flat(Object3D obj, Vertex l, double[]argb, double[] drgb, double[] ergb, Vertex h, BitmapData bdma)
        {
			double ln, hn;
			int r, g, bc;
			List<Vertex> lv;
			foreach (Face f in obj.getFaces())
			{
				ln = l.getX() * f.getNormal().getX() + l.getY() * f.getNormal().getY() + l.getZ() * f.getNormal().getZ();
				hn = Math.Pow((h.getX() * f.getNormal().getX() + h.getY() * f.getNormal().getY() + h.getZ() * f.getNormal().getZ()), 10);

				r = (int)(255 * (0.1 * argb[0] + 0.4 * drgb[0] * ln + 0.3 * ergb[0] * hn));
				g = (int)(255 * (0.1 * argb[1] + 0.4 * drgb[1] * ln + 0.3 * ergb[1] * hn));
				bc = (int)(255 * (0.1 * argb[2] + 0.4 * drgb[2] * ln + 0.3 * ergb[2] * hn));

				if (f.getNormal().getZ() > 0)
				{
					lv = new List<Vertex>();
					for (int i = 0; i < f.getVertexs().Count; i++)
						lv.Add(new Vertex(330 + obj.getActuals()[f.getVertexs()[i]].getX(), 250 + obj.getActuals()[f.getVertexs()[i]].getY(), obj.getActuals()[f.getVertexs()[i]].getZ()));
					Fill.flat(lv, Color.FromArgb(limiter(0, 255, r), limiter(0, 255, g), limiter(0, 255, bc)), bdma);
				}
			}
		}


		public static Bitmap drawObjectZY(Object3D obj, Bitmap b)
		{
			int x1, x2, y1, y2;
			BitmapData bdma = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			foreach (Face f in obj.getFaces())
			{
				for (int i = 0; i < f.getVertexs().Count - 1; i++)
				{
					x1 = (int)(330 + obj.getActuals()[f.getVertexs()[i]].getZ());
					y1 = (int)(250 + obj.getActuals()[f.getVertexs()[i]].getY());
					x2 = (int)(330 + obj.getActuals()[f.getVertexs()[i + 1]].getZ());
					y2 = (int)(250 + obj.getActuals()[f.getVertexs()[i + 1]].getY());
					GraphicPrimitives.bresenham(bdma, x1, y1, x2, y2);
				}
				x1 = (int)(330 + obj.getActuals()[f.getVertexs()[f.getVertexs().Count - 1]].getZ());
				y1 = (int)(250 + obj.getActuals()[f.getVertexs()[f.getVertexs().Count - 1]].getY());
				x2 = (int)(330 + obj.getActuals()[f.getVertexs()[0]].getZ());
				y2 = (int)(250 + obj.getActuals()[f.getVertexs()[0]].getY());
				GraphicPrimitives.bresenham(bdma, x1, y1, x2, y2);
			}

			b.UnlockBits(bdma);

			return b;
		}

		public static Bitmap drawObjectXZ(Object3D obj, Bitmap b)
		{
			int x1, x2, y1, y2;
			BitmapData bdma = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			foreach (Face f in obj.getFaces())
			{
				for (int i = 0; i < f.getVertexs().Count - 1; i++)
				{
					x1 = (int)(330 + obj.getActuals()[f.getVertexs()[i]].getX());
					y1 = (int)(250 + obj.getActuals()[f.getVertexs()[i]].getZ());
					x2 = (int)(330 + obj.getActuals()[f.getVertexs()[i + 1]].getX());
					y2 = (int)(250 + obj.getActuals()[f.getVertexs()[i + 1]].getZ());
					GraphicPrimitives.bresenham(bdma, x1, y1, x2, y2);
				}
				x1 = (int)(330 + obj.getActuals()[f.getVertexs()[f.getVertexs().Count - 1]].getX());
				y1 = (int)(250 + obj.getActuals()[f.getVertexs()[f.getVertexs().Count - 1]].getZ());
				x2 = (int)(330 + obj.getActuals()[f.getVertexs()[0]].getX());
				y2 = (int)(250 + obj.getActuals()[f.getVertexs()[0]].getZ());
				GraphicPrimitives.bresenham(bdma, x1, y1, x2, y2);
			}

			b.UnlockBits(bdma);

			return b;
		}

		public static int limiter(int limmin, int limmax, int number)
        {
			if (number > limmax)
				number = limmax;
			else if (number < limmin)
				number = limmin;

			return number;
        }

		public static int limiterL(int lim, int n)
		{
			if (n < lim)
				return lim;
			return n;
		}

		public static int limiterH(int lim, int n)
		{
			if (n > lim)
				return lim;
			return n;
		}
	}
}