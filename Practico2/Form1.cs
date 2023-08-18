using Microsoft.VisualBasic;

namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TDni_KeyPress(object  sender, KeyPressEventArgs e){
            // probar if original,sino probar : "!double.TryParse(this.TDni.Text, out parseValue)"
             if(!char.IsControl(e.keyChar) && !char.IsDigit(e.KeyChar)){
                  e.Handled=true
             }
        }
        private void TApellido_KeyPress(object  sender, KeyPressEventArgs e){
            //probar, si funciona, en caso de ser asi hacer lo mismo con TNombre 
             if(input.All(c => char.IsLetter(c) || c == ' '){
                  e.Handled=true
             }
        }
        private void TGuardar_Click(object sender, EventArgs e)
        {
            double parseValue;
         
            MsgBoxResult ask;



            

            this.LModificar.Text = this.TNombre.Text + " " + this.TApellido.Text;

            if (this.TApellido.Text == "" || this.TApellido.Text == "" || this.TDNI.Text == "")
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

        private void inputValidation(bool validacion, string campo, TextBox textBoxN)
        {
            double parseValue;
            string type;
            if (!double.TryParse(textBoxN.Text, out parseValue))
            {
                type = "numeric";
            }
            else
            {
                type = "char";
            }
            if (validacion)
            {
                textBoxN.Text = "";
                MessageBox.Show(campo + " field only allows " + type + " values", campo + "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateString(string input)
        {
            return input.All(c => char.IsLetter(c) || c == ' ');
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Está apunto de eliminar el Cliente: " + LModificar.Text, "Confirmar Eliminación",MessageBoxButtons.NoYes,MessageBoxIcon.Exclamation);

            if(ask == MsgBoxResult.Yes){
                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                MessageBox.Show("El Cliente: " + LModificar.Text+ " se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LModificar.Text = "Modificar";
            }
        }
    }
}
