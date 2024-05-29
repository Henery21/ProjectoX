using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace General2.GUI
{
    partial class InfoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoEmpleado));
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTItuloEmpleado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdentidad = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.lblNOmbres = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.DGInfoEmpleado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGInfoEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(600, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox1.Location = new System.Drawing.Point(-141, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 30);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(184, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // lblTItuloEmpleado
            // 
            this.lblTItuloEmpleado.AutoSize = true;
            this.lblTItuloEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItuloEmpleado.Location = new System.Drawing.Point(263, 63);
            this.lblTItuloEmpleado.Name = "lblTItuloEmpleado";
            this.lblTItuloEmpleado.Size = new System.Drawing.Size(295, 32);
            this.lblTItuloEmpleado.TabIndex = 9;
            this.lblTItuloEmpleado.Text = "Información del Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Identidad";
            // 
            // tbIdentidad
            // 
            this.tbIdentidad.Location = new System.Drawing.Point(10, 140);
            this.tbIdentidad.Name = "tbIdentidad";
            this.tbIdentidad.Size = new System.Drawing.Size(115, 20);
            this.tbIdentidad.TabIndex = 11;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(129, 140);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(124, 20);
            this.tbNombres.TabIndex = 13;
            // 
            // lblNOmbres
            // 
            this.lblNOmbres.AutoSize = true;
            this.lblNOmbres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOmbres.Location = new System.Drawing.Point(129, 115);
            this.lblNOmbres.Name = "lblNOmbres";
            this.lblNOmbres.Size = new System.Drawing.Size(70, 20);
            this.lblNOmbres.TabIndex = 12;
            this.lblNOmbres.Text = "Nombres";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(263, 140);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(122, 20);
            this.tbApellidos.TabIndex = 15;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(263, 115);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(72, 20);
            this.lblApellidos.TabIndex = 14;
            this.lblApellidos.Text = "Apellidos";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(394, 140);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(105, 20);
            this.tbCelular.TabIndex = 17;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(394, 115);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(55, 20);
            this.lblCelular.TabIndex = 16;
            this.lblCelular.Text = "Celular";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(10, 197);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(243, 20);
            this.tbCorreo.TabIndex = 19;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(10, 172);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(54, 20);
            this.lblCorreo.TabIndex = 18;
            this.lblCorreo.Text = "Correo";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(263, 197);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(236, 20);
            this.tbDireccion.TabIndex = 21;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(263, 172);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(72, 20);
            this.LblDireccion.TabIndex = 20;
            this.LblDireccion.Text = "Direccion";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(10, 224);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(53, 20);
            this.lblPuesto.TabIndex = 22;
            this.lblPuesto.Text = "Puesto";
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Location = new System.Drawing.Point(112, 224);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(104, 21);
            this.cbPuesto.TabIndex = 23;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(394, 225);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(104, 21);
            this.cbSexo.TabIndex = 25;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(292, 225);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 20);
            this.lblSexo.TabIndex = 24;
            this.lblSexo.Text = "Sexo";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(112, 273);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(104, 21);
            this.cbEstado.TabIndex = 27;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(10, 273);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 20);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(537, 137);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 23);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(537, 194);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(71, 23);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(537, 222);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 23);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(537, 270);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 23);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // DGInfoEmpleado
            // 
            this.DGInfoEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.DGInfoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInfoEmpleado.Location = new System.Drawing.Point(3, 307);
            this.DGInfoEmpleado.Name = "DGInfoEmpleado";
            this.DGInfoEmpleado.Size = new System.Drawing.Size(626, 256);
            this.DGInfoEmpleado.TabIndex = 33;
            // 
            // InfoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 563);
            this.Controls.Add(this.DGInfoEmpleado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.lblNOmbres);
            this.Controls.Add(this.tbIdentidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTItuloEmpleado);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoEmpleado";
            this.Text = "InfoEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGInfoEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox btnClose;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label lblTItuloEmpleado;
        private Label label1;
        private TextBox tbIdentidad;
        private TextBox tbNombres;
        private Label lblNOmbres;
        private TextBox tbApellidos;
        private Label lblApellidos;
        private TextBox tbCelular;
        private Label lblCelular;
        private TextBox tbCorreo;
        private Label lblCorreo;
        private TextBox tbDireccion;
        private Label LblDireccion;
        private Label lblPuesto;
        private ComboBox cbPuesto;
        private ComboBox cbSexo;
        private Label lblSexo;
        private ComboBox cbEstado;
        private Label lblEstado;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private DataGridView DGInfoEmpleado;
    }
}