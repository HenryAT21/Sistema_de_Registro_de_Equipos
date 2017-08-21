using System;
using CRUD;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte_de_Equipos_Fixers
{
    public partial class frmEquipos : Form
    {
        Operacion oper = new Operacion();
        public frmEquipos()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casillas de marca");
            }

            if (txtAccesorios.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casillas de acccesorios");
            }

            if (txtDiagnostico.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casillas de diagnóstico");
            }

            if (txtServiceTag.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casillas de service tag");
            }

            if (txtSolucion.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casillas de solución");
            }

            else
            {
                try
                {//insertar equipos en la base de datos
                    oper.ConsultaSinResultado("INSERT INTO equipos (marca_modelo, service_tag, accesorios, problema, solucion) VALUES ('" + txtMarca.Text + "', '" + txtServiceTag.Text + "', '" + txtAccesorios.Text + "', '" + txtDiagnostico.Text + "', '" + txtSolucion.Text + "') ");
                    MessageBox.Show("Datos guardados correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {//para que se muestren los datos en el dataGridView
                DataTable dt = new DataTable();
                dataGridEquipos.Update();
                dt = oper.ConsultaConResultado("SELECT * FROM equipos");
                dataGridEquipos.DataSource = dt;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIDEquipo.Text.Length == 0)
            {
                MessageBox.Show("El ID está vacío");
            }

            else
            {
                if (MessageBox.Show("Seguro que desea actualizar este registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {//esta condicion es para lanzar un mensaje de aviso para confirmar si quiere realizar la accion
                    try
                    {//para actualizar los datos en la tabla de equipos en la base de datos
                        oper.ConsultaSinResultado("UPDATE equipos SET marca_modelo= '" + txtMarca.Text + "', service_tag= '" + txtServiceTag.Text + "', accesorios= '" + txtAccesorios.Text + "', problema= '" + txtDiagnostico.Text + "', solucion= '" + txtSolucion.Text + "' WHERE id_equipo= '" + txtIDEquipo.Text + "'");
                        MessageBox.Show("Datos actualizados correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtIDEquipo.Text.Length == 0)
            {
                MessageBox.Show("El ID está vacío");
            }

            else
            {
                if (MessageBox.Show("Seguro que desea borrar este registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {//esta condicion es para lanzar un mensaje de aviso para confirmar si quiere realizar la accion
                    try
                    {//borrar datos de la base de datos
                        oper.ConsultaSinResultado("DELETE FROM equipos WHERE id_equipo= '" + txtIDEquipo.Text + "'");
                        MessageBox.Show("Datos borrados correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*estos codigos son los responsables de hacer que cada vez que se de click a una fila en el dataGridView 
         se muestren en los txtBox indicados*/
            char[] delimitador = { '/' };
            string[] separando = Convert.ToString(this.dataGridEquipos.CurrentRow.Cells[5].Value).Split(delimitador);
            txtIDEquipo.Text = Convert.ToString(this.dataGridEquipos.CurrentRow.Cells[0].Value);
            txtMarca.Text = Convert.ToString(this.dataGridEquipos.CurrentRow.Cells[1].Value);
            txtServiceTag.Text = Convert.ToString(this.dataGridEquipos.CurrentRow.Cells[2].Value);
            txtAccesorios.Text = Convert.ToString(this.dataGridEquipos.CurrentRow.Cells[3].Value);
            txtDiagnostico.Text = Convert.ToString(this.dataGridEquipos.CurrentRow.Cells[4].Value);
            txtSolucion.Text = Convert.ToString(this.dataGridEquipos.CurrentRow.Cells[5].Value);
            txtIDEquipo.Enabled = false;
            txtMarca.Enabled = true;
            txtServiceTag.Enabled = true;
            txtAccesorios.Enabled = true;
            txtDiagnostico.Enabled = true;
            txtSolucion.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {//limpiar formulario
            txtIDEquipo.Clear();
            txtMarca.Clear();
            txtServiceTag.Clear();
            txtSolucion.Clear();
            txtDiagnostico.Clear();
            txtAccesorios.Clear();
        }
    }
}
