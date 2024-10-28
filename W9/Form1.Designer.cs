namespace W9
{
    partial class Form1
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
            HeadLabel = new Label();
            SaldoLabel = new Label();
            actionLabel = new Label();
            UangLabel = new Label();
            PasswordLabel = new Label();
            setorButton = new RadioButton();
            tarikButton = new RadioButton();
            passwordBox = new TextBox();
            submitButton = new Button();
            uangBox = new TextBox();
            SuspendLayout();
            // 
            // HeadLabel
            // 
            HeadLabel.AutoSize = true;
            HeadLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HeadLabel.Location = new Point(291, 41);
            HeadLabel.Name = "HeadLabel";
            HeadLabel.Size = new Size(218, 32);
            HeadLabel.TabIndex = 0;
            HeadLabel.Text = "Saldo Akun Umum";
            // 
            // SaldoLabel
            // 
            SaldoLabel.AutoSize = true;
            SaldoLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaldoLabel.Location = new Point(376, 105);
            SaldoLabel.Name = "SaldoLabel";
            SaldoLabel.Size = new Size(23, 25);
            SaldoLabel.TabIndex = 1;
            SaldoLabel.Text = "0";
            // 
            // actionLabel
            // 
            actionLabel.AutoSize = true;
            actionLabel.Location = new Point(210, 189);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new Size(48, 15);
            actionLabel.TabIndex = 2;
            actionLabel.Text = "Action :";
            // 
            // UangLabel
            // 
            UangLabel.AutoSize = true;
            UangLabel.Location = new Point(176, 218);
            UangLabel.Name = "UangLabel";
            UangLabel.Size = new Size(82, 15);
            UangLabel.TabIndex = 2;
            UangLabel.Text = "Jumlah Uang :";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(195, 249);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(63, 15);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password :";
            // 
            // setorButton
            // 
            setorButton.AutoSize = true;
            setorButton.Location = new Point(274, 187);
            setorButton.Name = "setorButton";
            setorButton.Size = new Size(52, 19);
            setorButton.TabIndex = 3;
            setorButton.TabStop = true;
            setorButton.Text = "Setor";
            setorButton.UseVisualStyleBackColor = true;
            // 
            // tarikButton
            // 
            tarikButton.AutoSize = true;
            tarikButton.Location = new Point(347, 187);
            tarikButton.Name = "tarikButton";
            tarikButton.Size = new Size(49, 19);
            tarikButton.TabIndex = 3;
            tarikButton.TabStop = true;
            tarikButton.Text = "Tarik";
            tarikButton.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(274, 250);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '●';
            passwordBox.Size = new Size(148, 23);
            passwordBox.TabIndex = 6;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(274, 292);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 7;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // uangBox
            // 
            uangBox.Location = new Point(274, 215);
            uangBox.Name = "uangBox";
            uangBox.Size = new Size(148, 23);
            uangBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uangBox);
            Controls.Add(submitButton);
            Controls.Add(passwordBox);
            Controls.Add(tarikButton);
            Controls.Add(setorButton);
            Controls.Add(PasswordLabel);
            Controls.Add(UangLabel);
            Controls.Add(actionLabel);
            Controls.Add(SaldoLabel);
            Controls.Add(HeadLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeadLabel;
        private Label SaldoLabel;
        private Label actionLabel;
        private Label UangLabel;
        private Label PasswordLabel;
        private RadioButton setorButton;
        private RadioButton tarikButton;
        private TextBox passwordBox;
        private Button submitButton;
        private TextBox uangBox;
    }
}
