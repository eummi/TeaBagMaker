using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] SList = new string[] { "차", "홍차", "녹차", "루이보스차", "국화차" };
        string orgStr = "";
        int CountOrgNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SList.Length; i++)
            {
                this.comboBox.Items.Add(SList[i]);
            }
            this.orgStr = time.Text;
            if (comboBox.Items.Count > 0)
            {
                this.comboBox.SelectedIndex = 0;
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (this.comboBox.Text == "홍차")
            {
                this.time.Text = "2분";
            }
            else if (this.comboBox.Text == "녹차")
            {
                
            }
            else if (this.comboBox.Text == "루이보스차")
            {

            }
            else if (this.comboBox.Text == "국화차")
            {

            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CountOrgNum < 1)
            {
                this.timer1.Enabled = false;
                this.time.Text = "";
                MessageBox.Show("티백을 건지세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CountOrgNum--;
                this.time.Text = Convert.ToString(CountOrgNum);
            }

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox.Text != "차")
            {
                this.time.Text = this.comboBox.Text;
            }

        }
    }
}
