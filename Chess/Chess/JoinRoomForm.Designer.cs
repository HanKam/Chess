namespace Chess
{
    partial class JoinRoomForm
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
            btnRefresh = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnBack = new Button();
            roomList = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.None;
            btnRefresh.BackColor = Color.DarkSeaGreen;
            btnRefresh.Font = new Font("Segoe UI", 15F);
            btnRefresh.Location = new Point(112, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(158, 41);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Odśwież";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(30, 54);
            label1.Name = "label1";
            label1.Size = new Size(723, 60);
            label1.TabIndex = 2;
            label1.Text = "Wyszukiwanie dostępnych pokojów";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(roomList, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7777777F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.22222F));
            tableLayoutPanel1.Size = new Size(784, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.24433F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.75567F));
            tableLayoutPanel2.Controls.Add(btnRefresh, 0, 0);
            tableLayoutPanel2.Controls.Add(btnBack, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 177);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(778, 47);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.Khaki;
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(501, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(158, 41);
            btnBack.TabIndex = 2;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // roomList
            // 
            roomList.BackColor = SystemColors.GradientActiveCaption;
            roomList.Dock = DockStyle.Fill;
            roomList.Font = new Font("Segoe UI", 15F);
            roomList.FormattingEnabled = true;
            roomList.ItemHeight = 28;
            roomList.Location = new Point(3, 237);
            roomList.Name = "roomList";
            roomList.Size = new Size(778, 321);
            roomList.TabIndex = 0;
            roomList.DoubleClick += roomList_DubleClick;
            // 
            // JoinRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "JoinRoomForm";
            Text = "JoinRoomForm";
            Load += JoinRoomForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnBack;
        private ListBox roomList;
    }
}