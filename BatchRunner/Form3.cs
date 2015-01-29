using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchRunner
{
    public partial class Form3 : Form
    {
        string _machineCSVPath;
        string _propertiesPath;
        string _ip1;
        string _ip2;
        string _mc1;
        string _mc2;
        public Form3(string ip1, string ip2, string mc_1, string mc_2, string machineCSVPath, string propertiesPath)
        {
            InitializeComponent();
            
            //automatically populate the felds during the initializing
            this.ip1.Text = ip1;
            this.ip2.Text = ip2;
            this.mc1.Text = mc_1;
            this.mc2.Text = mc_2;

            _ip1 = ip1;
            _ip2 = ip2;
            _mc1 = mc_1;
            _mc2 = mc_2;


            _machineCSVPath = machineCSVPath;
            _propertiesPath = propertiesPath;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            //rewrite the machine.csv

            string text = "Role,IPAddress,BrowserToUse,ThinClientType\nCUSTOMER,"+this.ip1.Text+",CHROME,\nEXPERT,"+this.ip2.Text+",CHROME,";
            using (FileStream fs = File.Create(_machineCSVPath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(text);
                fs.Write(info, 0, info.Length);
            }


            //edit the properties.txt.local file
            string updatedPropertiesFile = getUpdatedPropertiesFileText();
            Console.WriteLine("prop path : " + _propertiesPath);
            using (FileStream fs = File.Create(_propertiesPath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(updatedPropertiesFile);
                fs.Write(info, 0, info.Length);
            }


           //Console.WriteLine(updatedPropertiesFile);

            closeForm();
        }

        string getUpdatedPropertiesFileText()
        {
            string propertiesFileText = File.ReadAllText(_propertiesPath);
            Console.WriteLine("properties path : " + _propertiesPath);
            string host = Regex.Match(propertiesFileText, "host = ([A-Za-z0-9_]*)").Groups[1].Value;
            string viewer = Regex.Match(propertiesFileText, "viewer = ([A-Za-z0-9_]*)").Groups[1].Value;
            propertiesFileText = Regex.Replace(propertiesFileText, host + ".computerName = " + _mc1, host + ".computerName = " + this.mc1.Text);
            propertiesFileText = Regex.Replace(propertiesFileText, viewer + ".computerName = " + _mc2, viewer + ".computerName = " + this.mc2.Text);

            propertiesFileText = Regex.Replace(propertiesFileText, host + ".ip = " + _ip1, host + ".ip = " + this.ip1.Text);
            propertiesFileText = Regex.Replace(propertiesFileText, viewer + ".ip = " + _ip2, viewer + ".ip = " + this.ip2.Text);

            return propertiesFileText;
        }

        private void ip1_TextChanged(object sender, EventArgs e)
        {
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            closeForm();
        }


        void closeForm()
        {
            this.Close();
        }
    }
}
