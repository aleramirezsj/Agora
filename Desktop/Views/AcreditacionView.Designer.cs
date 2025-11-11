namespace Desktop.Views
{
    partial class AcreditacionesView
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
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscarInscripto = new TextBox();
            ContextMenuInscripcion = new ContextMenuStrip(components);
            SubMenuEliminarInscripcion = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).BeginInit();
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
            label1.Size = new Size(341, 62);
            label1.TabIndex = 1;
            label1.Text = "Acreditaciones";
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
            ComboCapacitaciones.Size = new Size(1211, 40);
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
            GridInscripciones.Location = new Point(26, 241);
            GridInscripciones.Name = "GridInscripciones";
            GridInscripciones.ReadOnly = true;
            GridInscripciones.RowHeadersVisible = false;
            GridInscripciones.RowHeadersWidth = 62;
            GridInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridInscripciones.Size = new Size(1550, 372);
            GridInscripciones.TabIndex = 11;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(1275, 165);
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
            TxtBuscarInscripto.Location = new Point(200, 171);
            TxtBuscarInscripto.Name = "TxtBuscarInscripto";
            TxtBuscarInscripto.PlaceholderText = "Buscar inscriptos...";
            TxtBuscarInscripto.Size = new Size(1055, 39);
            TxtBuscarInscripto.TabIndex = 15;
            TxtBuscarInscripto.TextChanged += TxtBuscarInscripto_TextChanged;
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
            // 
            // AcreditacionesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 625);
            Controls.Add(GridInscripciones);
            Controls.Add(BtnBuscar);
            Controls.Add(label2);
            Controls.Add(TxtBuscarInscripto);
            Controls.Add(ComboCapacitaciones);
            Controls.Add(panel1);
            Name = "AcreditacionesView";
            Text = "Acreditaciones";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).EndInit();
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
        private TextBox TxtBuscarInscripto;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private ContextMenuStrip ContextMenuInscripcion;
        private ToolStripMenuItem SubMenuEliminarInscripcion;
    }
}