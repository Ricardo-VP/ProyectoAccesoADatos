using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos2.informes
{
    public partial class frmInformeMateriaMostrar : Form
    {
        private String mMateria;
        public frmInformeMateriaMostrar(String nMateria)
        {
            InitializeComponent();
            mMateria = nMateria;
        }

        private void frmInformeMateriaMostrar_Load(object sender, EventArgs e)
        {
            this.materiaxCodigoTableAdapter.FillMateriaxCodigo(this.dsMaterias.MateriaxCodigo, mMateria);
            this.reportViewer1.RefreshReport();
        }
    }
}
