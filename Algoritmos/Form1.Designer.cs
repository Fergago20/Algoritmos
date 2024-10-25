namespace Algoritmos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.btmMerge = new System.Windows.Forms.Button();
            this.btmQuick = new System.Windows.Forms.Button();
            this.btmBuscar = new System.Windows.Forms.Button();
            this.lbSalida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "numero";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(125, 83);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(172, 20);
            this.tbNumero.TabIndex = 2;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(528, 95);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 4;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // btmMerge
            // 
            this.btmMerge.Location = new System.Drawing.Point(528, 137);
            this.btmMerge.Name = "btmMerge";
            this.btmMerge.Size = new System.Drawing.Size(92, 61);
            this.btmMerge.TabIndex = 5;
            this.btmMerge.Text = "Ordenar Merge";
            this.btmMerge.UseVisualStyleBackColor = true;
            this.btmMerge.Click += new System.EventHandler(this.btmMerge_Click);
            // 
            // btmQuick
            // 
            this.btmQuick.Location = new System.Drawing.Point(528, 214);
            this.btmQuick.Name = "btmQuick";
            this.btmQuick.Size = new System.Drawing.Size(92, 61);
            this.btmQuick.TabIndex = 6;
            this.btmQuick.Text = "Ordenar Quick";
            this.btmQuick.UseVisualStyleBackColor = true;
            this.btmQuick.Click += new System.EventHandler(this.btmQuick_Click);
            // 
            // btmBuscar
            // 
            this.btmBuscar.Location = new System.Drawing.Point(339, 163);
            this.btmBuscar.Name = "btmBuscar";
            this.btmBuscar.Size = new System.Drawing.Size(92, 61);
            this.btmBuscar.TabIndex = 7;
            this.btmBuscar.Text = "Buscar";
            this.btmBuscar.UseVisualStyleBackColor = true;
            this.btmBuscar.Click += new System.EventHandler(this.btmBuscar_Click);
            // 
            // lbSalida
            // 
            this.lbSalida.FormattingEnabled = true;
            this.lbSalida.Location = new System.Drawing.Point(79, 172);
            this.lbSalida.Name = "lbSalida";
            this.lbSalida.Size = new System.Drawing.Size(148, 95);
            this.lbSalida.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSalida);
            this.Controls.Add(this.btmBuscar);
            this.Controls.Add(this.btmQuick);
            this.Controls.Add(this.btmMerge);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button btmMerge;
        private System.Windows.Forms.Button btmQuick;
        private System.Windows.Forms.Button btmBuscar;
        private System.Windows.Forms.ListBox lbSalida;
    }
}

