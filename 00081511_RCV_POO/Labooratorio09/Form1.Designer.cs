namespace Labooratorio09
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDet = new System.Windows.Forms.Button();
            this.btnInsc = new System.Windows.Forms.Button();
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.estudiante1 = new Labooratorio09.Estudiante();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDet, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInsc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMateria, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEstudiante, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.estudiante1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 413);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDet
            // 
            this.btnDet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDet.Location = new System.Drawing.Point(321, 3);
            this.btnDet.Name = "btnDet";
            this.btnDet.Size = new System.Drawing.Size(101, 60);
            this.btnDet.TabIndex = 3;
            this.btnDet.Text = "Detalle";
            this.btnDet.UseVisualStyleBackColor = true;
            this.btnDet.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnInsc
            // 
            this.btnInsc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsc.Location = new System.Drawing.Point(215, 3);
            this.btnInsc.Name = "btnInsc";
            this.btnInsc.Size = new System.Drawing.Size(100, 60);
            this.btnInsc.TabIndex = 2;
            this.btnInsc.Text = "Inscripcion";
            this.btnInsc.UseVisualStyleBackColor = true;
            this.btnInsc.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMateria.Location = new System.Drawing.Point(109, 3);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(100, 60);
            this.btnMateria.TabIndex = 1;
            this.btnMateria.Text = "Materia";
            this.btnMateria.UseVisualStyleBackColor = true;
            this.btnMateria.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstudiante.Location = new System.Drawing.Point(3, 3);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(100, 60);
            this.btnEstudiante.TabIndex = 0;
            this.btnEstudiante.Text = "Estudiante";
            this.btnEstudiante.UseVisualStyleBackColor = true;
            this.btnEstudiante.Click += new System.EventHandler(this.button1_Click);
            // 
            // estudiante1
            // 
            this.estudiante1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.estudiante1, 4);
            this.estudiante1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.estudiante1.Location = new System.Drawing.Point(3, 69);
            this.estudiante1.Name = "estudiante1";
            this.estudiante1.Size = new System.Drawing.Size(419, 341);
            this.estudiante1.TabIndex = 4;
            this.estudiante1.Load += new System.EventHandler(this.estudiante1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(425, 413);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnDet;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnInsc;
        private System.Windows.Forms.Button btnMateria;
        private Labooratorio09.Estudiante estudiante1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}