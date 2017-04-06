namespace DemoCSTimbraCFDI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnRegistraEmisorWebService = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnTimbraCfdiArchivo = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnTimbraCfdiEntidad = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRfcEmisorConsulta = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtFolioFiscalConsulta = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.btnObtieneCFDI = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.txtRfcEmisorCancelacion = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtFolioFiscalCancelacion = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.btnCancelaCFDI = new System.Windows.Forms.Button();
            this.Label18 = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.ofdComprobante = new System.Windows.Forms.OpenFileDialog();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.Label20);
            this.Panel1.Controls.Add(this.Label19);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(708, 76);
            this.Panel1.TabIndex = 4;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label20.Location = new System.Drawing.Point(173, 28);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(510, 16);
            this.Label20.TabIndex = 5;
            this.Label20.Text = "En este demo se muestra como hacer uso del componente DGMC.TimbraCFDI";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label19.Location = new System.Drawing.Point(173, 45);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(499, 16);
            this.Label19.TabIndex = 4;
            this.Label19.Text = "para facilitar la integración entre tu sistema y nuestro servicio de timbrado";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::DemoCSTimbraCFDI.Properties.Resources.timbradoLogo_50;
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(155, 50);
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 76);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(708, 171);
            this.TabControl1.TabIndex = 5;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(700, 145);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Registro de Emisores";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.Label7);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.btnRegistraEmisorWebService);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox3.Location = new System.Drawing.Point(3, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(694, 135);
            this.GroupBox3.TabIndex = 5;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Ejemplo de registro para Emisores";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label10.Location = new System.Drawing.Point(145, 108);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(396, 17);
            this.Label10.TabIndex = 8;
            this.Label10.Text = "ó por medio del portal de integradores de manera manual.";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label9.Location = new System.Drawing.Point(145, 91);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(471, 17);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "Nota: El registro de emisores se puede hacer por medio del web service";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label8.Location = new System.Drawing.Point(145, 74);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(238, 17);
            this.Label8.TabIndex = 6;
            this.Label8.Text = "y la contraseña de la llave privada.";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label7.Location = new System.Drawing.Point(145, 57);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(511, 17);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "del conector, para esto necesitamos el RFC a registrar, los archivos de su sello";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label5.Location = new System.Drawing.Point(145, 40);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(481, 17);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "En este ejemplo se muestra como registrar un nuevo Emisor con la ayuda";
            // 
            // btnRegistraEmisorWebService
            // 
            this.btnRegistraEmisorWebService.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistraEmisorWebService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistraEmisorWebService.Location = new System.Drawing.Point(6, 20);
            this.btnRegistraEmisorWebService.Name = "btnRegistraEmisorWebService";
            this.btnRegistraEmisorWebService.Size = new System.Drawing.Size(128, 109);
            this.btnRegistraEmisorWebService.TabIndex = 2;
            this.btnRegistraEmisorWebService.Text = "RegistraEmisor";
            this.btnRegistraEmisorWebService.UseVisualStyleBackColor = true;
            this.btnRegistraEmisorWebService.Click += new System.EventHandler(this.btnRegistraEmisorWebService_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label6.Location = new System.Drawing.Point(145, 23);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(508, 17);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Para que un Emisor pueda comenzar a timbrar, antes debe de ser registrado.";
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage2.Controls.Add(this.GroupBox2);
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(700, 145);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Timbrado ";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.btnTimbraCfdiArchivo);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox2.Location = new System.Drawing.Point(3, 70);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(694, 67);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Ejemplo de timbrado No. 2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label3.Location = new System.Drawing.Point(145, 40);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(315, 17);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Se manda a timbrar y se guardan los resultados";
            // 
            // btnTimbraCfdiArchivo
            // 
            this.btnTimbraCfdiArchivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimbraCfdiArchivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimbraCfdiArchivo.Location = new System.Drawing.Point(6, 20);
            this.btnTimbraCfdiArchivo.Name = "btnTimbraCfdiArchivo";
            this.btnTimbraCfdiArchivo.Size = new System.Drawing.Size(128, 39);
            this.btnTimbraCfdiArchivo.TabIndex = 2;
            this.btnTimbraCfdiArchivo.Text = "TimbraCFDI";
            this.btnTimbraCfdiArchivo.UseVisualStyleBackColor = true;
            this.btnTimbraCfdiArchivo.Click += new System.EventHandler(this.btnTimbraCfdiArchivo_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label4.Location = new System.Drawing.Point(145, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(429, 17);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "En este ejemplo se indica la ruta de nuestro xml (CFDI) sin timbrar";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.btnTimbraCfdiEntidad);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(694, 67);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Ejemplo de timbrado No. 1";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label2.Location = new System.Drawing.Point(145, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(441, 17);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Una vez generado, se manda a timbrar y se guardan los resultados";
            // 
            // btnTimbraCfdiEntidad
            // 
            this.btnTimbraCfdiEntidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimbraCfdiEntidad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimbraCfdiEntidad.Location = new System.Drawing.Point(6, 20);
            this.btnTimbraCfdiEntidad.Name = "btnTimbraCfdiEntidad";
            this.btnTimbraCfdiEntidad.Size = new System.Drawing.Size(128, 39);
            this.btnTimbraCfdiEntidad.TabIndex = 2;
            this.btnTimbraCfdiEntidad.Text = "TimbraCFDI";
            this.btnTimbraCfdiEntidad.UseVisualStyleBackColor = true;
            this.btnTimbraCfdiEntidad.Click += new System.EventHandler(this.btnTimbraCfdiEntidad_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label1.Location = new System.Drawing.Point(145, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(512, 17);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "En este ejemplo se genera el xml (CFDI) con la ayuda de nuestro componente";
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage3.Controls.Add(this.GroupBox4);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(700, 145);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Consulta";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.txtRfcEmisorConsulta);
            this.GroupBox4.Controls.Add(this.Label11);
            this.GroupBox4.Controls.Add(this.txtFolioFiscalConsulta);
            this.GroupBox4.Controls.Add(this.Label13);
            this.GroupBox4.Controls.Add(this.Label15);
            this.GroupBox4.Controls.Add(this.btnObtieneCFDI);
            this.GroupBox4.Controls.Add(this.Label16);
            this.GroupBox4.Location = new System.Drawing.Point(3, 3);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(694, 135);
            this.GroupBox4.TabIndex = 6;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Ejemplo de consulta";
            // 
            // txtRfcEmisorConsulta
            // 
            this.txtRfcEmisorConsulta.Location = new System.Drawing.Point(268, 77);
            this.txtRfcEmisorConsulta.Name = "txtRfcEmisorConsulta";
            this.txtRfcEmisorConsulta.Size = new System.Drawing.Size(406, 20);
            this.txtRfcEmisorConsulta.TabIndex = 9;
            this.txtRfcEmisorConsulta.Text = "AAA010101AAA";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label11.Location = new System.Drawing.Point(145, 78);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(78, 17);
            this.Label11.TabIndex = 8;
            this.Label11.Text = "RFC Emisor";
            // 
            // txtFolioFiscalConsulta
            // 
            this.txtFolioFiscalConsulta.Location = new System.Drawing.Point(268, 104);
            this.txtFolioFiscalConsulta.Name = "txtFolioFiscalConsulta";
            this.txtFolioFiscalConsulta.Size = new System.Drawing.Size(406, 20);
            this.txtFolioFiscalConsulta.TabIndex = 7;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label13.Location = new System.Drawing.Point(145, 105);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(117, 17);
            this.Label13.TabIndex = 6;
            this.Label13.Text = "Folio Fiscal - UUID";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label15.Location = new System.Drawing.Point(145, 40);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(458, 17);
            this.Label15.TabIndex = 4;
            this.Label15.Text = "el RFC del Emisor y el folio fiscal que le fue asignado al comprobante.";
            // 
            // btnObtieneCFDI
            // 
            this.btnObtieneCFDI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtieneCFDI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnObtieneCFDI.Location = new System.Drawing.Point(6, 20);
            this.btnObtieneCFDI.Name = "btnObtieneCFDI";
            this.btnObtieneCFDI.Size = new System.Drawing.Size(128, 109);
            this.btnObtieneCFDI.TabIndex = 2;
            this.btnObtieneCFDI.Text = "ObtieneCFDI";
            this.btnObtieneCFDI.UseVisualStyleBackColor = true;
            this.btnObtieneCFDI.Click += new System.EventHandler(this.btnObtieneCFDI_Click);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label16.Location = new System.Drawing.Point(145, 23);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(517, 17);
            this.Label16.TabIndex = 3;
            this.Label16.Text = "En este ejemplo se obtiene un xml (CFDI) previamente timbrado especificando";
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage4.Controls.Add(this.GroupBox5);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(700, 145);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Cancelación";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.txtRfcEmisorCancelacion);
            this.GroupBox5.Controls.Add(this.Label12);
            this.GroupBox5.Controls.Add(this.txtFolioFiscalCancelacion);
            this.GroupBox5.Controls.Add(this.Label14);
            this.GroupBox5.Controls.Add(this.Label17);
            this.GroupBox5.Controls.Add(this.btnCancelaCFDI);
            this.GroupBox5.Controls.Add(this.Label18);
            this.GroupBox5.Location = new System.Drawing.Point(3, 3);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(694, 135);
            this.GroupBox5.TabIndex = 7;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Ejemplo de cancelación";
            // 
            // txtRfcEmisorCancelacion
            // 
            this.txtRfcEmisorCancelacion.Location = new System.Drawing.Point(268, 77);
            this.txtRfcEmisorCancelacion.Name = "txtRfcEmisorCancelacion";
            this.txtRfcEmisorCancelacion.Size = new System.Drawing.Size(406, 20);
            this.txtRfcEmisorCancelacion.TabIndex = 9;
            this.txtRfcEmisorCancelacion.Text = "AAA010101AAA";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label12.Location = new System.Drawing.Point(145, 78);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(78, 17);
            this.Label12.TabIndex = 8;
            this.Label12.Text = "RFC Emisor";
            // 
            // txtFolioFiscalCancelacion
            // 
            this.txtFolioFiscalCancelacion.Location = new System.Drawing.Point(268, 104);
            this.txtFolioFiscalCancelacion.Name = "txtFolioFiscalCancelacion";
            this.txtFolioFiscalCancelacion.Size = new System.Drawing.Size(406, 20);
            this.txtFolioFiscalCancelacion.TabIndex = 7;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label14.Location = new System.Drawing.Point(145, 105);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(117, 17);
            this.Label14.TabIndex = 6;
            this.Label14.Text = "Folio Fiscal - UUID";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label17.Location = new System.Drawing.Point(145, 40);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(458, 17);
            this.Label17.TabIndex = 4;
            this.Label17.Text = "el RFC del Emisor y el folio fiscal que le fue asignado al comprobante.";
            // 
            // btnCancelaCFDI
            // 
            this.btnCancelaCFDI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaCFDI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelaCFDI.Location = new System.Drawing.Point(6, 20);
            this.btnCancelaCFDI.Name = "btnCancelaCFDI";
            this.btnCancelaCFDI.Size = new System.Drawing.Size(128, 109);
            this.btnCancelaCFDI.TabIndex = 2;
            this.btnCancelaCFDI.Text = "CancelaCFDI";
            this.btnCancelaCFDI.UseVisualStyleBackColor = true;
            this.btnCancelaCFDI.Click += new System.EventHandler(this.btnCancelaCFDI_Click);
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label18.Location = new System.Drawing.Point(145, 23);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(520, 17);
            this.Label18.TabIndex = 3;
            this.Label18.Text = "En este ejemplo se cancela un xml (CFDI) previamente timbrado especificando";
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TabPage5.Controls.Add(this.TextBox1);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(700, 145);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Ventajas del Servicio TimbraCFDI";
            // 
            // TextBox1
            // 
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Location = new System.Drawing.Point(0, 0);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(700, 145);
            this.TextBox1.TabIndex = 11;
            this.TextBox1.Text = resources.GetString("TextBox1.Text");
            // 
            // ofdComprobante
            // 
            this.ofdComprobante.FileName = "openFileDialog1";
            this.ofdComprobante.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdComprobante_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 247);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel1);
            this.MaximumSize = new System.Drawing.Size(724, 286);
            this.MinimumSize = new System.Drawing.Size(724, 286);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo - TimbraCFDI";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnRegistraEmisorWebService;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnTimbraCfdiArchivo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnTimbraCfdiEntidad;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox txtRfcEmisorConsulta;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtFolioFiscalConsulta;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button btnObtieneCFDI;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.TextBox txtRfcEmisorCancelacion;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtFolioFiscalCancelacion;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Button btnCancelaCFDI;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.OpenFileDialog ofdComprobante;
    }
}

