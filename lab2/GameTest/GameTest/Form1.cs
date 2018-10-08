using System;
using System.Windows.Forms;

namespace GameTest
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Magazyn
        /// </summary>
        Storage storage = new Storage();
        /// <summary>
        /// Kopalnia Złota
        /// </summary>
        GoldMine goldMine = new GoldMine();
        /// <summary>
        /// Tartak
        /// </summary>
        LumberMill lumberMill = new LumberMill();
        /// <summary>
        /// Kamieniołom
        /// </summary>
        StoneMine stoneMine = new StoneMine();
        /// <summary>
        /// Market
        /// </summary>
        Market market = new Market();

        public FormMain()
        {
            InitializeComponent();
            ///
            /// Restart wszystkich labeli
            /// 
            RestartLabels();
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
            labelStorageLevel.Text = "Poziom " + storage.Level;
            labelGoldMineLevel.Text = "Poziom " + goldMine.Level;
            labelLumberMillLevel.Text = "Poziom " + lumberMill.Level;
            labelStoneMineLevel.Text = "Poziom " + stoneMine.Level;
            labelMarketLevel.Text = "Poziom " + market.Level;
            ///
            /// Start licznikow surowcow
            ///
            timerGold.Start();
            timerStone.Start();
            timerWood.Start();
            ///
            /// Dodanie wierszy do dataGridViewUpgradePrices
            ///
            for(int i = 0; i < 10; i++)
            dataGridViewUpgradePrices.Rows.Add((i+1).ToString()+"->"+(i+2).ToString(),
                                               String.Join("/", storage.GetPrices(3, i)),
                                               String.Join("/", goldMine.GetPrices(3, i)),
                                               String.Join("/", lumberMill.GetPrices(3, i)),
                                               String.Join("/", stoneMine.GetPrices(3, i)),
                                               String.Join("/", market.GetPrices(3, i)));
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
            labelGold.Text = CommonStuff.goldResources.ToString();
            labelWood.Text = CommonStuff.lumberResources.ToString();
            labelStone.Text = CommonStuff.lumberResources.ToString();
            labelPlace.Text = CommonStuff.storageResources.ToString();

            labelStorageLevel.Text = "Poziom " + storage.Level;
            labelGoldMineLevel.Text = "Poziom " + goldMine.Level;
            labelLumberMillLevel.Text = "Poziom " + lumberMill.Level;
            labelStoneMineLevel.Text = "Poziom " + stoneMine.Level;
            labelMarketLevel.Text = "Poziom " + market.Level;
        }
        /// <summary>
        /// Obsluga timera zwiekszajacego poziom posiadanych zasobow zlota
        /// </summary>
        private void TimerGold_Tick(object sender, EventArgs e)
        {
            CommonStuff.goldResources++;
            labelGold.Text = CommonStuff.goldResources.ToString();
            if (CommonStuff.goldResources == CommonStuff.storageResources)
            {
                timerGold.Stop();
                CommonStuff.goldResources = CommonStuff.storageResources - 1;
            }
        }
        /// <summary>
        /// Obsluga timera zwiekszajacego poziom posiadancyh zasobow drewna
        /// </summary>
        private void TimerWood_Tick(object sender, EventArgs e)
        {
            CommonStuff.lumberResources++;
            labelWood.Text = CommonStuff.lumberResources.ToString();
            if (CommonStuff.lumberResources >= CommonStuff.storageResources)
            {
                timerWood.Stop();
                CommonStuff.lumberResources = CommonStuff.storageResources - 1;
            }
        }
        /// <summary>
        /// Obsluga timera zwiekszajacego poziom posiadancyh zasobow kamienia
        /// </summary>
        private void TimerStone_Tick(object sender, EventArgs e)
        {
            CommonStuff.stoneResources++;
            labelStone.Text = CommonStuff.stoneResources.ToString();
            if (CommonStuff.stoneResources == CommonStuff.storageResources)
            {
                timerStone.Stop();
                CommonStuff.stoneResources = CommonStuff.storageResources - 1;
            }
        }
        /// <summary>
        /// Obsluga buttona rozwoju magazynu
        /// </summary>
        private void ButtonStorageUpgrade_Click(object sender, EventArgs e)
        {
            /// Uruchomienie procesu rozbydowy Magazynu
            storage.Upgrade(progressBarStorage, timerStorageBuild, buttonStorageUpgrade, pictureBoxStorage, imageListBuildings);
            /// Restart timerow i labeli
            RestartResourcesTimers();
            RestartLabels();
            /// Wlaczenie guzika budowy Marketu
            if (storage.Level >= 6)
                buttonMarketUpgrade.Enabled = true;
        }
        /// <summary>
        /// Obsluga buttona rozwoju Kopalni Zlota
        /// </summary>
        private void ButtonGoldMineUpgrade_Click(object sender, EventArgs e)
        {
            /// Uruchomienie procesu rozbudowy Kopalni Złota
            goldMine.Upgrade(progressBarGoldMine, timerGoldMineBuild, buttonGoldMineUpgrade, pictureBoxGoldMine, imageListBuildings);
            /// Restart timerow i labeli
            RestartResourcesTimers();
            RestartLabels();
        }
        /// <summary>
        /// Obsluga buttona rozwoju Tartaku
        /// </summary>
        private void ButtonLumberMillUpgrade_Click(object sender, EventArgs e)
        {
            /// Uruchomienie procesu rozbudowy Tartaka
            lumberMill.Upgrade(progressBarLumberMill, timerLumberMillBuild, buttonLumberMillUpgrade, pictureBoxLumberMill, imageListBuildings);
            /// Restart timerow i labeli
            RestartResourcesTimers();
            RestartLabels();
        }
        /// <summary>
        /// Obsluga buttona rozwoju Kamieniolomu
        /// </summary>
        private void ButtonStoneMineUpgrade_Click(object sender, EventArgs e)
        {
            /// Uruchomienie procesu rozbudowy Kamieniołomu
            stoneMine.Upgrade(progressBarStoneMine, timerStoneMineBuild, buttonStoneMineUpgrade, pictureBoxStoneMine, imageListBuildings);
            /// Restart timerow i labeli
            RestartResourcesTimers();
            RestartLabels();
        }
        /// <summary>
        /// Obsluga buttona rozwoju Marketu
        /// </summary>
        private void ButtonMarketUpgrade_Click(object sender, EventArgs e)
        {
            /// Uruchomienie procesu rozbudowy Makretu
            market.Upgrade(progressBarMarket, timerMarketBuild, buttonMarketUpgrade, pictureBoxMarket, imageListBuildings);
            /// Przypadek gdy Market nie jest zbudowany
            if (market.Level == 0 &&
                    CommonStuff.goldResources >= 360 &&
                    CommonStuff.lumberResources >= 310 &&
                    CommonStuff.stoneResources >= 320)
                {
                    market.Level++;
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
            /// Restart timerow i labeli
            RestartResourcesTimers();
            RestartLabels();
        }
        /// <summary>
        /// Obsluga buttona dokonania wymiany z Marketem
        /// </summary>
        private void ButtonBuy_Click(object sender, EventArgs e)
        {
            // Przekazanie do zmiennej wartosci oferty Gracza i wartosci oferty Marketu
            CommonStuff.marketPlayerOfferQuantity = Int32.Parse(textBoxPlayerOffer.Text);
            CommonStuff.marketStoreOfferQuantity = Int32.Parse(textBoxMarketOffer.Text);

            // Obsluga transakcji (oferta Gracza)
            if (listBoxPlayerOffer.GetSelected(0) == true && (CommonStuff.goldResources + CommonStuff.marketStoreOfferQuantity) <= CommonStuff.storageResources)
            {
                CommonStuff.goldResources += CommonStuff.marketPlayerOfferQuantity;
                timerGold.Start();
            }
            else if (listBoxPlayerOffer.GetSelected(1) == true && (CommonStuff.lumberResources + CommonStuff.marketStoreOfferQuantity) <= CommonStuff.storageResources)
            {
                CommonStuff.lumberResources += CommonStuff.marketPlayerOfferQuantity; timerWood.Start();

            }
            else if (listBoxPlayerOffer.GetSelected(2) == true && (CommonStuff.stoneResources + CommonStuff.marketStoreOfferQuantity) <= CommonStuff.storageResources)
            {
                CommonStuff.stoneResources += CommonStuff.marketPlayerOfferQuantity; timerStone.Start();

            }

            // Obsluga transakcji (oferta Marketu)
            if (listBoxMarketOffer.GetSelected(0) == true && (CommonStuff.goldResources - CommonStuff.marketStoreOfferQuantity) >= 0 )
            {
                CommonStuff.goldResources -= CommonStuff.marketStoreOfferQuantity; timerGold.Start();
            }
            else if (listBoxMarketOffer.GetSelected(1) == true && (CommonStuff.lumberResources - CommonStuff.marketStoreOfferQuantity) >= 0)
            {
                CommonStuff.lumberResources -= CommonStuff.marketStoreOfferQuantity; timerWood.Start();
            }
            else if (listBoxMarketOffer.GetSelected(2) == true && (CommonStuff.stoneResources - CommonStuff.marketStoreOfferQuantity) >= 0)
            {
                CommonStuff.stoneResources -= CommonStuff.marketStoreOfferQuantity; timerStone.Start();
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
            CommonStuff.marketPlayerOfferQuantity = Int32.Parse(textBoxPlayerOffer.Text);

            // Obsluga generowania oferty Marketu
            for (int i = 0; i < 3; i++)
            {
                if (listBoxMarketOffer.GetSelected(i) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (CommonStuff.marketPlayerOfferQuantity).ToString();
                    CommonStuff.marketStoreOfferQuantity = CommonStuff.marketPlayerOfferQuantity;
                }
                if (listBoxMarketOffer.GetSelected((i + 1) % 3) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (Math.Round(CommonStuff.marketPlayerOfferQuantity * CommonStuff.marketTradeRatio)).ToString();
                    CommonStuff.marketStoreOfferQuantity = (int)Math.Round(CommonStuff.marketPlayerOfferQuantity * CommonStuff.marketTradeRatio);
                }
                if (listBoxMarketOffer.GetSelected((i + 2) % 3) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (Math.Round(CommonStuff.marketPlayerOfferQuantity * CommonStuff.marketTradeRatio * 1.5)).ToString();
                    CommonStuff.marketStoreOfferQuantity = (int)Math.Round(CommonStuff.marketPlayerOfferQuantity * CommonStuff.marketTradeRatio * 1.5);
                }
            }
        }
        /// <summary>
        /// Obsluga zdarzenia zmiany wartosci zasobow oferowanych przez Gracza 
        /// </summary>
        private void TextBoxPlayerOffer_TextChanged(object sender, EventArgs e)
        {
            // Przekazanie do zmiennej domyslnej wartosci oferty Gracza
            CommonStuff.marketPlayerOfferQuantity = 0;

            // Obsluga generowania oferty Marketu
            for (int i = 0; i < 3; i++)
            {
                if (listBoxMarketOffer.GetSelected(i) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (CommonStuff.marketPlayerOfferQuantity).ToString();
                    CommonStuff.marketStoreOfferQuantity = CommonStuff.marketPlayerOfferQuantity;
                }
                if (listBoxMarketOffer.GetSelected((i + 1) % 3) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (Math.Round(CommonStuff.marketPlayerOfferQuantity * CommonStuff.marketTradeRatio)).ToString();
                    CommonStuff.marketStoreOfferQuantity = (int)Math.Round(CommonStuff.marketPlayerOfferQuantity * CommonStuff.marketTradeRatio);
                }
                if (listBoxMarketOffer.GetSelected((i + 2) % 3) == true && listBoxPlayerOffer.GetSelected(i) == true)
                {
                    textBoxMarketOffer.Text = (Math.Round(CommonStuff.marketPlayerOfferQuantity * CommonStuff.marketTradeRatio * 1.5)).ToString();
                    CommonStuff.marketStoreOfferQuantity = (int)Math.Round(CommonStuff.marketPlayerOfferQuantity * CommonStuff.marketTradeRatio * 1.5);
                }
            }
        }
        /// <summary>
        /// Obsluga timera odpowiedzialnego za proces rozbudowy Magazynu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStorageBuild_Tick(object sender, EventArgs e)
        {
            this.progressBarStorage.Increment(1);
        }
        /// <summary>
        /// Obsluga timera odpowiedzialnego za proces rozbudowy Kopalni Złota 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGoldMineBuild_Tick(object sender, EventArgs e)
        {
            this.progressBarGoldMine.Increment(1);
        }
        /// <summary>
        /// Obsluga timera odpowiedzialnego za proces rozbudowy Tartaka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerLumberMillBuild_Tick(object sender, EventArgs e)
        {
            this.progressBarLumberMill.Increment(1);
        }
        /// <summary>
        /// Obsluga timera odpowiedzialnego za proces rozbudowy Kamieniołomu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStoneMineBuild_Tick(object sender, EventArgs e)
        {
            this.progressBarStoneMine.Increment(1);
        }
        /// <summary>
        /// Obsluga timera odpowiedzialnego za proces rozbudowy Marketu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMarketBuild_Tick(object sender, EventArgs e)
        {
            this.progressBarMarket.Increment(1);
        }
    }
}
