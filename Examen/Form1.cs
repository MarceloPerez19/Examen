using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class frmSerieExamen : Form
    {
        public frmSerieExamen()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            long f = Examen.Serie.Facortial();
            long re = Examen.Serie.SerieExamen();
            this.txtNumero.Text = re.ToString();
            this.txtFactorial.Text = f.ToString();
        }

        private void txtFactorial_Load(object sender, EventArgs e)
        {

        }
    }
}
