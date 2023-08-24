using Microsoft.VisualBasic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void TGuardar_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask;

            this.LModificar.Text = this.TNombre.Text + " " + this.TApellido.Text;

            if (string.IsNullOrEmpty(TNombre.Text) || string.IsNullOrEmpty(TApellido.Text) || string.IsNullOrEmpty(TDni.Text))
            {
                MessageBox.Show("el formulario no puede contener campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                ask = (MsgBoxResult)MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == MsgBoxResult.Yes)
                {

                    MessageBox.Show("El cliente " + this.TNombre.Text + " " + this.TApellido.Text + " se inserto Correctamente ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }




        private void TEliminar_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Está apunto de eliminar el Cliente: " + LModificar.Text, "Confirmar Eliminación", MessageBoxButtons.NoYes, MessageBoxIcon.Exclamation);

            if (ask == MsgBoxResult.Yes)
            {
                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                MessageBox.Show("El Cliente: " + LModificar.Text + " se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LModificar.Text = "Modificar";
            }
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is not a digit
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Set the Handled property to true to cancel the key press
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("El campo DNI solo acepta valores numericos", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Set the Handled property to true to cancel the key press
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("El campo Nombre solo acepta letras", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Set the Handled property to true to cancel the key press
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("El campo Apellido solo acepta letras", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
