namespace GestonDeCobroEstacionamiento
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcionTarifa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Items.AddRange(new object[] {
            "Motocicleta",
            "Automóvil",
            "Camioneta"});
            this.cmbVehiculo.Location = new System.Drawing.Point(129, 35);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(129, 21);
            this.cmbVehiculo.TabIndex = 0;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(129, 69);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(129, 20);
            this.txtHoras.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Lime;
            this.btnCalcular.Location = new System.Drawing.Point(37, 98);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 26);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(44, 161);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: $0";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(34, 35);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(92, 13);
            this.lblVehiculo.TabIndex = 4;
            this.lblVehiculo.Text = "Tipo de Vehículo:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(34, 69);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(96, 13);
            this.lblHoras.TabIndex = 5;
            this.lblHoras.Text = "Horas de estancia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // lblDescripcionTarifa
            // 
            this.lblDescripcionTarifa.AutoSize = true;
            this.lblDescripcionTarifa.Location = new System.Drawing.Point(44, 136);
            this.lblDescripcionTarifa.Name = "lblDescripcionTarifa";
            this.lblDescripcionTarifa.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionTarifa.TabIndex = 7;
            this.lblDescripcionTarifa.Text = "Descripcion";
            this.lblDescripcionTarifa.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 199);
            this.Controls.Add(this.lblDescripcionTarifa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblHoras);
            this.Name = "Form1";
            this.Text = "Estacionamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripcionTarifa;
    }
}


