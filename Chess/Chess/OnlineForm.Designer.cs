namespace Chess
{
    partial class OnlineForm
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
            layoutMultiplayerPanel = new TableLayoutPanel();
            btnBack = new Button();
            btnMultiJoin = new Button();
            btnMultiHost = new Button();
            label1 = new Label();
            layoutMultiplayerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // layoutMultiplayerPanel
            // 
            layoutMultiplayerPanel.ColumnCount = 1;
            layoutMultiplayerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMultiplayerPanel.Controls.Add(btnBack, 0, 3);
            layoutMultiplayerPanel.Controls.Add(btnMultiJoin, 0, 2);
            layoutMultiplayerPanel.Controls.Add(btnMultiHost, 0, 1);
            layoutMultiplayerPanel.Controls.Add(label1, 0, 0);
            layoutMultiplayerPanel.Dock = DockStyle.Fill;
            layoutMultiplayerPanel.Location = new Point(0, 0);
            layoutMultiplayerPanel.Name = "layoutMultiplayerPanel";
            layoutMultiplayerPanel.RowCount = 4;
            layoutMultiplayerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0526314F));
            layoutMultiplayerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            layoutMultiplayerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            layoutMultiplayerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            layoutMultiplayerPanel.Size = new Size(784, 561);
            layoutMultiplayerPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.DarkKhaki;
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(232, 436);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(320, 100);
            btnBack.TabIndex = 3;
            btnBack.Text = "Wstecz";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnMultiJoin
            // 
            btnMultiJoin.Anchor = AnchorStyles.None;
            btnMultiJoin.BackColor = Color.DarkSeaGreen;
            btnMultiJoin.Font = new Font("Segoe UI", 15F);
            btnMultiJoin.Location = new Point(232, 288);
            btnMultiJoin.Name = "btnMultiJoin";
            btnMultiJoin.Size = new Size(320, 100);
            btnMultiJoin.TabIndex = 2;
            btnMultiJoin.Text = "Dołącz do pokoju";
            btnMultiJoin.UseVisualStyleBackColor = false;
            btnMultiJoin.Click += btnJoin_Click;
            // 
            // btnMultiHost
            // 
            btnMultiHost.Anchor = AnchorStyles.None;
            btnMultiHost.BackColor = Color.DarkSeaGreen;
            btnMultiHost.Font = new Font("Segoe UI", 15F);
            btnMultiHost.Location = new Point(232, 141);
            btnMultiHost.Name = "btnMultiHost";
            btnMultiHost.Size = new Size(320, 100);
            btnMultiHost.TabIndex = 1;
            btnMultiHost.Text = "Stwórz pokój";
            btnMultiHost.UseVisualStyleBackColor = false;
            btnMultiHost.Click += btnHost_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(216, 25);
            label1.Name = "label1";
            label1.Size = new Size(351, 67);
            label1.TabIndex = 0;
            label1.Text = "Wybierz opcje";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OnlineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 561);
            Controls.Add(layoutMultiplayerPanel);
            Name = "OnlineForm";
            Text = "MultiplayerForm";
            layoutMultiplayerPanel.ResumeLayout(false);
            layoutMultiplayerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutMultiplayerPanel;
        private Label label1;
        private Button btnBack;
        private Button btnMultiJoin;
        private Button btnMultiHost;
    }
}