using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace biongo
{
    public partial class Form1 : Form
    {
        string inputNum;
        int count = 0;
        int[] userSelectNum;
        int[] bingoNum;
        int quantity = 0;
        string evenStatus;
        string heigherStatus;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userSelectNum = new int[10];
            bingoNum = new int[10];
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            inputNum += "1";
            
            lblUserInput.Text = inputNum;
            
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            inputNum += "2";
            
            lblUserInput.Text = inputNum;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            inputNum += "3";
            
            lblUserInput.Text = inputNum;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            inputNum += "4";
            
            lblUserInput.Text = inputNum;

        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            inputNum += "5";
            
            lblUserInput.Text = inputNum;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            inputNum += "6";
            
            lblUserInput.Text = inputNum;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            inputNum += "7";
            
            lblUserInput.Text = inputNum;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            inputNum += "8";
            
            lblUserInput.Text = inputNum;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            inputNum += "9";
            
            lblUserInput.Text = inputNum;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            inputNum += "0";
            
            lblUserInput.Text = inputNum;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (inputNum == null || inputNum == "")
            {
                return;
            }
            int selectNum = Convert.ToInt32(inputNum);
            if (selectNum > 80 || selectNum == 0) //限制輸入 1~40
            {
                inputNum = "";
                lblUserInput.Text = "";
                MessageBox.Show("數字輸入錯誤");
                return;
            }
            if (Array.IndexOf(userSelectNum, selectNum) >= 0)
            {
                inputNum = "";
                lblUserInput.Text = "";
                MessageBox.Show("數字輸入重複");
                return;
            }
            if (count == 0)
            {
                lblRendamNum.Text = "";
            }
            userSelectNum[count] = selectNum;
            
            
            lblUserNum.Text += $"{inputNum.PadLeft(2, '0')} ";
            inputNum = "";
            lblUserInput.Text = "";
            count++;
            if (count >= 10)
            {
                lblRendamNum.Text = "";
                getRandomNum();
                string all = lblRendamNum.Text;
                getresult(userSelectNum);

                quantity = 0;
                lblUserNum.Text = "";
                Array.Clear(userSelectNum, 0, userSelectNum.Length);
                Array.Clear(bingoNum, 0, bingoNum.Length);
                count = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            evenStatus = "even";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            evenStatus = "odd";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            heigherStatus = "high";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            heigherStatus = "low";
        }

        void getRandomNum()
        {
            Random 亂數 = new Random();//亂數種子

            for (int i = 0; i < 10; i++)
            {
                int index = 亂數.Next(1, 81);//回傳1-80的亂數
                bingoNum[quantity] = index;
                quantity += 1;
                lblRendamNum.Text += $"{index :D2} ";
            }

        }

        void  getresult(Array SelectNum)
        {
            int bingoAmount = 0;
            int evenNumber = 0;
            int higherNumber = 0;
            if (evenStatus == null)
            {
                lblAnswer.Text = "";
            }
            else
            {   
                foreach(int item in bingoNum)
                {
                    if ((item % 2) == 0)
                    {
                        evenNumber += 2;
                    }
                    else
                    {
                        evenNumber -= 1;
                    }
                }
                Console.WriteLine($"{evenNumber}");
                if (evenStatus == "even" && evenNumber >= 10)
                {
                    lblAnswer.Text = "猜中雙數 ";
                }
                else if (evenStatus == "odd" && evenNumber < 10)
                {
                    lblAnswer.Text = "猜中單數 ";
                }
                else
                {
                    lblAnswer.Text = "";
                }
                evenNumber = 0;
            }

            if (heigherStatus == null)
            {
                lblAnswer.Text += "";
            }
            else
            {
                foreach (int item in bingoNum)
                {
                    if (item > 40)
                    {
                    higherNumber += 2;
                    }
                    else if (item < 40)
                    {
                    higherNumber -= 1;
                    }
                }
                if (heigherStatus == "high" && higherNumber >= 10)
                {
                    lblAnswer.Text += " 猜中大數 ";
                }
                else if (heigherStatus == "low" && higherNumber < 10)
                {
                    lblAnswer.Text += " 猜中小數 ";
                }
                higherNumber = 0;
            }

            foreach (var item in SelectNum)
            { 
                if (Array.IndexOf(bingoNum, item) >= 0)
                {
                    bingoAmount += 1;
                }
            }
            switch (bingoAmount)
            {
                case 10:
                    lblAnswer.Text += $"中獎10星";
                    break;
                case 9:
                    lblAnswer.Text += $"中獎9星";
                    break;
                case 8:
                    lblAnswer.Text += $"中獎8星";
                    break;
                case 7:
                    lblAnswer.Text += $"中獎7星";
                    break;
                case 6:
                    lblAnswer.Text += $"中獎6星";
                    break;
                case 5:
                    lblAnswer.Text += $"中獎5星";
                    break;
                case 4:
                    lblAnswer.Text += $"中獎4星";
                    break;
                case 3:
                    lblAnswer.Text += $"中獎3星";
                    break;
                case 2:
                    lblAnswer.Text += $"中獎2星";
                    break;
                case 1:
                    lblAnswer.Text += $"中獎1星";
                    break;
                default:
                    lblAnswer.Text += $"無星中獎";
                    break;
            }
        }


        //void result(SelectNum)
        //{
        //    int bingoAmount = 0;
        //    int evenNumber = 0;
        //    int higherNumber = 0;
        //    foreach (int item in SelectNum)
        //    {
        //        if (Array.IndexOf(SelectNum, item) >= 0)
        //        {
        //            bingoAmount += 1;
        //        }
        //        if ((item % 2) == 0)
        //        {
        //            evenNumber += 1;
        //        }
        //        else
        //        {
        //            evenNumber -= 1;
        //        }
        //        if (item > 40)
        //        {
        //            higherNumber += 1;
        //        }
        //        else if (item < 40)
        //        {
        //            higherNumber -= 1;
        //        }
        //    }
        //    if (evenNumber > 3)
        //    {
        //        lblAnswer.Text += $"猜中雙,";
        //    }
        //    else if (evenNumber < 3)
        //    {
        //        lblAnswer.Text += $"猜中單,";
        //    }

        //    if (higherNumber >= 3)
        //    {
        //        lblAnswer.Text += $"猜中大,";
        //    }
        //    else
        //    {
        //        lblAnswer.Text += $"猜中大,";
        //    }
        //}
    }
}
