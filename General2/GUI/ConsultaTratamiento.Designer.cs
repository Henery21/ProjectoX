using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace General2.GUI
{
    partial class ConsultaTratamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaTratamiento));
            this.DGConsultaTratamiento = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbConsulta = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.lblTItuloCtratamiento = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.cbTratamiento = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGConsultaTratamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGConsultaTratamiento
            // 
            this.DGConsultaTratamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.DGConsultaTratamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGConsultaTratamiento.Location = new System.Drawing.Point(3, 260);
            this.DGConsultaTratamiento.Name = "DGConsultaTratamiento";
            this.DGConsultaTratamiento.Size = new System.Drawing.Size(626, 302);
            this.DGConsultaTratamiento.TabIndex = 156;
            this.DGConsultaTratamiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGConsultaTratamiento_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(263, 220);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 23);
            this.btnBuscar.TabIndex = 155;
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
            this.btnEliminar.Location = new System.Drawing.Point(537, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 23);
            this.btnEliminar.TabIndex = 154;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(537, 166);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(71, 23);
            this.btnModificar.TabIndex = 153;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnAgregar.TabIndex = 152;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbConsulta
            // 
            this.tbConsulta.Location = new System.Drawing.Point(135, 140);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.Size = new System.Drawing.Size(112, 20);
            this.tbConsulta.TabIndex = 147;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(135, 115);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(66, 20);
            this.lblConsulta.TabIndex = 146;
            this.lblConsulta.Text = "Consulta";
            // 
            // lblTItuloCtratamiento
            // 
            this.lblTItuloCtratamiento.AutoSize = true;
            this.lblTItuloCtratamiento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItuloCtratamiento.Location = new System.Drawing.Point(263, 63);
            this.lblTItuloCtratamiento.Name = "lblTItuloCtratamiento";
            this.lblTItuloCtratamiento.Size = new System.Drawing.Size(241, 32);
            this.lblTItuloCtratamiento.TabIndex = 145;
            this.lblTItuloCtratamiento.Text = "Consulta Tratamiento";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(184, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 144;
            this.pictureBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(600, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 143;
            this.btnClose.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox1.Location = new System.Drawing.Point(-141, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 30);
            this.pictureBox1.TabIndex = 142;
            this.pictureBox1.TabStop = false;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.Location = new System.Drawing.Point(10, 115);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(89, 20);
            this.lblTratamiento.TabIndex = 150;
            this.lblTratamiento.Text = "Tratamiento";
            // 
            // cbTratamiento
            // 
            this.cbTratamiento.FormattingEnabled = true;
            this.cbTratamiento.Location = new System.Drawing.Point(10, 140);
            this.cbTratamiento.Name = "cbTratamiento";
            this.cbTratamiento.Size = new System.Drawing.Size(112, 21);
            this.cbTratamiento.TabIndex = 151;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(263, 140);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(112, 21);
            this.cbEstado.TabIndex = 158;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(263, 115);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 20);
            this.lblEstado.TabIndex = 157;
            this.lblEstado.Text = "Estado";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(14, 222);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(233, 20);
            this.tbBuscar.TabIndex = 159;
            // 
            // ConsultaTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(630, 563);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.DGConsultaTratamiento);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbTratamiento);
            this.Controls.Add(this.lblTratamiento);
            this.Controls.Add(this.tbConsulta);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lblTItuloCtratamiento);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaTratamiento";
            this.Text = "ConsultaTratamiento";
            this.Load += new System.EventHandler(this.ConsultaTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGConsultaTratamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView DGConsultaTratamiento;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox tbConsulta;
        private Label lblConsulta;
        private Label lblTItuloCtratamiento;
        private PictureBox pictureBox4;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
        private Label lblTratamiento;
        private ComboBox cbTratamiento;
        private ComboBox cbEstado;
        private Label lblEstado;
        private TextBox tbBuscar;
    }
}