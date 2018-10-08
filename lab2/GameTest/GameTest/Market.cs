using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameTest
{
    class Market : Building
    {
        /// <summary>
        ///  Zmienna odpowiadajaca za startowy poziom rozbudowy Marketu
        /// </summary>
        int marketLevel = 0;
        /// <summary>
        /// Lista cen rozbudowy Marketu
        /// <para> 10 > i > 0 </para>
        /// <para>[3*i] - zloto, [3*i +1] - drewno, [3*i + 2] - kamien</para>
        /// </summary>
        public List<int> listMarketPrices = new List<int>();

        public Market()
        {
            Level = marketLevel;
            ///
            /// Petla inicjujaca ceny rozbudowy
            /// 
            for (int i = 0; i < 30; i++)
            {
                listMarketPrices.Add(20 * (int)Math.Round(CommonStuff.goldRatio * (i + 1)));
                listMarketPrices.Add(20 * (int)Math.Round(CommonStuff.lumberRatio * (i + 1)));
                listMarketPrices.Add(20 * (int)Math.Round(CommonStuff.stoneRatio * (i + 1)));
            }
        }
        /// <summary>
        /// Aktualizacja obrazkow po osiagniecu 5 i 10 poziomu
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="imageList"></param>
        private void UpdateStoragePicture(PictureBox pictureBox, ImageList imageList)
        {
            /// Aktualizacja obrazkow Magazynu po osiagniecu 5 i 10 poziomu
            if (Level == 5) pictureBox.Image = imageList.Images[9];
            if (Level == 10) pictureBox.Image = imageList.Images[14];
        }
        /// <summary>
        /// Funkcja odpowiedzialna za rozbudowe
        /// </summary>
        /// <param name="progressBar"></param>
        /// <param name="timer"></param>
        /// <param name="button"></param>
        /// <param name="pictureBox"></param>
        /// <param name="imageList"></param>
        public override void Upgrade(ProgressBar progressBar, Timer timer, Button button, PictureBox pictureBox, ImageList imageList)
        {
            /// Petla pobierajaca oplate za rozbudowe Tartaku i zmniejszenie czasu wydobycia Drewna
            for (int i = 0; i < 10; i++)
            {
                if (Level != 0 &&
                    Level == i &&
                    CommonStuff.goldResources >= listMarketPrices[3 * (i - 1)] &&
                    CommonStuff.lumberResources >= listMarketPrices[3 * (i - 1) + 1] &&
                    CommonStuff.stoneResources >= listMarketPrices[3 * (i - 1) + 2] &&
                    UpgradeProgress(progressBar, timer, button) == true)
                {
                    Level++;
                    CommonStuff.goldResources -= listMarketPrices[3 * (i - 1)];
                    CommonStuff.lumberResources -= listMarketPrices[(3 * (i - 1)) + 1];
                    CommonStuff.stoneResources -= listMarketPrices[(3 * (i - 1)) + 2];
                    CommonStuff.marketTradeRatio -= 0.05;
                    progressBar.Visible = false;
                    progressBar.Value = 0;
                    button.Text = "Rozbuduj";
                    UpdateStoragePicture(pictureBox, imageList);
                }
            }
        }
        /// <summary>
        /// Funkcja zwracająca listę trzech rodzajów zasobów wymaganych do rozbudowy Marketu
        /// <para>Złoto/Drewno/Kamień</para>
        /// </summary>
        /// <param name="takeCount">Zmienna odpowiedzialna za ilość elementów w zwracanej liście</param>
        /// <param name="skipCount">Zmienna która przeskakuje w liście listStoragePrices o następny level</param>
        /// <returns>Lista z wymaganymi ilościami trzech rodzajów zasobów</returns>
        public List<int> GetPrices(int takeCount, int skipCount)
        {
            List<int> tempListMarketePrices = new List<int>();

            for (int i = 0; i < takeCount; i++)
                tempListMarketePrices.Add(listMarketPrices[i + skipCount]);

            return tempListMarketePrices;
        }
    }
}
