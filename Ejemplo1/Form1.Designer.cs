namespace Ejemplo1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.boxRadio = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbSeparado = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.lblObjetos = new System.Windows.Forms.Label();
            this.listObjetos = new System.Windows.Forms.ListView();
            this.txtObjetos = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkVehiculo = new System.Windows.Forms.CheckBox();
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.boxRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(161, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(161, 84);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(161, 116);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(221, 145);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(124, 151);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(91, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(221, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(221, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Location = new System.Drawing.Point(221, 109);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(167, 337);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(92, 35);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // boxRadio
            // 
            this.boxRadio.Controls.Add(this.rbSoltero);
            this.boxRadio.Controls.Add(this.rbSeparado);
            this.boxRadio.Controls.Add(this.rbCasado);
            this.boxRadio.Location = new System.Drawing.Point(127, 205);
            this.boxRadio.Name = "boxRadio";
            this.boxRadio.Size = new System.Drawing.Size(302, 42);
            this.boxRadio.TabIndex = 9;
            this.boxRadio.TabStop = false;
            this.boxRadio.Text = "Estado civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(211, 19);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 2;
            this.rbSoltero.TabStop = true;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbSeparado
            // 
            this.rbSeparado.AutoSize = true;
            this.rbSeparado.Location = new System.Drawing.Point(105, 19);
            this.rbSeparado.Name = "rbSeparado";
            this.rbSeparado.Size = new System.Drawing.Size(74, 17);
            this.rbSeparado.TabIndex = 1;
            this.rbSeparado.TabStop = true;
            this.rbSeparado.Text = "Sepadado";
            this.rbSeparado.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Location = new System.Drawing.Point(14, 19);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 0;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // lblObjetos
            // 
            this.lblObjetos.AutoSize = true;
            this.lblObjetos.Location = new System.Drawing.Point(164, 427);
            this.lblObjetos.Name = "lblObjetos";
            this.lblObjetos.Size = new System.Drawing.Size(43, 13);
            this.lblObjetos.TabIndex = 10;
            this.lblObjetos.Text = "Objetos";
            // 
            // listObjetos
            // 
            this.listObjetos.HideSelection = false;
            this.listObjetos.Location = new System.Drawing.Point(206, 466);
            this.listObjetos.Name = "listObjetos";
            this.listObjetos.Size = new System.Drawing.Size(101, 97);
            this.listObjetos.TabIndex = 11;
            this.listObjetos.UseCompatibleStateImageBehavior = false;
            this.listObjetos.View = System.Windows.Forms.View.List;
            // 
            // txtObjetos
            // 
            this.txtObjetos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObjetos.Location = new System.Drawing.Point(206, 424);
            this.txtObjetos.Name = "txtObjetos";
            this.txtObjetos.Size = new System.Drawing.Size(100, 20);
            this.txtObjetos.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(313, 427);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 26);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(313, 398);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(206, 570);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkVehiculo
            // 
            this.checkVehiculo.AutoSize = true;
            this.checkVehiculo.Location = new System.Drawing.Point(221, 182);
            this.checkVehiculo.Name = "checkVehiculo";
            this.checkVehiculo.Size = new System.Drawing.Size(105, 17);
            this.checkVehiculo.TabIndex = 18;
            this.checkVehiculo.Text = "Posee vehiculo?";
            this.checkVehiculo.UseVisualStyleBackColor = true;
            // 
            // cbZona
            // 
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Location = new System.Drawing.Point(221, 265);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(121, 21);
            this.cbZona.TabIndex = 19;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(124, 268);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(96, 13);
            this.lblZona.TabIndex = 20;
            this.lblZona.Text = "En que zona vive?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 621);
            this.Controls.Add(this.lblZona);
            this.Controls.Add(this.cbZona);
            this.Controls.Add(this.checkVehiculo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtObjetos);
            this.Controls.Add(this.listObjetos);
            this.Controls.Add(this.lblObjetos);
            this.Controls.Add(this.boxRadio);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxRadio.ResumeLayout(false);
            this.boxRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox boxRadio;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbSeparado;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.Label lblObjetos;
        private System.Windows.Forms.ListView listObjetos;
        private System.Windows.Forms.TextBox txtObjetos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkVehiculo;
        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.Label lblZona;
    }
}

