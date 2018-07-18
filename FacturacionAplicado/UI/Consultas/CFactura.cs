
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
    public partial class CFactura : Form
    {
        public CFactura()
        {
            InitializeComponent();
        }
        Expression<Func<Factura, bool>> filtrar = x => true;
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            //int id;
            //decimal valor = 0;

            //if(TipocomboBox.Text ==string.Empty&& FechacheckBox.Checked == true)
            //{
            //    filtrar = t => true && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
            //}
            //else
            //{
            //    filtrar = t => true;
            //}



            //switch (TipocomboBox.SelectedIndex)
            //{
            //    //ID
            //    case 0:
            //        LimpiarError();
            //        if (SetError(1))
            //        {
            //            MessageBox.Show("Introduce un numero");
            //            return;

            //        }
            //        id = int.Parse(CriteriotextBox.Text);
            //        if (FechacheckBox.Checked == true)
            //        {
            //            filtrar = t => t.FacturaId == id && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
            //        }
            //        else
            //        {
            //            filtrar = t => t.FacturaId == id;
            //        }

            //        break;
            //    //ClienteID
            //    case 1:
            //        LimpiarError();
            //        if (SetError(1))
            //        {
            //            MessageBox.Show("Introduce un numero");
            //            return;

            //        }
            //        id = int.Parse(CriteriotextBox.Text);
            //        if (FechacheckBox.Checked == true)
            //        {
            //            filtrar = t => t.ClienteId == id && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
            //        }
            //        else
            //        {
            //            filtrar = t => t.ClienteId == id;
            //        }

            //        break;
            //    //IDusuario
            //    case 2:
            //        LimpiarError();
            //        if (SetError(1))
            //        {
            //            MessageBox.Show("Introduce un numero");
            //            return;

            //        }
            //        id = int.Parse(CriteriotextBox.Text);
            //        if (FechacheckBox.Checked == true)
            //        {
            //            filtrar = t => t.UsuarioId == id && (t.Fecha.Date >= AHoradateTimePicker1.Value.Date)  && (t.Fecha.Date <= FInaldateTimePicker2.Value.Date);
            //        }
            //        else
            //        {
            //            filtrar = t => t.UsuarioId == id;
            //        }

            //        break;
            //    //Descripcion
            //    case 3:
            //        LimpiarError();
            //        if (SetError(2))
            //        {
            //            MessageBox.Show("Introduce un caracter");
            //            return;
            //        }
            //        if (FechacheckBox.Checked == true)
            //        {
            //            filtrar = t => t.Descripcion.Contains(CriteriotextBox.Text) && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
            //        }
            //        else
            //        {
            //            filtrar = t => t.Descripcion.Contains(CriteriotextBox.Text);
            //        }

            //        break;
            //    //Lista todo
            //    case 4:

            //        if (FechacheckBox.Checked == true)
            //        {
            //            filtrar = t => true && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
            //        }
            //        else
            //        {
            //            filtrar = t => true;
            //        }

            //        //filtrar = t => (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
            //        break;

            //    //forma de pago
            //    case 5:

            //        if (FechacheckBox.Checked == true)
            //        {
                        
            //            if (ContadocheckBox.Checked == true)
            //            {
            //                filtrar = t => t.FormaDePago == "Contado" && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);

            //            }
            //            if (CreditocheckBox.Checked == true)
            //            {
            //                filtrar = t => t.FormaDePago == "Credito" && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);

            //            }
            //            if (CreditocheckBox.Checked == false && ContadocheckBox.Checked == false || CreditocheckBox.Checked == true && ContadocheckBox.Checked == true)
            //            {
            //                filtrar = t => true && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
                            
            //            }

            //        }
            //        else
            //        {
                        
            //            if (ContadocheckBox.Checked == true)
            //            {
            //                filtrar = t => t.FormaDePago == "Contado";

            //            }
            //            if (CreditocheckBox.Checked == true)
            //            {
            //                filtrar = t => t.FormaDePago == "Credito" ;

            //            }
            //            if (CreditocheckBox.Checked == false && ContadocheckBox.Checked == false || CreditocheckBox.Checked == true && ContadocheckBox.Checked == true)
            //            {
            //                filtrar = t => true;
                           
            //            }
            //        }
                        
            //        break;
            //    //monto
            //    case 6:
            //        LimpiarError();
            //        if (SetError(1))
            //        {
            //            MessageBox.Show("Introduce un numero");
            //            return;

            //        }

            //        valor = Convert.ToDecimal(CriteriotextBox.Text);
            //        if (FechacheckBox.Checked == true)
            //        {
            //            filtrar = t => t.Monto == valor && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
            //        }
            //        else
            //        {
            //            filtrar = t => t.Monto == valor;
            //        }
                        
            //        break;
            //    //efectivo recibido
            //    case 7:
            //        LimpiarError();
            //        if (SetError(1))
            //        {
            //            MessageBox.Show("Introduce un numero");
            //            return;

            //        }
            //        valor = Convert.ToDecimal(CriteriotextBox.Text);
            //        if (FechacheckBox.Checked == true)
            //        {
            //            filtrar = t => t.EfectivoRecibido == valor && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
            //        }
            //        else
            //        {
            //            filtrar = t => t.EfectivoRecibido == valor;
            //        }
                        
            //        break;

            //    //Devuelta
            //    case 8:
            //        LimpiarError();
            //        if (SetError(1))
            //        {
            //            MessageBox.Show("Introduce un numero");
            //            return;

            //        }
            //        valor = Convert.ToDecimal(CriteriotextBox.Text);
            //        if (FechacheckBox.Checked == true)
            //        {
            //            filtrar = t => t.Devuelta == valor && (t.Fecha.Day >= AHoradateTimePicker1.Value.Day) && (t.Fecha.Month >= AHoradateTimePicker1.Value.Month) && (t.Fecha.Year >= AHoradateTimePicker1.Value.Year) && (t.Fecha.Day <= FInaldateTimePicker2.Value.Day) && (t.Fecha.Month <= FInaldateTimePicker2.Value.Month) && (t.Fecha.Year <= FInaldateTimePicker2.Value.Year);
            //        }
            //        else
            //        {
            //            filtrar = t => t.Devuelta == valor;
            //        }
                        
            //        break;
               
            //}


          //  ConsultadataGridView.DataSource = BLL.FacturacionBLL.GetList(filtrar);
        }

        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                TexterrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
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
            if(TipocomboBox.SelectedIndex==4)
            {
                CriteriotextBox.Enabled = false;

            }
            else
            {
                CriteriotextBox.Enabled = true;
            }
            if(TipocomboBox.SelectedIndex == 5)
            {
                CriteriotextBox.Enabled = false;
                ContadocheckBox.Enabled = true;
                CreditocheckBox.Enabled = true;
            }
            else
            {
                ContadocheckBox.Enabled = false;
                CreditocheckBox.Enabled = false;
            }

        }

        private void FechacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(FechacheckBox.Checked==false)
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
