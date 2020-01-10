using System;
using System.Windows.Forms;
using Caroline.Core;
//using WMPLib;

namespace Caroline.Forms
{
    public partial class CoreLineVi : Form
    {

        bool _txt = true;
        string _state;
        int _pices = 0;
        Emotions em = new Emotions();
        TimeSpan _do = new TimeSpan(23, 00, 00);
        TimeSpan _pose = new TimeSpan(06, 00, 00);
        Face _f = new Face();
//        WMPLib.WindowsMediaPlayer Player;

        public CoreLineVi()
        {
            InitializeComponent();
            pa_load.Top = Height / 2 - pa_load.Height / 2;
            pa_load.Left = Width / 2 - pa_load.Width / 2;

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            

//            Player = new WMPLib.WindowsMediaPlayer();
//            Player.MediaError += new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
//            PlayFile();

            //f.Fase(Face.State.THANKS);
        }

//        private void PlayFile()
//        {
//            Player.settings.volume = 25;
//            Player.URL = @"F:\load.wav";
//            Player.controls.play();
//        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        private void faceupdate_Tick(object sender, EventArgs e)
        {
            la_Face.Top = Height / 2 - la_Face.Height / 2;
            la_Face.Left = Width / 2 - la_Face.Width / 2;
            la_text.Left = Width / 2 - la_text.Width / 2;

            var someTime = new DateTime();
            someTime = DateTime.Now;
            var Time = someTime.TimeOfDay;

            _state = "happy";

            la_Face.Text = em.feels(_state);
            la_state.Text = $"*{_state}*";
            la_text.Text = "Релиз!";

            //if (Time > _do || Time < _pose)
            //{
            //la_Face.Text = em.feels("fatigue");
            //la_text.Text = "Ди спать...";

            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_txt) { la_Name.Text = "CoreLine..."; _txt = false; }
            else { la_Name.Text = "CoreLine.."; _txt = true; }
            switch (_pices)
            {
                case 0:
                    la_subLoad.Text = "Подготовка...";
                    _pices++;
                    break;
                case 1:
                    la_subLoad.Text = "Запуск компонентов...";
                    _pices++;
                    break;
                case 2:
                    la_subLoad.Text = "Компоненты запущены...";
                    _pices++;
                    break;
                case 3:
                    la_subLoad.Text = "Настройка параметров...";
                    _pices++;
                    break;
                case 4:
                    la_subLoad.Text = "Начинаем!";
                    _pices++;
                    break;
                case 5:
                    timer1.Enabled = false;
                    pa_load.Visible = false;
                    la_text.Visible = true;
                    la_Face.Visible = true;
                    faceUpdate.Enabled = true;
                    
                    break;
            }
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
