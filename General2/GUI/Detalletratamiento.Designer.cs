using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace General2.GUI
{
    partial class Detalletratamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalletratamiento));
            this.DGdetalleTratamiento = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbIndicaciones = new System.Windows.Forms.TextBox();
            this.lblindicaciones = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTItuloDtratamiento = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bntCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.lblDuracionTratamiento = new System.Windows.Forms.Label();
            this.tbNtratameinto = new System.Windows.Forms.TextBox();
            this.lblNTratamiento = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalleTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGdetalleTratamiento
            // 
            this.DGdetalleTratamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.DGdetalleTratamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdetalleTratamiento.Location = new System.Drawing.Point(3, 285);
            this.DGdetalleTratamiento.Name = "DGdetalleTratamiento";
            this.DGdetalleTratamiento.Size = new System.Drawing.Size(626, 277);
            this.DGdetalleTratamiento.TabIndex = 137;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(254, 257);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 23);
            this.btnBuscar.TabIndex = 136;
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
            this.btnEliminar.Location = new System.Drawing.Point(537, 222);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 23);
            this.btnEliminar.TabIndex = 135;
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
            this.btnModificar.Location = new System.Drawing.Point(537, 194);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(71, 23);
            this.btnModificar.TabIndex = 134;
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
            this.btnAgregar.Location = new System.Drawing.Point(537, 137);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 23);
            this.btnAgregar.TabIndex = 133;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(411, 197);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(104, 21);
            this.cbEstado.TabIndex = 132;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(411, 172);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 20);
            this.lblEstado.TabIndex = 131;
            this.lblEstado.Text = "Estado";
            // 
            // tbIndicaciones
            // 
            this.tbIndicaciones.Location = new System.Drawing.Point(10, 197);
            this.tbIndicaciones.Multiline = true;
            this.tbIndicaciones.Name = "tbIndicaciones";
            this.tbIndicaciones.Size = new System.Drawing.Size(397, 48);
            this.tbIndicaciones.TabIndex = 127;
            // 
            // lblindicaciones
            // 
            this.lblindicaciones.AutoSize = true;
            this.lblindicaciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblindicaciones.Location = new System.Drawing.Point(10, 172);
            this.lblindicaciones.Name = "lblindicaciones";
            this.lblindicaciones.Size = new System.Drawing.Size(95, 20);
            this.lblindicaciones.TabIndex = 126;
            this.lblindicaciones.Text = "Inidicaciones";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(411, 140);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(105, 20);
            this.tbUsuario.TabIndex = 125;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(411, 115);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 20);
            this.lblPrecio.TabIndex = 124;
            this.lblPrecio.Text = "Precio";
            // 
            // lblTItuloDtratamiento
            // 
            this.lblTItuloDtratamiento.AutoSize = true;
            this.lblTItuloDtratamiento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItuloDtratamiento.Location = new System.Drawing.Point(263, 63);
            this.lblTItuloDtratamiento.Name = "lblTItuloDtratamiento";
            this.lblTItuloDtratamiento.Size = new System.Drawing.Size(223, 32);
            this.lblTItuloDtratamiento.TabIndex = 119;
            this.lblTItuloDtratamiento.Text = "Detalle Tratamiento";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(184, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 118;
            this.pictureBox4.TabStop = false;
            // 
            // bntCerrar
            // 
            this.bntCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.bntCerrar.Image = ((System.Drawing.Image)(resources.GetObject("bntCerrar.Image")));
            this.bntCerrar.Location = new System.Drawing.Point(600, 0);
            this.bntCerrar.Name = "bntCerrar";
            this.bntCerrar.Size = new System.Drawing.Size(30, 30);
            this.bntCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntCerrar.TabIndex = 117;
            this.bntCerrar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox1.Location = new System.Drawing.Point(-141, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 30);
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Location = new System.Drawing.Point(275, 140);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(132, 20);
            this.tbIdUsuario.TabIndex = 139;
            // 
            // lblDuracionTratamiento
            // 
            this.lblDuracionTratamiento.AutoSize = true;
            this.lblDuracionTratamiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracionTratamiento.Location = new System.Drawing.Point(275, 115);
            this.lblDuracionTratamiento.Name = "lblDuracionTratamiento";
            this.lblDuracionTratamiento.Size = new System.Drawing.Size(153, 20);
            this.lblDuracionTratamiento.TabIndex = 138;
            this.lblDuracionTratamiento.Text = "Duracion Tratamiento";
            // 
            // tbNtratameinto
            // 
            this.tbNtratameinto.Location = new System.Drawing.Point(10, 140);
            this.tbNtratameinto.Name = "tbNtratameinto";
            this.tbNtratameinto.Size = new System.Drawing.Size(260, 20);
            this.tbNtratameinto.TabIndex = 141;
            // 
            // lblNTratamiento
            // 
            this.lblNTratamiento.AutoSize = true;
            this.lblNTratamiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTratamiento.Location = new System.Drawing.Point(10, 115);
            this.lblNTratamiento.Name = "lblNTratamiento";
            this.lblNTratamiento.Size = new System.Drawing.Size(141, 20);
            this.lblNTratamiento.TabIndex = 140;
            this.lblNTratamiento.Text = "Nombre tratamieno";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(14, 259);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(234, 20);
            this.tbBuscar.TabIndex = 142;
            // 
            // Detalletratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 563);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.tbNtratameinto);
            this.Controls.Add(this.lblNTratamiento);
            this.Controls.Add(this.tbIdUsuario);
            this.Controls.Add(this.lblDuracionTratamiento);
            this.Controls.Add(this.DGdetalleTratamiento);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tbIndicaciones);
            this.Controls.Add(this.lblindicaciones);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTItuloDtratamiento);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bntCerrar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detalletratamiento";
            this.Text = "Detalletratamiento";
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalleTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DGdetalleTratamiento;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox cbEstado;
        private Label lblEstado;
        private ComboBox cbTpUsuario;
        private Label lblTUsuerio;
        private TextBox tbIndicaciones;
        private Label lblindicaciones;
        private TextBox tbUsuario;
        private Label lblPrecio;
        private TextBox tbNombreCompleto;
        private Label lblNOmbreCompleto;
        private Label lblIDUSuario;
        private Label lblTItuloDtratamiento;
        private PictureBox pictureBox4;
        private PictureBox bntCerrar;
        private PictureBox pictureBox1;
        private TextBox tbIdUsuario;
        private Label lblDuracionTratamiento;
        private TextBox tbNtratameinto;
        private Label lblNTratamiento;
        private TextBox tbBuscar;
    }
}