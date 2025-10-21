namespace Desktop.Views
{
    partial class CapacitacionesView
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
            components = new System.ComponentModel.Container();
            TabControl = new TabControl();
            TabPageLista = new TabPage();
            BtnRestaurar = new FontAwesome.Sharp.IconButton();
            checkVerEliminados = new CheckBox();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            label2 = new Label();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            DataGrid = new DataGridView();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            TabPageAgregarEditar = new TabPage();
            BtnQuitar = new FontAwesome.Sharp.IconButton();
            BtnAniadir = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            numericCosto = new NumericUpDown();
            ComboTiposInscripciones = new ComboBox();
            label8 = new Label();
            GridTiposDeInscripciones = new DataGridView();
            checkInscripcionAbierta = new CheckBox();
            label7 = new Label();
            DateTimeFechaHora = new DateTimePicker();
            TxtPonente = new TextBox();
            label6 = new Label();
            label5 = new Label();
            NumericCupo = new NumericUpDown();
            TxtDetalle = new TextBox();
            label4 = new Label();
            TxtNombre = new TextBox();
            label3 = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            LabelStatusMessage = new ToolStripStatusLabel();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridTiposDeInscripciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericCupo).BeginInit();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(21, 83);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1395, 605);
            TabControl.TabIndex = 0;
            // 
            // TabPageLista
            // 
            TabPageLista.Controls.Add(BtnRestaurar);
            TabPageLista.Controls.Add(checkVerEliminados);
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(TxtBuscar);
            TabPageLista.Controls.Add(label2);
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(DataGrid);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Location = new Point(4, 34);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(3);
            TabPageLista.Size = new Size(1387, 567);
            TabPageLista.TabIndex = 1;
            TabPageLista.Text = "Lista";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            BtnRestaurar.IconColor = Color.Black;
            BtnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRestaurar.Location = new Point(1238, 259);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(136, 53);
            BtnRestaurar.TabIndex = 6;
            BtnRestaurar.Text = "&Restaurar";
            BtnRestaurar.TextAlign = ContentAlignment.MiddleRight;
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Visible = false;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // checkVerEliminados
            // 
            checkVerEliminados.AutoSize = true;
            checkVerEliminados.Location = new Point(883, 27);
            checkVerEliminados.Name = "checkVerEliminados";
            checkVerEliminados.Size = new Size(154, 29);
            checkVerEliminados.TabIndex = 1;
            checkVerEliminados.Text = "Ver eliminados";
            checkVerEliminados.UseVisualStyleBackColor = true;
            checkVerEliminados.CheckedChanged += checkVerEliminados_CheckedChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(1238, 8);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(136, 54);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(85, 22);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(779, 31);
            TxtBuscar.TabIndex = 0;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 13;
            label2.Text = "Buscar:";
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(1238, 382);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(136, 51);
            BtnSalir.TabIndex = 7;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(6, 62);
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowHeadersWidth = 62;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(1219, 383);
            DataGrid.TabIndex = 7;
            DataGrid.SelectionChanged += GridPeliculas_SelectionChanged_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(1238, 200);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(136, 53);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "&Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(1238, 84);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(136, 54);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "&Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(1238, 144);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(136, 50);
            BtnModificar.TabIndex = 4;
            BtnModificar.Text = "&Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(BtnQuitar);
            TabPageAgregarEditar.Controls.Add(BtnAniadir);
            TabPageAgregarEditar.Controls.Add(label9);
            TabPageAgregarEditar.Controls.Add(numericCosto);
            TabPageAgregarEditar.Controls.Add(ComboTiposInscripciones);
            TabPageAgregarEditar.Controls.Add(label8);
            TabPageAgregarEditar.Controls.Add(GridTiposDeInscripciones);
            TabPageAgregarEditar.Controls.Add(checkInscripcionAbierta);
            TabPageAgregarEditar.Controls.Add(label7);
            TabPageAgregarEditar.Controls.Add(DateTimeFechaHora);
            TabPageAgregarEditar.Controls.Add(TxtPonente);
            TabPageAgregarEditar.Controls.Add(label6);
            TabPageAgregarEditar.Controls.Add(label5);
            TabPageAgregarEditar.Controls.Add(NumericCupo);
            TabPageAgregarEditar.Controls.Add(TxtDetalle);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(TxtNombre);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Controls.Add(BtnCancelar);
            TabPageAgregarEditar.Controls.Add(BtnGuardar);
            TabPageAgregarEditar.Location = new Point(4, 34);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(3);
            TabPageAgregarEditar.Size = new Size(1387, 567);
            TabPageAgregarEditar.TabIndex = 0;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // BtnQuitar
            // 
            BtnQuitar.Anchor = AnchorStyles.None;
            BtnQuitar.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            BtnQuitar.IconColor = Color.Black;
            BtnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnQuitar.Location = new Point(1199, 346);
            BtnQuitar.Name = "BtnQuitar";
            BtnQuitar.Size = new Size(136, 53);
            BtnQuitar.TabIndex = 34;
            BtnQuitar.Text = "&Quitar";
            BtnQuitar.TextAlign = ContentAlignment.MiddleRight;
            BtnQuitar.UseVisualStyleBackColor = true;
            BtnQuitar.Click += BtnQuitar_Click;
            // 
            // BtnAniadir
            // 
            BtnAniadir.Anchor = AnchorStyles.None;
            BtnAniadir.IconChar = FontAwesome.Sharp.IconChar.Add;
            BtnAniadir.IconColor = Color.Black;
            BtnAniadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAniadir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAniadir.Location = new Point(1199, 235);
            BtnAniadir.Name = "BtnAniadir";
            BtnAniadir.Size = new Size(136, 54);
            BtnAniadir.TabIndex = 33;
            BtnAniadir.Text = "&Añadir";
            BtnAniadir.TextAlign = ContentAlignment.MiddleRight;
            BtnAniadir.UseVisualStyleBackColor = true;
            BtnAniadir.Click += BtnAniadir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(910, 251);
            label9.Name = "label9";
            label9.Size = new Size(80, 25);
            label9.TabIndex = 32;
            label9.Text = "Importe:";
            // 
            // numericCosto
            // 
            numericCosto.DecimalPlaces = 2;
            numericCosto.Location = new Point(996, 248);
            numericCosto.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericCosto.Name = "numericCosto";
            numericCosto.Size = new Size(163, 31);
            numericCosto.TabIndex = 31;
            numericCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // ComboTiposInscripciones
            // 
            ComboTiposInscripciones.FormattingEnabled = true;
            ComboTiposInscripciones.Location = new Point(590, 248);
            ComboTiposInscripciones.Name = "ComboTiposInscripciones";
            ComboTiposInscripciones.Size = new Size(305, 33);
            ComboTiposInscripciones.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(586, 202);
            label8.Name = "label8";
            label8.Size = new Size(335, 25);
            label8.TabIndex = 29;
            label8.Text = "Tipos de inscripciones de la capacitación:";
            // 
            // GridTiposDeInscripciones
            // 
            GridTiposDeInscripciones.AllowUserToAddRows = false;
            GridTiposDeInscripciones.AllowUserToDeleteRows = false;
            GridTiposDeInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridTiposDeInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTiposDeInscripciones.Location = new Point(586, 294);
            GridTiposDeInscripciones.Name = "GridTiposDeInscripciones";
            GridTiposDeInscripciones.ReadOnly = true;
            GridTiposDeInscripciones.RowHeadersWidth = 62;
            GridTiposDeInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridTiposDeInscripciones.Size = new Size(573, 173);
            GridTiposDeInscripciones.TabIndex = 28;
            // 
            // checkInscripcionAbierta
            // 
            checkInscripcionAbierta.AutoSize = true;
            checkInscripcionAbierta.Location = new Point(217, 314);
            checkInscripcionAbierta.Name = "checkInscripcionAbierta";
            checkInscripcionAbierta.Size = new Size(182, 29);
            checkInscripcionAbierta.TabIndex = 6;
            checkInscripcionAbierta.Text = "Inscripción abierta";
            checkInscripcionAbierta.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 202);
            label7.Name = "label7";
            label7.Size = new Size(116, 25);
            label7.TabIndex = 27;
            label7.Text = "Fecha y hora:";
            // 
            // DateTimeFechaHora
            // 
            DateTimeFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
            DateTimeFechaHora.Format = DateTimePickerFormat.Custom;
            DateTimeFechaHora.Location = new Point(217, 202);
            DateTimeFechaHora.Name = "DateTimeFechaHora";
            DateTimeFechaHora.Size = new Size(300, 31);
            DateTimeFechaHora.TabIndex = 4;
            // 
            // TxtPonente
            // 
            TxtPonente.Location = new Point(217, 146);
            TxtPonente.Name = "TxtPonente";
            TxtPonente.Size = new Size(1130, 31);
            TxtPonente.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 148);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 24;
            label6.Text = "Orador/a:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 256);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 19;
            label5.Text = "Cupo:";
            // 
            // NumericCupo
            // 
            NumericCupo.Location = new Point(217, 258);
            NumericCupo.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumericCupo.Name = "NumericCupo";
            NumericCupo.Size = new Size(112, 31);
            NumericCupo.TabIndex = 5;
            NumericCupo.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtDetalle
            // 
            TxtDetalle.Location = new Point(217, 90);
            TxtDetalle.Name = "TxtDetalle";
            TxtDetalle.Size = new Size(1130, 31);
            TxtDetalle.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 94);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 16;
            label4.Text = "Detalle:";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(217, 34);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(1130, 31);
            TxtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 40);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(718, 493);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(136, 54);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Bottom;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(518, 493);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(136, 54);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1433, 79);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(347, 62);
            label1.TabIndex = 1;
            label1.Text = "Capacitaciones";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelStatusMessage });
            statusStrip1.Location = new Point(0, 720);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1428, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 15);
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 5000;
            TimerStatusBar.Tick += TimerStatusBar_Tick;
            // 
            // CapacitacionesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 742);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(TabControl);
            Name = "CapacitacionesView";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            TabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridTiposDeInscripciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericCupo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl TabControl;
        private TabPage TabPageLista;
        private TabPage TabPageAgregarEditar;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private DataGridView DataGrid;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private Label label2;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private TextBox TxtBuscar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private TextBox TxtDetalle;
        private Label label4;
        private TextBox TxtNombre;
        private Label label3;
        private Label label5;
        private NumericUpDown NumericCupo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatusMessage;
        private System.Windows.Forms.Timer TimerStatusBar;
        private FontAwesome.Sharp.IconButton BtnRestaurar;
        private CheckBox checkVerEliminados;
        private TextBox TxtPonente;
        private Label label6;
        private Label label7;
        private DateTimePicker DateTimeFechaHora;
        private CheckBox checkInscripcionAbierta;
        private Label label9;
        private NumericUpDown numericCosto;
        private ComboBox ComboTiposInscripciones;
        private Label label8;
        private DataGridView GridTiposDeInscripciones;
        private FontAwesome.Sharp.IconButton BtnQuitar;
        private FontAwesome.Sharp.IconButton BtnAniadir;
    }
}