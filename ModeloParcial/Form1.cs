using BLL;
using DAL;
using Entity;

namespace ModeloParcial
{
   public partial class Form1 : Form
   {
      private EntradaBusiness entradaBusiness = new EntradaBusiness();
      private TipoTurismoBusiness tipoTurismoBusiness = new TipoTurismoBusiness();
      public Form1()
      {
         InitializeComponent();
         this.Load += new System.EventHandler(this.Form1_Load);
         entradaBusiness = new EntradaBusiness();
      }
      private void Form1_Load(object? sender, EventArgs e)
      {
         actualizarDgv();
         cmbTipoTurismo.DataSource = null;
         cmbTipoTurismo.DataSource = tipoTurismoBusiness.getAll();
         cmbTipoTurismo.ValueMember = "IdTipoTurismo";
         cmbTipoTurismo.DisplayMember = "Descripcion";

      }


      private void btnAltaEntrada_Click(object sender, EventArgs e)
      {
         try
         {

            Entrada entrada = new Entrada();
            entrada.IdTipoTurismo = Convert.ToInt32(cmbTipoTurismo.SelectedValue);
            entrada.DniPasaporte = txtDNIPasaporte.Text;
            entrada.Monto = Convert.ToDouble(txtMonto.Text);
            entrada.FechaValidez = dateTimePicker1.Value;
            entradaBusiness.guardarEntrada(entrada);
            actualizarDgv();
            MessageBox.Show("Entrada guardada correctamente");

            MessageBox.Show("Entrada guardada correctamente.");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void actualizarDgv()
      {
         dgvNuevaEntrada.DataSource = null;
         dgvNuevaEntrada.DataSource = entradaBusiness.getAll();
      }

      private void btnEliminarEntrada_Click(object sender, EventArgs e)
      {
         try
         {
            entradaBusiness.EliminarEntrada(Convert.ToInt32(txtIdEntrada.Text));
            actualizarDgv();
            MessageBox.Show("Entrada eliminada correctamente");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

      }
      private void btnModificar_Click(object sender, EventArgs e)
      {
         try
         {
            entradaBusiness.ExtenderVigencia(Convert.ToInt32(txtExtenderVigencia.Text), dateTimePicker2.Value);
            actualizarDgv();
            MessageBox.Show("Entrada modificada correctamente");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }


      }

   }
}
