using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace IndexingProjectDraft1
{
    public partial class Form1 : Form
    {


        List<string> listFiles = new List<string>();
        List<string> s1 = new List<string>();
        //all data inside a individual file
        static string[] filesdata = new string[0];
        //all files i side selected folder
        static string[] filesnames = new string[0];
        static string output = "";
        static string[] indexedfiles = { "" };

        static string shortestWord = "";
        static string longestWord = "";
        static int wordCounter = 0;
        static List<string> wordList = new List<string>();
        static string highestfrequencyOutput = "";
        static string leastfrequencyOutput = "";
        static string recentWord = "";
        static int TotalWordCount = 0;

        private static void processFiles(string[] filesx, string[] filesnamesx, string searchwordx, bool casesensitivityx)
        {
            System.IO.File.WriteAllText(@"C:\TempTextFiles\BinaryIndex.dat", string.Empty);
            //System.IO.File.WriteAllText(@"C:\TempTextFiles\HTML.txt", string.Empty);

            //Indexed files.
            /*Indexed files are the same as files*/
            indexedfiles = filesx;

            //Initialised Output
            output = "";

            /*Go through each and every file*/
            for (int i = 0; i < filesx.Length; i++)
            { //1

                //Get the currentFile data
                string currentFile = filesx[i];
                currentFile += " ";

                //Check the word
                string currentWord = "";

                //Search Word
                int searchWordCount = 0;
                string searchWordIndexes = "";

                //Current file with indexing
                string currentFileIndexedOutput = "";

                //Scan in the file
                for (int j = 0; j < currentFile.Length; j++)
                { //2
                    bool flag = true;
                    if (currentWord.Equals("is") || currentWord.Equals("a") || currentWord.Equals("the") || currentWord.Equals("of") || currentWord.Equals("this") || currentWord.Equals("how") ||
                               currentWord.Equals("all") || currentWord.Equals("ago") || currentWord.Equals("I") || currentWord.Equals("me") || currentWord.Equals("he") || currentWord.Equals("he’ll") || currentWord.Equals("he’s") || currentWord.Equals("she") ||
                               currentWord.Equals("she’ll") || currentWord.Equals("she’s") || currentWord.Equals("am") || currentWord.Equals("in") || currentWord.Equals("so") || currentWord.Equals("is") || currentWord.Equals("be") || currentWord.Equals("let") ||
                               currentWord.Equals("mr") || currentWord.Equals("mrs") || currentWord.Equals("we") || currentWord.Equals("us") || currentWord.Equals("you") || currentWord.Equals("oh") || currentWord.Equals("ok") || currentWord.Equals("ex"))
                    { flag = false; }


                    char c = currentFile[j];

                    if (c == ' ' || c == '\n')
                    {

                        if (currentWord.Length > 1 && flag==true)
                        {

                            //int long = 0;



                            int endIndex = j - 1;
                            int startIndex = j - currentWord.Length;


                            if ((string.Compare(currentWord, searchwordx, casesensitivityx)) == 0)
                            {
                                searchWordCount++;
                                searchWordIndexes += "(" + startIndex + ", " + endIndex + ") ";
                            }

                            currentFileIndexedOutput += currentWord + "|" + " (" + startIndex + "," + endIndex + ")" + "|" + filesnamesx[i] + "\n";
                            //write this line in binary file for indexing


                            wordList.Add(currentWord);

                            if (wordCounter == 0)
                            {
                                longestWord = currentWord;
                                shortestWord = currentWord;
                            }

                            wordCounter++;

                            //Report file
                            //Longest
                            if (longestWord.Length < currentWord.Length)
                            {
                                longestWord = currentWord;
                            }

                            //Shortest
                            if (shortestWord.Length > currentWord.Length)
                            {
                                shortestWord = currentWord;
                            }


                            string BinaryFile = @"C:\TempTextFiles\BinaryIndex.dat";
                            if (!File.Exists(BinaryFile))
                            {
                                using (FileStream fs = new FileStream(BinaryFile, FileMode.Create, FileAccess.Write))
                                using (BinaryWriter bw = new BinaryWriter(fs))


                                {
                                    bw.Write(currentFileIndexedOutput);
                                }
                            }
                            else
                            {
                                using (FileStream fs = new FileStream(BinaryFile, FileMode.Append, FileAccess.Write))
                                using (BinaryWriter bw = new BinaryWriter(fs))
                                {
                                    bw.Write(currentFileIndexedOutput);
                                }

                            }
                            // Console.WriteLine("thisssssssssssssssss"+filesnames+','+ currentFileIndexedOutput);
                            currentWord = "";


                        }

                    }
                    else
                    {
                        currentWord += c;
                        recentWord = currentWord;
                    }

                }//for 2

                TotalWordCount = wordCounter;


                if (searchWordCount > 0)
                {
                    output += searchwordx + " count: " + searchWordCount + " indexes: " + searchWordIndexes + " file: " + filesnamesx[i] + "\n";
                }
                indexedfiles[i] = currentFileIndexedOutput;

            }//for 1

            //OPTIONAL
            Debug.Write("Output:\n\n" + output + "Indexed Files:\n\n");


        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            listViewfiles.Items.Clear();

            using (FolderBrowserDialog fbd = new FolderBrowserDialog()
            { Description = "Select Folder" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    var files = from file in System.IO.Directory.EnumerateFiles(fbd.SelectedPath)
                                let extension = System.IO.Path.GetExtension(file)
                                where extension.Equals(".txt")
                                select file;
                    txtboxpath.Text = fbd.SelectedPath;


                    foreach (string item in System.IO.Directory.GetFiles(fbd.SelectedPath, "*.txt"))
                    {

                        //wordfind.Add(new filewords())
                        imageList1.Images.Add(Icon.ExtractAssociatedIcon(item));
                        System.IO.FileInfo fi = new System.IO.FileInfo(item);
                        listFiles.Add(fi.FullName);
                        listViewfiles.Items.Add(fi.Name, imageList1.Images.Count - 1);

                        Array.Resize(ref filesnames, filesnames.Length + 1);
                        filesnames[filesnames.Length - 1] = item;



                        Array.Resize(ref filesdata, filesdata.Length + 1);
                        filesdata[filesdata.Length - 1] = File.ReadAllText(item); ;

                    }


                    string[] array = new string[files.Count()];

                    int i = 0;
                    foreach (String item in files)
                    {
                        System.IO.StreamReader fi = new System.IO.StreamReader(item);
                        array[i] = fi.ReadToEnd();
                        i++;

                    }

                   
                }

            }

            processFiles(filesdata, filesnames, txtboxword.Text, true);
        }


        string currentDir = System.IO.Directory.GetCurrentDirectory();
        private void listViewfiles_ItemActivate(object sender, EventArgs e)
        {
            string selectedFile = listViewfiles.SelectedItems[0].Text;
            // the file exists open the file.
            if (File.Exists(Path.Combine(currentDir, selectedFile)))
            {
                //
                try
                {
                    System.Diagnostics.Process.Start(Path.Combine(currentDir, selectedFile));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        private void listViewfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //BinaryReader binReader = new BinaryReader(File.Open(BinaryFile, FileMode.Open)
        //string authorName = binReader.ReadString();

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //string wd = txtboxsearch.Text;

            if (txtboxword.Text != "")
            {
                FileStream inFile = new FileStream(@"C:\TempTextFiles\BinaryIndex.dat", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);
                string record;
                string input;
                input = txtboxword.Text;
                try
                {
                    //the program reads the record and displays it on the screen
                    record = reader.ReadLine();
                    while (record != null)
                    {
                        if (record.Contains(input))
                        {
                            // Console.WriteLine(record);
                            listboxindex.Items.Add(record);

                        }
                        record = reader.ReadLine();
                    }
                }
                finally
                {
                    //after the record is done being read, the progam closes
                    reader.Close();
                    inFile.Close();
                }
                Console.ReadLine();


            }
        }

        private void htmlbtn_Click(object sender, EventArgs e)
        {
            //if (htmltxtbox.Text != "")
            //{


                string htmlinput;
                htmlinput = htmltxtbox.Text;



                WebClient client = new WebClient();
                List<string> t = new List<string>();
                List<string> s = new List<string>();
                List<string> l = new List<string>();
                string h = client.DownloadString(htmlinput);
                var doc = new HtmlWeb().Load(htmlinput);

                HtmlNodeCollection titleCol = doc.DocumentNode.SelectNodes("//title");
                t.Add(titleCol[0].InnerText);

                HtmlNodeCollection anchorColl = doc.DocumentNode.SelectNodes("//a");
                foreach (var anchor in anchorColl)
                {
                    l.Add(anchor.InnerText);
                }

                HtmlNodeCollection scriptColl = doc.DocumentNode.SelectNodes("//script");
                foreach (var script in scriptColl)
                {
                    s.Add(script.InnerText);
                }


                listBox3.DataSource = t;
                listBox1.DataSource = l;
                listBox2.DataSource = s;
                                
                Console.ReadLine();



            //}
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            Debug.Write("Output:\n\n" + output + "\n\nINDEXED FILES:\n\n");

            for (int i = 0; i < indexedfiles.Length; i++)
            {
                Debug.Write(filesnames[i] + ":\n");
                Debug.Write(indexedfiles[i] + "\n\n");
            }

            Debug.Write("Shortest Word: " + shortestWord + "\n");
            Debug.Write("Longest Word: " + longestWord + "\nWords: " + wordList.Count + "\n");
            largestWordFrequency(wordList);
            leastWordFrequency(wordList);
            reportrichtxtbox.AppendText("Shortest Word is " + shortestWord + "\n");
            reportrichtxtbox.AppendText("Longest Word is " + longestWord + "\n");
            reportrichtxtbox.AppendText("Most Used Word and its frequency is " + highestfrequencyOutput + "\n");
            reportrichtxtbox.AppendText("Least Used Word and its frequency is " + leastfrequencyOutput + "\n");
            reportrichtxtbox.AppendText("Most Recent used Word " + recentWord + "\n");
            reportrichtxtbox.AppendText("Total count of words " + TotalWordCount + "\n");
        }



        private static void largestWordFrequency(List<string> words)
        {
            /*for (int x = 0; x < words.Count;x++){
                Debug.Write(words[x]+"\n");
            }*/

            int count = 0;
            int largestFrequencyWordCount = 0;
            string largestFrequencyWord = "";

            for (int i = 0; i < words.Count; i++)
            {

                string currentWord = words[i];
                for (int j = 0; j < words.Count; j++)
                {

                    if ((string.Compare(currentWord, words[j], true)) == 0)
                    {
                        count++;
                    }
                }

                if (count > largestFrequencyWordCount)
                {
                    largestFrequencyWordCount = count;
                    largestFrequencyWord = currentWord;
                }
                count = 0;
            }
            //Debug.Write("Word: " + largestFrequencyWord + "\nFrequency: " +largestFrequencyWordCount);
            highestfrequencyOutput = "Word: " + largestFrequencyWord + "\nFrequency: " + largestFrequencyWordCount;
        }

        private static void leastWordFrequency(List<string> words)
        {
            /*for (int x = 0; x < words.Count;x++){
                Debug.Write(words[x]+"\n");
            }*/

            int count = 0;
            int leastFrequencyWordCount = 10000;
            string leastFrequencyWord = "";

            for (int i = 0; i < words.Count; i++)
            {

                string currentWord = words[i];
                for (int j = 0; j < words.Count; j++)
                {

                    if ((string.Compare(currentWord, words[j], true)) == 0)
                    {
                        count++;
                    }
                }

                if (count < leastFrequencyWordCount)
                {
                    leastFrequencyWordCount = count;
                    leastFrequencyWord = currentWord;
                }
                count = 0;
            }
            //Debug.Write("Word: " + leastFrequencyWord + "\nFrequency: " +leastFrequencyWordCount);
            leastfrequencyOutput = "Word: " + leastFrequencyWord + "\nFrequency: " + leastFrequencyWordCount;
        }

        private void button1_Click(object sender, EventArgs e) // Open selected file for searched word
        {
            string nn = listboxindex.SelectedItem.ToString();
            string[] sep = { "|" };
            string[] sepword = nn.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            richTextBoxfileitems.Text = File.ReadAllText(sepword[2]);

        }

        private void listboxindex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
