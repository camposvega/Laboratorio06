using System.ComponentModel;

namespace Labooratorio09
{
    partial class Estudiante
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbCarnet = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbCarnet = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.Controls.Add(this.tbEdad, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbCarnet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbApellido, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbApellido, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbCarnet, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbEdad, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbNombre, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 363);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbEdad
            // 
            this.tbEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEdad.Location = new System.Drawing.Point(189, 240);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(229, 23);
            this.tbEdad.TabIndex = 8;
            // 
            // tbCarnet
            // 
            this.tbCarnet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCarnet.Location = new System.Drawing.Point(189, 168);
            this.tbCarnet.Name = "tbCarnet";
            this.tbCarnet.Size = new System.Drawing.Size(229, 23);
            this.tbCarnet.TabIndex = 7;
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellido.Location = new System.Drawing.Point(189, 96);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(229, 23);
            this.tbApellido.TabIndex = 6;
            // 
            // lbNombre
            // 
            this.lbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNombre.Location = new System.Drawing.Point(3, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(141, 72);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbApellido
            // 
            this.lbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbApellido.Location = new System.Drawing.Point(3, 72);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(141, 72);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellido";
            this.lbApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCarnet
            // 
            this.lbCarnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCarnet.Location = new System.Drawing.Point(3, 144);
            this.lbCarnet.Name = "lbCarnet";
            this.lbCarnet.Size = new System.Drawing.Size(141, 72);
            this.lbCarnet.TabIndex = 2;
            this.lbCarnet.Text = "Carnet";
            this.lbCarnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEdad
            // 
            this.lbEdad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEdad.Location = new System.Drawing.Point(3, 216);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(141, 72);
            this.lbEdad.TabIndex = 3;
            this.lbEdad.Text = "Edad";
            this.lbEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Location = new System.Drawing.Point(189, 24);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(229, 23);
            this.tbNombre.TabIndex = 5;
            // 
            // Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Estudiante";
            this.Size = new System.Drawing.Size(461, 363);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbCarnet;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbCarnet;
    }
}