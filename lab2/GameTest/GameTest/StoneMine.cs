using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameTest
{
    class StoneMine : Building
    {
        /// <summary>
        /// Zmienna odpowiadajaca za startowy poziom rozbudowy Kamieniołomu
        /// </summary>
        int stoneMineLevel = 2;
        /// <summary>
        /// Zmienna odpowiadajaca za startową ilość zasobów kamienia
        /// </summary>
        int stoneResources = 46;
        /// <summary>
        /// Lista cen rozwoju Kamieniolomu.
        /// <para> 10 > i > 0 </para>
        /// <para>[3*i] - zloto, [3*i +1] - drewno, [3*i + 2] - kamien</para>
        /// </summary>
        public List<int> listStoneMinePrices = new List<int>();

        public StoneMine()
        {
            Level = stoneMineLevel;
            CommonStuff.stoneResources = stoneResources;
            ///
            /// Petla inicjujaca ceny rozbudowy
            /// 
            for (int i = 0; i < 30; i++)
            {
                listStoneMinePrices.Add(12 * (int)Math.Round(CommonStuff.goldRatio * (i + 1)));
                listStoneMinePrices.Add(15 * (int)Math.Round(CommonStuff.lumberRatio * (i + 1)));
                listStoneMinePrices.Add(18 * (int)Math.Round(CommonStuff.stoneRatio * (i + 1)));
            }
        }
        /// <summary>
        /// Aktualizacja obrazkow po osiagniecu 5 i 10 poziomu
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="imageList"></param>
        private void UpdateStoragePicture(PictureBox pictureBox, ImageList imageList)
        {
            if (Level == 5) pictureBox.Image = imageList.Images[8];
            if (Level == 10) pictureBox.Image = imageList.Images[13];
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
            // Petla pobierajaca oplate za rozbudowe Kamieniolomu i zmniejszenie czasu wydobycia Kamienia
            for (int i = 0; i < 10; i++)
            {
                if (Level == i &&
                    CommonStuff.goldResources >= listStoneMinePrices[3 * (i - 1)] &&
                    CommonStuff.lumberResources >= listStoneMinePrices[3 * (i - 1) + 1] &&
                    CommonStuff.stoneResources >= listStoneMinePrices[3 * (i - 1) + 2] &&
                    UpgradeProgress(progressBar, timer, button) == true)
                {
                    Level++;
                    CommonStuff.goldResources -= listStoneMinePrices[3 * (i - 1)];
                    CommonStuff.lumberResources -= listStoneMinePrices[(3 * (i - 1)) + 1];
                    CommonStuff.stoneResources -= listStoneMinePrices[(3 * (i - 1)) + 2];
                    progressBar.Visible = false;
                    progressBar.Value = 0;
                    button.Text = "Rozbuduj";
                    UpdateStoragePicture(pictureBox, imageList);
                }
            }
        }
        /// <summary>
        /// Funkcja zwracająca listę trzech rodzajów zasobów wymaganych do rozbudowy Kamieniołomu
        /// <para>Złoto/Drewno/Kamień</para>
        /// </summary>
        /// <param name="takeCount">Zmienna odpowiedzialna za ilość elementów w zwracanej liście</param>
        /// <param name="skipCount">Zmienna która przeskakuje w liście listStoragePrices o następny level</param>
        /// <returns>Lista z wymaganymi ilościami trzech rodzajów zasobów</returns>
        public List<int> GetPrices(int takeCount, int skipCount)
        {
            List<int> tempListStonePrices = new List<int>();

            for (int i = 0; i < takeCount; i++)
                tempListStonePrices.Add(listStoneMinePrices[i + skipCount]);

            return tempListStonePrices;
        }
    }
}
