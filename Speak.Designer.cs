namespace Vivek_s_Text_To_Speech_Application
{
    partial class Speak
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
            this.richTextboxSpeak = new System.Windows.Forms.RichTextBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnSpeakHindi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextboxSpeak
            // 
            this.richTextboxSpeak.AcceptsTab = true;
            this.richTextboxSpeak.BackColor = System.Drawing.Color.PapayaWhip;
            this.richTextboxSpeak.Location = new System.Drawing.Point(126, 94);
            this.richTextboxSpeak.Name = "richTextboxSpeak";
            this.richTextboxSpeak.Size = new System.Drawing.Size(838, 263);
            this.richTextboxSpeak.TabIndex = 0;
            this.richTextboxSpeak.Text = "";
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeak.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSpeak.Location = new System.Drawing.Point(178, 397);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(337, 91);
            this.btnSpeak.TabIndex = 1;
            this.btnSpeak.Text = "Speak in English";
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnSpeakHindi
            // 
            this.btnSpeakHindi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSpeakHindi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeakHindi.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSpeakHindi.Location = new System.Drawing.Point(582, 397);
            this.btnSpeakHindi.Name = "btnSpeakHindi";
            this.btnSpeakHindi.Size = new System.Drawing.Size(349, 91);
            this.btnSpeakHindi.TabIndex = 2;
            this.btnSpeakHindi.Text = "Speak in Hindi";
            this.btnSpeakHindi.UseVisualStyleBackColor = false;
            this.btnSpeakHindi.Click += new System.EventHandler(this.btnSpeakHindi_Click);
            // 
            // Speak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 594);
            this.Controls.Add(this.btnSpeakHindi);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.richTextboxSpeak);
            this.Name = "Speak";
            this.Text = "Vivek\'s Text To Speech Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextboxSpeak;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnSpeakHindi;
    }
}

