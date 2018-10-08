using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public static class CommonStuff
    {
        ///
        /// Zmienne dotyczace zasobow
        /// 
        /// <summary>
        /// Zmienna reprezentujaca zasoby złota
        /// </summary>
        public static int goldResources;
        /// <summary>
        /// Zmienna reprezentujaca zasoby drewna
        /// </summary>
        public static int lumberResources;
        /// <summary>
        /// Zmienna reprezentujaca zasoby kamienia
        /// </summary>
        public static int stoneResources;
        /// <summary>
        /// Zmienna reprezentujaca ilosc miejsca w magazynie
        /// </summary>
        public static int storageResources;
        /// 
        /// Zmienne dotyczace wspolczynnikow wartości surowcow
        /// 
        /// <summary>
        /// Wspolczynnik wartosci zlota
        /// </summary>
        public static readonly double goldRatio = 3.65;
        /// <summary>
        /// Wspolczynnik wartosci drewna
        /// </summary>
        public static readonly double lumberRatio = 3.07;
        /// <summary>
        /// Wspolczynnik wartosci kamienia
        /// </summary>
        public static readonly double stoneRatio = 3.23;
        /// <summary>
        /// Wspolczynnik cen w Markecie w zaleznosci od poziomu Marketu
        /// </summary>
        public static double marketTradeRatio = 1.65;
        /// 
        /// Zmienna dotyczaca wzrostu predkosci wydobycia surowcow
        /// 
        /// <summary>
        /// Wzrost predkosci wydobycia surowcow
        /// </summary>
        public static int speedExtraction = 0;
        /// 
        /// Zmienne dotyczace handlu
        /// 
        /// <summary>
        /// Ilosc surowcow oferowana przez Gracza
        /// </summary>
        public static int marketPlayerOfferQuantity = 0;
        /// <summary>
        /// Ilosc surowcow oferowana przez Market
        /// </summary>
        public static int marketStoreOfferQuantity = 150;

    }
}
