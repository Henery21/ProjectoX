namespace SisBclinica.GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnClose = new PictureBox();
            label1 = new Label();
            btnIniciar = new Button();
            lblUser = new Label();
            pictureBox4 = new PictureBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            lblMensaje = new Label();
            pbMostrar = new PictureBox();
            pbOcultar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(122, 162, 227);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 35);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(106, 212, 221);
            pictureBox2.Location = new Point(0, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(450, 150);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(106, 212, 221);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(415, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(106, 212, 221);
            label1.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 69);
            label1.Name = "label1";
            label1.Size = new Size(245, 59);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido!";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(106, 212, 221);
            btnIniciar.BackgroundImageLayout = ImageLayout.None;
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Location = new Point(180, 386);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(157, 202);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(75, 21);
            lblUser.TabIndex = 5;
            lblUser.Text = "Usuario : ";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(248, 246, 227);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(125, 198);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(124, 228);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(220, 23);
            txtUsuario.TabIndex = 7;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(124, 305);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(220, 23);
            txtClave.TabIndex = 10;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(248, 246, 227);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(125, 275);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(157, 279);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 8;
            label2.Text = "Contraseña :";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(215, 145);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 11;
            // 
            // pbMostrar
            // 
            pbMostrar.Image = (Image)resources.GetObject("pbMostrar.Image");
            pbMostrar.Location = new Point(350, 304);
            pbMostrar.Name = "pbMostrar";
            pbMostrar.Size = new Size(25, 25);
            pbMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbMostrar.TabIndex = 13;
            pbMostrar.TabStop = false;
            pbMostrar.Click += pbMostrar_Click;
            // 
            // pbOcultar
            // 
            pbOcultar.Image = (Image)resources.GetObject("pbOcultar.Image");
            pbOcultar.Location = new Point(350, 304);
            pbOcultar.Name = "pbOcultar";
            pbOcultar.Size = new Size(25, 25);
            pbOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            pbOcultar.TabIndex = 14;
            pbOcultar.TabStop = false;
            pbOcultar.Click += pbOcultar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 246, 227);
            ClientSize = new Size(450, 450);
            Controls.Add(pbMostrar);
            Controls.Add(lblMensaje);
            Controls.Add(txtClave);
            Controls.Add(pictureBox5);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox4);
            Controls.Add(lblUser);
            Controls.Add(btnIniciar);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pbOcultar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOcultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btnClose;
        private Label label1;
        private Button btnIniciar;
        private Label lblUser;
        private PictureBox pictureBox4;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private PictureBox pictureBox5;
        private Label label2;
        private Label lblMensaje;
        private PictureBox pbMostrar;
        private PictureBox pbOcultar;
    }
}