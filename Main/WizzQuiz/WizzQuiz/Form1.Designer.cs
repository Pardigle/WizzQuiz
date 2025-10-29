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
            pnlCreate = new Panel();
            panel2 = new Panel();
            btnSave = new Button();
            btnAddMultipleChoice = new Button();
            btnAddIdentification = new Button();
            label1 = new Label();
            btnBackToLibrary1 = new Button();
            pnlLibrary.SuspendLayout();
            pnlCreate.SuspendLayout();
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
            pnlLibrary.Location = new Point(16, 15);
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
            // pnlCreate
            // 
            pnlCreate.Controls.Add(panel2);
            pnlCreate.Controls.Add(btnSave);
            pnlCreate.Controls.Add(btnAddMultipleChoice);
            pnlCreate.Controls.Add(btnAddIdentification);
            pnlCreate.Controls.Add(label1);
            pnlCreate.Controls.Add(btnBackToLibrary1);
            pnlCreate.Location = new Point(16, 15);
            pnlCreate.Name = "pnlCreate";
            pnlCreate.Size = new Size(734, 417);
            pnlCreate.TabIndex = 4;
            pnlCreate.Paint += pnlCreate_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(34, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 263);
            panel2.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(562, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(162, 39);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddMultipleChoice
            // 
            btnAddMultipleChoice.Location = new Point(297, 351);
            btnAddMultipleChoice.Name = "btnAddMultipleChoice";
            btnAddMultipleChoice.Size = new Size(259, 39);
            btnAddMultipleChoice.TabIndex = 5;
            btnAddMultipleChoice.Text = "Add Multiple Choice";
            btnAddMultipleChoice.UseVisualStyleBackColor = true;
            btnAddMultipleChoice.Click += btnAddMultipleChoice_Click;
            // 
            // btnAddIdentification
            // 
            btnAddIdentification.Location = new Point(34, 351);
            btnAddIdentification.Name = "btnAddIdentification";
            btnAddIdentification.Size = new Size(257, 39);
            btnAddIdentification.TabIndex = 5;
            btnAddIdentification.Text = "Add Identification";
            btnAddIdentification.UseVisualStyleBackColor = true;
            btnAddIdentification.Click += btnAddIdentification_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(200, 46);
            label1.TabIndex = 7;
            label1.Text = "Create Quiz";
            label1.Click += label1_Click;
            // 
            // btnBackToLibrary1
            // 
            btnBackToLibrary1.Location = new Point(566, 38);
            btnBackToLibrary1.Name = "btnBackToLibrary1";
            btnBackToLibrary1.Size = new Size(158, 38);
            btnBackToLibrary1.TabIndex = 4;
            btnBackToLibrary1.Text = "Back to Library";
            btnBackToLibrary1.UseVisualStyleBackColor = true;
            btnBackToLibrary1.Click += btnBackToLibrary1_Click;
            // 
            // WizzQuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 444);
            Controls.Add(pnlCreate);
            Controls.Add(pnlLibrary);
            ForeColor = SystemColors.ControlText;
            Name = "WizzQuizForm";
            Text = "WizzQuiz";
            Load += WizzQuizForm_Load;
            pnlLibrary.ResumeLayout(false);
            pnlLibrary.PerformLayout();
            pnlCreate.ResumeLayout(false);
            pnlCreate.PerformLayout();
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
        private Panel pnlCreate;
        private Label label1;
        private Button btnBackToLibrary1;
        private Button btnAddMultipleChoice;
        private Button btnAddIdentification;
        private Button btnSave;
        private Panel panel2;
    }
}
