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
using System.Net.Mail;
using System.Net;

namespace BatchRunner
{
    public partial class Form4 : Form
    {
        String selectedFolder = ""; //this var will hold the path of the selected folder
        List<String> listUnSelected = new List<string>();
        List<String> listSelected = new List<string>();
        String directoryPath = "C:/BatchRunnerTempFiles/";
        String batchFile = "batchFile_";
        String finalPath = "";
        String new_path = "";
        String final_batch_file_path;
        string batchFileTestCaseData = ""; // This is the string holding all the targeted test case with the appropriate testcases name in a string, that will be appened to the batch file later
        List<String> targetTestCaseList = new List<string>();
        string ip1;
        string ip2;
        string mc_1;
        string mc_2;
        string machineCSVPath;
        string propertiesPath;
        string coverageType = "Regression"; //this value is either going to be Sanity or Regression
        string driveLetter = "";// this variable holds the drive in which the command line is suppose to navigate into, before calling/executing the batch file
        string path_to_java_test = ""; //this holds the path to Java_Test
        public Form4()
        {
            InitializeComponent();
            makeBatch.Enabled = false;
            regression.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;//=" E:\\PerforceWorkSpace\\depot\\Products\\GoToMyPC\\main_new\\Automation\\Java_Tests\\src\\test\\java\\com\\citrix\\aft\\test";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
          //      folderBrowserDialog1.SelectedPath = "C:\\Users\\srvdsk\\Desktop\\shipIt\\scwindows\\Automation\\Java_Tests\\src\\test\\java\\com\\citrix\\aft\\test\\SC\\Broker";
                selectedFolder = folderBrowserDialog1.SelectedPath;

                path_to_java_test = selectedFolder.Split(new string[] { "src" }, StringSplitOptions.None)[0];

                Console.WriteLine("Selected folder =" + selectedFolder);
                String[] files = readFileNames(selectedFolder);
                listUnSelectedTCs.Items.Clear();
                foreach (String file in files)
                {
                    listUnSelected.Add(file.Replace(selectedFolder + "\\", ""));
                }
                populateCheckedListBox(listUnSelected, listUnSelectedTCs);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            foreach (String ll in listUnSelectedTCs.CheckedItems)
            {
                listSelected.Add(ll);
                listUnSelected.Remove(ll);
            }
            populateCheckedListBox(listSelected, listSelectedTCs);
            populateCheckedListBox(listUnSelected, listUnSelectedTCs);

            makeBatch.Enabled = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {
            foreach (String ll in listSelectedTCs.CheckedItems)
            {
                listUnSelected.Add(ll);
                listSelected.Remove(ll);
            }
            populateCheckedListBox(listSelected, listSelectedTCs);
            populateCheckedListBox(listUnSelected, listUnSelectedTCs);
        }

        private String[] readFileNames(String folder)
        {
            Console.WriteLine(folder);
            String[] fileList = Directory.GetFiles(@folder);
            Console.WriteLine(fileList);
            return fileList;
        }

        void populateCheckedListBox(List<String> strList, CheckedListBox box)
        {
            box.BeginUpdate();
            box.Items.Clear();
            foreach (String s in strList)
            {
                box.Items.Add(s);
            }
            box.EndUpdate();
        }

        void updateRadioButtonEntry()
        {
            if (regression.Checked)
            {
                coverageType = "Regression";
            }
            else if (sanity.Checked)
            {
                coverageType = "Sanity";
            }
        }
        private void makeBatch_Click(object sender, EventArgs e)
        {


            String path_var = DateTime.Now.Ticks.ToString();
            new_path = batchFile + path_var + ".bat";
            final_batch_file_path = path_to_java_test + new_path;

            using (FileStream fs = File.Create(final_batch_file_path))
            {
                String finalBatchFileData = "";
                finalBatchFileData += "set PROPERTIES=" + getPropertyType() + "\n";
                finalBatchFileData += "set PROFILE=" + getProfileType() + "\n";

                updateRadioButtonEntry();
                updateTargetTestCaseList1();

                finalBatchFileData += driveLetter + "\n";

                finalBatchFileData += "cd " + path_to_java_test + "\n";

//                finalBatchFileData += "set TESTS=";

                //finalBatchFileData += batchFileTestCaseData;
                batchFileTestCaseData = batchFileTestCaseData.Remove(batchFileTestCaseData.Length - 1, 1);
                finalBatchFileData += "\n" + "call execute.bat  -Dtest=" + batchFileTestCaseData + "\n";
//                finalBatchFileData += "\n" + "call execute.bat  -Dtest=%TESTS%";

                //Console.WriteLine("final :: \n" + finalBatchFileData);

                Byte[] info = new UTF8Encoding(true).GetBytes(finalBatchFileData);
                Console.WriteLine("property : " + getPropertyType());

                fs.Write(info, 0, info.Length);
            }
            MessageBox.Show("Batch file created");
            run_batch();
            //send_mail();

        }

        public void updateTargetTestCaseList()
        {
            finalPath = "";
            targetTestCaseList.Clear();
            foreach (String c in listSelectedTCs.Items)
            {
                String tempStr = "";
                tempStr = String.Copy(c);

                tempStr = selectedFolder + "\\" + tempStr;

                String x = tempStr.Split(new string[] { "Java_Tests", "com" }, StringSplitOptions.None)[0];
                finalPath = x + "Java_Tests";

                Console.WriteLine("TestCase : " + c);
            }
            Console.WriteLine("FinalPath : " + finalPath);

            foreach (String h in targetTestCaseList)
            {
                Console.WriteLine("Target Test Case : " + h);
            }

        }

        public void updateTargetTestCaseList1()
        {
            driveLetter = selectedFolder.Split('\\')[0];

            foreach (string tcFileName in listSelectedTCs.Items)
            {
                Console.WriteLine("TC : " + selectedFolder + "\\" + tcFileName);
                List<string> testCasesList = getTestCaseNameList(tcFileName);
                string tcFileNameWithoutExtension = tcFileName.Split('.')[0];
                foreach (string x in testCasesList)
                {
                    batchFileTestCaseData += tcFileNameWithoutExtension + "#" + x + ",";
                }

            }
        }

        public List<string> getTestCaseNameList(string fileName)
        {
            List<string> tempList = new List<string>();
            string filePath = selectedFolder + "\\" + fileName;

            IEnumerable<string> fullText = File.ReadLines(filePath);
            var iterator1 = fullText.GetEnumerator();
            while (iterator1.MoveNext())
            {
                string line = iterator1.Current;

                Match m = Regex.Match(line, @"@Test.*groups.*{.*(Regression|Sanity).*");
                if (m.Success && m.Groups[1].Value.Equals(coverageType))
                {
                    iterator1.MoveNext();
                    string testCaseDeclarationLine = iterator1.Current;
                    Match tcName = Regex.Match(testCaseDeclarationLine, @"public.*void ([A-Za-z]+)\(\).*");
                    //                    Console.WriteLine(tcName.Groups[1].Value);
                    tempList.Add(tcName.Groups[1].Value);
                }
            }

            return tempList;
        }

        public String getPropertyType()
        {
            /*
            String res = "";
            if (integrationRadio.Checked)
            {
                res = "integration";
            }
            else if (localRadio.Checked)
            {
                res = "local";
            }
            else if (nightlyRadio.Checked)
            {
                res = "nightly";
            }
            return res;
             * */
            return "local";

        }

        public String getProfileType()
        {
            /*
            String res = "";
            if (profile1_radio.Checked)
            {
                res = "integration_xp_i3";
            }
            return res;
            */
            return "integration_xp_i3";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void run_batch()
        {
            MessageBox.Show("Executing batch");
            System.Diagnostics.Process.Start("CMD.exe", "/C " + final_batch_file_path + "> " + path_to_java_test + "batch_log_file.txt").WaitForExit();
            send_mail();

        }

      

        public static void Watch()
        {
            var watch = new FileSystemWatcher();
            watch.Path = @"D:\tmp";
            watch.Filter = "file.txt";
            watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite; //more options
            watch.Changed += new FileSystemEventHandler(OnChanged);
            watch.EnableRaisingEvents = true;
        }

        /// Functions:
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            if (e.FullPath == @"D:\tmp\file.txt")
            {
                // do stuff
            }
        }

        private void send_mail()
        {
            try
            {
                string path = path_to_java_test + "batch_log_file.txt"; //@"C:\BatchRunnerTempFiles\batch_log_file.txt";

                int large = 0;
                string s = String.Empty;
                using (StreamReader sr = File.OpenText(path))
                {

                    s = sr.ReadToEnd();
                }

                String message = String.Empty;
                //message = s.Substring(x);
                var matches = Regex.Matches(s, "Tests run");
                foreach (Match m in matches)
                {
                    large = m.Index;

                }
               
                message = s.Substring(large);
                //Console.WriteLine(message);
                //Console.ReadKey();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(path);

                mail.From = new MailAddress("maheswaricitrix@gmail.com");
                mail.To.Add("pallavi.sreerama@citrix.com");
                mail.To.Add("pallavisreerama@gmail.com");
                mail.Subject = "Results of batch run";
                mail.Body = message;
                mail.Attachments.Add(attachment);
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("maheswaricitrix", "Citrix1234");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }









        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void machine_detials_Click(object sender, EventArgs e)
        {
            updateMachineIps();
            updateMachineNames();
            String str = finalPath.ToString();
            Console.WriteLine("final@@ + " + finalPath + "....." + str);

            Form3 form3 = new Form3(ip1, ip2, mc_1, mc_2, machineCSVPath, propertiesPath);
            form3.ShowDialog();
        }

        void updateMachineNames()
        {
            propertiesPath = selectedFolder.Split(new string[] { "Java_Tests", "com" }, StringSplitOptions.None)[0] + "\\" + "Java_Tests\\Properties.txt.local";
            string propertiesFileText = File.ReadAllText(propertiesPath);
            Console.WriteLine("properties path : " + propertiesPath);
            string host = Regex.Match(propertiesFileText, "host = ([A-Za-z0-9_]*)").Groups[1].Value;
            string viewer = Regex.Match(propertiesFileText, "viewer = ([A-Za-z0-9_]*)").Groups[1].Value;

            string hostComputerName = Regex.Match(propertiesFileText, host + ".computerName = ([A-Za-z0-9_]*)").Groups[1].Value;
            string viewerComputerName = Regex.Match(propertiesFileText, viewer + ".computerName = ([A-Za-z0-9_]*)").Groups[1].Value;
            Console.WriteLine("hostCompName" + hostComputerName);
            mc_1 = hostComputerName;
            mc_2 = viewerComputerName;

        }

        void updateMachineIps()
        {
            //read the machine.csv file

            machineCSVPath = selectedFolder.Split(new string[] { "Java_Tests", "com" }, StringSplitOptions.None)[0] + "\\" + "Java_Tests\\machines.csv";

            string text = System.IO.File.ReadAllText(machineCSVPath);

            var x = Regex.Matches(text, @"\d+.\d+.\d+.\d+");

            ip1 = x[0].ToString();
            ip2 = x[1].ToString();


        }

        private void listSelectedTCs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

