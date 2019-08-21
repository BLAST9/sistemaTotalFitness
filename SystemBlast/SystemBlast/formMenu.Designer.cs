namespace SystemBlast
{
    partial class formMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Barra = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHorarioCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRegistarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrincipal = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHorarioEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnRegistroEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnFacturas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnControlPrincipal = new System.Windows.Forms.Panel();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.btnControlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Barra.BackgroundImage")));
            this.logoAnimator.SetDecoration(this.Barra, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.Barra, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator2.SetDecoration(this.Barra, BunifuAnimatorNS.DecorationType.None);
            this.Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra.Location = new System.Drawing.Point(0, 0);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(1354, 60);
            this.Barra.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHorarioCliente);
            this.panel1.Controls.Add(this.btnRegistarCliente);
            this.panel1.Controls.Add(this.btnPrincipal);
            this.panel1.Controls.Add(this.btnHorarioEmpleado);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.btnRegistroEmpleado);
            this.panel1.Controls.Add(this.lblTiempo);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.btnFacturas);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.btnClientes);
            this.logoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 635);
            this.panel1.TabIndex = 3;
            // 
            // btnHorarioCliente
            // 
            this.btnHorarioCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHorarioCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHorarioCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHorarioCliente.BorderRadius = 0;
            this.btnHorarioCliente.ButtonText = "     Horario Cliente";
            this.btnHorarioCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator2.SetDecoration(this.btnHorarioCliente, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnHorarioCliente, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnHorarioCliente, BunifuAnimatorNS.DecorationType.None);
            this.btnHorarioCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnHorarioCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHorarioCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHorarioCliente.Iconimage")));
            this.btnHorarioCliente.Iconimage_right = null;
            this.btnHorarioCliente.Iconimage_right_Selected = null;
            this.btnHorarioCliente.Iconimage_Selected = null;
            this.btnHorarioCliente.IconMarginLeft = 0;
            this.btnHorarioCliente.IconMarginRight = 0;
            this.btnHorarioCliente.IconRightVisible = true;
            this.btnHorarioCliente.IconRightZoom = 0D;
            this.btnHorarioCliente.IconVisible = true;
            this.btnHorarioCliente.IconZoom = 60D;
            this.btnHorarioCliente.IsTab = true;
            this.btnHorarioCliente.Location = new System.Drawing.Point(48, 195);
            this.btnHorarioCliente.Name = "btnHorarioCliente";
            this.btnHorarioCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHorarioCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHorarioCliente.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHorarioCliente.selected = false;
            this.btnHorarioCliente.Size = new System.Drawing.Size(154, 33);
            this.btnHorarioCliente.TabIndex = 143;
            this.btnHorarioCliente.Text = "     Horario Cliente";
            this.btnHorarioCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarioCliente.Textcolor = System.Drawing.Color.White;
            this.btnHorarioCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarioCliente.Click += new System.EventHandler(this.btnHorarioCliente_Click);
            // 
            // btnRegistarCliente
            // 
            this.btnRegistarCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRegistarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistarCliente.BorderRadius = 0;
            this.btnRegistarCliente.ButtonText = "     Registro";
            this.btnRegistarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator2.SetDecoration(this.btnRegistarCliente, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnRegistarCliente, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnRegistarCliente, BunifuAnimatorNS.DecorationType.None);
            this.btnRegistarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegistarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegistarCliente.Iconimage")));
            this.btnRegistarCliente.Iconimage_right = null;
            this.btnRegistarCliente.Iconimage_right_Selected = null;
            this.btnRegistarCliente.Iconimage_Selected = null;
            this.btnRegistarCliente.IconMarginLeft = 0;
            this.btnRegistarCliente.IconMarginRight = 0;
            this.btnRegistarCliente.IconRightVisible = true;
            this.btnRegistarCliente.IconRightZoom = 0D;
            this.btnRegistarCliente.IconVisible = true;
            this.btnRegistarCliente.IconZoom = 60D;
            this.btnRegistarCliente.IsTab = true;
            this.btnRegistarCliente.Location = new System.Drawing.Point(48, 160);
            this.btnRegistarCliente.Name = "btnRegistarCliente";
            this.btnRegistarCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistarCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistarCliente.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRegistarCliente.selected = false;
            this.btnRegistarCliente.Size = new System.Drawing.Size(154, 33);
            this.btnRegistarCliente.TabIndex = 16;
            this.btnRegistarCliente.Text = "     Registro";
            this.btnRegistarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistarCliente.Textcolor = System.Drawing.Color.White;
            this.btnRegistarCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarCliente.Click += new System.EventHandler(this.btnRegistarCliente_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.logoAnimator.SetDecoration(this.btnPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator2.SetDecoration(this.btnPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.btnPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnPrincipal.Image")));
            this.btnPrincipal.ImageActive = null;
            this.btnPrincipal.Location = new System.Drawing.Point(156, 53);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(35, 35);
            this.btnPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrincipal.TabIndex = 139;
            this.btnPrincipal.TabStop = false;
            this.btnPrincipal.Zoom = 10;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnHorarioEmpleado
            // 
            this.btnHorarioEmpleado.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHorarioEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHorarioEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHorarioEmpleado.BorderRadius = 0;
            this.btnHorarioEmpleado.ButtonText = "     Horario                     Empleado";
            this.btnHorarioEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator2.SetDecoration(this.btnHorarioEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnHorarioEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnHorarioEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.btnHorarioEmpleado.DisabledColor = System.Drawing.Color.Gray;
            this.btnHorarioEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHorarioEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHorarioEmpleado.Iconimage")));
            this.btnHorarioEmpleado.Iconimage_right = null;
            this.btnHorarioEmpleado.Iconimage_right_Selected = null;
            this.btnHorarioEmpleado.Iconimage_Selected = null;
            this.btnHorarioEmpleado.IconMarginLeft = 0;
            this.btnHorarioEmpleado.IconMarginRight = 0;
            this.btnHorarioEmpleado.IconRightVisible = true;
            this.btnHorarioEmpleado.IconRightZoom = 0D;
            this.btnHorarioEmpleado.IconVisible = true;
            this.btnHorarioEmpleado.IconZoom = 60D;
            this.btnHorarioEmpleado.IsTab = true;
            this.btnHorarioEmpleado.Location = new System.Drawing.Point(52, 300);
            this.btnHorarioEmpleado.Name = "btnHorarioEmpleado";
            this.btnHorarioEmpleado.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHorarioEmpleado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnHorarioEmpleado.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnHorarioEmpleado.selected = false;
            this.btnHorarioEmpleado.Size = new System.Drawing.Size(148, 33);
            this.btnHorarioEmpleado.TabIndex = 22;
            this.btnHorarioEmpleado.Text = "     Horario                     Empleado";
            this.btnHorarioEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarioEmpleado.Textcolor = System.Drawing.Color.White;
            this.btnHorarioEmpleado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarioEmpleado.Click += new System.EventHandler(this.btnHorarioEmpleado_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.logoAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator2.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(156, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Logo
            // 
            this.panelAnimator2.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(15, 42);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(119, 37);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // btnRegistroEmpleado
            // 
            this.btnRegistroEmpleado.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRegistroEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistroEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistroEmpleado.BorderRadius = 0;
            this.btnRegistroEmpleado.ButtonText = "     Registro";
            this.btnRegistroEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator2.SetDecoration(this.btnRegistroEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnRegistroEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnRegistroEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.btnRegistroEmpleado.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegistroEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistroEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegistroEmpleado.Iconimage")));
            this.btnRegistroEmpleado.Iconimage_right = null;
            this.btnRegistroEmpleado.Iconimage_right_Selected = null;
            this.btnRegistroEmpleado.Iconimage_Selected = null;
            this.btnRegistroEmpleado.IconMarginLeft = 0;
            this.btnRegistroEmpleado.IconMarginRight = 0;
            this.btnRegistroEmpleado.IconRightVisible = true;
            this.btnRegistroEmpleado.IconRightZoom = 0D;
            this.btnRegistroEmpleado.IconVisible = true;
            this.btnRegistroEmpleado.IconZoom = 60D;
            this.btnRegistroEmpleado.IsTab = true;
            this.btnRegistroEmpleado.Location = new System.Drawing.Point(52, 265);
            this.btnRegistroEmpleado.Name = "btnRegistroEmpleado";
            this.btnRegistroEmpleado.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistroEmpleado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRegistroEmpleado.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRegistroEmpleado.selected = false;
            this.btnRegistroEmpleado.Size = new System.Drawing.Size(150, 33);
            this.btnRegistroEmpleado.TabIndex = 21;
            this.btnRegistroEmpleado.Text = "     Registro";
            this.btnRegistroEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroEmpleado.Textcolor = System.Drawing.Color.White;
            this.btnRegistroEmpleado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroEmpleado.Click += new System.EventHandler(this.btnRegistroEmpleado_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.panelAnimator2.SetDecoration(this.lblTiempo, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.lblTiempo, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.lblTiempo, BunifuAnimatorNS.DecorationType.None);
            this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(114, 617);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(0, 19);
            this.lblTiempo.TabIndex = 20;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.panelAnimator2.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.lblHora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(58, 614);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(71, 19);
            this.lblHora.TabIndex = 19;
            this.lblHora.Text = "12: 00: 00";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.panelAnimator2.SetDecoration(this.lblFecha, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.lblFecha, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.lblFecha, BunifuAnimatorNS.DecorationType.None);
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(14, 591);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(170, 19);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "viernes, 9 febrero de 2018";
            // 
            // btnFacturas
            // 
            this.btnFacturas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFacturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturas.BorderRadius = 0;
            this.btnFacturas.ButtonText = "     Factura";
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator2.SetDecoration(this.btnFacturas, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnFacturas, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnFacturas, BunifuAnimatorNS.DecorationType.None);
            this.btnFacturas.DisabledColor = System.Drawing.Color.Gray;
            this.btnFacturas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFacturas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFacturas.Iconimage")));
            this.btnFacturas.Iconimage_right = null;
            this.btnFacturas.Iconimage_right_Selected = null;
            this.btnFacturas.Iconimage_Selected = null;
            this.btnFacturas.IconMarginLeft = 0;
            this.btnFacturas.IconMarginRight = 0;
            this.btnFacturas.IconRightVisible = true;
            this.btnFacturas.IconRightZoom = 0D;
            this.btnFacturas.IconVisible = true;
            this.btnFacturas.IconZoom = 60D;
            this.btnFacturas.IsTab = true;
            this.btnFacturas.Location = new System.Drawing.Point(1, 370);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFacturas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFacturas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnFacturas.selected = false;
            this.btnFacturas.Size = new System.Drawing.Size(200, 33);
            this.btnFacturas.TabIndex = 14;
            this.btnFacturas.Text = "     Factura";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Textcolor = System.Drawing.Color.White;
            this.btnFacturas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.BorderRadius = 0;
            this.btnProductos.ButtonText = "     Productos";
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator2.SetDecoration(this.btnProductos, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnProductos, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnProductos, BunifuAnimatorNS.DecorationType.None);
            this.btnProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductos.Iconimage")));
            this.btnProductos.Iconimage_right = null;
            this.btnProductos.Iconimage_right_Selected = null;
            this.btnProductos.Iconimage_Selected = null;
            this.btnProductos.IconMarginLeft = 0;
            this.btnProductos.IconMarginRight = 0;
            this.btnProductos.IconRightVisible = true;
            this.btnProductos.IconRightZoom = 0D;
            this.btnProductos.IconVisible = true;
            this.btnProductos.IconZoom = 60D;
            this.btnProductos.IsTab = true;
            this.btnProductos.Location = new System.Drawing.Point(1, 335);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnProductos.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnProductos.selected = false;
            this.btnProductos.Size = new System.Drawing.Size(200, 33);
            this.btnProductos.TabIndex = 12;
            this.btnProductos.Text = "     Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Textcolor = System.Drawing.Color.White;
            this.btnProductos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleados.BorderRadius = 0;
            this.btnEmpleados.ButtonText = "     Empleados";
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator2.SetDecoration(this.btnEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.btnEmpleados.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Iconimage")));
            this.btnEmpleados.Iconimage_right = null;
            this.btnEmpleados.Iconimage_right_Selected = null;
            this.btnEmpleados.Iconimage_Selected = null;
            this.btnEmpleados.IconMarginLeft = 0;
            this.btnEmpleados.IconMarginRight = 0;
            this.btnEmpleados.IconRightVisible = true;
            this.btnEmpleados.IconRightZoom = 0D;
            this.btnEmpleados.IconVisible = true;
            this.btnEmpleados.IconZoom = 60D;
            this.btnEmpleados.IsTab = true;
            this.btnEmpleados.Location = new System.Drawing.Point(2, 230);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEmpleados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEmpleados.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEmpleados.selected = false;
            this.btnEmpleados.Size = new System.Drawing.Size(200, 33);
            this.btnEmpleados.TabIndex = 11;
            this.btnEmpleados.Text = "     Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Textcolor = System.Drawing.Color.White;
            this.btnEmpleados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            this.btnEmpleados.DoubleClick += new System.EventHandler(this.btnEmpleados_DoubleClick);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "     Clientes";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator2.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 60D;
            this.btnClientes.IsTab = true;
            this.btnClientes.Location = new System.Drawing.Point(1, 125);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClientes.selected = true;
            this.btnClientes.Size = new System.Drawing.Size(201, 33);
            this.btnClientes.TabIndex = 10;
            this.btnClientes.Text = "     Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.White;
            this.btnClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.DoubleClick += new System.EventHandler(this.btnClientes_DoubleClick);
            // 
            // btnControlPrincipal
            // 
            this.btnControlPrincipal.BackColor = System.Drawing.Color.Black;
            this.btnControlPrincipal.Controls.Add(this.Imagen);
            this.logoAnimator.SetDecoration(this.btnControlPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnControlPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator2.SetDecoration(this.btnControlPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.btnControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnControlPrincipal.Location = new System.Drawing.Point(202, 60);
            this.btnControlPrincipal.Name = "btnControlPrincipal";
            this.btnControlPrincipal.Size = new System.Drawing.Size(1152, 635);
            this.btnControlPrincipal.TabIndex = 4;
            // 
            // Imagen
            // 
            this.panelAnimator2.SetDecoration(this.Imagen, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.Imagen, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.Imagen, BunifuAnimatorNS.DecorationType.None);
            this.Imagen.Image = ((System.Drawing.Image)(resources.GetObject("Imagen.Image")));
            this.Imagen.Location = new System.Drawing.Point(231, 0);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(709, 636);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 1;
            this.Imagen.TabStop = false;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation1;
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.panelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation2;
            // 
            // panelAnimator2
            // 
            this.panelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.panelAnimator2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.panelAnimator2.DefaultAnimation = animation3;
            // 
            // FechaHora
            // 
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 695);
            this.Controls.Add(this.btnControlPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Barra);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "formMenu";
            this.Text = "Sistema TotalFitness";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.btnControlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel Barra;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnPrincipal;
        private Bunifu.Framework.UI.BunifuFlatButton btnHorarioEmpleado;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistroEmpleado;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistarCliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnFacturas;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductos;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private System.Windows.Forms.Panel btnControlPrincipal;
        private BunifuAnimatorNS.BunifuTransition panelAnimator2;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private System.Windows.Forms.Timer FechaHora;
        private Bunifu.Framework.UI.BunifuFlatButton btnHorarioCliente;
        private System.Windows.Forms.PictureBox Imagen;
    }
}