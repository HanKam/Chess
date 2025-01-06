namespace Chess
{
    partial class StartForm
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
            layoutStartPanel = new TableLayoutPanel();
            btnBack = new Button();
            btnSingleplayer = new Button();
            btnMultiplayer = new Button();
            label1 = new Label();
            layoutStartPanel.SuspendLayout();
            SuspendLayout();
            // 
            // layoutStartPanel
            // 
            layoutStartPanel.ColumnCount = 1;
            layoutStartPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutStartPanel.Controls.Add(btnBack, 0, 3);
            layoutStartPanel.Controls.Add(btnSingleplayer, 0, 1);
            layoutStartPanel.Controls.Add(btnMultiplayer, 0, 2);
            layoutStartPanel.Controls.Add(label1, 0, 0);
            layoutStartPanel.Dock = DockStyle.Fill;
            layoutStartPanel.Location = new Point(0, 0);
            layoutStartPanel.Name = "layoutStartPanel";
            layoutStartPanel.RowCount = 4;
            layoutStartPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0526314F));
            layoutStartPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            layoutStartPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            layoutStartPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            layoutStartPanel.Size = new Size(800, 450);
            layoutStartPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.Khaki;
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(240, 340);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(320, 100);
            btnBack.TabIndex = 3;
            btnBack.Text = "Wstecz";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSingleplayer
            // 
            btnSingleplayer.Anchor = AnchorStyles.None;
            btnSingleplayer.BackColor = Color.DarkSeaGreen;
            btnSingleplayer.Font = new Font("Segoe UI", 15F);
            btnSingleplayer.Location = new Point(240, 103);
            btnSingleplayer.Name = "btnSingleplayer";
            btnSingleplayer.Size = new Size(320, 100);
            btnSingleplayer.TabIndex = 0;
            btnSingleplayer.Text = "Gra jednoosobowa";
            btnSingleplayer.UseVisualStyleBackColor = false;
            btnSingleplayer.Click += btnSingleplayer_Click;
            // 
            // btnMultiplayer
            // 
            btnMultiplayer.Anchor = AnchorStyles.None;
            btnMultiplayer.BackColor = Color.DarkSeaGreen;
            btnMultiplayer.Font = new Font("Segoe UI", 15F);
            btnMultiplayer.Location = new Point(240, 221);
            btnMultiplayer.Name = "btnMultiplayer";
            btnMultiplayer.Size = new Size(320, 100);
            btnMultiplayer.TabIndex = 1;
            btnMultiplayer.Text = "Gra wieloosobowa";
            btnMultiplayer.UseVisualStyleBackColor = false;
            btnMultiplayer.Click += btnMultiplayer_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(168, 13);
            label1.Name = "label1";
            label1.Size = new Size(463, 67);
            label1.TabIndex = 2;
            label1.Text = "Wybierz rodzaj gry";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(layoutStartPanel);
            Name = "StartForm";
            Text = "StartForm";
            Load += StartForm_Load;
            layoutStartPanel.ResumeLayout(false);
            layoutStartPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutStartPanel;
        private Button btnSingleplayer;
        private Button btnMultiplayer;
        private Label label1;
        private Button btnBack;
    }
}