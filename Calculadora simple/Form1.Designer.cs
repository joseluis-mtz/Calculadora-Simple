namespace Calculadora_simple
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDivision = new System.Windows.Forms.PictureBox();
            this.btnMultiplicacion = new System.Windows.Forms.PictureBox();
            this.btnResta = new System.Windows.Forms.PictureBox();
            this.btnSuma = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtLet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMultiplicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSuma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Controls.Add(this.txtNum2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblRes);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(234, 242);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Información";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(20, 66);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 26);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(20, 160);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 26);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número 2:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(20, 208);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(96, 20);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "Resultado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDivision);
            this.groupBox2.Controls.Add(this.btnMultiplicacion);
            this.groupBox2.Controls.Add(this.btnResta);
            this.groupBox2.Controls.Add(this.btnSuma);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(252, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(234, 242);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones Disponibles";
            // 
            // btnDivision
            // 
            this.btnDivision.Image = global::Calculadora_simple.Properties.Resources.entre;
            this.btnDivision.Location = new System.Drawing.Point(134, 126);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(50, 50);
            this.btnDivision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDivision.TabIndex = 12;
            this.btnDivision.TabStop = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            this.btnDivision.MouseLeave += new System.EventHandler(this.btnDivision_MouseLeave);
            this.btnDivision.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDivision_MouseMove);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Image = global::Calculadora_simple.Properties.Resources.por;
            this.btnMultiplicacion.Location = new System.Drawing.Point(45, 126);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(50, 50);
            this.btnMultiplicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMultiplicacion.TabIndex = 11;
            this.btnMultiplicacion.TabStop = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            this.btnMultiplicacion.MouseLeave += new System.EventHandler(this.btnMultiplicacion_MouseLeave);
            this.btnMultiplicacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMultiplicacion_MouseMove);
            // 
            // btnResta
            // 
            this.btnResta.Image = global::Calculadora_simple.Properties.Resources.menos;
            this.btnResta.Location = new System.Drawing.Point(134, 57);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(50, 50);
            this.btnResta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnResta.TabIndex = 10;
            this.btnResta.TabStop = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            this.btnResta.MouseLeave += new System.EventHandler(this.btnResta_MouseLeave);
            this.btnResta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnResta_MouseMove);
            // 
            // btnSuma
            // 
            this.btnSuma.Image = global::Calculadora_simple.Properties.Resources.mas;
            this.btnSuma.Location = new System.Drawing.Point(45, 57);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(50, 50);
            this.btnSuma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSuma.TabIndex = 9;
            this.btnSuma.TabStop = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            this.btnSuma.MouseLeave += new System.EventHandler(this.btnSuma_MouseLeave);
            this.btnSuma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSuma_MouseMove);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(396, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 36);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtLet
            // 
            this.txtLet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLet.Location = new System.Drawing.Point(124, 265);
            this.txtLet.Name = "txtLet";
            this.txtLet.Size = new System.Drawing.Size(183, 26);
            this.txtLet.TabIndex = 16;
            this.txtLet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLet_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Solo letras:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(491, 299);
            this.Controls.Add(this.txtLet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Calculadora-Simple";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMultiplicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSuma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox btnDivision;
        private System.Windows.Forms.PictureBox btnMultiplicacion;
        private System.Windows.Forms.PictureBox btnResta;
        private System.Windows.Forms.PictureBox btnSuma;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtLet;
        private System.Windows.Forms.Label label4;
    }
}

