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
        }

        private void BTNregistros_Click(object sender, EventArgs e)
        {
            FRMregistros fr = new FRMregistros();
            fr.ShowDialog();
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            Curp _curp = null;

            if (ValidaCampos())
            {
                try
                {
                    char[] sexo = CBOsexo.SelectedText.ToCharArray();
                    string curp = _curp.ObtenCurp(TXTnombre.Text, TXTappat.Text, TXTapmat.Text,
                        sexo[0], DTPnac.ToString(), Clases.Funciones.ParseEstados(CBOedonac.SelectedText));
                    TXTcurp.Text = curp;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(MSG_ERROR_CURP, MSG_ERROR_GENERAL, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.Write("ERROR: " + exception.Message);
                }
                
            }
        }

        // ################## Inicializaciones #################
        private void IniSexo()
        {
            CBOsexo.Items.Insert(0, "- Seleccionar -");
            CBOsexo.Items.Insert(1, "Hombre");
            CBOsexo.Items.Insert(2, "Mujer");
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
