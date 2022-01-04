using NReco.VideoInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VedioSpliter
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_split_Click(object sender, EventArgs e)
        {

            var filePathVedio = string.Empty;

            using (OpenFileDialog fdVedio = new OpenFileDialog())
            {
                fdVedio.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // 초기화면
                fdVedio.Filter = "Video Files | *.mp4; *.wmv; *.avi";    // 필터
                fdVedio.FilterIndex = 1;

                if (fdVedio.ShowDialog() == DialogResult.OK)
                {
                    filePathVedio = fdVedio.FileName;

                    //FFProbe ffProbe = new FFProbe();
                    //var videoInfo = ffProbe.GetMediaInfo(filePath);
                    //double videoDuration = Math.Floor(videoInfo.Duration.TotalSeconds);

                    for (int i = 0; i < list.Count; i++)
                    {
                        int start = Convert.ToInt16(list[i]);
                        int end = Convert.ToInt16(endTextBox.Text);
                        string outputFilename = $@"{lab_path.Text}\{txt_name.Text}+{i}.mp4";
                        string command = $"-i \"{filePathVedio}\" -ss {start} -t {end} \"{outputFilename}\"";

                        FfmpegHandler.ExecuteFFMpeg(command);

                        Process.Start("explorer.exe", "/select, \"" + $@"{lab_path.Text}" + "\"");

                        Application.Exit();
                    }
                }
            }
        }

        private void btn_OpenCsv_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // 초기화면
                fd.Filter = "CSV Files (*.csv)|*.csv";    // 필터
                fd.FilterIndex = 1;

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    filePath = fd.FileName;
                    StreamReader sr = new StreamReader(filePath);

                    while (!sr.EndOfStream)
                    {
                        // 한 줄씩 읽어온다.
                        string line = sr.ReadLine();
                        // 쉼표( , )를 기준으로 데이터를 분리한다.
                        string[] data = line.Split(',');

                        for (int i = 0; i < data.Length; i++)
                        {
                            list.Add(Convert.ToInt16(data[i]));
                        }
                    }
                }
            }
        }

        private void btn_savePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lab_path.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}