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
		private int x1, y1, x2, y2, lx, ly;
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
			lx = 330;
			ly = 10;
			ambiente = Color.FromArgb(255,0,0,255);
			difusa = Color.FromArgb(255,0, 128, 255);
			especular = Color.FromArgb(255,255, 255, 255);
			rbAramado.Checked = true;
			this.pbPrincipal.MouseWheel += pbPrincipal_MouseWheel;
			exibeTab("info");
		}

		private void exibeTab(String tab)
		{
			Color valada = Color.FromArgb(0, 151, 230), info = Color.Black, config = Color.Black;

			if (tab.Equals("info"))
				info = valada;
			else if (tab.Equals("config"))
				config = valada;

			cbPreenchimento.Visible = tab.Equals("config");
			cbAxonometrica.Visible = tab.Equals("config");
			cbfaceo.Visible = tab.Equals("config");
			lambiente.Visible = tab.Equals("config");
			pbAmbiente.Visible = tab.Equals("config");
			ldifusa.Visible = tab.Equals("config");
			pbDifusa.Visible = tab.Equals("config");
			lespecular.Visible = tab.Equals("config");
			pbEspecular.Visible = tab.Equals("config");

			btInfo.FlatAppearance.BorderColor = info;
			btConfig.FlatAppearance.BorderColor = config;
		}

		private void desenhaObjeto(Bitmap b)
		{
			if (rbAramado.Checked)
				mudaAxonometrica(b);
			else
				pbPrincipal.Image = Utils.drawObjectSolid(actobj, b, new Vertex(0, 1, 1), ambiente, difusa, especular, fill);
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
				desenhaObjeto(b);
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
				lx = this.PointToClient(MousePosition).X;
				ly = this.PointToClient(MousePosition).Y;
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

		private void rbSolido_CheckedChanged(object sender, EventArgs e)
		{
			Bitmap b = new Bitmap(pbPrincipal.Width, pbPrincipal.Height);

			if (rbSolido.Checked)
				pbPrincipal.Image = Utils.drawObjectSolid(actobj, b, new Vertex(0, 1, 1), ambiente, difusa, especular, fill);
			else
				pbPrincipal.Image = Utils.drawObjectWire(actobj, b, cbfaceo.Checked);
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

				desenhaObjeto(b);
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
					actobj.setNewActuals();
					actobj.setNFaces();
					desenhaObjeto(b);
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
					actobj.setNFaces();
					desenhaObjeto(b);

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
				
			actobj.setNewActuals();
			actobj.setNFaces();
			desenhaObjeto(b);
		}
	}
}
