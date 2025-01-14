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
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            secTimerAdd = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            minTimerAdd = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            secTimerMoves = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            minTimerMoves = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secTimerAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minTimerAdd).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secTimerMoves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minTimerMoves).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tableLayoutPanel1.Size = new Size(784, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(229, 13);
            label1.Name = "label1";
            label1.Size = new Size(326, 67);
            label1.TabIndex = 0;
            label1.Text = "Utwórz pokój";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9032249F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.09677F));
            tableLayoutPanel2.Controls.Add(textBoxRoomName, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 96);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(778, 110);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // textBoxRoomName
            // 
            textBoxRoomName.Anchor = AnchorStyles.None;
            textBoxRoomName.BackColor = SystemColors.GradientInactiveCaption;
            textBoxRoomName.Font = new Font("Segoe UI", 20F);
            textBoxRoomName.Location = new Point(229, 33);
            textBoxRoomName.Name = "textBoxRoomName";
            textBoxRoomName.Size = new Size(513, 43);
            textBoxRoomName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(44, 17);
            label2.Name = "label2";
            label2.Size = new Size(109, 76);
            label2.TabIndex = 2;
            label2.Text = "Nazwa pokoju:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
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
            tableLayoutPanel3.Location = new Point(3, 212);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(778, 110);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // radioBtnRandom
            // 
            radioBtnRandom.Anchor = AnchorStyles.None;
            radioBtnRandom.AutoSize = true;
            radioBtnRandom.Checked = true;
            radioBtnRandom.Font = new Font("Segoe UI", 20F);
            radioBtnRandom.Location = new Point(616, 34);
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
            radioBtnBlack.Location = new Point(423, 34);
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
            label3.Location = new Point(53, 36);
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
            radioBtnWhite.Location = new Point(244, 34);
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
            tableLayoutPanel4.Location = new Point(3, 444);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(778, 114);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.Khaki;
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(423, 7);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(320, 100);
            btnBack.TabIndex = 1;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.Anchor = AnchorStyles.None;
            btnCreateRoom.BackColor = Color.DarkSeaGreen;
            btnCreateRoom.Font = new Font("Segoe UI", 15F);
            btnCreateRoom.Location = new Point(34, 7);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(320, 100);
            btnCreateRoom.TabIndex = 0;
            btnCreateRoom.Text = "Utwórz";
            btnCreateRoom.UseVisualStyleBackColor = false;
            btnCreateRoom.Click += btnCreateRoom_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 3, 0);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(label5, 2, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 328);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(778, 110);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.Controls.Add(secTimerAdd, 0, 1);
            tableLayoutPanel7.Controls.Add(label8, 1, 0);
            tableLayoutPanel7.Controls.Add(label9, 1, 1);
            tableLayoutPanel7.Controls.Add(minTimerAdd, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(585, 6);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(187, 98);
            tableLayoutPanel7.TabIndex = 7;
            // 
            // secTimerAdd
            // 
            secTimerAdd.Anchor = AnchorStyles.None;
            secTimerAdd.Font = new Font("Segoe UI", 11F);
            secTimerAdd.Location = new Point(14, 60);
            secTimerAdd.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secTimerAdd.Name = "secTimerAdd";
            secTimerAdd.Size = new Size(120, 27);
            secTimerAdd.TabIndex = 3;
            secTimerAdd.TextAlign = HorizontalAlignment.Center;
            secTimerAdd.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(152, 0);
            label8.Name = "label8";
            label8.Size = new Size(32, 49);
            label8.TabIndex = 0;
            label8.Text = "min";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(152, 49);
            label9.Name = "label9";
            label9.Size = new Size(32, 49);
            label9.TabIndex = 1;
            label9.Text = "sec";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minTimerAdd
            // 
            minTimerAdd.Anchor = AnchorStyles.None;
            minTimerAdd.Font = new Font("Segoe UI", 11F);
            minTimerAdd.Location = new Point(14, 11);
            minTimerAdd.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            minTimerAdd.Name = "minTimerAdd";
            minTimerAdd.Size = new Size(120, 27);
            minTimerAdd.TabIndex = 2;
            minTimerAdd.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(32, 17);
            label4.Name = "label4";
            label4.Size = new Size(132, 76);
            label4.TabIndex = 4;
            label4.Text = "Czas \r\nna ruchy:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(411, 17);
            label5.Name = "label5";
            label5.Size = new Size(146, 76);
            label5.TabIndex = 5;
            label5.Text = "Czas dodawany:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.Controls.Add(secTimerMoves, 0, 1);
            tableLayoutPanel6.Controls.Add(label6, 1, 0);
            tableLayoutPanel6.Controls.Add(label7, 1, 1);
            tableLayoutPanel6.Controls.Add(minTimerMoves, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(199, 6);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(184, 98);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // secTimerMoves
            // 
            secTimerMoves.Anchor = AnchorStyles.None;
            secTimerMoves.Font = new Font("Segoe UI", 11F);
            secTimerMoves.Location = new Point(13, 60);
            secTimerMoves.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secTimerMoves.Name = "secTimerMoves";
            secTimerMoves.Size = new Size(120, 27);
            secTimerMoves.TabIndex = 3;
            secTimerMoves.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(150, 0);
            label6.Name = "label6";
            label6.Size = new Size(31, 49);
            label6.TabIndex = 0;
            label6.Text = "min";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(150, 49);
            label7.Name = "label7";
            label7.Size = new Size(31, 49);
            label7.TabIndex = 1;
            label7.Text = "sec";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minTimerMoves
            // 
            minTimerMoves.Anchor = AnchorStyles.None;
            minTimerMoves.Font = new Font("Segoe UI", 11F);
            minTimerMoves.Location = new Point(13, 11);
            minTimerMoves.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            minTimerMoves.Name = "minTimerMoves";
            minTimerMoves.Size = new Size(120, 27);
            minTimerMoves.TabIndex = 2;
            minTimerMoves.TextAlign = HorizontalAlignment.Center;
            minTimerMoves.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // HostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 561);
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
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)secTimerAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)minTimerAdd).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)secTimerMoves).EndInit();
            ((System.ComponentModel.ISupportInitialize)minTimerMoves).EndInit();
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
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label6;
        private Label label7;
        private NumericUpDown minTimerMoves;
        private NumericUpDown secTimerMoves;
        private TableLayoutPanel tableLayoutPanel7;
        private NumericUpDown secTimerAdd;
        private Label label8;
        private Label label9;
        private NumericUpDown minTimerAdd;
    }
}