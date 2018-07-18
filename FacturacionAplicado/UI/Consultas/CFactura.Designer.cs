namespace FacturacionAplicado.UI.Consultas
{
    partial class CFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFactura));
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.Consultabutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AHoradateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FInaldateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Reportebutton = new System.Windows.Forms.Button();
            this.FechacheckBox = new System.Windows.Forms.CheckBox();
            this.TexterrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContadocheckBox = new System.Windows.Forms.CheckBox();
            this.CreditocheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TexterrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 145);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(874, 415);
            this.ConsultadataGridView.TabIndex = 28;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(2, 7);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(29, 13);
            this.Tipo.TabIndex = 29;
            this.Tipo.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Criterio";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(151, 23);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(157, 20);
            this.CriteriotextBox.TabIndex = 31;
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Items.AddRange(new object[] {
            "ID",
            "ClienteId",
            "UsuarioId",
            "Descripcion",
            "Listar Todo",
            "Forma de pago",
            "Monto",
            "Efectivo recibido",
            "Devuelta",
            "Facturas Hechas a Credito"});
            this.TipocomboBox.Location = new System.Drawing.Point(5, 23);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(128, 21);
            this.TipocomboBox.TabIndex = 32;
            this.TipocomboBox.SelectedIndexChanged += new System.EventHandler(this.TipocomboBox_SelectedIndexChanged);
            // 
            // Consultabutton
            // 
         
            this.Consultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultabutton.Location = new System.Drawing.Point(347, 9);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(127, 58);
            this.Consultabutton.TabIndex = 33;
            this.Consultabutton.Text = "Consultar";
            this.Consultabutton.UseVisualStyleBackColor = true;
            this.Consultabutton.Click += new System.EventHandler(this.Consultabutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Hasta";
            // 
            // AHoradateTimePicker1
            // 
            this.AHoradateTimePicker1.Location = new System.Drawing.Point(12, 107);
            this.AHoradateTimePicker1.Name = "AHoradateTimePicker1";
            this.AHoradateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.AHoradateTimePicker1.TabIndex = 36;
            // 
            // FInaldateTimePicker2
            // 
            this.FInaldateTimePicker2.Location = new System.Drawing.Point(230, 107);
            this.FInaldateTimePicker2.Name = "FInaldateTimePicker2";
            this.FInaldateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.FInaldateTimePicker2.TabIndex = 37;
            // 
            // Reportebutton
            // 
          
            this.Reportebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportebutton.Location = new System.Drawing.Point(510, 9);
            this.Reportebutton.Name = "Reportebutton";
            this.Reportebutton.Size = new System.Drawing.Size(127, 58);
            this.Reportebutton.TabIndex = 38;
            this.Reportebutton.Text = "Reporte";
            this.Reportebutton.UseVisualStyleBackColor = true;
            this.Reportebutton.Click += new System.EventHandler(this.Reportebutton_Click);
            // 
            // FechacheckBox
            // 
            this.FechacheckBox.AutoSize = true;
            this.FechacheckBox.Checked = true;
            this.FechacheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FechacheckBox.Location = new System.Drawing.Point(5, 50);
            this.FechacheckBox.Name = "FechacheckBox";
            this.FechacheckBox.Size = new System.Drawing.Size(107, 17);
            this.FechacheckBox.TabIndex = 39;
            this.FechacheckBox.Text = "Buscar por fecha";
            this.FechacheckBox.UseVisualStyleBackColor = true;
            this.FechacheckBox.CheckedChanged += new System.EventHandler(this.FechacheckBox_CheckedChanged);
            // 
            // TexterrorProvider
            // 
            this.TexterrorProvider.ContainerControl = this;
            // 
            // ContadocheckBox
            // 
            this.ContadocheckBox.AutoSize = true;
            this.ContadocheckBox.Enabled = false;
            this.ContadocheckBox.Location = new System.Drawing.Point(132, 72);
            this.ContadocheckBox.Name = "ContadocheckBox";
            this.ContadocheckBox.Size = new System.Drawing.Size(66, 17);
            this.ContadocheckBox.TabIndex = 40;
            this.ContadocheckBox.Text = "Contado";
            this.ContadocheckBox.UseVisualStyleBackColor = true;
            // 
            // CreditocheckBox
            // 
            this.CreditocheckBox.AutoSize = true;
            this.CreditocheckBox.Enabled = false;
            this.CreditocheckBox.Location = new System.Drawing.Point(204, 72);
            this.CreditocheckBox.Name = "CreditocheckBox";
            this.CreditocheckBox.Size = new System.Drawing.Size(59, 17);
            this.CreditocheckBox.TabIndex = 41;
            this.CreditocheckBox.Text = "Credito";
            this.CreditocheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Formas de pago";
            // 
            // CFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(898, 572);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreditocheckBox);
            this.Controls.Add(this.ContadocheckBox);
            this.Controls.Add(this.FechacheckBox);
            this.Controls.Add(this.Reportebutton);
            this.Controls.Add(this.FInaldateTimePicker2);
            this.Controls.Add(this.AHoradateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.TipocomboBox);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.ConsultadataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CFactura";
            this.Text = "Consulta de Factura";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TexterrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Button Consultabutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker AHoradateTimePicker1;
        private System.Windows.Forms.DateTimePicker FInaldateTimePicker2;
        private System.Windows.Forms.Button Reportebutton;
        private System.Windows.Forms.CheckBox FechacheckBox;
        private System.Windows.Forms.ErrorProvider TexterrorProvider;
        private System.Windows.Forms.CheckBox CreditocheckBox;
        private System.Windows.Forms.CheckBox ContadocheckBox;
        private System.Windows.Forms.Label label4;
    }
}