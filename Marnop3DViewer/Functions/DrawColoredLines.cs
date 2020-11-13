using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marnop3DViewer.Functions
{
	class DrawColoredLines
	{

		public static void drawGroupBox(Graphics g, System.Windows.Forms.GroupBox gbFormato)
		{
			Brush borderBrush = new SolidBrush(Color.FromArgb(0, 151, 230));
			Pen borderPen = new Pen(borderBrush);
			SizeF strSize = g.MeasureString(gbFormato.Text, gbFormato.Font);
			Rectangle rect = new Rectangle(gbFormato.ClientRectangle.X,
										   gbFormato.ClientRectangle.Y + (int)(strSize.Height / 2),
										   gbFormato.ClientRectangle.Width - 1,
										   gbFormato.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

			g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
			g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
			g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
			g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + gbFormato.Padding.Left, rect.Y));
			g.DrawLine(borderPen, new Point(rect.X + gbFormato.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
		}

		public static void drawPictureBox(Graphics g, System.Windows.Forms.PictureBox pbPrincipal)
		{
			Brush borderBrush = new SolidBrush(Color.FromArgb(0, 151, 230));
			Pen borderPen = new Pen(borderBrush);
			SizeF strSize = g.MeasureString(pbPrincipal.Text, pbPrincipal.Font);
			Rectangle rect = new Rectangle(pbPrincipal.ClientRectangle.X,
										   pbPrincipal.ClientRectangle.Y + (int)(strSize.Height / 2),
										   pbPrincipal.ClientRectangle.Width - 1,
										   pbPrincipal.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

			g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
			g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
			g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
			g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + pbPrincipal.Padding.Left, rect.Y));
			g.DrawLine(borderPen, new Point(rect.X + pbPrincipal.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
		}

		public static void drawPanel(Graphics g, System.Windows.Forms.Panel pnFuncoes)
		{
			Brush borderBrush = new SolidBrush(Color.FromArgb(0, 151, 230));
			Pen borderPen = new Pen(borderBrush);
			SizeF strSize = g.MeasureString(pnFuncoes.Text, pnFuncoes.Font);
			Rectangle rect = new Rectangle(pnFuncoes.ClientRectangle.X,
										   pnFuncoes.ClientRectangle.Y + (int)(strSize.Height / 2),
										   pnFuncoes.ClientRectangle.Width - 1,
										   pnFuncoes.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

			g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
			g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
			g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
			g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + pnFuncoes.Padding.Left, rect.Y));
			g.DrawLine(borderPen, new Point(rect.X + pnFuncoes.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
		}
	}
}
