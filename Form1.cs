using System.ComponentModel;

namespace _01_Caso_practico_Persona
{
    public partial class Form1 : Form
    {
        //Declaramos y creamos la lista personas
        public BindingList<Persona> personas = new BindingList<Persona>();
        public Form1()
        {
            InitializeComponent();
            dgvPersonas.DataSource = personas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //Creamos un nuevo objeto persona
            Persona p = new Persona()
            {
                Nombre = txtNombre.Text,//Toma lo que se cargue en la caja de texto
                Apellido = txtApellido.Text,
                DNI = txtDNI.Text,
            };
            //Agrego el objeto creado a la lista
            personas.Add(p);
            //Refrescamos DGV
            //RefreshGrid();
        }
        /*private void RefreshGrid()
        {//Limpiamos la grilla para que solo contenga los datos cargados
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;
        }*/ // ya no lo necesito con Bindinglist

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow?.DataBoundItem is Persona p)
            {
                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                p.DNI = txtDNI.Text;
                //RefreshGrid();
            }
        }            

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.CurrentRow != null) 
            {
                Persona p = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
                personas.Remove(p);
                //RefreshGrid();
            }
        }
    }
}
