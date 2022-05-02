
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Threading;


namespace GameBasic
{
    public partial class New_Form : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private int yourMoney = 0; //biến lưu trữ tiền vốn
        //private int yourMoney2 = 0;
        private int cuoc;
        private int temp;
        //private bool check;
        private System.Windows.Forms.Timer formClosingTimer;
        Random dice = new Random();
        int num1, num2, num3;
        public New_Form()
        {
            InitializeComponent();
            player.URL = @"D:\GameBasic\music\music.mp4";
        }
        private void OnPageLoad(object sender, EventArgs e)
        {
            Credit_Money();
            //Program.Save_file(yourMoney);
            player.controls.play();
            player.settings.playCount = 3;
            formClosingTimer = new System.Windows.Forms.Timer();
            //formClosingTimer.Tick += new EventHandler(CloseForm); // Defining tick event to invoke after a time period
            formClosingTimer.Interval = 2000; // Time Interval in miliseconds
            formClosingTimer.Start(); // Starting a timer

        }
        private void enable_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }
        private void unmute_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }
        //Hàm tiền vốn
        public void Credit_Money()
        {
            if (Program.check == true)
            {
                yourMoney += Program.money_push;
                your_money.Text = yourMoney.ToString();
            }
            //else if (Program.check == false && Program.money_push == 0 ) {
            //    MessageBox.Show("Bạn chưa nạp tiền");
            //    Print_money();
            //}
            //else if (Program.check == true && Program.first_money==0)
            //{
            //    MessageBox.Show("Bạn chưa nạp tiền");
            //    Print_money();
            //}
            else if (Program.check == false)
            {
                yourMoney = Program.money_credits;
                your_money.Text = yourMoney.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa nạp tiền");
            }

        }
        private void equal_TextChanged(object sender, EventArgs e)
        {

            if (number.Text != "")
            {
                try
                {
                    cuoc = Int32.Parse(number.Text.Trim());

                }
                catch
                {
                    MessageBox.Show("Bạn nhập không hợp lệ");
                    number.Text = "";
                    number.Focus();
                }
            }

            //else
            //{
            //    MessageBox.Show("Bạn ASDASDA được nhập chữ");
            //}
        }
        private void btnSetting(object sender, EventArgs e)
        {

            Control click = ((Control)sender);
            click.BackColor = Color.Yellow;
        }

        private void even_Click(object sender, EventArgs e)
        {
            temp = 1;
            btnSetting(even, null);
            if (even.BackColor == Color.Yellow)
            {
                odd.BackColor = Color.Gray;
            }
        }

        private void odd_Click_1(object sender, EventArgs e)
        {
            temp = 2;
            btnSetting(odd, null);
            if (odd.BackColor == Color.Yellow)
            {
                even.BackColor = Color.Gray;
            }

        }
        //Nút quay chẵn lẻ
        private void Roll(object sender, EventArgs e)
        {
            int c;
            if (yourMoney < 0)
            {
                MessageBox.Show("Ban da het tien");

            }
            else
            {
                if (!int.TryParse(number.Text, out c))
                {
                    MessageBox.Show("Can ban nhap tien cuoc");

                }
                else
                {
                    int checkNumber = Int32.Parse(number.Text.Trim());
                    if (checkNumber > yourMoney || checkNumber < 0)
                    {
                        MessageBox.Show("Tien cuoc khong hop le");
                    }
                    else if (temp != 1 && temp != 2)
                    {
                        MessageBox.Show("Ban chua chon chan le");
                    }
                    else
                    {
                        Random();
                        int equal1 = num1 + num2 + num3;
                        OddandEven(equal1);
                        textBox2.Text = equal1.ToString();
                    }
                }
            }
        }
        //Nút nạp tiền
        private void recharge_Click(object sender, EventArgs e)
        {
            Program.check = true;
            Recharge new_form = new Recharge();
            if (yourMoney >= 0)
            {
                this.Hide();
                new_form.ShowDialog();
                this.Show();

                Credit_Money();
                //this.Refresh();
            }
            else
            {
                if (MessageBox.Show("Ban dang no " + yourMoney * -1 + ", Ban co muon nap tien", "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Hide();
                    new_form.ShowDialog();
                    this.Show();
                    Program.check = true;
                    Credit_Money();
                }
                else
                {
                    return;
                }
            }
        }
        //Hàm Random
        private void Random()
        {
            int Random1 = dice.Next(1, 7);
            int Random2 = dice.Next(1, 7);
            int Random3 = dice.Next(1, 7);

            switch (Random1)
            {
                case 1:
                    pictureBox1.ImageLocation = @"D:\GameBasic\img\1.png";
                    num1 = 1;
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"D:\GameBasic\img\2.png";
                    num1 = 2;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"D:\GameBasic\img\3.png";
                    num1 = 3;
                    break;

                case 4:
                    pictureBox1.ImageLocation = @"D:\GameBasic\img\4.png";
                    num1 = 4;
                    break;

                case 5:
                    pictureBox1.ImageLocation = @"D:\GameBasic\img\5.png";
                    num1 = 5;
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"D:\GameBasic\img\6.png";
                    num1 = 6;
                    break;
                default:
                    pictureBox1.ImageLocation = @"D:\GameBasic\img\1.png";
                    num1 = 1;
                    break;

            }

            switch (Random2)
            {
                case 1:
                    pictureBox2.ImageLocation = @"D:\GameBasic\img\1.png";
                    num2 = 1;
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"D:\GameBasic\img\2.png";
                    num2 = 2;
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"D:\GameBasic\img\3.png";
                    num2 = 3;
                    break;

                case 4:
                    pictureBox2.ImageLocation = @"D:\GameBasic\img\4.png";
                    num2 = 4;
                    break;

                case 5:
                    pictureBox2.ImageLocation = @"D:\GameBasic\img\5.png";
                    num2 = 5;
                    break;
                case 6:
                    pictureBox2.ImageLocation = @"D:\GameBasic\img\6.png";
                    num2 = 6;
                    break;
                default:
                    pictureBox2.ImageLocation = @"D:\GameBasic\img\1.png";
                    num2 = 1;
                    break;

            }
            switch (Random3)
            {
                case 1:
                    pictureBox3.ImageLocation = @"D:\GameBasic\img\1.png";
                    num3 = 1;
                    break;
                case 2:
                    pictureBox3.ImageLocation = @"D:\GameBasic\img\2.png";
                    num3 = 2;
                    break;
                case 3:
                    pictureBox3.ImageLocation = @"D:\GameBasic\img\3.png";
                    num3 = 3;
                    break;

                case 4:
                    pictureBox3.ImageLocation = @"D:\GameBasic\img\4.png";
                    num3 = 4;
                    break;

                case 5:
                    pictureBox3.ImageLocation = @"D:\GameBasic\img\5.png";
                    num3 = 5;
                    break;
                case 6:
                    pictureBox3.ImageLocation = @"D:\GameBasic\img\6.png";
                    num3 = 6;
                    break;
                default:
                    pictureBox3.ImageLocation = @"D:\GameBasic\img\1.png";
                    num3 = 1;
                    break;
            }

            //MessageBox.Show(num1.ToString() +" "+ num2.ToString() +" "+ num3.ToString());
            Thread.Sleep(1000);
            //int equal1 = num1 + num2 + num3;
            //textBox2.Text = equal1.ToString();
        }

        private void your_money_Click(object sender, EventArgs e)
        {
        }



        //Hàm hiển thị số tiền
        private void Print_money()
        {
            if (yourMoney > 0)
            {
                your_money.Text = yourMoney.ToString();
            }
            else
            {
                your_money.Text = "0";
                //tien_no.Text = (yourMoney * -1).ToString();
            }
        }
        //Hàm tính tiền chẵn lẻ
        private void OddandEven(int equals)
        {
            int tiencuoc = Int32.Parse(number.Text.Trim());
            int tienan;
            //tien cuoc x 2
            if (cuoc2.Checked == true && cuoc4.Checked == false && cuoc5.Checked == false && cuoc10.Checked == false)
            {
                if (yourMoney > 0)
                {
                    if (temp == 1 && equals % 2 == 0)
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            tienan = tiencuoc * 2;
                            yourMoney = yourMoney + tienan;
                            MessageBox.Show("Bạn nhận được " + tienan + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tienan * 3;
                            MessageBox.Show("Bạn nhận được " + tienan * 2 + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                    }
                    else if (temp == 2 && equals % 2 != 0)
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            tienan = tiencuoc * 2;
                            yourMoney = yourMoney + tienan;
                            MessageBox.Show("Bạn nhận được " + tienan + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tienan * 3;
                            MessageBox.Show("Bạn nhận được " + tienan * 2 + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                    }
                    else
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = yourMoney - tienan * 2;
                            MessageBox.Show("Bạn đã mất " + tienan * 2);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tiencuoc - tienan * 2;
                            MessageBox.Show("Bạn đã mất " + tienan * 2);
                        }
                    }
                    Print_money();
                }
                else
                {
                    MessageBox.Show("Ban khong du tien.");
                }
            }
            //tien cuoc x 4
            else if (cuoc2.Checked == false && cuoc4.Checked == true && cuoc5.Checked == false && cuoc10.Checked == false)
            {
                if (yourMoney > 0)
                {
                    if (temp == 1 && equals % 2 == 0)
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            tienan = tiencuoc * 4;
                            yourMoney = yourMoney + tienan;
                            MessageBox.Show("Bạn nhận được " + tienan + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tienan * 5;
                            MessageBox.Show("Bạn nhận được " + tienan * 4 + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                    }
                    else if (temp == 2 && equals % 2 != 0)
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            tienan = tiencuoc * 4;
                            yourMoney = yourMoney + tienan;
                            MessageBox.Show("Bạn nhận được " + tienan + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tienan * 5;
                            MessageBox.Show("Bạn nhận được " + tienan * 4 + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                    }
                    else
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = yourMoney - tienan * 4;
                            MessageBox.Show("Bạn đã mất " + tienan * 4);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tiencuoc - tienan * 4;
                            MessageBox.Show("Bạn đã mất " + tienan * 4);
                        }
                    }
                    Print_money();
                }
                else
                {
                    MessageBox.Show("Ban khong du tien.");
                }

            }
            //tien cuoc x 5
            else if (cuoc2.Checked == false && cuoc4.Checked == false && cuoc5.Checked == true && cuoc10.Checked == false)
            {
                if (yourMoney > 0)
                {
                    if (temp == 1 && equals % 2 == 0)
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            tienan = tiencuoc * 5;
                            yourMoney = yourMoney + tienan;
                            MessageBox.Show("Bạn nhận được " + tienan + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tienan * 6;
                            MessageBox.Show("Bạn nhận được " + tienan * 5 + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                    }
                    else if (temp == 2 && equals % 2 != 0)
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            tienan = tiencuoc * 5;
                            yourMoney = yourMoney + tienan;
                            MessageBox.Show("Bạn nhận được " + tienan + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tienan * 6;
                            MessageBox.Show("Bạn nhận được " + tienan * 5 + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                    }
                    else
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = yourMoney - tienan * 5;
                            MessageBox.Show("Bạn đã mất " + tienan * 5);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tiencuoc - tienan * 5;
                            MessageBox.Show("Bạn đã mất " + tienan * 5);
                        }
                    }
                    Print_money();
                }
                else
                {
                    MessageBox.Show("Ban khong du tien.");
                }
            }
            //tien cuoc x10
            else if (cuoc2.Checked == false && cuoc4.Checked == false && cuoc5.Checked == false && cuoc10.Checked == true)
            {
                if (yourMoney > 0)
                {
                    if (temp == 1 && equals % 2 == 0)
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            tienan = tiencuoc * 10;
                            yourMoney = yourMoney + tienan;
                            MessageBox.Show("Bạn nhận được " + (tienan - tiencuoc) + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tienan * 11;
                            MessageBox.Show("Bạn nhận được " + tienan * 10 + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                    }
                    else if (temp == 2 && equals % 2 != 0)
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            tienan = tiencuoc * 10;
                            yourMoney = yourMoney + tienan;
                            MessageBox.Show("Bạn nhận được " + (tienan - tiencuoc) + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tienan * 11;
                            MessageBox.Show("Bạn nhận được " + tienan * 10 + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                    }
                    else
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = yourMoney - tienan * 10;
                            MessageBox.Show("Bạn đã mất " + tienan * 10);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tiencuoc - tienan * 10;
                            MessageBox.Show("Bạn đã mất " + tienan * 10);
                        }
                    }
                    Print_money();
                }
                else
                {
                    MessageBox.Show("Ban khong du tien.");
                }

            }
            //tien cuon x 1
            else if (cuoc2.Checked == false && cuoc4.Checked == false && cuoc5.Checked == false && cuoc10.Checked == false)
            {
                if (yourMoney > 0)
                {
                    if (temp == 1 && equals % 2 == 0)
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = yourMoney + tienan;
                            MessageBox.Show("Bạn nhận được " + tienan + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tienan * 2;
                            MessageBox.Show("Bạn nhận được " + tienan);
                        }

                    }
                    else if (temp == 2 && equals % 2 != 0)
                    {
                        if (tiencuoc < yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = yourMoney + tienan;
                            MessageBox.Show("Bạn nhận được " + tienan + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            tienan = tiencuoc;
                            yourMoney = tienan * 2;
                            MessageBox.Show("Bạn nhận được " + tienan + "\nTổng tiền của bạn là: " + yourMoney);
                        }
                    }
                    else
                    {
                        if (tiencuoc < yourMoney)
                        {
                            yourMoney = yourMoney - tiencuoc;
                            MessageBox.Show("Bạn đã mất " + tiencuoc);
                        }
                        else if (tiencuoc == yourMoney)
                        {
                            yourMoney = tiencuoc - tiencuoc;
                            MessageBox.Show("Bạn đã mất " + tiencuoc);
                        }
                    }
                    Print_money();
                }
                else
                {
                    MessageBox.Show("Ban khong du tien.");
                }
            }
            Program.Save_file(yourMoney);
        }

    }
}
