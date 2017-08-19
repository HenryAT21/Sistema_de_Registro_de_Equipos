﻿using System;
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
    public partial class frmRegistro_Usuario : Form
    {
        public frmRegistro_Usuario()
        {
            InitializeComponent();
        }

        private void btnRCrear_Click(object sender, EventArgs e)
        {//botón para agregar un nuevo usuario a la base de datos
            if (txtRPass.Text==txtConfPass.Text)//este if condiciona los textBox de contraseña y confirmación de contraseña para que si los dos coinciden se pueda continuar
            {
                Operacion oper = new Operacion();//conexón a la base de datos
                oper.ConsultaSinResultado("INSERT INTO usuario (nombre, pass) VALUES ('" + txtRUsuario.Text + "', '" + txtRPass.Text + "')");
                //esta consulta agrega al nuevo usuario a la base de datos
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();//este botón es para cerrar el formulario
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {//este botón muestra la ventana de registrar nuevo empleado
            frmRegistrar_Empleado fr = new frmRegistrar_Empleado();
            fr.Show();
        }
    }
}
