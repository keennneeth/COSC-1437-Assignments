using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreLibrary;

namespace Master_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)

        {
            IbFileOutput.Items.Clear();

            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Comma seperated values |*.csv|Text File| *.txt",
                Title = @"Select the Hundred Names database"
            };

            // Shows Dialog
            // When user clicks ok, it opens

            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)

                txtFileName.Text = openFileDialog.SafeFileName;

                toolStripStatusLabel1.Text = openFileDialog.FileName;
    
                 string fileContent = ReadEncrypt(openFileDialog.FileName);

                 var parsedArrayOfStrings = Regex.Split(fileContent, "\n");

                 IbFileOutput.Items.AddRange(parsedArrayOfStrings);

            Properties.Settings.Default.PreviousFilePath = openFileDialog.FileName;
                Properties.Settings.Default.Save();



                using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    var oneLineOfText = "";
                    while ((oneLineOfText = sr.ReadLine()) !=null)
                    {
                        IbFileOutput.Items.Add(oneLineOfText);
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Properties.Settings.Default.PreviousFilePath;
        }

        private void btnWriteEncryptedFile(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Comma Seperated Values |*.csv|Text File|*.txt|All Files| *.*",
                Title = @"Select a file, preferably a plain text file"
            };

            // reads the plain text

            string inputFilePath = openFileDialog.FileName;

            FileStream sourceFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);
            Debug.WriteLine($"Property 'Name' : {sourceFileStream.Name}");
            Debug.WriteLine($"Property 'CanRead' : {sourceFileStream.CanRead}");

            StreamReader sr = new StreamReader(sourceFileStream);

            Debug.WriteLine($"Property 'EndOfStream' : {sr.EndOfStream}");
            string sourceFileContent = sr.ReadToEnd();

            Debug.WriteLine($"Property 'EndOfStream' : {sr.EndOfStream}");
            Debug.WriteLine(sourceFileContent.Left(25));

            //writes encrypted file
            string outputFilePath = Path.ChangeExtension(openFileDialog.FileName, "Encrypted");
            Debug.WriteLine($"outputFilePath : {outputFilePath}");
            WriteEncrypt(outputFilePath, sourceFileContent);




            /// <summary>
            /// Encrypt FileStream
            /// </summary>
            /// <param name="outputFilePath">full path to the output file</param>
            /// <param name="msg">text to output</param>
            private static void WriteEncrypt(string outputFilePath, string msg)
            {
                FileStream outputFileStream =
                    new FileStream(outputFilePath,
                        FileMode.Create,
                        FileAccess.Write);

                Debug.WriteLine($"Property 'Name' : {outputFileStream.Name}");
                Debug.WriteLine($"Property 'CanRead' : {outputFileStream.CanRead}");

                // (1) Create Data Encryption Standard (DES) object.
                DESCryptoServiceProvider crypt = new DESCryptoServiceProvider();
                // (2) Create a key and Initialization Vector - requires 8 bytes
                crypt.Key = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
                crypt.IV = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
                // (3) Create CryptoStream stream object
                CryptoStream cs =
                    new CryptoStream(outputFileStream,
                        crypt.CreateEncryptor(),
                        CryptoStreamMode.Write);
                // (4) Create StreamWriter using CryptoStream
                StreamWriter sw = new StreamWriter(cs);

                sw.Write(msg);
                sw.Close();
                cs.Close();
            }
        }

        private void btnReadEncryptedFile(object sender, EventArgs e)
        {
            /// <summary>
            /// Read and Decrypt a file stream.
            /// </summary>
            /// <param name="inputFilePath">input file path name</param>
            /// <returns></returns>
            private static string ReadEncrypt(string inputFilePath)
            {
                FileStream inputFileStream =
                    new FileStream(inputFilePath,
                        FileMode.Open,
                        FileAccess.Read);

                Debug.WriteLine($"Property 'Name' : {inputFileStream.Name}");
                Debug.WriteLine($"Property 'CanRead' : {inputFileStream.CanRead}");

                // (1) Create Data Encryption Standard (DES) object.
               var crypt = new DESCryptoServiceProvider()
               {
                   KeySize = 64,
                   Key = new byte [] {}
               }
                            // got confused here



                // (2) Create a key and Initialization Vector
                //old crypt.Key = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
                //old crypt.IV = new byte[] { 71, 72, 83, 84, 85, 96, 97, 78 };
                // (3) Create CryptoStream stream object
                CryptoStream cs =
                    new CryptoStream(inputFileStream,
                        crypt.CreateDecryptor(),
                        CryptoStreamMode.Read);
                // (4) Create StreamReader using CryptoStream

                StreamReader sr = new StreamReader(cs);
                string msg = sr.ReadToEnd();
                sr.Close();
                cs.Close();
                return msg;
            }
        }
    }
}
