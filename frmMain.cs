using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace TextToSpeech
{
    public partial class frmMain : Form
    {
        SpeechSynthesizer _voice;

        public frmMain()
        {
            InitializeComponent();

            
            _voice = new SpeechSynthesizer();
            cboSelectVoice.DataSource = Enum.GetValues(typeof(VoiceGender));
            
        }

        private void Speak_Click(object sender, EventArgs e)
        {
            _voice.SelectVoiceByHints((VoiceGender)cboSelectVoice.SelectedItem);


            if (!string.IsNullOrEmpty(txtContent.Text))
                _voice.SpeakAsync(txtContent.Text);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Wav Files|*.wav",
                Title = "Save File as Wav"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                    {
                        _voice.SetOutputToWaveStream(fs);
                        _voice.Speak(txtContent.Text);
                    }
                }
                catch (Exception ex)
                {
                    //handle here
                }
            }
        }

        private void Pause_Click(object sender, EventArgs e) =>
            _voice.Pause();

        private void Resume_Click(object sender, EventArgs e) =>
            _voice.Resume();

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}