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
    public partial class frmdinamicaContable : Form
    {
        public frmdinamicaContable()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CDinamica = new HPResergerCapaLogica.HPResergerCL();
        public int ejercicio { get; set; }
        public int codigo { get; set; }
        public int activo { get; set; }
        public int codope { get; set; }
        public int codsub { get; set; }
        public int nombre { get; set; }
        public int debe { get; set; }
        public int columna { get; set; }
        public int fila { get; set; }
        public int estado { get; set; }
        public int busca { get; set; }
        public string ValordeCaja { get; set; }
        public void Rellenaryear(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            for (int i = 1; i < 31; i++)
            {
                tablita.Rows.Add(new object[] { i + 2015, i + 2015 });
            }
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            combito.Text = DateTime.Today.Year.ToString();

        }
        public void RellenarEstado(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "1", "Activo" });
            tablita.Rows.Add(new object[] { "0", "Inactivo" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";

        }
        public void CargarOperacion(ComboBox combito)
        {
            combito.DataSource = CDinamica.getCargoTipoContratacion3("Id_Operacion", "Estado", "Operacion", "TBL_Operacion", "1");
            combito.DisplayMember = "DESCRIPCION";
            combito.ValueMember = "CODIGO";

        }
        public void CargarSubOperacion(ComboBox combito)
        {
            try
            {
                combito.DataSource = CDinamica.getCargoTipoContratacion6("Id_SubOperacion", "SubOperacion", "Id_Operacion", "Estado", "TBL_SubOperacion", cbooperacion.SelectedValue.ToString(), "1");
                combito.DisplayMember = "DESCRIPCION";
                combito.ValueMember = "CODIGO";
            }
            catch
            { }
        }
        public void ultimadinamica()
        {
            DataTable tablita = new DataTable();
            tablita = CDinamica.UltimaDinamica();
            DataRow filas = tablita.Rows[0];
            if (filas.ItemArray[0] != DBNull.Value)
            {
                codigo = Convert.ToInt32(filas.ItemArray[0]);
            }
            else { codigo = 0; }
        }
        public void Codigito(int codigo)
        {
            txtcodigo.Text = "DC_00" + codigo;
        }
        public DataTable ListarDinamicas(string busca, int opcion)
        {
            return CDinamica.ListarDinamicas(busca, opcion);
        }
        public int ValorBusqueda = 0;
        public Boolean Busqueda = false;
        private void frmdinamicaContable_Load(object sender, EventArgs e)
        {
            ultimadinamica();
            Codigito(codigo);
            fila = columna = 0;
            Rellenaryear(cboyear);
            RellenarEstado(cboestado);
            CargarOperacion(cbooperacion);
            CargarSubOperacion(cbosuboperacion);
            label5.Text = label5.Text.ToUpper();
            dtgbusca.DataSource = ListarDinamicas(Txtbusca.Text, ValorBusqueda);
            msgs(dtgbusca);
            DesactivarModi();
        }
        public void Mensajes(string text)
        {
            MessageBox.Show(text, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Dtgconten.RowCount > 0)
            {
                try
                {
                    Boolean pase = true;
                    dtgayuda.DataSource = CDinamica.BuscarCuentas(Dtgconten[0, Dtgconten.RowCount - 1].Value.ToString(), 1);
                    if (dtgayuda.RowCount != 1)
                    {
                        pase = false;
                        Dtgconten[1, Dtgconten.RowCount - 1].Value = Dtgconten[0, Dtgconten.RowCount - 1].Value = "";
                    }
                    else { pase = true; }
                    if (!string.IsNullOrWhiteSpace(Dtgconten[0, Dtgconten.RowCount - 1].Value.ToString()) && !string.IsNullOrWhiteSpace(Dtgconten[1, Dtgconten.RowCount - 1].Value.ToString()) && pase)
                    {
                        Dtgconten.Rows.Add();
                        DataTable tablita = new DataTable();
                        tablita.Columns.Add("CODIGO");
                        tablita.Columns.Add("VALOR");
                        tablita.Rows.Add(new object[] { "H", "HABER" });
                        tablita.Rows.Add(new object[] { "D", "DEBE" });
                        DataGridViewComboBoxColumn MarcaSColumn = Dtgconten.Columns["debehaber"] as DataGridViewComboBoxColumn;
                        MarcaSColumn.DataSource = tablita;
                        MarcaSColumn.ValueMember = "CODIGO";
                        MarcaSColumn.DisplayMember = "VALOR";
                        Dtgconten.CurrentCell = Dtgconten[0, Dtgconten.RowCount - 1];
                        Dtgconten.BeginEdit(true); aux = true;
                        fila++;
                        filamax++;
                    }
                    else
                    {
                    }
                }
                catch { Dtgconten.BeginEdit(true); Mensajes("Debe Ingresar Datos en la fila."); aux = false; }
            }
            else
            {
                Dtgconten.Rows.Add();
                DataTable tablita = new DataTable();
                tablita.Columns.Add("CODIGO");
                tablita.Columns.Add("VALOR");
                tablita.Rows.Add(new object[] { "H", "HABER" });
                tablita.Rows.Add(new object[] { "D", "DEBE" });
                DataGridViewComboBoxColumn MarcaSColumn = Dtgconten.Columns["debehaber"] as DataGridViewComboBoxColumn;
                MarcaSColumn.DataSource = tablita;
                MarcaSColumn.ValueMember = "CODIGO";
                MarcaSColumn.DisplayMember = "VALOR";
                Dtgconten.BeginEdit(true);
                fila++; filamax++;
            }

        }
        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex == 0)
                { //MODIFICAR LA COLUMNA DE CODIGOS
                    dtgayuda.DataSource = CDinamica.BuscarCuentas(Dtgconten[0, e.RowIndex].Value.ToString(), 1);
                    if (dtgayuda.RowCount == 1)
                    {
                        Dtgconten[1, e.RowIndex].Value = dtgayuda[0, 0].Value.ToString();
                        Dtgconten[2, e.RowIndex].Value = dtgayuda[1, 0].Value.ToString();
                        aux = true;
                    }
                    else
                    {
                        aux = false;
                    }
                }
                if (e.RowIndex > -1 && e.ColumnIndex == 1)
                {// MODIFICAR LA COLUMNA DE DESCRIPCIONES
                    dtgayuda.DataSource = CDinamica.BuscarCuentas(Dtgconten[1, e.RowIndex].Value.ToString(), 2);
                    if (dtgayuda.RowCount == 1)
                    {
                        Dtgconten[0, e.RowIndex].Value = dtgayuda[0, 0].Value.ToString();
                        Dtgconten[2, e.RowIndex].Value = dtgayuda[1, 0].Value.ToString();
                    }
                    else
                    {

                    }
                }
                if (e.RowIndex > -1 && e.ColumnIndex == 0)
                {//VERIFICAR QUE NO SE DUPLIQUEN CUENTAS
                    for (int i = 0; i < Dtgconten.RowCount - 1; i++)
                    {

                        if (Dtgconten[0, e.RowIndex].Value.ToString() == Dtgconten[0, i].Value.ToString() && i != e.RowIndex)
                        {
                            MessageBox.Show("No se pueden Repetir Cuenta", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Dtgconten.Rows.RemoveAt(Dtgconten.CurrentRow.Index); fila--;
                            break;
                        }
                    }
                }
            }
            catch { }
            msg(Dtgconten);
        }
        private void cboanalitica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
            }
            else { e.Handled = true; }
        }
        private void cbooperacion_TextChanged(object sender, EventArgs e)
        {
            CargarSubOperacion(cbosuboperacion);
        }
        private void Dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // string cadenita = Dtgconten[0, e.RowIndex].Value.ToString();
                btnmas.Focus();
                if (e.RowIndex > -1 && e.ColumnIndex == 0 && estado!=0)
                {
                    frmlistarcuentas cuentitas = new frmlistarcuentas();
                    if (Dtgconten[0, e.RowIndex].Value != null)
                    {
                        cuentitas.Txtbusca.Text = Dtgconten[0, e.RowIndex].Value.ToString();
                    }
                    else
                    { cuentitas.Txtbusca.Text = ""; }
                    cuentitas.radioButton1.Checked = true;
                    cuentitas.ShowDialog();
                    if (cuentitas.aceptar)
                    {
                        Dtgconten[0, e.RowIndex].Value = cuentitas.codigo;
                        btnmas.Focus();
                    }
                }
                if (e.RowIndex > -1 && e.ColumnIndex == 1 && estado != 0)
                {
                    frmlistarcuentas cuentitas = new frmlistarcuentas();
                    if (Dtgconten[1, e.RowIndex].Value != null)
                    {
                        cuentitas.Txtbusca.Text = Dtgconten[1, e.RowIndex].Value.ToString();
                    }
                    else { cuentitas.Txtbusca.Text = ""; }
                    cuentitas.radioButton2.Checked = true;
                    cuentitas.ShowDialog();
                    if (cuentitas.aceptar)
                    {
                        Dtgconten[0, e.RowIndex].Value = cuentitas.codigo;
                        btnmas.Focus();
                    }
                }
            }
            catch { }
            msg(Dtgconten);
        }
        private void Dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Desea Borrar esta fila", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fila--; filamax--;
                }
                else { e.Handled = true; msg(Dtgconten); }
            }
        }
        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            msg(Dtgconten);
        }
        public void msg(DataGridView conteo)
        {
            lblmsg.Text = "Total Registros: " + conteo.RowCount;
        }
        public void msgs(DataGridView conteo)
        {
            lblmsg2.Text = "Total Registros: " + conteo.RowCount;
        }
        private void Dtgconten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
            else { e.Handled = true; }
        }
        private void Dtgconten_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void cbosuboperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            aceptar = false;
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                if (estado == 1 && fila > 0)
                {
                    if (MessageBox.Show("Hay datos Ingresados, Desea Salir?", CompanyName ,MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        estado = 0;
                        Activar(); DesactivarModi();
                        ListarDinamicas(" ",ValorBusqueda);
                        Txtbusca.Enabled = false;
                        dtgbusca.Focus();
                    }
                    else { }
                }
                else
                {
                    if (estado == 2 && fila > 0)
                    {
                        if (MessageBox.Show("Hay datos Ingresados, Desea Salir?", CompanyName ,MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            estado = 0;
                            Activar(); DesactivarModi();
                            ListarDinamicas(" ",ValorBusqueda);
                            Txtbusca.Enabled = true;
                            dtgbusca.Focus();
                        }
                        else { Dtgconten.BeginEdit(true); }
                    }
                    else
                    {
                        estado = 0;
                        Activar(); DesactivarModi();
                        ListarDinamicas(" ", ValorBusqueda);
                        Txtbusca.Enabled = true;
                        dtgbusca.Focus();
                    }
                }
            }
        }
        public void Activar()
        {
            groupBox1.Enabled = btnlimpiar.Enabled = Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgbusca.Enabled = true;
        }
        public void Desactivar()
        {
            groupBox1.Enabled = btnlimpiar.Enabled = Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgbusca.Enabled = false;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            busca = 1; Txtbusca_TextChanged(sender, e);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            busca = 2; Txtbusca_TextChanged(sender, e);
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            busca = 3; Txtbusca_TextChanged(sender, e);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            busca = 4; Txtbusca_TextChanged(sender, e);
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            busca = 5; Txtbusca_TextChanged(sender, e);
        }
        private void label19_Click(object sender, EventArgs e)
        {

        }
        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            dtgbusca.DataSource = ListarDinamicas(Txtbusca.Text, busca);
            msgs(dtgbusca);
        }
        public int filamax;
        private void dtgbusca_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            codigo = Convert.ToInt32(dtgbusca[0, e.RowIndex].Value.ToString());
            Codigito(codigo);
            cboyear.Text = dtgbusca[1, e.RowIndex].Value.ToString();
            cbooperacion.Text = dtgbusca[3, e.RowIndex].Value.ToString();
            cbosuboperacion.Text = dtgbusca[5, e.RowIndex].Value.ToString();
            cboestado.SelectedValue = dtgbusca[9, e.RowIndex].Value.ToString();
            dtgayuda2.DataSource = CDinamica.SacarDinaminas(codigo.ToString());
            if (dtgayuda2.RowCount > 0)
            {
                Dtgconten.Rows.Clear(); filamax = 0;
                for (int i = 0; i < dtgayuda2.RowCount; i++)
                {
                    Dtgconten.Rows.Add();
                    DataTable tablita = new DataTable();
                    tablita.Columns.Add("CODIGO");
                    tablita.Columns.Add("VALOR");
                    tablita.Rows.Add(new object[] { "H", "HABER" });
                    tablita.Rows.Add(new object[] { "D", "DEBE" });
                    DataGridViewComboBoxColumn MarcaSColumn = Dtgconten.Columns["debehaber"] as DataGridViewComboBoxColumn;
                    MarcaSColumn.DataSource = tablita;
                    MarcaSColumn.ValueMember = "CODIGO";
                    MarcaSColumn.DisplayMember = "VALOR"; filamax++;
                    Dtgconten[0, i].Value = dtgayuda2[6, i].Value;
                    Dtgconten[2, i].Value = dtgayuda2[8, i].Value; fila++;
                }
            }
        }
        private void dtgayuda2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
            busca = 1; Txtbusca_TextChanged(sender, e);
        }
        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1; Desactivar(); fila = 0;
            Dtgconten.Rows.Clear();
            ultimadinamica();
            Codigito(codigo + 1); ActivarModi();
            cboestado.SelectedValue = 1;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            Desactivar();
            //Mensajes(codigo + "");
            ActivarModi();
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }
        private void cbooperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSubOperacion(cbosuboperacion);
        }
        private void Dtgconten_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Dtgconten_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }
        public void CargarValoresIngreso()
        {
            ejercicio = Convert.ToInt32(cboyear.SelectedValue);
            activo = Convert.ToInt32(cboestado.SelectedValue);
            codope = Convert.ToInt32(cbooperacion.SelectedValue);
            codsub = Convert.ToInt32(cbosuboperacion.SelectedValue);
        }
        public void MostrarValores(string cadena, int codigo)
        {
            MessageBox.Show("DATOS:\nEjercicio: " + ejercicio + "\tEstado; " + cboestado.Text + "\tCodigo CD_00" + codigo + "\nOperación: " + cbooperacion.Text
                + "\nSubOperación: " + cbosuboperacion.Text + "\nDINAMICA CONTABLE\n" + cadena
                , CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public string Detalle()
        {
            string cadena = "";
            for (int i = 0; i < fila; i++)
            {
                cadena += "CodigoCuenta: " + Dtgconten[0, i].Value + " Cuenta: " + Dtgconten[1, i].Value + " Debe:" + Dtgconten[2, i].Value + "\n";
            }
            return cadena;
        }
        public string Detalle2()
        {
            string cadena = "";
            for (int i = 0; i < Dtgconten.RowCount; i++)
            {
                cadena += "CodigoCuenta: " + Dtgconten[0, i].Value + " Cuenta: " + Dtgconten[1, i].Value + " Debe:" + Dtgconten[2, i].Value + "\n";
            }
            return cadena;
        }
        public Boolean aux;
        public void ActivarModi()
        {
            btnmas.Enabled = cboyear.Enabled = cboestado.Enabled = cbooperacion.Enabled = cbosuboperacion.Enabled = true;
            foreach (DataGridViewColumn col in Dtgconten.Columns)
                col.ReadOnly = false;
        }
        public void DesactivarModi()
        {
            btnmas.Enabled = cboyear.Enabled = cboestado.Enabled = cbooperacion.Enabled = cbosuboperacion.Enabled = false;
            foreach (DataGridViewColumn col in Dtgconten.Columns)
                col.ReadOnly = true;
        }
        public Boolean aceptar = false;
        public Boolean salida = true;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            aceptar = true;
            if (salida || estado != 0)
            {
                if (estado == 1)
                {
                    button1_Click(sender, e); Dtgconten.Rows.RemoveAt(fila - 1); fila--;
                }
                if (estado == 2)
                {
                    button1_Click(sender, e); Dtgconten.Rows.RemoveAt(Dtgconten.RowCount - 1); fila--;
                }
                //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones  
                if (estado == 1 && fila > 0 && aux)
                {
                    //string cadena = "";
                    CargarValoresIngreso();
                    //MostrarValores(cadena + Detalle(), codigo + 1);
                    Mensajes("Se Insertó con Exito");
                    estado = 0;
                    for (int i = 0; i < fila; i++)
                    {
                        CDinamica.InsertarDinamica(codigo + 1, ejercicio, codope, codsub,(Dtgconten[0, i].Value.ToString()), Dtgconten[2, i].Value.ToString(), activo);
                    }
                    //INGRESO DE REVERSA
                    //////////////////////////
                    Txtbusca.Text = (codigo + 1) + "";
                    dtgbusca.DataSource = ListarDinamicas(Txtbusca.Text, 1);
                    Activar(); DesactivarModi();
                }
                else
                {
                    if (estado == 2 && aux)
                    {
                        //string cadena = "";
                        CargarValoresIngreso();
                        //MostrarValores(cadena + Detalle2(), codigo);
                        Mensajes("Se Modificó con Exito");
                        estado = 0;
                        CDinamica.Modificar2Dinamica(codigo);
                        for (int i = 0; i < Dtgconten.RowCount; i++)
                        {
                            CDinamica.ModificarDinamica(codigo, ejercicio, codope, codsub, Dtgconten[0, i].Value.ToString(), Dtgconten[2, i].Value.ToString(), activo);
                        }
                        //MODIFICAR DE REVERSA
                        //////////////////////////
                        Txtbusca.Text = (codigo) + "";
                        dtgbusca.DataSource = ListarDinamicas(Txtbusca.Text, 1);
                        Activar(); DesactivarModi();
                    }
                    else
                    {
                        if (estado == 3)
                        {
                            if (MessageBox.Show("Seguró Desea Eliminar; Dinámica Contable: DC_0" + codigo, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                CDinamica.EliminarDinamica(codigo);
                                MessageBox.Show("Eliminado Exitosamente ", CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Txtbusca.Text = "";
                                dtgbusca.DataSource = ListarDinamicas(Txtbusca.Text, 1);

                            }
                        }
                    }
                }
            }
            else { this.Close(); }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgbusca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblmsg2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cboyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgbusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (dtgbusca.Rows.Count > 0)
            {
                if (dtgbusca.CurrentCell.RowIndex >= 0)
                {
                    if (e.KeyCode == Keys.Down)
                    {
                        //Tecla para Abajo
                        int x = dtgbusca.CurrentCell.RowIndex;
                        int cox = 0;
                        cox = (int)dtgbusca[0, x].Value;
                        for (int i = x; i < dtgbusca.RowCount; i++)
                        {
                            //Buscar Siguiente Codigo de Asiento;
                            if (cox != (int)dtgbusca[0, i].Value)
                            {
                                dtgbusca.CurrentCell = dtgbusca[0, i - 1];
                                break;
                            }
                        }
                    }
                    if (e.KeyCode == Keys.Up)
                    {
                        int x = dtgbusca.CurrentCell.RowIndex;
                        int cox = 0;
                        cox = (int)dtgbusca[0, x].Value;
                        for (int i = x; i > 0; i--)
                        {
                            //Buscar Siguiente Codigo de Asiento;
                            if (cox != (int)dtgbusca[0, i].Value)
                            {
                                dtgbusca.CurrentCell = dtgbusca[0, i];
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void cbooperacion_Click(object sender, EventArgs e)
        {
            string text = cbooperacion.Text;
            CargarOperacion(cbooperacion);
            cbooperacion.Text = text;
        }

        private void cbosuboperacion_Click(object sender, EventArgs e)
        {
            string text = cbosuboperacion.Text;
            CargarSubOperacion(cbosuboperacion);
            cbosuboperacion.Text = text;
        }
    }
}
