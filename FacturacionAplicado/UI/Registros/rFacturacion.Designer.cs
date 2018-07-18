namespace FacturacionAplicado.UI.Registros
{
    partial class rFacturacion
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
            this.EliminarDetalle = new System.Windows.Forms.Button();
            this.NombreCLientetextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IDcomboBox = new System.Windows.Forms.ComboBox();
            this.CLienteIDcomboBox = new System.Windows.Forms.ComboBox();
            this.ProductoIdcomboBox = new System.Windows.Forms.ComboBox();
            this.DetallecomboBox = new System.Windows.Forms.ComboBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.Importe = new System.Windows.Forms.Label();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DescripcionProductotextBox = new System.Windows.Forms.TextBox();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.NUevobutton = new System.Windows.Forms.Button();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.DevueltatextBox = new System.Windows.Forms.TextBox();
            this.EfectivonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FacturadataGridView = new System.Windows.Forms.DataGridView();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteDg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripciponFacturatextBox = new System.Windows.Forms.TextBox();
            this.FormaDePagocomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DemaserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemaserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarDetalle
            // 
            this.EliminarDetalle.Enabled = false;
            this.EliminarDetalle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarDetalle.Location = new System.Drawing.Point(4, 501);
            this.EliminarDetalle.Name = "EliminarDetalle";
            this.EliminarDetalle.Size = new System.Drawing.Size(86, 27);
            this.EliminarDetalle.TabIndex = 11;
            this.EliminarDetalle.Text = "Eliminar Detalle";
            this.EliminarDetalle.UseVisualStyleBackColor = true;
            this.EliminarDetalle.Click += new System.EventHandler(this.EliminarDetalle_Click);
            // 
            // NombreCLientetextBox
            // 
            this.NombreCLientetextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NombreCLientetextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NombreCLientetextBox.Location = new System.Drawing.Point(126, 123);
            this.NombreCLientetextBox.Name = "NombreCLientetextBox";
            this.NombreCLientetextBox.ReadOnly = true;
            this.NombreCLientetextBox.Size = new System.Drawing.Size(121, 20);
            this.NombreCLientetextBox.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 98;
            this.label10.Text = "Nombre CLiente";
            // 
            // IDcomboBox
            // 
            this.IDcomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDcomboBox.FormattingEnabled = true;
            this.IDcomboBox.Location = new System.Drawing.Point(39, 20);
            this.IDcomboBox.Name = "IDcomboBox";
            this.IDcomboBox.Size = new System.Drawing.Size(55, 21);
            this.IDcomboBox.TabIndex = 0;
            this.IDcomboBox.SelectedIndexChanged += new System.EventHandler(this.IDcomboBox_SelectedIndexChanged_1);
            // 
            // CLienteIDcomboBox
            // 
            this.CLienteIDcomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CLienteIDcomboBox.FormattingEnabled = true;
            this.CLienteIDcomboBox.Location = new System.Drawing.Point(180, 14);
            this.CLienteIDcomboBox.Name = "CLienteIDcomboBox";
            this.CLienteIDcomboBox.Size = new System.Drawing.Size(69, 21);
            this.CLienteIDcomboBox.TabIndex = 1;
            this.CLienteIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.CLienteIDcomboBox_SelectedIndexChanged);
            // 
            // ProductoIdcomboBox
            // 
            this.ProductoIdcomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductoIdcomboBox.FormattingEnabled = true;
            this.ProductoIdcomboBox.Location = new System.Drawing.Point(20, 184);
            this.ProductoIdcomboBox.Name = "ProductoIdcomboBox";
            this.ProductoIdcomboBox.Size = new System.Drawing.Size(111, 21);
            this.ProductoIdcomboBox.TabIndex = 4;
            this.ProductoIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.ProductoIdcomboBox_SelectedIndexChanged);
            // 
            // DetallecomboBox
            // 
            this.DetallecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DetallecomboBox.Enabled = false;
            this.DetallecomboBox.FormattingEnabled = true;
            this.DetallecomboBox.Location = new System.Drawing.Point(163, 184);
            this.DetallecomboBox.Name = "DetallecomboBox";
            this.DetallecomboBox.Size = new System.Drawing.Size(111, 21);
            this.DetallecomboBox.TabIndex = 94;
            this.DetallecomboBox.SelectedIndexChanged += new System.EventHandler(this.DetallecomboBox_SelectedIndexChanged);
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuariotextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UsuariotextBox.Location = new System.Drawing.Point(103, 511);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.ReadOnly = true;
            this.UsuariotextBox.Size = new System.Drawing.Size(87, 20);
            this.UsuariotextBox.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(182, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 92;
            this.label11.Text = "ID Detalle";
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImportetextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImportetextBox.Location = new System.Drawing.Point(419, 246);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportetextBox.TabIndex = 91;
            // 
            // Importe
            // 
            this.Importe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Importe.AutoSize = true;
            this.Importe.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Importe.Location = new System.Drawing.Point(435, 220);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(59, 18);
            this.Importe.TabIndex = 90;
            this.Importe.Text = "Importe";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Agregarbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.Location = new System.Drawing.Point(536, 236);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(67, 34);
            this.Agregarbutton.TabIndex = 6;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(333, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 18);
            this.label12.TabIndex = 88;
            this.label12.Text = "Precio";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PreciotextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PreciotextBox.Location = new System.Drawing.Point(300, 246);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(58, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 18);
            this.label13.TabIndex = 86;
            this.label13.Text = "Descripcion";
            // 
            // DescripcionProductotextBox
            // 
            this.DescripcionProductotextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescripcionProductotextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DescripcionProductotextBox.Location = new System.Drawing.Point(5, 246);
            this.DescripcionProductotextBox.Name = "DescripcionProductotextBox";
            this.DescripcionProductotextBox.ReadOnly = true;
            this.DescripcionProductotextBox.Size = new System.Drawing.Size(212, 20);
            this.DescripcionProductotextBox.TabIndex = 85;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(223, 246);
            this.CantidadnumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.CantidadnumericUpDown.TabIndex = 5;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(225, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 18);
            this.label14.TabIndex = 83;
            this.label14.Text = "Cantidad";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 18);
            this.label15.TabIndex = 82;
            this.label15.Text = "ProductoId";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.Location = new System.Drawing.Point(354, 552);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(82, 44);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardarbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.Location = new System.Drawing.Point(251, 552);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(82, 44);
            this.Guardarbutton.TabIndex = 8;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // NUevobutton
            // 
            this.NUevobutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NUevobutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NUevobutton.Location = new System.Drawing.Point(148, 552);
            this.NUevobutton.Name = "NUevobutton";
            this.NUevobutton.Size = new System.Drawing.Size(82, 44);
            this.NUevobutton.TabIndex = 9;
            this.NUevobutton.Text = "Nuevo";
            this.NUevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NUevobutton.UseVisualStyleBackColor = true;
            this.NUevobutton.Click += new System.EventHandler(this.NUevobutton_Click);
            // 
            // MontotextBox
            // 
            this.MontotextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MontotextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MontotextBox.Location = new System.Drawing.Point(515, 511);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.ReadOnly = true;
            this.MontotextBox.Size = new System.Drawing.Size(87, 20);
            this.MontotextBox.TabIndex = 78;
            // 
            // DevueltatextBox
            // 
            this.DevueltatextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DevueltatextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DevueltatextBox.Location = new System.Drawing.Point(365, 511);
            this.DevueltatextBox.Name = "DevueltatextBox";
            this.DevueltatextBox.ReadOnly = true;
            this.DevueltatextBox.Size = new System.Drawing.Size(87, 20);
            this.DevueltatextBox.TabIndex = 77;
            // 
            // EfectivonumericUpDown
            // 
            this.EfectivonumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EfectivonumericUpDown.Location = new System.Drawing.Point(215, 511);
            this.EfectivonumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.EfectivonumericUpDown.Name = "EfectivonumericUpDown";
            this.EfectivonumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.EfectivonumericUpDown.TabIndex = 7;
            this.EfectivonumericUpDown.ValueChanged += new System.EventHandler(this.EfectivonumericUpDown_ValueChanged);
            // 
            // FacturadataGridView
            // 
            this.FacturadataGridView.AllowUserToAddRows = false;
            this.FacturadataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacturadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoId,
            this.Cantidad,
            this.Precio,
            this.Descripcion,
            this.FacturaId,
            this.Id,
            this.ImporteDg});
            this.FacturadataGridView.Location = new System.Drawing.Point(10, 272);
            this.FacturadataGridView.Name = "FacturadataGridView";
            this.FacturadataGridView.Size = new System.Drawing.Size(593, 210);
            this.FacturadataGridView.TabIndex = 75;
            this.FacturadataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacturadataGridView_CellClick);
            // 
            // ProductoId
            // 
            this.ProductoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductoId.DataPropertyName = "ProductoId";
            this.ProductoId.HeaderText = "ProductoId";
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.ReadOnly = true;
            this.ProductoId.Width = 60;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 180;
            // 
            // FacturaId
            // 
            this.FacturaId.DataPropertyName = "FacturaId";
            this.FacturaId.HeaderText = "FacturaId";
            this.FacturaId.Name = "FacturaId";
            this.FacturaId.ReadOnly = true;
            this.FacturaId.Width = 60;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 60;
            // 
            // ImporteDg
            // 
            this.ImporteDg.DataPropertyName = "Importe";
            this.ImporteDg.HeaderText = "Importe";
            this.ImporteDg.Name = "ImporteDg";
            this.ImporteDg.ReadOnly = true;
            this.ImporteDg.Width = 70;
            // 
            // DescripciponFacturatextBox
            // 
            this.DescripciponFacturatextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescripciponFacturatextBox.Location = new System.Drawing.Point(316, 92);
            this.DescripciponFacturatextBox.Multiline = true;
            this.DescripciponFacturatextBox.Name = "DescripciponFacturatextBox";
            this.DescripciponFacturatextBox.Size = new System.Drawing.Size(299, 89);
            this.DescripciponFacturatextBox.TabIndex = 3;
            // 
            // FormaDePagocomboBox
            // 
            this.FormaDePagocomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormaDePagocomboBox.FormattingEnabled = true;
            this.FormaDePagocomboBox.Location = new System.Drawing.Point(126, 93);
            this.FormaDePagocomboBox.Name = "FormaDePagocomboBox";
            this.FormaDePagocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FormaDePagocomboBox.TabIndex = 2;
            this.FormaDePagocomboBox.SelectedIndexChanged += new System.EventHandler(this.FormaDePagocomboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "Descripcion";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FechadateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(323, 15);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.FechadateTimePicker.TabIndex = 71;
            this.FechadateTimePicker.Value = new System.DateTime(2018, 6, 20, 9, 58, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(221, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 70;
            this.label9.Text = "Efectivo Recibido";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 69;
            this.label8.Text = "Devuelta";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 68;
            this.label7.Text = "Forma de pago";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Monto";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "ClienteId";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Nombre Usuario";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Id";
            // 
            // IDerrorProvider
            // 
            this.IDerrorProvider.ContainerControl = this;
            // 
            // DemaserrorProvider
            // 
            this.DemaserrorProvider.ContainerControl = this;
            // 
            // ProductoerrorProvider
            // 
            this.ProductoerrorProvider.ContainerControl = this;
            // 
            // rFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 749);
            this.Controls.Add(this.EliminarDetalle);
            this.Controls.Add(this.NombreCLientetextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IDcomboBox);
            this.Controls.Add(this.CLienteIDcomboBox);
            this.Controls.Add(this.ProductoIdcomboBox);
            this.Controls.Add(this.DetallecomboBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ImportetextBox);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DescripcionProductotextBox);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.NUevobutton);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.DevueltatextBox);
            this.Controls.Add(this.EfectivonumericUpDown);
            this.Controls.Add(this.FacturadataGridView);
            this.Controls.Add(this.DescripciponFacturatextBox);
            this.Controls.Add(this.FormaDePagocomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rFacturacion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemaserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarDetalle;
        private System.Windows.Forms.TextBox NombreCLientetextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox IDcomboBox;
        private System.Windows.Forms.ComboBox CLienteIDcomboBox;
        private System.Windows.Forms.ComboBox ProductoIdcomboBox;
        private System.Windows.Forms.ComboBox DetallecomboBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.Label Importe;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DescripcionProductotextBox;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button NUevobutton;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.TextBox DevueltatextBox;
        private System.Windows.Forms.NumericUpDown EfectivonumericUpDown;
        private System.Windows.Forms.DataGridView FacturadataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteDg;
        private System.Windows.Forms.TextBox DescripciponFacturatextBox;
        private System.Windows.Forms.ComboBox FormaDePagocomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider IDerrorProvider;
        private System.Windows.Forms.ErrorProvider DemaserrorProvider;
        private System.Windows.Forms.ErrorProvider ProductoerrorProvider;
    }
}