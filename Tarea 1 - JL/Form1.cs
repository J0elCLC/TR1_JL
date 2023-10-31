using EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1___JL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var objpedidobe = new pedido
            {

                fecha_registro = dateTimePicker1.Value,
                precio_venta = int.Parse(textBox2.Text),
                activo = true
            };

            void CargaCancha()
            {
                var objproductobl = new producto();
                var canchas = objproductobl.ListarActivas();
                comboBox1.Items.AddRange(producto.ToArray());
                comboBox1.ValueMember = "id_producto";
                comboBox1.DisplayMember = "nombre";
            }
        }
    }
}
