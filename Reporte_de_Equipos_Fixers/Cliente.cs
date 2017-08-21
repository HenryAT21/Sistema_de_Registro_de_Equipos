using System;
using CRUD;
using System.Data;
using System.Windows.Forms;

namespace Reporte_de_Equipos_Fixers
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            TopMost = true;//para que cuando inicie, aparezca al frente
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {//para guardar los nuevos clientes
            if (txtNombreCliente.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casilla de nombre");
            }

            if (txtTelefono.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casilla de teléfono");
            }

            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Inserte datos en las casilla de emil");
            }

            else
            {
                try//manejador de errores
                {
                    Operacion oper = new Operacion();//conexion a la base de datos
                    oper.ConsultaSinResultado("INSERT INTO cliente (nombre_apellido, telefono, email) VALUES ('" + txtNombreCliente.Text + "', '" + txtTelefono.Text + "', '" + txtEmail.Text + "')");
                    //esta consulta es para insertar los datos especificados en la tabla de clientes
                    MessageBox.Show("Datos agregados correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {//esto condiciona a que el usuario final se percate de que el id esta vacio para poder actualizar el registro
            if (txtIDCliente.Text.Length == 0)
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
                        oper.ConsultaSinResultado("UPDATE cliente SET nombre_apellido= '" + txtNombreCliente.Text + "', telefono= '" + txtTelefono.Text + "', email= '" + txtEmail.Text + "' WHERE id_cliente= '" + txtIDCliente.Text + "'");
                        //esta consulta es para actualizar los datos del cliente filtrandolos por el id_cliente
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
            if (txtIDCliente.Text.Length == 0)
            {
                MessageBox.Show("El ID esta vacío");
            }

            else
            {
                if (MessageBox.Show("Seguro que desea borrar este registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {//esta condicion es para lanzar un mensaje de aviso para confirmar si quiere realizar la accion
                    try//manejador de errores
                    {
                        Operacion oper = new Operacion();
                        oper.ConsultaSinResultado("DELETE FROM cliente WHERE id_cliente= '" + txtIDCliente.Text + "'");
                        //esta consulta borra los clientes filtrados por id de la base de datos
                        MessageBox.Show("Datos borrados correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {//para mostrar los datos en el dataGridView
            try//manejador de errores
            {
                Operacion oper = new Operacion();
                //se llama esta clase para mostrar los datos en el dataGridView
                DataTable dtCliente = new DataTable();
                dataGridCliente.Update();//este codigo actualiza el dataGridView
                dtCliente = oper.ConsultaConResultado("SELECT * FROM cliente");
                //este select selecciona los datos de la tabla cliente para luego mostrarlos en el dataGridView
                dataGridCliente.DataSource = dtCliente;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*estos codigos son los responsables de hacer que cada vez que se de click a una fila en el dataGridView 
         se muestren en los txtBox indicados*/
            char[] delimitador = { '/' };
            string[] separando = Convert.ToString(this.dataGridCliente.CurrentRow.Cells[3].Value).Split(delimitador);
            txtIDCliente.Text = Convert.ToString(this.dataGridCliente.CurrentRow.Cells[0].Value);
            txtNombreCliente.Text = Convert.ToString(this.dataGridCliente.CurrentRow.Cells[1].Value);
            txtTelefono.Text = Convert.ToString(this.dataGridCliente.CurrentRow.Cells[2].Value);
            txtEmail.Text = Convert.ToString(this.dataGridCliente.CurrentRow.Cells[3].Value);
            txtIDCliente.Enabled = false;
            txtNombreCliente.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {//limpiar el formulario
            txtIDCliente.Clear();
            txtNombreCliente.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }
    }
}
