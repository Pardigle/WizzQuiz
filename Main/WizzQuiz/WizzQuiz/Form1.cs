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
        List<QuizItem> Quiz = new List<QuizItem>();
        public WizzQuizForm()
        {
            InitializeComponent();
        }

        private void AddIdentification()
        {
            pnlMultiple.Visible = false;
            pnlIdentification.Visible = true;
            pnlIdentification.BringToFront();
        }

        private void AddMultiple()
        {
            pnlIdentification.Visible=false;
            pnlMultiple.Visible=true;
            pnlMultiple.BringToFront();
        }

        public void updateQuestionList()
        {
            lbxQuestionList.Items.Clear();
            for (int i = 0; i < Quiz.Count(); i++)
            {
                lbxQuestionList.Items.Add($"Question {(i+1).ToString()}");
            }
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
            pnlLibrary.Visible = false;
            pnlCreate.Visible = true;
            pnlCreate.BringToFront();
        }
        public void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
        }
        private void btnAddMultipleChoice_Click(object sender, EventArgs e)
        {
            AddMultiple();
            MultipleChoice newMultipleChoice = new MultipleChoice();
            Quiz.Add(newMultipleChoice);
            updateQuestionList();
        }

        private void btnAddIdentification_Click(object sender, EventArgs e)
        {
            AddIdentification();
            Identification newIdentification = new Identification();
            Quiz.Add(newIdentification);
            updateQuestionList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToLibrary1_Click(object sender, EventArgs e)
        {
            pnlMultiple.Visible = false;
            pnlLibrary.Visible = true;
            pnlLibrary.BringToFront();
        }

        private void pnlCreate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCreateQuestions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbxQuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlMultiple_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlIdentification_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxIdentificationNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudIdentificationPoints_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxIdentificationQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxIdentificationAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMultipleNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudMultiplePoints_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxMultipleQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMultipleOption1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxMultipleOption2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxMultipleOption3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbxMultipleOption1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMultipleOption2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMultipleOption3_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class QuizItem
    {
        public String question = "";
        public int points;
        public String questionType = "";
    }

    public class Identification : QuizItem
    {
        public String correctAnswer = "";
        public Identification() {}
        public Identification(String question, int points, String questionType, String correctAnswer)
        {
            this.question = question;
            this.points = points;
            this.questionType = questionType;
            this.correctAnswer = correctAnswer;
        }
    }
    public class MultipleChoice : QuizItem
    {
        public String optionDesc1 = "";
        public String optionDesc2 = "";
        public String optionDesc3 = "";
        public String optionDesc4 = "";
        public bool optionCorrect1 = false;
        public bool optionCorrect2 = false;
        public bool optionCorrect3 = false;
        public bool optionCorrect4 = false;
        public MultipleChoice() {}
        public MultipleChoice(String question, int points, String questionType, String optionDesc1, 
            String optionDesc2, String optionDesc3, String optionDesc4, bool optionCorrect1, 
            bool optionCorrect2, bool optionCorrect3, bool optionCorrect4)
        {
            this.question = question;
            this.points = points;
            this.questionType = questionType;

            this.optionDesc1 = optionDesc1;
            this.optionCorrect1 = optionCorrect1;

            this.optionDesc2 = optionDesc2;
            this.optionCorrect2 = optionCorrect2;

            this.optionDesc3 = optionDesc3;
            this.optionCorrect3 = optionCorrect3;

            this.optionDesc4 = optionDesc4;
            this.optionCorrect4 = optionCorrect4;
        }
    }
}
