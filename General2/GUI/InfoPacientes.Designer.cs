using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace General2.GUI
{
    partial class InfoPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoPacientes));
            this.DGInfoPaciente = new System.Windows.Forms.DataGridView();
            this.btnHistorialConsulta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.lblNOmbres = new System.Windows.Forms.Label();
            this.tbIdentidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTItuloEmpleado = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnHistorialClinico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGInfoPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGInfoPaciente
            // 
            this.DGInfoPaciente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.DGInfoPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInfoPaciente.Location = new System.Drawing.Point(2, 304);
            this.DGInfoPaciente.Name = "DGInfoPaciente";
            this.DGInfoPaciente.Size = new System.Drawing.Size(626, 256);
            this.DGInfoPaciente.TabIndex = 87;
            // 
            // btnHistorialConsulta
            // 
            this.btnHistorialConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnHistorialConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistorialConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialConsulta.FlatAppearance.BorderSize = 0;
            this.btnHistorialConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialConsulta.Location = new System.Drawing.Point(315, 276);
            this.btnHistorialConsulta.Name = "btnHistorialConsulta";
            this.btnHistorialConsulta.Size = new System.Drawing.Size(143, 23);
            this.btnHistorialConsulta.TabIndex = 86;
            this.btnHistorialConsulta.Text = "Historial Consulta ";
            this.btnHistorialConsulta.UseVisualStyleBackColor = false;
            this.btnHistorialConsulta.Click += new System.EventHandler(this.btnHistorialConsulta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(536, 219);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 23);
            this.btnEliminar.TabIndex = 85;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(536, 192);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(71, 23);
            this.btnModificar.TabIndex = 84;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(536, 134);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 23);
            this.btnAgregar.TabIndex = 83;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(393, 248);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(104, 21);
            this.cbEstado.TabIndex = 82;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(291, 250);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 20);
            this.lblEstado.TabIndex = 81;
            this.lblEstado.Text = "Estado";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(393, 223);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(104, 21);
            this.cbSexo.TabIndex = 80;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(291, 223);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 20);
            this.lblSexo.TabIndex = 79;
            this.lblSexo.Text = "Sexo";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(9, 222);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(149, 20);
            this.lblFechaNacimiento.TabIndex = 77;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(262, 194);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(236, 20);
            this.tbDireccion.TabIndex = 76;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(262, 170);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(72, 20);
            this.LblDireccion.TabIndex = 75;
            this.LblDireccion.Text = "Direccion";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(9, 194);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(243, 20);
            this.tbCorreo.TabIndex = 74;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(9, 170);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(54, 20);
            this.lblCorreo.TabIndex = 73;
            this.lblCorreo.Text = "Correo";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(393, 137);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(105, 20);
            this.tbCelular.TabIndex = 72;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(393, 113);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(55, 20);
            this.lblCelular.TabIndex = 71;
            this.lblCelular.Text = "Celular";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(262, 137);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(122, 20);
            this.tbApellidos.TabIndex = 70;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(262, 113);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(72, 20);
            this.lblApellidos.TabIndex = 69;
            this.lblApellidos.Text = "Apellidos";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(129, 137);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(124, 20);
            this.tbNombres.TabIndex = 68;
            // 
            // lblNOmbres
            // 
            this.lblNOmbres.AutoSize = true;
            this.lblNOmbres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOmbres.Location = new System.Drawing.Point(129, 113);
            this.lblNOmbres.Name = "lblNOmbres";
            this.lblNOmbres.Size = new System.Drawing.Size(70, 20);
            this.lblNOmbres.TabIndex = 67;
            this.lblNOmbres.Text = "Nombres";
            // 
            // tbIdentidad
            // 
            this.tbIdentidad.Location = new System.Drawing.Point(9, 137);
            this.tbIdentidad.Name = "tbIdentidad";
            this.tbIdentidad.Size = new System.Drawing.Size(115, 20);
            this.tbIdentidad.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Identidad";
            // 
            // lblTItuloEmpleado
            // 
            this.lblTItuloEmpleado.AutoSize = true;
            this.lblTItuloEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItuloEmpleado.Location = new System.Drawing.Point(262, 61);
            this.lblTItuloEmpleado.Name = "lblTItuloEmpleado";
            this.lblTItuloEmpleado.Size = new System.Drawing.Size(278, 32);
            this.lblTItuloEmpleado.TabIndex = 64;
            this.lblTItuloEmpleado.Text = "Información del Paciente";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(183, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 63;
            this.pictureBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(600, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 62;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox1.Location = new System.Drawing.Point(-141, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 30);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 88;
            // 
            // btnHistorialClinico
            // 
            this.btnHistorialClinico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnHistorialClinico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistorialClinico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialClinico.FlatAppearance.BorderSize = 0;
            this.btnHistorialClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialClinico.Location = new System.Drawing.Point(464, 276);
            this.btnHistorialClinico.Name = "btnHistorialClinico";
            this.btnHistorialClinico.Size = new System.Drawing.Size(143, 23);
            this.btnHistorialClinico.TabIndex = 89;
            this.btnHistorialClinico.Text = "Historial Clinico";
            this.btnHistorialClinico.UseVisualStyleBackColor = false;
            this.btnHistorialClinico.Click += new System.EventHandler(this.btnHistorialClinico_Click);
            // 
            // InfoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 563);
            this.Controls.Add(this.btnHistorialClinico);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DGInfoPaciente);
            this.Controls.Add(this.btnHistorialConsulta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblFechaNacimiento);
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
            this.Name = "InfoPacientes";
            this.Text = "InfoPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.DGInfoPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DGInfoPaciente;
        private Button btnHistorialConsulta;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox cbEstado;
        private Label lblEstado;
        private ComboBox cbSexo;
        private Label lblSexo;
        private Label lblFechaNacimiento;
        private TextBox tbDireccion;
        private Label LblDireccion;
        private TextBox tbCorreo;
        private Label lblCorreo;
        private TextBox tbCelular;
        private Label lblCelular;
        private TextBox tbApellidos;
        private Label lblApellidos;
        private TextBox tbNombres;
        private Label lblNOmbres;
        private TextBox tbIdentidad;
        private Label label1;
        private Label lblTItuloEmpleado;
        private PictureBox pictureBox4;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnHistorialClinico;
    }
}