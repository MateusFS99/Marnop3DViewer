﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marnop3DViewer
{
	public partial class TelaPrincipal : Form
	{
		private int mousex, mousey;
		private bool dragging;
		private Color cor;
		private Object3D actobj;
		private int x1, y1, x2, y2;

		public TelaPrincipal()
		{
			InitializeComponent();
			this.pbPrincipal.MouseWheel += pbPrincipal_MouseWheel;
			exibeTab("info");
		}

		private void drawGroupBox(Graphics g)
		{
			Brush borderBrush = new SolidBrush(Color.FromArgb(0, 151, 230));
			Pen borderPen = new Pen(borderBrush);
			SizeF strSize = g.MeasureString(this.gbFormato.Text, gbFormato.Font);
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

		private void drawPane(Graphics g)
		{
			Brush borderBrush = new SolidBrush(Color.FromArgb(0, 151, 230));
			Pen borderPen = new Pen(borderBrush);
			SizeF strSize = g.MeasureString(this.pnFuncoes.Text, pnFuncoes.Font);
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

		private void exibeTab(String tab)
		{
			Color valada = Color.FromArgb(0, 151, 230), info = Color.Black, config = Color.Black;

			if (tab.Equals("info"))
			{
				info = valada;
			}
			else if (tab.Equals("config"))
			{
				config = valada;
			}
			cbIluminacao.Visible = tab.Equals("config");
			btInfo.FlatAppearance.BorderColor = info;
			btConfig.FlatAppearance.BorderColor = config;
		}

		private void btAbrir_Click(object sender, EventArgs e)
		{
			Bitmap b = new Bitmap(pbPrincipal.Width,pbPrincipal.Height);
			openFileDialog.FileName = "";
			openFileDialog.Filter = "Arquivos (*.obj)|*.obj";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				actobj = Utils.readObj(File.OpenText(openFileDialog.FileName));
				pbPrincipal.Image = null;
				rbAramado.Checked = true;
				pbPrincipal.Image = Utils.drawObject(actobj,b);
			}
		}

		private void btLimpar_Click(object sender, EventArgs e)
		{
			pbPrincipal.Image = null;
		}

		private void btColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			if (colorPicker.ShowDialog() == DialogResult.OK)
				cor = pbColor.BackColor = colorPicker.Color;
		}

		private void gbFormato_Paint(object sender, PaintEventArgs e)
		{
			drawGroupBox(e.Graphics);
		}

		private void pnFuncoes_Paint(object sender, PaintEventArgs e)
		{
			drawPane(e.Graphics);
		}

		private void pbLight_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				int clipleft = this.PointToClient(MousePosition).X - pbLight.Location.X;
				int cliptop = this.PointToClient(MousePosition).Y - pbLight.Location.Y;
				int clipwidth = this.ClientSize.Width - (pbLight.Width - clipleft);
				int clipheight = this.ClientSize.Height - (pbLight.Height - cliptop);

				dragging = true;
				mousex = -e.X;
				mousey = -e.Y;
				Cursor.Clip = this.RectangleToScreen(new Rectangle(clipleft, cliptop, clipwidth, clipheight));
				pbLight.Invalidate();
			}
		}

		private void pbLight_MouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point MPosition = new Point();

				MPosition = this.PointToClient(MousePosition);
				MPosition.Offset(mousex, mousey);
				if(MPosition.X >= 12 && MPosition.Y >= 59 && MPosition.X <= 640 && MPosition.Y <= 523)
					pbLight.Location = MPosition;
			}
		}

		private void pbLight_MouseUp(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				dragging = false;
				Cursor.Clip = System.Drawing.Rectangle.Empty;
				pbLight.Invalidate();
			}
		}

		private void btInfo_Click(object sender, EventArgs e)
		{
			exibeTab("info");
		}

		private void btConfig_Click(object sender, EventArgs e)
		{
			exibeTab("config");
		}

        private void TelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Control)
			{
				//shift pressionado
			}
			if (e.KeyCode == Keys.Shift)
			{
				//ctrl pressionado
			}
		}

        private void TelaPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Control)
			{
				//shift pressionado
			}
			if (e.KeyCode == Keys.Shift)
			{
				//ctrl pressionado
			}
		}

        private void pbPrincipal_MouseMove(object sender, MouseEventArgs e)
		{
			x2 = e.X;
			y2 = e.Y;
			int dx = x2 - x1;
			int dy = y2 - y1;
			if (e.Button == MouseButtons.Left)
			{
				//x, y rotation
				if (Math.Abs(dx) > 7 || Math.Abs(dy) > 7)
                {
					Bitmap b = new Bitmap(pbPrincipal.Width, pbPrincipal.Height);
					actobj.rotationX(dy);
					actobj.rotationY(-dx);
					actobj.setNewActuals();
					pbPrincipal.Image = Utils.drawObject(actobj, b);

					x1 = x2;
					y1 = y2;
				}
					
			}
			else if (e.Button == MouseButtons.Right && actobj != null)
			{
				//x, y translation
				if(Math.Abs(dx) > 15 || Math.Abs(dy) > 15)
                {
					Bitmap b = new Bitmap(pbPrincipal.Width, pbPrincipal.Height);
					actobj.translation(dx, dy, 0);
					actobj.setNewActuals();
					pbPrincipal.Image = Utils.drawObject(actobj, b);

					x1 = x2;
					y1 = y2;
				}
			}
		}

		private void pbPrincipal_MouseUp(object sender, MouseEventArgs e)
		{
			
		}

		private void pbPrincipal_MouseDown(object sender, MouseEventArgs e)
		{
			x1 = e.X;
			y1 = e.Y;
		}

		private void pbPrincipal_MouseWheel(object sender, MouseEventArgs e)
		{
			Bitmap b = new Bitmap(pbPrincipal.Width,pbPrincipal.Height);
			//scroll down
			if (e.Delta < 0)
            {
				//if buttom pressed

				//else 

				actobj.scale(0.8, 0.8, 0.8);
			}
				
			//scroll up
			else
            {
				//if buttom pressed

				//else 
				actobj.scale(1.2, 1.2, 1.2);
			}
				
			actobj.setNewActuals();
			pbPrincipal.Image = Utils.drawObject(actobj, b);
		}
	}
}
