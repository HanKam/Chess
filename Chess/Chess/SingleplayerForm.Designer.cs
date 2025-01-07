namespace Chess
{
    partial class SingleplayerForm
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
            tableLayoutPanel8 = new TableLayoutPanel();
            btnBack = new Button();
            btnCreate = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            label10 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            numericUpDown3 = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            minTimerMoves = new NumericUpDown();
            label1 = new Label();
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
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minTimerMoves).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secTimerAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minTimerAdd).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secTimerMoves).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.034483F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.4827576F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.4827576F));
            tableLayoutPanel1.Size = new Size(784, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(btnBack, 1, 0);
            tableLayoutPanel8.Controls.Add(btnCreate, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 370);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(778, 188);
            tableLayoutPanel8.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.Khaki;
            btnBack.Font = new Font("Segoe UI", 15F);
            btnBack.Location = new Point(423, 44);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(320, 100);
            btnBack.TabIndex = 1;
            btnBack.Text = "Wróć";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.None;
            btnCreate.BackColor = Color.DarkSeaGreen;
            btnCreate.Font = new Font("Segoe UI", 15F);
            btnCreate.Location = new Point(34, 44);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(320, 100);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Utwórz";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 3, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(label10, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 177);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(778, 187);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(numericUpDown1, 0, 1);
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 1, 1);
            tableLayoutPanel3.Controls.Add(numericUpDown2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(585, 6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(187, 175);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Font = new Font("Segoe UI", 11F);
            numericUpDown1.Location = new Point(14, 117);
            numericUpDown1.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(152, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 87);
            label2.TabIndex = 0;
            label2.Text = "min";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(152, 87);
            label3.Name = "label3";
            label3.Size = new Size(32, 88);
            label3.TabIndex = 1;
            label3.Text = "sec";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.None;
            numericUpDown2.Font = new Font("Segoe UI", 11F);
            numericUpDown2.Location = new Point(14, 30);
            numericUpDown2.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 27);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(32, 55);
            label7.Name = "label7";
            label7.Size = new Size(132, 76);
            label7.TabIndex = 4;
            label7.Text = "Czas \r\nna ruchy:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(411, 55);
            label10.Name = "label10";
            label10.Size = new Size(146, 76);
            label10.TabIndex = 5;
            label10.Text = "Czas dodawany:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(numericUpDown3, 0, 1);
            tableLayoutPanel4.Controls.Add(label11, 1, 0);
            tableLayoutPanel4.Controls.Add(label12, 1, 1);
            tableLayoutPanel4.Controls.Add(minTimerMoves, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(199, 6);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(184, 175);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.None;
            numericUpDown3.Font = new Font("Segoe UI", 11F);
            numericUpDown3.Location = new Point(13, 117);
            numericUpDown3.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 27);
            numericUpDown3.TabIndex = 3;
            numericUpDown3.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(150, 0);
            label11.Name = "label11";
            label11.Size = new Size(31, 87);
            label11.TabIndex = 0;
            label11.Text = "min";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(150, 87);
            label12.Name = "label12";
            label12.Size = new Size(31, 88);
            label12.TabIndex = 1;
            label12.Text = "sec";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minTimerMoves
            // 
            minTimerMoves.Anchor = AnchorStyles.None;
            minTimerMoves.Font = new Font("Segoe UI", 11F);
            minTimerMoves.Location = new Point(13, 30);
            minTimerMoves.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            minTimerMoves.Name = "minTimerMoves";
            minTimerMoves.Size = new Size(120, 27);
            minTimerMoves.TabIndex = 2;
            minTimerMoves.TextAlign = HorizontalAlignment.Center;
            minTimerMoves.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(778, 174);
            label1.TabIndex = 0;
            label1.Text = "Utwórz grę";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 3, 0);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(label5, 2, 0);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
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
            tableLayoutPanel7.Location = new Point(153, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(44, 412);
            tableLayoutPanel7.TabIndex = 7;
            // 
            // secTimerAdd
            // 
            secTimerAdd.Anchor = AnchorStyles.None;
            secTimerAdd.Font = new Font("Segoe UI", 11F);
            secTimerAdd.Location = new Point(3, 295);
            secTimerAdd.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secTimerAdd.Name = "secTimerAdd";
            secTimerAdd.Size = new Size(29, 27);
            secTimerAdd.TabIndex = 3;
            secTimerAdd.TextAlign = HorizontalAlignment.Center;
            secTimerAdd.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(38, 0);
            label8.Name = "label8";
            label8.Size = new Size(3, 206);
            label8.TabIndex = 0;
            label8.Text = "min";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(38, 206);
            label9.Name = "label9";
            label9.Size = new Size(3, 206);
            label9.TabIndex = 1;
            label9.Text = "sec";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minTimerAdd
            // 
            minTimerAdd.Anchor = AnchorStyles.None;
            minTimerAdd.Font = new Font("Segoe UI", 11F);
            minTimerAdd.Location = new Point(3, 89);
            minTimerAdd.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            minTimerAdd.Name = "minTimerAdd";
            minTimerAdd.Size = new Size(29, 27);
            minTimerAdd.TabIndex = 2;
            minTimerAdd.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(3, 38);
            label4.Name = "label4";
            label4.Size = new Size(44, 342);
            label4.TabIndex = 4;
            label4.Text = "Czas na ruchy:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(103, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 418);
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
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // secTimerMoves
            // 
            secTimerMoves.Anchor = AnchorStyles.None;
            secTimerMoves.Font = new Font("Segoe UI", 11F);
            secTimerMoves.Location = new Point(46, 36);
            secTimerMoves.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secTimerMoves.Name = "secTimerMoves";
            secTimerMoves.Size = new Size(67, 27);
            secTimerMoves.TabIndex = 3;
            secTimerMoves.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(163, 0);
            label6.Name = "label6";
            label6.Size = new Size(34, 19);
            label6.TabIndex = 0;
            label6.Text = "min";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SingleplayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "SingleplayerForm";
            Text = "SingleplayerForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)minTimerMoves).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)secTimerAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)minTimerAdd).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)secTimerMoves).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel4;
        private NumericUpDown numericUpDown3;
        private Label label11;
        private Label label12;
        private NumericUpDown minTimerMoves;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel7;
        private NumericUpDown secTimerAdd;
        private Label label8;
        private Label label9;
        private NumericUpDown minTimerAdd;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel6;
        private NumericUpDown secTimerMoves;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel8;
        private Button btnBack;
        private Button btnCreate;
    }
}