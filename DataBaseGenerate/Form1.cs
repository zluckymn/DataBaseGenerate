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
namespace DataBaseGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oldCon = new MongoOperation("mongodb://sa:dba@192.168.1.230/A3");
            var dataOp = new DataOperation(oldCon);

 
            StreamReader objReader = new StreamReader(@"C:\Users\Administrator\Downloads\90万7位dd号账号密码\90万7位QQ号账号密码\格式.txt");
            var regexStr = this.textBox1.Text;
            string sLine = "";
            while (sLine != null)
            {
               sLine = objReader.ReadLine();

                if (sLine != null)
                {
                    var rex = new Regex(regexStr);
                    var temp=rex.Match(sLine);
                    MessageBox.Show(temp.Value);
                }

            }

            objReader.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
