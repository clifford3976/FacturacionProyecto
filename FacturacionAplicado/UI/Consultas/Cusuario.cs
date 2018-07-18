using FacturacionAplicado.Entidades;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace FacturacionAplicado.UI.Consultas
{
    public partial class Cusuario : Form
    {
        public Cusuario()
        {
            InitializeComponent();
        }
        Expression<Func<Usuario, bool>> filtrar = x => true;
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            //int id;

            if (TipocomboBox.Text == string.Empty && FechacheckBox.Checked == true)
            {
                //filtrar = t => true && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
            }
            else
            {
                filtrar = t => true;
            }



            //switch (TipocomboBox.SelectedIndex)
            //{
                //ID
                //case 0:

                //    LimpiarError();
                //    if (SetError(1))
                //    {
                //        MessageBox.Show("Introduce un numero");
                //        return;
                //    }
                //    id = int.Parse(CriteriotextBox.Text);
                //    if (FechacheckBox.Checked == true)
                //    {
                //        filtrar = t => t.IdUsuario == id && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
                //    }
                //    else
                //    {
                //        filtrar = t => t.IdUsuario == id;
                //    }

                //    break;
                ////Nombre
                //case 1:
                //    LimpiarError();
                //    if (SetError(2))
                //    {
                //        MessageBox.Show("Introduce un caracter");
                //        return;
                //    }
                //    if (FechacheckBox.Checked == true)
                //    {
                //        filtrar = t => t.Nombre.Equals(CriteriotextBox.Text) && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);

                //    }
                //    else
                //    {
                //        filtrar = t => t.Nombre.Equals(CriteriotextBox.Text);
                //    }

                //    break;
                ////Lista todo
                //case 2:
                //    LimpiarError();


                //    if (FechacheckBox.Checked == true)
                //    {
                //        filtrar = t => true && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
                //    }
                //    else
                //    {
                //        filtrar = t => true;
                //    }
                //    //filtrar = t => (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) &&(t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
                //    break;
                ////Usuario
                //case 3:
                //    LimpiarError();
                //    if (SetError(2))
                //    {
                //        MessageBox.Show("Introduce un Caracter");
                //        return;
                //    }
                //    if (FechacheckBox.Checked == true)
                //    {
                //        filtrar = t => t.NombreUsuario.Equals(CriteriotextBox.Text) && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
                //    }
                //    else
                //    {
                //        filtrar = t => t.NombreUsuario.Equals(CriteriotextBox.Text);
                //    }

                //    break;
                ////Clave
                //case 4:
                //    LimpiarError();
                //    if (SetError(1))
                //    {
                //        MessageBox.Show("Introduce un numero");
                //        return;

                //    }
                //    if (FechacheckBox.Checked == true)
                //    {
                //        filtrar = t => t.Clave.Equals(CriteriotextBox.Text) && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
                //    }
                //    else
                //    {
                //        filtrar = t => t.Clave.Equals(CriteriotextBox.Text);
                //    }

                //    break;
                ////Comentario
                //case 5:
                //    LimpiarError();
                //    if (SetError(2))
                //    {
                //        MessageBox.Show("Introduce un caracter");
                //        return;
                //    }
                //    if (FechacheckBox.Checked == true)
                //    {
                //        filtrar = t => t.Comentario.Contains(CriteriotextBox.Text) && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
                //    }
                //    {
                //        filtrar = t => t.Comentario.Contains(CriteriotextBox.Text);
                //    }

                //    break;
            //}


          //  ConsultadataGridView.DataSource = BLL.UsuarioBLL.GetList(filtrar);
        }
        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if(error ==1&& int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                TexterrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if(error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) ==true)
            {
                TexterrorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void LimpiarError()
        {
            TexterrorProvider.Clear();
        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            
        }

        private void TipocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CriteriotextBox.Clear();
            LimpiarError();
            if (TipocomboBox.SelectedIndex == 2)
            {
                CriteriotextBox.Enabled = false;

            }
            else
            {
                CriteriotextBox.Enabled = true;
            }
        }

        private void FechacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FechacheckBox.Checked == false)
            {
                AHoradateTimePicker1.Enabled = false;
                FInaldateTimePicker2.Enabled = false;
            }
            else
            {
                AHoradateTimePicker1.Enabled = true;
                FInaldateTimePicker2.Enabled = true;
            }
        }
    }
}
