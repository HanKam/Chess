namespace Chess
{
    partial class HostForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxRoomName = new TextBox();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            radioBtnRandom = new RadioButton();
            radioBtnBlack = new RadioButton();
            label3 = new Label();
            radioBtnWhite = new RadioButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnBack = new Button();
            btnCreateRoom = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(237, 13);
            label1.Name = "label1";
            label1.Size = new Size(326, 67);
            label1.TabIndex = 0;
            label1.Text = "Utwórz pokój";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(textBoxRoomName, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 97);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 112);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // textBoxRoomName
            // 
            textBoxRoomName.Anchor = AnchorStyles.None;
            textBoxRoomName.Font = new Font("Segoe UI", 20F);
            textBoxRoomName.Location = new Point(253, 34);
            textBoxRoomName.Name = "textBoxRoomName";
            textBoxRoomName.Size = new Size(538, 43);
            textBoxRoomName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(25, 37);
            label2.Name = "label2";
            label2.Size = new Size(199, 38);
            label2.TabIndex = 2;
            label2.Text = "Nazwa pokoju:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(radioBtnRandom, 3, 0);
            tableLayoutPanel3.Controls.Add(radioBtnBlack, 2, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(radioBtnWhite, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 215);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(794, 112);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // radioBtnRandom
            // 
            radioBtnRandom.Anchor = AnchorStyles.None;
            radioBtnRandom.AutoSize = true;
            radioBtnRandom.Checked = true;
            radioBtnRandom.Font = new Font("Segoe UI", 20F);
            radioBtnRandom.Location = new Point(632, 35);
            radioBtnRandom.Name = "radioBtnRandom";
            radioBtnRandom.Size = new Size(124, 42);
            radioBtnRandom.TabIndex = 6;
            radioBtnRandom.TabStop = true;
            radioBtnRandom.Text = "Losowo";
            radioBtnRandom.UseVisualStyleBackColor = true;
            // 
            // radioBtnBlack
            // 
            radioBtnBlack.Anchor = AnchorStyles.None;
            radioBtnBlack.AutoSize = true;
            radioBtnBlack.Font = new Font("Segoe UI", 20F);
            radioBtnBlack.Location = new Point(434, 35);
            radioBtnBlack.Name = "radioBtnBlack";
            radioBtnBlack.Size = new Size(121, 42);
            radioBtnBlack.TabIndex = 5;
            radioBtnBlack.Text = "Czarny";
            radioBtnBlack.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(54, 37);
            label3.Name = "label3";
            label3.Size = new Size(90, 38);
            label3.TabIndex = 3;
            label3.Text = "Kolor:";
            // 
            // radioBtnWhite
            // 
            radioBtnWhite.Anchor = AnchorStyles.None;
            radioBtnWhite.AutoSize = true;
            radioBtnWhite.Font = new Font("Segoe UI", 20F);
            radioBtnWhite.Location = new Point(250, 35);
            radioBtnWhite.Name = "radioBtnWhite";
            radioBtnWhite.Size = new Size(93, 42);
            radioBtnWhite.TabIndex = 4;
            radioBtnWhite.TabStop = true;
            radioBtnWhite.Text = "Biały";
            radioBtnWhite.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnBack, 1, 0);
            tableLayoutPanel4.Controls.Add(btnCreateRoom, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 333);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(794, 114);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(435, 7);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(320, 100);
            btnBack.TabIndex = 1;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.Anchor = AnchorStyles.None;
            btnCreateRoom.Font = new Font("Segoe UI", 15F);
            btnCreateRoom.Location = new Point(38, 7);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(320, 100);
            btnCreateRoom.TabIndex = 0;
            btnCreateRoom.Text = "Utwórz";
            btnCreateRoom.UseVisualStyleBackColor = true;
            btnCreateRoom.Click += btnCreateRoom_Click;
            // 
            // HostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "HostForm";
            Text = "HostForm";
            Load += HostForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBoxRoomName;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton radioBtnRandom;
        private RadioButton radioBtnBlack;
        private Label label3;
        private RadioButton radioBtnWhite;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnCreateRoom;
        private Button btnBack;
    }
}