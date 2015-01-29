using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchRunner
{
    public partial class Form2 : Form
    {
        String target_file;
        public Form2(String log_file_path , String directory_path)
        {
            InitializeComponent();

            target_file = log_file_path;

            Show_log_file();
        }

        private void onChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("in the onchanged method");
            //            throw new NotImplementedException();

            Show_log_file();
        }


        private void Show_log_file()
        {
            string text = System.IO.File.ReadAllText(@target_file);
            SetText(text);
        }
        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.richTextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBox1.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_log_file();
        }
    }
}


