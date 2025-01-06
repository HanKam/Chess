namespace Chess
{
    partial class MainMenuForm
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
            btnStart = new Button();
            btnExit = new Button();
            labelName = new Label();
            btnOption = new Button();
            layoutMainMenu = new TableLayoutPanel();
            layoutMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.BackColor = Color.DarkSeaGreen;
            btnStart.Font = new Font("Segoe UI", 15F);
            btnStart.Location = new Point(240, 118);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(320, 100);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.RosyBrown;
            btnExit.Font = new Font("Segoe UI", 15F);
            btnExit.Location = new Point(240, 343);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(320, 100);
            btnExit.TabIndex = 2;
            btnExit.Text = "Wyjście";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.None;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 35F);
            labelName.Location = new Point(172, 22);
            labelName.Name = "labelName";
            labelName.Size = new Size(455, 67);
            labelName.TabIndex = 3;
            labelName.Text = "SZACHY PO SIECI";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOption
            // 
            btnOption.Anchor = AnchorStyles.None;
            btnOption.BackColor = Color.Khaki;
            btnOption.Font = new Font("Segoe UI", 15F);
            btnOption.Location = new Point(240, 230);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(320, 100);
            btnOption.TabIndex = 1;
            btnOption.Text = "Opcje";
            btnOption.UseVisualStyleBackColor = false;
            btnOption.Click += btnOption_Click;
            // 
            // layoutMainMenu
            // 
            layoutMainMenu.Anchor = AnchorStyles.None;
            layoutMainMenu.ColumnCount = 1;
            layoutMainMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMainMenu.Controls.Add(labelName, 0, 0);
            layoutMainMenu.Controls.Add(btnStart, 0, 1);
            layoutMainMenu.Controls.Add(btnOption, 0, 2);
            layoutMainMenu.Controls.Add(btnExit, 0, 3);
            layoutMainMenu.Location = new Point(0, 0);
            layoutMainMenu.Name = "layoutMainMenu";
            layoutMainMenu.RowCount = 4;
            layoutMainMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutMainMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutMainMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutMainMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            layoutMainMenu.Size = new Size(800, 450);
            layoutMainMenu.TabIndex = 4;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(layoutMainMenu);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            Load += MainMenuForm_Load;
            layoutMainMenu.ResumeLayout(false);
            layoutMainMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnExit;
        private Label labelName;
        private TableLayoutPanel layoutMainMenu;
        private Button btnOption;
    }
}