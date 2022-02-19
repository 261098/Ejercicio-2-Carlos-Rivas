namespace Ejercicio_n2_Carlos_Rivas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ingresar = new System.Windows.Forms.Button();
            this.LBestudiantes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Salir_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(219, 90);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 23);
            this.textNombre.TabIndex = 0;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(219, 138);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(100, 23);
            this.textEdad.TabIndex = 1;
            this.textEdad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(219, 192);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(100, 23);
            this.Ingresar.TabIndex = 4;
            this.Ingresar.Text = "Ingresar Datos";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // LBestudiantes
            // 
            this.LBestudiantes.FormattingEnabled = true;
            this.LBestudiantes.ItemHeight = 15;
            this.LBestudiantes.Location = new System.Drawing.Point(369, 90);
            this.LBestudiantes.Name = "LBestudiantes";
            this.LBestudiantes.Size = new System.Drawing.Size(198, 184);
            this.LBestudiantes.TabIndex = 5;
            this.LBestudiantes.SelectedIndexChanged += new System.EventHandler(this.LBestudiantes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(292, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de Estudiantes";
            // 
            // Salir_button
            // 
            this.Salir_button.Location = new System.Drawing.Point(219, 288);
            this.Salir_button.Name = "Salir_button";
            this.Salir_button.Size = new System.Drawing.Size(75, 23);
            this.Salir_button.TabIndex = 7;
            this.Salir_button.Text = "Salir";
            this.Salir_button.UseVisualStyleBackColor = true;
            this.Salir_button.Click += new System.EventHandler(this.Salir_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBestudiantes);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textNombre;
        private TextBox textEdad;
        private Label label1;
        private Label label2;
        private Button Ingresar;
        private ListBox LBestudiantes;
        private Label label3;
        private Button Salir_button;
    }
}