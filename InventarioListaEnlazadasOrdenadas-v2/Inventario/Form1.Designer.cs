﻿namespace Inventario
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.bttonAdd = new System.Windows.Forms.Button();
            this.bttonDelete = new System.Windows.Forms.Button();
            this.bttonBuscar = new System.Windows.Forms.Button();
            this.bttonReporte = new System.Windows.Forms.Button();
            this.txtReportes = new System.Windows.Forms.TextBox();
            this.lblProcuctosEnAlmacen = new System.Windows.Forms.Label();
            this.bttonReporteInverso = new System.Windows.Forms.Button();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.bttonInsertar = new System.Windows.Forms.Button();
            this.bttonAgregarInicio = new System.Windows.Forms.Button();
            this.bttonEliminarPrimero = new System.Windows.Forms.Button();
            this.bttonEliminarUltimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 85);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 16);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(9, 123);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 16);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(101, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(129, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(101, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(101, 82);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(129, 21);
            this.txtPrecio.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(101, 120);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(129, 21);
            this.txtCantidad.TabIndex = 3;
            // 
            // bttonAdd
            // 
            this.bttonAdd.AutoSize = true;
            this.bttonAdd.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonAdd.Location = new System.Drawing.Point(12, 178);
            this.bttonAdd.Name = "bttonAdd";
            this.bttonAdd.Size = new System.Drawing.Size(57, 51);
            this.bttonAdd.TabIndex = 4;
            this.bttonAdd.Text = "+";
            this.bttonAdd.UseVisualStyleBackColor = true;
            this.bttonAdd.Click += new System.EventHandler(this.bttonAdd_Click);
            // 
            // bttonDelete
            // 
            this.bttonDelete.AutoSize = true;
            this.bttonDelete.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonDelete.Location = new System.Drawing.Point(173, 178);
            this.bttonDelete.Name = "bttonDelete";
            this.bttonDelete.Size = new System.Drawing.Size(57, 51);
            this.bttonDelete.TabIndex = 6;
            this.bttonDelete.Text = "-";
            this.bttonDelete.UseVisualStyleBackColor = true;
            this.bttonDelete.Click += new System.EventHandler(this.bttonDelete_Click);
            // 
            // bttonBuscar
            // 
            this.bttonBuscar.AutoSize = true;
            this.bttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonBuscar.Location = new System.Drawing.Point(86, 178);
            this.bttonBuscar.Name = "bttonBuscar";
            this.bttonBuscar.Size = new System.Drawing.Size(67, 51);
            this.bttonBuscar.TabIndex = 5;
            this.bttonBuscar.Text = "Buscar";
            this.bttonBuscar.UseVisualStyleBackColor = true;
            this.bttonBuscar.Click += new System.EventHandler(this.bttonBuscar_Click);
            // 
            // bttonReporte
            // 
            this.bttonReporte.AutoSize = true;
            this.bttonReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonReporte.Location = new System.Drawing.Point(439, 385);
            this.bttonReporte.Name = "bttonReporte";
            this.bttonReporte.Size = new System.Drawing.Size(129, 26);
            this.bttonReporte.TabIndex = 12;
            this.bttonReporte.Text = "Reporte";
            this.bttonReporte.UseVisualStyleBackColor = true;
            this.bttonReporte.Click += new System.EventHandler(this.bttonReporte_Click);
            // 
            // txtReportes
            // 
            this.txtReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportes.Location = new System.Drawing.Point(273, 9);
            this.txtReportes.Multiline = true;
            this.txtReportes.Name = "txtReportes";
            this.txtReportes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReportes.Size = new System.Drawing.Size(295, 362);
            this.txtReportes.TabIndex = 15;
            this.txtReportes.TabStop = false;
            // 
            // lblProcuctosEnAlmacen
            // 
            this.lblProcuctosEnAlmacen.AutoSize = true;
            this.lblProcuctosEnAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcuctosEnAlmacen.Location = new System.Drawing.Point(9, 424);
            this.lblProcuctosEnAlmacen.Name = "lblProcuctosEnAlmacen";
            this.lblProcuctosEnAlmacen.Size = new System.Drawing.Size(0, 16);
            this.lblProcuctosEnAlmacen.TabIndex = 4;
            // 
            // bttonReporteInverso
            // 
            this.bttonReporteInverso.AutoSize = true;
            this.bttonReporteInverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonReporteInverso.Location = new System.Drawing.Point(439, 420);
            this.bttonReporteInverso.Name = "bttonReporteInverso";
            this.bttonReporteInverso.Size = new System.Drawing.Size(129, 26);
            this.bttonReporteInverso.TabIndex = 13;
            this.bttonReporteInverso.Text = "Reporte Inverso";
            this.bttonReporteInverso.UseVisualStyleBackColor = true;
            this.bttonReporteInverso.Click += new System.EventHandler(this.bttonReporteInverso_Click);
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(11, 262);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(68, 16);
            this.lblPosicion.TabIndex = 4;
            this.lblPosicion.Text = "Posición";
            // 
            // txtPosicion
            // 
            this.txtPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicion.Location = new System.Drawing.Point(85, 259);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(59, 21);
            this.txtPosicion.TabIndex = 7;
            // 
            // bttonInsertar
            // 
            this.bttonInsertar.AutoSize = true;
            this.bttonInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonInsertar.Location = new System.Drawing.Point(160, 257);
            this.bttonInsertar.Name = "bttonInsertar";
            this.bttonInsertar.Size = new System.Drawing.Size(70, 26);
            this.bttonInsertar.TabIndex = 8;
            this.bttonInsertar.Text = "Insertar";
            this.bttonInsertar.UseVisualStyleBackColor = true;
            this.bttonInsertar.Click += new System.EventHandler(this.bttonInsertar_Click);
            // 
            // bttonAgregarInicio
            // 
            this.bttonAgregarInicio.AutoSize = true;
            this.bttonAgregarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttonAgregarInicio.Location = new System.Drawing.Point(50, 301);
            this.bttonAgregarInicio.Name = "bttonAgregarInicio";
            this.bttonAgregarInicio.Size = new System.Drawing.Size(132, 34);
            this.bttonAgregarInicio.TabIndex = 9;
            this.bttonAgregarInicio.Text = "Agregar al inicio";
            this.bttonAgregarInicio.UseVisualStyleBackColor = true;
            this.bttonAgregarInicio.Click += new System.EventHandler(this.bttonAgregarInicio_Click);
            // 
            // bttonEliminarPrimero
            // 
            this.bttonEliminarPrimero.AutoSize = true;
            this.bttonEliminarPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttonEliminarPrimero.Location = new System.Drawing.Point(50, 358);
            this.bttonEliminarPrimero.Name = "bttonEliminarPrimero";
            this.bttonEliminarPrimero.Size = new System.Drawing.Size(132, 34);
            this.bttonEliminarPrimero.TabIndex = 10;
            this.bttonEliminarPrimero.Text = "Eliminar primero";
            this.bttonEliminarPrimero.UseVisualStyleBackColor = true;
            this.bttonEliminarPrimero.Click += new System.EventHandler(this.bttonEliminarPrimero_Click);
            // 
            // bttonEliminarUltimo
            // 
            this.bttonEliminarUltimo.AutoSize = true;
            this.bttonEliminarUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttonEliminarUltimo.Location = new System.Drawing.Point(50, 412);
            this.bttonEliminarUltimo.Name = "bttonEliminarUltimo";
            this.bttonEliminarUltimo.Size = new System.Drawing.Size(132, 34);
            this.bttonEliminarUltimo.TabIndex = 11;
            this.bttonEliminarUltimo.Text = "Eliminar ultimo";
            this.bttonEliminarUltimo.UseVisualStyleBackColor = true;
            this.bttonEliminarUltimo.Click += new System.EventHandler(this.bttonEliminarUltimo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.bttonEliminarUltimo);
            this.Controls.Add(this.bttonEliminarPrimero);
            this.Controls.Add(this.bttonAgregarInicio);
            this.Controls.Add(this.txtReportes);
            this.Controls.Add(this.bttonReporteInverso);
            this.Controls.Add(this.bttonReporte);
            this.Controls.Add(this.bttonBuscar);
            this.Controls.Add(this.bttonInsertar);
            this.Controls.Add(this.bttonDelete);
            this.Controls.Add(this.bttonAdd);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblProcuctosEnAlmacen);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FormMain";
            this.Text = "Control de Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button bttonAdd;
        private System.Windows.Forms.Button bttonDelete;
        private System.Windows.Forms.Button bttonBuscar;
        private System.Windows.Forms.Button bttonReporte;
        private System.Windows.Forms.TextBox txtReportes;
        private System.Windows.Forms.Label lblProcuctosEnAlmacen;
        private System.Windows.Forms.Button bttonReporteInverso;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Button bttonInsertar;
        private System.Windows.Forms.Button bttonAgregarInicio;
        private System.Windows.Forms.Button bttonEliminarPrimero;
        private System.Windows.Forms.Button bttonEliminarUltimo;
    }
}

