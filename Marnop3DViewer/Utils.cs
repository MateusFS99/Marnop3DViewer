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
            String line = sr.ReadLine();

            return obj;
        }
    }
}
