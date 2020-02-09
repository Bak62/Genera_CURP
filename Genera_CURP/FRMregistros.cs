using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Genera_CURP.Modelos;

namespace Genera_CURP
{
    public partial class FRMregistros : Form
    {
        public FRMregistros()
        {
            InitializeComponent();
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVregistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (bdCURPEntities _entity = new bdCURPEntities())
            {
                List<Personas> _personas = new List<Personas>();
                _personas = _entity.tbPersonas.Select(x => new Personas
                {
                    id = x.id,
                    nombre = x.nombre,
                    apellido1 =  x.apellido1,
                    apellido2 = x.apellido2
                }).ToList();
                DGVregistros.DataSource = _personas;
            }
        }
    }
}
