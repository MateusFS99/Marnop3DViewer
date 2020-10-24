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
                //add
                if (s[0].Equals("v"))
                {
					obj.addOriginals(new Vertex(Convert.ToDouble(s[1].Replace(".", ",")), Convert.ToDouble(s[2].Replace(".", ",")), Convert.ToDouble(s[3].Replace(".", ","))));
				}
                    
                //add face
                else if (s[0].Equals("f"))
                {
                    f = new Face();
                    for (int i = 1; i < s.Length; i++)
                    {
                        s1 = s[i].Split('/');
                        f.addVertex(Convert.ToInt32(s1[0])-1);
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

		
	}
}