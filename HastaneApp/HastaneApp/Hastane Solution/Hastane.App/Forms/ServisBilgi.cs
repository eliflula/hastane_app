using System;
using System.Windows.Forms;
using MODEL;

namespace Hastane.App.Forms
{
    public partial class ServisBilgi : Form
    {
        private Service servis;
       

        public ServisBilgi(Service service)
        {
            InitializeComponent();
            servis = service;
        }

        private void ServisBilgi_Load(object sender, EventArgs e)
        {


           
        }
    }
}



        
        

