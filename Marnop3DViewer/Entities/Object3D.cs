using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Marnop3DViewer
{
    class Object3D
    {
        private double[,] ma;
        private List<Face> faces;
        private List<Vertex> actuals;
        private List<Vertex> originals;

        public Object3D()
        {
            ma = new double[,] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            faces = new List<Face>();
            actuals = new List<Vertex>();
            originals = new List<Vertex>();
        }   

        public Object3D(List<Face> faces, List<Vertex> actuals, List<Vertex> originals)
        {
            ma = new double[,] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            this.faces = faces;
            this.actuals = actuals;
            this.originals = originals;
        }

        public void scale(double x, double y, double z)
        {
            double[,] aux2 = new double[,] { { x, 0, 0, 0}, { 0, y, 0, 0}, { 0, 0, z, 0}, { 0, 0, 0, 1 } };

            multiplyMatrix(aux2);
        }

        public void translation(int x, int y, int z)
        {
            double[,] aux2 = new double[,] { { 1, 0, 0, x}, { 0, 1, 0, y}, { 0, 0, 1, z}, { 0, 0, 0, 1 } };

            multiplyMatrix(aux2);
        }

        public void rotationZ(int grau)
        {
            double[,] aux2 = new double[,] { { Math.Cos(grau*Math.PI/180), -Math.Sin(grau * Math.PI / 180), 0 ,0},
                { Math.Sin(grau * Math.PI / 180), Math.Cos(grau * Math.PI / 180), 0, 0}, { 0, 0, 1 , 0}, { 0, 0, 0 , 1}};

            multiplyMatrix(aux2);
        }

        public void rotationX(int grau)
        {
            double[,] aux2 = new double[,] { { 1, 0, 0 ,0},
                { 0, Math.Cos(grau*Math.PI/180), -Math.Sin(grau * Math.PI / 180), 0},
                { 0, Math.Sin(grau * Math.PI / 180), Math.Cos(grau * Math.PI / 180) , 0}, { 0, 0, 0 , 1}};

            multiplyMatrix(aux2);
        }

        public void rotationY(int grau)
        {
            double[,] aux2 = new double[,] { { Math.Cos(grau*Math.PI/180), 0, Math.Sin(grau * Math.PI / 180), 0},
                { 0, 1, 0 ,0 }, { -Math.Sin(grau * Math.PI / 180), 0, Math.Cos(grau * Math.PI / 180) , 0}, { 0, 0, 0 , 1}};

            multiplyMatrix(aux2);
        }

        public void setNewActuals()
        {
            actuals = null;
            actuals = new List<Vertex>();
            foreach (Vertex p in originals)
            {
                actuals.Add(new Vertex(Convert.ToDouble(ma[0, 0] * p.getX() + ma[0, 1] * p.getY() + ma[0, 2] * p.getZ() + ma[0,3]),
                    Convert.ToDouble(ma[1, 0] * p.getX() + ma[1, 1] * p.getY() + ma[1, 2] * p.getZ() + ma[1, 3]), 
                    Convert.ToDouble(ma[2, 0] * p.getX() + ma[2, 1] * p.getY() + ma[2, 2] * p.getZ() + ma[2, 3])));
            }
        }

        private void multiplyMatrix(double[,] maux)
        {
            double[,] aux = new double[4, 4];
            for (int i = 0; i < 4; i++)
            {
                aux[i, 0] = maux[i, 0] * ma[0, 0] + maux[i, 1] * ma[1, 0] + maux[i, 2] * ma[2, 0] + maux[i, 3] * ma[3, 0];
                aux[i, 1] = maux[i, 0] * ma[0, 1] + maux[i, 1] * ma[1, 1] + maux[i, 2] * ma[2, 1] + maux[i, 3] * ma[3, 1];
                aux[i, 2] = maux[i, 0] * ma[0, 2] + maux[i, 1] * ma[1, 2] + maux[i, 2] * ma[2, 2] + maux[i, 3] * ma[3, 2];
                aux[i, 3] = maux[i, 0] * ma[0, 3] + maux[i, 1] * ma[1, 3] + maux[i, 2] * ma[2, 3] + maux[i, 3] * ma[3, 3];
            }
            ma = aux;
        }

        public double[,] getMA()
        {
            return ma;
        }

        public void addActuals(Vertex v)
        {
            actuals.Add(v);
        }

        public void addOriginals(Vertex v)
        {
            originals.Add(v);
        }

        public void addFaces(Face f)
        {
            faces.Add(f);
        }

        public List<Vertex> getActuals()
        {
            return actuals;
        }

        public List<Vertex> getOriginals()
        {
            return originals;
        }

        public List<Face> getFaces()
        {
            return faces;
        }

        public void setFaces(List<Face> l)
        {
            faces = l;
        }

        public void setActuals(List<Vertex> l)
        {
            actuals = l;
        }

        public void setOriginals(List<Vertex> l)
        {
            originals = l;
        }
    }
}