namespace Chess
{
    partial class ChessBoardForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            timerPlLabel = new Label();
            whoMoveLabel = new Label();
            btnGiveUp = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            timerOpLabel = new Label();
            promotionPanel = new Panel();
            btnDraw = new Button();
            boardPanel = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            roomNameLabel = new Label();
            historyLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(784, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(boardPanel, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 420F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(494, 555);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel5.Controls.Add(timerPlLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(whoMoveLabel, 1, 0);
            tableLayoutPanel5.Controls.Add(btnGiveUp, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 490);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(488, 62);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // timerPlLabel
            // 
            timerPlLabel.AutoSize = true;
            timerPlLabel.BackColor = SystemColors.InactiveCaption;
            timerPlLabel.BorderStyle = BorderStyle.FixedSingle;
            timerPlLabel.Dock = DockStyle.Fill;
            timerPlLabel.Font = new Font("Segoe UI", 15F);
            timerPlLabel.Location = new Point(3, 0);
            timerPlLabel.Name = "timerPlLabel";
            timerPlLabel.Size = new Size(102, 62);
            timerPlLabel.TabIndex = 1;
            timerPlLabel.Text = "90:00";
            timerPlLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // whoMoveLabel
            // 
            whoMoveLabel.AutoSize = true;
            whoMoveLabel.Dock = DockStyle.Fill;
            whoMoveLabel.Font = new Font("Segoe UI", 13F);
            whoMoveLabel.Location = new Point(111, 0);
            whoMoveLabel.Name = "whoMoveLabel";
            whoMoveLabel.Size = new Size(264, 62);
            whoMoveLabel.TabIndex = 2;
            whoMoveLabel.Text = "Ty Ty!";
            whoMoveLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGiveUp
            // 
            btnGiveUp.BackColor = Color.RosyBrown;
            btnGiveUp.Dock = DockStyle.Fill;
            btnGiveUp.Font = new Font("Segoe UI", 10F);
            btnGiveUp.Location = new Point(381, 3);
            btnGiveUp.Name = "btnGiveUp";
            btnGiveUp.Size = new Size(104, 56);
            btnGiveUp.TabIndex = 3;
            btnGiveUp.Text = "Poddaję się";
            btnGiveUp.UseVisualStyleBackColor = false;
            btnGiveUp.Click += btnGiveUp_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel3.Controls.Add(timerOpLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(promotionPanel, 1, 0);
            tableLayoutPanel3.Controls.Add(btnDraw, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(488, 61);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // timerOpLabel
            // 
            timerOpLabel.AutoSize = true;
            timerOpLabel.BackColor = SystemColors.InactiveCaption;
            timerOpLabel.BorderStyle = BorderStyle.FixedSingle;
            timerOpLabel.Dock = DockStyle.Fill;
            timerOpLabel.Font = new Font("Segoe UI", 15F);
            timerOpLabel.Location = new Point(3, 0);
            timerOpLabel.Name = "timerOpLabel";
            timerOpLabel.Size = new Size(102, 61);
            timerOpLabel.TabIndex = 0;
            timerOpLabel.Text = "90:00";
            timerOpLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // promotionPanel
            // 
            promotionPanel.Dock = DockStyle.Fill;
            promotionPanel.Location = new Point(111, 3);
            promotionPanel.Name = "promotionPanel";
            promotionPanel.Size = new Size(264, 55);
            promotionPanel.TabIndex = 1;
            // 
            // btnDraw
            // 
            btnDraw.BackColor = Color.Khaki;
            btnDraw.Dock = DockStyle.Fill;
            btnDraw.Font = new Font("Segoe UI", 10F);
            btnDraw.Location = new Point(381, 3);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(104, 55);
            btnDraw.TabIndex = 2;
            btnDraw.Text = "Zaproponuj remis";
            btnDraw.UseVisualStyleBackColor = false;
            btnDraw.Click += btnDraw_Click;
            // 
            // boardPanel
            // 
            boardPanel.Anchor = AnchorStyles.None;
            boardPanel.BackColor = SystemColors.GradientActiveCaption;
            boardPanel.Location = new Point(47, 77);
            boardPanel.Name = "boardPanel";
            boardPanel.Size = new Size(400, 400);
            boardPanel.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(roomNameLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(historyLabel, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(503, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            tableLayoutPanel4.Size = new Size(278, 555);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.BorderStyle = BorderStyle.FixedSingle;
            roomNameLabel.Dock = DockStyle.Fill;
            roomNameLabel.Font = new Font("Segoe UI", 15F);
            roomNameLabel.Location = new Point(3, 0);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new Size(272, 66);
            roomNameLabel.TabIndex = 0;
            roomNameLabel.Text = "Przykładowa nazwa pokoju szachowego";
            roomNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // historyLabel
            // 
            historyLabel.AutoSize = true;
            historyLabel.BorderStyle = BorderStyle.FixedSingle;
            historyLabel.Dock = DockStyle.Fill;
            historyLabel.Font = new Font("Segoe UI", 10F);
            historyLabel.Location = new Point(3, 66);
            historyLabel.Name = "historyLabel";
            historyLabel.Size = new Size(272, 489);
            historyLabel.TabIndex = 1;
            historyLabel.Text = "ssssssssssss";
            // 
            // ChessBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "ChessBoardForm";
            Text = "Chess Board";
            Load += ChessBoardForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label roomNameLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label timerPlLabel;
        private Label timerOpLabel;
        private Panel boardPanel;
        private Panel promotionPanel;
        private Label historyLabel;
        private Label whoMoveLabel;
        private Button btnGiveUp;
        private Button btnDraw;
    }
}
