namespace Chess
{
    partial class OptionsForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            btnBack = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            muteCheckBox = new CheckBox();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            volumeBar = new TrackBar();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeBar).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBack, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714245F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7142868F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7142868F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(784, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(778, 160);
            label1.TabIndex = 0;
            label1.Text = "Opcje";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.DarkKhaki;
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(232, 410);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(320, 100);
            btnBack.TabIndex = 4;
            btnBack.Text = "Wstecz";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.5555573F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel2.Controls.Add(muteCheckBox, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 163);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(778, 194);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // muteCheckBox
            // 
            muteCheckBox.Anchor = AnchorStyles.None;
            muteCheckBox.AutoSize = true;
            muteCheckBox.BackgroundImageLayout = ImageLayout.None;
            muteCheckBox.Font = new Font("Segoe UI", 20F);
            muteCheckBox.Location = new Point(625, 76);
            muteCheckBox.Name = "muteCheckBox";
            muteCheckBox.Size = new Size(128, 42);
            muteCheckBox.TabIndex = 0;
            muteCheckBox.Text = "Wycisz";
            muteCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            muteCheckBox.UseVisualStyleBackColor = true;
            muteCheckBox.CheckedChanged += muteCheckBox_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(25, 59);
            label2.Name = "label2";
            label2.Size = new Size(126, 76);
            label2.TabIndex = 0;
            label2.Text = "Poziom głośności";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(volumeBar, 0, 0);
            tableLayoutPanel3.Location = new Point(228, 72);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(320, 50);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // volumeBar
            // 
            volumeBar.Anchor = AnchorStyles.None;
            volumeBar.BackColor = SystemColors.ActiveCaption;
            volumeBar.Location = new Point(6, 6);
            volumeBar.Maximum = 100;
            volumeBar.Name = "volumeBar";
            volumeBar.Size = new Size(308, 38);
            volumeBar.TabIndex = 1;
            volumeBar.TickStyle = TickStyle.Both;
            volumeBar.Value = 100;
            volumeBar.Scroll += volumeBar_Scroll;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "OptionsForm";
            Text = "OptionsForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumeBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button btnBack;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox muteCheckBox;
        private TrackBar volumeBar;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
    }
}