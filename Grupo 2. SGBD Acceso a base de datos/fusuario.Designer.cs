
using System;

namespace Grupo_2._SGBD_Acceso_a_base_de_datos
{
    partial class fusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fusuario));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bprimero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.bnuevo = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.banterior = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-4, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(808, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "INGRESO DE USUARIOS AL SISTEMA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(97, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 176);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bprimero
            // 
            this.bprimero.BackColor = System.Drawing.Color.Aqua;
            this.bprimero.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bprimero.Location = new System.Drawing.Point(97, 317);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(124, 40);
            this.bprimero.TabIndex = 2;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = false;
            this.bprimero.Click += new System.EventHandler(this.bprimero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(290, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtusuario.Location = new System.Drawing.Point(431, 125);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(214, 34);
            this.txtusuario.TabIndex = 4;
            // 
            // lstnivel
            // 
            this.lstnivel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Location = new System.Drawing.Point(431, 244);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(214, 36);
            this.lstnivel.TabIndex = 5;
            this.lstnivel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(290, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(290, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nivel:";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcontraseña.Location = new System.Drawing.Point(431, 187);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(214, 34);
            this.txtcontraseña.TabIndex = 8;
            // 
            // bnuevo
            // 
            this.bnuevo.BackColor = System.Drawing.Color.Aqua;
            this.bnuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bnuevo.Location = new System.Drawing.Point(97, 363);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(124, 40);
            this.bnuevo.TabIndex = 9;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = false;
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.Aqua;
            this.bguardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bguardar.Location = new System.Drawing.Point(97, 409);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(124, 40);
            this.bguardar.TabIndex = 10;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = false;
            // 
            // banterior
            // 
            this.banterior.BackColor = System.Drawing.Color.Aqua;
            this.banterior.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.banterior.Location = new System.Drawing.Point(238, 317);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(124, 40);
            this.banterior.TabIndex = 11;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = false;
            // 
            // beliminar
            // 
            this.beliminar.BackColor = System.Drawing.Color.Aqua;
            this.beliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.beliminar.Location = new System.Drawing.Point(238, 363);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(124, 40);
            this.beliminar.TabIndex = 12;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = false;
            // 
            // bsiguiente
            // 
            this.bsiguiente.BackColor = System.Drawing.Color.Aqua;
            this.bsiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bsiguiente.Location = new System.Drawing.Point(383, 317);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(124, 40);
            this.bsiguiente.TabIndex = 13;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = false;
            // 
            // bmodificar
            // 
            this.bmodificar.BackColor = System.Drawing.Color.Aqua;
            this.bmodificar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bmodificar.Location = new System.Drawing.Point(383, 363);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(124, 40);
            this.bmodificar.TabIndex = 14;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = false;
            // 
            // bactualizar
            // 
            this.bactualizar.BackColor = System.Drawing.Color.Aqua;
            this.bactualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bactualizar.Location = new System.Drawing.Point(383, 409);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(124, 40);
            this.bactualizar.TabIndex = 15;
            this.bactualizar.Text = "Actualizar";
            this.bactualizar.UseVisualStyleBackColor = false;
            // 
            // bultimo
            // 
            this.bultimo.BackColor = System.Drawing.Color.Aqua;
            this.bultimo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bultimo.Location = new System.Drawing.Point(521, 317);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(124, 40);
            this.bultimo.TabIndex = 16;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = false;
            // 
            // bsalir
            // 
            this.bsalir.BackColor = System.Drawing.Color.Aqua;
            this.bsalir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bsalir.Location = new System.Drawing.Point(521, 363);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(124, 40);
            this.bsalir.TabIndex = 17;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = false;
            // 
            // fusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bactualizar);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bprimero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "fusuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.fusuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void fusuario_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bprimero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Button bsalir;
    }
}