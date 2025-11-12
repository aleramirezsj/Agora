namespace Desktop.Views
{
    partial class InscripcionesView
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
            label1 = new Label();
            panel1 = new Panel();
            ComboCapacitaciones = new ComboBox();
            label2 = new Label();
            GridInscripciones = new DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            ComboTipoInscripcion = new ComboBox();
            BtnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscarInscripto = new TextBox();
            GridUsuarios = new DataGridView();
            label3 = new Label();
            ContextMenuInscripcion = new ContextMenuStrip(components);
            SubMenuEliminarInscripcion = new ToolStripMenuItem();
            BtnImprimirInscripciones = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).BeginInit();
            ContextMenuInscripcion.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 62);
            label1.TabIndex = 1;
            label1.Text = "Inscripciones";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1621, 79);
            panel1.TabIndex = 8;
            // 
            // ComboCapacitaciones
            // 
            ComboCapacitaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboCapacitaciones.Font = new Font("Segoe UI", 12F);
            ComboCapacitaciones.FormattingEnabled = true;
            ComboCapacitaciones.Location = new Point(200, 104);
            ComboCapacitaciones.Name = "ComboCapacitaciones";
            ComboCapacitaciones.Size = new Size(571, 40);
            ComboCapacitaciones.TabIndex = 9;
            ComboCapacitaciones.SelectedIndexChanged += ComboCapacitaciones_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(25, 106);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 10;
            label2.Text = "Capacitación:";
            // 
            // GridInscripciones
            // 
            GridInscripciones.AllowUserToAddRows = false;
            GridInscripciones.AllowUserToDeleteRows = false;
            GridInscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridInscripciones.Location = new Point(26, 181);
            GridInscripciones.Name = "GridInscripciones";
            GridInscripciones.ReadOnly = true;
            GridInscripciones.RowHeadersVisible = false;
            GridInscripciones.RowHeadersWidth = 62;
            GridInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridInscripciones.Size = new Size(761, 380);
            GridInscripciones.TabIndex = 11;
            GridInscripciones.MouseClick += GridInscripciones_MouseClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ComboTipoInscripcion);
            panel2.Controls.Add(BtnAgregarUsuario);
            panel2.Controls.Add(BtnBuscar);
            panel2.Controls.Add(TxtBuscarInscripto);
            panel2.Controls.Add(GridUsuarios);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(808, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 509);
            panel2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(21, 323);
            label4.Name = "label4";
            label4.Size = new Size(216, 32);
            label4.TabIndex = 19;
            label4.Text = "Tipo de inscripción";
            // 
            // ComboTipoInscripcion
            // 
            ComboTipoInscripcion.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboTipoInscripcion.Font = new Font("Segoe UI", 12F);
            ComboTipoInscripcion.FormattingEnabled = true;
            ComboTipoInscripcion.Location = new Point(21, 371);
            ComboTipoInscripcion.Name = "ComboTipoInscripcion";
            ComboTipoInscripcion.Size = new Size(582, 40);
            ComboTipoInscripcion.TabIndex = 18;
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregarUsuario.IconColor = Color.Black;
            BtnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarUsuario.Location = new Point(641, 357);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(138, 54);
            BtnAgregarUsuario.TabIndex = 17;
            BtnAgregarUsuario.Text = "&Agregar inscripto...";
            BtnAgregarUsuario.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregarUsuario.UseCompatibleTextRendering = true;
            BtnAgregarUsuario.UseVisualStyleBackColor = true;
            BtnAgregarUsuario.Click += BtnAgregarUsuario_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(643, 60);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(136, 54);
            BtnBuscar.TabIndex = 16;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscarInscripto
            // 
            TxtBuscarInscripto.Font = new Font("Segoe UI", 12F);
            TxtBuscarInscripto.Location = new Point(21, 75);
            TxtBuscarInscripto.Name = "TxtBuscarInscripto";
            TxtBuscarInscripto.PlaceholderText = "Buscar inscriptos...";
            TxtBuscarInscripto.Size = new Size(582, 39);
            TxtBuscarInscripto.TabIndex = 15;
            TxtBuscarInscripto.TextChanged += TxtBuscarInscripto_TextChanged;
            TxtBuscarInscripto.KeyPress += TxtBuscarInscripto_KeyPress;
            // 
            // GridUsuarios
            // 
            GridUsuarios.AllowUserToAddRows = false;
            GridUsuarios.AllowUserToDeleteRows = false;
            GridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridUsuarios.Location = new Point(21, 146);
            GridUsuarios.Name = "GridUsuarios";
            GridUsuarios.ReadOnly = true;
            GridUsuarios.RowHeadersVisible = false;
            GridUsuarios.RowHeadersWidth = 62;
            GridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridUsuarios.Size = new Size(758, 160);
            GridUsuarios.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(21, 17);
            label3.Name = "label3";
            label3.Size = new Size(219, 32);
            label3.TabIndex = 13;
            label3.Text = "Agregar inscripción";
            // 
            // ContextMenuInscripcion
            // 
            ContextMenuInscripcion.ImageScalingSize = new Size(24, 24);
            ContextMenuInscripcion.Items.AddRange(new ToolStripItem[] { SubMenuEliminarInscripcion });
            ContextMenuInscripcion.Name = "ContextMenuInscripcion";
            ContextMenuInscripcion.Size = new Size(225, 36);
            // 
            // SubMenuEliminarInscripcion
            // 
            SubMenuEliminarInscripcion.Name = "SubMenuEliminarInscripcion";
            SubMenuEliminarInscripcion.Size = new Size(224, 32);
            SubMenuEliminarInscripcion.Text = "&Anular inscripción";
            SubMenuEliminarInscripcion.Click += SubMenuEliminarInscripcion_Click;
            // 
            // BtnImprimirInscripciones
            // 
            BtnImprimirInscripciones.Anchor = AnchorStyles.Bottom;
            BtnImprimirInscripciones.IconChar = FontAwesome.Sharp.IconChar.Print;
            BtnImprimirInscripciones.IconColor = Color.Black;
            BtnImprimirInscripciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnImprimirInscripciones.ImageAlign = ContentAlignment.MiddleLeft;
            BtnImprimirInscripciones.Location = new Point(282, 567);
            BtnImprimirInscripciones.Name = "BtnImprimirInscripciones";
            BtnImprimirInscripciones.Size = new Size(249, 54);
            BtnImprimirInscripciones.TabIndex = 20;
            BtnImprimirInscripciones.Text = "&Imprimir inscripciones";
            BtnImprimirInscripciones.TextAlign = ContentAlignment.MiddleRight;
            BtnImprimirInscripciones.UseCompatibleTextRendering = true;
            BtnImprimirInscripciones.UseVisualStyleBackColor = true;
            BtnImprimirInscripciones.Click += BtnImprimirInscripciones_Click;
            // 
            // InscripcionesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 625);
            Controls.Add(BtnImprimirInscripciones);
            Controls.Add(panel2);
            Controls.Add(GridInscripciones);
            Controls.Add(label2);
            Controls.Add(ComboCapacitaciones);
            Controls.Add(panel1);
            Name = "InscripcionesView";
            Text = "Inscripciones";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).EndInit();
            ContextMenuInscripcion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox ComboCapacitaciones;
        private Label label2;
        private DataGridView GridInscripciones;
        private Panel panel2;
        private Label label3;
        private DataGridView GridUsuarios;
        private TextBox TxtBuscarInscripto;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnAgregarUsuario;
        private ComboBox ComboTipoInscripcion;
        private Label label4;
        private ContextMenuStrip ContextMenuInscripcion;
        private ToolStripMenuItem SubMenuEliminarInscripcion;
        private FontAwesome.Sharp.IconButton BtnImprimirInscripciones;
    }
}