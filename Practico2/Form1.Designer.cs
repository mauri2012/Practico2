namespace TP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LNya = new Label();
            LModificar = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            TNombre = new TextBox();
            TDni = new TextBox();
            TApellido = new TextBox();
            TGuardar = new Button();
            TEliminar = new Button();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AccessibleName = "LNya";
            LNya.AutoSize = true;
            LNya.Location = new Point(25, 52);
            LNya.Name = "LNya";
            LNya.Size = new Size(107, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido";
            // 
            // LModificar
            // 
            LModificar.AccessibleName = "LMocdificar";
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(172, 52);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "Modificar";
            // 
            // LDni
            // 
            LDni.AccessibleName = "LDni";
            LDni.AutoSize = true;
            LDni.Location = new Point(42, 194);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AccessibleName = "LApellido";
            LApellido.AutoSize = true;
            LApellido.Location = new Point(42, 149);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            LNombre.AccessibleName = "LNombre";
            LNombre.AutoSize = true;
            LNombre.Location = new Point(42, 105);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(134, 105);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 5;
           
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TDni
            // 
            TDni.AccessibleName = "TDni";
            TDni.Location = new Point(134, 186);
            TDni.Name = "TDni";
            TDni.RightToLeft = RightToLeft.No;
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 6;
       
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.AccessibleName = "TApellido";
            TApellido.Location = new Point(134, 141);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 7;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TGuardar
            // 
            TGuardar.AccessibleName = "TGuardar";
            TGuardar.Location = new Point(42, 224);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(75, 23);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.AccessibleName = "TEliminar";
            TEliminar.Location = new Point(159, 226);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(75, 23);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(TNombre);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            Name = "Form1";
            Text = "pequeño formulario";
            ResumeLayout(false);
            PerformLayout();
        }

    

        #endregion

        private Label LNya;
        private Label LModificar;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private TextBox TNombre;
        private TextBox TDni;
        private TextBox TApellido;
        private Button TGuardar;
        private Button TEliminar;
    }
}