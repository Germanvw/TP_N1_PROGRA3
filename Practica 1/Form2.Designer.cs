
namespace Practica_1
{
    partial class Form2
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
            this.lb_1 = new System.Windows.Forms.ListBox();
            this.lb_2 = new System.Windows.Forms.ListBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_agregar1 = new System.Windows.Forms.Button();
            this.btn_agregartodos = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.FormattingEnabled = true;
            this.lb_1.ItemHeight = 16;
            this.lb_1.Location = new System.Drawing.Point(180, 144);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(120, 180);
            this.lb_1.TabIndex = 0;
            // 
            // lb_2
            // 
            this.lb_2.FormattingEnabled = true;
            this.lb_2.ItemHeight = 16;
            this.lb_2.Location = new System.Drawing.Point(468, 144);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(120, 180);
            this.lb_2.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(547, 49);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(114, 41);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_aceptar_MouseClick);
            // 
            // btn_agregar1
            // 
            this.btn_agregar1.Location = new System.Drawing.Point(343, 186);
            this.btn_agregar1.Name = "btn_agregar1";
            this.btn_agregar1.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar1.TabIndex = 3;
            this.btn_agregar1.Text = ">";
            this.btn_agregar1.UseVisualStyleBackColor = true;
            this.btn_agregar1.Click += new System.EventHandler(this.btn_agregar1_Click);
            // 
            // btn_agregartodos
            // 
            this.btn_agregartodos.Location = new System.Drawing.Point(343, 234);
            this.btn_agregartodos.Name = "btn_agregartodos";
            this.btn_agregartodos.Size = new System.Drawing.Size(75, 23);
            this.btn_agregartodos.TabIndex = 4;
            this.btn_agregartodos.Text = ">>";
            this.btn_agregartodos.UseVisualStyleBackColor = true;
            this.btn_agregartodos.Click += new System.EventHandler(this.btn_agregartodos_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(150, 59);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(117, 17);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "Ingrese Nombre :";
            this.lbl_nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(265, 56);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(224, 22);
            this.tbx_nombre.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_agregartodos);
            this.Controls.Add(this.btn_agregar1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Name = "Form2";
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_1;
        private System.Windows.Forms.ListBox lb_2;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_agregar1;
        private System.Windows.Forms.Button btn_agregartodos;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox tbx_nombre;
    }
}