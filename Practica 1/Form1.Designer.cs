
namespace Practica_1
{
    partial class frm_menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ejerc1 = new System.Windows.Forms.Button();
            this.btn_ejerc2 = new System.Windows.Forms.Button();
            this.btn_ejerc3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ejerc1
            // 
            this.btn_ejerc1.Location = new System.Drawing.Point(54, 69);
            this.btn_ejerc1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ejerc1.Name = "btn_ejerc1";
            this.btn_ejerc1.Size = new System.Drawing.Size(115, 28);
            this.btn_ejerc1.TabIndex = 0;
            this.btn_ejerc1.Text = "Ejercicio 1";
            this.btn_ejerc1.UseVisualStyleBackColor = true;
            this.btn_ejerc1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ejerc2
            // 
            this.btn_ejerc2.Location = new System.Drawing.Point(234, 69);
            this.btn_ejerc2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ejerc2.Name = "btn_ejerc2";
            this.btn_ejerc2.Size = new System.Drawing.Size(115, 28);
            this.btn_ejerc2.TabIndex = 1;
            this.btn_ejerc2.Text = "Ejercicio 2";
            this.btn_ejerc2.UseVisualStyleBackColor = true;
            this.btn_ejerc2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ejerc3
            // 
            this.btn_ejerc3.Location = new System.Drawing.Point(400, 69);
            this.btn_ejerc3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ejerc3.Name = "btn_ejerc3";
            this.btn_ejerc3.Size = new System.Drawing.Size(115, 28);
            this.btn_ejerc3.TabIndex = 2;
            this.btn_ejerc3.Text = "Ejercicio 3";
            this.btn_ejerc3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Integrantes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ejerc3);
            this.Controls.Add(this.btn_ejerc2);
            this.Controls.Add(this.btn_ejerc1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ejerc1;
        private System.Windows.Forms.Button btn_ejerc2;
        private System.Windows.Forms.Button btn_ejerc3;
     
        private System.Windows.Forms.Label label1;
    }
}

