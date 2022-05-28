using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class PatientInfo
    {

        public string ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }


        public string TC { get; set; }
        public int DoktorID { get; set; }

        public Doctor Doctor { get; set; }

        public int PolID { get; set; }
        public Service Service { get; set; }

        public string Durum { get; set; }
        public string Gender { get; set; }
        public DateTime KayitTarihi { get; set; }



    }
}
