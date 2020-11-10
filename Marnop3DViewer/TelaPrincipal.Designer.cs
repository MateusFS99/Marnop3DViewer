namespace Marnop3DViewer
{
	partial class TelaPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
			this.pbPrincipal = new System.Windows.Forms.PictureBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.btAbrir = new System.Windows.Forms.Button();
			this.btLimpar = new System.Windows.Forms.Button();
			this.gbFormato = new System.Windows.Forms.GroupBox();
			this.rbSolido = new System.Windows.Forms.RadioButton();
			this.rbAramado = new System.Windows.Forms.RadioButton();
			this.btColor = new System.Windows.Forms.Button();
			this.pbColor = new System.Windows.Forms.PictureBox();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.pbLight = new System.Windows.Forms.PictureBox();
			this.btInfo = new System.Windows.Forms.Button();
			this.btConfig = new System.Windows.Forms.Button();
			this.pnFuncoes = new System.Windows.Forms.Panel();
			this.cbIluminacao = new System.Windows.Forms.ComboBox();
			this.cbfaceo = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).BeginInit();
			this.gbFormato.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
			this.pnFuncoes.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbPrincipal
			// 
			this.pbPrincipal.BackColor = System.Drawing.Color.Black;
			this.pbPrincipal.Cursor = System.Windows.Forms.Cursors.Cross;
			this.pbPrincipal.Location = new System.Drawing.Point(12, 59);
			this.pbPrincipal.Name = "pbPrincipal";
			this.pbPrincipal.Size = new System.Drawing.Size(660, 500);
			this.pbPrincipal.TabIndex = 1;
			this.pbPrincipal.TabStop = false;
			this.pbPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPrincipal_Paint);
			this.pbPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPrincipal_MouseDown);
			this.pbPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPrincipal_MouseMove);
			this.pbPrincipal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPrincipal_MouseUp);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// btAbrir
			// 
			this.btAbrir.BackColor = System.Drawing.Color.Black;
			this.btAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btAbrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.btAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAbrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.btAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btAbrir.Image")));
			this.btAbrir.Location = new System.Drawing.Point(12, 18);
			this.btAbrir.Name = "btAbrir";
			this.btAbrir.Size = new System.Drawing.Size(120, 35);
			this.btAbrir.TabIndex = 1;
			this.btAbrir.Text = "Abrir";
			this.btAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btAbrir.UseVisualStyleBackColor = false;
			this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
			// 
			// btLimpar
			// 
			this.btLimpar.BackColor = System.Drawing.Color.Black;
			this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
			this.btLimpar.Location = new System.Drawing.Point(138, 18);
			this.btLimpar.Name = "btLimpar";
			this.btLimpar.Size = new System.Drawing.Size(120, 35);
			this.btLimpar.TabIndex = 2;
			this.btLimpar.Text = "Limpar";
			this.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btLimpar.UseVisualStyleBackColor = false;
			this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
			// 
			// gbFormato
			// 
			this.gbFormato.Controls.Add(this.rbSolido);
			this.gbFormato.Controls.Add(this.rbAramado);
			this.gbFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbFormato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.gbFormato.Location = new System.Drawing.Point(678, 2);
			this.gbFormato.Name = "gbFormato";
			this.gbFormato.Size = new System.Drawing.Size(314, 52);
			this.gbFormato.TabIndex = 3;
			this.gbFormato.TabStop = false;
			this.gbFormato.Text = "Formato";
			this.gbFormato.Paint += new System.Windows.Forms.PaintEventHandler(this.gbFormato_Paint);
			// 
			// rbSolido
			// 
			this.rbSolido.AutoSize = true;
			this.rbSolido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbSolido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.rbSolido.Image = ((System.Drawing.Image)(resources.GetObject("rbSolido.Image")));
			this.rbSolido.Location = new System.Drawing.Point(174, 15);
			this.rbSolido.Name = "rbSolido";
			this.rbSolido.Size = new System.Drawing.Size(125, 33);
			this.rbSolido.TabIndex = 5;
			this.rbSolido.TabStop = true;
			this.rbSolido.Text = "Sólido";
			this.rbSolido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbSolido.UseVisualStyleBackColor = true;
			this.rbSolido.CheckedChanged += new System.EventHandler(this.rbSolido_CheckedChanged);
			// 
			// rbAramado
			// 
			this.rbAramado.AutoSize = true;
			this.rbAramado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbAramado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.rbAramado.Image = ((System.Drawing.Image)(resources.GetObject("rbAramado.Image")));
			this.rbAramado.Location = new System.Drawing.Point(16, 16);
			this.rbAramado.Name = "rbAramado";
			this.rbAramado.Size = new System.Drawing.Size(152, 33);
			this.rbAramado.TabIndex = 4;
			this.rbAramado.TabStop = true;
			this.rbAramado.Text = "Aramado";
			this.rbAramado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.rbAramado.UseVisualStyleBackColor = true;
			// 
			// btColor
			// 
			this.btColor.BackColor = System.Drawing.Color.Black;
			this.btColor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.btColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.btColor.Image = ((System.Drawing.Image)(resources.GetObject("btColor.Image")));
			this.btColor.Location = new System.Drawing.Point(264, 18);
			this.btColor.Name = "btColor";
			this.btColor.Size = new System.Drawing.Size(120, 35);
			this.btColor.TabIndex = 3;
			this.btColor.Text = "Cor";
			this.btColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btColor.UseVisualStyleBackColor = false;
			this.btColor.Click += new System.EventHandler(this.btColor_Click);
			// 
			// pbColor
			// 
			this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbColor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbColor.Location = new System.Drawing.Point(349, 23);
			this.pbColor.Name = "pbColor";
			this.pbColor.Size = new System.Drawing.Size(26, 23);
			this.pbColor.TabIndex = 4;
			this.pbColor.TabStop = false;
			this.pbColor.Click += new System.EventHandler(this.btColor_Click);
			// 
			// pbLight
			// 
			this.pbLight.BackColor = System.Drawing.Color.Black;
			this.pbLight.Cursor = System.Windows.Forms.Cursors.NoMove2D;
			this.pbLight.Image = ((System.Drawing.Image)(resources.GetObject("pbLight.Image")));
			this.pbLight.InitialImage = null;
			this.pbLight.Location = new System.Drawing.Point(631, 67);
			this.pbLight.Name = "pbLight";
			this.pbLight.Size = new System.Drawing.Size(32, 36);
			this.pbLight.TabIndex = 5;
			this.pbLight.TabStop = false;
			this.pbLight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLight_MouseDown);
			this.pbLight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLight_MouseMove);
			this.pbLight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLight_MouseUp);
			// 
			// btInfo
			// 
			this.btInfo.BackColor = System.Drawing.Color.Black;
			this.btInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.btInfo.Image = ((System.Drawing.Image)(resources.GetObject("btInfo.Image")));
			this.btInfo.Location = new System.Drawing.Point(679, 60);
			this.btInfo.Name = "btInfo";
			this.btInfo.Size = new System.Drawing.Size(142, 43);
			this.btInfo.TabIndex = 6;
			this.btInfo.Text = "Informações";
			this.btInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btInfo.UseVisualStyleBackColor = false;
			this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
			// 
			// btConfig
			// 
			this.btConfig.BackColor = System.Drawing.Color.Black;
			this.btConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btConfig.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.btConfig.Image = ((System.Drawing.Image)(resources.GetObject("btConfig.Image")));
			this.btConfig.Location = new System.Drawing.Point(826, 60);
			this.btConfig.Name = "btConfig";
			this.btConfig.Size = new System.Drawing.Size(166, 43);
			this.btConfig.TabIndex = 7;
			this.btConfig.Text = "Configurações";
			this.btConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btConfig.UseVisualStyleBackColor = false;
			this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
			// 
			// pnFuncoes
			// 
			this.pnFuncoes.Controls.Add(this.cbfaceo);
			this.pnFuncoes.Controls.Add(this.cbIluminacao);
			this.pnFuncoes.Location = new System.Drawing.Point(679, 101);
			this.pnFuncoes.Name = "pnFuncoes";
			this.pnFuncoes.Size = new System.Drawing.Size(313, 457);
			this.pnFuncoes.TabIndex = 6;
			this.pnFuncoes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnFuncoes_Paint);
			// 
			// cbIluminacao
			// 
			this.cbIluminacao.BackColor = System.Drawing.Color.Black;
			this.cbIluminacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbIluminacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbIluminacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.cbIluminacao.FormattingEnabled = true;
			this.cbIluminacao.Location = new System.Drawing.Point(4, 9);
			this.cbIluminacao.Name = "cbIluminacao";
			this.cbIluminacao.Size = new System.Drawing.Size(130, 24);
			this.cbIluminacao.TabIndex = 8;
			this.cbIluminacao.Text = "Iluminação";
			// 
			// cbfaceo
			// 
			this.cbfaceo.AutoSize = true;
			this.cbfaceo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbfaceo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.cbfaceo.Location = new System.Drawing.Point(4, 39);
			this.cbfaceo.Name = "cbfaceo";
			this.cbfaceo.Size = new System.Drawing.Size(130, 24);
			this.cbfaceo.TabIndex = 9;
			this.cbfaceo.Text = "Faces Ocultas";
			this.cbfaceo.UseVisualStyleBackColor = true;
			// 
			// TelaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1004, 571);
			this.Controls.Add(this.pnFuncoes);
			this.Controls.Add(this.pbLight);
			this.Controls.Add(this.pbColor);
			this.Controls.Add(this.gbFormato);
			this.Controls.Add(this.btColor);
			this.Controls.Add(this.btConfig);
			this.Controls.Add(this.btInfo);
			this.Controls.Add(this.btAbrir);
			this.Controls.Add(this.btLimpar);
			this.Controls.Add(this.pbPrincipal);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "TelaPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Marnop3DViewer";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaPrincipal_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TelaPrincipal_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).EndInit();
			this.gbFormato.ResumeLayout(false);
			this.gbFormato.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
			this.pnFuncoes.ResumeLayout(false);
			this.pnFuncoes.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pbPrincipal;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button btAbrir;
		private System.Windows.Forms.Button btLimpar;
		private System.Windows.Forms.GroupBox gbFormato;
		private System.Windows.Forms.Button btColor;
		private System.Windows.Forms.PictureBox pbColor;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.PictureBox pbLight;
		private System.Windows.Forms.RadioButton rbSolido;
		private System.Windows.Forms.RadioButton rbAramado;
		private System.Windows.Forms.Button btInfo;
		private System.Windows.Forms.Button btConfig;
		private System.Windows.Forms.Panel pnFuncoes;
		private System.Windows.Forms.ComboBox cbIluminacao;
		private System.Windows.Forms.CheckBox cbfaceo;
	}
}

