
namespace PPAI.Interfaces
{
    partial class pantallaRegistrarVentaEntradas
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
            this.lbl_sede = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_sede = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.dgv_tarifas = new System.Windows.Forms.DataGridView();
            this.TipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.txt_monto_guia = new System.Windows.Forms.TextBox();
            this.lbl_tipo_entrada = new System.Windows.Forms.Label();
            this.lbl_tipo_visita = new System.Windows.Forms.Label();
            this.cmb_tipo_entrada = new System.Windows.Forms.ComboBox();
            this.cmb_tipo_visita = new System.Windows.Forms.ComboBox();
            this.ck_guiado = new System.Windows.Forms.CheckBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_continuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(141, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(563, 33);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Sistema de Gestion de Museo Pictorico";
            // 
            // lbl_sede
            // 
            this.lbl_sede.AutoSize = true;
            this.lbl_sede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sede.Location = new System.Drawing.Point(91, 104);
            this.lbl_sede.Name = "lbl_sede";
            this.lbl_sede.Size = new System.Drawing.Size(100, 20);
            this.lbl_sede.TabIndex = 1;
            this.lbl_sede.Text = "Sede Actual:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(448, 104);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(117, 20);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario Actual:";
            // 
            // txt_sede
            // 
            this.txt_sede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sede.Location = new System.Drawing.Point(197, 101);
            this.txt_sede.Name = "txt_sede";
            this.txt_sede.ReadOnly = true;
            this.txt_sede.Size = new System.Drawing.Size(151, 26);
            this.txt_sede.TabIndex = 3;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(571, 101);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.ReadOnly = true;
            this.txt_usuario.Size = new System.Drawing.Size(151, 26);
            this.txt_usuario.TabIndex = 4;
            // 
            // dgv_tarifas
            // 
            this.dgv_tarifas.AllowUserToAddRows = false;
            this.dgv_tarifas.AllowUserToResizeRows = false;
            this.dgv_tarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoEntrada,
            this.TipoVisita,
            this.Monto});
            this.dgv_tarifas.Location = new System.Drawing.Point(95, 205);
            this.dgv_tarifas.Name = "dgv_tarifas";
            this.dgv_tarifas.Size = new System.Drawing.Size(627, 230);
            this.dgv_tarifas.TabIndex = 5;
            // 
            // TipoEntrada
            // 
            this.TipoEntrada.HeaderText = "Tipo de Entrada";
            this.TipoEntrada.Name = "TipoEntrada";
            this.TipoEntrada.ReadOnly = true;
            // 
            // TipoVisita
            // 
            this.TipoVisita.HeaderText = "Tipo de Visita";
            this.TipoVisita.Name = "TipoVisita";
            this.TipoVisita.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(91, 161);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(96, 20);
            this.lbl_monto.TabIndex = 6;
            this.lbl_monto.Text = "Monto Guia:";
            // 
            // txt_monto_guia
            // 
            this.txt_monto_guia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_guia.Location = new System.Drawing.Point(197, 163);
            this.txt_monto_guia.Name = "txt_monto_guia";
            this.txt_monto_guia.ReadOnly = true;
            this.txt_monto_guia.Size = new System.Drawing.Size(151, 26);
            this.txt_monto_guia.TabIndex = 7;
            // 
            // lbl_tipo_entrada
            // 
            this.lbl_tipo_entrada.AutoSize = true;
            this.lbl_tipo_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_entrada.Location = new System.Drawing.Point(92, 458);
            this.lbl_tipo_entrada.Name = "lbl_tipo_entrada";
            this.lbl_tipo_entrada.Size = new System.Drawing.Size(126, 20);
            this.lbl_tipo_entrada.TabIndex = 8;
            this.lbl_tipo_entrada.Text = "Tipo de Entrada:";
            // 
            // lbl_tipo_visita
            // 
            this.lbl_tipo_visita.AutoSize = true;
            this.lbl_tipo_visita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_visita.Location = new System.Drawing.Point(380, 458);
            this.lbl_tipo_visita.Name = "lbl_tipo_visita";
            this.lbl_tipo_visita.Size = new System.Drawing.Size(108, 20);
            this.lbl_tipo_visita.TabIndex = 9;
            this.lbl_tipo_visita.Text = "Tipo de Visita:";
            // 
            // cmb_tipo_entrada
            // 
            this.cmb_tipo_entrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_entrada.FormattingEnabled = true;
            this.cmb_tipo_entrada.Location = new System.Drawing.Point(224, 455);
            this.cmb_tipo_entrada.Name = "cmb_tipo_entrada";
            this.cmb_tipo_entrada.Size = new System.Drawing.Size(121, 28);
            this.cmb_tipo_entrada.TabIndex = 10;
            // 
            // cmb_tipo_visita
            // 
            this.cmb_tipo_visita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_visita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_visita.FormattingEnabled = true;
            this.cmb_tipo_visita.Location = new System.Drawing.Point(494, 455);
            this.cmb_tipo_visita.Name = "cmb_tipo_visita";
            this.cmb_tipo_visita.Size = new System.Drawing.Size(121, 28);
            this.cmb_tipo_visita.TabIndex = 11;
            // 
            // ck_guiado
            // 
            this.ck_guiado.AutoSize = true;
            this.ck_guiado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ck_guiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_guiado.Location = new System.Drawing.Point(96, 509);
            this.ck_guiado.Name = "ck_guiado";
            this.ck_guiado.Size = new System.Drawing.Size(123, 24);
            this.ck_guiado.TabIndex = 12;
            this.ck_guiado.Text = "Visita Guiada";
            this.ck_guiado.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(95, 594);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 42);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_continuar
            // 
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.Location = new System.Drawing.Point(612, 594);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(110, 42);
            this.btn_continuar.TabIndex = 14;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = true;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // pantallaRegistrarVentaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 658);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.ck_guiado);
            this.Controls.Add(this.cmb_tipo_visita);
            this.Controls.Add(this.cmb_tipo_entrada);
            this.Controls.Add(this.lbl_tipo_visita);
            this.Controls.Add(this.lbl_tipo_entrada);
            this.Controls.Add(this.txt_monto_guia);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.dgv_tarifas);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_sede);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_sede);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "pantallaRegistrarVentaEntradas";
            this.Text = "Venta Entradas Museo";
            this.Load += new System.EventHandler(this.pantallaRegistrarVentaEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_sede;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_sede;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.DataGridView dgv_tarifas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.TextBox txt_monto_guia;
        private System.Windows.Forms.Label lbl_tipo_entrada;
        private System.Windows.Forms.Label lbl_tipo_visita;
        private System.Windows.Forms.ComboBox cmb_tipo_entrada;
        private System.Windows.Forms.ComboBox cmb_tipo_visita;
        private System.Windows.Forms.CheckBox ck_guiado;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_continuar;
    }
}