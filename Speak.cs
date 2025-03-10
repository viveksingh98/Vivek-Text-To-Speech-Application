﻿using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Linq;

namespace Vivek_s_Text_To_Speech_Application
{
    public partial class Speak : Form
    {
        private SpeechSynthesizer synthesizer; // Class level variable

        public Speak()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();
            this.Text = "Vivek's Text To Speech Application";
            richTextboxSpeak.KeyDown += new KeyEventHandler(richTextboxSpeak_KeyDown); // KeyDown event subscribe karein

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            LogInstalledVoices(); // Log the installed voices
        }

        private void LogInstalledVoices()
        {
            string voices = "Installed voices:\n";
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                voices += $"Voice Name: {voice.VoiceInfo.Name}, Culture: {voice.VoiceInfo.Culture}\n";
            }
            MessageBox.Show(voices, "Installed Voices", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                string textToSpeak = richTextboxSpeak.Text;
                if (!string.IsNullOrEmpty(textToSpeak))
                {
                    synthesizer.SpeakAsyncCancelAll(); // Pehle ki boli hui speech ko rok de
                    synthesizer.SpeakAsync(textToSpeak); // Naya text aloud padhe
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                synthesizer.Dispose();
                base.OnFormClosing(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during closing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SpeakInHindiWithEspeak(string text)
        {
            try
            {
                if (!string.IsNullOrEmpty(text))
                {
                    System.Diagnostics.Process.Start("espeak", $"-v hi \"{text}\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpeakHindi_Click(object sender, EventArgs e)
        {
            try
            {
                string textToSpeak = richTextboxSpeak.Text;
                if (!string.IsNullOrEmpty(textToSpeak))
                {
                    // Check if the "Microsoft Kalpana" voice is installed
                    var kalpanaVoice = synthesizer.GetInstalledVoices()
                                                  .FirstOrDefault(v => v.VoiceInfo.Name == "Microsoft Kalpana");

                    if (kalpanaVoice != null)
                    {
                        synthesizer.SelectVoice("Microsoft Kalpana");
                        synthesizer.SpeakAsyncCancelAll(); // Cancel any ongoing speech
                        synthesizer.SpeakAsync(textToSpeak); // Speak the new text
                    }
                    else
                    {
                        MessageBox.Show("Microsoft Kalpana voice is not installed.", "Voice Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This is the overridden method to capture the F5 key press
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == (Keys.Control | Keys.H))
                {
                    btnSpeakHindi_Click(null, null);
                    return true; // Key press ko handle kar liya
                }

                if (keyData == (Keys.Control | Keys.E))
                {
                    btnSpeak_Click(null, null);
                    return true; // Key press ko handle kar liya
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return base.ProcessCmdKey(ref msg, keyData); // Default handling
        }


        private void richTextboxSpeak_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.C:
                            if (richTextboxSpeak.SelectionLength > 0)
                                richTextboxSpeak.Copy();
                            break;
                        case Keys.V:
                            if (Clipboard.ContainsText())
                            {
                                int position = richTextboxSpeak.SelectionStart;
                                string beforeText = richTextboxSpeak.Text.Substring(0, position);
                                string afterText = richTextboxSpeak.Text.Substring(position);
                                richTextboxSpeak.Text = beforeText + Clipboard.GetText() + afterText;
                                richTextboxSpeak.SelectionStart = position + Clipboard.GetText().Length;
                                e.Handled = true; // Yeh line add karein
                            }
                            break;
                        case Keys.X:
                            if (richTextboxSpeak.SelectionLength > 0)
                                richTextboxSpeak.Cut();
                            break;
                        case Keys.A:
                            richTextboxSpeak.SelectAll();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
