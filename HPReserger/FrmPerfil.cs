using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class FrmPerfil : Form
    {
        HPResergerCapaLogica.HPResergerCL cperfil = new HPResergerCapaLogica.HPResergerCL();
        
        public int codigo { get; set; }
        public int estado { get; set; }
        public string descripcion { get; set; }
        public FrmPerfil()
        {
            InitializeComponent();
        }
        
        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            estado = 0;          
            dtgperfil.DataSource = cperfil.getCargoTipoContratacion("Codgo_perfil_User","desc_perfil_user","TBL_PERFIL_USER");
            dtgperfil.Focus();

        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux =true;
            for (int i = 0;i< dtgperfil.RowCount; i++)
            {
                if (dtgperfil[1, i].Value.ToString() == valor)
                {
                    Aux = false;
                    MessageBox.Show("Este valor:"+txtdes.Text+" ya Existe","Hp Reserger",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return Aux;                    
                }
            }
            return Aux;
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgperfil.Enabled = false;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Descripción", txtdes,1000);
            txtcodigo.Text = txtdes.Text = "";                        
            estado = 1;
            Desactivar();
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Desactivar();
            estado = 2;
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender,e);            
        }
        
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            if (estado == 1&& ValidarDes(txtdes.Text)) {
                cperfil.AgregarPerfil(txtdes.Text.ToString());                       
            }
            else {
                if (estado==2&&ValidarDes(txtdes.Text)){
                    cperfil.ActualizarPerfil(Convert.ToInt32(txtcodigo.Text), txtdes.Text.ToString());
                }
                else {
                    if (estado == 3) {
                        if (MessageBox.Show("Seguró Desea Eliminar " + txtdes.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString()=="Yes")
                            {
                            cperfil.EliminarPerfil(Convert.ToInt32(txtcodigo.Text));
                        }
                    }                    
                }
             }
            estado = 0;
            FrmPerfil_Load(sender, e);
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgperfil.Enabled = true;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                estado = 0;
                btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgperfil.Enabled = true;
                FrmPerfil_Load(sender, e);
            }
        }

        private void dtgperfil_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = dtgperfil[0, e.RowIndex].Value.ToString();
                txtdes.Text = dtgperfil[1, e.RowIndex].Value.ToString();
            }
            catch { }
        }
    }
}
