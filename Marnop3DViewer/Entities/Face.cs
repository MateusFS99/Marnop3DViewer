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
        private Vertex vnormal;

        public Face()
        {
            vertex = new List<int>();
            vnormal = new Vertex();
        }

        public Face(List<int> vertices, Vertex vnormal)
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

        public void setNormal(Vertex n)
        {
            vnormal = n;
        }

        public Vertex getNormal()
        {
            return vnormal;
        }

    }
}