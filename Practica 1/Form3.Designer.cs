
namespace Practica_1
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_agregar_2 = new System.Windows.Forms.Button();
            this.tbx_apellido_2 = new System.Windows.Forms.TextBox();
            this.tbx_nombre_2 = new System.Windows.Forms.TextBox();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_borrar_2 = new System.Windows.Forms.Button();
            this.lb_nombres_2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_agregar_2);
            this.groupBox1.Controls.Add(this.tbx_apellido_2);
            this.groupBox1.Controls.Add(this.tbx_nombre_2);
            this.groupBox1.Controls.Add(this.lb_apellido);
            this.groupBox1.Controls.Add(this.lb_nombre);
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Datos";
            // 
            // btn_agregar_2
            // 
            this.btn_agregar_2.Location = new System.Drawing.Point(98, 222);
            this.btn_agregar_2.Name = "btn_agregar_2";
            this.btn_agregar_2.Size = new System.Drawing.Size(95, 49);
            this.btn_agregar_2.TabIndex = 4;
            this.btn_agregar_2.Text = "Agregar";
            this.btn_agregar_2.UseVisualStyleBackColor = true;
            this.btn_agregar_2.Click += new System.EventHandler(this.btn_agregar);
            // 
            // tbx_apellido_2
            // 
            this.tbx_apellido_2.Location = new System.Drawing.Point(66, 162);
            this.tbx_apellido_2.Name = "tbx_apellido_2";
            this.tbx_apellido_2.Size = new System.Drawing.Size(166, 20);
            this.tbx_apellido_2.TabIndex = 3;
            // 
            // tbx_nombre_2
            // 
            this.tbx_nombre_2.Location = new System.Drawing.Point(66, 119);
            this.tbx_nombre_2.Name = "tbx_nombre_2";
            this.tbx_nombre_2.Size = new System.Drawing.Size(166, 20);
            this.tbx_nombre_2.TabIndex = 2;
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Location = new System.Drawing.Point(16, 162);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(44, 13);
            this.lb_apellido.TabIndex = 1;
            this.lb_apellido.Text = "Apellido";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(16, 122);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(44, 13);
            this.lb_nombre.TabIndex = 0;
            this.lb_nombre.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_borrar_2);
            this.groupBox2.Controls.Add(this.lb_nombres_2);
            this.groupBox2.Location = new System.Drawing.Point(385, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 398);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elementos";
            // 
            // btn_borrar_2
            // 
            this.btn_borrar_2.Location = new System.Drawing.Point(150, 334);
            this.btn_borrar_2.Name = "btn_borrar_2";
            this.btn_borrar_2.Size = new System.Drawing.Size(95, 49);
            this.btn_borrar_2.TabIndex = 5;
            this.btn_borrar_2.Text = "Borrar";
            this.btn_borrar_2.UseVisualStyleBackColor = true;
            this.btn_borrar_2.Click += new System.EventHandler(this.btn_borrar);
            // 
            // lb_nombres_2
            // 
            this.lb_nombres_2.FormattingEnabled = true;
            this.lb_nombres_2.Location = new System.Drawing.Point(73, 36);
            this.lb_nombres_2.Name = "lb_nombres_2";
            this.lb_nombres_2.Size = new System.Drawing.Size(253, 277);
            this.lb_nombres_2.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Ejercicio 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Button btn_agregar_2;
        private System.Windows.Forms.TextBox tbx_apellido_2;
        private System.Windows.Forms.TextBox tbx_nombre_2;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lb_nombres_2;
        private System.Windows.Forms.Button btn_borrar_2;
    }
}