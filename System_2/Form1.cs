using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace System_2
{
    public partial class Form1 : Form
    {
        string destinationFilePath = string.Empty, fileName = string.Empty;
        Thread t = null;
        FolderBrowserDialog folderBrowserDialog = null;
        OpenFileDialog openFileDialog = null;
        public Form1()
        {
            InitializeComponent();
        }

        #region Event

        private void button_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn == fileOpen1)
            {
                if (openFileDialog == null)
                    openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "*.all|*.*|.txt|*.txt|.pdf|*.pdf";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;
                    fileName = openFileDialog.SafeFileName;
                    fileOpen2.Enabled = true;
                }
            }
            else if (btn == fileOpen2)
            {
                if (folderBrowserDialog == null)
                    folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = folderBrowserDialog.SelectedPath;
                    copy.Enabled = true;
                }
            }
            else if (btn == copy)
            {
                t = new Thread(Copy_Paste)
                {
                    IsBackground = true
                };

                t.Start();

                suspend.Enabled = true;
                abort.Enabled = true;
            }
            else if (btn == suspend)
            {
                if (t != null)
                    if (t.ThreadState != ThreadState.Aborted)
                    {
                        suspend.Enabled = false;
                        resume.Enabled = true;
                        abort.Enabled = false;

                        t.Suspend();
                    }
            }
            else if (btn == resume)
            {
                if (t != null)
                    if (t.ThreadState != ThreadState.Aborted & t.ThreadState != ThreadState.Aborted)
                    {
                        suspend.Enabled = true;
                        resume.Enabled = false;
                        abort.Enabled = true;

                        t.Resume();
                    }
            }
            else if (btn == abort)
            {
                if (t != null)
                {
                    t.Abort();

                    MessageBox.Show("Copy operation was cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    suspend.Enabled = false;
                    resume.Enabled = false;
                    abort.Enabled = false;
                    copy.Enabled = false;

                    openFileDialog.Reset();
                    folderBrowserDialog.Reset();

                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    progressBar1.Value = 0;
                    percent.Text = 0.ToString() + " %";

                    File.Delete(destinationFilePath);
                }
            }
        }

        #endregion

        private void Copy_Paste()
        {
            int a = 0;

            byte[] fileBytes = File.ReadAllBytes(textBox1.Text);

            destinationFilePath = Path.Combine(textBox2.Text, fileName);
            do
            {
                if (File.Exists(destinationFilePath))
                    destinationFilePath = Path.Combine(textBox2.Text, fileName.Split('.')[0] + '_' + (++a).ToString() + '.' + fileName.Split('.')[1]);
                else
                    break;
            }
            while (true);
            using (FileStream destinationFile = new FileStream(destinationFilePath, FileMode.Create))
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i == 99)
                    {
                        destinationFile.Write(fileBytes, 0, fileBytes.Length);

                        progressBar1.Invoke(new Action(() =>
                        {
                            percent.Text = i.ToString() + " %";

                            Thread.Sleep(200);
                            i = 100;

                            percent.Text = i.ToString() + " %";

                            progressBar1.Value = 100;

                            MessageBox.Show("Copy operation was completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            abort.Enabled = false;
                            resume.Enabled = false;
                            suspend.Enabled = false;
                            copy.Enabled = false;

                            openFileDialog.Reset();
                            folderBrowserDialog.Reset();

                            textBox1.Text = string.Empty;
                            textBox2.Text = string.Empty;
                            progressBar1.Value = 0;
                            percent.Text = 0.ToString() + " %";
                        }));
                    }
                    else
                    {
                        Thread.Sleep(100);

                        progressBar1.Invoke(new Action(() =>
                        {
                            progressBar1.Value = i;
                            percent.Text = i.ToString() + " %";
                        }));
                    }
                }

            }
        }
    }
}
