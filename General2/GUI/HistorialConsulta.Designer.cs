
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace General2.GUI
{
    partial class HistorialConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialConsulta));
            this.btnHistorialClinico = new System.Windows.Forms.Button();
            this.dGHistorialC = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.tbMotivoConsulta = new System.Windows.Forms.TextBox();
            this.lblMotivoConsulta = new System.Windows.Forms.Label();
            this.tbHClinico = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.lblTItuloHconsulta = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHClinico = new System.Windows.Forms.Label();
            this.tbConculta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGHistorialC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistorialClinico
            // 
            this.btnHistorialClinico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnHistorialClinico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistorialClinico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialClinico.FlatAppearance.BorderSize = 0;
            this.btnHistorialClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialClinico.Location = new System.Drawing.Point(393, 248);
            this.btnHistorialClinico.Name = "btnHistorialClinico";
            this.btnHistorialClinico.Size = new System.Drawing.Size(143, 23);
            this.btnHistorialClinico.TabIndex = 117;
            this.btnHistorialClinico.Text = "Historial Clinico";
            this.btnHistorialClinico.UseVisualStyleBackColor = false;
            // 
            // dGHistorialC
            // 
            this.dGHistorialC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.dGHistorialC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGHistorialC.Location = new System.Drawing.Point(2, 276);
            this.dGHistorialC.Name = "dGHistorialC";
            this.dGHistorialC.Size = new System.Drawing.Size(626, 285);
            this.dGHistorialC.TabIndex = 115;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(317, 248);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 23);
            this.btnBuscar.TabIndex = 114;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(536, 220);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 23);
            this.btnEliminar.TabIndex = 113;
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
            this.btnModificar.TabIndex = 112;
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
            this.btnAgregar.Location = new System.Drawing.Point(536, 135);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 23);
            this.btnAgregar.TabIndex = 111;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(393, 220);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(129, 21);
            this.cbEstado.TabIndex = 110;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(393, 194);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 20);
            this.lblEstado.TabIndex = 109;
            this.lblEstado.Text = "Estado";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(262, 220);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(129, 21);
            this.cbSexo.TabIndex = 108;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(263, 194);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 20);
            this.lblSexo.TabIndex = 107;
            this.lblSexo.Text = "Sexo";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(9, 186);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(243, 54);
            this.tbObservaciones.TabIndex = 103;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(74, 166);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(109, 20);
            this.lblObservaciones.TabIndex = 102;
            this.lblObservaciones.Text = "Observaciones ";
            // 
            // tbMotivoConsulta
            // 
            this.tbMotivoConsulta.Location = new System.Drawing.Point(262, 138);
            this.tbMotivoConsulta.Multiline = true;
            this.tbMotivoConsulta.Name = "tbMotivoConsulta";
            this.tbMotivoConsulta.Size = new System.Drawing.Size(260, 51);
            this.tbMotivoConsulta.TabIndex = 99;
            // 
            // lblMotivoConsulta
            // 
            this.lblMotivoConsulta.AutoSize = true;
            this.lblMotivoConsulta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoConsulta.Location = new System.Drawing.Point(340, 114);
            this.lblMotivoConsulta.Name = "lblMotivoConsulta";
            this.lblMotivoConsulta.Size = new System.Drawing.Size(117, 20);
            this.lblMotivoConsulta.TabIndex = 98;
            this.lblMotivoConsulta.Text = "Motivo Consulta";
            // 
            // tbHClinico
            // 
            this.tbHClinico.Location = new System.Drawing.Point(132, 138);
            this.tbHClinico.Name = "tbHClinico";
            this.tbHClinico.Size = new System.Drawing.Size(124, 20);
            this.tbHClinico.TabIndex = 97;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(9, 114);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(66, 20);
            this.lblConsulta.TabIndex = 94;
            this.lblConsulta.Text = "Consulta";
            // 
            // lblTItuloHconsulta
            // 
            this.lblTItuloHconsulta.AutoSize = true;
            this.lblTItuloHconsulta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItuloHconsulta.Location = new System.Drawing.Point(262, 62);
            this.lblTItuloHconsulta.Name = "lblTItuloHconsulta";
            this.lblTItuloHconsulta.Size = new System.Drawing.Size(201, 32);
            this.lblTItuloHconsulta.TabIndex = 93;
            this.lblTItuloHconsulta.Text = "Historial Consulta";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(183, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 92;
            this.pictureBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(600, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 91;
            this.btnClose.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox1.Location = new System.Drawing.Point(-141, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 30);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // lblHClinico
            // 
            this.lblHClinico.AutoSize = true;
            this.lblHClinico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHClinico.Location = new System.Drawing.Point(138, 114);
            this.lblHClinico.Name = "lblHClinico";
            this.lblHClinico.Size = new System.Drawing.Size(114, 20);
            this.lblHClinico.TabIndex = 118;
            this.lblHClinico.Text = "Historial Clinico";
            // 
            // tbConculta
            // 
            this.tbConculta.Location = new System.Drawing.Point(2, 138);
            this.tbConculta.Name = "tbConculta";
            this.tbConculta.Size = new System.Drawing.Size(124, 20);
            this.tbConculta.TabIndex = 119;
            // 
            // HistorialConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 563);
            this.Controls.Add(this.tbConculta);
            this.Controls.Add(this.lblHClinico);
            this.Controls.Add(this.btnHistorialClinico);
            this.Controls.Add(this.dGHistorialC);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.tbMotivoConsulta);
            this.Controls.Add(this.lblMotivoConsulta);
            this.Controls.Add(this.tbHClinico);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lblTItuloHconsulta);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialConsulta";
            this.Text = "HistorialConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.dGHistorialC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private Button btnHistorialClinico;
        private DateTimePicker dateTimePicker1;
        private DataGridView dGHistorialC;
        private Button btnBuscar;
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
        private TextBox tbObservaciones;
        private Label lblObservaciones;
        private TextBox tbMotivoConsulta;
        private Label lblMotivoConsulta;
        private TextBox tbHClinico;
        private Label lblNOmbres;
        private TextBox tbIdentidad;
        private Label lblConsulta;
        private Label lblTItuloHconsulta;
        private PictureBox pictureBox4;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
        private Label lblHClinico;
        private TextBox tbConculta;
    }
}