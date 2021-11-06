
namespace PPAI.Interfaces
{
    partial class pantallaRegistrarVentaEntradas2
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_sede = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.num_cant_entradas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_cant_entradas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(114, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(563, 33);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Sistema de Gestion de Museo Pictorico";
            // 
            // btn_continuar
            // 
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.Location = new System.Drawing.Point(590, 381);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(110, 42);
            this.btn_continuar.TabIndex = 16;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(73, 381);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 42);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_sede
            // 
            this.lbl_sede.AutoSize = true;
            this.lbl_sede.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sede.Location = new System.Drawing.Point(67, 129);
            this.lbl_sede.Name = "lbl_sede";
            this.lbl_sede.Size = new System.Drawing.Size(251, 31);
            this.lbl_sede.TabIndex = 17;
            this.lbl_sede.Text = "Duracion Estimada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cantidad de Entradas:";
            // 
            // txt_duracion
            // 
            this.txt_duracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duracion.Location = new System.Drawing.Point(368, 124);
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.ReadOnly = true;
            this.txt_duracion.Size = new System.Drawing.Size(100, 44);
            this.txt_duracion.TabIndex = 19;
            // 
            // num_cant_entradas
            // 
            this.num_cant_entradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_cant_entradas.Location = new System.Drawing.Point(368, 248);
            this.num_cant_entradas.Name = "num_cant_entradas";
            this.num_cant_entradas.Size = new System.Drawing.Size(100, 44);
            this.num_cant_entradas.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "min.";
            // 
            // pantallaRegistrarVentaEntradas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_cant_entradas);
            this.Controls.Add(this.txt_duracion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_sede);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "pantallaRegistrarVentaEntradas2";
            this.Text = "pantallaRegistrarVentaEntradas2";
            ((System.ComponentModel.ISupportInitialize)(this.num_cant_entradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_sede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.NumericUpDown num_cant_entradas;
        private System.Windows.Forms.Label label2;
    }
}