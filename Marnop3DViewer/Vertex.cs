using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marnop3DViewer
{
    class Vertex
    {
        private double x, y, z;

        public Vertex()
        {
        }

        public Vertex(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public double getZ()
        {
            return z;
        }

        public void setX(double x)
        {
            this.x = x;
        }

        public void setY(double y)
        {
            this.y = y;
        }

        public void setZ(double z)
        {
            this.z = z;
        }

    }
}
