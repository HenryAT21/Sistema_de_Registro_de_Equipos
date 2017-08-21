using System;
using CRUD;
using System.Data;
using System.Windows.Forms;

namespace Reporte_de_Equipos_Fixers
{
    public partial class frmRegistrar_Tecnico : Form
    {
        public frmRegistrar_Tecnico()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void btnRGuardar_Click(object sender, EventArgs e)
        {
            if (txtRNombreTec.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casillas de nombre");
            }

            if (txtRTelefonoTec.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casillas de teléfono");
            }

            else
            {
                try//manejador de errores
                {
                    Operacion oper = new Operacion();//conexión a la base de datos
                    oper.ConsultaSinResultado("INSERT INTO tecnico (nombre, telefono) VALUES ('" + txtRNombreTec.Text + "', '" + txtRTelefonoTec.Text + "')");
                    //esta consulta agrega un nuevo empleado a la tabla técnico en la base de datos
                    MessageBox.Show("Datos guardados correctamente");
                }
                catch (Exception ex)
                {//muetsra un mensaje de error en caso de que suceda
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                Operacion oper = new Operacion();//conexion a la base de datos
                //se llama esta clase para mostrar los datos en el dataGridView
                DataTable dtTecnico = new DataTable();
                
                dtTecnico = oper.ConsultaConResultado("SELECT * FROM tecnico");
                //este select selecciona los datos de la tabla tecnico para luego mostrarlos en el dataGridView
                dataGridTecnico.DataSource = dtTecnico;
                dataGridTecnico.Update();//este codigo actualiza el dataGridView
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRActualizar_Click(object sender, EventArgs e)
        {//para actualizar los técnicos

            if (txtIDRTec.Text.Length == 0)
            {
                MessageBox.Show("El ID está vacío");
            }

            else
            {
                if (MessageBox.Show("Seguro que desea actualizar este registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {//esta condicion es para lanzar un mensaje de aviso para confirmar si quiere realizar la accion
                    try//manejador de errores
                    {
                        Operacion oper = new Operacion();
                        oper.ConsultaSinResultado("UPDATE tecnico SET nombre = '" + txtRNombreTec.Text + "', telefono = '" + txtRTelefonoTec.Text + "' WHERE id_tecnico = '" + txtIDRTec.Text + "'");
                        //esta consulta actualiza el técnico que elijamos
                        MessageBox.Show("Datos actualizados correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnRBorrar_Click(object sender, EventArgs e)
        {//para borrar los técnicos

            if (txtIDRTec.Text.Length == 0)
            {
                MessageBox.Show("El ID está vacío");
            }

            else
            {
                if (MessageBox.Show("Seguro que desea borrar este registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {//esta condicion es para lanzar un mensaje de aviso para confirmar si quiere realizar la accion
                    try
                    {
                        Operacion oper = new Operacion();
                        oper.ConsultaSinResultado("DELETE FROM tecnico WHERE id_tecnico = '" + txtIDRTec.Text + "'");
                        //esta es la consulta para borrar un técnico filtrado por id
                        MessageBox.Show("Datos borrados correctamete");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridTecnico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*estos codigos son los responsables de hacer que cada vez que se de click a una fila en el dataGridView 
         se muestren en los txtBox indicados*/
            char[] delimitador = { '/' };
            string[] separando = Convert.ToString(this.dataGridTecnico.CurrentRow.Cells[2].Value).Split(delimitador);
            txtIDRTec.Text = Convert.ToString(this.dataGridTecnico.CurrentRow.Cells[0].Value);
            txtRNombreTec.Text = Convert.ToString(this.dataGridTecnico.CurrentRow.Cells[1].Value);
            txtRTelefonoTec.Text = Convert.ToString(this.dataGridTecnico.CurrentRow.Cells[2].Value);
            txtIDRTec.Enabled = false;
            txtRNombreTec.Enabled = true;
            txtRTelefonoTec.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {//limpiar el formulario
            txtIDRTec.Clear();
            txtRNombreTec.Clear();
            txtRTelefonoTec.Clear();
        }
    }
}
