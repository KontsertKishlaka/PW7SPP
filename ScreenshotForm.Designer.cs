namespace PW7SPP
{
    partial class ScreenshotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AltPrintScreenButton = new Button();
            SuspendLayout();
            // 
            // AltPrintScreenButton
            // 
            AltPrintScreenButton.BackColor = SystemColors.ButtonFace;
            AltPrintScreenButton.Location = new Point(12, 12);
            AltPrintScreenButton.Name = "AltPrintScreenButton";
            AltPrintScreenButton.Size = new Size(776, 426);
            AltPrintScreenButton.TabIndex = 0;
            AltPrintScreenButton.Text = "Имитация сочетания клавиш <Alt> + <PrintScreen>";
            AltPrintScreenButton.UseVisualStyleBackColor = false;
            AltPrintScreenButton.Click += AltPrintScreenButton_Click;
            // 
            // ScreenshotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AltPrintScreenButton);
            Name = "ScreenshotForm";
            Text = "Form1";
            Load += ScreenshotForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AltPrintScreenButton;
    }
}
