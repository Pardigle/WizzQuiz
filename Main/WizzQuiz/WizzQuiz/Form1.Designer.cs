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
            pnlCreateQuestions = new FlowLayoutPanel();
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
            btnAddQuiz.Location = new Point(1113, 61);
            btnAddQuiz.Margin = new Padding(5);
            btnAddQuiz.Name = "btnAddQuiz";
            btnAddQuiz.Size = new Size(65, 61);
            btnAddQuiz.TabIndex = 0;
            btnAddQuiz.Text = "+";
            btnAddQuiz.UseVisualStyleBackColor = true;
            btnAddQuiz.Click += btnAddQuiz_Click;
            // 
            // btnViewAttempts
            // 
            btnViewAttempts.Font = new Font("Segoe UI", 9F);
            btnViewAttempts.Location = new Point(814, 61);
            btnViewAttempts.Margin = new Padding(5);
            btnViewAttempts.Name = "btnViewAttempts";
            btnViewAttempts.Size = new Size(289, 61);
            btnViewAttempts.TabIndex = 1;
            btnViewAttempts.Text = "View Attempts";
            btnViewAttempts.UseVisualStyleBackColor = true;
            btnViewAttempts.Click += btnViewAttempts_Click;
            // 
            // lbxQuizList
            // 
            lbxQuizList.Font = new Font("Segoe UI", 9F);
            lbxQuizList.FormattingEnabled = true;
            lbxQuizList.Location = new Point(41, 130);
            lbxQuizList.Margin = new Padding(5);
            lbxQuizList.Name = "lbxQuizList";
            lbxQuizList.ScrollAlwaysVisible = true;
            lbxQuizList.Size = new Size(1135, 420);
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
            pnlLibrary.Location = new Point(26, 24);
            pnlLibrary.Margin = new Padding(5);
            pnlLibrary.Name = "pnlLibrary";
            pnlLibrary.Size = new Size(1193, 667);
            pnlLibrary.TabIndex = 3;
            pnlLibrary.Paint += pnlLibrary_Paint;
            // 
            // btnDeleteQuiz
            // 
            btnDeleteQuiz.Location = new Point(41, 562);
            btnDeleteQuiz.Margin = new Padding(5);
            btnDeleteQuiz.Name = "btnDeleteQuiz";
            btnDeleteQuiz.Size = new Size(302, 62);
            btnDeleteQuiz.TabIndex = 6;
            btnDeleteQuiz.Text = "Delete";
            btnDeleteQuiz.UseVisualStyleBackColor = true;
            btnDeleteQuiz.Click += btnDeleteQuiz_Click;
            // 
            // btnEditQuiz
            // 
            btnEditQuiz.Location = new Point(353, 562);
            btnEditQuiz.Margin = new Padding(5);
            btnEditQuiz.Name = "btnEditQuiz";
            btnEditQuiz.Size = new Size(292, 62);
            btnEditQuiz.TabIndex = 5;
            btnEditQuiz.Text = "Edit";
            btnEditQuiz.UseVisualStyleBackColor = true;
            btnEditQuiz.Click += btnEditQuiz_Click;
            // 
            // btnAnswerQuiz
            // 
            btnAnswerQuiz.Location = new Point(655, 562);
            btnAnswerQuiz.Margin = new Padding(5);
            btnAnswerQuiz.Name = "btnAnswerQuiz";
            btnAnswerQuiz.Size = new Size(523, 62);
            btnAnswerQuiz.TabIndex = 4;
            btnAnswerQuiz.Text = "Answer Quiz";
            btnAnswerQuiz.UseVisualStyleBackColor = true;
            btnAnswerQuiz.Click += btnAnswerQuiz_Click;
            // 
            // lblLibrary
            // 
            lblLibrary.AutoSize = true;
            lblLibrary.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibrary.Location = new Point(15, 45);
            lblLibrary.Margin = new Padding(5, 0, 5, 0);
            lblLibrary.Name = "lblLibrary";
            lblLibrary.Size = new Size(311, 71);
            lblLibrary.TabIndex = 3;
            lblLibrary.Text = "Your library";
            lblLibrary.Click += lblLibrary_Click;
            // 
            // pnlCreate
            // 
            pnlCreate.Controls.Add(pnlCreateQuestions);
            pnlCreate.Controls.Add(btnSave);
            pnlCreate.Controls.Add(btnAddMultipleChoice);
            pnlCreate.Controls.Add(btnAddIdentification);
            pnlCreate.Controls.Add(label1);
            pnlCreate.Controls.Add(btnBackToLibrary1);
            pnlCreate.Location = new Point(26, 24);
            pnlCreate.Margin = new Padding(5);
            pnlCreate.Name = "pnlCreate";
            pnlCreate.Size = new Size(1193, 667);
            pnlCreate.TabIndex = 4;
            pnlCreate.Paint += pnlCreate_Paint;
            // 
            // pnlCreateQuestions
            // 
            pnlCreateQuestions.AutoScroll = true;
            pnlCreateQuestions.BackColor = SystemColors.Control;
            pnlCreateQuestions.FlowDirection = FlowDirection.TopDown;
            pnlCreateQuestions.Location = new Point(55, 131);
            pnlCreateQuestions.Name = "pnlCreateQuestions";
            pnlCreateQuestions.Size = new Size(1121, 421);
            pnlCreateQuestions.TabIndex = 8;
            pnlCreateQuestions.WrapContents = false;
            pnlCreateQuestions.Paint += pnlCreateQuestions_Paint;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(913, 562);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(263, 62);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddMultipleChoice
            // 
            btnAddMultipleChoice.Location = new Point(483, 562);
            btnAddMultipleChoice.Margin = new Padding(5);
            btnAddMultipleChoice.Name = "btnAddMultipleChoice";
            btnAddMultipleChoice.Size = new Size(421, 62);
            btnAddMultipleChoice.TabIndex = 5;
            btnAddMultipleChoice.Text = "Add Multiple Choice Item";
            btnAddMultipleChoice.UseVisualStyleBackColor = true;
            btnAddMultipleChoice.Click += btnAddMultipleChoice_Click;
            // 
            // btnAddIdentification
            // 
            btnAddIdentification.Location = new Point(55, 562);
            btnAddIdentification.Margin = new Padding(5);
            btnAddIdentification.Name = "btnAddIdentification";
            btnAddIdentification.Size = new Size(418, 62);
            btnAddIdentification.TabIndex = 5;
            btnAddIdentification.Text = "Add Identification Item";
            btnAddIdentification.UseVisualStyleBackColor = true;
            btnAddIdentification.Click += btnAddIdentification_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(311, 71);
            label1.TabIndex = 7;
            label1.Text = "Create Quiz";
            label1.Click += label1_Click;
            // 
            // btnBackToLibrary1
            // 
            btnBackToLibrary1.Location = new Point(920, 61);
            btnBackToLibrary1.Margin = new Padding(5);
            btnBackToLibrary1.Name = "btnBackToLibrary1";
            btnBackToLibrary1.Size = new Size(257, 61);
            btnBackToLibrary1.TabIndex = 4;
            btnBackToLibrary1.Text = "Back to Library";
            btnBackToLibrary1.UseVisualStyleBackColor = true;
            btnBackToLibrary1.Click += btnBackToLibrary1_Click;
            // 
            // WizzQuizForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 710);
            Controls.Add(pnlCreate);
            Controls.Add(pnlLibrary);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5);
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
        private FlowLayoutPanel pnlCreateQuestions;
    }
}
