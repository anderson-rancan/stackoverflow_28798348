namespace stackoverflow_28798348
{
    internal partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnBrowseSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.totalProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFileProgress = new System.Windows.Forms.Label();
            this.fileProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalProgress = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDoWork = new System.Windows.Forms.Button();
            this.buttonCancelWork = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // btnBrowseSave
            // 
            this.btnBrowseSave.Location = new System.Drawing.Point(174, 290);
            this.btnBrowseSave.Name = "btnBrowseSave";
            this.btnBrowseSave.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSave.TabIndex = 0;
            this.btnBrowseSave.Text = "Save...";
            this.btnBrowseSave.UseVisualStyleBackColor = true;
            this.btnBrowseSave.Click += new System.EventHandler(this.btnBrowseSave_Click);
            // 
            // totalProgressBar
            // 
            this.totalProgressBar.Location = new System.Drawing.Point(16, 56);
            this.totalProgressBar.Name = "totalProgressBar";
            this.totalProgressBar.Size = new System.Drawing.Size(164, 23);
            this.totalProgressBar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFileProgress);
            this.groupBox1.Controls.Add(this.fileProgressBar);
            this.groupBox1.Controls.Add(this.lblTotalFiles);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // lblFileProgress
            // 
            this.lblFileProgress.AutoSize = true;
            this.lblFileProgress.Location = new System.Drawing.Point(12, 92);
            this.lblFileProgress.Name = "lblFileProgress";
            this.lblFileProgress.Size = new System.Drawing.Size(74, 13);
            this.lblFileProgress.TabIndex = 0;
            this.lblFileProgress.Text = "lblFileProgress";
            // 
            // fileProgressBar
            // 
            this.fileProgressBar.Location = new System.Drawing.Point(16, 114);
            this.fileProgressBar.Name = "fileProgressBar";
            this.fileProgressBar.Size = new System.Drawing.Size(164, 23);
            this.fileProgressBar.TabIndex = 1;
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Location = new System.Drawing.Point(13, 51);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(62, 13);
            this.lblTotalFiles.TabIndex = 0;
            this.lblTotalFiles.Text = "lblTotalFiles";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(13, 27);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(61, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "lblFileName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalProgress);
            this.groupBox2.Controls.Add(this.totalProgressBar);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totals";
            // 
            // lblTotalProgress
            // 
            this.lblTotalProgress.AutoSize = true;
            this.lblTotalProgress.Location = new System.Drawing.Point(13, 34);
            this.lblTotalProgress.Name = "lblTotalProgress";
            this.lblTotalProgress.Size = new System.Drawing.Size(82, 13);
            this.lblTotalProgress.TabIndex = 0;
            this.lblTotalProgress.Text = "lblTotalProgress";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 260);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drop here!";
            this.groupBox3.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBox3_DragDrop);
            this.groupBox3.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupBox3_DragEnter);
            // 
            // buttonDoWork
            // 
            this.buttonDoWork.Location = new System.Drawing.Point(12, 290);
            this.buttonDoWork.Name = "buttonDoWork";
            this.buttonDoWork.Size = new System.Drawing.Size(75, 23);
            this.buttonDoWork.TabIndex = 5;
            this.buttonDoWork.Text = "Do Work";
            this.buttonDoWork.UseVisualStyleBackColor = true;
            this.buttonDoWork.Click += new System.EventHandler(this.buttonDoWork_Click);
            // 
            // buttonCancelWork
            // 
            this.buttonCancelWork.Enabled = false;
            this.buttonCancelWork.Location = new System.Drawing.Point(93, 290);
            this.buttonCancelWork.Name = "buttonCancelWork";
            this.buttonCancelWork.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelWork.TabIndex = 6;
            this.buttonCancelWork.Text = "Cancel";
            this.buttonCancelWork.UseVisualStyleBackColor = true;
            this.buttonCancelWork.Click += new System.EventHandler(this.buttonCancelWork_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 325);
            this.Controls.Add(this.buttonCancelWork);
            this.Controls.Add(this.buttonDoWork);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowseSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btnBrowseSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ProgressBar totalProgressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblTotalProgress;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.Label lblFileProgress;
        private System.Windows.Forms.ProgressBar fileProgressBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDoWork;
        private System.Windows.Forms.Button buttonCancelWork;
    }
}

