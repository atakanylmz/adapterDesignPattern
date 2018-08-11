using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOdev2
{
    public class Oyun
    {
        public string Oyna(IDusman Dusman)
        {
            return Dusman.DusmanAdi()+" "+Dusman.Hizlan()+" "+Dusman.SilahKullan();
        }
    }
}
