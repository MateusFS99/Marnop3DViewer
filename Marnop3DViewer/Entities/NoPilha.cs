using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marnop3DViewer.Entities
{
	class NoPilha
	{
		private int x, y;

		public NoPilha(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public int X { get => x; set => x = value; }
		public int Y { get => y; set => y = value; }
	}
}
