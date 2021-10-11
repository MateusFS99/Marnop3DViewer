using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marnop3DViewer.Entities
{
	class NoScan
	{
		private double ymax, incx, xmin;

		public NoScan(double ymax, double xmin, double incx)
		{
			this.ymax = ymax;
			this.xmin = xmin;
			this.incx = incx;
		}

		public double Ymax { get => ymax; set => ymax = value; }
		public double Xmin { get => xmin; set => xmin = value; }
		public double Incx { get => incx; set => incx = value; }
	}
}
