using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General2.GUI
{
    public partial class HistorialClinico : Form
    {
        public HistorialClinico()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Llamar clase
            CLS.HClinico oclas = new CLS.HClinico();
            //componentes
            oclas.IDPaciente = tbId.Text;
            oclas.IDHistorialClinico = tbAfecciones.Text;
            //combobox componnete
            DataRowView drv = (DataRowView)cbEstado.SelectedItem; 
            oclas.Estado = drv.Row.ItemArray[0].ToString();
            //Verificar si alguno de los campos está vacío

            if (string.IsNullOrWhiteSpace(tbPaciente.Text) ||
                string.IsNullOrWhiteSpace(tbAfecciones.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbId.TextLength > 0)
            {
                if (oclas.Actualizar())
                {
                    //mostrar mensaje
                    MessageBox.Show("Registro fue actualizado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Registro no fue actualizado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Realizar la operacion de insertar
            else
            {
                if (oclas.Insertar())
                {

                    //mostrar mensaje
                    MessageBox.Show("Registro insertado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();


                }
                else
                {
                    MessageBox.Show("Registro no fue insertado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
        //Continuar aqui

    }
}
