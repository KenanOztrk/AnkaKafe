using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkaKafe.UI
{
   public class MasaTasındıEventArgs: EventArgs
    {
        public int EskiMasaNo { get; private set; }
        public int YeniMasaNo { get; private set; }

        public MasaTasındıEventArgs( int eskiMasaNo, int yeniMasaNo)
        {
            EskiMasaNo = eskiMasaNo;
            YeniMasaNo = yeniMasaNo;
        }
    }
}
