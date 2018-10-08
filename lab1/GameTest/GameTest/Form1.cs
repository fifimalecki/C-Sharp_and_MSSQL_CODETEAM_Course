using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest
{
    public partial class FormMain : Form
    {
        /// 
        /// Zmienne dotyczace poziomu budynków
        /// 
        /// <summary>
        /// Poziom Magazynu
        /// </summary>
        int storageLevel = 1;
        /// <summary>
        /// Poziom Kopalni Zlota
        /// </summary>
        int goldMineLevel = 3;
        /// <summary>
        /// Poziom Tartaku
        /// </summary>
        int lumberMillLevel = 1;
        /// <summary>
        /// Poziom Kamieniolomu
        /// </summary>
        int stoneMineLevel = 2;
        /// <summary>
        /// Poziom Marketu
        /// </summary>
        int marketLevel = 0;

        /// 
        /// Zmienne dotyczace ilosci posiadanych zasobow(surowcow)
        /// 
        /// <summary>
        /// Ilosc posiadanego miejsca w magazynie
        /// </summary>
        int storageResources = 100;
        /// <summary>
        /// Ilosc posiadanego zlota
        /// </summary>
        int goldResources = 50;
        /// <summary>
        /// Ilosc posiadanego drewna
        /// </summary>
        int lumberResources = 32;
        /// <summary>
        /// Ilosc posiadanego kamienia
        /// </summary>
        int stoneResources = 46;

        /// 
        /// Zmienne dotyczace wspolczynnikow wartości surowcow
        /// 
        /// <summary>
        /// Wspolczynnik wartosci zlota
        /// </summary>
        double goldRatio = 3.65;
        /// <summary>
        /// Wspolczynnik wartosci drewna
        /// </summary>
        double lumberRatio = 3.07;
        /// <summary>
        /// Wspolczynnik wartosci kamienia
        /// </summary>
        double stoneRatio = 3.23;

        /// 
        /// Zmienna dotyczaca wzrostu predkosci wydobycia surowcow
        /// 
        /// <summary>
        /// Wzrost predkosci wydobycia surowcow
        /// </summary>
        int speedExtraction = 0;

        /// 
        /// Zmienne dotyczace handlu
        /// 
        /// <summary>
        /// Ilosc surowcow oferowana przez Gracza
        /// </summary>
        int marketPlayerOfferQuantity = 0;
        /// <summary>
        /// Ilosc surowcow oferowana przez Market
        /// </summary>
        int marketStoreOfferQuantity = 150;

        /// 
        /// Listy dotyczace cen za rozwijanie poszczegolnych budynkow
        /// 
        /// <summary>
        /// Lista cen rozwoju Magazynu.
        /// <para> 10 > i > 0 </para>
        /// <para>[3*i] - zloto, [3*i +1] - drewno, [3*i + 2] - kamien</para>
        /// </summary>
        List<int> listStoragePrices = new List<int>();
        /// <summary>
        /// Lista cen rozwoju Kopalni Zlota.
        /// <para> 10 > i > 0 </para>
        /// <para>[3*i] - zloto, [3*i +1] - drewno, [3*i + 2] - kamien</para>
        /// </summary>
        List<int> listGoldMinePrices = new List<int>();
        /// <summary>
        /// Lista cen rozwoju Tartaku.
        /// <para> 10 > i > 0 </para>
        /// <para>[3*i] - zloto, [3*i +1] - drewno, [3*i + 2] - kamien</para>
        /// </summary>
        List<int> listLumberMillPrices = new List<int>();
        /// <summary>
        /// Lista cen rozwoju Kamieniolomu.
        /// <para> 10 > i > 0 </para>
        /// <para>[3*i] - zloto, [3*i +1] - drewno, [3*i + 2] - kamien</para>
        /// </summary>
        List<int> listStoneMinePrices = new List<int>();
        /// <summary>
        /// Lista cen rozwoju Marketu.
        /// <para> 10 > i > 0 </para>
        /// <para>[3*i] - zloto, [3*i +1] - drewno, [3*i + 2] - kamien</para>
        /// </summary>
        List<int> listMarketPrices = new List<int>();

        /// Zmienna dotyczaca wspolczynnika cen w Markecie w zaleznosci od poziomu Marketu
        /// 
        /// <summary>
        /// Wspolczynnik cen w Markecie w zaleznosci od poziomu Marketu
        /// </summary>
        double marketTradeRatio = 1.65;

        public FormMain()
        {
            InitializeComponent();
            ///
            /// Petla inicjujaca ceny rozwoju budynkow
            /// 
            for (int i = 0; i < 30; i++)
            {
                listStoragePrices.Add(15 * (int)Math.Round(goldRatio * (i + 1)));
                listStoragePrices.Add(10 * (int)Math.Round(lumberRatio * (i + 1)));
                listStoragePrices.Add(12 * (int)Math.Round(stoneRatio * (i + 1)));

                listGoldMinePrices.Add(13 * (int)Math.Round(goldRatio * (i + 1)));
                listGoldMinePrices.Add(15 * (int)Math.Round(lumberRatio * (i + 1)));
                listGoldMinePrices.Add(14 * (int)Math.Round(stoneRatio * (i + 1)));

                listLumberMillPrices.Add(12 * (int)Math.Round(goldRatio * (i + 1)));
                listLumberMillPrices.Add(17 * (int)Math.Round(lumberRatio * (i + 1)));
                listLumberMillPrices.Add(10 * (int)Math.Round(stoneRatio * (i + 1)));

                listStoneMinePrices.Add(12 * (int)Math.Round(goldRatio * (i + 1)));
                listStoneMinePrices.Add(15 * (int)Math.Round(lumberRatio * (i + 1)));
                listStoneMinePrices.Add(18 * (int)Math.Round(stoneRatio * (i + 1)));

                listMarketPrices.Add(20 * (int)Math.Round(goldRatio * (i + 1)));
                listMarketPrices.Add(20 * (int)Math.Round(lumberRatio * (i + 1)));
                listMarketPrices.Add(20 * (int)Math.Round(stoneRatio * (i + 1)));
            }
            ///
            /// Inicjalizaca wierszy nalezace do dataGridViewUpgradePrices
            ///
            /// <summary>
            /// Wiersz 0 nalezacy do dataGridViewUpgradePrices
            /// </summary>
            string[] row0DataGridViewUpgradePrices = {"1 -> 2", (listStoragePrices[0]+"/"+listStoragePrices[1]+"/"+listStoragePrices[2]).ToString(),
                                                       (listGoldMinePrices[0]+"/"+listGoldMinePrices[1]+"/"+listGoldMinePrices[2]).ToString(),
                                                       (listLumberMillPrices[0]+"/"+listLumberMillPrices[1]+"/"+listLumberMillPrices[2]).ToString(),
                                                       (listStoneMinePrices[0]+"/"+listStoneMinePrices[1]+"/"+listStoneMinePrices[2]).ToString(),
                                                       (listMarketPrices[0]+"/"+listMarketPrices[1]+"/"+listMarketPrices[2]).ToString() };
            /// <summary>
            /// Wiersz 1 nalezacy do dataGridViewUpgradePrices
            /// </summary>
            string[] row1DataGridViewUpgradePrices = {"2 -> 3", (listStoragePrices[3]+"/"+listStoragePrices[4]+"/"+listStoragePrices[5]).ToString(),
                                                       (listGoldMinePrices[3]+"/"+listGoldMinePrices[4]+"/"+listGoldMinePrices[5]).ToString(),
                                                       (listLumberMillPrices[3]+"/"+listLumberMillPrices[4]+"/"+listLumberMillPrices[5]).ToString(),
                                                       (listStoneMinePrices[3]+"/"+listStoneMinePrices[4]+"/"+listStoneMinePrices[5]).ToString(),
                                                       (listMarketPrices[3]+"/"+listMarketPrices[4]+"/"+listMarketPrices[8]).ToString() };
            /// <summary>
            /// Wiersz 2 nalezacy do dataGridViewUpgradePrices
            /// </summary>
            string[] row2DataGridViewUpgradePrices = {"3 -> 4", (listStoragePrices[6]+"/"+listStoragePrices[7]+"/"+listStoragePrices[8]).ToString(),
                                                       (listGoldMinePrices[6]+"/"+listGoldMinePrices[7]+"/"+listGoldMinePrices[8]).ToString(),
                                                       (listLumberMillPrices[6]+"/"+listLumberMillPrices[7]+"/"+listLumberMillPrices[8]).ToString(),
                                                       (listStoneMinePrices[6]+"/"+listStoneMinePrices[7]+"/"+listStoneMinePrices[8]).ToString(),
                                                       (listMarketPrices[6]+"/"+listMarketPrices[7]+"/"+listMarketPrices[8]).ToString() };
            /// <summary>
            /// Wiersz 3 nalezacy do dataGridViewUpgradePrices
            /// </summary>
            string[] row3DataGridViewUpgradePrices = {"4 -> 5", (listStoragePrices[9]+"/"+listStoragePrices[10]+"/"+listStoragePrices[11]).ToString(),
                                                       (listGoldMinePrices[9]+"/"+listGoldMinePrices[10]+"/"+listGoldMinePrices[11]).ToString(),
                                                       (listLumberMillPrices[9]+"/"+listLumberMillPrices[10]+"/"+listLumberMillPrices[11]).ToString(),
                                                       (listStoneMinePrices[9]+"/"+listStoneMinePrices[10]+"/"+listStoneMinePrices[11]).ToString(),
                                                       (listMarketPrices[9]+"/"+listMarketPrices[10]+"/"+listMarketPrices[11]).ToString() };
            /// <summary>
            /// Wiersz 4 nalezacy do dataGridViewUpgradePrices
            /// </summary>
            string[] row4DataGridViewUpgradePrices = {"5 -> 6", (listStoragePrices[12]+"/"+listStoragePrices[13]+"/"+listStoragePrices[14]).ToString(),
                                                       (listGoldMinePrices[12]+"/"+listGoldMinePrices[13]+"/"+listGoldMinePrices[14]).ToString(),
                                                       (listLumberMillPrices[12]+"/"+listLumberMillPrices[13]+"/"+listLumberMillPrices[14]).ToString(),
                                                       (listStoneMinePrices[12]+"/"+listStoneMinePrices[13]+"/"+listStoneMinePrices[14]).ToString(),
                                                       (listMarketPrices[12]+"/"+listMarketPrices[13]+"/"+listMarketPrices[14]).ToString() };
            /// <summary>
            /// Wiersz 5 nalezacy do dataGridViewUpgradePrices
            /// </summary>
            string[] row5DataGridViewUpgradePrices = {"6 -> 7", (listStoragePrices[15]+"/"+listStoragePrices[16]+"/"+listStoragePrices[17]).ToString(),
                                                       (listGoldMinePrices[15]+"/"+listGoldMinePrices[16]+"/"+listGoldMinePrices[17]).ToString(),
                                                       (listLumberMillPrices[15]+"/"+listLumberMillPrices[16]+"/"+listLumberMillPrices[17]).ToString(),
                                                       (listStoneMinePrices[15]+"/"+listStoneMinePrices[16]+"/"+listStoneMinePrices[17]).ToString(),
                                                       (listMarketPrices[15]+"/"+listMarketPrices[16]+"/"+listMarketPrices[17]).ToString() };
            /// <summary>
            /// Wiersz 6 nalezacy do dataGridViewUpgradePrices
            /// </summary>
            string[] row6DataGridViewUpgradePrices = {"7 -> 8", (listStoragePrices[18]+"/"+listStoragePrices[19]+"/"+listStoragePrices[20]).ToString(),
                                                       (listGoldMinePrices[18]+"/"+listGoldMinePrices[19]+"/"+listGoldMinePrices[20]).ToString(),
                                                       (listLumberMillPrices[18]+"/"+listLumberMillPrices[19]+"/"+listLumberMillPrices[20]).ToString(),
                                                       (listStoneMinePrices[18]+"/"+listStoneMinePrices[19]+"/"+listStoneMinePrices[20]).ToString(),
                                                       (listMarketPrices[18]+"/"+listMarketPrices[19]+"/"+listMarketPrices[20]).ToString() };
            /// <summary>
            /// Wiersz 7 nalezacy do dataGridViewUpgradePrices
            /// </summary>
            string[] row7DataGridViewUpgradePrices = {"8 -> 9", (listStoragePrices[21]+"/"+listStoragePrices[22]+"/"+listStoragePrices[23]).ToString(),
                                                       (listGoldMinePrices[21]+"/"+listGoldMinePrices[22]+"/"+listGoldMinePrices[23]).ToString(),
                                                       (listLumberMillPrices[21]+"/"+listLumberMillPrices[22]+"/"+listLumberMillPrices[23]).ToString(),
                                                       (listStoneMinePrices[21]+"/"+listStoneMinePrices[22]+"/"+listStoneMinePrices[23]).ToString(),
                                                       (listMarketPrices[21]+"/"+listMarketPrices[22]+"/"+listMarketPrices[23]).ToString() };
            /// <summary>
            /// Wiersz 8 nalezacy do dataGridViewUpgradePrices
            /// </summary>
            string[] row8DataGridViewUpgradePrices = {"9 -> 10", (listStoragePrices[24]+"/"+listStoragePrices[25]+"/"+listStoragePrices[26]).ToString(),
                                                       (listGoldMinePrices[24]+"/"+listGoldMinePrices[25]+"/"+listGoldMinePrices[26]).ToString(),
                                                       (listLumberMillPrices[24]+"/"+listLumberMillPrices[25]+"/"+listLumberMillPrices[26]).ToString(),
                                                       (listStoneMinePrices[24]+"/"+listStoneMinePrices[25]+"/"+listStoneMinePrices[26]).ToString(),
                                                       (listMarketPrices[24]+"/"+listMarketPrices[25]+"/"+listMarketPrices[26]).ToString() };
            /// <summary>
            /// Wiersz 9 nalezacy do dataGridViewUpgradePrices
            /// </summary>
            string[] row9DataGridViewUpgradePrices = {"10 -> ...", (listStoragePrices[27]+"/"+listStoragePrices[28]+"/"+listStoragePrices[29]).ToString(),
                                                       (listGoldMinePrices[27]+"/"+listGoldMinePrices[28]+"/"+listGoldMinePrices[29]).ToString(),
                                                       (listLumberMillPrices[27]+"/"+listLumberMillPrices[28]+"/"+listLumberMillPrices[29]).ToString(),
                                                       (listStoneMinePrices[27]+"/"+listStoneMinePrices[28]+"/"+listStoneMinePrices[29]).ToString(),
                                                       (listMarketPrices[27]+"/"+listMarketPrices[28]+"/"+listMarketPrices[29]).ToString() };
            ///
            /// Przypisanie posiadanych zasobow do labeli wyswietlajacych ich wartosc
            /// 
            labelGold.Text = goldResources.ToString();
            labelWood.Text = lumberResources.ToString();
            labelStone.Text = stoneResources.ToString();
            labelPlace.Text = storageResources.ToString();
            ///
            /// Przypisanie wymagan zbudowania Marketu do labelu wyswietlajacego
            /// 
            labelMarketRequirements.Text = "Wymagania:\nMagazyn (Poziom 6)\nKoszt:\n360/310/320";
            ///
            /// Przypisanie obrazkow z imageList do pictureBox (Budynki)
            ///
            pictureBoxStorage.Image = imageListBuildings.Images[0];
            pictureBoxGoldMine.Image = imageListBuildings.Images[1];
            pictureBoxLumberMill.Image = imageListBuildings.Images[2];
            pictureBoxStoneMine.Image = imageListBuildings.Images[3];
            pictureBoxMarket.Image = imageListBuildings.Images[4];
            ///
            /// Przypisanie obrazkow z imageList do pictureBox (Ikony)
            ///
            pictureBoxPlace.Image = imageListIcons.Images[0];
            pictureBoxGold.Image = imageListIcons.Images[1];
            pictureBoxWood.Image = imageListIcons.Images[2];
            pictureBoxStone.Image = imageListIcons.Images[3];
            ///
            /// Obsluga wyswietlania poziomu
            ///
            labelStorageLevel.Text = "Poziom " + storageLevel;
            labelGoldMineLevel.Text = "Poziom " + goldMineLevel;
            labelLumberMillLevel.Text = "Poziom " + lumberMillLevel;
            labelStoneMineLevel.Text = "Poziom " + stoneMineLevel;
            labelMarketLevel.Text = "Poziom " + marketLevel;
            ///
            /// Start licznikow surowcow
            ///
            timerGold.Start();
            timerStone.Start();
            timerWood.Start();
            
            ///
            /// Dodanie wierszy do dataGridViewUpgradePrices
            ///
            dataGridViewUpgradePrices.Rows.Add(row0DataGridViewUpgradePrices);
            dataGridViewUpgradePrices.Rows.Add(row1DataGridViewUpgradePrices);
            dataGridViewUpgradePrices.Rows.Add(row2DataGridViewUpgradePrices);
            dataGridViewUpgradePrices.Rows.Add(row3DataGridViewUpgradePrices);
            dataGridViewUpgradePrices.Rows.Add(row4DataGridViewUpgradePrices);
            dataGridViewUpgradePrices.Rows.Add(row5DataGridViewUpgradePrices);
            dataGridViewUpgradePrices.Rows.Add(row6DataGridViewUpgradePrices);
            dataGridViewUpgradePrices.Rows.Add(row7DataGridViewUpgradePrices);
            dataGridViewUpgradePrices.Rows.Add(row8DataGridViewUpgradePrices);
            dataGridViewUpgradePrices.Rows.Add(row9DataGridViewUpgradePrices);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Restart wszystkich licznikow zasobow
        /// </summary>
        private void RestartResourcesTimers()
        {
            timerGold.Start();
            timerWood.Start();
            timerStone.Start();
        }
        /// <summary>
        /// Restart wszystkich labeli
        /// </summary>
        private void RestartLabels()
        {
            labelGold.Text = goldResources.ToString();
            labelWood.Text = lumberResources.ToString();
            labelStone.Text = lumberResources.ToString();
            labelPlace.Text = storageResources.ToString();

            labelStorageLevel.Text = "Poziom " + storageLevel;
            labelGoldMineLevel.Text = "Poziom " + goldMineLevel;
            labelLumberMillLevel.Text = "Poziom " + lumberMillLevel;
            labelStoneMineLevel.Text = "Poziom " + stoneMineLevel;
            labelMarketLevel.Text = "Poziom " + marketLevel;
        }
        /// <summary>
        /// Obsluga timera zwiekszajacego poziom posiadanych zasobow zlota
        /// </summary>
        private void TimerGold_Tick(object sender, EventArgs e)
        {
            goldResources++;
            labelGold.Text = goldResources.ToString();
            if (goldResources == storageResources)
            {
                timerGold.Stop();
                goldResources = storageResources - 1;
            }
        }
        /// <summary>
        /// Obsluga timera zwiekszajacego poziom posiadancyh zasobow drewna
        /// </summary>
        private void TimerWood_Tick(object sender, EventArgs e)
        {
            lumberResources++;
            labelWood.Text = lumberResources.ToString();
            if (lumberResources >= storageResources)
            {
                timerWood.Stop();
                lumberResources = storageResources - 1;
            }
        }
        /// <summary>
        /// Obsluga timera zwiekszajacego poziom posiadancyh zasobow kamienia
        /// </summary>
        private void TimerStone_Tick(object sender, EventArgs e)
        {
            stoneResources++;
            labelStone.Text = stoneResources.ToString();
            if (stoneResources == storageResources)
            {
                timerStone.Stop();
                stoneResources = storageResources - 1;
            }
        }
        /// <summary>
        /// Obsluga buttona rozwoju magazynu
        /// </summary>
        private void ButtonStorageUpgrade_Click(object sender, EventArgs e)
        {
            /// Wlaczenie guzika budowy Marketu
            if (storageLevel == 6)
                buttonMarketUpgrade.Enabled = true;

            // Petla pobierajaca oplate za rozbudowe Magazynu i powiekszenie jego zasobow
            for (int i = 0; i < 10; i++)
            {
                if (storageLevel == i &&
                    goldResources >= listStoragePrices[3 * (i-1)] &&
                    lumberResources >= listStoragePrices[(3 * (i-1)) + 1] &&
                    stoneResources >= listStoragePrices[(3 * (i-1)) + 2])
                {
                    storageLevel++;
                    goldResources -= listStoragePrices[3 * (i-1)];
                    lumberResources -= listStoragePrices[(3 * (i-1)) + 1];
                    stoneResources -= listStoragePrices[(3 * (i-1)) + 2];
                    storageResources += (25 * i);
                }
            }
            // Restart timerow i labeli
            RestartResourcesTimers();
            RestartLabels();

            // Aktualizacja obrazkow Magazynu po osiagniecu 5 i 10 poziomu
            if (storageLevel == 5) pictureBoxStorage.Image = imageListBuildings.Images[5];
            if (storageLevel == 10) pictureBoxStorage.Image = imageListBuildings.Images[10];
        }
        /// <summary>
        /// Obsluga buttona rozwoju Kopalni Zlota
        /// </summary>
        private void ButtonGoldMineUpgrade_Click(object sender, EventArgs e)
        {
            // Petla pobierajaca oplate za rozbudowe Kopalni Zlota i zmniejszenie czasu wydobycia Zlota
            for (int i = 0; i < 10; i++)
            {
                if (goldMineLevel == i &&
                    goldResources >= listGoldMinePrices[3 * (i-1)] &&
                    lumberResources >= listGoldMinePrices[3 * (i - 1) + 1] &&
                    stoneResources >= listGoldMinePrices[3 * (i - 1) + 2])
                {
                    goldMineLevel++;
                    goldResources -= listGoldMinePrices[3 * (i - 1)];
                    lumberResources -= listGoldMinePrices[3 * (i - 1) + 1];
                    stoneResources -= listGoldMinePrices[3 * (i - 1) + 2];
                    timerGold.Interval -= speedExtraction;

                }
            }
            // Restart timerow i labeli
            RestartResourcesTimers();
            RestartLabels();

            // Aktualizacja obrazkow Kopalni Zlota po osiagnieciu 5 i 10 poziomu
            if (goldMineLevel == 5) pictureBoxGoldMine.Image = imageListBuildings.Images[6];
            if (goldMineLevel == 10) pictureBoxGoldMine.Image = imageListBuildings.Images[11];
        }
        /// <summary>
        /// Obsluga buttona rozwoju Tartaku
        /// </summary>
        private void ButtonLumberMillUpgrade_Click(object sender, EventArgs e)
        {
            // Petla pobierajaca oplate za rozbudowe Tartaku i zmniejszenie czasu wydobycia Drewna
            for (int i = 0; i < 10; i++)
            {
                if (lumberMillLevel == i &&
                    goldResources >= listLumberMillPrices[3 * (i - 1)] &&
                    lumberResources >= listLumberMillPrices[3 * (i - 1) + 1] &&
                    stoneResources >= listLumberMillPrices[3 * (i - 1) + 2])
                {
                    lumberMillLevel++;
                    goldResources -= listLumberMillPrices[3 * (i - 1)];
                    lumberResources -= listLumberMillPrices[3 * (i - 1) + 1];
                    stoneResources -= listLumberMillPrices[3 * (i - 1) + 2];
                    timerWood.Interval -= speedExtraction;

                }
            }
            // Restart timerow i labeli
            RestartResourcesTimers();
            RestartLabels();

            // Aktualizacja obrazkow Tartaku po osiagnieciu 5 i 10 poziomu
            if (lumberMillLevel == 5) pictureBoxLumberMill.Image = imageListBuildings.Images[7];
            if (lumberMillLevel == 10) pictureBoxLumberMill.Image = imageListBuildings.Images[12];
        }
        /// <summary>
        /// Obsluga buttona rozwoju Kamieniolomu
        /// </summary>
        private void ButtonStoneMineUpgrade_Click(object sender, EventArgs e)
        {
            // Petla pobierajaca oplate za rozbudowe Kamieniolomu i zmniejszenie czasu wydobycia Kamienia
            for (int i = 0; i < 10; i++)
            {
                if (goldResources >= listStoneMinePrices[3 * (i - 1)] &&
                    lumberResources >= listStoneMinePrices[3 * (i - 1) + 1] &&
                    stoneResources >= listStoneMinePrices[3 * (i - 1) + 2])
                {
                    stoneMineLevel++;
                    goldResources -= listStoneMinePrices[3 * (i - 1)];
                    lumberResources -= listStoneMinePrices[3 * (i - 1) + 1];
                    stoneResources -= listStoneMinePrices[3 * (i - 1) + 2];
                    timerStone.Interval -= speedExtraction;
                    
                }
            }
            // Restart timerow i labeli
            RestartResourcesTimers();
            RestartLabels();

            // Aktualizacja obrazkow Kamieniolomu po osiagnieciu 5 i 10 poziomu
            if (stoneMineLevel == 5) pictureBoxStoneMine.Image = imageListBuildings.Images[8];
            if (stoneMineLevel == 10) pictureBoxStoneMine.Image = imageListBuildings.Images[13];
        }
        /// <summary>
        /// Obsluga buttona rozwoju Marketu
        /// </summary>
        private void ButtonMarketUpgrade_Click(object sender, EventArgs e)
        {
            // Petla pobierajaca oplate za rozbudowe/budowe Marketu i zmniejszenie wspolczynnika cen w Markecie
            for (int i = 0; i < 10; i++)
            {
                if (marketLevel != 0 &&
                    marketLevel == i &&
                    goldResources >= listMarketPrices[3 * (i - 1)] &&
                    lumberResources >= listMarketPrices[3 * (i - 1) + 1] &&
                    stoneResources >= listMarketPrices[3 * (i - 1) + 2])
                {
                    marketLevel++;
                    marketTradeRatio -= 0.05;
                    goldResources -= listMarketPrices[3 * (i - 1)];
                    lumberResources -= listMarketPrices[3 * (i - 1) + 1];
                    stoneResources -= listMarketPrices[3 * (i - 1) + 2];
                }
                // Przypadek gdy Market nie jest zbudowany
                if(marketLevel == 0 &&
                    goldResources >= 360 &&
                    lumberResources >= 310 &&
                    stoneResources >= 320)
                {
                    marketLevel++;
                    pictureBoxMarket.Visible = true;
                    listBoxPlayerOffer.Visible = true;
                    listBoxMarketOffer.Visible = true;
                    labelTrade1.Visible = true;
                    labelTrade2.Visible = true;
                    textBoxPlayerOffer.Visible = true;
                    textBoxMarketOffer.Visible = true;
                    buttonBuy.Visible = true;
                    buttonMarketUpgrade.Text = "Rozbuduj";
                }
            }
            //Restart timerow i labeli
            RestartResourcesTimers();
            RestartLabels();

            // Aktualizacja obrazkow Marketu po osiagnieciu 5 i 10 poziomu
            if (marketLevel == 5) pictureBoxMarket.Image = imageListBuildings.Images[9];
            if (marketLevel == 10) pictureBoxMarket.Image = imageListBuildings.Images[14];
        }
        /// <summary>
        /// Obsluga buttona dokonania wymiany z Marketem
        /// </summary>
        private void ButtonBuy_Click(object sender, EventArgs e)
        {
            // Przekazanie do zmiennej wartosci oferty Gracza i wartosci oferty Marketu
            marketPlayerOfferQuantity = Int32.Parse(textBoxPlayerOffer.Text);
            marketStoreOfferQuantity = Int32.Parse(textBoxMarketOffer.Text);

            // Obsluga transakcji (oferta Gracza)
            if (listBoxPlayerOffer.GetSelected(0) == true && (goldResources + marketStoreOfferQuantity) <= storageResources)
            {
                goldResources += marketPlayerOfferQuantity;
                timerGold.Start();
            }
            else if (listBoxPlayerOffer.GetSelected(1) == true && (lumberResources + marketStoreOfferQuantity) <= storageResources)
            {
                lumberResources += marketPlayerOfferQuantity; timerWood.Start();

            }
            else if (listBoxPlayerOffer.GetSelected(2) == true && (stoneResources + marketStoreOfferQuantity) <= storageResources)
            {
                stoneResources += marketPlayerOfferQuantity; timerStone.Start();

            }

            // Obsluga transakcji (oferta Marketu)
            if (listBoxMarketOffer.GetSelected(0) == true && (goldResources - marketStoreOfferQuantity) >= 0 )
            {
                goldResources -= marketStoreOfferQuantity; timerGold.Start();
            }
            else if (listBoxMarketOffer.GetSelected(1) == true && (lumberResources - marketStoreOfferQuantity) >= 0)
            {
                lumberResources -= marketStoreOfferQuantity; timerWood.Start();
            }
            else if (listBoxMarketOffer.GetSelected(2) == true && (stoneResources - marketStoreOfferQuantity) >= 0)
            {
                stoneResources -= marketStoreOfferQuantity; timerStone.Start();
            }
            // Restart timerow
            RestartResourcesTimers();
        }
        /// <summary>
        /// Obsluga zdarzenia zmiany zaznaczonego elementu listy listBoxMarketOffer
        /// </summary>
        private void ListBoxMarketOfferSelectItem(object sender, EventArgs e)
        {
            // Przekazanie do zmiennej wartości oferty Gracza
            marketPlayerOfferQuantity = Int32.Parse(textBoxPlayerOffer.Text);

            // Obsluga generowania oferty Marketu
            for (int i = 0; i < 3; i++)
            {
                if (listBoxMarketOffer.GetSelected(i) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (marketPlayerOfferQuantity).ToString();
                    marketStoreOfferQuantity = marketPlayerOfferQuantity;
                }
                if (listBoxMarketOffer.GetSelected((i + 1) % 3) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (Math.Round(marketPlayerOfferQuantity * marketTradeRatio)).ToString();
                    marketStoreOfferQuantity = (int)Math.Round(marketPlayerOfferQuantity * marketTradeRatio);
                }
                if (listBoxMarketOffer.GetSelected((i + 2) % 3) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (Math.Round(marketPlayerOfferQuantity * marketTradeRatio * 1.5)).ToString();
                    marketStoreOfferQuantity = (int)Math.Round(marketPlayerOfferQuantity * marketTradeRatio * 1.5);
                }
            }
        }
        /// <summary>
        /// Obsluga zdarzenia zmiany wartosci zasobow oferowanych przez Gracza 
        /// </summary>
        private void TextBoxPlayerOffer_TextChanged(object sender, EventArgs e)
        {
            // Przekazanie do zmiennej domyslnej wartosci oferty Gracza
            marketPlayerOfferQuantity = 0;

            // Obsluga generowania oferty Marketu
            for (int i = 0; i < 3; i++)
            {
                if (listBoxMarketOffer.GetSelected(i) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (marketPlayerOfferQuantity).ToString();
                    marketStoreOfferQuantity = marketPlayerOfferQuantity;
                }
                if (listBoxMarketOffer.GetSelected((i + 1) % 3) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (Math.Round(marketPlayerOfferQuantity * marketTradeRatio)).ToString();
                    marketStoreOfferQuantity = (int)Math.Round(marketPlayerOfferQuantity * marketTradeRatio);
                }
                if (listBoxMarketOffer.GetSelected((i + 2) % 3) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (Math.Round(marketPlayerOfferQuantity * marketTradeRatio * 1.5)).ToString();
                    marketStoreOfferQuantity = (int)Math.Round(marketPlayerOfferQuantity * marketTradeRatio * 1.5);
                }
            }
        }
        
    }
}
