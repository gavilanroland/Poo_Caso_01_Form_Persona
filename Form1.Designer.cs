namespace _01_Caso_practico_Persona
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            btnAlta = new Button();
            btnBaja = new Button();
            btnModificacion = new Button();
            dgvPersonas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(47, 40);
            label1.Name = "label1";
            label1.Size = new Size(238, 32);
            label1.TabIndex = 0;
            label1.Text = "Formulario Persona";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 125);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 181);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 235);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(155, 178);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(171, 27);
            txtApellido.TabIndex = 5;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(155, 232);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(171, 27);
            txtDNI.TabIndex = 6;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(60, 344);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(160, 34);
            btnAlta.TabIndex = 7;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(278, 344);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(160, 34);
            btnBaja.TabIndex = 8;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificacion
            // 
            btnModificacion.Location = new Point(491, 344);
            btnModificacion.Name = "btnModificacion";
            btnModificacion.Size = new Size(160, 34);
            btnModificacion.TabIndex = 9;
            btnModificacion.Text = "Modificar";
            btnModificacion.UseVisualStyleBackColor = true;
            btnModificacion.Click += btnModificacion_Click;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(351, 122);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.Size = new Size(405, 137);
            dgvPersonas.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPersonas);
            Controls.Add(btnModificacion);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Button btnAlta;
        private Button btnBaja;
        private Button btnModificacion;
        private DataGridView dgvPersonas;
    }
}
