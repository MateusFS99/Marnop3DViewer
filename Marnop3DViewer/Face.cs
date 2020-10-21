using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marnop3DViewer
{
    class Face
    {
        private int[] vertices;
        private double vnormal;

        public Face()
        {
            vertices = new int[3];
        }

        public Face(int[] vertices, double vnormal)
        {
            this.vertices = vertices;
            this.vnormal = vnormal;
        }

        public void setVertice(int index, int v)
        {
            vertices[index] = v;
        }

        public int [] getVertices()
        {
            return vertices;
        }

        public void setNormal(double n)
        {
            vnormal = n;
        }

        public double getNormal()
        {
            return vnormal;
        }
    }
}
