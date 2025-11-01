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
            lblCreate0 = new Label();
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
            lblCreate = new Label();
            btnBackToLibrary1 = new Button();
            pnlAnswer = new Panel();
            pnlAnswerIdentification = new Panel();
            tbxAnswerIdentification = new TextBox();
            label1 = new Label();
            tbxAnswerQuizName = new TextBox();
            lblAnswerQuizName = new Label();
            pnlAnswerMultiple = new Panel();
            cbxAnswerChoice4 = new CheckBox();
            cbxAnswerChoice3 = new CheckBox();
            cbxAnswerChoice2 = new CheckBox();
            cbxAnswerChoice1 = new CheckBox();
            label10 = new Label();
            btnAnswerSubmit = new Button();
            btnAnswerNext = new Button();
            btnAnswerPrevious = new Button();
            btnAnswerQuestionJumpTo = new Button();
            lbxAnswerQuestionList = new ListBox();
            pnlAnswerQuestion = new Panel();
            tbxAnswerQuestionPoints = new TextBox();
            tbxAnswerQuestion = new TextBox();
            tbxAnswerQuestionNumber = new TextBox();
            lblCreate1 = new Label();
            pnlViewAttempt = new Panel();
            tbxAttemptQuizName = new TextBox();
            btnAttemptPrev = new Button();
            btnAttemptNext = new Button();
            label12 = new Label();
            lblViewAttempt = new Label();
            pnlAttemptAnswerIdentification = new Panel();
            tbxUserAnswerIdentification = new TextBox();
            label13 = new Label();
            tbxAttemptAnswerIdentification = new TextBox();
            label11 = new Label();
            pnlAttemptAnswerMultiple = new Panel();
            tbxAttemptChoice4 = new TextBox();
            pnlChoice4 = new Panel();
            tbxAttemptChoice3 = new TextBox();
            pnlChoice3 = new Panel();
            tbxAttemptChoice2 = new TextBox();
            pnlChoice2 = new Panel();
            tbxAttemptChoice1 = new TextBox();
            pnlChoice1 = new Panel();
            label15 = new Label();
            btnViewAttemptJumpTo = new Button();
            btnBackToAttemptList = new Button();
            pnlAttemptQuestion = new Panel();
            label14 = new Label();
            tbxAttemptQuestionPoints = new TextBox();
            tbxAttemptQuestion = new TextBox();
            tbxAttemptQuestionNumber = new TextBox();
            lbxAttemptQuestionList = new ListBox();
            pnlAttempts = new Panel();
            lsvAttemptList = new ListView();
            btnViewAttemptFromList = new Button();
            btnBackToLibraryAttempts = new Button();
            lblAttempts = new Label();
            pnlLibrary.SuspendLayout();
            pnlCreate.SuspendLayout();
            pnlMultiple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMultiplePoints).BeginInit();
            pnlIdentification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdentificationPoints).BeginInit();
            pnlAnswer.SuspendLayout();
            pnlAnswerIdentification.SuspendLayout();
            pnlAnswerMultiple.SuspendLayout();
            pnlAnswerQuestion.SuspendLayout();
            pnlViewAttempt.SuspendLayout();
            pnlAttemptAnswerIdentification.SuspendLayout();
            pnlAttemptAnswerMultiple.SuspendLayout();
            pnlAttemptQuestion.SuspendLayout();
            pnlAttempts.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddQuiz
            // 
            btnAddQuiz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddQuiz.Font = new Font("Segoe UI", 10F);
            btnAddQuiz.Location = new Point(900, 36);
            btnAddQuiz.Name = "btnAddQuiz";
            btnAddQuiz.Size = new Size(39, 38);
            btnAddQuiz.TabIndex = 0;
            btnAddQuiz.Text = "+";
            btnAddQuiz.UseVisualStyleBackColor = true;
            btnAddQuiz.Click += btnAddQuiz_Click;
            // 
            // btnViewAttempts
            // 
            btnViewAttempts.Font = new Font("Segoe UI", 9F);
            btnViewAttempts.Location = new Point(630, 36);
            btnViewAttempts.Name = "btnViewAttempts";
            btnViewAttempts.Size = new Size(264, 38);
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
            lbxQuizList.Size = new Size(914, 364);
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
            pnlLibrary.Size = new Size(948, 513);
            pnlLibrary.TabIndex = 3;
            pnlLibrary.Paint += pnlLibrary_Paint;
            // 
            // btnDeleteQuiz
            // 
            btnDeleteQuiz.Location = new Point(25, 450);
            btnDeleteQuiz.Name = "btnDeleteQuiz";
            btnDeleteQuiz.Size = new Size(195, 39);
            btnDeleteQuiz.TabIndex = 6;
            btnDeleteQuiz.Text = "Delete";
            btnDeleteQuiz.UseVisualStyleBackColor = true;
            btnDeleteQuiz.Click += btnDeleteQuiz_Click;
            // 
            // btnEditQuiz
            // 
            btnEditQuiz.Location = new Point(226, 450);
            btnEditQuiz.Name = "btnEditQuiz";
            btnEditQuiz.Size = new Size(198, 39);
            btnEditQuiz.TabIndex = 5;
            btnEditQuiz.Text = "Edit";
            btnEditQuiz.UseVisualStyleBackColor = true;
            btnEditQuiz.Click += btnEditQuiz_Click;
            // 
            // btnAnswerQuiz
            // 
            btnAnswerQuiz.Location = new Point(430, 450);
            btnAnswerQuiz.Name = "btnAnswerQuiz";
            btnAnswerQuiz.Size = new Size(509, 39);
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
            lblLibrary.Size = new Size(207, 46);
            lblLibrary.TabIndex = 3;
            lblLibrary.Text = "Your Library";
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
            pnlCreate.Controls.Add(lblCreate);
            pnlCreate.Controls.Add(btnBackToLibrary1);
            pnlCreate.Location = new Point(13, 15);
            pnlCreate.Name = "pnlCreate";
            pnlCreate.Size = new Size(948, 513);
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
            pnlMultiple.Controls.Add(lblCreate0);
            pnlMultiple.Controls.Add(label9);
            pnlMultiple.Controls.Add(tbxMultipleQuestion);
            pnlMultiple.Controls.Add(label8);
            pnlMultiple.Controls.Add(tbxMultipleNumber);
            pnlMultiple.Controls.Add(label7);
            pnlMultiple.Location = new Point(34, 117);
            pnlMultiple.Name = "pnlMultiple";
            pnlMultiple.Size = new Size(646, 328);
            pnlMultiple.TabIndex = 6;
            pnlMultiple.Visible = false;
            pnlMultiple.Paint += pnlMultiple_Paint;
            // 
            // tbxMultipleOption4
            // 
            tbxMultipleOption4.Location = new Point(360, 274);
            tbxMultipleOption4.Name = "tbxMultipleOption4";
            tbxMultipleOption4.Size = new Size(254, 27);
            tbxMultipleOption4.TabIndex = 14;
            tbxMultipleOption4.TextChanged += tbxMultipleOption4_TextChanged;
            // 
            // tbxMultipleOption3
            // 
            tbxMultipleOption3.Location = new Point(360, 238);
            tbxMultipleOption3.Name = "tbxMultipleOption3";
            tbxMultipleOption3.Size = new Size(254, 27);
            tbxMultipleOption3.TabIndex = 7;
            tbxMultipleOption3.TextChanged += tbxMultipleOption3_TextChanged;
            // 
            // cbxMultipleOption4
            // 
            cbxMultipleOption4.AutoSize = true;
            cbxMultipleOption4.Location = new Point(336, 280);
            cbxMultipleOption4.Name = "cbxMultipleOption4";
            cbxMultipleOption4.Size = new Size(18, 17);
            cbxMultipleOption4.TabIndex = 7;
            cbxMultipleOption4.UseVisualStyleBackColor = true;
            cbxMultipleOption4.CheckedChanged += cbxMultipleOption4_CheckedChanged;
            // 
            // cbxMultipleOption3
            // 
            cbxMultipleOption3.AutoSize = true;
            cbxMultipleOption3.Location = new Point(336, 244);
            cbxMultipleOption3.Name = "cbxMultipleOption3";
            cbxMultipleOption3.Size = new Size(18, 17);
            cbxMultipleOption3.TabIndex = 13;
            cbxMultipleOption3.UseVisualStyleBackColor = true;
            cbxMultipleOption3.CheckedChanged += cbxMultipleOption3_CheckedChanged;
            // 
            // tbxMultipleOption2
            // 
            tbxMultipleOption2.Location = new Point(44, 274);
            tbxMultipleOption2.Name = "tbxMultipleOption2";
            tbxMultipleOption2.Size = new Size(259, 27);
            tbxMultipleOption2.TabIndex = 7;
            tbxMultipleOption2.TextChanged += tbxMultipleOption2_TextChanged;
            // 
            // cbxMultipleOption2
            // 
            cbxMultipleOption2.AutoSize = true;
            cbxMultipleOption2.Location = new Point(20, 280);
            cbxMultipleOption2.Name = "cbxMultipleOption2";
            cbxMultipleOption2.Size = new Size(18, 17);
            cbxMultipleOption2.TabIndex = 7;
            cbxMultipleOption2.UseVisualStyleBackColor = true;
            cbxMultipleOption2.CheckedChanged += cbxMultipleOption2_CheckedChanged;
            // 
            // tbxMultipleOption1
            // 
            tbxMultipleOption1.Location = new Point(44, 238);
            tbxMultipleOption1.Name = "tbxMultipleOption1";
            tbxMultipleOption1.Size = new Size(259, 27);
            tbxMultipleOption1.TabIndex = 7;
            tbxMultipleOption1.TextChanged += tbxMultipleOption1_TextChanged;
            // 
            // cbxMultipleOption1
            // 
            cbxMultipleOption1.AutoSize = true;
            cbxMultipleOption1.Location = new Point(20, 244);
            cbxMultipleOption1.Name = "cbxMultipleOption1";
            cbxMultipleOption1.Size = new Size(18, 17);
            cbxMultipleOption1.TabIndex = 7;
            cbxMultipleOption1.UseVisualStyleBackColor = true;
            cbxMultipleOption1.CheckedChanged += cbxMultipleOption1_CheckedChanged;
            // 
            // nudMultiplePoints
            // 
            nudMultiplePoints.Location = new Point(575, 22);
            nudMultiplePoints.Name = "nudMultiplePoints";
            nudMultiplePoints.Size = new Size(52, 27);
            nudMultiplePoints.TabIndex = 12;
            nudMultiplePoints.ValueChanged += nudMultiplePoints_ValueChanged;
            // 
            // lblCreate0
            // 
            lblCreate0.AutoSize = true;
            lblCreate0.Location = new Point(518, 24);
            lblCreate0.Name = "lblCreate0";
            lblCreate0.Size = new Size(51, 20);
            lblCreate0.TabIndex = 11;
            lblCreate0.Text = "Points:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 210);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 10;
            label9.Text = "Answer:";
            // 
            // tbxMultipleQuestion
            // 
            tbxMultipleQuestion.Location = new Point(20, 77);
            tbxMultipleQuestion.Multiline = true;
            tbxMultipleQuestion.Name = "tbxMultipleQuestion";
            tbxMultipleQuestion.Size = new Size(607, 130);
            tbxMultipleQuestion.TabIndex = 9;
            tbxMultipleQuestion.TextChanged += tbxMultipleQuestion_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 54);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 8;
            label8.Text = "Question:";
            // 
            // tbxMultipleNumber
            // 
            tbxMultipleNumber.Enabled = false;
            tbxMultipleNumber.Location = new Point(92, 17);
            tbxMultipleNumber.Name = "tbxMultipleNumber";
            tbxMultipleNumber.ReadOnly = true;
            tbxMultipleNumber.Size = new Size(32, 27);
            tbxMultipleNumber.TabIndex = 7;
            tbxMultipleNumber.TextChanged += tbxMultipleNumber_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 20);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
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
            pnlIdentification.Location = new Point(34, 118);
            pnlIdentification.Name = "pnlIdentification";
            pnlIdentification.Size = new Size(646, 328);
            pnlIdentification.TabIndex = 5;
            pnlIdentification.Visible = false;
            pnlIdentification.Paint += pnlIdentification_Paint;
            // 
            // nudIdentificationPoints
            // 
            nudIdentificationPoints.Location = new Point(575, 16);
            nudIdentificationPoints.Name = "nudIdentificationPoints";
            nudIdentificationPoints.Size = new Size(52, 27);
            nudIdentificationPoints.TabIndex = 6;
            nudIdentificationPoints.ValueChanged += nudIdentificationPoints_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(518, 19);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 6;
            label6.Text = "Points:";
            // 
            // tbxIdentificationAnswer
            // 
            tbxIdentificationAnswer.Location = new Point(20, 230);
            tbxIdentificationAnswer.Multiline = true;
            tbxIdentificationAnswer.Name = "tbxIdentificationAnswer";
            tbxIdentificationAnswer.Size = new Size(607, 82);
            tbxIdentificationAnswer.TabIndex = 5;
            tbxIdentificationAnswer.TextChanged += tbxIdentificationAnswer_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 207);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Answer:";
            // 
            // tbxIdentificationQuestion
            // 
            tbxIdentificationQuestion.Location = new Point(20, 74);
            tbxIdentificationQuestion.Multiline = true;
            tbxIdentificationQuestion.Name = "tbxIdentificationQuestion";
            tbxIdentificationQuestion.Size = new Size(607, 130);
            tbxIdentificationQuestion.TabIndex = 3;
            tbxIdentificationQuestion.TextChanged += tbxIdentificationQuestion_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 51);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 2;
            label4.Text = "Question:";
            // 
            // tbxIdentificationNumber
            // 
            tbxIdentificationNumber.Enabled = false;
            tbxIdentificationNumber.Location = new Point(92, 16);
            tbxIdentificationNumber.Name = "tbxIdentificationNumber";
            tbxIdentificationNumber.Size = new Size(32, 27);
            tbxIdentificationNumber.TabIndex = 1;
            tbxIdentificationNumber.TextChanged += tbxIdentificationNumber_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 20);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Number:";
            label3.Click += label3_Click;
            // 
            // btnViewQuestion
            // 
            btnViewQuestion.Location = new Point(816, 415);
            btnViewQuestion.Name = "btnViewQuestion";
            btnViewQuestion.Size = new Size(116, 29);
            btnViewQuestion.TabIndex = 13;
            btnViewQuestion.Text = "View";
            btnViewQuestion.UseVisualStyleBackColor = true;
            btnViewQuestion.Click += btnViewQuestion_Click;
            // 
            // btnDeleteQuestion
            // 
            btnDeleteQuestion.Location = new Point(685, 415);
            btnDeleteQuestion.Name = "btnDeleteQuestion";
            btnDeleteQuestion.Size = new Size(125, 29);
            btnDeleteQuestion.TabIndex = 12;
            btnDeleteQuestion.Text = "Delete";
            btnDeleteQuestion.UseVisualStyleBackColor = true;
            btnDeleteQuestion.Click += btnDeleteQuestion_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 90);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 11;
            label2.Text = "Quiz Name:";
            label2.Click += label2_Click;
            // 
            // tbxQuizName
            // 
            tbxQuizName.Location = new Point(126, 87);
            tbxQuizName.Name = "tbxQuizName";
            tbxQuizName.Size = new Size(553, 27);
            tbxQuizName.TabIndex = 10;
            // 
            // lbxQuestionList
            // 
            lbxQuestionList.FormattingEnabled = true;
            lbxQuestionList.Location = new Point(685, 87);
            lbxQuestionList.Name = "lbxQuestionList";
            lbxQuestionList.ScrollAlwaysVisible = true;
            lbxQuestionList.Size = new Size(247, 324);
            lbxQuestionList.TabIndex = 9;
            lbxQuestionList.SelectedIndexChanged += lbxQuestionList_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(685, 450);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(247, 39);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddMultipleChoice
            // 
            btnAddMultipleChoice.Location = new Point(351, 450);
            btnAddMultipleChoice.Name = "btnAddMultipleChoice";
            btnAddMultipleChoice.Size = new Size(329, 39);
            btnAddMultipleChoice.TabIndex = 5;
            btnAddMultipleChoice.Text = "Add Multiple Choice Item";
            btnAddMultipleChoice.UseVisualStyleBackColor = true;
            btnAddMultipleChoice.Click += btnAddMultipleChoice_Click;
            // 
            // btnAddIdentification
            // 
            btnAddIdentification.Location = new Point(34, 450);
            btnAddIdentification.Name = "btnAddIdentification";
            btnAddIdentification.Size = new Size(311, 39);
            btnAddIdentification.TabIndex = 5;
            btnAddIdentification.Text = "Add Identification Item";
            btnAddIdentification.UseVisualStyleBackColor = true;
            btnAddIdentification.Click += btnAddIdentification_Click;
            // 
            // lblCreate
            // 
            lblCreate.AutoSize = true;
            lblCreate.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreate.Location = new Point(12, 27);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(200, 46);
            lblCreate.TabIndex = 7;
            lblCreate.Text = "Create Quiz";
            lblCreate.Click += lblCreate_Click;
            // 
            // btnBackToLibrary1
            // 
            btnBackToLibrary1.Location = new Point(774, 39);
            btnBackToLibrary1.Name = "btnBackToLibrary1";
            btnBackToLibrary1.Size = new Size(158, 38);
            btnBackToLibrary1.TabIndex = 4;
            btnBackToLibrary1.Text = "Back to Library";
            btnBackToLibrary1.UseVisualStyleBackColor = true;
            btnBackToLibrary1.Click += btnBackToLibrary1_Click;
            // 
            // pnlAnswer
            // 
            pnlAnswer.Controls.Add(pnlAnswerIdentification);
            pnlAnswer.Controls.Add(tbxAnswerQuizName);
            pnlAnswer.Controls.Add(lblAnswerQuizName);
            pnlAnswer.Controls.Add(pnlAnswerMultiple);
            pnlAnswer.Controls.Add(btnAnswerSubmit);
            pnlAnswer.Controls.Add(btnAnswerNext);
            pnlAnswer.Controls.Add(btnAnswerPrevious);
            pnlAnswer.Controls.Add(btnAnswerQuestionJumpTo);
            pnlAnswer.Controls.Add(lbxAnswerQuestionList);
            pnlAnswer.Controls.Add(pnlAnswerQuestion);
            pnlAnswer.Controls.Add(lblCreate1);
            pnlAnswer.Location = new Point(16, 15);
            pnlAnswer.Name = "pnlAnswer";
            pnlAnswer.Size = new Size(948, 513);
            pnlAnswer.TabIndex = 5;
            pnlAnswer.Paint += pnlAnswer_Paint;
            // 
            // pnlAnswerIdentification
            // 
            pnlAnswerIdentification.Controls.Add(tbxAnswerIdentification);
            pnlAnswerIdentification.Controls.Add(label1);
            pnlAnswerIdentification.Location = new Point(26, 310);
            pnlAnswerIdentification.Name = "pnlAnswerIdentification";
            pnlAnswerIdentification.Size = new Size(651, 136);
            pnlAnswerIdentification.TabIndex = 14;
            pnlAnswerIdentification.Paint += pnlAnswerIdentification_Paint;
            // 
            // tbxAnswerIdentification
            // 
            tbxAnswerIdentification.Location = new Point(12, 35);
            tbxAnswerIdentification.Multiline = true;
            tbxAnswerIdentification.Name = "tbxAnswerIdentification";
            tbxAnswerIdentification.Size = new Size(625, 89);
            tbxAnswerIdentification.TabIndex = 1;
            tbxAnswerIdentification.TextChanged += tbxAnswerIdentification_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Answer:";
            // 
            // tbxAnswerQuizName
            // 
            tbxAnswerQuizName.Location = new Point(118, 91);
            tbxAnswerQuizName.Name = "tbxAnswerQuizName";
            tbxAnswerQuizName.ReadOnly = true;
            tbxAnswerQuizName.Size = new Size(559, 27);
            tbxAnswerQuizName.TabIndex = 9;
            tbxAnswerQuizName.TextChanged += tbxAnswerQuizName_TextChanged;
            // 
            // lblAnswerQuizName
            // 
            lblAnswerQuizName.AutoSize = true;
            lblAnswerQuizName.Location = new Point(26, 94);
            lblAnswerQuizName.Name = "lblAnswerQuizName";
            lblAnswerQuizName.Size = new Size(86, 20);
            lblAnswerQuizName.TabIndex = 8;
            lblAnswerQuizName.Text = "Quiz Name:";
            lblAnswerQuizName.Click += lblAnswerQuizName_Click;
            // 
            // pnlAnswerMultiple
            // 
            pnlAnswerMultiple.Controls.Add(cbxAnswerChoice4);
            pnlAnswerMultiple.Controls.Add(cbxAnswerChoice3);
            pnlAnswerMultiple.Controls.Add(cbxAnswerChoice2);
            pnlAnswerMultiple.Controls.Add(cbxAnswerChoice1);
            pnlAnswerMultiple.Controls.Add(label10);
            pnlAnswerMultiple.Location = new Point(26, 311);
            pnlAnswerMultiple.Name = "pnlAnswerMultiple";
            pnlAnswerMultiple.Size = new Size(651, 134);
            pnlAnswerMultiple.TabIndex = 1;
            pnlAnswerMultiple.Paint += pnlAnswerMultiple_Paint;
            // 
            // cbxAnswerChoice4
            // 
            cbxAnswerChoice4.AutoSize = true;
            cbxAnswerChoice4.Location = new Point(333, 73);
            cbxAnswerChoice4.Name = "cbxAnswerChoice4";
            cbxAnswerChoice4.Size = new Size(155, 24);
            cbxAnswerChoice4.TabIndex = 4;
            cbxAnswerChoice4.Text = "cbxAnswerChoice4";
            cbxAnswerChoice4.UseVisualStyleBackColor = true;
            cbxAnswerChoice4.CheckedChanged += cbxAnswerChoice4_CheckedChanged;
            // 
            // cbxAnswerChoice3
            // 
            cbxAnswerChoice3.AutoSize = true;
            cbxAnswerChoice3.Location = new Point(333, 43);
            cbxAnswerChoice3.Name = "cbxAnswerChoice3";
            cbxAnswerChoice3.Size = new Size(155, 24);
            cbxAnswerChoice3.TabIndex = 3;
            cbxAnswerChoice3.Text = "cbxAnswerChoice3";
            cbxAnswerChoice3.UseVisualStyleBackColor = true;
            cbxAnswerChoice3.CheckedChanged += cbxAnswerChoice3_CheckedChanged;
            // 
            // cbxAnswerChoice2
            // 
            cbxAnswerChoice2.AutoSize = true;
            cbxAnswerChoice2.Location = new Point(14, 75);
            cbxAnswerChoice2.Name = "cbxAnswerChoice2";
            cbxAnswerChoice2.Size = new Size(155, 24);
            cbxAnswerChoice2.TabIndex = 2;
            cbxAnswerChoice2.Text = "cbxAnswerChoice2";
            cbxAnswerChoice2.UseVisualStyleBackColor = true;
            cbxAnswerChoice2.CheckedChanged += cbxAnswerChoice2_CheckedChanged;
            // 
            // cbxAnswerChoice1
            // 
            cbxAnswerChoice1.AutoSize = true;
            cbxAnswerChoice1.Location = new Point(14, 43);
            cbxAnswerChoice1.Name = "cbxAnswerChoice1";
            cbxAnswerChoice1.Size = new Size(155, 24);
            cbxAnswerChoice1.TabIndex = 1;
            cbxAnswerChoice1.Text = "cbxAnswerChoice1";
            cbxAnswerChoice1.UseVisualStyleBackColor = true;
            cbxAnswerChoice1.CheckedChanged += cbxAnswerChoice1_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 12);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 0;
            label10.Text = "Answer:";
            // 
            // btnAnswerSubmit
            // 
            btnAnswerSubmit.Location = new Point(683, 452);
            btnAnswerSubmit.Name = "btnAnswerSubmit";
            btnAnswerSubmit.Size = new Size(245, 37);
            btnAnswerSubmit.TabIndex = 7;
            btnAnswerSubmit.Text = "Submit";
            btnAnswerSubmit.UseVisualStyleBackColor = true;
            btnAnswerSubmit.Click += btnAnswerSubmit_Click;
            // 
            // btnAnswerNext
            // 
            btnAnswerNext.Location = new Point(357, 452);
            btnAnswerNext.Name = "btnAnswerNext";
            btnAnswerNext.Size = new Size(320, 37);
            btnAnswerNext.TabIndex = 6;
            btnAnswerNext.Text = "Next>";
            btnAnswerNext.UseVisualStyleBackColor = true;
            btnAnswerNext.Visible = false;
            btnAnswerNext.Click += btnAnswerNext_Click;
            // 
            // btnAnswerPrevious
            // 
            btnAnswerPrevious.Location = new Point(26, 450);
            btnAnswerPrevious.Name = "btnAnswerPrevious";
            btnAnswerPrevious.Size = new Size(325, 39);
            btnAnswerPrevious.TabIndex = 5;
            btnAnswerPrevious.Text = "<Prev";
            btnAnswerPrevious.UseVisualStyleBackColor = true;
            btnAnswerPrevious.Visible = false;
            btnAnswerPrevious.Click += btnAnswerPrevious_Click;
            // 
            // btnAnswerQuestionJumpTo
            // 
            btnAnswerQuestionJumpTo.Location = new Point(683, 420);
            btnAnswerQuestionJumpTo.Name = "btnAnswerQuestionJumpTo";
            btnAnswerQuestionJumpTo.Size = new Size(245, 29);
            btnAnswerQuestionJumpTo.TabIndex = 4;
            btnAnswerQuestionJumpTo.Text = "Jump To";
            btnAnswerQuestionJumpTo.UseVisualStyleBackColor = true;
            btnAnswerQuestionJumpTo.Click += btnAnswerQuestionJumpTo_Click;
            // 
            // lbxAnswerQuestionList
            // 
            lbxAnswerQuestionList.FormattingEnabled = true;
            lbxAnswerQuestionList.Location = new Point(683, 90);
            lbxAnswerQuestionList.Name = "lbxAnswerQuestionList";
            lbxAnswerQuestionList.Size = new Size(245, 324);
            lbxAnswerQuestionList.TabIndex = 3;
            lbxAnswerQuestionList.SelectedIndexChanged += lbxAnswerQuestionList_SelectedIndexChanged;
            // 
            // pnlAnswerQuestion
            // 
            pnlAnswerQuestion.Controls.Add(tbxAnswerQuestionPoints);
            pnlAnswerQuestion.Controls.Add(tbxAnswerQuestion);
            pnlAnswerQuestion.Controls.Add(tbxAnswerQuestionNumber);
            pnlAnswerQuestion.Location = new Point(26, 124);
            pnlAnswerQuestion.Name = "pnlAnswerQuestion";
            pnlAnswerQuestion.Size = new Size(651, 181);
            pnlAnswerQuestion.TabIndex = 2;
            pnlAnswerQuestion.Paint += pnlAnswerQuestion_Paint;
            // 
            // tbxAnswerQuestionPoints
            // 
            tbxAnswerQuestionPoints.Location = new Point(537, 11);
            tbxAnswerQuestionPoints.Name = "tbxAnswerQuestionPoints";
            tbxAnswerQuestionPoints.ReadOnly = true;
            tbxAnswerQuestionPoints.Size = new Size(100, 27);
            tbxAnswerQuestionPoints.TabIndex = 2;
            tbxAnswerQuestionPoints.TextChanged += tbxAnswerQuestionPoints_TextChanged;
            // 
            // tbxAnswerQuestion
            // 
            tbxAnswerQuestion.Location = new Point(14, 47);
            tbxAnswerQuestion.Multiline = true;
            tbxAnswerQuestion.Name = "tbxAnswerQuestion";
            tbxAnswerQuestion.ReadOnly = true;
            tbxAnswerQuestion.Size = new Size(622, 120);
            tbxAnswerQuestion.TabIndex = 1;
            tbxAnswerQuestion.TextChanged += tbxAnswerQuestion_TextChanged;
            // 
            // tbxAnswerQuestionNumber
            // 
            tbxAnswerQuestionNumber.Location = new Point(13, 14);
            tbxAnswerQuestionNumber.Name = "tbxAnswerQuestionNumber";
            tbxAnswerQuestionNumber.ReadOnly = true;
            tbxAnswerQuestionNumber.Size = new Size(139, 27);
            tbxAnswerQuestionNumber.TabIndex = 0;
            tbxAnswerQuestionNumber.TextChanged += tbxAnswerQuestionNumber_TextChanged;
            // 
            // lblCreate1
            // 
            lblCreate1.AutoSize = true;
            lblCreate1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblCreate1.Location = new Point(12, 28);
            lblCreate1.Name = "lblCreate1";
            lblCreate1.Size = new Size(215, 46);
            lblCreate1.TabIndex = 0;
            lblCreate1.Text = "Answer Quiz";
            lblCreate1.Click += lblCreate1_Click;
            // 
            // pnlViewAttempt
            // 
            pnlViewAttempt.Controls.Add(tbxAttemptQuizName);
            pnlViewAttempt.Controls.Add(btnAttemptPrev);
            pnlViewAttempt.Controls.Add(btnAttemptNext);
            pnlViewAttempt.Controls.Add(label12);
            pnlViewAttempt.Controls.Add(lblViewAttempt);
            pnlViewAttempt.Controls.Add(pnlAttemptAnswerIdentification);
            pnlViewAttempt.Controls.Add(pnlAttemptAnswerMultiple);
            pnlViewAttempt.Controls.Add(btnViewAttemptJumpTo);
            pnlViewAttempt.Controls.Add(btnBackToAttemptList);
            pnlViewAttempt.Controls.Add(pnlAttemptQuestion);
            pnlViewAttempt.Controls.Add(lbxAttemptQuestionList);
            pnlViewAttempt.Location = new Point(11, 15);
            pnlViewAttempt.Margin = new Padding(2);
            pnlViewAttempt.Name = "pnlViewAttempt";
            pnlViewAttempt.Size = new Size(952, 514);
            pnlViewAttempt.TabIndex = 15;
            // 
            // tbxAttemptQuizName
            // 
            tbxAttemptQuizName.Location = new Point(107, 86);
            tbxAttemptQuizName.Name = "tbxAttemptQuizName";
            tbxAttemptQuizName.ReadOnly = true;
            tbxAttemptQuizName.Size = new Size(559, 27);
            tbxAttemptQuizName.TabIndex = 16;
            // 
            // btnAttemptPrev
            // 
            btnAttemptPrev.Location = new Point(14, 453);
            btnAttemptPrev.Name = "btnAttemptPrev";
            btnAttemptPrev.Size = new Size(325, 39);
            btnAttemptPrev.TabIndex = 15;
            btnAttemptPrev.Text = "<Prev";
            btnAttemptPrev.UseVisualStyleBackColor = true;
            btnAttemptPrev.Visible = false;
            btnAttemptPrev.Click += btnAttemptPrev_Click;
            // 
            // btnAttemptNext
            // 
            btnAttemptNext.Location = new Point(345, 455);
            btnAttemptNext.Name = "btnAttemptNext";
            btnAttemptNext.Size = new Size(320, 37);
            btnAttemptNext.TabIndex = 16;
            btnAttemptNext.Text = "Next>";
            btnAttemptNext.UseVisualStyleBackColor = true;
            btnAttemptNext.Visible = false;
            btnAttemptNext.Click += btnAttemptNext_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 88);
            label12.Name = "label12";
            label12.Size = new Size(86, 20);
            label12.TabIndex = 15;
            label12.Text = "Quiz Name:";
            // 
            // lblViewAttempt
            // 
            lblViewAttempt.AutoSize = true;
            lblViewAttempt.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblViewAttempt.Location = new Point(29, 28);
            lblViewAttempt.Name = "lblViewAttempt";
            lblViewAttempt.Size = new Size(230, 46);
            lblViewAttempt.TabIndex = 8;
            lblViewAttempt.Text = "View Attempt";
            // 
            // pnlAttemptAnswerIdentification
            // 
            pnlAttemptAnswerIdentification.Controls.Add(tbxUserAnswerIdentification);
            pnlAttemptAnswerIdentification.Controls.Add(label13);
            pnlAttemptAnswerIdentification.Controls.Add(tbxAttemptAnswerIdentification);
            pnlAttemptAnswerIdentification.Controls.Add(label11);
            pnlAttemptAnswerIdentification.Location = new Point(14, 310);
            pnlAttemptAnswerIdentification.Name = "pnlAttemptAnswerIdentification";
            pnlAttemptAnswerIdentification.Size = new Size(651, 136);
            pnlAttemptAnswerIdentification.TabIndex = 15;
            // 
            // tbxUserAnswerIdentification
            // 
            tbxUserAnswerIdentification.ForeColor = SystemColors.ButtonHighlight;
            tbxUserAnswerIdentification.Location = new Point(13, 98);
            tbxUserAnswerIdentification.Multiline = true;
            tbxUserAnswerIdentification.Name = "tbxUserAnswerIdentification";
            tbxUserAnswerIdentification.ReadOnly = true;
            tbxUserAnswerIdentification.Size = new Size(625, 26);
            tbxUserAnswerIdentification.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 75);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 2;
            label13.Text = "Your Answer:";
            // 
            // tbxAttemptAnswerIdentification
            // 
            tbxAttemptAnswerIdentification.Location = new Point(12, 35);
            tbxAttemptAnswerIdentification.Multiline = true;
            tbxAttemptAnswerIdentification.Name = "tbxAttemptAnswerIdentification";
            tbxAttemptAnswerIdentification.ReadOnly = true;
            tbxAttemptAnswerIdentification.Size = new Size(625, 26);
            tbxAttemptAnswerIdentification.TabIndex = 1;
            tbxAttemptAnswerIdentification.TextChanged += tbxAttemptAnswerIdentification_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 12);
            label11.Name = "label11";
            label11.Size = new Size(112, 20);
            label11.TabIndex = 0;
            label11.Text = "Correct Answer:";
            // 
            // pnlAttemptAnswerMultiple
            // 
            pnlAttemptAnswerMultiple.Controls.Add(tbxAttemptChoice4);
            pnlAttemptAnswerMultiple.Controls.Add(pnlChoice4);
            pnlAttemptAnswerMultiple.Controls.Add(tbxAttemptChoice3);
            pnlAttemptAnswerMultiple.Controls.Add(pnlChoice3);
            pnlAttemptAnswerMultiple.Controls.Add(tbxAttemptChoice2);
            pnlAttemptAnswerMultiple.Controls.Add(pnlChoice2);
            pnlAttemptAnswerMultiple.Controls.Add(tbxAttemptChoice1);
            pnlAttemptAnswerMultiple.Controls.Add(pnlChoice1);
            pnlAttemptAnswerMultiple.Controls.Add(label15);
            pnlAttemptAnswerMultiple.Location = new Point(14, 310);
            pnlAttemptAnswerMultiple.Name = "pnlAttemptAnswerMultiple";
            pnlAttemptAnswerMultiple.Size = new Size(651, 134);
            pnlAttemptAnswerMultiple.TabIndex = 17;
            // 
            // tbxAttemptChoice4
            // 
            tbxAttemptChoice4.Location = new Point(376, 79);
            tbxAttemptChoice4.Margin = new Padding(2);
            tbxAttemptChoice4.Name = "tbxAttemptChoice4";
            tbxAttemptChoice4.ReadOnly = true;
            tbxAttemptChoice4.Size = new Size(260, 27);
            tbxAttemptChoice4.TabIndex = 12;
            // 
            // pnlChoice4
            // 
            pnlChoice4.Location = new Point(341, 79);
            pnlChoice4.Margin = new Padding(2);
            pnlChoice4.Name = "pnlChoice4";
            pnlChoice4.Size = new Size(24, 24);
            pnlChoice4.TabIndex = 11;
            // 
            // tbxAttemptChoice3
            // 
            tbxAttemptChoice3.Location = new Point(376, 45);
            tbxAttemptChoice3.Margin = new Padding(2);
            tbxAttemptChoice3.Name = "tbxAttemptChoice3";
            tbxAttemptChoice3.ReadOnly = true;
            tbxAttemptChoice3.Size = new Size(260, 27);
            tbxAttemptChoice3.TabIndex = 10;
            // 
            // pnlChoice3
            // 
            pnlChoice3.Location = new Point(341, 45);
            pnlChoice3.Margin = new Padding(2);
            pnlChoice3.Name = "pnlChoice3";
            pnlChoice3.Size = new Size(24, 24);
            pnlChoice3.TabIndex = 9;
            // 
            // tbxAttemptChoice2
            // 
            tbxAttemptChoice2.Location = new Point(50, 81);
            tbxAttemptChoice2.Margin = new Padding(2);
            tbxAttemptChoice2.Name = "tbxAttemptChoice2";
            tbxAttemptChoice2.ReadOnly = true;
            tbxAttemptChoice2.Size = new Size(260, 27);
            tbxAttemptChoice2.TabIndex = 8;
            // 
            // pnlChoice2
            // 
            pnlChoice2.Location = new Point(15, 81);
            pnlChoice2.Margin = new Padding(2);
            pnlChoice2.Name = "pnlChoice2";
            pnlChoice2.Size = new Size(24, 24);
            pnlChoice2.TabIndex = 7;
            // 
            // tbxAttemptChoice1
            // 
            tbxAttemptChoice1.Location = new Point(52, 45);
            tbxAttemptChoice1.Margin = new Padding(2);
            tbxAttemptChoice1.Name = "tbxAttemptChoice1";
            tbxAttemptChoice1.ReadOnly = true;
            tbxAttemptChoice1.Size = new Size(260, 27);
            tbxAttemptChoice1.TabIndex = 6;
            // 
            // pnlChoice1
            // 
            pnlChoice1.Location = new Point(17, 45);
            pnlChoice1.Margin = new Padding(2);
            pnlChoice1.Name = "pnlChoice1";
            pnlChoice1.Size = new Size(24, 24);
            pnlChoice1.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(14, 12);
            label15.Name = "label15";
            label15.Size = new Size(60, 20);
            label15.TabIndex = 0;
            label15.Text = "Answer:";
            // 
            // btnViewAttemptJumpTo
            // 
            btnViewAttemptJumpTo.Location = new Point(671, 440);
            btnViewAttemptJumpTo.Name = "btnViewAttemptJumpTo";
            btnViewAttemptJumpTo.Size = new Size(245, 50);
            btnViewAttemptJumpTo.TabIndex = 15;
            btnViewAttemptJumpTo.Text = "Jump To";
            btnViewAttemptJumpTo.UseVisualStyleBackColor = true;
            btnViewAttemptJumpTo.Click += btnViewAttemptJumpTo_Click;
            // 
            // btnBackToAttemptList
            // 
            btnBackToAttemptList.Location = new Point(756, 49);
            btnBackToAttemptList.Name = "btnBackToAttemptList";
            btnBackToAttemptList.Size = new Size(158, 38);
            btnBackToAttemptList.TabIndex = 15;
            btnBackToAttemptList.Text = "Back to Attempt List";
            btnBackToAttemptList.UseVisualStyleBackColor = true;
            btnBackToAttemptList.Click += btnBackToAttemptList_Click;
            // 
            // pnlAttemptQuestion
            // 
            pnlAttemptQuestion.Controls.Add(label14);
            pnlAttemptQuestion.Controls.Add(tbxAttemptQuestionPoints);
            pnlAttemptQuestion.Controls.Add(tbxAttemptQuestion);
            pnlAttemptQuestion.Controls.Add(tbxAttemptQuestionNumber);
            pnlAttemptQuestion.Location = new Point(14, 125);
            pnlAttemptQuestion.Name = "pnlAttemptQuestion";
            pnlAttemptQuestion.Size = new Size(651, 181);
            pnlAttemptQuestion.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(483, 14);
            label14.Name = "label14";
            label14.Size = new Size(51, 20);
            label14.TabIndex = 17;
            label14.Text = "Points:";
            // 
            // tbxAttemptQuestionPoints
            // 
            tbxAttemptQuestionPoints.Location = new Point(537, 11);
            tbxAttemptQuestionPoints.Name = "tbxAttemptQuestionPoints";
            tbxAttemptQuestionPoints.ReadOnly = true;
            tbxAttemptQuestionPoints.Size = new Size(100, 27);
            tbxAttemptQuestionPoints.TabIndex = 2;
            // 
            // tbxAttemptQuestion
            // 
            tbxAttemptQuestion.Location = new Point(14, 47);
            tbxAttemptQuestion.Multiline = true;
            tbxAttemptQuestion.Name = "tbxAttemptQuestion";
            tbxAttemptQuestion.ReadOnly = true;
            tbxAttemptQuestion.Size = new Size(622, 120);
            tbxAttemptQuestion.TabIndex = 1;
            // 
            // tbxAttemptQuestionNumber
            // 
            tbxAttemptQuestionNumber.Location = new Point(13, 14);
            tbxAttemptQuestionNumber.Name = "tbxAttemptQuestionNumber";
            tbxAttemptQuestionNumber.ReadOnly = true;
            tbxAttemptQuestionNumber.Size = new Size(139, 27);
            tbxAttemptQuestionNumber.TabIndex = 0;
            // 
            // lbxAttemptQuestionList
            // 
            lbxAttemptQuestionList.FormattingEnabled = true;
            lbxAttemptQuestionList.Location = new Point(671, 94);
            lbxAttemptQuestionList.Name = "lbxAttemptQuestionList";
            lbxAttemptQuestionList.Size = new Size(245, 344);
            lbxAttemptQuestionList.TabIndex = 15;
            lbxAttemptQuestionList.SelectedIndexChanged += lbxAttemptQuestionList_SelectedIndexChanged;
            // 
            // pnlAttempts
            // 
            pnlAttempts.Controls.Add(lsvAttemptList);
            pnlAttempts.Controls.Add(btnViewAttemptFromList);
            pnlAttempts.Controls.Add(btnBackToLibraryAttempts);
            pnlAttempts.Controls.Add(lblAttempts);
            pnlAttempts.Location = new Point(16, 14);
            pnlAttempts.Margin = new Padding(2);
            pnlAttempts.Name = "pnlAttempts";
            pnlAttempts.Size = new Size(949, 513);
            pnlAttempts.TabIndex = 7;
            pnlAttempts.Paint += pnlAttempts_Paint;
            // 
            // lsvAttemptList
            // 
            lsvAttemptList.FullRowSelect = true;
            lsvAttemptList.GridLines = true;
            lsvAttemptList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lsvAttemptList.Location = new Point(25, 81);
            lsvAttemptList.Margin = new Padding(2);
            lsvAttemptList.Name = "lsvAttemptList";
            lsvAttemptList.Size = new Size(914, 364);
            lsvAttemptList.TabIndex = 3;
            lsvAttemptList.UseCompatibleStateImageBehavior = false;
            lsvAttemptList.View = View.Details;
            // 
            // btnViewAttemptFromList
            // 
            btnViewAttemptFromList.Location = new Point(25, 450);
            btnViewAttemptFromList.Margin = new Padding(2);
            btnViewAttemptFromList.Name = "btnViewAttemptFromList";
            btnViewAttemptFromList.Size = new Size(913, 38);
            btnViewAttemptFromList.TabIndex = 2;
            btnViewAttemptFromList.Text = "View Attempt";
            btnViewAttemptFromList.UseVisualStyleBackColor = true;
            btnViewAttemptFromList.Click += btnViewAttemptFromList_Click;
            // 
            // btnBackToLibraryAttempts
            // 
            btnBackToLibraryAttempts.Location = new Point(674, 36);
            btnBackToLibraryAttempts.Margin = new Padding(2);
            btnBackToLibraryAttempts.Name = "btnBackToLibraryAttempts";
            btnBackToLibraryAttempts.Size = new Size(264, 38);
            btnBackToLibraryAttempts.TabIndex = 1;
            btnBackToLibraryAttempts.Text = "Back to Library";
            btnBackToLibraryAttempts.UseVisualStyleBackColor = true;
            btnBackToLibraryAttempts.Click += btnBackToLibraryAttempts_Click;
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Font = new Font("Segoe UI Semibold", 19.8F, FontStyle.Bold);
            lblAttempts.Location = new Point(9, 28);
            lblAttempts.Margin = new Padding(2, 0, 2, 0);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(234, 45);
            lblAttempts.TabIndex = 0;
            lblAttempts.Text = "Your Attempts";
            // 
            // WizzQuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 542);
            Controls.Add(pnlViewAttempt);
            Controls.Add(pnlAnswer);
            Controls.Add(pnlCreate);
            Controls.Add(pnlAttempts);
            Controls.Add(pnlLibrary);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            pnlAnswer.ResumeLayout(false);
            pnlAnswer.PerformLayout();
            pnlAnswerIdentification.ResumeLayout(false);
            pnlAnswerIdentification.PerformLayout();
            pnlAnswerMultiple.ResumeLayout(false);
            pnlAnswerMultiple.PerformLayout();
            pnlAnswerQuestion.ResumeLayout(false);
            pnlAnswerQuestion.PerformLayout();
            pnlViewAttempt.ResumeLayout(false);
            pnlViewAttempt.PerformLayout();
            pnlAttemptAnswerIdentification.ResumeLayout(false);
            pnlAttemptAnswerIdentification.PerformLayout();
            pnlAttemptAnswerMultiple.ResumeLayout(false);
            pnlAttemptAnswerMultiple.PerformLayout();
            pnlAttemptQuestion.ResumeLayout(false);
            pnlAttemptQuestion.PerformLayout();
            pnlAttempts.ResumeLayout(false);
            pnlAttempts.PerformLayout();
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
        private Label lblCreate;
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
        private Label lblCreate0;
        private Label label9;
        private TextBox tbxMultipleOption4;
        private TextBox tbxMultipleOption3;
        private CheckBox cbxMultipleOption4;
        private CheckBox cbxMultipleOption3;
        private TextBox tbxMultipleOption2;
        private CheckBox cbxMultipleOption2;
        private TextBox tbxMultipleOption1;
        private CheckBox cbxMultipleOption1;
        private Panel pnlAnswer;
        private Label lblCreate1;
        private Button btnAnswerSubmit;
        private Button btnAnswerNext;
        private Button btnAnswerPrevious;
        private Button btnAnswerQuestionJumpTo;
        private ListBox lbxAnswerQuestionList;
        private Panel pnlAnswerQuestion;
        private Panel pnlAnswerMultiple;
        private Label lblAnswerQuizName;
        private TextBox tbxAnswerQuizName;
        private TextBox tbxAnswerQuestionNumber;
        private TextBox tbxAnswerQuestion;
        private TextBox tbxAnswerQuestionPoints;
        private Panel pnlAnswerIdentification;
        private CheckBox cbxAnswerChoice4;
        private CheckBox cbxAnswerChoice3;
        private CheckBox cbxAnswerChoice2;
        private CheckBox cbxAnswerChoice1;
        private Label label10;
        private TextBox tbxAnswerIdentification;
        private Label label1;
        private Panel pnlAttempts;
        private Label lblAttempts;
        private Button btnBackToLibraryAttempts;
        private Button btnViewAttemptFromList;
        private ListView lsvAttemptList;
        private Label lblViewAttempt;
        private Button btnBackToAttemptList;
        private Button btnViewAttemptJumpTo;
        private ListBox lbxAttemptQuestionList;
        private Panel pnlAttemptQuestion;
        private TextBox tbxAttemptQuestionPoints;
        private TextBox tbxAttemptQuestion;
        private TextBox tbxAttemptQuestionNumber;
        private Button btnAttemptNext;
        private Button btnAttemptPrev;
        private Panel pnlAttemptAnswerIdentification;
        private TextBox tbxAttemptAnswerIdentification;
        private Label label11;
        private Panel pnlViewAttempt;
        private TextBox tbxAttemptQuizName;
        private Label label12;
        private TextBox tbxUserAnswerIdentification;
        private Label label13;
        private Label label14;
        private Panel pnlAttemptAnswerMultiple;
        private Label label15;
        private TextBox tbxAttemptChoice4;
        private Panel pnlChoice4;
        private TextBox tbxAttemptChoice3;
        private Panel pnlChoice3;
        private TextBox tbxAttemptChoice2;
        private Panel pnlChoice2;
        private TextBox tbxAttemptChoice1;
        private Panel pnlChoice1;
    }
}
