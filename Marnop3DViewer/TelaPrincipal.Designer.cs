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
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.pbLight = new System.Windows.Forms.PictureBox();
			this.btInfo = new System.Windows.Forms.Button();
			this.btConfig = new System.Windows.Forms.Button();
			this.pnFuncoes = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbDist = new System.Windows.Forms.Label();
			this.tbDistancia = new System.Windows.Forms.TextBox();
			this.cbProjecoes = new System.Windows.Forms.ComboBox();
			this.cbfaceo = new System.Windows.Forms.CheckBox();
			this.cbAxonometrica = new System.Windows.Forms.ComboBox();
			this.pbEspecular = new System.Windows.Forms.PictureBox();
			this.pbDifusa = new System.Windows.Forms.PictureBox();
			this.pbAmbiente = new System.Windows.Forms.PictureBox();
			this.cbPreenchimento = new System.Windows.Forms.ComboBox();
			this.lespecular = new System.Windows.Forms.Button();
			this.ldifusa = new System.Windows.Forms.Button();
			this.lambiente = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).BeginInit();
			this.gbFormato.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
			this.pnFuncoes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbEspecular)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDifusa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAmbiente)).BeginInit();
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
			this.pbLight.Click += new System.EventHandler(this.pbLight_Click);
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
			this.btInfo.Location = new System.Drawing.Point(850, 60);
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
			this.btConfig.Location = new System.Drawing.Point(679, 59);
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
			this.pnFuncoes.Controls.Add(this.label12);
			this.pnFuncoes.Controls.Add(this.label13);
			this.pnFuncoes.Controls.Add(this.label11);
			this.pnFuncoes.Controls.Add(this.label5);
			this.pnFuncoes.Controls.Add(this.label8);
			this.pnFuncoes.Controls.Add(this.label10);
			this.pnFuncoes.Controls.Add(this.label9);
			this.pnFuncoes.Controls.Add(this.label7);
			this.pnFuncoes.Controls.Add(this.label6);
			this.pnFuncoes.Controls.Add(this.label4);
			this.pnFuncoes.Controls.Add(this.label3);
			this.pnFuncoes.Controls.Add(this.label2);
			this.pnFuncoes.Controls.Add(this.label1);
			this.pnFuncoes.Controls.Add(this.lbDist);
			this.pnFuncoes.Controls.Add(this.tbDistancia);
			this.pnFuncoes.Controls.Add(this.cbProjecoes);
			this.pnFuncoes.Controls.Add(this.cbfaceo);
			this.pnFuncoes.Controls.Add(this.cbAxonometrica);
			this.pnFuncoes.Controls.Add(this.pbEspecular);
			this.pnFuncoes.Controls.Add(this.pbDifusa);
			this.pnFuncoes.Controls.Add(this.pbAmbiente);
			this.pnFuncoes.Controls.Add(this.cbPreenchimento);
			this.pnFuncoes.Controls.Add(this.lespecular);
			this.pnFuncoes.Controls.Add(this.ldifusa);
			this.pnFuncoes.Controls.Add(this.lambiente);
			this.pnFuncoes.Location = new System.Drawing.Point(679, 101);
			this.pnFuncoes.Name = "pnFuncoes";
			this.pnFuncoes.Size = new System.Drawing.Size(313, 457);
			this.pnFuncoes.TabIndex = 6;
			this.pnFuncoes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnFuncoes_Paint);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label5.Location = new System.Drawing.Point(18, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "Traslação:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label8.Location = new System.Drawing.Point(153, 65);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(113, 24);
			this.label8.TabIndex = 13;
			this.label8.Text = "Shift + Scroll";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label10.Location = new System.Drawing.Point(181, 141);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(105, 24);
			this.label10.TabIndex = 13;
			this.label10.Text = "Ctrl + Scroll";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label9.Location = new System.Drawing.Point(18, 141);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(157, 24);
			this.label9.TabIndex = 13;
			this.label9.Text = "Translação em Z:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label7.Location = new System.Drawing.Point(84, 177);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 24);
			this.label7.TabIndex = 13;
			this.label7.Text = "Scroll";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label6.Location = new System.Drawing.Point(18, 177);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 24);
			this.label6.TabIndex = 13;
			this.label6.Text = "Escala:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label4.Location = new System.Drawing.Point(18, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 24);
			this.label4.TabIndex = 13;
			this.label4.Text = "Rotação em Z:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label3.Location = new System.Drawing.Point(117, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 24);
			this.label3.TabIndex = 13;
			this.label3.Text = "Mouse Dir";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label2.Location = new System.Drawing.Point(107, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 24);
			this.label2.TabIndex = 13;
			this.label2.Text = "Mouse Esq";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label1.Location = new System.Drawing.Point(18, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 24);
			this.label1.TabIndex = 13;
			this.label1.Text = "Rotação:";
			// 
			// lbDist
			// 
			this.lbDist.AutoSize = true;
			this.lbDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.lbDist.Location = new System.Drawing.Point(158, 82);
			this.lbDist.Name = "lbDist";
			this.lbDist.Size = new System.Drawing.Size(79, 20);
			this.lbDist.TabIndex = 12;
			this.lbDist.Text = "Distância:";
			// 
			// tbDistancia
			// 
			this.tbDistancia.BackColor = System.Drawing.Color.Black;
			this.tbDistancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.tbDistancia.Location = new System.Drawing.Point(243, 82);
			this.tbDistancia.Name = "tbDistancia";
			this.tbDistancia.Size = new System.Drawing.Size(45, 20);
			this.tbDistancia.TabIndex = 11;
			this.tbDistancia.Text = "700";
			// 
			// cbProjecoes
			// 
			this.cbProjecoes.BackColor = System.Drawing.Color.Black;
			this.cbProjecoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbProjecoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbProjecoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.cbProjecoes.FormattingEnabled = true;
			this.cbProjecoes.Items.AddRange(new object[] {
            "",
            "Cavalier",
            "Cabinet",
            "Perspectiva"});
			this.cbProjecoes.Location = new System.Drawing.Point(22, 82);
			this.cbProjecoes.Name = "cbProjecoes";
			this.cbProjecoes.Size = new System.Drawing.Size(130, 24);
			this.cbProjecoes.TabIndex = 10;
			this.cbProjecoes.SelectedIndexChanged += new System.EventHandler(this.cbProjecoes_SelectedIndexChanged);
			// 
			// cbfaceo
			// 
			this.cbfaceo.AutoSize = true;
			this.cbfaceo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbfaceo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.cbfaceo.Location = new System.Drawing.Point(22, 123);
			this.cbfaceo.Name = "cbfaceo";
			this.cbfaceo.Size = new System.Drawing.Size(130, 24);
			this.cbfaceo.TabIndex = 9;
			this.cbfaceo.Text = "Faces Ocultas";
			this.cbfaceo.UseVisualStyleBackColor = true;
			// 
			// cbAxonometrica
			// 
			this.cbAxonometrica.BackColor = System.Drawing.Color.Black;
			this.cbAxonometrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbAxonometrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAxonometrica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.cbAxonometrica.FormattingEnabled = true;
			this.cbAxonometrica.Items.AddRange(new object[] {
            "",
            "X,Y",
            "Z,Y",
            "X,Z"});
			this.cbAxonometrica.Location = new System.Drawing.Point(158, 27);
			this.cbAxonometrica.Name = "cbAxonometrica";
			this.cbAxonometrica.Size = new System.Drawing.Size(130, 24);
			this.cbAxonometrica.TabIndex = 8;
			this.cbAxonometrica.SelectedIndexChanged += new System.EventHandler(this.cbIsometrica_SelectedIndexChanged);
			// 
			// pbEspecular
			// 
			this.pbEspecular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbEspecular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbEspecular.Location = new System.Drawing.Point(212, 252);
			this.pbEspecular.Name = "pbEspecular";
			this.pbEspecular.Size = new System.Drawing.Size(26, 23);
			this.pbEspecular.TabIndex = 4;
			this.pbEspecular.TabStop = false;
			this.pbEspecular.Click += new System.EventHandler(this.pbEspecular_Click);
			// 
			// pbDifusa
			// 
			this.pbDifusa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbDifusa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbDifusa.Location = new System.Drawing.Point(212, 211);
			this.pbDifusa.Name = "pbDifusa";
			this.pbDifusa.Size = new System.Drawing.Size(26, 23);
			this.pbDifusa.TabIndex = 4;
			this.pbDifusa.TabStop = false;
			this.pbDifusa.Click += new System.EventHandler(this.pbDifusa_Click);
			// 
			// pbAmbiente
			// 
			this.pbAmbiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbAmbiente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbAmbiente.Location = new System.Drawing.Point(213, 170);
			this.pbAmbiente.Name = "pbAmbiente";
			this.pbAmbiente.Size = new System.Drawing.Size(26, 23);
			this.pbAmbiente.TabIndex = 4;
			this.pbAmbiente.TabStop = false;
			this.pbAmbiente.Click += new System.EventHandler(this.pbAmbiente_Click);
			// 
			// cbPreenchimento
			// 
			this.cbPreenchimento.BackColor = System.Drawing.Color.Black;
			this.cbPreenchimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbPreenchimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPreenchimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.cbPreenchimento.FormattingEnabled = true;
			this.cbPreenchimento.Items.AddRange(new object[] {
            "",
            "Flat",
            "Gourard",
            "Phong"});
			this.cbPreenchimento.Location = new System.Drawing.Point(22, 27);
			this.cbPreenchimento.Name = "cbPreenchimento";
			this.cbPreenchimento.Size = new System.Drawing.Size(130, 24);
			this.cbPreenchimento.TabIndex = 8;
			this.cbPreenchimento.SelectedIndexChanged += new System.EventHandler(this.cbPreenchimento_SelectedIndexChanged);
			// 
			// lespecular
			// 
			this.lespecular.BackColor = System.Drawing.Color.Black;
			this.lespecular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lespecular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.lespecular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lespecular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lespecular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.lespecular.Image = ((System.Drawing.Image)(resources.GetObject("lespecular.Image")));
			this.lespecular.Location = new System.Drawing.Point(79, 247);
			this.lespecular.Name = "lespecular";
			this.lespecular.Size = new System.Drawing.Size(170, 35);
			this.lespecular.TabIndex = 3;
			this.lespecular.Text = "Especular";
			this.lespecular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lespecular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.lespecular.UseVisualStyleBackColor = false;
			this.lespecular.Click += new System.EventHandler(this.lespecular_Click);
			// 
			// ldifusa
			// 
			this.ldifusa.BackColor = System.Drawing.Color.Black;
			this.ldifusa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ldifusa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.ldifusa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ldifusa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ldifusa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.ldifusa.Image = ((System.Drawing.Image)(resources.GetObject("ldifusa.Image")));
			this.ldifusa.Location = new System.Drawing.Point(79, 206);
			this.ldifusa.Name = "ldifusa";
			this.ldifusa.Size = new System.Drawing.Size(170, 35);
			this.ldifusa.TabIndex = 3;
			this.ldifusa.Text = "Difusa";
			this.ldifusa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ldifusa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ldifusa.UseVisualStyleBackColor = false;
			this.ldifusa.Click += new System.EventHandler(this.ldifusa_Click);
			// 
			// lambiente
			// 
			this.lambiente.BackColor = System.Drawing.Color.Black;
			this.lambiente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lambiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.lambiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lambiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lambiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.lambiente.Image = ((System.Drawing.Image)(resources.GetObject("lambiente.Image")));
			this.lambiente.Location = new System.Drawing.Point(79, 165);
			this.lambiente.Name = "lambiente";
			this.lambiente.Size = new System.Drawing.Size(170, 35);
			this.lambiente.TabIndex = 3;
			this.lambiente.Text = "Ambiente";
			this.lambiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lambiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.lambiente.UseVisualStyleBackColor = false;
			this.lambiente.Click += new System.EventHandler(this.lambiente_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label11.Location = new System.Drawing.Point(19, 11);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(98, 16);
			this.label11.TabIndex = 14;
			this.label11.Text = "Preenchimento";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label12.Location = new System.Drawing.Point(159, 11);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(90, 16);
			this.label12.TabIndex = 14;
			this.label12.Text = "Axonométrica";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
			this.label13.Location = new System.Drawing.Point(19, 63);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(70, 16);
			this.label13.TabIndex = 14;
			this.label13.Text = "Projeções";
			// 
			// TelaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1004, 571);
			this.Controls.Add(this.pnFuncoes);
			this.Controls.Add(this.pbLight);
			this.Controls.Add(this.gbFormato);
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
			((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
			this.pnFuncoes.ResumeLayout(false);
			this.pnFuncoes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbEspecular)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDifusa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAmbiente)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pbPrincipal;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button btAbrir;
		private System.Windows.Forms.Button btLimpar;
		private System.Windows.Forms.GroupBox gbFormato;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.PictureBox pbLight;
		private System.Windows.Forms.RadioButton rbSolido;
		private System.Windows.Forms.RadioButton rbAramado;
		private System.Windows.Forms.Button btInfo;
		private System.Windows.Forms.Button btConfig;
		private System.Windows.Forms.Panel pnFuncoes;
		private System.Windows.Forms.ComboBox cbPreenchimento;
		private System.Windows.Forms.CheckBox cbfaceo;
		private System.Windows.Forms.ComboBox cbAxonometrica;
		private System.Windows.Forms.PictureBox pbEspecular;
		private System.Windows.Forms.PictureBox pbDifusa;
		private System.Windows.Forms.PictureBox pbAmbiente;
		private System.Windows.Forms.Button lespecular;
		private System.Windows.Forms.Button ldifusa;
		private System.Windows.Forms.Button lambiente;
		private System.Windows.Forms.ComboBox cbProjecoes;
		private System.Windows.Forms.Label lbDist;
		private System.Windows.Forms.TextBox tbDistancia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
	}
}

