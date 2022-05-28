using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;

namespace Hastane.App.Forms
{
    public partial class KayıtSorgu : Form
    {
        private PatientInfo i;


        public KayıtSorgu(PatientInfo info)
        {
            InitializeComponent();
            i = info;
        }

        private void KayıtSorgu_Load(object sender, EventArgs e)
        {
           

        }
    }
}
