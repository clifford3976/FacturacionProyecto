using FacturacionAplicado.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionAplicado.UI.Registros
{
    public partial class rProducto : Form
    {
        public rProducto()
        {
            InitializeComponent();
            AgregarAComboBox();
        }

        private bool SetError(int error)
        {
            bool paso = false;
            if (error == 1 && IDcomboBox.Text == string.Empty)
            {
                IderrorProvider.SetError(IDcomboBox, "Llenar Id");
                paso = true;
            }
            if (error == 2 && PrecionumericUpDown.Value == 0)
            {
                DemasCamposerrorProvider.SetError(PrecionumericUpDown, "LLenar Precio");
                paso = true;
            }
            if (error == 2 && DepartamentocomboBox.Text == string.Empty)
            {
                DemasCamposerrorProvider.SetError(DepartamentocomboBox, "LLenar Departamento");
                paso = true;
            }
            if (error == 2 && CantidadnumericUpDown.Value == 0)
            {
                DemasCamposerrorProvider.SetError(CantidadnumericUpDown, "LLenar Cantidad");
                paso = true;
            }
            if (error == 2 && DescripciontextBox.Text == string.Empty)
            {
                DemasCamposerrorProvider.SetError(DescripciontextBox, "LLenar Descripcion");
                paso = true;
            }


            return paso;
        }

        private void LimpiarProvider()
        {
            IderrorProvider.Clear();
            DemasCamposerrorProvider.Clear();
        }

        private Producto LlenaClase()
        {
            Producto producto = new Producto();
            if (IDcomboBox.Text == string.Empty)
            {
                producto.Idproducto = 0;
            }
            else
            {
                producto.Idproducto = Convert.ToInt32(IDcomboBox.Text);
            }
            producto.Descripcion = DescripciontextBox.Text;
            producto.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            producto.Precio = PrecionumericUpDown.Value;
            producto.DepartamentoId = DepartamentocomboBox.SelectedIndex + 1;
            return producto;

        }

        public void AgregarAComboBox()
        {

            Expression<Func<Departamento, bool>> filtrar = x => true;
            List<Departamento> tipo = new List<Departamento>();
            tipo = BLL.DepartamentoBLL.GetList(filtrar);
            IDcomboBox.Items.Clear();
            DepartamentocomboBox.Items.Clear();
            foreach (var tel in tipo)
            {
                DepartamentocomboBox.Items.Add(tel.Nombre);

            }

            foreach (var item in BLL.ProductoBLL.GetList(x => true))
            {
                IDcomboBox.Items.Add(item.Idproducto);
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(1))
            {
                MessageBox.Show("Llenar campo Id");
                return;
            }

            if (BLL.ProductoBLL.Eliminar(Convert.ToString(IDcomboBox.Text)))
            {
                MessageBox.Show("Eliminado!!");
                Clear();
                AgregarAComboBox();
                return;
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!");
                return;
            }
        }

        private void IDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarProvider();
            var producto = BLL.ProductoBLL.Buscar(Convert.ToString(IDcomboBox.Text));
            PrecionumericUpDown.Value = producto.Precio;
            CantidadnumericUpDown.Value = producto.Cantidad;
            DepartamentocomboBox.Text = BLL.DepartamentoBLL.Buscar(producto.DepartamentoId).Nombre;
            DescripciontextBox.Text = producto.Descripcion;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            LimpiarProvider();
            if (SetError(2))
            {
                MessageBox.Show("LLenar Los Campos Vacios");
                return;
            }
            Producto product = LlenaClase();
            if (IDcomboBox.Text == string.Empty)
            {
                if (BLL.ProductoBLL.Guardar(product))
                {
                    MessageBox.Show("Guardado!!");
                    Clear();
                    AgregarAComboBox();
                    return;
                }
                else
                {
                    MessageBox.Show("No se Guardo!!");
                    return;
                }
            }
            else
            {
                if (BLL.ProductoBLL.Modificar(LlenaClase()))
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

        private void Clear()
        {
            LimpiarProvider();
            IDcomboBox.Text = string.Empty;
            PrecionumericUpDown.Value = 0;
            DepartamentocomboBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
        }
    }
}
