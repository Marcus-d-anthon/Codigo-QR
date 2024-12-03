namespace Codigo_QR
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
            ptbCodigoQR = new PictureBox();
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            btnGenerar = new Button();
            txtTextoQR = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            GuardarArchivos = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)ptbCodigoQR).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ptbCodigoQR
            // 
            ptbCodigoQR.BorderStyle = BorderStyle.FixedSingle;
            ptbCodigoQR.Location = new Point(70, 219);
            ptbCodigoQR.Name = "ptbCodigoQR";
            ptbCodigoQR.Size = new Size(200, 200);
            ptbCodigoQR.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbCodigoQR.TabIndex = 0;
            ptbCodigoQR.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnGenerar);
            groupBox1.Controls.Add(txtTextoQR);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ptbCodigoQR);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(57, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 455);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Convertor de Texto a QR";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(210, 172);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 28);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(50, 172);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(86, 28);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtTextoQR
            // 
            txtTextoQR.Location = new Point(70, 128);
            txtTextoQR.Name = "txtTextoQR";
            txtTextoQR.Size = new Size(205, 25);
            txtTextoQR.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(50, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 25);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(23, 104);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 2;
            label3.Text = "Ingrese su Texto:";
            // 
            // label2
            // 
            label2.Location = new Point(23, 39);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su Nombre:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 30);
            label1.Name = "label1";
            label1.Size = new Size(308, 33);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Conversion Texto a QR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 554);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convertor de Texto a QR";
            ((System.ComponentModel.ISupportInitialize)ptbCodigoQR).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbCodigoQR;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnGuardar;
        private Button btnGenerar;
        private TextBox txtTextoQR;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private SaveFileDialog GuardarArchivos;
    }
}
