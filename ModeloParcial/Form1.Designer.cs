namespace ModeloParcial
{
   partial class Form1
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
         lblNuevaEntrada = new Label();
         lblTipoTurismo = new Label();
         cmbTipoTurismo = new ComboBox();
         lblDNIPasaporte = new Label();
         txtDNIPasaporte = new TextBox();
         lblMonto = new Label();
         txtMonto = new TextBox();
         lblFechaValidez = new Label();
         btnAltaEntrada = new Button();
         dgvNuevaEntrada = new DataGridView();
         lblEliminarEntrada = new Label();
         lblIdEntrada = new Label();
         txtIdEntrada = new TextBox();
         btnEliminarEntrada = new Button();
         lblExtenderLicencia = new Label();
         txtExtenderVigencia = new TextBox();
         btnModificar = new Button();
         dateTimePicker1 = new DateTimePicker();
         dateTimePicker2 = new DateTimePicker();
         ((System.ComponentModel.ISupportInitialize)dgvNuevaEntrada).BeginInit();
         SuspendLayout();
         // 
         // lblNuevaEntrada
         // 
         lblNuevaEntrada.AutoSize = true;
         lblNuevaEntrada.Location = new Point(51, 27);
         lblNuevaEntrada.Name = "lblNuevaEntrada";
         lblNuevaEntrada.Size = new Size(106, 20);
         lblNuevaEntrada.TabIndex = 0;
         lblNuevaEntrada.Text = "Nueva Entrada";
         // 
         // lblTipoTurismo
         // 
         lblTipoTurismo.AutoSize = true;
         lblTipoTurismo.Location = new Point(76, 64);
         lblTipoTurismo.Name = "lblTipoTurismo";
         lblTipoTurismo.Size = new Size(99, 20);
         lblTipoTurismo.TabIndex = 1;
         lblTipoTurismo.Text = "Tipo Turismo:";
         // 
         // cmbTipoTurismo
         // 
         cmbTipoTurismo.FormattingEnabled = true;
         cmbTipoTurismo.Location = new Point(51, 104);
         cmbTipoTurismo.Name = "cmbTipoTurismo";
         cmbTipoTurismo.Size = new Size(151, 28);
         cmbTipoTurismo.TabIndex = 2;
         // 
         // lblDNIPasaporte
         // 
         lblDNIPasaporte.AutoSize = true;
         lblDNIPasaporte.Location = new Point(66, 152);
         lblDNIPasaporte.Name = "lblDNIPasaporte";
         lblDNIPasaporte.Size = new Size(109, 20);
         lblDNIPasaporte.TabIndex = 3;
         lblDNIPasaporte.Text = "DNI/Pasaporte:";
         // 
         // txtDNIPasaporte
         // 
         txtDNIPasaporte.Location = new Point(51, 192);
         txtDNIPasaporte.Name = "txtDNIPasaporte";
         txtDNIPasaporte.Size = new Size(151, 27);
         txtDNIPasaporte.TabIndex = 4;
         // 
         // lblMonto
         // 
         lblMonto.AutoSize = true;
         lblMonto.Location = new Point(91, 244);
         lblMonto.Name = "lblMonto";
         lblMonto.Size = new Size(56, 20);
         lblMonto.TabIndex = 5;
         lblMonto.Text = "Monto:";
         // 
         // txtMonto
         // 
         txtMonto.Location = new Point(51, 276);
         txtMonto.Name = "txtMonto";
         txtMonto.Size = new Size(151, 27);
         txtMonto.TabIndex = 6;
         // 
         // lblFechaValidez
         // 
         lblFechaValidez.AutoSize = true;
         lblFechaValidez.Location = new Point(76, 331);
         lblFechaValidez.Name = "lblFechaValidez";
         lblFechaValidez.Size = new Size(102, 20);
         lblFechaValidez.TabIndex = 7;
         lblFechaValidez.Text = "Fecha Validez:";
         // 
         // btnAltaEntrada
         // 
         btnAltaEntrada.Location = new Point(125, 409);
         btnAltaEntrada.Name = "btnAltaEntrada";
         btnAltaEntrada.Size = new Size(147, 29);
         btnAltaEntrada.TabIndex = 9;
         btnAltaEntrada.Text = "Alta Entrada";
         btnAltaEntrada.UseVisualStyleBackColor = true;
         btnAltaEntrada.Click += btnAltaEntrada_Click;
         // 
         // dgvNuevaEntrada
         // 
         dgvNuevaEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvNuevaEntrada.Location = new Point(257, 43);
         dgvNuevaEntrada.Name = "dgvNuevaEntrada";
         dgvNuevaEntrada.RowHeadersWidth = 51;
         dgvNuevaEntrada.Size = new Size(531, 238);
         dgvNuevaEntrada.TabIndex = 10;
         // 
         // lblEliminarEntrada
         // 
         lblEliminarEntrada.AutoSize = true;
         lblEliminarEntrada.Location = new Point(377, 304);
         lblEliminarEntrada.Name = "lblEliminarEntrada";
         lblEliminarEntrada.Size = new Size(118, 20);
         lblEliminarEntrada.TabIndex = 11;
         lblEliminarEntrada.Text = "Eliminar Entrada";
         // 
         // lblIdEntrada
         // 
         lblIdEntrada.AutoSize = true;
         lblIdEntrada.Location = new Point(279, 340);
         lblIdEntrada.Name = "lblIdEntrada";
         lblIdEntrada.Size = new Size(80, 20);
         lblIdEntrada.TabIndex = 12;
         lblIdEntrada.Text = "Id Entrada:";
         // 
         // txtIdEntrada
         // 
         txtIdEntrada.Location = new Point(365, 340);
         txtIdEntrada.Name = "txtIdEntrada";
         txtIdEntrada.Size = new Size(151, 27);
         txtIdEntrada.TabIndex = 13;
         // 
         // btnEliminarEntrada
         // 
         btnEliminarEntrada.Location = new Point(365, 409);
         btnEliminarEntrada.Name = "btnEliminarEntrada";
         btnEliminarEntrada.Size = new Size(147, 29);
         btnEliminarEntrada.TabIndex = 14;
         btnEliminarEntrada.Text = "Eliminar ";
         btnEliminarEntrada.UseVisualStyleBackColor = true;
         btnEliminarEntrada.Click += btnEliminarEntrada_Click;
         // 
         // lblExtenderLicencia
         // 
         lblExtenderLicencia.AutoSize = true;
         lblExtenderLicencia.Location = new Point(541, 304);
         lblExtenderLicencia.Name = "lblExtenderLicencia";
         lblExtenderLicencia.Size = new Size(128, 20);
         lblExtenderLicencia.TabIndex = 15;
         lblExtenderLicencia.Text = "Extender Vigencia";
         // 
         // txtExtenderVigencia
         // 
         txtExtenderVigencia.Location = new Point(541, 340);
         txtExtenderVigencia.Name = "txtExtenderVigencia";
         txtExtenderVigencia.Size = new Size(151, 27);
         txtExtenderVigencia.TabIndex = 16;
         // 
         // btnModificar
         // 
         btnModificar.Location = new Point(545, 409);
         btnModificar.Name = "btnModificar";
         btnModificar.Size = new Size(147, 29);
         btnModificar.TabIndex = 18;
         btnModificar.Text = "Modificar ";
         btnModificar.UseVisualStyleBackColor = true;
         btnModificar.Click += btnModificar_Click;
         // 
         // dateTimePicker1
         // 
         dateTimePicker1.Location = new Point(51, 371);
         dateTimePicker1.Name = "dateTimePicker1";
         dateTimePicker1.Size = new Size(151, 27);
         dateTimePicker1.TabIndex = 19;
         // 
         // dateTimePicker2
         // 
         dateTimePicker2.Location = new Point(541, 373);
         dateTimePicker2.Name = "dateTimePicker2";
         dateTimePicker2.Size = new Size(151, 27);
         dateTimePicker2.TabIndex = 20;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(800, 450);
         Controls.Add(dateTimePicker2);
         Controls.Add(dateTimePicker1);
         Controls.Add(btnModificar);
         Controls.Add(txtExtenderVigencia);
         Controls.Add(lblExtenderLicencia);
         Controls.Add(btnEliminarEntrada);
         Controls.Add(txtIdEntrada);
         Controls.Add(lblIdEntrada);
         Controls.Add(lblEliminarEntrada);
         Controls.Add(dgvNuevaEntrada);
         Controls.Add(btnAltaEntrada);
         Controls.Add(lblFechaValidez);
         Controls.Add(txtMonto);
         Controls.Add(lblMonto);
         Controls.Add(txtDNIPasaporte);
         Controls.Add(lblDNIPasaporte);
         Controls.Add(cmbTipoTurismo);
         Controls.Add(lblTipoTurismo);
         Controls.Add(lblNuevaEntrada);
         Name = "Form1";
         Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)dgvNuevaEntrada).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label lblNuevaEntrada;
      private Label lblTipoTurismo;
      private ComboBox cmbTipoTurismo;
      private Label lblDNIPasaporte;
      private TextBox txtDNIPasaporte;
      private Label lblMonto;
      private TextBox txtMonto;
      private Label lblFechaValidez;
      private Button btnAltaEntrada;
      private DataGridView dgvNuevaEntrada;
      private Label lblEliminarEntrada;
      private Label lblIdEntrada;
      private TextBox txtIdEntrada;
      private Button btnEliminarEntrada;
      private Label lblExtenderLicencia;
      private TextBox txtExtenderVigencia;
      private Button btnModificar;
      private DateTimePicker dateTimePicker1;
      private DateTimePicker dateTimePicker2;
   }
}
