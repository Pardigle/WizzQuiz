namespace WizzQuiz
{
    partial class WizzQuizForm
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
            btnAddQuiz = new Button();
            btnViewAttempts = new Button();
            lbxQuizList = new ListBox();
            pnlLibrary = new Panel();
            btnDeleteQuiz = new Button();
            btnEditQuiz = new Button();
            btnAnswerQuiz = new Button();
            lblLibrary = new Label();
            pnlLibrary.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddQuiz
            // 
            btnAddQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddQuiz.Font = new Font("Segoe UI", 10F);
            btnAddQuiz.Location = new Point(685, 38);
            btnAddQuiz.Name = "btnAddQuiz";
            btnAddQuiz.Size = new Size(40, 38);
            btnAddQuiz.TabIndex = 0;
            btnAddQuiz.Text = "+";
            btnAddQuiz.UseVisualStyleBackColor = true;
            btnAddQuiz.Click += btnAddQuiz_Click;
            // 
            // btnViewAttempts
            // 
            btnViewAttempts.Font = new Font("Segoe UI", 9F);
            btnViewAttempts.Location = new Point(501, 38);
            btnViewAttempts.Name = "btnViewAttempts";
            btnViewAttempts.Size = new Size(178, 38);
            btnViewAttempts.TabIndex = 1;
            btnViewAttempts.Text = "View Attempts";
            btnViewAttempts.UseVisualStyleBackColor = true;
            btnViewAttempts.Click += btnViewAttempts_Click;
            // 
            // lbxQuizList
            // 
            lbxQuizList.Font = new Font("Segoe UI", 9F);
            lbxQuizList.FormattingEnabled = true;
            lbxQuizList.Location = new Point(25, 81);
            lbxQuizList.Name = "lbxQuizList";
            lbxQuizList.ScrollAlwaysVisible = true;
            lbxQuizList.Size = new Size(700, 264);
            lbxQuizList.TabIndex = 2;
            lbxQuizList.SelectedIndexChanged += lbxQuizList_SelectedIndexChanged;
            // 
            // pnlLibrary
            // 
            pnlLibrary.Controls.Add(btnAddQuiz);
            pnlLibrary.Controls.Add(btnDeleteQuiz);
            pnlLibrary.Controls.Add(btnEditQuiz);
            pnlLibrary.Controls.Add(btnAnswerQuiz);
            pnlLibrary.Controls.Add(lblLibrary);
            pnlLibrary.Controls.Add(lbxQuizList);
            pnlLibrary.Controls.Add(btnViewAttempts);
            pnlLibrary.Location = new Point(24, 6);
            pnlLibrary.Name = "pnlLibrary";
            pnlLibrary.Size = new Size(734, 417);
            pnlLibrary.TabIndex = 3;
            pnlLibrary.Paint += pnlLibrary_Paint;
            // 
            // btnDeleteQuiz
            // 
            btnDeleteQuiz.Location = new Point(25, 351);
            btnDeleteQuiz.Name = "btnDeleteQuiz";
            btnDeleteQuiz.Size = new Size(186, 39);
            btnDeleteQuiz.TabIndex = 6;
            btnDeleteQuiz.Text = "Delete";
            btnDeleteQuiz.UseVisualStyleBackColor = true;
            btnDeleteQuiz.Click += btnDeleteQuiz_Click;
            // 
            // btnEditQuiz
            // 
            btnEditQuiz.Location = new Point(217, 351);
            btnEditQuiz.Name = "btnEditQuiz";
            btnEditQuiz.Size = new Size(180, 39);
            btnEditQuiz.TabIndex = 5;
            btnEditQuiz.Text = "Edit";
            btnEditQuiz.UseVisualStyleBackColor = true;
            btnEditQuiz.Click += btnEditQuiz_Click;
            // 
            // btnAnswerQuiz
            // 
            btnAnswerQuiz.Location = new Point(403, 351);
            btnAnswerQuiz.Name = "btnAnswerQuiz";
            btnAnswerQuiz.Size = new Size(322, 39);
            btnAnswerQuiz.TabIndex = 4;
            btnAnswerQuiz.Text = "Answer Quiz";
            btnAnswerQuiz.UseVisualStyleBackColor = true;
            btnAnswerQuiz.Click += btnAnswerQuiz_Click;
            // 
            // lblLibrary
            // 
            lblLibrary.AutoSize = true;
            lblLibrary.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibrary.Location = new Point(9, 28);
            lblLibrary.Name = "lblLibrary";
            lblLibrary.Size = new Size(199, 46);
            lblLibrary.TabIndex = 3;
            lblLibrary.Text = "Your library";
            lblLibrary.Click += lblLibrary_Click;
            // 
            // WizzQuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 450);
            Controls.Add(pnlLibrary);
            Name = "WizzQuizForm";
            Text = "WizzQuiz";
            Load += WizzQuizForm_Load;
            pnlLibrary.ResumeLayout(false);
            pnlLibrary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddQuiz;
        private Button btnViewAttempts;
        private ListBox lbxQuizList;
        private Panel pnlLibrary;
        private Button btnAnswerQuiz;
        private Label lblLibrary;
        private Button btnDeleteQuiz;
        private Button btnEditQuiz;
    }
}
