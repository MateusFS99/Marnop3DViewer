using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marnop3DViewer
{
    class Face
    {
        private List<int> vertex;
        private double vnormal;

        public Face()
        {
            vertex = new List<int>();
        }

        public Face(List<int> vertices, double vnormal)
        {
            this.vertex = vertices;
            this.vnormal = vnormal;
        }

        public void addVertex(int index)
        {
            vertex.Add(index);
        }

        public List<int> getVertexs()
        {
            return vertex;
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