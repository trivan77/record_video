using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using Ozeki.Media;
using Ozeki.Camera;
using Ozeki.VoIP;
using Accord.Video.FFMPEG;

namespace Record_CameraIP
{
     public partial class Form1 : Form
     {
        //MJPEGStream stream;
        private IIPCamera _camera;
        private DrawingImageProvider _imageProvider = new DrawingImageProvider();
        private MediaConnector _connector = new MediaConnector();
        private VideoViewerWF _videoViewerWF1;
        public VideoFileWriter FileWriter = new VideoFileWriter();
        private MPEG4Recorder _mpeg4Recorder;
        public Form1()
          {
               InitializeComponent();
            //stream = new MJPEGStream("rtsp://khanh29bk:Admin123@192.168.10.12/Src/MediaInput/h264/stream_1/ch_");
            //stream.NewFrame += GetNewFrame;
            // Create video viewer UI control
            
        }

          //void GetNewFrame(object sender, NewFrameEventArgs eventarg)
          //{
          //     Bitmap bmp = (Bitmap)eventarg.Frame.Clone();
          //     display.Image = bmp;
          //}

          private void btnStart_Click(object sender, EventArgs e)
          {
            panel1.Controls.Clear();
            _videoViewerWF1 = new VideoViewerWF();
            _videoViewerWF1.Name = "videoViewerWF1";
            _videoViewerWF1.Size = panel1.Size;


            // Bind the camera image to the UI control
            _videoViewerWF1.SetImageProvider(_imageProvider);
            panel1.Controls.Add(_videoViewerWF1);

            //stream.Start();
            _camera = IPCameraFactory.GetCamera("rtsp://sla:1123456@117.6.121.13:554/axis-media/media.amp", "sla", "1123456");
            _connector.Connect(_camera.VideoChannel, _imageProvider);
            _camera.Start();
            _videoViewerWF1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(btnStop.Text == "Stop")
            {
                _videoViewerWF1.Stop();
            }

            if(btnStop.Text == "Stop Record")
            {
                StopVideoRecord();
                btnRecord.Text = "Record";
                btnRecord.BackColor = Color.FromKnownColor(KnownColor.Control);
                btnStop.Text = "Stop";

                

            }
            
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if(btnStop.Text == "Stop")
            {
                btnStop.Text = "Stop Record";
                btnRecord.Text = "Recording";
                btnRecord.BackColor = Color.Red;
                
                // Lấy ổ cứng muốn lưu từ file config
                FileStream fs = new FileStream(@"E:\record_CameraIP\Record_CameraIP\config.txt", FileMode.Open);
                StreamReader rd = new StreamReader(fs, Encoding.UTF8);
                string source = rd.ReadLine();

                var date = DateTime.Now.Year + "y-" + DateTime.Now.Month + "m-" + DateTime.Now.Day + "d-";
                
                string path = source + date;
                if(Directory.Exists(path))
                         StartVideoRecord(path);
                DirectoryInfo di = Directory.CreateDirectory(path);
                StartVideoRecord(path);
            }
            

        }

        private void StartVideoRecord(string path)
        {
            var date = DateTime.Now.Hour + "h-" + DateTime.Now.Minute + "m-" + DateTime.Now.Second + "s";
            string currentpath;
            if (String.IsNullOrEmpty(path))
                currentpath = date + ".mp4";
            else
                currentpath = path + "\\" + date + ".mp4";

            _mpeg4Recorder = new MPEG4Recorder(currentpath);
            _mpeg4Recorder.MultiplexFinished += Mpeg4Recorder_MultiplexFinished;
            //_connector.Connect(_camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
            _connector.Connect(_camera.VideoChannel, _mpeg4Recorder.VideoRecorder);
        }

        private void Mpeg4Recorder_MultiplexFinished(object sender, VoIPEventArgs<bool> e)
        {
            _mpeg4Recorder.MultiplexFinished -= Mpeg4Recorder_MultiplexFinished;
            //_connector.Disconnect(_camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
            //_connector.Disconnect(_camera.VideoChannel, _mpeg4Recorder.VideoRecorder);
            _mpeg4Recorder.Dispose();
        }

        
        private void StopVideoRecord()
        {
            if (_mpeg4Recorder != null)
            {
                _mpeg4Recorder.Multiplex();
                //_connector.Disconnect(_camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
                _connector.Disconnect(_camera.VideoChannel, _mpeg4Recorder.VideoRecorder);
            }
        }

     }
}
