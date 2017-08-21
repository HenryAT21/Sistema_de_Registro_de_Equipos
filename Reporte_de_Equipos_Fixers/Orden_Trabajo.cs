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
    public partial class frmOrden_Trabajo : Form
    {
        Operacion oper = new Operacion();
        public frmOrden_Trabajo()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casillas de ID del cliente");
            }

            if (txtIDorden.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casillas de ID de la orden");
            }
            if (txtIDTecnico.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casillas de ID técnico");
            }

            if (cmbEstatus.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en la casilla de estatus");
            }

            else
            {
                try
                {//guardar datos en la tabla orden_trabajo
                    oper.ConsultaSinResultado("INSERT INTO orden_trabajo (fk_id_equipo, fk_id_tecnico, fk_id_cliente, estatus) VALUES ('" + txtIDEquipo.Text + "', '" + txtIDTecnico.Text + "', '" + txtIDCliente.Text + "', '" + cmbEstatus.Text + "')");
                    MessageBox.Show("Datos agregados correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {//mostrar los datos de la tabla orden_trabajo en el dataGridView
                DataTable dt = new DataTable();
                dataGridOrdenT.Update();
                dt = oper.ConsultaConResultado("SELECT * FROM orden_trabajo");
                dataGridOrdenT.DataSource = dt;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIDTecnico.Text.Length == 0)
            {
                MessageBox.Show("El ID está vacío");
            }

            else
            {
                if (MessageBox.Show("Seguro que desea actualizar este registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {//esta condicion es para lanzar un mensaje de aviso para confirmar si quiere realizar la accion
                    try
                    {
                        oper.ConsultaSinResultado("UPDATE orden_trabajo SET fk_id_equipo= '" + txtIDEquipo.Text + "', fk_id_tecnico= '" + txtIDTecnico.Text + "', fk_id_cliente= '" + txtIDCliente.Text + "', estatus= '" + cmbEstatus.Text + "' WHERE id_tr= '" + txtIDorden.Text + "'");
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
            if (txtIDTecnico.Text.Length == 0)
            {
                MessageBox.Show("El ID está vacío");
            }

            else
            {
                if (MessageBox.Show("Seguro que desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {//esta condicion es para lanzar un mensaje de aviso para confirmar si quiere realizar la accion
                    try
                    {
                        oper.ConsultaSinResultado("DELETE FROM orden_trabajo WHERE id_tr= '" + txtIDorden.Text + "'");
                        MessageBox.Show("Datos borrados correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridOrdenT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//esto hace que cuando se haga click en un dato del dataGridView se pase a los textBox
            char[] delimitador = { '/' };
            string[] separando = Convert.ToString(this.dataGridOrdenT.CurrentRow.Cells[5].Value).Split(delimitador);
            txtIDorden.Text = Convert.ToString(this.dataGridOrdenT.CurrentRow.Cells[0].Value);
            txtIDEquipo.Text = Convert.ToString(this.dataGridOrdenT.CurrentRow.Cells[2].Value);
            txtIDTecnico.Text = Convert.ToString(this.dataGridOrdenT.CurrentRow.Cells[3].Value);
            txtIDCliente.Text = Convert.ToString(this.dataGridOrdenT.CurrentRow.Cells[4].Value);
            cmbEstatus.Text = Convert.ToString(this.dataGridOrdenT.CurrentRow.Cells[5].Value);
            txtIDorden.Enabled = false;
            txtIDEquipo.Enabled = true;
            txtIDTecnico.Enabled = true;
            txtIDCliente.Enabled = true;
            cmbEstatus.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {//limpiar formulario
            txtIDCliente.Clear();
            txtIDEquipo.Clear();
            txtIDorden.Clear();
            txtIDTecnico.Clear();
        }
    }
}
