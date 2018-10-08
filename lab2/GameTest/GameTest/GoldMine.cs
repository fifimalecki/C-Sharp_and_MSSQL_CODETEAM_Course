using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameTest
{
    class GoldMine : Building
    {
        /// <summary>
        /// Zmienna odpowiadajaca za startowy poziom rozbudowy Kopalni Złota
        /// </summary>
        private int goldMineLevel = 3;
        /// <summary>
        /// Zmienna odpowiadajaca za startową ilość zasobów złota
        /// </summary>
        private int goldResources = 78;
        /// <summary>
        /// Lista cen rozbudowy Kopalni Złota
        /// <para> 10 > i > 0 </para>
        /// <para>[3*i] - zloto, [3*i +1] - drewno, [3*i + 2] - kamien</para>
        /// </summary>
        public List<int> listGoldMinePrices = new List<int>();

        public GoldMine()
        {
            Level = goldMineLevel;
            CommonStuff.goldResources = goldResources;
            ///
            /// Petla inicjujaca ceny rozbudowy
            /// 
            for (int i = 0; i < 30; i++)
            {
                listGoldMinePrices.Add(13 * (int)Math.Round(CommonStuff.goldRatio * (i + 1)));
                listGoldMinePrices.Add(15 * (int)Math.Round(CommonStuff.lumberRatio * (i + 1)));
                listGoldMinePrices.Add(14 * (int)Math.Round(CommonStuff.stoneRatio * (i + 1)));
            }
        }
        /// <summary>
        /// Aktualizacja obrazkow po osiagniecu 5 i 10 poziomu
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="imageList"></param>
        private void UpdateStoragePicture(PictureBox pictureBox, ImageList imageList)
        {
            if (Level == 5) pictureBox.Image = imageList.Images[6];
            if (Level == 10) pictureBox.Image = imageList.Images[11];
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
            /// Petla pobierajaca oplate za rozbudowe Kopalni Zlota i zmniejszenie czasu wydobycia Zlota
            for (int i = 0; i < 10; i++)
            {
                if (Level == i &&
                    CommonStuff.goldResources >= listGoldMinePrices[3 * (i - 1)] &&
                    CommonStuff.lumberResources >= listGoldMinePrices[3 * (i - 1) + 1] &&
                    CommonStuff.stoneResources >= listGoldMinePrices[3 * (i - 1) + 2] &&
                    UpgradeProgress(progressBar, timer, button) == true)
                {
                    Level++;
                    CommonStuff.goldResources -= listGoldMinePrices[3 * (i - 1)];
                    CommonStuff.lumberResources -= listGoldMinePrices[(3 * (i - 1)) + 1];
                    CommonStuff.stoneResources -= listGoldMinePrices[(3 * (i - 1)) + 2];
                    progressBar.Visible = false;
                    progressBar.Value = 0;
                    button.Text = "Rozbuduj";
                    UpdateStoragePicture(pictureBox, imageList);
                }
            }
        }
        public List<int> GetPrices(int takeCount, int skipCount)
        {
            List<int> tempListGoldMinePrices = new List<int>();

            for (int i = 0; i < takeCount; i++)
                tempListGoldMinePrices.Add(listGoldMinePrices[i + skipCount]);

            return tempListGoldMinePrices;
        }
    }
}
