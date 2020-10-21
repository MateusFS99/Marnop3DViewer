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

        public List<Vertex> GetActuals()
        {
            return actuals;
        }

        public List<Vertex> GetOriginals()
        {
            return originals;
        }

        public List<Face> GetFaces()
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
