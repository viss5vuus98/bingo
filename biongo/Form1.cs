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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            if(Convert.ToInt32(inputNum) > 80 || Convert.ToInt32(inputNum) == 0) //限制輸入 1~40
            {
                inputNum = "";
                lblUserInput.Text = "";
                MessageBox.Show("數字輸入錯誤");
                return;
            }
            lblUserNum.Text += $"{inputNum},";
            inputNum = "";
            lblUserInput.Text = "";
            count++;
            if (count >= 10)
            {
                getRandomNum();
                string all = lblRendamNum.Text;
                string[] subs = all.Split(',',' ');
                foreach (var item in subs)
                {
                    Console.WriteLine($"Substring: {item}");
                }
            }

            //輸入10個後呼叫函式開獎 用sliot切開字串

        }
        void getRandomNum()
        {
            Random 亂數 = new Random();//亂數種子

            for (int i = 0; i < 10; i++)
            {
                int index = 亂數.Next(1, 81);//回傳1-80的亂數
                lblRendamNum.Text += $"{index},";
            }

        }

        
    }
}
