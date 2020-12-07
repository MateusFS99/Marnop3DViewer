using Marnop3DViewer.Functions;
using System;
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
		private int x1, y1, x2, y2, lx1, ly1,lx2, ly2;
		private bool dragging, shift, ctrl;
		private String fill;
		private Color ambiente, difusa, especular;
		private Object3D actobj;

		public TelaPrincipal()
		{
			InitializeComponent();
			shift = false;
			ctrl = false;
			fill = "Flat";
			pbAmbiente.BackColor = Color.Blue;
			pbDifusa.BackColor = Color.Blue;
			pbEspecular.BackColor = Color.Blue;
			lx1 = 700;
			ly1 = 100;
			ambiente = Color.FromArgb(255,0,0,255);
			difusa = Color.FromArgb(255,0, 128, 255);
			especular = Color.FromArgb(255,255, 255, 255);
			rbAramado.Checked = true;
			this.pbPrincipal.MouseWheel += pbPrincipal_MouseWheel;
			exibeTab("config");
		}

		private void exibeTab(String tab)
		{
			Color valada = Color.FromArgb(0, 151, 230), info = Color.Black, config = Color.Black;

			if (tab.Equals("info"))
				info = valada;
			else if (tab.Equals("config"))
				config = valada;

			label1.Visible = tab.Equals("info");
			label2.Visible = tab.Equals("info");
			label3.Visible = tab.Equals("info");
			label4.Visible = tab.Equals("info");
			label5.Visible = tab.Equals("info");
			label6.Visible = tab.Equals("info");
			label7.Visible = tab.Equals("info");
			label8.Visible = tab.Equals("info");
			label9.Visible = tab.Equals("info");
			label10.Visible = tab.Equals("info");
			cbPreenchimento.Visible = tab.Equals("config");
			cbAxonometrica.Visible = tab.Equals("config");
			cbfaceo.Visible = tab.Equals("config");
			lambiente.Visible = tab.Equals("config");
			pbAmbiente.Visible = tab.Equals("config");
			ldifusa.Visible = tab.Equals("config");
			pbDifusa.Visible = tab.Equals("config");
			lespecular.Visible = tab.Equals("config");
			pbEspecular.Visible = tab.Equals("config");
			cbProjecoes.Visible = tab.Equals("config");
			lbDist.Visible = tab.Equals("config");
			tbDistancia.Visible = tab.Equals("config");

			btInfo.FlatAppearance.BorderColor = info;
			btConfig.FlatAppearance.BorderColor = config;
		}

		private void desenhaObjeto(char op)
		{
			Bitmap b = new Bitmap(pbPrincipal.Width,pbPrincipal.Height);
			double lux, luy,xp = 1,yp = 1,vx = 336,vy = 240;
			
			lux = -xp*((lx1 - vx) / 400.0);
			luy = -yp * ((ly1 - vy) / 500.0); 
			if (op == 'a')
			{
				if (rbAramado.Checked)
					mudaAxonometrica(b);
				else
					pbPrincipal.Image = Utils.drawObjectSolid(actobj, b, new Vertex(lux, luy, 1), ambiente, difusa, especular, fill);
			}
			else if (op == 'p')
			{
				if (cbProjecoes.Text.Equals("Cabinet"))
					actobj.setCavalierCabinet(0.5, 45);
				else if (cbProjecoes.Text.Equals("Cavalier"))
					actobj.setCavalierCabinet(1, 45);
				else if (tbDistancia.Text != "")
					actobj.setNewActualsP(Convert.ToInt32(tbDistancia.Text));
				else
					MessageBox.Show("Distância não definida!", "Erro!", MessageBoxButtons.OK);
				if (rbAramado.Checked)
					pbPrincipal.Image = Utils.drawObjectWire(actobj, b,cbfaceo.Checked);
				else
					pbPrincipal.Image = Utils.drawObjectSolid(actobj, b, new Vertex(lux, luy, 1), ambiente, difusa, especular, fill);
			}
		}

		private void mudaAxonometrica(Bitmap b)
		{
			if (cbAxonometrica.Text.Equals("Z,Y"))
				pbPrincipal.Image = Utils.drawObjectZY(actobj, b);
			else if (cbAxonometrica.Text.Equals("X,Z"))
				pbPrincipal.Image = Utils.drawObjectXZ(actobj, b);
			else
				pbPrincipal.Image = Utils.drawObjectWire(actobj, b, cbfaceo.Checked);
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
				desenhaObjeto('a');
				this.Text = "Marnop3DViewer - " + openFileDialog.FileName;
			}
		}

		private void btLimpar_Click(object sender, EventArgs e)
		{
			pbPrincipal.Image = null;
			this.Text = "Marnop3DViewer";
		}

		private void gbFormato_Paint(object sender, PaintEventArgs e)
		{
			DrawColoredLines.drawGroupBox(e.Graphics,gbFormato);
		}

		private void pbPrincipal_Paint(object sender, PaintEventArgs e)
		{
			DrawColoredLines.drawPictureBox(e.Graphics,pbPrincipal);
		}

		private void pnFuncoes_Paint(object sender, PaintEventArgs e)
		{
			DrawColoredLines.drawPanel(e.Graphics,pnFuncoes);
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
				if(rbSolido.Checked)
                {
					int lux, luy;
					lx2 = this.PointToClient(MousePosition).X;
					ly2 = this.PointToClient(MousePosition).Y;
					if (Math.Abs(lx2 - lx1) > 20 || Math.Abs(ly2 - ly1) > 20)
					{
						lx1 = lx2;
						ly1 = ly2;
						desenhaObjeto('a');
					}
					MPosition = this.PointToClient(MousePosition);
					MPosition.Offset(mousex, mousey);
				}
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

		private void rbSolido_CheckedChanged(object sender, EventArgs e)
		{
			desenhaObjeto('a');
		}

		private void btInfo_Click(object sender, EventArgs e)
		{
			exibeTab("info");
		}

		private void btConfig_Click(object sender, EventArgs e)
		{
			exibeTab("config");
		}

		private void pbAmbiente_Click(object sender, EventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			if (colorPicker.ShowDialog() == DialogResult.OK)
				ambiente = pbAmbiente.BackColor = colorPicker.Color;
		}

		private void pbDifusa_Click(object sender, EventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			if (colorPicker.ShowDialog() == DialogResult.OK)
				difusa = pbDifusa.BackColor = colorPicker.Color;
		}

		private void pbEspecular_Click(object sender, EventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			if (colorPicker.ShowDialog() == DialogResult.OK)
				especular = pbEspecular.BackColor = colorPicker.Color;
		}

		private void pbLight_Click(object sender, EventArgs e)
        {

        }

		private void cbProjecoes_SelectedIndexChanged(object sender, EventArgs e)
		{
			desenhaObjeto('p');
		}

		private void cbPreenchimento_SelectedIndexChanged(object sender, EventArgs e)
		{
			fill = cbPreenchimento.Text;
		}

        private void lambiente_Click(object sender, EventArgs e)
        {
			ColorDialog colorPicker = new ColorDialog();

			if (colorPicker.ShowDialog() == DialogResult.OK)
				ambiente = pbAmbiente.BackColor = colorPicker.Color;
		}

		private void ldifusa_Click(object sender, EventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			if (colorPicker.ShowDialog() == DialogResult.OK)
				difusa = pbDifusa.BackColor = colorPicker.Color;
		}

		private void lespecular_Click(object sender, EventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			if (colorPicker.ShowDialog() == DialogResult.OK)
				especular = pbEspecular.BackColor = colorPicker.Color;
		}

		private void cbIsometrica_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (actobj != null)
			{
				Bitmap b = new Bitmap(pbPrincipal.Width, pbPrincipal.Height);

				desenhaObjeto('a');
			}
			else
				MessageBox.Show("Nenhum Objeto aberto!", "Erro!", MessageBoxButtons.OK);
		}

		private void TelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.ShiftKey)
			{
				//shift down
				shift = true;
			}
			if (e.KeyCode == Keys.ControlKey)
			{
				//ctrl down
				ctrl = true;
			}
		}

        private void TelaPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.ShiftKey)
			{
				//shift up
				shift = false;
			}
			if (e.KeyCode == Keys.ControlKey)
			{
				//ctrl up
				ctrl = false;
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
					actobj.setNFaces();
					if (tbDistancia.Text == "")
					{
						actobj.setNewActuals();
						desenhaObjeto('a');
					}
					else
						desenhaObjeto('p');

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
					actobj.setNFaces();
					if (tbDistancia.Text == "")
					{
						actobj.setNewActuals();
						desenhaObjeto('a');
					}
					else
						desenhaObjeto('p');

					x1 = x2;
					y1 = y2;
				}
			}
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
				if (shift)
					actobj.rotationZ(-8);
				else if (ctrl)
					actobj.translation(0, 0, -2);
				else
					actobj.scale(0.8, 0.8, 0.8);
			}
			//scroll up
			else
            {
				if (shift)
					actobj.rotationZ(8);
				else if (ctrl)
					actobj.translation(0, 0, 2);
				else 
					actobj.scale(1.2, 1.2, 1.2);
			}
			
			actobj.setNFaces();
			if(tbDistancia.Text == "")
			{
				actobj.setNewActuals();
				desenhaObjeto('a');
			}
			else
				desenhaObjeto('p');
		}
	}
}
