﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteServer
{
    public partial class RemoteDebug : Form
    {
        public RemoteDebug()
        {
            InitializeComponent();
        }
        //按键名称
        private bool flag1 = false;
        private bool flag2 = false;
        private bool flag3 = false;
        private bool flag4 = false;
        private bool flag5 = false;
        private bool flag6 = false;
        private bool flag7 = false;
        private bool flag8 = false;
        //图片切换
        public bool flag11 = false;
        public bool flag22 = false;
        public bool flag33 = false;
        public bool flag44 = false;
        public bool flag55 = false;
        public bool flag66 = false;
        public bool flag77 = false;
        public bool flag88 = false;
        //参数信息
        public string DataInformation = null;
        public char [] a=new char[10];
        private void RemoteDebug_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (a[0] == '0') a[0] = '1';
            else a[0] = '0';
            if (!flag1)
            {
                button1.Text = "发生修改";
                flag1 = true;
            }
            else
            {
                button1.Text = "修改参数";
                flag1 = false;
            }
            if (flag11)
            {
                pictureBox1.Image = Properties.Resources.led_D;
                flag11 = false;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.led_O;
                flag11 = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a[1] == '0') a[1] = '1';
            else a[1] = '0';
            if (!flag2)
            {
                button2.Text = "发生修改";
                flag2 = true;
            }
            else
            {
                button2.Text = "修改参数";
                flag2 = false;
            }
            if (flag22)
            {
                pictureBox2.Image = Properties.Resources.led_D;
                flag22 = false;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.led_O;
                flag22 = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a[2] == '0') a[2] = '1';
            else a[2] = '0';
            if (!flag3)
            {
                button3.Text = "发生修改";
                flag3 = true;
            }
            else
            {
                button3.Text = "修改参数";
                flag3 = false;
            }
            if (flag33)
            {
                pictureBox3.Image = Properties.Resources.led_D;
                flag33 = false;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.led_O;
                flag33 = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (a[3] == '0') a[3] = '1';
            else a[3] = '0';
            if (!flag4)
            {
                button4.Text = "发生修改";
                flag4 = true;
            }
            else
            {
                button4.Text = "修改参数";
                flag4 = false;
            }
            if (flag44)
            {
                pictureBox4.Image = Properties.Resources.led_D;
                flag44 = false;
            }
            else
            {
                pictureBox4.Image = Properties.Resources.led_O;
                flag44 = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a[4] == '0') a[4] = '1';
            else a[4] = '0';
            if (!flag5)
            {
                button5.Text = "发生修改";
                flag5 = true;
            }
            else
            {
                button5.Text = "修改参数";
                flag5 = false;
            }
            if (flag55)
            {
                pictureBox5.Image = Properties.Resources.led_D;
                flag55 = false;
            }
            else
            {
                pictureBox5.Image = Properties.Resources.led_O;
                flag55 = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a[5] == '0') a[5] = '1';
            else a[5] = '0';
            if (!flag6)
            {
                button6.Text = "发生修改";
                flag6 = true;
            }
            else
            {
                button6.Text = "修改参数";
                flag6 = false;
            }
            if (flag66)
            {
                pictureBox6.Image = Properties.Resources.led_D;
                flag66 = false;
            }
            else
            {
                pictureBox6.Image = Properties.Resources.led_O;
                flag66 = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (a[6] == '0') a[6] = '1';
            else a[6] = '0';
            if (!flag7)
            {
                button7.Text = "发生修改";
                flag7 = true;
            }
            else
            {
                button7.Text = "修改参数";
                flag7 = false;
            }
            if (flag77)
            {
                pictureBox7.Image = Properties.Resources.led_D;
                flag77 = false;
            }
            else
            {
                pictureBox7.Image = Properties.Resources.led_O;
                flag77 = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (a[7] == '0') a[7] = '1';
            else a[7]='0';
            if (!flag8)
            {
                button8.Text = "发生修改";
                flag8 = true;
            }
            else
            {
                button8.Text = "修改参数";
                flag8 = false;
            }
            if (flag88)
            {
                pictureBox8.Image = Properties.Resources.led_D;
                flag88 = false;
            }
            else
            {
                pictureBox8.Image = Properties.Resources.led_O;
                flag88 = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
