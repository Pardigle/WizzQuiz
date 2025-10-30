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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
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
            lblLibrary.Size = new Size(199, 46);
            lblLibrary.TabIndex = 3;
            lblLibrary.Text = "Your library";
            lblLibrary.Click += lblLibrary_Click;
            // 
            // pnlCreate
            // 
            pnlCreate.Controls.Add(pnlMultiple);
            pnlCreate.Controls.Add(pnlIdentification);
            pnlCreate.Controls.Add(button2);
            pnlCreate.Controls.Add(button1);
            pnlCreate.Controls.Add(label2);
            pnlCreate.Controls.Add(textBox1);
            pnlCreate.Controls.Add(lbxQuestionList);
            pnlCreate.Controls.Add(btnSave);
            pnlCreate.Controls.Add(btnAddMultipleChoice);
            pnlCreate.Controls.Add(btnAddIdentification);
            pnlCreate.Controls.Add(label1);
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
            pnlMultiple.Controls.Add(label10);
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(518, 24);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 11;
            label10.Text = "Points:";
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
            tbxMultipleNumber.Location = new Point(92, 17);
            tbxMultipleNumber.Name = "tbxMultipleNumber";
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
            // button2
            // 
            button2.Location = new Point(816, 415);
            button2.Name = "button2";
            button2.Size = new Size(116, 29);
            button2.TabIndex = 13;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(685, 415);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 12;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(126, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(553, 27);
            textBox1.TabIndex = 10;
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
            btnBackToLibrary1.Location = new Point(774, 39);
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
            ClientSize = new Size(977, 540);
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
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button button2;
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
