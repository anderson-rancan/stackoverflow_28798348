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

namespace stackoverflow_28798348
{
    internal partial class Form1 : Form
    {

        private string saveFilePath = string.Empty;
        private bool hadReadErrors = false;
        private string[] files;
        private Dictionary<string, object> dicEmails;
        private DragEventArgs dragEventArgs;
        private int stopPosition;

        public Form1()
        {
            InitializeComponent();

            this.dicEmails = new Dictionary<string, object>();
            this.groupBox3.AllowDrop = true;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bckw = (BackgroundWorker)sender;

            try
            {
                if (string.IsNullOrEmpty(saveFilePath))
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        btnBrowseSave.PerformClick();
                    }));
                }
                if (!string.IsNullOrEmpty(saveFilePath))
                {
                    if (dragEventArgs != null)
                        files = (string[])dragEventArgs.Data.GetData(DataFormats.FileDrop);

                    int filesCount = 0, rowsCount = 0;
                    foreach (string file in files)
                    {
                        filesCount++;
                        int fileTotalLines = File.ReadAllLines(file).Length;

                        this.BeginInvoke(new MethodInvoker(delegate
                        {
                            lblFileName.Text = "Loading file: " + file.Substring(file.LastIndexOf("\\") + 1);
                            lblTotalFiles.Text = "File " + filesCount + " of " + files.Length;
                        }));

                        using (StreamReader reader = new StreamReader(file))
                        {
                            using (StreamWriter writer = new StreamWriter(saveFilePath))
                            {
                                while (!reader.EndOfStream)
                                {
                                    try
                                    {
                                        while (stopPosition > rowsCount)
                                        {
                                            reader.ReadLine();
                                            rowsCount++;
                                        }
                                        string email = reader.ReadLine().Trim();
                                        if (!string.IsNullOrEmpty(email) && !dicEmails.ContainsKey(email))
                                        {
                                            dicEmails.Add(email, null);
                                            writer.WriteLine(email);
                                        }
                                        rowsCount++;
                                        stopPosition++;

                                        bckw.ReportProgress((rowsCount * 100 / fileTotalLines), (int)ProgressType.Row);
                                        if (bckw.CancellationPending)
                                            return;
                                    }
                                    catch (Exception ex)
                                    {
                                        hadReadErrors = true;
                                    }
                                }
                            }
                        }
                        bckw.ReportProgress(0, (int)ProgressType.Row);
                        bckw.ReportProgress((filesCount * 100 / files.Length), (int)ProgressType.File);
                    }
                }
            }
            catch (Exception ex)
            {
                hadReadErrors = true;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bckw.Dispose();
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //try
            //{
                switch ((int)e.UserState)
                {
                    case (int)ProgressType.Row:
                        lblFileProgress.Text = e.ProgressPercentage + "%";
                        if (e.ProgressPercentage <= fileProgressBar.Maximum)
                            fileProgressBar.Value = e.ProgressPercentage;
                        break;
                    case (int)ProgressType.File:
                        lblTotalProgress.Text = e.ProgressPercentage + "%";
                        totalProgressBar.Value = e.ProgressPercentage;
                        break;
                }
            //}
            //catch (Exception ex) { }
        }

        private void btnBrowseSave_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                this.saveFilePath = saveFileDialog.FileName;
            else
                this.saveFilePath = string.Empty;
        }

        private void buttonCancelWork_Click(object sender, EventArgs e)
        {
            if (this.backgroundWorker.IsBusy)
            {
                this.backgroundWorker.CancelAsync();
                this.buttonCancelWork.Enabled = false;
            }
        }

        private void groupBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetFormats().Contains("FileName"))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void groupBox3_DragDrop(object sender, DragEventArgs e)
        {
            this.dragEventArgs = e;
        }

        private void buttonDoWork_Click(object sender, EventArgs e)
        {
            this.backgroundWorker.RunWorkerAsync();
            this.buttonDoWork.Enabled = false;
            this.buttonCancelWork.Enabled = true;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.buttonDoWork.Enabled = true;
            this.buttonCancelWork.Enabled = false;
        }

    }
}
