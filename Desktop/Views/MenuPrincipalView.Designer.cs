namespace Desktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPrincipal = new MenuStrip();
            SubMenuPrincipal = new FontAwesome.Sharp.IconMenuItem();
            SubMenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            subMenuCapacitaciones = new FontAwesome.Sharp.IconMenuItem();
            SubMenuTiposDeInscripciones = new FontAwesome.Sharp.IconMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            SubmenuInscripciones = new FontAwesome.Sharp.IconMenuItem();
            SubMenuSalir = new FontAwesome.Sharp.IconMenuItem();
            SubMenuSalirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            toolStrip1 = new ToolStrip();
            SubmenuAcreditaciones = new FontAwesome.Sharp.IconMenuItem();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.ImageScalingSize = new Size(24, 24);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { SubMenuPrincipal, SubMenuSalir });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(800, 33);
            menuPrincipal.TabIndex = 1;
            menuPrincipal.Text = "menuStrip1";
            // 
            // SubMenuPrincipal
            // 
            SubMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] { SubMenuUsuarios, subMenuCapacitaciones, SubMenuTiposDeInscripciones, toolStripSeparator1, SubmenuInscripciones, SubmenuAcreditaciones });
            SubMenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            SubMenuPrincipal.IconColor = Color.Black;
            SubMenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuPrincipal.Name = "SubMenuPrincipal";
            SubMenuPrincipal.Size = new Size(118, 29);
            SubMenuPrincipal.Text = "Principal";
            // 
            // SubMenuUsuarios
            // 
            SubMenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            SubMenuUsuarios.IconColor = Color.Black;
            SubMenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuUsuarios.Name = "SubMenuUsuarios";
            SubMenuUsuarios.Size = new Size(289, 34);
            SubMenuUsuarios.Text = "Usuarios";
            SubMenuUsuarios.Click += SubMenuUsuarios_Click;
            // 
            // subMenuCapacitaciones
            // 
            subMenuCapacitaciones.IconChar = FontAwesome.Sharp.IconChar.Book;
            subMenuCapacitaciones.IconColor = Color.Black;
            subMenuCapacitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuCapacitaciones.Name = "subMenuCapacitaciones";
            subMenuCapacitaciones.Size = new Size(289, 34);
            subMenuCapacitaciones.Text = "Capacitaciones";
            subMenuCapacitaciones.Click += subMenuCapacitaciones_Click;
            // 
            // SubMenuTiposDeInscripciones
            // 
            SubMenuTiposDeInscripciones.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            SubMenuTiposDeInscripciones.IconColor = Color.Black;
            SubMenuTiposDeInscripciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuTiposDeInscripciones.Name = "SubMenuTiposDeInscripciones";
            SubMenuTiposDeInscripciones.Size = new Size(289, 34);
            SubMenuTiposDeInscripciones.Text = "Tipos de Inscripciones";
            SubMenuTiposDeInscripciones.Click += SubMenuTiposDeInscripciones_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(286, 6);
            // 
            // SubmenuInscripciones
            // 
            SubmenuInscripciones.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            SubmenuInscripciones.IconColor = Color.Black;
            SubmenuInscripciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuInscripciones.Name = "SubmenuInscripciones";
            SubmenuInscripciones.Size = new Size(289, 34);
            SubmenuInscripciones.Text = "Inscripciones";
            SubmenuInscripciones.Click += SubmenuInscripciones_Click;
            // 
            // SubMenuSalir
            // 
            SubMenuSalir.DropDownItems.AddRange(new ToolStripItem[] { SubMenuSalirDelSistema });
            SubMenuSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            SubMenuSalir.IconColor = Color.Black;
            SubMenuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuSalir.Name = "SubMenuSalir";
            SubMenuSalir.Size = new Size(85, 29);
            SubMenuSalir.Text = "Salir";
            // 
            // SubMenuSalirDelSistema
            // 
            SubMenuSalirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            SubMenuSalirDelSistema.IconColor = Color.Black;
            SubMenuSalirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuSalirDelSistema.Name = "SubMenuSalirDelSistema";
            SubMenuSalirDelSistema.Size = new Size(241, 34);
            SubMenuSalirDelSistema.Text = "Salir del sistema";
            SubMenuSalirDelSistema.Click += SubMenuSalirDelSistema_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // SubmenuAcreditaciones
            // 
            SubmenuAcreditaciones.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            SubmenuAcreditaciones.IconColor = Color.Black;
            SubmenuAcreditaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubmenuAcreditaciones.Name = "SubmenuAcreditaciones";
            SubmenuAcreditaciones.Size = new Size(289, 34);
            SubmenuAcreditaciones.Text = "Acreditaciones";
            SubmenuAcreditaciones.Click += SubmenuAcreditaciones_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipal;
            Name = "MenuPrincipalView";
            Text = "Ágora : Software de Acreditación de Capacitaciones ISP20";
            WindowState = FormWindowState.Maximized;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconMenuItem SubMenuPrincipal;
        private FontAwesome.Sharp.IconMenuItem SubMenuSalir;
        private FontAwesome.Sharp.IconMenuItem SubMenuSalirDelSistema;
        private FontAwesome.Sharp.IconMenuItem SubMenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem subMenuCapacitaciones;
        private FontAwesome.Sharp.IconMenuItem SubMenuTiposDeInscripciones;
        private ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem SubmenuInscripciones;
        private FontAwesome.Sharp.IconMenuItem SubmenuAcreditaciones;
    }
}
