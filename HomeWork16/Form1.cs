using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HomeWork16
{
    public partial class Form1 : Form
    {
        FileStream fs;
        StreamWriter sw;
        int ErrorCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void String1_Click(object sender, EventArgs e)
        {

        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            ErrorCount = 0;
            if (PathValue.Text == "")
            {
                PathValue.Text = "Please Enter a folder path to Search";
                ErrorCount = ErrorCount + 1;
            }
            else
            if (ExtValue1.Text == "")
            {
                ExtValue1.Text = " Please enter correct field";
                ErrorCount = ErrorCount + 1;

                String1.Text = "";
                TextString.Text = "";
                ExtValue1.Text = "";
            }
            try
            {
                fs = new FileStream("Log.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Start Process");

                // populate listbox with files matching user input.
                PopulateListBox(ResultSearch, PathValue.Text, ExtValue1.Text, String1.Text);

                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "End Process");
                sw.Close();
            }
            catch (IOException ex)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "IO Exception Thrown: " + ex.Message);
                sw.Close();
                return;
            }
            catch (Exception ex)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Exception Thrown: " + ex.Message);
                sw.Close();
                return;
            }
        
          

            //string userFilePathInput;
            //string userExtensionInput;
            //string[] files;
            //// assigning global variables equal to text and combo box values
            //userFilePathInput = PathValue.Text; // text box value for file path
            //userExtensionInput = ExtValue1.Text; // combo box value for extension

            //// getting files per user input as arguements
            //files = Directory.GetFiles(userFilePathInput, "*" + userExtensionInput);



        }

        // retrieve files within a directory (path) matching the extension given by the user.
        private void PopulateListBox(ListBox ResultValue, string PathValue, string ExtValue1, string String1)
        {
            // The path value given by the user should be an existing directory.
            // If not, DirectoryNotFoundException will be thrown.

            try
            {
                //Set the current directory to the user's path value.
                Directory.SetCurrentDirectory(this.PathValue.Text);
            }
            catch (DirectoryNotFoundException)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Exception Thrown: Directory Path Not Found");

                throw;
            }
            catch (Exception)
            {
                throw;
            }

            // get files from the current directory with the extension specified by the user.
            // for each file, search its contents for the search string specified by the user.
            // when this string is found, add the file name to the listbox.
            DirectoryInfo directinfo = new DirectoryInfo(PathValue);
            FileInfo[] files = directinfo.GetFiles("*" + ExtValue1);
            foreach (FileInfo file in files)
            {
                bool stringfound = false;
                stringfound = SearchFile(file, String1);
                if (stringfound)
                {
                    ResultValue.Items.Add(file.Name);
                }
            }
        }

        private bool SearchFile(FileInfo file, string stringvalue)
        {
            bool stringfound = false;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(file.ToString()))
                {
                    string line;
                    sr.Read();
                    // Read and check lines for search string from the file
                    // until a match is found, or the end of file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.ToLower().Contains(stringvalue.ToLower()))
                        {
                            stringfound = true;
                            break;
                        }
                        else
                        {
                            stringfound = false;
                        }
                        sr.Read();
                    }
                }
            }
            catch (Exception)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Exception Thrown: File Not Read");

                throw;

            }
            return stringfound;
        }

        private void searchFile(string fileName, string searchString)
        {
            //    /*
            //open file
            //    Read one line at a time
            //    Examine each line to see if it contains searchString
            //    if it contains the string 
            //       return true 
            //    */


            
           
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            PathValue.Text = "";
            String1.Text = "";
            TextString.Text = "";
            ExtValue1.Text = "";
            ResultSearch.Items.Clear();
        }


        private void Results_Click(object sender, EventArgs e)
        {

        }

        private void ResultSearch_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void TextString_TextChanged(object sender, EventArgs e)
        {

        }

        private void PathValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExtValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExtValue1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
