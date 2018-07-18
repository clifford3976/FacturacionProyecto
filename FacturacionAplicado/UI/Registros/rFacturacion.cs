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
    public partial class rFacturacion : Form
    {//todo: para todo: Probar todo mas de una vez
        decimal Monto = 0;
        bool paso = false, Arreglar = false;
        Factura billes = new Factura();
        List<FacturaDetalle> Detalle = new List<FacturaDetalle>();
        public int RowSelected { get; set; }

        public rFacturacion()
        {
            InitializeComponent();
            LlenarComboBox();
            //todo: descomentar el codigo en el constructor de la facturacion cuando la ventana login este programada.
            // UsuariotextBox.Text = BLL.FacturacionBLL.returnUsuario().Nombre;
        }


        //listo esto es el boton nuevo
        private void NUevobutton_Click(object sender, EventArgs e)
        {
            Clean();
        }
        //listo esto limpia la ventana
        private void Clean()
        {

            IDcomboBox.Text = string.Empty;
            CLienteIDcomboBox.Text = string.Empty;
            FormaDePagocomboBox.Text = string.Empty;
            DescripciponFacturatextBox.Clear();
            LimpiarProducto();
            NombreCLientetextBox.Text = string.Empty;
            EfectivonumericUpDown.Value = 0;
            DevueltatextBox.Text = "0";
            MontotextBox.Text = "0";
            LimpiarProvider();
            FacturadataGridView.DataSource = null;
            billes.BillDetalle = new List<FacturaDetalle>();
            Monto = 0;
            DetallecomboBox.Text = string.Empty;
            DetallecomboBox.Enabled = false;
            EliminarDetalle.Enabled = false;
            FechadateTimePicker.Value = DateTime.Now;
            Detalle = new List<FacturaDetalle>();
            paso = true;
            Arreglar = true;

        }
        //listo esto limpia los errores providers
        private void LimpiarProvider()
        {
            IDerrorProvider.Clear();
            DemaserrorProvider.Clear();
            ProductoerrorProvider.Clear();
        }
        // Esto llena el combo box de forma de pago
        private void LlenarComboBox()
        {
            FormaDePagocomboBox.Items.Clear();
            FormaDePagocomboBox.Items.Add("Credito");
            FormaDePagocomboBox.Items.Add("Contado");
            DevueltatextBox.Text = "0";
            MontotextBox.Text = "0";
            IDcomboBox.Items.Clear();
            CLienteIDcomboBox.Items.Clear();
            ProductoIdcomboBox.Items.Clear();

            foreach (var item in BLL.ProductoBLL.Buscar())
            {
                ProductoIdcomboBox.Items.Add(item.Idproducto);
            }
            foreach (var item in BLL.FacturacionBLL.Buscar())
            {
                IDcomboBox.Items.Add(item.FacturaId);
            }
            foreach (var item in BLL.ClienteBLL.Buscar())
            {
                CLienteIDcomboBox.Items.Add(item.IdCliente);
            }


        }
        //listo Eso maneja la validacion
        private bool SetError(int error)
        {
            bool paso = false;
            if (error == 1 && IDcomboBox.Text == string.Empty)
            {
                IDerrorProvider.SetError(IDcomboBox, "Llenar Id");
                paso = true;
            }

            if (error == 2 && CLienteIDcomboBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(CLienteIDcomboBox, "Llenar Cliente Id");
                paso = true;
            }
            if (error == 2 && FormaDePagocomboBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(FormaDePagocomboBox, "Llenar Forma de pago");
                paso = true;
            }
            if (error == 2 && DescripciponFacturatextBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(DescripciponFacturatextBox, "Llenar descripcion");
                paso = true;
            }
            if (error == 2 && DescripciponFacturatextBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(DescripciponFacturatextBox, "Llenar descripcion");
                paso = true;
            }
            if (error == 2 && EfectivonumericUpDown.Value == 0 && FormaDePagocomboBox.SelectedIndex != 0 && Convert.ToInt32(DevueltatextBox.Text) < Convert.ToInt32(MontotextBox.Text))
            {
                DemaserrorProvider.SetError(EfectivonumericUpDown, "Llenar Efectivo de caja");
                paso = true;
            }
            if (error == 3 && ProductoIdcomboBox.Text == string.Empty)
            {
                ProductoerrorProvider.SetError(ProductoIdcomboBox, " Llenar id producto");
                paso = true;
            }
            if (error == 4 && DetallecomboBox.Text == string.Empty)
            {
                ProductoerrorProvider.SetError(DetallecomboBox, " Llenar id producto");
                paso = true;
            }
            if (error == 5 && Convert.ToDecimal(DevueltatextBox.Text) < 0)
            {
                DemaserrorProvider.SetError(DevueltatextBox, "Posible perdida, Arreglar efectivo recibido");
                paso = true;
            }
            if (error == 6 && ProductoIdcomboBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(ProductoIdcomboBox, "Debe de buscar antes de agregar!");
                paso = true;
            }
            if (error == 7 && CantidadnumericUpDown.Value == 0)
            {
                DemaserrorProvider.SetError(CantidadnumericUpDown, "Debe de agregar una cantidad andes de agregar!");
                paso = true;
            }



            return paso;
        }
        //listo Esto limpia algunas casillas de la ventana
        private void LimpiarProducto()
        {
            LimpiarProvider();
            CantidadnumericUpDown.Value = 0;
            DescripcionProductotextBox.Clear();
            ProductoIdcomboBox.Text = string.Empty;
            PreciotextBox.Clear();
            ImportetextBox.Clear();
            DetallecomboBox.Text = string.Empty;
        }
        //listo Esto asigna a el textbox del cliente el nombre correspondiente 
        private void CLienteIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarProvider();
            foreach (var item in BLL.ClienteBLL.Buscar())
            {
                if (item.IdCliente == Convert.ToInt32(CLienteIDcomboBox.Text))
                {
                    NombreCLientetextBox.Text = item.Nombre;
                }

            }

        }
        //listo Este metodo elimina un detalle de la lista
        private void EliminarDetalle_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Eliminar el detalle seleccionado?", "+Ventas",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (RowSelected >= 0)
                {
                    Monto -= BLL.FacturacionBLL.RecalcularImporte(billes.BillDetalle, RowSelected);
                    MontotextBox.Text = Monto.ToString();
                    Arreglar = true;
                    FacturaDetalle factura = billes.BillDetalle.ElementAt(RowSelected);
                    Detalle.Add(new FacturaDetalle(factura.Id, factura.FacturaId, factura.ProductoId, factura.Cantidad, factura.Precio, factura.Descripcion, factura.Importe));
                    billes.BillDetalle.RemoveAt(RowSelected);
                    FacturadataGridView.DataSource = null;
                    FacturadataGridView.DataSource = billes.BillDetalle;
                    RowSelected = -1;
                    if (paso)
                    {
                        AsignarDevuelta();
                    }
                    MessageBox.Show("Eliminado!");
                }


            }

            if(billes.BillDetalle.Count()==0)
            {
                EliminarDetalle.Enabled = false;
            }
        }
        //listo Esto le asigna el valor del importe 
        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(6))
            {
                MessageBox.Show("Debe Buscar Antes de poner una cantidad");
                CantidadnumericUpDown.Value = 0;
                return;
            }


            ImportetextBox.Text = BLL.FacturacionBLL.Importedemas(CantidadnumericUpDown.Value, Convert.ToDecimal(PreciotextBox.Text)).ToString();
        }
        //listo Esto asigna la devuelta
        private void EfectivonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AsignarDevuelta();
        }
        //listo  esto hace el calculo de l adevuelta
        private void AsignarDevuelta()
        {
            DevueltatextBox.Text = BLL.FacturacionBLL.RetornarDevuelta(EfectivonumericUpDown.Value, Convert.ToDecimal(MontotextBox.Text)).ToString();
        }
        //listo esto agrega a la lista de detalle los productos 
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(6) || SetError(7))
            {
                MessageBox.Show("Debe de completar los campos marcados");
                return;
            }
            int cantidad = 0;
            foreach (var item in BLL.ProductoBLL.Buscar())
            {
                if (item.Idproducto == Convert.ToInt32(ProductoIdcomboBox.Text))
                {
                    cantidad = item.Cantidad;
                }
            }


            if (cantidad - Convert.ToInt32(CantidadnumericUpDown.Value) < 0)
            {

                MessageBox.Show("Cantidad insuficiente del producto solicitado");
                MessageBox.Show("Disponibles " + cantidad);
                return;
            }
            if (IDcomboBox.Text == string.Empty)
            {
                billes.BillDetalle.Add(new FacturaDetalle(0, billes.FacturaId, Convert.ToInt32(ProductoIdcomboBox.Text), Convert.ToInt32(CantidadnumericUpDown.Value), Convert.ToDecimal(PreciotextBox.Text), DescripcionProductotextBox.Text, Convert.ToDecimal(ImportetextBox.Text)));

            }
            else
            {
                //int idfactura = Convert.ToInt32(IDcomboBox.Text);
                if (billes.BillDetalle.Count == 0)
                {
                    billes.BillDetalle = BLL.FacturaDetalleBLL.BuscarFacturaID(IDcomboBox.Text);
                }
                if (DetallecomboBox.Text == string.Empty)
                {
                    var Idproducto = Convert.ToInt32(ProductoIdcomboBox.Text);
                    if (billes.BillDetalle.Exists(x => x.ProductoId == Idproducto))
                    {
                        foreach (var item in billes.BillDetalle)
                        {
                            if (item.ProductoId == Idproducto)
                            {
                                item.Cantidad += Convert.ToInt32(CantidadnumericUpDown.Value);
                            }
                        }
                    }
                    else
                    {
                        billes.BillDetalle.Add(new FacturaDetalle(0, Convert.ToInt32(IDcomboBox.Text), Convert.ToInt32(ProductoIdcomboBox.Text), Convert.ToInt32(CantidadnumericUpDown.Value), Convert.ToDecimal(PreciotextBox.Text), DescripcionProductotextBox.Text, Convert.ToDecimal(ImportetextBox.Text)));
                    }
                }
                else
                {
                    Monto -= BLL.FacturacionBLL.DescontarImporte(billes.BillDetalle, Convert.ToInt32(DetallecomboBox.Text));

                    foreach (var item in billes.BillDetalle)
                    {
                        item.Importe = BLL.FacturacionBLL.Importe(item.Cantidad, CantidadnumericUpDown.Value, item.Precio, Convert.ToInt32(ProductoIdcomboBox.Text), item.ProductoId);
                    }
                    billes.BillDetalle = BLL.FacturacionBLL.Editar(billes.BillDetalle, new FacturaDetalle(Convert.ToInt32(DetallecomboBox.Text), Convert.ToInt32(IDcomboBox.Text), Convert.ToInt32(ProductoIdcomboBox.Text), Convert.ToInt32(CantidadnumericUpDown.Value), Convert.ToDecimal(PreciotextBox.Text), DescripcionProductotextBox.Text, Convert.ToDecimal(ImportetextBox.Text)));
                }

            }

            Monto += BLL.FacturacionBLL.CalcularMonto(Convert.ToDecimal(ImportetextBox.Text));
            MontotextBox.Text = Monto.ToString();
            if (paso)
            {
                AsignarDevuelta();
            }
            FacturadataGridView.DataSource = null;
            FacturadataGridView.DataSource = billes.BillDetalle;
            DetallecomboBox.Enabled = true;
            LimpiarProducto();
            LlenarDetalleComboBox();
            EliminarDetalle.Enabled = true;
        }
        //Listo esto activa y desactiva el numericUpDown de efectivo 
        private void FormaDePagocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormaDePagocomboBox.SelectedIndex == 0)
            {
                EfectivonumericUpDown.Enabled = false;
                paso = false;
            }
            else
            {
                EfectivonumericUpDown.Enabled = true;
                paso = true;
            }
        }
        // listo Esto permite seleccionar un detalle del DataGridView para modificarlo
        private void DetallecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID;

            //id = Convert.ToInt32(IDcomboBox.Text);
            ID = Convert.ToInt32(DetallecomboBox.Text);
            if (billes.BillDetalle.Count() == 0)
            {
                billes.BillDetalle = BLL.FacturaDetalleBLL.Buscar(IDcomboBox.Text);
            }
            foreach (var item in billes.BillDetalle)
            {
                if (item.Id == ID)
                {
                    DescripcionProductotextBox.Text = item.Descripcion;
                    PreciotextBox.Text = item.Precio.ToString();
                    ProductoIdcomboBox.Text = item.ProductoId.ToString();
                    CantidadnumericUpDown.Value = item.Cantidad;
                }
            }

            //DescripcionProductotextBox.Text = BLL.FacturaDetalleBLL.BuscarDetalle(id, ID).Descripcion;
            //PreciotextBox.Text = BLL.FacturaDetalleBLL.BuscarDetalle(id, ID).Precio.ToString();
            //ProductoIdcomboBox.Text = BLL.FacturaDetalleBLL.BuscarDetalle(id, ID).ProductoId.ToString();
            //CantidadnumericUpDown.Value = BLL.FacturaDetalleBLL.BuscarDetalle(id, ID).Cantidad;

        }
        //listo Esto permite seleccionar un producto de comboBox
        private void ProductoIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarProvider();
            CantidadnumericUpDown.Value = 0;
            ImportetextBox.Clear();
            int id = Convert.ToInt32(ProductoIdcomboBox.Text);

            foreach (var item in BLL.ProductoBLL.Buscar())
            {
                if (item.Idproducto == id)
                {
                    DescripcionProductotextBox.Text = item.Descripcion;
                    PreciotextBox.Text = item.Precio.ToString();
                }
            }
        }
        //listo Este es el llena clase
        private Factura LlenaClase()
        {
            Factura bill = new Factura();
            if (IDcomboBox.Text == string.Empty)
            {
                bill.FacturaId = 0;
            }
            else
            {
                bill.FacturaId = Convert.ToInt32(IDcomboBox.Text);
            }


            bill.ClienteId = Convert.ToInt32(CLienteIDcomboBox.Text);
            bill.UsuarioId = BLL.FacturacionBLL.returnUsuario().IdUsuario;
            bill.Fecha = FechadateTimePicker.Value.ToString("yyyy-MM-dd");
            bill.FormaDePago = FormaDePagocomboBox.Text;
            bill.Descripcion = DescripciponFacturatextBox.Text;
            bill.EfectivoRecibido = EfectivonumericUpDown.Value;
            bill.Monto = Convert.ToDecimal(MontotextBox.Text);

            bill.Devuelta = Convert.ToDecimal(DevueltatextBox.Text);

            bill.BillDetalle = billes.BillDetalle;

            return bill;
        }
        //listo esto devuelve cual celda o fila del datagridview esta seleccionada
        private void FacturadataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowSelected = e.RowIndex;
        }
        // Listo, metodo Guardar y modificar 
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(2))
            {
                MessageBox.Show("Llenar Campos vacios");
                return;
            }
            if (SetError(5) == true && FormaDePagocomboBox.SelectedIndex != 0)
            {
                MessageBox.Show("Arreglar devolucion");
                return;
            }

            Factura bill = LlenaClase();
            if (IDcomboBox.Text == string.Empty)
            {
                if (BLL.FacturacionBLL.Guardar(bill) && BLL.FacturaDetalleBLL.Guardar(bill.BillDetalle))
                {
                    MessageBox.Show("Guardado!!");
                    LlenarComboBox();
                    BLL.FacturacionBLL.DescontarProductos(billes.BillDetalle);
                    var result = MessageBox.Show("Desea Imprimir un recibo?", "+Ventas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //La variable mayor me devuelve la ultima factura realizada para poder imprimirla
                        //int mayor = BLL.FacturacionBLL.Mayor(BLL.FacturacionBLL.GetList(y => true));
                        //ReporteFacturasCliente abrir = new ReporteFacturasCliente(BLL.FacturacionBLL.GetList(x => x.FacturaId == mayor));
                        //abrir.Show();
                    }
                    Clean();
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar!!");
                }



            }
            else
            {
                var result = MessageBox.Show("Seguro de Modificar?", "+Ventas",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    BLL.FacturacionBLL.DescontarBuscando(LlenaClase().BillDetalle, IDcomboBox.Text);
                    if (BLL.FacturacionBLL.Modificar(LlenaClase()))
                    {
                        if (LlenaClase().BillDetalle.Count() > 0)
                            BLL.FacturaDetalleBLL.Modificar(LlenaClase().BillDetalle);



                        MessageBox.Show("Modificado!!");

                        if (Detalle.Count != 0)
                        {
                            foreach (var item in Detalle)
                            {
                                BLL.FacturaDetalleBLL.Eliminar(item.Id.ToString());

                            }

                        }
                        if (Arreglar)
                        {
                            BLL.FacturacionBLL.ArreglarProductoList(Detalle);
                            Arreglar = false;
                        }


                        var resultado = MessageBox.Show("Desea Imprimir un recibo?", "+Ventas",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            int id = LlenaClase().FacturaId;
                            //todo:  para Albert: Hacer reportes
                            //  ReporteFacturasCliente abrir = new ReporteFacturasCliente(BLL.FacturacionBLL.GetList(x => x.FacturaId == id));
                            //abrir.Show();

                        }
                        Clean();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar!!");
                    }
                }
            }
        }
        //listo metodo eliminar
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(1))
            {
                MessageBox.Show("Llenar campos Vacios");
                return;
            }
            var result = MessageBox.Show("Seguro de  Eliminar?", "+Ventas",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                foreach (var item in BLL.FacturacionBLL.Buscar())
                {
                    if (item.FacturaId == Convert.ToInt32(IDcomboBox.Text))
                    {
                        BLL.FacturacionBLL.ArreglarProducto(item.FacturaId.ToString());
                    }

                }

                var eliminar = BLL.FacturaDetalleBLL.BuscarFacturaID(IDcomboBox.Text);

                if (BLL.FacturacionBLL.Eliminar(IDcomboBox.Text) && BLL.FacturaDetalleBLL.Eliminar(eliminar))
                {
                    MessageBox.Show("Eliminado");
                    IDcomboBox.DataSource = null;
                    LlenarComboBox();
                    Clean();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }

            }
        }
        // listo metodo buscar
        private void IDcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LimpiarProvider();
            //int idfactura = Convert.ToInt32(IDcomboBox.Text);


            foreach (var item in BLL.FacturacionBLL.Buscar())
            {
                billes.Descripcion = item.Descripcion;
                billes.Devuelta = item.Devuelta;
                billes.EfectivoRecibido = item.EfectivoRecibido;
                billes.FacturaId = item.FacturaId;
                billes.Fecha = item.Fecha;
                billes.FormaDePago = item.FormaDePago;
                billes.Monto = item.Monto;
                billes.UsuarioId = item.UsuarioId;
                billes.ClienteId = item.ClienteId;


            }
            CLienteIDcomboBox.Text = billes.ClienteId.ToString();
            FormaDePagocomboBox.Text = billes.FormaDePago;
            DescripciponFacturatextBox.Text = billes.Descripcion;
            DevueltatextBox.Text = billes.Devuelta.ToString();
            MontotextBox.Text = billes.Monto.ToString();
            Monto = billes.Monto;
            FechadateTimePicker.Value = Convert.ToDateTime(billes.Fecha);
            EfectivonumericUpDown.Value = billes.EfectivoRecibido;
            billes.BillDetalle = BLL.FacturaDetalleBLL.BuscarFacturaID(IDcomboBox.Text);
            LlenarDetalleComboBox();
            if (billes.BillDetalle.Count() > 0)
            {
                DetallecomboBox.Enabled = true;
                EliminarDetalle.Enabled = true;

            }
            foreach (var item in billes.BillDetalle)
            {
                item.Importe = BLL.FacturacionBLL.Importedemas(item.Cantidad, item.Precio);
            }
            FacturadataGridView.DataSource = billes.BillDetalle;
            Detalle = new List<FacturaDetalle>();
            //billes.BillDetalle = new List<FacturaDetalle>();
            //busco = true;
        }
        // listo llena Detalle Comobobox
        private void LlenarDetalleComboBox()
        {
            DetallecomboBox.Items.Clear();
            foreach (var item in billes.BillDetalle)
            {
                DetallecomboBox.Items.Add(item.Id);
            }
        }
    }


}
