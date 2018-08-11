using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOdev2
{
    public class DusmanTank : IDusman
    {
        public string DusmanAdi()
        {
            return " Tiger Tank ";
        }

        public string Hizlan()
        {
            return " hızlanıyor ";
        }

        public string SilahKullan()
        {
            return " silah kullanıyor ";
        }
    }
}
