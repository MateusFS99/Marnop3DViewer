using System;
using System.Collections.Generic;
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
            while(line.Length != 0)
            {
                s = line.Split(' ');
                //add
                if (s[0].Equals("v"))
                    obj.addOriginals(new Vertex(Convert.ToDouble(s[1]), Convert.ToDouble(s[2]), Convert.ToDouble(s[3])));
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
            obj.setActuals(obj.GetOriginals());

            return obj;
        }
    }
}
