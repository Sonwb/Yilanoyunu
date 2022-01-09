using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Yılann
{
    public class yilan_kordinat
    {
        public int xKoordinat;
        public int yKoordinat;

        public yilan_kordinat(int x, int y)
        {
            xKoordinat = x;
            yKoordinat = y;
        }
    }

    public class yilan_yonu
    {
        public int xYon;
        public int yYon;

        public yilan_yonu(int x,int y)
        {
            xYon = x;
            yYon = y;
        }
    }
    class yilan
    {
        yilan_kordinat[] parcalar;
        yilan_yonu ilerleme;
        int yilan_buyujkugu;


        public yilan()
        {
            parcalar = new yilan_kordinat[4];
            yilan_buyujkugu = 4;
            parcalar[0] = new yilan_kordinat(200, 200);
            parcalar[1] = new yilan_kordinat(200, 210);
            parcalar[2] = new yilan_kordinat(200, 220);
            parcalar[3] = new yilan_kordinat(200, 230);
        }

        public Point yer_al(int eleman)
        {
            return new Point(parcalar[eleman].xKoordinat, parcalar[eleman].yKoordinat);
        }

        public void ilerle(yilan_yonu yon)
        {
            ilerleme = yon;

            for (int i = yilan_buyujkugu-1; i > 0; i--)
            {
                parcalar[i] = new yilan_kordinat(parcalar[i - 1].xKoordinat, parcalar[i - 1].yKoordinat);
            }
            parcalar[0] = new yilan_kordinat(parcalar[0].xKoordinat + yon.xYon, parcalar[0].yKoordinat + yon.yYon);
        }

    }
}
