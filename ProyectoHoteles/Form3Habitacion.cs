using System;
using ProyectoHoteles.Dato;
using ProyectoHoteles.Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHoteles
{
    public partial class Form3Habitacion : Form
    {
        private DataTable Tabla;
        Habitaciones habi = new Habitaciones();
        private void Inicializar()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("IdHabitacion");
            Tabla.Columns.Add("Dimension");
            Tabla.Columns.Add("Categoria");
            Tabla.Columns.Add("Disponibilidad");
            dgHabitacion.DataSource = Tabla;
        }
        public Form3Habitacion()
        {
            InitializeComponent();
            Inicializar();
            Consultar();
        }

        private void Consultar()
        {
            List<Habitacion> lista = habi.Consultar();
            foreach(var elemento in lista)
            {
                DataRow row = Tabla.NewRow();
                row["IdHabitacion"] = elemento.IdHabitacion;
                row["Dimension"] = elemento.Dimension;
                row["Categoria"] = elemento.Disponibilidad;
                Tabla.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
