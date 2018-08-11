using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterOdev2
{
    public class Adapter : IDusman
    {
        public IYeniNesilDusman AdapteDusman;
        public Adapter(IYeniNesilDusman AdapteOlacak)
        {
            this.AdapteDusman = AdapteOlacak;
        }
        public string DusmanAdi()
        {
            return AdapteDusman.RobotIsim();
        }

        public string Hizlan()
        {
            return AdapteDusman.Yuru();
        }

        public string SilahKullan()
        {
            return AdapteDusman.YumrukAt();
        }
    }
}
