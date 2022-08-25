
namespace PROYECTO_FINAL_BD
{
    partial class FrmPuertos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuertos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNombrePuerto = new System.Windows.Forms.ComboBox();
            this.txtCodViaje = new System.Windows.Forms.TextBox();
            this.lblCodViaje = new System.Windows.Forms.Label();
            this.txtCodDestino = new System.Windows.Forms.TextBox();
            this.lblCodDestino = new System.Windows.Forms.Label();
            this.txtCodBuque = new System.Windows.Forms.TextBox();
            this.lblCodBuque = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblNombrePuerto = new System.Windows.Forms.Label();
            this.txtCodPuerto = new System.Windows.Forms.TextBox();
            this.lblCodPuerto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPuertosSalida = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuertosSalida)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.cmbNombrePuerto);
            this.groupBox2.Controls.Add(this.txtCodViaje);
            this.groupBox2.Controls.Add(this.lblCodViaje);
            this.groupBox2.Controls.Add(this.txtCodDestino);
            this.groupBox2.Controls.Add(this.lblCodDestino);
            this.groupBox2.Controls.Add(this.txtCodBuque);
            this.groupBox2.Controls.Add(this.lblCodBuque);
            this.groupBox2.Controls.Add(this.txtPais);
            this.groupBox2.Controls.Add(this.lblPais);
            this.groupBox2.Controls.Add(this.lblNombrePuerto);
            this.groupBox2.Controls.Add(this.txtCodPuerto);
            this.groupBox2.Controls.Add(this.lblCodPuerto);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 303);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso de Datos";
            // 
            // cmbNombrePuerto
            // 
            this.cmbNombrePuerto.FormattingEnabled = true;
            this.cmbNombrePuerto.Items.AddRange(new object[] {
            "Puerto de Valencia",
            "Puerto Cortés",
            "Puerto de Hong Kong"});
            this.cmbNombrePuerto.Location = new System.Drawing.Point(117, 70);
            this.cmbNombrePuerto.Name = "cmbNombrePuerto";
            this.cmbNombrePuerto.Size = new System.Drawing.Size(100, 21);
            this.cmbNombrePuerto.TabIndex = 2;
            // 
            // txtCodViaje
            // 
            this.txtCodViaje.Location = new System.Drawing.Point(117, 223);
            this.txtCodViaje.Name = "txtCodViaje";
            this.txtCodViaje.Size = new System.Drawing.Size(100, 20);
            this.txtCodViaje.TabIndex = 6;
            // 
            // lblCodViaje
            // 
            this.lblCodViaje.AutoSize = true;
            this.lblCodViaje.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodViaje.Location = new System.Drawing.Point(13, 226);
            this.lblCodViaje.Name = "lblCodViaje";
            this.lblCodViaje.Size = new System.Drawing.Size(69, 13);
            this.lblCodViaje.TabIndex = 6;
            this.lblCodViaje.Text = "Código Viaje:";
            // 
            // txtCodDestino
            // 
            this.txtCodDestino.Location = new System.Drawing.Point(117, 183);
            this.txtCodDestino.Name = "txtCodDestino";
            this.txtCodDestino.Size = new System.Drawing.Size(100, 20);
            this.txtCodDestino.TabIndex = 5;
            // 
            // lblCodDestino
            // 
            this.lblCodDestino.AutoSize = true;
            this.lblCodDestino.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodDestino.Location = new System.Drawing.Point(13, 186);
            this.lblCodDestino.Name = "lblCodDestino";
            this.lblCodDestino.Size = new System.Drawing.Size(82, 13);
            this.lblCodDestino.TabIndex = 6;
            this.lblCodDestino.Text = "Código Destino:";
            // 
            // txtCodBuque
            // 
            this.txtCodBuque.Location = new System.Drawing.Point(117, 145);
            this.txtCodBuque.Name = "txtCodBuque";
            this.txtCodBuque.Size = new System.Drawing.Size(100, 20);
            this.txtCodBuque.TabIndex = 4;
            // 
            // lblCodBuque
            // 
            this.lblCodBuque.AutoSize = true;
            this.lblCodBuque.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodBuque.Location = new System.Drawing.Point(13, 148);
            this.lblCodBuque.Name = "lblCodBuque";
            this.lblCodBuque.Size = new System.Drawing.Size(77, 13);
            this.lblCodBuque.TabIndex = 6;
            this.lblCodBuque.Text = "Código Buque:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(117, 109);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPais.Location = new System.Drawing.Point(13, 112);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 6;
            this.lblPais.Text = "Pais:";
            // 
            // lblNombrePuerto
            // 
            this.lblNombrePuerto.AutoSize = true;
            this.lblNombrePuerto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombrePuerto.Location = new System.Drawing.Point(13, 73);
            this.lblNombrePuerto.Name = "lblNombrePuerto";
            this.lblNombrePuerto.Size = new System.Drawing.Size(98, 13);
            this.lblNombrePuerto.TabIndex = 6;
            this.lblNombrePuerto.Text = "Nombre del Puerto:";
            this.lblNombrePuerto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCodPuerto
            // 
            this.txtCodPuerto.Enabled = false;
            this.txtCodPuerto.Location = new System.Drawing.Point(117, 31);
            this.txtCodPuerto.Name = "txtCodPuerto";
            this.txtCodPuerto.Size = new System.Drawing.Size(100, 20);
            this.txtCodPuerto.TabIndex = 1;
            // 
            // lblCodPuerto
            // 
            this.lblCodPuerto.AutoSize = true;
            this.lblCodPuerto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodPuerto.Location = new System.Drawing.Point(13, 34);
            this.lblCodPuerto.Name = "lblCodPuerto";
            this.lblCodPuerto.Size = new System.Drawing.Size(77, 13);
            this.lblCodPuerto.TabIndex = 4;
            this.lblCodPuerto.Text = "Código Puerto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(316, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "S A L I D A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "P U E R T O S  D E  ";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegresar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(673, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 49);
            this.btnRegresar.TabIndex = 37;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_FINAL_BD.Properties.Resources.kisspng_logo_msc_cruises_cruise_ship_mediterranean_shippin_cruise_5b55950cba1e28_2943787715323353727624;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPuertosSalida
            // 
            this.dgvPuertosSalida.AllowUserToOrderColumns = true;
            this.dgvPuertosSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuertosSalida.Location = new System.Drawing.Point(274, 221);
            this.dgvPuertosSalida.Name = "dgvPuertosSalida";
            this.dgvPuertosSalida.Size = new System.Drawing.Size(474, 225);
            this.dgvPuertosSalida.TabIndex = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnMostrar);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(316, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 86);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Panel de Control";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(275, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 51);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(194, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 51);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(113, 19);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 51);
            this.btnMostrar.TabIndex = 25;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(29, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 51);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 22);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(760, 477);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvPuertosSalida);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPuertos";
            this.Text = "Puertos de salida";
            this.Load += new System.EventHandler(this.FrmPuertos_Load);
            this.Click += new System.EventHandler(this.FrmPuertos_Click);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuertosSalida)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbNombrePuerto;
        private System.Windows.Forms.TextBox txtCodViaje;
        private System.Windows.Forms.Label lblCodViaje;
        private System.Windows.Forms.TextBox txtCodDestino;
        private System.Windows.Forms.Label lblCodDestino;
        private System.Windows.Forms.TextBox txtCodBuque;
        private System.Windows.Forms.Label lblCodBuque;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblNombrePuerto;
        private System.Windows.Forms.TextBox txtCodPuerto;
        private System.Windows.Forms.Label lblCodPuerto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPuertosSalida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}