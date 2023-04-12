using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            var fileContent = string.Empty;
            String fileName;
            time.Start();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog1.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {

                    fileContent = reader.ReadToEnd();
                    fileContent = Regex.Replace(fileContent, "<.*?>", string.Empty);


                }
            }
          
            time.Stop();
            TimeSpan timeTaken = time.Elapsed;
            string foo = "Tiempo que tardo en abrir: " + timeTaken.ToString(@"m\:ss\.fff");

            registroResultados.AppendText(fileContent);
            registroResultados.AppendText("\n\r" + foo);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            var fileContent = string.Empty;
            String fileName;
            time.Start();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog1.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {

                    fileContent = reader.ReadToEnd();
                    fileContent = Regex.Replace(fileContent, "<.*?>", string.Empty);


                }
            }

            time.Stop();
            TimeSpan timeTaken = time.Elapsed;
            string foo = "Tiempo que tardo en abrir: " + timeTaken.ToString(@"m\:ss\.fff");

            registroResultados.AppendText(fileContent);
            registroResultados.AppendText("\n\r" + foo);
        }
    }
    }

