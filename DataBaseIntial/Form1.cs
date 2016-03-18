using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Yinhe.Data;

namespace DataBaseIntial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MongoOperate.SetMongoServer("mongodb://sa:dba@192.168.1.230/");
            //MongoOperate.SetMongoDatabase("A3");

            
                

         
            StreamReader objReader = new StreamReader(@"C:\Users\Administrator\Downloads\90万7位dd号账号密码\90万7位QQ号账号密码\格式.txt");
            var regexStr = this.textBox1.Text;
            var regexStr2 = this.textBox2.Text;
            string sLine = "";
            while (sLine != null)
            {
                sLine = objReader.ReadLine();

                if (sLine != null)
                {
                    var rex = new Regex(regexStr);
                    var account = rex.Match(sLine);
                    var rex2 = new Regex(regexStr2);
                    var passWord = rex2.Match(sLine);
                    MessageBox.Show(account.Value + passWord.Value);
                }

            }

            objReader.Close();
        }
    }
}
