namespace Ejercicio_n2_Carlos_Rivas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LBestudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        string[] nombres;
        string[] edad = new string[5];
        private void Ingresar_Click(object sender, EventArgs e)
        {
            nombres = new string[1];
            nombres[0] = textNombre.Text;
            edad=new string[1];
            edad[0]=textEdad.Text;
            LBestudiantes.Items.Add("Nombre:" +nombres[0] + "Edad:" + edad[0]);
            textNombre.Clear();
            textEdad.Clear();

        }

        private void Salir_button_Click(object sender, EventArgs e)
        {
            
           this.Close();
            
        }
    }
}