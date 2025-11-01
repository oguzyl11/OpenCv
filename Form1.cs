using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace NTP_Odev_YuzTanima;

public partial class Form1 : Form
{
    private VideoCapture? capture;
    private CascadeClassifier? faceClassifier;
    private System.Windows.Forms.Timer? timer;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        try
        {
            faceClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Haar cascade dosyası yüklenemedi: {ex.Message}");
        }
    }

    private void btnBaslat_Click(object sender, EventArgs e)
    {
        try
        {
            capture = new VideoCapture(0);
            if (!capture.IsOpened())
            {
                MessageBox.Show("Kamera açılamadı.");
                return;
            }

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 30; // 30 ms aralıklarla çalışacak
            timer.Tick += Timer_Tick;
            timer.Start();

            btnBaslat.Enabled = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Kamera başlatılamadı: {ex.Message}");
        }
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        try
        {
            using (Mat frame = new Mat())
            {
                capture.Read(frame);
                if (frame.Empty())
                    return;

                // Gri tonlamaya çevir
                Mat gray = new Mat();
                Cv2.CvtColor(frame, gray, ColorConversionCodes.BGR2GRAY);

                // Yüzleri tespit et
                Rect[] faces = faceClassifier.DetectMultiScale(
                    gray, 1.1, 3, HaarDetectionTypes.ScaleImage, new OpenCvSharp.Size(30, 30));

                // Tespit edilen yüzlerin etrafına dikdörtgen çiz
                foreach (var face in faces)
                {
                    Cv2.Rectangle(frame, face, Scalar.Red, 2);
                }

                // İşlenmiş kareyi PictureBox'ta göster
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = BitmapConverter.ToBitmap(frame);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Görüntü işleme hatası: {ex.Message}");
        }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        timer?.Stop();
        timer?.Dispose();
        capture?.Release();
        capture?.Dispose();
        faceClassifier?.Dispose();
    }
}
