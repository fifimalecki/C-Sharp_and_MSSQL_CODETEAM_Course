using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameTest
{
    class Storage : Building
    {
        /// <summary>
        /// Zmienna odpowiadajaca za startowy poziom rozbudowy Kamieniołomu
        /// </summary>
        private int storageLevel = 1;
        /// <summary>
        /// Zmienna odpowiadajaca za startową ilość zasobów kamienia
        /// </summary>
        private int storageResources = 100;
        /// <summary>
        /// Lista cen rozwoju Magazynu.
        /// <para> 10 > i > 0 </para>
        /// <para>[3*i] - zloto, [3*i +1] - drewno, [3*i + 2] - kamien</para>
        /// </summary>
        public List<int> listStoragePrices = new List<int>();

        public Storage()
        {
            Level = storageLevel;
            CommonStuff.storageResources = storageResources;

            for (int i = 0; i < 30; i++)
            {
                listStoragePrices.Add(15 * (int)Math.Round(CommonStuff.goldRatio * (i + 1)));
                listStoragePrices.Add(10 * (int)Math.Round(CommonStuff.lumberRatio * (i + 1)));
                listStoragePrices.Add(12 * (int)Math.Round(CommonStuff.stoneRatio * (i + 1)));
            }
        }
        /// <summary>
        /// Aktualizacja obrazkow po osiagniecu 5 i 10 poziomu
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="imageList"></param>
        private void UpdateStoragePicture(PictureBox pictureBox,ImageList imageList)
        {
            if (Level == 5) pictureBox.Image = imageList.Images[5];
            if (Level == 10) pictureBox.Image = imageList.Images[10];
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
            // Petla pobierajaca oplate za rozbudowe Magazynu i powiekszenie jego zasobow
            for (int i = 0; i < 10; i++)
            {
                
                if (Level == i &&
                    CommonStuff.goldResources >= listStoragePrices[3 * (i - 1)] &&
                    CommonStuff.lumberResources >= listStoragePrices[(3 * (i - 1)) + 1] &&
                    CommonStuff.stoneResources >= listStoragePrices[(3 * (i - 1)) + 2] &&
                    UpgradeProgress(progressBar, timer, button) == true)
                {
                    Level++;
                    CommonStuff.goldResources -= listStoragePrices[3 * (i - 1)];
                    CommonStuff.lumberResources -= listStoragePrices[(3 * (i - 1)) + 1];
                    CommonStuff.stoneResources -= listStoragePrices[(3 * (i - 1)) + 2];
                    CommonStuff.storageResources += (25 * i);
                    progressBar.Visible = false;
                    progressBar.Value = 0;
                    button.Text = "Rozbuduj";
                    UpdateStoragePicture(pictureBox, imageList);
                }
            }
        }
        /// <summary>
        /// Funkcja zwracająca listę trzech rodzajów zasobów wymaganych do rozbudowy Magazynu
        /// <para>Złoto/Drewno/Kamień</para>
        /// </summary>
        /// <param name="takeCount">Zmienna odpowiedzialna za ilość elementów w zwracanej liście</param>
        /// <param name="skipCount">Zmienna która przeskakuje w liście listStoragePrices o następny level</param>
        /// <returns>Lista z wymaganymi ilościami trzech rodzajów zasobów</returns>
        public List<int> GetPrices(int takeCount, int skipCount)
        {
            List<int> tempListStoragePrices = new List<int>();

            for (int i = 0; i < takeCount; i++)
                tempListStoragePrices.Add(listStoragePrices[i + skipCount]);

            return tempListStoragePrices;
        }
    }
}
