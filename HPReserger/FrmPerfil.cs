using HpResergerUserControls;
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
    public partial class FrmPerfil : FormGradient
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
            dtgperfil.DataSource = cperfil.getCargoTipoContratacion("Codgo_perfil_User", "desc_perfil_user", "TBL_PERFIL_USER");
            dtgperfil.Focus();
            cboperfiles.ValueMember = "CODIGO";
            cboperfiles.DisplayMember = "DESCRIPCION";
            cboperfiles.DataSource = cperfil.getCargoTipoContratacion("Codgo_perfil_User", "desc_perfil_user", "TBL_PERFIL_USER");
            //CargarDAtosalTRee(0, 0, 0);
            //cboperfiles.SelectedIndex = 0;
        }
        TreeNode pap, ramita, ramon;
        public void CargarDAtosalTRee(int Perfile, int opcion, int codigo)
        {
            DataTable Tablita = new DataTable();
            Tablita = cperfil.ListarPerfiles(Perfile, opcion, codigo, frmLogin.CodigoUsuario, DateTime.Now);
            treePerfiles.Nodes.Clear();
            pap = ramita = ramon = null;
            foreach (DataRow filita in Tablita.Rows)
            {
                if (filita["titulo"].ToString().Length == 1)
                {
                    pap = new TreeNode((filita["modulo_opcion"].ToString()));
                    if ((int)filita["Checked"] == 1)
                    {
                        pap.Checked = true;
                    }
                    else pap.Checked = false;
                    pap.Tag = filita["titulo"];
                    treePerfiles.Nodes.Add(pap);
                }
                if (filita["titulo"].ToString().Length == 3)
                {
                    ramita = new TreeNode(filita["modulo_opcion"].ToString());
                    if ((int)filita["Checked"] == 1)
                    {
                        ramita.Checked = true; pap.Expand();
                    }
                    else ramita.Checked = false;
                    ramita.Tag = filita["titulo"];
                    pap.Nodes.Add(ramita);
                }
                if (filita["titulo"].ToString().Length == 5)
                {
                    ramon = new TreeNode(filita["modulo_opcion"].ToString());
                    if ((int)filita["Checked"] == 1)
                    {
                        ramon.Checked = true; ramita.Expand();
                    }
                    else ramon.Checked = false;
                    ramon.Tag = filita["titulo"];
                    ramita.Nodes.Add(ramon);
                }
            }
        }
        public Boolean ValidarDes(string valor)
        {
            Boolean Aux = true;
            if (cboperfiles.SelectedIndex >= 0)
                dtgperfil.CurrentCell = dtgperfil[1, cboperfiles.SelectedIndex];
            for (int i = 0; i < dtgperfil.RowCount; i++)
            {
                if (estado == 1)
                    if (dtgperfil[1, i].Value.ToString() == valor)
                    {
                        Aux = false;
                        MessageBox.Show("Este valor:" + txtdes.Text + " ya Existe", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return Aux;
                    }
                if (estado == 2)
                    if (dtgperfil[1, i].Value.ToString() == valor && i != cboperfiles.SelectedIndex)
                    {
                        Aux = false;
                        MessageBox.Show("Este valor:" + txtdes.Text + " ya Existe", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return Aux;
                    }
            }
            return Aux;
        }
        public void Activar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = true;
        }
        public void Desactivar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = false;
        }
        public void Desactivar()
        {
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgperfil.Enabled = false;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            tipmsg.Show("Ingrese Descripción", txtdes, 1000);
            txtcodigo.Text = txtdes.Text = "";
            estado = 1;
            Desactivar();
            Activar(txtdes);
            Desactivar(cboperfiles);
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Desactivar();
            estado = 2;

            Activar(txtdes);
            Desactivar(cboperfiles);
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones
            string cade = txtdes.Text;
            if (estado == 1 && ValidarDes(txtdes.Text))
            {
                cperfil.AgregarPerfil(txtdes.Text.ToString());
                DataRow fiConsultalita = cperfil.VerUltimoIdentificador("TBL_Perfil_User", "Codgo_Perfil_User");
                int ultimo = ((int)fiConsultalita["ultimo"]);
                cperfil.ListarPerfiles(ultimo, 10, 0, frmLogin.CodigoUsuario, DateTime.Now);
                foreach (TreeNode x in treePerfiles.Nodes)
                    RecorrerNodos(x, ultimo);
                Activar(cboperfiles);
                Desactivar(txtdes);
                MessageBox.Show("Insertado con exito", CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (estado == 2 && ValidarDes(txtdes.Text))
                {
                    cperfil.ActualizarPerfil(Convert.ToInt32(txtcodigo.Text), txtdes.Text.ToString());
                    cperfil.ListarPerfiles((int)cboperfiles.SelectedValue, 10, 0, frmLogin.CodigoUsuario, DateTime.Now);
                    foreach (TreeNode x in treePerfiles.Nodes)
                        RecorrerNodos(x, (int)cboperfiles.SelectedValue);
                    Activar(cboperfiles);
                    Desactivar(txtdes);
                    MessageBox.Show("Modificado con exito", CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar " + txtdes.Text, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            cperfil.EliminarPerfil(Convert.ToInt32(txtcodigo.Text));
                            cperfil.ListarPerfiles((int)cboperfiles.SelectedValue, 10, 0, frmLogin.CodigoUsuario, DateTime.Now);
                            Activar(cboperfiles);
                            Desactivar(txtdes);
                        }
                    }
                }
            }
            estado = 0;
            FrmPerfil_Load(sender, e);
            btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgperfil.Enabled = true;
            //MessageBox.Show(this.Parent.Name);
            ((frmMenu)this.MdiParent).RecargarMenu();
            cboperfiles.Text = cade;
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
                Activar(cboperfiles);
                Desactivar(txtdes);
            }
        }
        private void treePerfiles_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void treePerfiles_AfterCheck(object sender, TreeViewEventArgs e)
        {

            foreach (TreeNode x in e.Node.Nodes)
            {
                x.Checked = e.Node.Checked;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (TreeNode x in treePerfiles.Nodes)
            {
                foreach (TreeNode xx in x.Nodes)
                    MessageBox.Show(xx.FullPath);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void RecorrerNodos(TreeNode treeNode, int codigo)
        {
            // Print the node.         
            if (treeNode.Checked)
                cperfil.ListarPerfiles(codigo, 1, int.Parse(treeNode.Tag.ToString()), frmLogin.CodigoUsuario, DateTime.Now);
            // Print each node recursively.
            foreach (TreeNode tn in treeNode.Nodes)
            {
                RecorrerNodos(tn, codigo);
            }
        }

        private void treePerfiles_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            //    if (e.Node.Checked)
            //    {
            //        if (e.Node.Parent != null)
            //            e.Node.Parent.Checked = true;
            //    }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            treePerfiles.ExpandAll();
            btnocultar.BringToFront();
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            treePerfiles.CollapseAll();
            btnampliar.BringToFront();
        }

        private void dtgperfil_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboperfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboperfiles.Items.Count > 0)
            {
                txtcodigo.Text = cboperfiles.SelectedValue.ToString(); ;
                txtdes.Text = cboperfiles.Text;
                CargarDAtosalTRee(int.Parse(cboperfiles.SelectedValue.ToString()), 0, 0);
            }
            else CargarDAtosalTRee(0, 0, 0);
        }
    }
}
