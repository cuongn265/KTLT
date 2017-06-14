using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTienLenMienNam
{
    public partial class Form1 : Form
    {
        CardSet cardSet;
        Player computer;
        Player user;

        public Form1()
        {
            InitializeComponent();
        }


        public void DrawCard(Card card, char TypeOfPlayer, int NumberOfCard, char Status)
        {
            PictureBox pb = new PictureBox();
            pb.Visible = false;
            pb.Width = 71;
            pb.Height = 96;
            if (Status == '1')
            {
                switch (card.GetID())
                {
                    case "1C":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._1C;
                        pb.Tag = 47;
                        break;
                    case "1R":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._1R;
                        pb.Tag = 46;
                        break;
                    case "1H":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._1H;
                        pb.Tag = 45;
                        break;
                    case "1B":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._1B;
                        pb.Tag = 44;
                        break;
                    case "2C":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._2C;
                        pb.Tag = 51;
                        break;
                    case "2R":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._2R;
                        pb.Tag = 50;
                        break;
                    case "2H":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._2H;
                        pb.Tag = 49;
                        break;
                    case "2B":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._2B;
                        pb.Tag = 48;
                        break;
                    case "3C":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._3C;
                        pb.Tag = 3;
                        break;
                    case "3R":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._3R;
                        pb.Tag = 2;
                        break;
                    case "3H":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._3H;
                        pb.Tag = 1;
                        break;
                    case "3B":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._3B;
                        pb.Tag = 0;
                        break;
                    case "4C":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._4C;
                        pb.Tag = 7;
                        break;
                    case "4R":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._4R;
                        pb.Tag = 6;
                        break;
                    case "4H":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._4H;
                        pb.Tag = 5;
                        break;
                    case "4B":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._4B;
                        pb.Tag = 4;
                        break;
                    case "5C":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._5C;
                        pb.Tag = 11;
                        break;
                    case "5R":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._5R;
                        pb.Tag = 10;
                        break;
                    case "5H":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._5H;
                        pb.Tag = 9;
                        break;
                    case "5B":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._5B;
                        pb.Tag = 8;
                        break;
                    case "6C":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._6C;
                        pb.Tag = 15;
                        break;
                    case "6R":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._6R;
                        pb.Tag = 14;
                        break;
                    case "6H":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._6H;
                        pb.Tag = 13;
                        break;
                    case "6B":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._6B;
                        pb.Tag = 12;
                        break;
                    case "7C":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._7C;
                        pb.Tag = 19;
                        break;
                    case "7R":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._7R;
                        pb.Tag = 18;
                        break;
                    case "7H":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._7H;
                        pb.Tag = 17;
                        break;
                    case "7B":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._7B;
                        pb.Tag = 16;
                        break;
                    case "8C":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._8C;
                        pb.Tag = 23;
                        break;
                    case "8R":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._8R;
                        pb.Tag = 22;
                        break;
                    case "8H":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._8H;
                        pb.Tag = 21;
                        break;
                    case "8B":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._8B;
                        pb.Tag = 20;
                        break;
                    case "9C":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._9C;
                        pb.Tag = 27;
                        break;
                    case "9R":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._9R;
                        pb.Tag = 26;
                        break;
                    case "9H":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._9H;
                        pb.Tag = 25;
                        break;
                    case "9B":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._9B;
                        pb.Tag = 24;
                        break;
                    case "10C":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._10C;
                        pb.Tag = 31;
                        break;
                    case "10R":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._10R;
                        pb.Tag = 30;
                        break;
                    case "10H":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._10H;
                        pb.Tag = 29;
                        break;
                    case "10B":
                        pb.Image = BaiTienLenMienNam.Properties.Resources._10B;
                        pb.Tag = 28;
                        break;
                    case "JC":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.JC;
                        pb.Tag = 35;
                        break;
                    case "JR":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.JR;
                        pb.Tag = 34;
                        break;
                    case "JH":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.JH;
                        pb.Tag = 33;
                        break;
                    case "JB":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.JB;
                        pb.Tag = 32;
                        break;
                    case "QC":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.QC;
                        pb.Tag = 39;
                        break;
                    case "QR":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.QR;
                        pb.Tag = 38;
                        break;
                    case "QH":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.QH;
                        pb.Tag = 37;
                        break;
                    case "QB":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.QB;
                        pb.Tag = 36;
                        break;
                    case "KC":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.KC;
                        pb.Tag = 43;
                        break;
                    case "KR":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.KR;
                        pb.Tag = 42;
                        break;
                    case "KH":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.KH;
                        pb.Tag = 41;
                        break;
                    case "KB":
                        pb.Image = BaiTienLenMienNam.Properties.Resources.KB;
                        pb.Tag = 40;
                        break;
                }
            }
            else
            {
                pb.Image = BaiTienLenMienNam.Properties.Resources.CB;
            }
            if (TypeOfPlayer == '0')
            {
                switch (NumberOfCard)
                {
                    case 1:
                        pictureBox1.Image = pb.Image;
                        pictureBox1.Tag = pb.Tag;
                        pictureBox1.Visible = true;
                        break;
                    case 2:
                        pictureBox2.Image = pb.Image;
                        pictureBox2.Tag = pb.Tag;
                        pictureBox2.Visible = true;
                        break;
                    case 3:
                        pictureBox3.Image = pb.Image;
                        pictureBox3.Tag = pb.Tag;
                        pictureBox3.Visible = true;
                        break;
                    case 4:
                        pictureBox4.Image = pb.Image;
                        pictureBox4.Tag = pb.Tag;
                        pictureBox4.Visible = true;
                        break;
                    case 5:
                        pictureBox5.Image = pb.Image;
                        pictureBox5.Tag = pb.Tag;
                        pictureBox5.Visible = true;
                        break;
                    case 6:
                        pictureBox6.Image = pb.Image;
                        pictureBox6.Tag = pb.Tag;
                        pictureBox6.Visible = true;
                        break;
                    case 7:
                        pictureBox7.Image = pb.Image;
                        pictureBox7.Tag = pb.Tag;
                        pictureBox7.Visible = true;
                        break;
                    case 8:
                        pictureBox8.Image = pb.Image;
                        pictureBox8.Tag = pb.Tag;
                        pictureBox8.Visible = true;
                        break;
                    case 9:
                        pictureBox9.Image = pb.Image;
                        pictureBox9.Tag = pb.Tag;
                        pictureBox9.Visible = true;
                        break;
                    case 10:
                        pictureBox10.Image = pb.Image;
                        pictureBox10.Tag = pb.Tag;
                        pictureBox10.Visible = true;
                        break;
                    case 11:
                        pictureBox11.Image = pb.Image;
                        pictureBox11.Tag = pb.Tag;
                        pictureBox11.Visible = true;
                        break;
                    case 12:
                        pictureBox12.Image = pb.Image;
                        pictureBox12.Tag = pb.Tag;
                        pictureBox12.Visible = true;
                        break;
                    case 13:
                        pictureBox13.Image = pb.Image;
                        pictureBox13.Tag = pb.Tag;
                        pictureBox13.Visible = true;
                        break;
                }
            }
            else
            {
                switch (NumberOfCard)
                {
                    case 1:
                        pictureBox14.Image = pb.Image;
                        pictureBox14.Tag = pb.Tag;
                        pictureBox14.Visible = true;
                        break;
                    case 2:
                        pictureBox15.Image = pb.Image;
                        pictureBox15.Tag = pb.Tag;
                        pictureBox15.Visible = true;
                        break;
                    case 3:
                        pictureBox16.Image = pb.Image;
                        pictureBox16.Tag = pb.Tag;
                        pictureBox16.Visible = true;
                        break;
                    case 4:
                        pictureBox17.Image = pb.Image;
                        pictureBox17.Tag = pb.Tag;
                        pictureBox17.Visible = true;
                        break;
                    case 5:
                        pictureBox18.Image = pb.Image;
                        pictureBox18.Tag = pb.Tag;
                        pictureBox18.Visible = true;
                        break;
                    case 6:
                        pictureBox19.Image = pb.Image;
                        pictureBox19.Tag = pb.Tag;
                        pictureBox19.Visible = true;
                        break;
                    case 7:
                        pictureBox20.Image = pb.Image;
                        pictureBox20.Tag = pb.Tag;
                        pictureBox20.Visible = true;
                        break;
                    case 8:
                        pictureBox21.Image = pb.Image;
                        pictureBox21.Tag = pb.Tag;
                        pictureBox21.Visible = true;
                        break;
                    case 9:
                        pictureBox22.Image = pb.Image;
                        pictureBox22.Tag = pb.Tag;
                        pictureBox22.Visible = true;
                        break;
                    case 10:
                        pictureBox23.Image = pb.Image;
                        pictureBox23.Tag = pb.Tag;
                        pictureBox23.Visible = true;
                        break;
                    case 11:
                        pictureBox24.Image = pb.Image;
                        pictureBox24.Tag = pb.Tag;
                        pictureBox24.Visible = true;
                        break;
                    case 12:
                        pictureBox25.Image = pb.Image;
                        pictureBox25.Tag = pb.Tag;
                        pictureBox25.Visible = true;
                        break;
                    case 13:
                        pictureBox26.Image = pb.Image;
                        pictureBox26.Tag = pb.Tag;
                        pictureBox26.Visible = true;
                        break;
                }
            }
        }
        public void NewGame()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            computer = new Player();
            computer.SetType('0');
            user = new Player();
            user.SetType('1');
            cardSet = new CardSet();
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');
            this.DrawCard(computer.WithdrawCard(cardSet), computer.GetT(), computer.GetNumberOfCards(), '1');
            this.DrawCard(user.WithdrawCard(cardSet), user.GetT(), user.GetNumberOfCards(), '1');

            Console.WriteLine(cardSet.ToString());
            sortCards();
            bt_BĐ.Visible = false;
            bt_BQ.Visible = true;
            bt_RB.Visible = true;
        }
        PictureBox[] playerDeckPictureBoxes;
        PictureBox[] computerDecksPictureBoxes;
        List<PictureBox> cardsOnTable;

        private void sortCards()
        {

            int j;
            Image temp;
            int temp2;
            for (int i = 0; i < playerDeckPictureBoxes.Length + 1; i++)
            {
                for (j = i + 1; j < playerDeckPictureBoxes.Length; j++)
                {
                    if (Int32.Parse(playerDeckPictureBoxes[i].Tag.ToString()) > Int32.Parse(playerDeckPictureBoxes[j].Tag.ToString()))
                    {
                        temp = playerDeckPictureBoxes[i].Image;
                        temp2 = Int32.Parse(playerDeckPictureBoxes[i].Tag.ToString());
                        playerDeckPictureBoxes[i].Image = playerDeckPictureBoxes[j].Image;
                        playerDeckPictureBoxes[i].Tag = playerDeckPictureBoxes[j].Tag;
                        playerDeckPictureBoxes[j].Image = temp;
                        playerDeckPictureBoxes[j].Tag = temp2;
                    }
                }
            }
            for (int i = 0; i < computerDecksPictureBoxes.Length + 1; i++)
            {
                for (j = i + 1; j < computerDecksPictureBoxes.Length; j++)
                {
                    if (Int32.Parse(computerDecksPictureBoxes[i].Tag.ToString()) > Int32.Parse(computerDecksPictureBoxes[j].Tag.ToString()))
                    {
                        temp = computerDecksPictureBoxes[i].Image;
                        temp2 = Int32.Parse(computerDecksPictureBoxes[i].Tag.ToString());
                        computerDecksPictureBoxes[i].Image = computerDecksPictureBoxes[j].Image;
                        computerDecksPictureBoxes[i].Tag = computerDecksPictureBoxes[j].Tag;
                        computerDecksPictureBoxes[j].Image = temp;
                        computerDecksPictureBoxes[j].Tag = temp2;
                    }
                }
            }
            for (int i = 1; i < playerDeckPictureBoxes.Length; i++)
            {
                Console.WriteLine(playerDeckPictureBoxes[i].Tag);
            }
        }

        private void bt_BĐ_Click(object sender, EventArgs e)
        {
            this.NewGame();

        }
        private bool playerDecksCardIsClick = false;
        private int numberClick = 0;
        private int[] numberClicks = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            switch (pictureBox.Name)
            {
                case "pictureBox14":
                    numberClicks[0]++;
                    numberClick = numberClicks[0];
                    break;
                case "pictureBox15":
                    numberClicks[1]++;
                    numberClick = numberClicks[1];
                    break;
                case "pictureBox16":
                    numberClicks[2]++;
                    numberClick = numberClicks[2];
                    break;
                case "pictureBox17":
                    numberClicks[3]++;
                    numberClick = numberClicks[3];
                    break;
                case "pictureBox18":
                    numberClicks[4]++;
                    numberClick = numberClicks[4];
                    break;
                case "pictureBox19":
                    numberClicks[5]++;
                    numberClick = numberClicks[5];
                    break;
                case "pictureBox20":
                    numberClicks[6]++;
                    numberClick = numberClicks[6];
                    break;
                case "pictureBox21":
                    numberClicks[7]++;
                    numberClick = numberClicks[7];
                    break;
                case "pictureBox22":
                    numberClicks[8]++;
                    numberClick = numberClicks[8];
                    break;
                case "pictureBox23":
                    numberClicks[9]++;
                    numberClick = numberClicks[9];
                    break;
                case "pictureBox24":
                    numberClicks[10]++;
                    numberClick = numberClicks[10];
                    break;
                case "pictureBox25":
                    numberClicks[11]++;
                    numberClick = numberClicks[11];
                    break;
                case "pictureBox26":
                    numberClicks[12]++;
                    numberClick = numberClicks[12];
                    break;
                default:
                    break;
            }
            int x = pictureBox.Location.X;
            int y = pictureBox.Location.Y;
            if (numberClick % 2 == 1)
            {
                playerDecksCardIsClick = true;
                pictureBox.Location = new Point(x, y - 22);
            }
            if (numberClick % 2 == 0)
            {
                playerDecksCardIsClick = false;
                pictureBox.Location = new Point(x, y + 22);
            }
            Console.WriteLine(pictureBox.Tag.ToString());
        }

        private void bt_RB_Click(object sender, EventArgs e)
        {

            cardsOnTable = new List<PictureBox>();
            PictureBox p = new PictureBox();
            int x = 500;
            int y = 160;
            for (int i = 0; i < numberClicks.Length; i++)
            {
                if (numberClicks[i] % 2 == 1)
                {
                    string name = "pictureBox" + (i + 14).ToString();
                    p = (PictureBox)Controls.Find(name, true)[0];
                    cardsOnTable.Add(p);
                    numberClicks[i] = 0;
                }
            }
            if (cardsOnTable.Count() == 2)
            {
                int a = Int32.Parse(cardsOnTable[0].Tag.ToString());
                int b = Int32.Parse(cardsOnTable[1].Tag.ToString());

                if (a / 4 == b / 4)
                {
                    DisposeCard();
                    cardsOnTable[0].Location = new Point(x, y);
                    x = x + 30;
                    cardsOnTable[1].Location = new Point(x, y);
                }
                else
                {
                    MessageBox.Show("Bài không hợp lệ!!!!", "Tiến Lên Miền Nam",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    int id = Int32.Parse(cardsOnTable[0].Name.ToString().Substring(10));
                    int id1 = Int32.Parse(cardsOnTable[1].Name.ToString().Substring(10));
                    numberClicks[id - 14] = 1;
                    numberClicks[id1 - 14] = 1;
                    DisposeCard();
                    resetPlayerCardsPosition();
                }
            }
            else if (cardsOnTable.Count() == 3)
            {
                // ba doi, ba loc
                int a = ToInteger(cardsOnTable[0].Tag.ToString()) / 4;
                int b = ToInteger(cardsOnTable[1].Tag.ToString()) / 4;
                int c = ToInteger(cardsOnTable[2].Tag.ToString()) / 4;
                float tb = (float)(a + b + c) / 3;
                Console.WriteLine("TB: " + tb);

                if (tb == a || tb == b || tb == c)
                {
                    cardsOnTable[0].Location = new Point(x, y);
                    x = x + 30;
                    cardsOnTable[1].Location = new Point(x, y);
                    x = x + 30;
                    cardsOnTable[2].Location = new Point(x, y);
                }
                else
                {
                    //Bai khong hop le
                    resetPlayerCardsPosition();
                    return;
                }
            }
            else
            {
                if (cardsOnTable.Count == 1)
                {
                    DisposeCard();
                    cardsOnTable[0].Location = new Point(x, y);
                }
            }
            ComputerPlay();
        }
        private int ToInteger(Object tag)
        {
            return Int32.Parse(tag.ToString());
        }
        private void ComputerPlay()
        {
            int x = 500;
            int y = 160;
            if (cardsOnTable.Count == 0)
            {
                // Computer begin turn

            }
            if (cardsOnTable.Count == 2)
            {
                for (int i = 0; i < computerDecksPictureBoxes.Length - 1; i++)
                {
                    if (((ToInteger(computerDecksPictureBoxes[i].Tag) / 4) == (ToInteger(computerDecksPictureBoxes[i + 1].Tag) / 4)))
                    {
                        if ((ToInteger(computerDecksPictureBoxes[i].Tag) + ToInteger(computerDecksPictureBoxes[i + 1].Tag) > ((ToInteger(cardsOnTable[0].Tag) + (ToInteger(cardsOnTable[1].Tag))))))
                        {
                            DisposeCard();
                            computerDecksPictureBoxes[i].Location = new Point(x, y);
                            x = x + 30;
                            computerDecksPictureBoxes[i + 1].Location = new Point(x, y);
                            return;
                        }
                    }
                }
                MessageBox.Show("Máy bỏ!!!", "Tiến Lên Miền Nam",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DisposeCard();

            }
            else if (cardsOnTable.Count == 3)
            {
                // 2 truong hop: 3 quan va loc
                Console.WriteLine("Tiep chieu !");


                int a = tagToCardValue(cardsOnTable[0].Tag);
                int b = tagToCardValue(cardsOnTable[1].Tag);
                int c = tagToCardValue(cardsOnTable[2].Tag);
                Console.WriteLine("Player card value {0}, {1}, {2}", a, b, c);


                if (a == b && b == c)
                {
                    // 3 quan giong nhau
                    for (int i = 0; i < computerDecksPictureBoxes.Length - 2; i++)
                    {
                        if ((tagToCardValue(computerDecksPictureBoxes[i].Tag) == tagToCardValue(computerDecksPictureBoxes[i + 1].Tag)) && (tagToCardValue(computerDecksPictureBoxes[i].Tag) == tagToCardValue(computerDecksPictureBoxes[i + 2].Tag) - 2))
                        {
                            DisposeCard();
                            // play cards
                            computerDecksPictureBoxes[i].Location = new Point(x, y);
                            x = x + 30;
                            computerDecksPictureBoxes[i + 1].Location = new Point(x, y);
                            x = x + 30;
                            computerDecksPictureBoxes[i + 2].Location = new Point(x, y);
                            return;
                        }
                    }
                }
                else
                {
                    // sanh 3 quan
                    int pointerIndex = 0;
                    for (int i = 0; i < computerDecksPictureBoxes.Length; i++)
                    {
                        if (tagToCardValue(cardsOnTable[0].Tag) == tagToCardValue(computerDecksPictureBoxes[i].Tag))
                        {
                            pointerIndex = i;
                            break;
                        }
                    }
                    for (int i = pointerIndex; i < computerDecksPictureBoxes.Length - 2; i++)
                    {



                        if ((tagToCardValue(computerDecksPictureBoxes[i].Tag) == tagToCardValue(computerDecksPictureBoxes[i + 1].Tag) - 1) &&
                            (tagToCardValue(computerDecksPictureBoxes[i].Tag) == tagToCardValue(computerDecksPictureBoxes[i + 2].Tag) - 2)
                            )
                        {
                            DisposeCard();
                            computerDecksPictureBoxes[i].Location = new Point(x, y);
                            x = x + 30;
                            computerDecksPictureBoxes[i + 1].Location = new Point(x, y);
                            x = x + 30;
                            computerDecksPictureBoxes[i + 2].Location = new Point(x, y);
                            // End turn
                            return;
                        }
                    }
                    Console.WriteLine("Deo danh duoc");
                }
            }
            else
            {
                if (cardsOnTable.Count == 1)
                {
                    for (int i = 0; i < computerDecksPictureBoxes.Length; i++)
                    {
                        if ((ToInteger(computerDecksPictureBoxes[i].Tag) > ((ToInteger(cardsOnTable[0].Tag)))))
                        {
                            DisposeCard();
                            computerDecksPictureBoxes[i].Location = new Point(x, y);
                            return;
                        }

                    }
                    MessageBox.Show("Máy bỏ!!!", "Tiến Lên Miền Nam",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    DisposeCard();
                    Console.WriteLine("em bo luot");
                    return;

                }
            }
            return;
        }

        private void DisposeCard()
        {
            foreach (PictureBox p in cardsOnTable)
            {
                p.Dispose();
            }
        }

        private int tagToCardValue(Object tag)
        {
            return ToInteger(tag.ToString()) / 4 + 3;
        }
        private int tagToCardType(Object tag)
        {
            /**
             * 0: B
             * 1: H
             * 2: R
             * 3: C
             */
            return ToInteger(tag.ToString()) % 4;
        }

        private void resetPlayerCardsPosition()
        {
            foreach (var picturebox in playerDeckPictureBoxes)
            {
                int x = picturebox.Location.X;
                picturebox.Location = new Point(x, 316);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerDeckPictureBoxes = new PictureBox[13] { pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26 };
            computerDecksPictureBoxes = new PictureBox[13] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13 };
        }

        private void bt_BQ_Click(object sender, EventArgs e)
        {
            ComputerPlay();
        }

    }
}
