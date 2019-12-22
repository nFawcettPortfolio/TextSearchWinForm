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

namespace TextSearchWinForms
{
    public partial class Form1 : Form
    {
        private string line;
        private int linePos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    text_fileName.Text = dialog.FileName;
                }

            }
            catch(Exception)
            {
                MessageBox.Show("An error occured.");
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string searchString = txt_SearchString.Text;
            string fileName = text_fileName.Text;

            linePos = 0;
            lv_Results.Items.Clear();

            if (searchString != null && fileName != null)
            {
                lbl_Status.Text = "Search starting...";
                try
                {
                    using (StreamReader sr = new StreamReader(fileName))

                        while ((line = sr.ReadLine()) != null)
                        {
                            linePos++;
                            if (CompareString(line, searchString))
                            {
                                var item = new ListViewItem(new[] { linePos.ToString(), line });
                                lv_Results.Items.Add(item);
                            }
                        }
                    lbl_Status.Text = "Search Complete.";
                }
                catch (Exception)
                {
                    lbl_Status.Text="An error occured. Please try again.";
                }
            }
        }

        private bool CompareString(String line, String searchString)
        {
            return line?.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
