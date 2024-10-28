namespace JunPro_8_Worksheet
{
    partial class Form2
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
            qrImg = new PictureBox();
            dataLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)qrImg).BeginInit();
            SuspendLayout();
            // 
            // qrImg
            // 
            qrImg.Location = new Point(12, 12);
            qrImg.Name = "qrImg";
            qrImg.Size = new Size(251, 229);
            qrImg.TabIndex = 0;
            qrImg.TabStop = false;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new Point(11, 258);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(38, 15);
            dataLabel.TabIndex = 1;
            dataLabel.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 450);
            Controls.Add(dataLabel);
            Controls.Add(qrImg);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)qrImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox qrImg;
        private Label dataLabel;
    }
}