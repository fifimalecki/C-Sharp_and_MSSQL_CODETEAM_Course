using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameTest
{
    class LumberMill : Building
    {

        /// <summary>
        ///  Zmienna odpowiadajaca za startowy poziom rozbudowy Tartaku
        /// </summary>
        private int lumberMillLevel = 1;
        /// <summary>
        /// Zmienna odpowiadajaca za startową ilość zasobów drewna
        /// </summary>
        private int lumberResources = 32;
        /// <summary>
        /// Lista cen rozbudowy Tartaka
        /// <para> 10 > i > 0 </para>
        /// <para>[3*i] - zloto, [3*i +1] - drewno, [3*i + 2] - kamien</para>
        /// </summary>
        public List<int> listLumberMillPrices = new List<int>();

        public LumberMill()
        {
            Level = lumberMillLevel;
            CommonStuff.lumberResources = lumberResources;
            ///
            /// Petla inicjujaca ceny rozbudowy
            /// 
            for (int i = 0; i < 30; i++)
            {
                listLumberMillPrices.Add(12 * (int)Math.Round(CommonStuff.goldRatio * (i + 1)));
                listLumberMillPrices.Add(17 * (int)Math.Round(CommonStuff.lumberRatio * (i + 1)));
                listLumberMillPrices.Add(10 * (int)Math.Round(CommonStuff.stoneRatio * (i + 1)));
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
            if (Level == 5) pictureBox.Image = imageList.Images[7];
            if (Level == 10) pictureBox.Image = imageList.Images[12];
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
                if (Level == i &&
                    CommonStuff.goldResources >= listLumberMillPrices[3 * (i - 1)] &&
                    CommonStuff.lumberResources >= listLumberMillPrices[3 * (i - 1) + 1] &&
                    CommonStuff.stoneResources >= listLumberMillPrices[3 * (i - 1) + 2] &&
                    UpgradeProgress(progressBar,timer,button) == true)
                {
                    Level++;
                    CommonStuff.goldResources -= listLumberMillPrices[3 * (i - 1)];
                    CommonStuff.lumberResources -= listLumberMillPrices[(3 * (i - 1)) + 1];
                    CommonStuff.stoneResources -= listLumberMillPrices[(3 * (i - 1)) + 2];
                    progressBar.Visible = false;
                    progressBar.Value = 0;
                    button.Text = "Rozbuduj";
                    UpdateStoragePicture(pictureBox, imageList);
                }
            }
        }
        /// <summary>
        /// Funkcja zwracająca listę trzech rodzajów zasobów wymaganych do rozbudowy Tartaku
        /// <para>Złoto/Drewno/Kamień</para>
        /// </summary>
        /// <param name="takeCount">Zmienna odpowiedzialna za ilość elementów w zwracanej liście</param>
        /// <param name="skipCount">Zmienna która przeskakuje w liście listStoragePrices o następny level</param>
        /// <returns>Lista z wymaganymi ilościami trzech rodzajów zasobów</returns>
        public List<int> GetPrices(int takeCount, int skipCount)
        {
            List<int> tempListLumberMillPrices = new List<int>();

            for (int i = 0; i < takeCount; i++)
                tempListLumberMillPrices.Add(listLumberMillPrices[i + skipCount]);

            return tempListLumberMillPrices;
        }
    }
}
