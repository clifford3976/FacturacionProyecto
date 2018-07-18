using FacturacionAplicado.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionAplicado.UI.Registros
{
    public partial class rDepartamento : Form
    {
        public rDepartamento()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void LlenarComboBox()
        {
            IDcomboBox.Items.Clear();
            foreach (var item in BLL.DepartamentoBLL.Buscar())
            {
                IDcomboBox.Items.Add(item.DepartamentoId);
            }


        }

        private void Clear()
        {
            NombretextBox.Clear();
            IDcomboBox.Text = string.Empty;
            LimpiarProvider();
        }

        private void LimpiarProvider()
        {
            IderrorProvider.Clear();
            DemaserrorProvider.Clear();
        }

        private bool SetError(int error)
        {
            bool paso = false;
            if (error == 1 && IDcomboBox.Text == string.Empty)
            {
                IderrorProvider.SetError(IDcomboBox, "Llenar Campo Id");
                paso = true;
            }
            if (error == 2 && NombretextBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(NombretextBox, "Llenar Nombre");
                paso = true;
            }

            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(2))
            {
                MessageBox.Show("Llenar los campos Vacios!!");
                return;
            }
            Departamento depo = LlenaClase();

            if (IDcomboBox.Text == string.Empty)
            {
                if (BLL.DepartamentoBLL.Guardar(depo))
                {
                    MessageBox.Show("Guardado!!");
                    IDcomboBox.DataSource = null;
                    LlenarComboBox();
                    Clear();

                }
                else
                {
                    MessageBox.Show("No se pudo Guardar!!");
                    return;
                }

            }
            else
            {
                if (BLL.DepartamentoBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Modificado!!");
                    return;
                }
                else
                {
                    MessageBox.Show("No se pudo modificar!!");
                    return;
                }
            }
        }


        private Departamento LlenaClase()
        {
            Departamento depo = new Departamento();
            if (IDcomboBox.Text == string.Empty)
            {
                depo.DepartamentoId = 0;
            }
            else
            {
                depo.DepartamentoId = Convert.ToInt32(IDcomboBox.Text);
            }


            depo.Nombre = NombretextBox.Text;
            return depo;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(1))
            {
                MessageBox.Show("Digite el ID");
                return;
            }

            if (BLL.DepartamentoBLL.Eliminar(IDcomboBox.Text))
            {
                MessageBox.Show("Eliminado!!");
                IDcomboBox.DataSource = null;
                LlenarComboBox();
                Clear();


            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!");
            }
        }

        private void IDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarProvider();
            var depo = Convert.ToInt32(IDcomboBox.Text);
            foreach (var item in BLL.DepartamentoBLL.Buscar())
            {
                if(item.DepartamentoId==depo)
                {
                    NombretextBox.Text =item.Nombre ;
                }
            }
            
        }
    }
}
