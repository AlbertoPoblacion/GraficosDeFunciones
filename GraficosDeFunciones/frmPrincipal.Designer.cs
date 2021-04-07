namespace GraficosDeFunciones
{
    partial class frmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdEvaluar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtXMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdDibujar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expresión:";
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(74, 33);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(175, 20);
            this.txtExpresion.TabIndex = 1;
            this.txtExpresion.Text = "10*Math.Sin(x)/x-3";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(120, 144);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(58, 20);
            this.txtX.TabIndex = 3;
            this.txtX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor de X:";
            // 
            // cmdEvaluar
            // 
            this.cmdEvaluar.Location = new System.Drawing.Point(184, 142);
            this.cmdEvaluar.Name = "cmdEvaluar";
            this.cmdEvaluar.Size = new System.Drawing.Size(75, 23);
            this.cmdEvaluar.TabIndex = 4;
            this.cmdEvaluar.Text = "&Evaluar";
            this.cmdEvaluar.UseVisualStyleBackColor = true;
            this.cmdEvaluar.Click += new System.EventHandler(this.cmdEvaluar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 213);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // txtXMin
            // 
            this.txtXMin.Location = new System.Drawing.Point(54, 7);
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.Size = new System.Drawing.Size(43, 20);
            this.txtXMin.TabIndex = 7;
            this.txtXMin.Text = "-10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X min";
            // 
            // txtXMax
            // 
            this.txtXMax.Location = new System.Drawing.Point(141, 7);
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.Size = new System.Drawing.Size(43, 20);
            this.txtXMax.TabIndex = 9;
            this.txtXMax.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X max";
            // 
            // txtYMin
            // 
            this.txtYMin.Location = new System.Drawing.Point(232, 7);
            this.txtYMin.Name = "txtYMin";
            this.txtYMin.Size = new System.Drawing.Size(43, 20);
            this.txtYMin.TabIndex = 11;
            this.txtYMin.Text = "-10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y min";
            // 
            // txtYMax
            // 
            this.txtYMax.Location = new System.Drawing.Point(324, 7);
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.Size = new System.Drawing.Size(43, 20);
            this.txtYMax.TabIndex = 13;
            this.txtYMax.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y max";
            // 
            // cmdDibujar
            // 
            this.cmdDibujar.Location = new System.Drawing.Point(255, 33);
            this.cmdDibujar.Name = "cmdDibujar";
            this.cmdDibujar.Size = new System.Drawing.Size(112, 23);
            this.cmdDibujar.TabIndex = 14;
            this.cmdDibujar.Text = "Dibujar gráfico";
            this.cmdDibujar.UseVisualStyleBackColor = true;
            this.cmdDibujar.Click += new System.EventHandler(this.cmdDibujar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 298);
            this.Controls.Add(this.cmdDibujar);
            this.Controls.Add(this.txtYMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtXMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtXMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdEvaluar);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Gráficos de funciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdEvaluar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtXMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdDibujar;
    }
}

