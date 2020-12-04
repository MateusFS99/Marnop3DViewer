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

        public static Bitmap drawObjectWire(Object3D obj, Bitmap b)
        {
			int x1, x2, y1, y2;
			BitmapData bdma = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			foreach (Face f in obj.getFaces())
            {
				if(f.getNormal().getZ() > 0)
                {
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
			}

			b.UnlockBits(bdma);

			return b;
		}

		public static Bitmap drawObjectSolid(Object3D obj, Bitmap b)
		{
			int x1, x2, y1, y2;
			BitmapData bdma = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			List<Vertex> lv;
			foreach (Face f in obj.getFaces())
			{
				if (f.getNormal().getZ() > 0)
				{
					lv = new List<Vertex>();
					for (int i = 0; i < f.getVertexs().Count; i++)						
						lv.Add(new Vertex(330 + obj.getActuals()[f.getVertexs()[i]].getX(), 250 + obj.getActuals()[f.getVertexs()[i]].getY(), obj.getActuals()[f.getVertexs()[i]].getZ()));
					GraphicPrimitives.scanLine(lv, Color.FromArgb(255, 255, 255), bdma);
				}
			}

			b.UnlockBits(bdma);

			return b;
		}

		/*public static Bitmap drawObject(Object3D obj, Bitmap b)
		{
			int x1, x2, y1, y2;
			BitmapData bdma = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			foreach (Face f in obj.getFaces())
			{
				for (int i = 0; i < f.getVertexs().Count - 1; i++)
				{
					x1 = (int)(330 + obj.getActuals()[f.getVertexs()[i]].getX());
					y1 = (int)(250 + obj.getActuals()[f.getVertexs()[i]].getY());
					x2 = (int)(330 + obj.getActuals()[f.getVertexs()[i + 1]].getX());
					y2 = (int)(250 + obj.getActuals()[f.getVertexs()[i + 1]].getY());
					bresenham(bdma, x1, y1, x2, y2);
				}
				x1 = (int)(330 + obj.getActuals()[f.getVertexs()[f.getVertexs().Count - 1]].getX());
				y1 = (int)(250 + obj.getActuals()[f.getVertexs()[f.getVertexs().Count - 1]].getY());
				x2 = (int)(330 + obj.getActuals()[f.getVertexs()[0]].getX());
				y2 = (int)(250 + obj.getActuals()[f.getVertexs()[0]].getY());
				bresenham(bdma, x1, y1, x2, y2);
			}

			b.UnlockBits(bdma);

			return b;
		}*/

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

		private static int limiter(int limmin, int limmax, int number)
        {
			if (number > limmax)
				number = limmax;
			else if (number < limmin)
				number = limmin;

			return number;
        }
	}
}