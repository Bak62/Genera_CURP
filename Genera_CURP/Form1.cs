using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Critza.Bibliotecas;
using Genera_CURP.Modelos;
using static Genera_CURP.Clases.Constantes;

namespace Genera_CURP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniSexo();
            LoadCBOedonac();
            LoadCBOedo();
        }

        private void BTNregistros_Click(object sender, EventArgs e)
        {
            FRMregistros fr = new FRMregistros();
            fr.ShowDialog();
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            Curp _curp = new Curp();

            if (ValidaCampos())
            {
                try
                {
                    char[] sexo = CBOsexo.SelectedItem.ToString().ToCharArray();
                    Debug.WriteLine(">>> " + sexo[0].ToString()[0] + " - " + DTPnac.Value.ToString("dd/MM/yyyy") + " - " + CBOedonac.Text + " - " + Clases.Funciones.ParseEstados(CBOedonac.Text));
                    string curp = _curp.ObtenCurp(TXTnombre.Text, TXTappat.Text, TXTapmat.Text, sexo[0], DTPnac.Value.ToString("dd/MM/yyyy"), Clases.Funciones.ParseEstados(CBOedonac.Text));
                    TXTcurp.Text = curp;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(MSG_ERROR_CURP, MSG_ERROR_GENERAL, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.Write("ERROR: " + exception.Message);
                }
                
            }
        }

        private void BTNguardar_Click(object sender, EventArgs e)
        {
            char[] sexo = CBOsexo.SelectedItem.ToString().ToCharArray();
            tbPersona pers = new tbPersona();
            pers.nombre = TXTnombre.Text;
            pers.apellido1 = TXTappat.Text;
            pers.apellido2 = TXTapmat.Text;
            pers.fnacimiento = DTPnac.Value;
            pers.sexo = sexo[0].ToString();
            pers.edonac = CBOedonac.SelectedIndex + 1;
            pers.telefono = TXTtellocal.Text;
            pers.celular = TXTtelcel.Text;
            pers.edoact = CBOedo.SelectedIndex + 1;
            pers.delact = TXTdelegacion.Text;
            pers.colact = TXTcolonia.Text;
            pers.calleact = TXTcalle.Text;
            pers.numact = TXTnumero.Text;
            bool r = Clases.CRUD.SavePersona(pers);
            if (r)
                MessageBox.Show(MSG_GUARDADO_OK);
            else
                MessageBox.Show(MSG_GUARDADO_ERROR);
        }



        // ################## Inicializaciones #################
        private void IniSexo()
        {
            CBOsexo.Items.Insert(0, "- Seleccionar -");
            CBOsexo.Items.Insert(1, "Hombre");
            CBOsexo.Items.Insert(2, "Mujer");
            CBOsexo.SelectedIndex = 0;
        }

        private void LoadCBOedonac()
        {
            using (bdCURPEntities _entity = new bdCURPEntities())
            {
                List<Estados> _estados = new List<Estados>();
                _estados = _entity.tbEstados.Select(x => new Estados
                {
                    id = x.id,
                    nombre = x.nombre
                }).ToList();

                var bindingSourceEdos = new BindingSource();
                bindingSourceEdos.DataSource = _estados;

                CBOedonac.DataSource = bindingSourceEdos.DataSource;
                CBOedonac.DisplayMember = "nombre";
                CBOedonac.ValueMember = "id";
            }
        }

        private void LoadCBOedo()
        {
            using (bdCURPEntities _entity = new bdCURPEntities())
            {
                List<Estados> _estados = new List<Estados>();
                _estados = _entity.tbEstados.Select(x => new Estados
                {
                    id = x.id,
                    nombre = x.nombre
                }).ToList();

                var bindingSourceEdos = new BindingSource();
                bindingSourceEdos.DataSource = _estados;

                CBOedo.DataSource = bindingSourceEdos.DataSource;
                CBOedo.DisplayMember = "nombre";
                CBOedo.ValueMember = "id";
            }
        }

        // ################## Validaciones ##################

        private bool ValidaCampos()
        {
            if (String.IsNullOrEmpty(TXTnombre.Text))
            {
                MessageBox.Show(MSG_ERROR_NOMBRE, MSG_ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrEmpty(TXTappat.Text))
            {
                MessageBox.Show(MSG_ERROR_APPAT, MSG_ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrEmpty(TXTtellocal.Text))
            {
                MessageBox.Show(MSG_ERROR_TELLOCAL, MSG_ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrEmpty(TXTtelcel.Text))
            {
                MessageBox.Show(MSG_ERROR_TELCEL, MSG_ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrEmpty(TXTcalle.Text))
            {
                MessageBox.Show(MSG_ERROR_CALLE, MSG_ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrEmpty(TXTcolonia.Text))
            {
                MessageBox.Show(MSG_ERROR_COLONIA, MSG_ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrEmpty(TXTnumero.Text))
            {
                MessageBox.Show(MSG_ERROR_NUMERO, MSG_ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (String.IsNullOrEmpty(TXTdelegacion.Text))
            {
                MessageBox.Show(MSG_ERROR_DELEG, MSG_ERROR_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (CBOsexo.SelectedIndex == 0)
            {
                MessageBox.Show(MSG_ERROR_DELEG, MSG_ERROR_SEXO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        
    }
}
