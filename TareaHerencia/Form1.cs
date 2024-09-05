using TareaHerencia.ClasesLibro;

namespace TareaHerencia
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClaseMiembros_Click(object sender, EventArgs e, Libros libros)
        {
            this.listBox1.Items.Add($"Clase Miembros: {Nombre}, {Autor}");
        }
    }
}
