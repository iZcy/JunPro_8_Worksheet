namespace JunPro_8_Worksheet
{
    partial class Form
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
            DataUsers = new Label();
            Header = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            HandphoneBox = new TextBox();
            AlamatBox = new TextBox();
            NoHandphoneLabel = new Label();
            AlamatLabel = new Label();
            NamaLabel = new Label();
            NamaBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            Delete = new Button();
            Update = new Button();
            InsertButton = new Button();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            LoadButton = new Button();
            Header.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // DataUsers
            // 
            DataUsers.Dock = DockStyle.Fill;
            DataUsers.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            DataUsers.Location = new Point(0, 0);
            DataUsers.Name = "DataUsers";
            DataUsers.Size = new Size(770, 100);
            DataUsers.TabIndex = 0;
            DataUsers.Text = "Data Users";
            DataUsers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            Header.Controls.Add(DataUsers);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(15, 15);
            Header.Name = "Header";
            Header.Size = new Size(770, 100);
            Header.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(15, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 120);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(770, 120);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.7622375F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.2377625F));
            tableLayoutPanel2.Controls.Add(HandphoneBox, 1, 2);
            tableLayoutPanel2.Controls.Add(AlamatBox, 1, 1);
            tableLayoutPanel2.Controls.Add(NoHandphoneLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(AlamatLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(NamaLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(NamaBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 48.71795F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 51.28205F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.Size = new Size(286, 114);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // HandphoneBox
            // 
            HandphoneBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            HandphoneBox.Location = new Point(108, 84);
            HandphoneBox.Margin = new Padding(0);
            HandphoneBox.Name = "HandphoneBox";
            HandphoneBox.Size = new Size(178, 23);
            HandphoneBox.TabIndex = 7;
            // 
            // AlamatBox
            // 
            AlamatBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AlamatBox.Location = new Point(108, 46);
            AlamatBox.Margin = new Padding(0);
            AlamatBox.Name = "AlamatBox";
            AlamatBox.Size = new Size(178, 23);
            AlamatBox.TabIndex = 6;
            // 
            // NoHandphoneLabel
            // 
            NoHandphoneLabel.AutoSize = true;
            NoHandphoneLabel.Dock = DockStyle.Left;
            NoHandphoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoHandphoneLabel.Location = new Point(3, 78);
            NoHandphoneLabel.Name = "NoHandphoneLabel";
            NoHandphoneLabel.Size = new Size(90, 36);
            NoHandphoneLabel.TabIndex = 4;
            NoHandphoneLabel.Text = "No Handphone";
            NoHandphoneLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AlamatLabel
            // 
            AlamatLabel.AutoSize = true;
            AlamatLabel.Dock = DockStyle.Left;
            AlamatLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AlamatLabel.Location = new Point(3, 38);
            AlamatLabel.Name = "AlamatLabel";
            AlamatLabel.Size = new Size(46, 40);
            AlamatLabel.TabIndex = 2;
            AlamatLabel.Text = "Alamat";
            AlamatLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NamaLabel
            // 
            NamaLabel.AutoSize = true;
            NamaLabel.Dock = DockStyle.Left;
            NamaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaLabel.Location = new Point(3, 0);
            NamaLabel.Name = "NamaLabel";
            NamaLabel.Size = new Size(39, 38);
            NamaLabel.TabIndex = 0;
            NamaLabel.Text = "Nama";
            NamaLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NamaBox
            // 
            NamaBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NamaBox.Location = new Point(108, 7);
            NamaBox.Margin = new Padding(0);
            NamaBox.Name = "NamaBox";
            NamaBox.Size = new Size(178, 23);
            NamaBox.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel3.Controls.Add(Delete, 2, 0);
            tableLayoutPanel3.Controls.Add(Update, 1, 0);
            tableLayoutPanel3.Controls.Add(InsertButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(295, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(472, 114);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // Delete
            // 
            Delete.Dock = DockStyle.Fill;
            Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(332, 10);
            Delete.Margin = new Padding(10);
            Delete.Name = "Delete";
            Delete.Size = new Size(130, 94);
            Delete.TabIndex = 2;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.Dock = DockStyle.Fill;
            Update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.Location = new Point(171, 10);
            Update.Margin = new Padding(10);
            Update.Name = "Update";
            Update.Size = new Size(141, 94);
            Update.TabIndex = 1;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // InsertButton
            // 
            InsertButton.Dock = DockStyle.Fill;
            InsertButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InsertButton.Location = new Point(10, 10);
            InsertButton.Margin = new Padding(10);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(141, 94);
            InsertButton.TabIndex = 0;
            InsertButton.Text = "Insert";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(15, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 140);
            panel2.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(770, 140);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(15, 375);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 63);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel4);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(629, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 63);
            panel4.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(LoadButton, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(141, 63);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // LoadButton
            // 
            LoadButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoadButton.Dock = DockStyle.Fill;
            LoadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadButton.Location = new Point(10, 15);
            LoadButton.Margin = new Padding(10, 15, 10, 15);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(121, 33);
            LoadButton.TabIndex = 0;
            LoadButton.Text = "Load Data";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form";
            Padding = new Padding(15);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Users: C# x PostGres";
            Load += Form_Load;
            Header.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label DataUsers;
        private Panel Header;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel4;
        private Button InsertButton;
        private Label NamaLabel;
        private Button Delete;
        private Button Update;
        private Label NoHandphoneLabel;
        private Label AlamatLabel;
        private DataGridView dataGridView;
        private TableLayoutPanel tableLayoutPanel4;
        private Button LoadButton;
        private TextBox NamaBox;
        private TextBox HandphoneBox;
        private TextBox AlamatBox;
    }
}
