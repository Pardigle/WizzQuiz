using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WizzQuiz
{
    public partial class WizzQuizForm : Form
    {
        int i = 0;

        public WizzQuizForm()
        {
            InitializeComponent();

            // When the form loads, add a blank title input to the Create Quiz screen
            TableLayoutPanel pnlQuizTitleInput = QuizTitleLayout();
            pnlCreateQuestions.Controls.Add(pnlQuizTitleInput);
        }

        private void WizzQuizForm_Load(object sender, EventArgs e)
        {
            pnlLibrary.BringToFront();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pnlLibrary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbxQuizList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnViewAttempts_Click(object sender, EventArgs e)
        {

        }

        private void btnAnswerQuiz_Click(object sender, EventArgs e)
        {

        }

        private void btnEditQuiz_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteQuiz_Click(object sender, EventArgs e)
        {

        }

        private void lblLibrary_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddQuiz_Click(object sender, EventArgs e)
        {
            pnlCreate.BringToFront();
        }



        // CODE FOR CREATE QUIZ 

        // SHOWS TITLE INPUT BOX
        public static TableLayoutPanel QuizTitleLayout() 
        {
            TableLayoutPanel pnlQuizTitleInput = new TableLayoutPanel();
            pnlQuizTitleInput.RowCount = 1;
            pnlQuizTitleInput.ColumnCount = 2;
            pnlQuizTitleInput.Size = new Size(1050, 50);
            pnlQuizTitleInput.AutoSize = false;
            pnlQuizTitleInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            pnlQuizTitleInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93F));
            pnlQuizTitleInput.Margin = new Padding(0, 0, 0, 20);

            Label lblQuizTitleInput = new Label();
            lblQuizTitleInput.AutoSize = true;
            lblQuizTitleInput.Text = "Title: ";

            TextBox tbxQuizTitleInput = new TextBox();
            tbxQuizTitleInput.Multiline = true;
            tbxQuizTitleInput.WordWrap = true;
            tbxQuizTitleInput.Dock = DockStyle.Fill;
            tbxQuizTitleInput.ScrollBars = ScrollBars.Vertical;

            pnlQuizTitleInput.Controls.Add(lblQuizTitleInput, 0, 0);
            pnlQuizTitleInput.Controls.Add(tbxQuizTitleInput, 1, 0);

            return pnlQuizTitleInput;
        }

        // TEMPLATE FOR QUIZ QUESTIONS (leaves last column empty)
        public TableLayoutPanel CreateQuestionLayout(int tableHeight, int questionNum)
        {
            // Creates a new panel for each MultipleChoice question
            TableLayoutPanel pnlQuestionTemplate = new TableLayoutPanel();
            pnlQuestionTemplate.RowCount = 5;
            pnlQuestionTemplate.ColumnCount = 1;
            pnlQuestionTemplate.AutoSize = false;
            pnlQuestionTemplate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlQuestionTemplate.Size = new Size(1050, tableHeight);
            pnlQuestionTemplate.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pnlQuestionTemplate.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pnlQuestionTemplate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlQuestionTemplate.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pnlQuestionTemplate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlQuestionTemplate.Margin = new Padding(0, 0, 0, 50);

            // ROW 1 -- Points number entry
            TableLayoutPanel pnlRow1 = new TableLayoutPanel();
            pnlRow1.RowCount = 1;
            pnlRow1.ColumnCount = 2;
            pnlRow1.Size = new Size(1050, 50);
            pnlRow1.AutoSize = false;
            pnlRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            pnlRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));

            Button btnDeleteQuestion = new Button();
            btnDeleteQuestion.Text = "×";
            btnDeleteQuestion.BackColor = Color.Red;
            btnDeleteQuestion.ForeColor = Color.White;
            btnDeleteQuestion.AutoSize = true;

            // Source: https://stackoverflow.com/questions/13888558/removing-dynamic-controls-from-panel
            btnDeleteQuestion.Tag = pnlQuestionTemplate;
            btnDeleteQuestion.Click += new EventHandler(btnDeleteQuestion_Click);

            FlowLayoutPanel pnlPoints = new FlowLayoutPanel();
            pnlPoints.FlowDirection = FlowDirection.RightToLeft;
            pnlPoints.AutoSize = true;
            pnlPoints.Anchor = AnchorStyles.Right;

            Label lblPoints = new Label();
            lblPoints.Text = "Points: ";
            lblPoints.AutoSize = true;

            NumericUpDown tbxPoints = new NumericUpDown();
            tbxPoints.Height = 38;
            tbxPoints.AutoSize = true;
            tbxPoints.Minimum = 1;

            pnlPoints.Controls.Add(tbxPoints);
            pnlPoints.Controls.Add(lblPoints);

            pnlRow1.Controls.Add(btnDeleteQuestion);
            pnlRow1.Controls.Add(pnlPoints);

            // ROW 2
            Label lblQuestion = new Label();
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Text = "Question " + questionNum.ToString() + ":";
            lblQuestion.AutoSize = true;

            // ROW 3 -- Question text entry
            TextBox tbxQuestion = new TextBox();
            tbxQuestion.PlaceholderText = "Definition ";
            tbxQuestion.Multiline = true;
            tbxQuestion.WordWrap = true;
            tbxQuestion.Dock = DockStyle.Fill;
            tbxQuestion.ScrollBars = ScrollBars.Vertical;

            // ROW 4
            Label lblAnswer = new Label();
            lblAnswer.Text = "Answer:";
            lblAnswer.AutoSize = true;

            pnlQuestionTemplate.Controls.Add(pnlRow1, 0, 0);
            pnlQuestionTemplate.Controls.Add(lblQuestion, 0, 1);
            pnlQuestionTemplate.Controls.Add(tbxQuestion, 0, 2);
            pnlQuestionTemplate.Controls.Add(lblAnswer, 0, 3);

            return pnlQuestionTemplate;
        }

        // FUNCTIONALITY FOR DELETE QUESTION BUTTON
        public void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            Button btnDeleteQuestion = sender as Button;
            TableLayoutPanel questionToDelete = btnDeleteQuestion.Tag as TableLayoutPanel;

            if (questionToDelete != null)
            {
                pnlCreateQuestions.Controls.Remove(questionToDelete);
            }
        }

        public TableLayoutPanel MultipleChoiceLayout(int questionNumber)
        {
            TableLayoutPanel pnlMultipleChoice = CreateQuestionLayout(500, questionNumber);

            // ROW 5 -- Choices checkboxes
            TableLayoutPanel pnlChoices = new TableLayoutPanel();
            pnlChoices.RowCount = 4;
            pnlChoices.ColumnCount = 2;
            pnlChoices.Size = new Size(1050, 180);
            pnlChoices.AutoSize = false;
            pnlChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            pnlChoices.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
            pnlChoices.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pnlChoices.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pnlChoices.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pnlChoices.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pnlChoices.Location = new Point(10, (questionNumber - 1) * (pnlChoices.Height + 20));

            CheckBox chkChoice1 = new CheckBox();
            chkChoice1.Text = "";
            TextBox tbxChoice1 = new TextBox();
            tbxChoice1.PlaceholderText = "Choice A";
            tbxChoice1.Multiline = true;
            tbxChoice1.WordWrap = true;
            tbxChoice1.Dock = DockStyle.Fill;
            tbxChoice1.ScrollBars = ScrollBars.Vertical;

            CheckBox chkChoice2 = new CheckBox();
            chkChoice2.Text = "";
            TextBox tbxChoice2 = new TextBox();
            tbxChoice2.PlaceholderText = "Choice B";
            tbxChoice2.Multiline = true;
            tbxChoice2.WordWrap = true;
            tbxChoice2.Dock = DockStyle.Fill;
            tbxChoice2.ScrollBars = ScrollBars.Vertical;

            CheckBox chkChoice3 = new CheckBox();
            chkChoice3.Text = "";
            TextBox tbxChoice3 = new TextBox();
            tbxChoice3.PlaceholderText = "Choice C";
            tbxChoice3.Multiline = true;
            tbxChoice3.WordWrap = true;
            tbxChoice3.Dock = DockStyle.Fill;
            tbxChoice3.ScrollBars = ScrollBars.Vertical;

            CheckBox chkChoice4 = new CheckBox();
            chkChoice4.Text = "";
            TextBox tbxChoice4 = new TextBox();
            tbxChoice4.PlaceholderText = "Choice D";
            tbxChoice4.Multiline = true;
            tbxChoice4.WordWrap = true;
            tbxChoice4.Dock = DockStyle.Fill;
            tbxChoice4.ScrollBars = ScrollBars.Vertical;

            pnlChoices.Controls.Add(chkChoice1, 0, 0);
            pnlChoices.Controls.Add(chkChoice2, 0, 1);
            pnlChoices.Controls.Add(chkChoice3, 0, 2);
            pnlChoices.Controls.Add(chkChoice4, 0, 3);
            pnlChoices.Controls.Add(tbxChoice1, 1, 0);
            pnlChoices.Controls.Add(tbxChoice2, 1, 1);
            pnlChoices.Controls.Add(tbxChoice3, 1, 2);
            pnlChoices.Controls.Add(tbxChoice4, 1, 3);

            pnlMultipleChoice.Controls.Add(pnlChoices, 0, 4);
            return pnlMultipleChoice;
        }

        public TableLayoutPanel IdentificationLayout(int questionNumber)
        {
            TableLayoutPanel pnlIdentification = CreateQuestionLayout(350, questionNumber);

            // ROW 5 -- Answer text entry
            TextBox tbxAnswer = new TextBox();
            tbxAnswer.PlaceholderText = "Term ";
            tbxAnswer.Multiline = true;
            tbxAnswer.WordWrap = true;
            tbxAnswer.Dock = DockStyle.Fill;
            tbxAnswer.ScrollBars = ScrollBars.Vertical;

            pnlIdentification.Controls.Add(tbxAnswer, 0, 4);
            return pnlIdentification;
        }

        // BUTTONS FOR CREATING QUESTIONS
        private void btnAddMultipleChoice_Click(object sender, EventArgs e)
        {
            i++; // For question number

            TableLayoutPanel pnlMultipleChoice = MultipleChoiceLayout(i);
            pnlCreateQuestions.Controls.Add(pnlMultipleChoice);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddIdentification_Click(object sender, EventArgs e)
        {
            i++;

            TableLayoutPanel pnlIdentification = IdentificationLayout(i);
            pnlCreateQuestions.Controls.Add(pnlIdentification);
        }

        private void btnBackToLibrary1_Click(object sender, EventArgs e)
        {
            pnlLibrary.BringToFront();
        }

        private void pnlCreate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCreateQuestions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
