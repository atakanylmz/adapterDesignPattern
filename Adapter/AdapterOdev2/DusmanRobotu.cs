using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOdev2
{
    public class DusmanRobotu : IYeniNesilDusman
    {
        public string RobotIsim()
        {
            return " Terminatör ";
        }

        public string YumrukAt()
        {
            return "yumruk atıyor";
        }

        public string Yuru()
        {
            return "yürüyor";
        }
    }
}
