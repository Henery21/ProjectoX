using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace General2.GUI
{
    partial class InfoCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoCita));
            this.DGInfiCita = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblFCita = new System.Windows.Forms.Label();
            this.tbPaciente = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.tbIdCita = new System.Windows.Forms.TextBox();
            this.lblIdCita = new System.Windows.Forms.Label();
            this.lblTItuloInfoCita = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblHoraCita = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGInfiCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGInfiCita
            // 
            this.DGInfiCita.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.DGInfiCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInfiCita.Location = new System.Drawing.Point(3, 277);
            this.DGInfiCita.Name = "DGInfiCita";
            this.DGInfiCita.Size = new System.Drawing.Size(626, 285);
            this.DGInfiCita.TabIndex = 158;
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
            this.btnEliminar.TabIndex = 156;
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
            this.btnModificar.TabIndex = 155;
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
            this.btnAgregar.TabIndex = 154;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(263, 115);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 20);
            this.lblEstado.TabIndex = 152;
            this.lblEstado.Text = "Estado";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(10, 182);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(365, 21);
            this.tbObservaciones.TabIndex = 151;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(10, 162);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(109, 20);
            this.lblObservaciones.TabIndex = 150;
            this.lblObservaciones.Text = "Observaciones ";
            // 
            // lblFCita
            // 
            this.lblFCita.AutoSize = true;
            this.lblFCita.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCita.Location = new System.Drawing.Point(10, 210);
            this.lblFCita.Name = "lblFCita";
            this.lblFCita.Size = new System.Drawing.Size(98, 20);
            this.lblFCita.TabIndex = 148;
            this.lblFCita.Text = "Fecha de Cita";
            // 
            // tbPaciente
            // 
            this.tbPaciente.Location = new System.Drawing.Point(129, 140);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.Size = new System.Drawing.Size(112, 20);
            this.tbPaciente.TabIndex = 147;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(129, 115);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(131, 20);
            this.lblPaciente.TabIndex = 146;
            this.lblPaciente.Text = "Id Historial Clinico";
            // 
            // tbIdCita
            // 
            this.tbIdCita.Location = new System.Drawing.Point(10, 140);
            this.tbIdCita.Name = "tbIdCita";
            this.tbIdCita.Size = new System.Drawing.Size(112, 20);
            this.tbIdCita.TabIndex = 145;
            // 
            // lblIdCita
            // 
            this.lblIdCita.AutoSize = true;
            this.lblIdCita.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCita.Location = new System.Drawing.Point(10, 115);
            this.lblIdCita.Name = "lblIdCita";
            this.lblIdCita.Size = new System.Drawing.Size(52, 20);
            this.lblIdCita.TabIndex = 144;
            this.lblIdCita.Text = "Id Cita";
            // 
            // lblTItuloInfoCita
            // 
            this.lblTItuloInfoCita.AutoSize = true;
            this.lblTItuloInfoCita.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItuloInfoCita.Location = new System.Drawing.Point(263, 63);
            this.lblTItuloInfoCita.Name = "lblTItuloInfoCita";
            this.lblTItuloInfoCita.Size = new System.Drawing.Size(249, 32);
            this.lblTItuloInfoCita.TabIndex = 143;
            this.lblTItuloInfoCita.Text = "Informacion de la Cita";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(184, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 142;
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
            this.btnClose.TabIndex = 141;
            this.btnClose.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.pictureBox1.Location = new System.Drawing.Point(-141, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 30);
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(263, 139);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(112, 21);
            this.cbEstado.TabIndex = 160;
            // 
            // lblHoraCita
            // 
            this.lblHoraCita.AutoSize = true;
            this.lblHoraCita.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCita.Location = new System.Drawing.Point(273, 210);
            this.lblHoraCita.Name = "lblHoraCita";
            this.lblHoraCita.Size = new System.Drawing.Size(93, 20);
            this.lblHoraCita.TabIndex = 161;
            this.lblHoraCita.Text = "Hora de Cita";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 162;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(374, 210);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker2.TabIndex = 163;
            // 
            // InfoCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 563);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblHoraCita);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.DGInfiCita);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblFCita);
            this.Controls.Add(this.tbPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.tbIdCita);
            this.Controls.Add(this.lblIdCita);
            this.Controls.Add(this.lblTItuloInfoCita);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoCita";
            this.Text = "InfoCita";
            ((System.ComponentModel.ISupportInitialize)(this.DGInfiCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConsulta;
        private DataGridView DGInfiCita;
        private Button btnCita;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label lblEstado;
        private TextBox tbObservaciones;
        private Label lblObservaciones;
        private TextBox tbAfecciones;
        private Label lblFCita;
        private TextBox tbPaciente;
        private Label lblPaciente;
        private TextBox tbIdCita;
        private Label lblIdCita;
        private Label lblTItuloInfoCita;
        private PictureBox pictureBox4;
        private PictureBox btnClose;
        private PictureBox pictureBox1;
        private ComboBox cbEstado;
        private Label lblHoraCita;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}