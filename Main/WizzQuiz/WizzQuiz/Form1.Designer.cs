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
            pnlMultiple = new Panel();
            tbxMultipleOption4 = new TextBox();
            tbxMultipleOption3 = new TextBox();
            cbxMultipleOption4 = new CheckBox();
            cbxMultipleOption3 = new CheckBox();
            tbxMultipleOption2 = new TextBox();
            cbxMultipleOption2 = new CheckBox();
            tbxMultipleOption1 = new TextBox();
            cbxMultipleOption1 = new CheckBox();
            nudMultiplePoints = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            tbxMultipleQuestion = new TextBox();
            label8 = new Label();
            tbxMultipleNumber = new TextBox();
            label7 = new Label();
            pnlIdentification = new Panel();
            nudIdentificationPoints = new NumericUpDown();
            label6 = new Label();
            tbxIdentificationAnswer = new TextBox();
            label5 = new Label();
            tbxIdentificationQuestion = new TextBox();
            label4 = new Label();
            tbxIdentificationNumber = new TextBox();
            label3 = new Label();
            btnViewQuestion = new Button();
            btnDeleteQuestion = new Button();
            label2 = new Label();
            tbxQuizName = new TextBox();
            lbxQuestionList = new ListBox();
            btnSave = new Button();
            btnAddMultipleChoice = new Button();
            btnAddIdentification = new Button();
            label1 = new Label();
            btnBackToLibrary1 = new Button();
            pnlLibrary.SuspendLayout();
            pnlCreate.SuspendLayout();
            pnlMultiple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMultiplePoints).BeginInit();
            pnlIdentification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdentificationPoints).BeginInit();
            SuspendLayout();
            // 
            // btnAddQuiz
            // 
            btnAddQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddQuiz.Font = new Font("Segoe UI", 10F);
            btnAddQuiz.Location = new Point(1462, 58);
            btnAddQuiz.Margin = new Padding(5);
            btnAddQuiz.Name = "btnAddQuiz";
            btnAddQuiz.Size = new Size(63, 61);
            btnAddQuiz.TabIndex = 0;
            btnAddQuiz.Text = "+";
            btnAddQuiz.UseVisualStyleBackColor = true;
            btnAddQuiz.Click += btnAddQuiz_Click;
            // 
            // btnViewAttempts
            // 
            btnViewAttempts.Font = new Font("Segoe UI", 9F);
            btnViewAttempts.Location = new Point(1024, 58);
            btnViewAttempts.Margin = new Padding(5);
            btnViewAttempts.Name = "btnViewAttempts";
            btnViewAttempts.Size = new Size(429, 61);
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
            lbxQuizList.Size = new Size(1483, 580);
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
            pnlLibrary.Size = new Size(1540, 821);
            pnlLibrary.TabIndex = 3;
            pnlLibrary.Paint += pnlLibrary_Paint;
            // 
            // btnDeleteQuiz
            // 
            btnDeleteQuiz.Location = new Point(41, 720);
            btnDeleteQuiz.Margin = new Padding(5);
            btnDeleteQuiz.Name = "btnDeleteQuiz";
            btnDeleteQuiz.Size = new Size(317, 62);
            btnDeleteQuiz.TabIndex = 6;
            btnDeleteQuiz.Text = "Delete";
            btnDeleteQuiz.UseVisualStyleBackColor = true;
            btnDeleteQuiz.Click += btnDeleteQuiz_Click;
            // 
            // btnEditQuiz
            // 
            btnEditQuiz.Location = new Point(367, 720);
            btnEditQuiz.Margin = new Padding(5);
            btnEditQuiz.Name = "btnEditQuiz";
            btnEditQuiz.Size = new Size(322, 62);
            btnEditQuiz.TabIndex = 5;
            btnEditQuiz.Text = "Edit";
            btnEditQuiz.UseVisualStyleBackColor = true;
            btnEditQuiz.Click += btnEditQuiz_Click;
            // 
            // btnAnswerQuiz
            // 
            btnAnswerQuiz.Location = new Point(699, 720);
            btnAnswerQuiz.Margin = new Padding(5);
            btnAnswerQuiz.Name = "btnAnswerQuiz";
            btnAnswerQuiz.Size = new Size(827, 62);
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
            pnlCreate.Controls.Add(pnlMultiple);
            pnlCreate.Controls.Add(pnlIdentification);
            pnlCreate.Controls.Add(btnViewQuestion);
            pnlCreate.Controls.Add(btnDeleteQuestion);
            pnlCreate.Controls.Add(label2);
            pnlCreate.Controls.Add(tbxQuizName);
            pnlCreate.Controls.Add(lbxQuestionList);
            pnlCreate.Controls.Add(btnSave);
            pnlCreate.Controls.Add(btnAddMultipleChoice);
            pnlCreate.Controls.Add(btnAddIdentification);
            pnlCreate.Controls.Add(label1);
            pnlCreate.Controls.Add(btnBackToLibrary1);
            pnlCreate.Location = new Point(21, 24);
            pnlCreate.Margin = new Padding(5);
            pnlCreate.Name = "pnlCreate";
            pnlCreate.Size = new Size(1540, 821);
            pnlCreate.TabIndex = 4;
            pnlCreate.Visible = false;
            pnlCreate.Paint += pnlCreate_Paint;
            // 
            // pnlMultiple
            // 
            pnlMultiple.Controls.Add(tbxMultipleOption4);
            pnlMultiple.Controls.Add(tbxMultipleOption3);
            pnlMultiple.Controls.Add(cbxMultipleOption4);
            pnlMultiple.Controls.Add(cbxMultipleOption3);
            pnlMultiple.Controls.Add(tbxMultipleOption2);
            pnlMultiple.Controls.Add(cbxMultipleOption2);
            pnlMultiple.Controls.Add(tbxMultipleOption1);
            pnlMultiple.Controls.Add(cbxMultipleOption1);
            pnlMultiple.Controls.Add(nudMultiplePoints);
            pnlMultiple.Controls.Add(label10);
            pnlMultiple.Controls.Add(label9);
            pnlMultiple.Controls.Add(tbxMultipleQuestion);
            pnlMultiple.Controls.Add(label8);
            pnlMultiple.Controls.Add(tbxMultipleNumber);
            pnlMultiple.Controls.Add(label7);
            pnlMultiple.Location = new Point(55, 187);
            pnlMultiple.Margin = new Padding(5);
            pnlMultiple.Name = "pnlMultiple";
            pnlMultiple.Size = new Size(1050, 525);
            pnlMultiple.TabIndex = 6;
            pnlMultiple.Visible = false;
            pnlMultiple.Paint += pnlMultiple_Paint;
            // 
            // tbxMultipleOption4
            // 
            tbxMultipleOption4.Location = new Point(585, 438);
            tbxMultipleOption4.Margin = new Padding(5);
            tbxMultipleOption4.Name = "tbxMultipleOption4";
            tbxMultipleOption4.Size = new Size(410, 39);
            tbxMultipleOption4.TabIndex = 14;
            tbxMultipleOption4.TextChanged += tbxMultipleOption4_TextChanged;
            // 
            // tbxMultipleOption3
            // 
            tbxMultipleOption3.Location = new Point(585, 381);
            tbxMultipleOption3.Margin = new Padding(5);
            tbxMultipleOption3.Name = "tbxMultipleOption3";
            tbxMultipleOption3.Size = new Size(410, 39);
            tbxMultipleOption3.TabIndex = 7;
            tbxMultipleOption3.TextChanged += tbxMultipleOption3_TextChanged;
            // 
            // cbxMultipleOption4
            // 
            cbxMultipleOption4.AutoSize = true;
            cbxMultipleOption4.Location = new Point(546, 448);
            cbxMultipleOption4.Margin = new Padding(5);
            cbxMultipleOption4.Name = "cbxMultipleOption4";
            cbxMultipleOption4.Size = new Size(28, 27);
            cbxMultipleOption4.TabIndex = 7;
            cbxMultipleOption4.UseVisualStyleBackColor = true;
            cbxMultipleOption4.CheckedChanged += cbxMultipleOption4_CheckedChanged;
            // 
            // cbxMultipleOption3
            // 
            cbxMultipleOption3.AutoSize = true;
            cbxMultipleOption3.Location = new Point(546, 390);
            cbxMultipleOption3.Margin = new Padding(5);
            cbxMultipleOption3.Name = "cbxMultipleOption3";
            cbxMultipleOption3.Size = new Size(28, 27);
            cbxMultipleOption3.TabIndex = 13;
            cbxMultipleOption3.UseVisualStyleBackColor = true;
            cbxMultipleOption3.CheckedChanged += cbxMultipleOption3_CheckedChanged;
            // 
            // tbxMultipleOption2
            // 
            tbxMultipleOption2.Location = new Point(72, 438);
            tbxMultipleOption2.Margin = new Padding(5);
            tbxMultipleOption2.Name = "tbxMultipleOption2";
            tbxMultipleOption2.Size = new Size(418, 39);
            tbxMultipleOption2.TabIndex = 7;
            tbxMultipleOption2.TextChanged += tbxMultipleOption2_TextChanged;
            // 
            // cbxMultipleOption2
            // 
            cbxMultipleOption2.AutoSize = true;
            cbxMultipleOption2.Location = new Point(32, 448);
            cbxMultipleOption2.Margin = new Padding(5);
            cbxMultipleOption2.Name = "cbxMultipleOption2";
            cbxMultipleOption2.Size = new Size(28, 27);
            cbxMultipleOption2.TabIndex = 7;
            cbxMultipleOption2.UseVisualStyleBackColor = true;
            cbxMultipleOption2.CheckedChanged += cbxMultipleOption2_CheckedChanged;
            // 
            // tbxMultipleOption1
            // 
            tbxMultipleOption1.Location = new Point(72, 381);
            tbxMultipleOption1.Margin = new Padding(5);
            tbxMultipleOption1.Name = "tbxMultipleOption1";
            tbxMultipleOption1.Size = new Size(418, 39);
            tbxMultipleOption1.TabIndex = 7;
            tbxMultipleOption1.TextChanged += tbxMultipleOption1_TextChanged;
            // 
            // cbxMultipleOption1
            // 
            cbxMultipleOption1.AutoSize = true;
            cbxMultipleOption1.Location = new Point(32, 390);
            cbxMultipleOption1.Margin = new Padding(5);
            cbxMultipleOption1.Name = "cbxMultipleOption1";
            cbxMultipleOption1.Size = new Size(28, 27);
            cbxMultipleOption1.TabIndex = 7;
            cbxMultipleOption1.UseVisualStyleBackColor = true;
            cbxMultipleOption1.CheckedChanged += cbxMultipleOption1_CheckedChanged;
            // 
            // nudMultiplePoints
            // 
            nudMultiplePoints.Location = new Point(934, 35);
            nudMultiplePoints.Margin = new Padding(5);
            nudMultiplePoints.Name = "nudMultiplePoints";
            nudMultiplePoints.Size = new Size(84, 39);
            nudMultiplePoints.TabIndex = 12;
            nudMultiplePoints.ValueChanged += nudMultiplePoints_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(842, 38);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 32);
            label10.TabIndex = 11;
            label10.Text = "Points:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 336);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(96, 32);
            label9.TabIndex = 10;
            label9.Text = "Answer:";
            // 
            // tbxMultipleQuestion
            // 
            tbxMultipleQuestion.Location = new Point(32, 123);
            tbxMultipleQuestion.Margin = new Padding(5);
            tbxMultipleQuestion.Multiline = true;
            tbxMultipleQuestion.Name = "tbxMultipleQuestion";
            tbxMultipleQuestion.Size = new Size(984, 206);
            tbxMultipleQuestion.TabIndex = 9;
            tbxMultipleQuestion.TextChanged += tbxMultipleQuestion_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 86);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(116, 32);
            label8.TabIndex = 8;
            label8.Text = "Question:";
            // 
            // tbxMultipleNumber
            // 
            tbxMultipleNumber.Location = new Point(150, 27);
            tbxMultipleNumber.Margin = new Padding(5);
            tbxMultipleNumber.Name = "tbxMultipleNumber";
            tbxMultipleNumber.Size = new Size(50, 39);
            tbxMultipleNumber.TabIndex = 7;
            tbxMultipleNumber.TextChanged += tbxMultipleNumber_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 32);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(107, 32);
            label7.TabIndex = 0;
            label7.Text = "Number:";
            // 
            // pnlIdentification
            // 
            pnlIdentification.Controls.Add(nudIdentificationPoints);
            pnlIdentification.Controls.Add(label6);
            pnlIdentification.Controls.Add(tbxIdentificationAnswer);
            pnlIdentification.Controls.Add(label5);
            pnlIdentification.Controls.Add(tbxIdentificationQuestion);
            pnlIdentification.Controls.Add(label4);
            pnlIdentification.Controls.Add(tbxIdentificationNumber);
            pnlIdentification.Controls.Add(label3);
            pnlIdentification.Location = new Point(55, 189);
            pnlIdentification.Margin = new Padding(5);
            pnlIdentification.Name = "pnlIdentification";
            pnlIdentification.Size = new Size(1050, 525);
            pnlIdentification.TabIndex = 5;
            pnlIdentification.Visible = false;
            pnlIdentification.Paint += pnlIdentification_Paint;
            // 
            // nudIdentificationPoints
            // 
            nudIdentificationPoints.Location = new Point(934, 26);
            nudIdentificationPoints.Margin = new Padding(5);
            nudIdentificationPoints.Name = "nudIdentificationPoints";
            nudIdentificationPoints.Size = new Size(84, 39);
            nudIdentificationPoints.TabIndex = 6;
            nudIdentificationPoints.ValueChanged += nudIdentificationPoints_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(842, 30);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 32);
            label6.TabIndex = 6;
            label6.Text = "Points:";
            // 
            // tbxIdentificationAnswer
            // 
            tbxIdentificationAnswer.Location = new Point(32, 368);
            tbxIdentificationAnswer.Margin = new Padding(5);
            tbxIdentificationAnswer.Multiline = true;
            tbxIdentificationAnswer.Name = "tbxIdentificationAnswer";
            tbxIdentificationAnswer.Size = new Size(984, 129);
            tbxIdentificationAnswer.TabIndex = 5;
            tbxIdentificationAnswer.TextChanged += tbxIdentificationAnswer_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 331);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 32);
            label5.TabIndex = 4;
            label5.Text = "Answer:";
            // 
            // tbxIdentificationQuestion
            // 
            tbxIdentificationQuestion.Location = new Point(32, 118);
            tbxIdentificationQuestion.Margin = new Padding(5);
            tbxIdentificationQuestion.Multiline = true;
            tbxIdentificationQuestion.Name = "tbxIdentificationQuestion";
            tbxIdentificationQuestion.Size = new Size(984, 206);
            tbxIdentificationQuestion.TabIndex = 3;
            tbxIdentificationQuestion.TextChanged += tbxIdentificationQuestion_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 82);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 2;
            label4.Text = "Question:";
            // 
            // tbxIdentificationNumber
            // 
            tbxIdentificationNumber.Location = new Point(150, 26);
            tbxIdentificationNumber.Margin = new Padding(5);
            tbxIdentificationNumber.Name = "tbxIdentificationNumber";
            tbxIdentificationNumber.Size = new Size(50, 39);
            tbxIdentificationNumber.TabIndex = 1;
            tbxIdentificationNumber.TextChanged += tbxIdentificationNumber_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 32);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 0;
            label3.Text = "Number:";
            label3.Click += label3_Click;
            // 
            // btnViewQuestion
            // 
            btnViewQuestion.Location = new Point(1326, 664);
            btnViewQuestion.Margin = new Padding(5);
            btnViewQuestion.Name = "btnViewQuestion";
            btnViewQuestion.Size = new Size(188, 46);
            btnViewQuestion.TabIndex = 13;
            btnViewQuestion.Text = "View";
            btnViewQuestion.UseVisualStyleBackColor = true;
            btnViewQuestion.Click += btnViewQuestion_Click;
            // 
            // btnDeleteQuestion
            // 
            btnDeleteQuestion.Location = new Point(1113, 664);
            btnDeleteQuestion.Margin = new Padding(5);
            btnDeleteQuestion.Name = "btnDeleteQuestion";
            btnDeleteQuestion.Size = new Size(203, 46);
            btnDeleteQuestion.TabIndex = 12;
            btnDeleteQuestion.Text = "Delete";
            btnDeleteQuestion.UseVisualStyleBackColor = true;
            btnDeleteQuestion.Click += btnDeleteQuestion_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 144);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 11;
            label2.Text = "Quiz Name:";
            label2.Click += label2_Click;
            // 
            // tbxQuizName
            // 
            tbxQuizName.Location = new Point(205, 139);
            tbxQuizName.Margin = new Padding(5);
            tbxQuizName.Name = "tbxQuizName";
            tbxQuizName.Size = new Size(896, 39);
            tbxQuizName.TabIndex = 10;
            // 
            // lbxQuestionList
            // 
            lbxQuestionList.FormattingEnabled = true;
            lbxQuestionList.Location = new Point(1113, 139);
            lbxQuestionList.Margin = new Padding(5);
            lbxQuestionList.Name = "lbxQuestionList";
            lbxQuestionList.ScrollAlwaysVisible = true;
            lbxQuestionList.Size = new Size(399, 516);
            lbxQuestionList.TabIndex = 9;
            lbxQuestionList.SelectedIndexChanged += lbxQuestionList_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1113, 720);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(401, 62);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddMultipleChoice
            // 
            btnAddMultipleChoice.Location = new Point(570, 720);
            btnAddMultipleChoice.Margin = new Padding(5);
            btnAddMultipleChoice.Name = "btnAddMultipleChoice";
            btnAddMultipleChoice.Size = new Size(535, 62);
            btnAddMultipleChoice.TabIndex = 5;
            btnAddMultipleChoice.Text = "Add Multiple Choice Item";
            btnAddMultipleChoice.UseVisualStyleBackColor = true;
            btnAddMultipleChoice.Click += btnAddMultipleChoice_Click;
            // 
            // btnAddIdentification
            // 
            btnAddIdentification.Location = new Point(55, 720);
            btnAddIdentification.Margin = new Padding(5);
            btnAddIdentification.Name = "btnAddIdentification";
            btnAddIdentification.Size = new Size(505, 62);
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
            btnBackToLibrary1.Location = new Point(1258, 62);
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
            ClientSize = new Size(1588, 864);
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
            pnlMultiple.ResumeLayout(false);
            pnlMultiple.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMultiplePoints).EndInit();
            pnlIdentification.ResumeLayout(false);
            pnlIdentification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdentificationPoints).EndInit();
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
        private ListBox lbxQuestionList;
        private TextBox tbxQuizName;
        private Label label2;
        private Button btnDeleteQuestion;
        private Button btnViewQuestion;
        private Label label3;
        private Panel pnlIdentification;
        private TextBox tbxIdentificationAnswer;
        private Label label5;
        private TextBox tbxIdentificationQuestion;
        private Label label4;
        private TextBox tbxIdentificationNumber;
        private NumericUpDown nudIdentificationPoints;
        private Label label6;
        private Panel pnlMultiple;
        private TextBox tbxMultipleQuestion;
        private Label label8;
        private TextBox tbxMultipleNumber;
        private Label label7;
        private NumericUpDown nudMultiplePoints;
        private Label label10;
        private Label label9;
        private TextBox tbxMultipleOption4;
        private TextBox tbxMultipleOption3;
        private CheckBox cbxMultipleOption4;
        private CheckBox cbxMultipleOption3;
        private TextBox tbxMultipleOption2;
        private CheckBox cbxMultipleOption2;
        private TextBox tbxMultipleOption1;
        private CheckBox cbxMultipleOption1;
    }
}
