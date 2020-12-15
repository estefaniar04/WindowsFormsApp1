namespace WindowsFormsApp1
{
    partial class numRectangulo1
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
            this.numDato1 = new System.Windows.Forms.NumericUpDown();
            this.btnAreaCuadrado = new System.Windows.Forms.Button();
            this.lblAreaCuadrado = new System.Windows.Forms.Label();
            this.numDato2 = new System.Windows.Forms.NumericUpDown();
            this.btnAreaTriangulo = new System.Windows.Forms.Button();
            this.lblAreaTriangulo = new System.Windows.Forms.Label();
            this.numCuadrado2 = new System.Windows.Forms.NumericUpDown();
            this.numDatoRectengulo = new System.Windows.Forms.NumericUpDown();
            this.lblAreaRectangulo = new System.Windows.Forms.Label();
            this.btnAreaRectangulo = new System.Windows.Forms.Button();
            this.numRectangulo2 = new System.Windows.Forms.NumericUpDown();
            this.numCubo = new System.Windows.Forms.NumericUpDown();
            this.btnAreaCubo = new System.Windows.Forms.Button();
            this.lblAreaCubo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDato1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDato2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCuadrado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDatoRectengulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRectangulo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCubo)).BeginInit();
            this.SuspendLayout();
            // 
            // numDato1
            // 
            this.numDato1.DecimalPlaces = 2;
            this.numDato1.Location = new System.Drawing.Point(12, 79);
            this.numDato1.Name = "numDato1";
            this.numDato1.Size = new System.Drawing.Size(120, 20);
            this.numDato1.TabIndex = 1;
            this.numDato1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDato1.ValueChanged += new System.EventHandler(this.numDato_ValueChanged);
            // 
            // btnAreaCuadrado
            // 
            this.btnAreaCuadrado.Location = new System.Drawing.Point(305, 128);
            this.btnAreaCuadrado.Name = "btnAreaCuadrado";
            this.btnAreaCuadrado.Size = new System.Drawing.Size(102, 49);
            this.btnAreaCuadrado.TabIndex = 2;
            this.btnAreaCuadrado.Text = "Area del Cuadrado ";
            this.btnAreaCuadrado.UseVisualStyleBackColor = true;
            this.btnAreaCuadrado.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAreaCuadrado
            // 
            this.lblAreaCuadrado.AutoSize = true;
            this.lblAreaCuadrado.Location = new System.Drawing.Point(426, 128);
            this.lblAreaCuadrado.Name = "lblAreaCuadrado";
            this.lblAreaCuadrado.Size = new System.Drawing.Size(10, 13);
            this.lblAreaCuadrado.TabIndex = 3;
            this.lblAreaCuadrado.Text = ".";
            // 
            // numDato2
            // 
            this.numDato2.DecimalPlaces = 3;
            this.numDato2.Location = new System.Drawing.Point(147, 79);
            this.numDato2.Name = "numDato2";
            this.numDato2.Size = new System.Drawing.Size(120, 20);
            this.numDato2.TabIndex = 4;
            this.numDato2.Value = new decimal(new int[] {
            234,
            0,
            0,
            131072});
            // 
            // btnAreaTriangulo
            // 
            this.btnAreaTriangulo.Location = new System.Drawing.Point(305, 64);
            this.btnAreaTriangulo.Name = "btnAreaTriangulo";
            this.btnAreaTriangulo.Size = new System.Drawing.Size(102, 45);
            this.btnAreaTriangulo.TabIndex = 5;
            this.btnAreaTriangulo.Text = "Area del Triangulo";
            this.btnAreaTriangulo.UseVisualStyleBackColor = true;
            // 
            // lblAreaTriangulo
            // 
            this.lblAreaTriangulo.AutoSize = true;
            this.lblAreaTriangulo.Location = new System.Drawing.Point(426, 79);
            this.lblAreaTriangulo.Name = "lblAreaTriangulo";
            this.lblAreaTriangulo.Size = new System.Drawing.Size(10, 13);
            this.lblAreaTriangulo.TabIndex = 6;
            this.lblAreaTriangulo.Text = ".";
            // 
            // numCuadrado2
            // 
            this.numCuadrado2.Location = new System.Drawing.Point(147, 128);
            this.numCuadrado2.Name = "numCuadrado2";
            this.numCuadrado2.Size = new System.Drawing.Size(120, 20);
            this.numCuadrado2.TabIndex = 7;
            this.numCuadrado2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numDatoRectengulo
            // 
            this.numDatoRectengulo.Location = new System.Drawing.Point(12, 213);
            this.numDatoRectengulo.Name = "numDatoRectengulo";
            this.numDatoRectengulo.Size = new System.Drawing.Size(120, 20);
            this.numDatoRectengulo.TabIndex = 8;
            // 
            // lblAreaRectangulo
            // 
            this.lblAreaRectangulo.AutoSize = true;
            this.lblAreaRectangulo.Location = new System.Drawing.Point(426, 213);
            this.lblAreaRectangulo.Name = "lblAreaRectangulo";
            this.lblAreaRectangulo.Size = new System.Drawing.Size(10, 13);
            this.lblAreaRectangulo.TabIndex = 9;
            this.lblAreaRectangulo.Text = ".";
            // 
            // btnAreaRectangulo
            // 
            this.btnAreaRectangulo.Location = new System.Drawing.Point(305, 202);
            this.btnAreaRectangulo.Name = "btnAreaRectangulo";
            this.btnAreaRectangulo.Size = new System.Drawing.Size(102, 47);
            this.btnAreaRectangulo.TabIndex = 10;
            this.btnAreaRectangulo.Text = "Area del Rectabgulo";
            this.btnAreaRectangulo.UseVisualStyleBackColor = true;
            // 
            // numRectangulo2
            // 
            this.numRectangulo2.Location = new System.Drawing.Point(147, 213);
            this.numRectangulo2.Name = "numRectangulo2";
            this.numRectangulo2.Size = new System.Drawing.Size(120, 20);
            this.numRectangulo2.TabIndex = 11;
            this.numRectangulo2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numCubo
            // 
            this.numCubo.Location = new System.Drawing.Point(147, 293);
            this.numCubo.Name = "numCubo";
            this.numCubo.Size = new System.Drawing.Size(120, 20);
            this.numCubo.TabIndex = 12;
            this.numCubo.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // btnAreaCubo
            // 
            this.btnAreaCubo.Location = new System.Drawing.Point(305, 269);
            this.btnAreaCubo.Name = "btnAreaCubo";
            this.btnAreaCubo.Size = new System.Drawing.Size(102, 47);
            this.btnAreaCubo.TabIndex = 13;
            this.btnAreaCubo.Text = "Area del Cubo";
            this.btnAreaCubo.UseVisualStyleBackColor = true;
            this.btnAreaCubo.Click += new System.EventHandler(this.btnAreaCubo_Click);
            // 
            // lblAreaCubo
            // 
            this.lblAreaCubo.AutoSize = true;
            this.lblAreaCubo.Location = new System.Drawing.Point(426, 293);
            this.lblAreaCubo.Name = "lblAreaCubo";
            this.lblAreaCubo.Size = new System.Drawing.Size(10, 13);
            this.lblAreaCubo.TabIndex = 14;
            this.lblAreaCubo.Text = ".";
            // 
            // numRectangulo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAreaCubo);
            this.Controls.Add(this.btnAreaCubo);
            this.Controls.Add(this.numCubo);
            this.Controls.Add(this.numRectangulo2);
            this.Controls.Add(this.btnAreaRectangulo);
            this.Controls.Add(this.lblAreaRectangulo);
            this.Controls.Add(this.numDatoRectengulo);
            this.Controls.Add(this.numCuadrado2);
            this.Controls.Add(this.lblAreaTriangulo);
            this.Controls.Add(this.btnAreaTriangulo);
            this.Controls.Add(this.numDato2);
            this.Controls.Add(this.lblAreaCuadrado);
            this.Controls.Add(this.btnAreaCuadrado);
            this.Controls.Add(this.numDato1);
            this.Name = "numRectangulo1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDato1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDato2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCuadrado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDatoRectengulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRectangulo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCubo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDato1;
        private System.Windows.Forms.Button btnAreaCuadrado;
        private System.Windows.Forms.Label lblAreaCuadrado;
        private System.Windows.Forms.NumericUpDown numDato2;
        private System.Windows.Forms.Button btnAreaTriangulo;
        private System.Windows.Forms.Label lblAreaTriangulo;
        private System.Windows.Forms.NumericUpDown numCuadrado2;
        private System.Windows.Forms.NumericUpDown numDatoRectengulo;
        private System.Windows.Forms.Label lblAreaRectangulo;
        private System.Windows.Forms.Button btnAreaRectangulo;
        private System.Windows.Forms.NumericUpDown numRectangulo2;
        private System.Windows.Forms.NumericUpDown numCubo;
        private System.Windows.Forms.Button btnAreaCubo;
        private System.Windows.Forms.Label lblAreaCubo;
    }
}

