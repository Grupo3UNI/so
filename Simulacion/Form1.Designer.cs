namespace Simulacion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbEsquema = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridPcb = new System.Windows.Forms.DataGridView();
            this.Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarProceso = new System.Windows.Forms.Button();
            this.txtBurstime = new System.Windows.Forms.TextBox();
            this.txtMemoria = new System.Windows.Forms.TextBox();
            this.txtArribo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerarProcesos = new System.Windows.Forms.Button();
            this.cbPlanificador = new System.Windows.Forms.ComboBox();
            this.txtNumProcesos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.txtQuantum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPcb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1152, 725);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.txtQuantum);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cbEsquema);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dataGridPcb);
            this.tabPage1.Controls.Add(this.btnEjecutar);
            this.tabPage1.Controls.Add(this.txtTiempo);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnReiniciar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnGenerarProcesos);
            this.tabPage1.Controls.Add(this.cbPlanificador);
            this.tabPage1.Controls.Add(this.txtNumProcesos);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1144, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Procesos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbEsquema
            // 
            this.cbEsquema.FormattingEnabled = true;
            this.cbEsquema.Location = new System.Drawing.Point(166, 64);
            this.cbEsquema.Name = "cbEsquema";
            this.cbEsquema.Size = new System.Drawing.Size(124, 21);
            this.cbEsquema.TabIndex = 23;
            this.cbEsquema.Text = "Seleccionar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Esquema de Planificación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tiempo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(838, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "PCB";
            // 
            // dataGridPcb
            // 
            this.dataGridPcb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPcb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPcb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Atributo,
            this.Valor});
            this.dataGridPcb.Location = new System.Drawing.Point(842, 305);
            this.dataGridPcb.Name = "dataGridPcb";
            this.dataGridPcb.Size = new System.Drawing.Size(283, 337);
            this.dataGridPcb.TabIndex = 19;
            // 
            // Atributo
            // 
            this.Atributo.HeaderText = "Atributo";
            this.Atributo.Name = "Atributo";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.Transparent;
            this.btnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEjecutar.Location = new System.Drawing.Point(19, 222);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 30);
            this.btnEjecutar.TabIndex = 18;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.AutoSize = true;
            this.txtTiempo.Location = new System.Drawing.Point(268, 270);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(13, 13);
            this.txtTiempo.TabIndex = 17;
            this.txtTiempo.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 337);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(171)))), ((int)(((byte)(229)))));
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(116, 222);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 30);
            this.btnReiniciar.TabIndex = 15;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAgregarProceso);
            this.groupBox1.Controls.Add(this.txtBurstime);
            this.groupBox1.Controls.Add(this.txtMemoria);
            this.groupBox1.Controls.Add(this.txtArribo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(358, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 129);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Proceso Manual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Memoria";
            // 
            // btnAgregarProceso
            // 
            this.btnAgregarProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(190)))), ((int)(((byte)(125)))));
            this.btnAgregarProceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProceso.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProceso.Location = new System.Drawing.Point(205, 59);
            this.btnAgregarProceso.Name = "btnAgregarProceso";
            this.btnAgregarProceso.Size = new System.Drawing.Size(154, 23);
            this.btnAgregarProceso.TabIndex = 10;
            this.btnAgregarProceso.Text = "Agregar";
            this.btnAgregarProceso.UseVisualStyleBackColor = false;
            this.btnAgregarProceso.Click += new System.EventHandler(this.btnAgregarProceso_Click);
            // 
            // txtBurstime
            // 
            this.txtBurstime.Location = new System.Drawing.Point(259, 25);
            this.txtBurstime.Name = "txtBurstime";
            this.txtBurstime.Size = new System.Drawing.Size(100, 20);
            this.txtBurstime.TabIndex = 13;
            // 
            // txtMemoria
            // 
            this.txtMemoria.Location = new System.Drawing.Point(83, 25);
            this.txtMemoria.Name = "txtMemoria";
            this.txtMemoria.Size = new System.Drawing.Size(100, 20);
            this.txtMemoria.TabIndex = 11;
            this.txtMemoria.Text = "40";
            // 
            // txtArribo
            // 
            this.txtArribo.Location = new System.Drawing.Point(83, 61);
            this.txtArribo.Name = "txtArribo";
            this.txtArribo.Size = new System.Drawing.Size(100, 20);
            this.txtArribo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "BursTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Arribo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Procesos";
            // 
            // btnGenerarProcesos
            // 
            this.btnGenerarProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnGenerarProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarProcesos.ForeColor = System.Drawing.Color.White;
            this.btnGenerarProcesos.Location = new System.Drawing.Point(19, 173);
            this.btnGenerarProcesos.Name = "btnGenerarProcesos";
            this.btnGenerarProcesos.Size = new System.Drawing.Size(155, 30);
            this.btnGenerarProcesos.TabIndex = 5;
            this.btnGenerarProcesos.Text = "Generar Procesos";
            this.btnGenerarProcesos.UseVisualStyleBackColor = false;
            this.btnGenerarProcesos.Click += new System.EventHandler(this.btnIniciarAleatoria_Click);
            // 
            // cbPlanificador
            // 
            this.cbPlanificador.FormattingEnabled = true;
            this.cbPlanificador.Location = new System.Drawing.Point(166, 106);
            this.cbPlanificador.Name = "cbPlanificador";
            this.cbPlanificador.Size = new System.Drawing.Size(124, 21);
            this.cbPlanificador.TabIndex = 4;
            this.cbPlanificador.Text = "Seleccionar";
            // 
            // txtNumProcesos
            // 
            this.txtNumProcesos.Location = new System.Drawing.Point(166, 29);
            this.txtNumProcesos.Name = "txtNumProcesos";
            this.txtNumProcesos.Size = new System.Drawing.Size(124, 20);
            this.txtNumProcesos.TabIndex = 3;
            this.txtNumProcesos.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Criterio de planificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Procesos";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtQuantum2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1125, 678);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Quantum";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(166, 144);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(124, 20);
            this.txtQuantum.TabIndex = 25;
            this.txtQuantum.Text = "2";
            // 
            // txtQuantum2
            // 
            this.txtQuantum2.Location = new System.Drawing.Point(125, 55);
            this.txtQuantum2.Name = "txtQuantum2";
            this.txtQuantum2.Size = new System.Drawing.Size(124, 20);
            this.txtQuantum2.TabIndex = 27;
            this.txtQuantum2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Quantum";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Memoria Total";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "1000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 24);
            this.label13.TabIndex = 30;
            this.label13.Text = "Administracion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(439, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(294, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "GRUPO 3 - SISTEMAS OPERATIVOS UNI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1189, 826);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Simulación";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPcb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbPlanificador;
        private System.Windows.Forms.TextBox txtNumProcesos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerarProcesos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarProceso;
        private System.Windows.Forms.TextBox txtBurstime;
        private System.Windows.Forms.TextBox txtMemoria;
        private System.Windows.Forms.TextBox txtArribo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtTiempo;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridPcb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.ComboBox cbEsquema;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
    }
}

