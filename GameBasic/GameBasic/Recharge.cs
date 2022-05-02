using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBasic
{
    public partial class Recharge : Form
    {
        private int answer;

        public static object Save { get; internal set; }

        public Recharge()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Program.check = true;
        }
        private int random()
        {
            Random random = new Random();
            answer = random.Next(1000, 9000);
            //MessageBox.Show(answer.ToString());
            return answer;
        }
        private void Check()
        {
            Program.check_data = Program.Read_file();
            if (money_recharge.Text =="" || checkCode.Text == "" )
            {

                MessageBox.Show("Can nhap so tien.");
            }else if(money_recharge.Text == "" && checkCode.Text == ""){
                MessageBox.Show("Can nhap so tien.");
            }
            else {

                int result = Int32.Parse(checkCode.Text);
                if (result == answer)
                {
                    if (Program.check == false)
                    {
                        if (Program.check_data != null)
                        {
                            if (Int32.Parse(Program.Read_file()) > 0)
                            {
                                Program.first_money = Int32.Parse(money_recharge.Text.Trim());
                                MessageBox.Show("Bạn đã nạp thành công.");
                            }
                            else if(Int32.Parse(Program.Read_file()) < 0)
                            {
                                Program.tien_no = Int32.Parse(money_recharge.Text)- Int32.Parse(Program.Read_file()) * -1;
                                //MessageBox.Show(Program.tien_no.ToString());
                                //MessageBox.Show((Int32.Parse(money_recharge.Text) - Int32.Parse(Program.Read_file()) * -1).ToString());
                                Program.Save_file(Program.tien_no);
                                MessageBox.Show("Bạn đã nạp thành công.");
                            }
                        }

                    }
                    else if(Program.check == true)
                    {
                        Program.money_push = Int32.Parse(money_recharge.Text.Trim());
                        MessageBox.Show("Bạn đã nạp thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Bạn nạp không thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Khong duoc r ");
                }
            }
        }
        private void btnSend_Code_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Mã của bạn là: " + random(), "Mã xác nhận");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Check();
                this.Close();
        }


    }
}
