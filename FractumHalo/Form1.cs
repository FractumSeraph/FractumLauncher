using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

using AutoUpdaterDotNET;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace FractumHalo
{
    public partial class Fractum : Form
    {
        public Fractum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Check Files Button Clicked!");
            string installPath = folderBrowserDialog1.SelectedPath.ToString();

            Console.WriteLine("Calling LoadChecksum File");
            LoadChecksumFile();

            //Looping through checksums dictionary and comparing.
            Console.WriteLine("Starting checksum loop");

            // TODO This should be a function, I'll change that later.
            foreach (var line in Checksums) //Loop through each loaded hash and check if they are correct.
            {
                string filepathToCheck = installPath + "\\" + line.Key;
                CheckIfHashesMatch(filepathToCheck, line.Value, line.Key);

            }

        }


        public Boolean CheckIfHashesMatch(string filepath, string hash, string subpath)
        {
            /*
             * Reads file from the filepath and checks them against the checksums.md5 list. 
             * If they do not match, it prepares a download link for said file.
             */

            using (var stream = new BufferedStream(File.OpenRead(filepath), 1200000)) //Read files from the path, with a 1,200,000 byte buffer size.
            {

                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    byte[] checksum = md5.ComputeHash(stream);
                    string result = BitConverter.ToString(checksum).Replace("-", String.Empty); //Make the result match the normal md5 look. (Lowercase, alphanumeric.)

                    Console.WriteLine("Checksum for file " + filepath + " is " + result.ToLower());

                    if (result.ToLower().Equals(hash))
                    {
                        Console.WriteLine("Hash Matches!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Hashes do NOT match! Adding to list. Calling Download fuction");
                        rtbMismatches.AppendText(filepath + "\n");
                        //TODO Get the value for given key. Add weburl to the front to make download url.
                        string webhost = @"http://halo.fractum.games/Halo The Master Chief Collection/";
                        string downloadURL = webhost + subpath;
                        Console.WriteLine("DownloadURl is currently " + downloadURL);
                        return false;
                    }

                }
            }



        }



        Dictionary<String, string> checksums = new Dictionary<string, string>();

        public Dictionary<string, string> Checksums { get => checksums; set => checksums = value; }

        public void LoadChecksumFile()

        /*
         * Opens a checksums.md5 file from the location selected by the folderBrowser.
         * Loads the contents into a dictionary using the path as a key, and the hash as the value.
         */

        {
            using (System.IO.StreamReader streamreader = new System.IO.StreamReader(folderBrowserDialog1.SelectedPath.ToString() + "\\" + "checksums.md5"))
            {
                Console.WriteLine("LoadChecksumFile has been called. Starting streamreader.");
                while (!streamreader.EndOfStream) // Keep reading until until theres nothing left.
                {
                    string splitMe = streamreader.ReadLine();
                    string[] checksumLine = splitMe.Split(new[] { " *" }, StringSplitOptions.None); //Split the hash from the path.

                    if (checksumLine.Length != 2)// If we get an incorrect amount, log it in the console.
                    {
                        Console.WriteLine("Checksum.Length != 2");
                        continue;
                    }
                    else if (checksumLine.Length == 2) //  If there are 2 results, as there should be, add them to the dictionary
                    {
                        Console.WriteLine(checksumLine[1] + ":" + checksumLine[0]);
                        //Read order is flipped. Dictionary is stored as the filepath first as the key, and the md5 is the value.
                        //This is because it's possible to have two of the same checksums in your install. (One file in two places.) But it's impossible to have two files at the same path.
                        Checksums.Add(checksumLine[1].Trim(), checksumLine[0].Trim());
                    }

                }
                Console.WriteLine("LoadChecksumFile complete.");
            }

        }


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbxInstallPath.Text = folderBrowserDialog1.SelectedPath.ToString();

            Console.WriteLine("Install path set to " + folderBrowserDialog1.SelectedPath.ToString());
        }

        private void DownloadFileFromURL(string url, string savepath)
        {
            WebClient mywebclient = new WebClient();
            mywebclient.DownloadFile(url, savepath);
        }

        private void tbxInstallPath_TextChanged(object sender, EventArgs e)
        {
            btnCheckFiles.Enabled = true;
        }

        private void Fractum_Load(object sender, EventArgs e)
        {
            //Update check on load.

            Console.WriteLine("Form loaded, updater starting.");
            AutoUpdater.RunUpdateAsAdmin = false;
            AutoUpdater.Start("https://halo.fractum.games/FractumLauncher.xml");
        }
    }
}
