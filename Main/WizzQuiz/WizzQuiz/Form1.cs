using System;
using System.Collections;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WizzQuiz
{
    public partial class WizzQuizForm : Form
    {
        List<QuizItem> Quiz = new List<QuizItem>();
        List<QuizItem> QuizAttempt = new List<QuizItem>();
        String QuizAnsweredName = "";
        int currentAttemptIndex = 0;
        //String path = "C:/Users/beaZ13/SynologyDrive/School/Y3S1_files/msys(dsa)_files/dsa_proj/WizzQuiz/Main/WizzQuiz/WizzQuiz/Quizzes.xml";
        //String pathAttempts = "C:/Users/beaZ13/SynologyDrive/School/Y3S1_files/msys(dsa)_files/dsa_proj/WizzQuiz/Main/WizzQuiz/WizzQuiz/Attempts.xml";
        String path = "C:/Users/Mikey/Source/Repos/WizzQuiz/Main/WizzQuiz/WizzQuiz/Quizzes.xml";
        String pathAttempts = "C:/Users/Mikey/Source/Repos/WizzQuiz/Main/WizzQuiz/WizzQuiz/Attempts.xml";

        bool editState = false; // checks whether user is currently editing a quiz

        public WizzQuizForm()
        {
            InitializeComponent();
        }

        private void ViewIdentification()
        {
            pnlMultiple.Visible = false;
            pnlIdentification.Visible = true;
            pnlIdentification.BringToFront();
        }

        private void ViewMultiple()
        {
            pnlIdentification.Visible = false;
            pnlMultiple.Visible = true;
            pnlMultiple.BringToFront();
        }

        private void AddIdentificationItem()
        {
            tbxIdentificationNumber.Text = Quiz.Count.ToString();
            nudIdentificationPoints.Value = 1;
            tbxIdentificationQuestion.Clear();
            tbxIdentificationAnswer.Clear();
        }

        private void AddMultipleChoiceItem()
        {
            tbxMultipleNumber.Text = Quiz.Count.ToString();
            nudMultiplePoints.Value = 1;
            tbxMultipleQuestion.Clear();

            tbxMultipleOption1.Clear();
            tbxMultipleOption2.Clear();
            tbxMultipleOption3.Clear();
            tbxMultipleOption4.Clear();
            cbxMultipleOption1.Checked = false;
            cbxMultipleOption2.Checked = false;
            cbxMultipleOption3.Checked = false;
            cbxMultipleOption4.Checked = false;
        }

        public void UpdateQuestionList()
        {
            lbxQuestionList.Items.Clear();
            for (int i = 0; i < Quiz.Count(); i++)
            {
                lbxQuestionList.Items.Add($"Question {(i + 1).ToString()}");
            }
        }

        public void UpdateQuizList()
        {
            XmlDocument doc = new();
            doc.Load(path);
            XmlElement rootNode = doc.DocumentElement;
            int quizNumber = 1;
            lbxQuizList.Items.Clear();
            foreach (XmlElement quiz in rootNode.ChildNodes)
            {
                lbxQuizList.Items.Add($"{quizNumber.ToString()}: " + quiz.GetAttribute("QuizName"));
                quizNumber++;
            }
        }
        public void ViewQuestionIndex(int index)
        {
            if (index >= 0)
            {
                QuizItem indexedItem = QuizAttempt[index];
                tbxAnswerQuestionNumber.Text = $"Question {(index + 1).ToString()}.";
                tbxAnswerQuestion.Text = $"{indexedItem.question}";
                tbxAnswerQuestionPoints.Text = $"({indexedItem.points.ToString()} points)";

                if (index == 0)
                {
                    btnAnswerPrevious.Visible = false;
                }
                else
                {
                    btnAnswerPrevious.Visible = true;
                }
                if (index == QuizAttempt.Count - 1)
                {
                    btnAnswerNext.Visible = false;
                }
                else
                {
                    btnAnswerNext.Visible = true;
                }

                if (indexedItem.questionType == "MultipleChoice")
                {
                    pnlAnswerIdentification.Visible = false;
                    pnlAnswerMultiple.Visible = true;
                    pnlAnswerMultiple.BringToFront();
                    AnswerMultipleChoice multipleChoiceItem = (AnswerMultipleChoice)indexedItem;

                    cbxAnswerChoice1.Text = multipleChoiceItem.optionDesc1;
                    cbxAnswerChoice2.Text = multipleChoiceItem.optionDesc2;
                    cbxAnswerChoice3.Text = multipleChoiceItem.optionDesc3;
                    cbxAnswerChoice4.Text = multipleChoiceItem.optionDesc4;

                    cbxAnswerChoice1.Checked = multipleChoiceItem.optionSelected1;
                    cbxAnswerChoice2.Checked = multipleChoiceItem.optionSelected2;
                    cbxAnswerChoice3.Checked = multipleChoiceItem.optionSelected3;
                    cbxAnswerChoice4.Checked = multipleChoiceItem.optionSelected4;
                }
                else
                {
                    pnlAnswerMultiple.Visible = false;
                    pnlAnswerIdentification.Visible = true;
                    pnlAnswerIdentification.BringToFront();
                    AnswerIdentification identificationItem = (AnswerIdentification)indexedItem;
                    tbxAnswerIdentification.Text = identificationItem.inputtedAnswer;
                }
            }
        }
        public static string computeScore(XmlElement attempt)
        {
            int myScore = 0;
            int totalPoints = 0;

            foreach (XmlElement question in attempt.ChildNodes)
            { 
                string questionType = question.GetAttribute("QuestionType");
                int points = Convert.ToInt32(question.GetAttribute("Points"));
                totalPoints += points;

                if (questionType == "Identification")
                {
                    string myAnswer = question.GetAttribute("InputtedAnswer").ToLower().Trim();
                    string correctAnswer = question.GetAttribute("CorrectAnswer").ToLower().Trim();

                    if (myAnswer == correctAnswer)
                    {
                        myScore += points;
                    }
                }
                else if (questionType == "MultipleChoice")
                {
                    bool choiceCorrect1 = Convert.ToBoolean(question.GetAttribute("ChoiceCorrect1"));
                    bool choiceCorrect2 = Convert.ToBoolean(question.GetAttribute("ChoiceCorrect2"));
                    bool choiceCorrect3 = Convert.ToBoolean(question.GetAttribute("ChoiceCorrect3"));
                    bool choiceCorrect4 = Convert.ToBoolean(question.GetAttribute("ChoiceCorrect4"));
                    bool choiceSelected1 = Convert.ToBoolean(question.GetAttribute("ChoiceSelected1"));
                    bool choiceSelected2 = Convert.ToBoolean(question.GetAttribute("ChoiceSelected2"));
                    bool choiceSelected3 = Convert.ToBoolean(question.GetAttribute("ChoiceSelected3"));
                    bool choiceSelected4 = Convert.ToBoolean(question.GetAttribute("ChoiceSelected4"));

                    if (choiceSelected1 == choiceCorrect1 && choiceSelected2 == choiceCorrect2 && choiceSelected3 == choiceCorrect3 && choiceSelected4 == choiceCorrect4)
                    {
                        myScore += points;
                    }

                }
            }

            return $"{myScore} / {totalPoints}";
        }
        public void UpdateAttemptList()
        {
            XmlDocument doc = new();
            doc.Load(pathAttempts);
            XmlElement rootNode = doc.DocumentElement;
         
            lsvAttemptList.Items.Clear();
            lsvAttemptList.Columns.Add("Attempt", 1129, HorizontalAlignment.Center);
            lsvAttemptList.Columns.Add("Score", 350, HorizontalAlignment.Center);

            Dictionary<string, int> trackMultipleQuizAttempts = new Dictionary<string, int>();
            int attemptNumber = 1;

            foreach (XmlElement item in rootNode.ChildNodes)
            {
                // Source: https://www.c-sharpcorner.com/article/various-methods-to-count-occurrences-of-each-number-in-array-or-list/

                string quizName = item.GetAttribute("QuizName");
                
                if (trackMultipleQuizAttempts.ContainsKey(quizName))
                {
                    trackMultipleQuizAttempts[quizName]++;
                    attemptNumber = trackMultipleQuizAttempts[quizName];
                }
                else
                {
                    trackMultipleQuizAttempts[quizName] = 1;
                    attemptNumber = 1;
                }

                ListViewItem attempt = new ListViewItem(quizName + $"    (Attempt #{attemptNumber})");
                attempt.SubItems.Add(computeScore(item));
                lsvAttemptList.Items.Add(attempt);
            }
        }
        
        
        private void WizzQuizForm_Load(object sender, EventArgs e)
        {
            UpdateQuizList();
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
            pnlLibrary.Visible = false;
            pnlAttempts.Visible = true;
            UpdateAttemptList();
            pnlAttempts.BringToFront();
        }

        private void btnAnswerQuiz_Click(object sender, EventArgs e)
        {
            int selectedQuizIndex = lbxQuizList.SelectedIndex;
            currentAttemptIndex = 0;

            if (selectedQuizIndex < 0)
            {
                MessageBox.Show("Please select a quiz.",
                    "No Quiz Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                pnlLibrary.Visible = false;
                pnlAnswer.Visible = true;

                pnlAnswer.BringToFront();
                lbxAnswerQuestionList.Items.Clear();
                QuizAttempt.Clear();

                XmlDocument doc = new();
                doc.Load(path);
                XmlElement rootNode = doc.DocumentElement;

                XmlElement selectedQuiz = (XmlElement)rootNode.ChildNodes[selectedQuizIndex];

                string quizName = selectedQuiz.GetAttribute("QuizName");
                QuizAnsweredName = quizName;
                tbxAnswerQuizName.Text = quizName;
                int questionNumber = 1;

                foreach (XmlElement item in selectedQuiz.ChildNodes)
                {
                    string questionType = item.GetAttribute("QuestionType");
                    int points = Convert.ToInt32(item.GetAttribute("Points"));
                    string question = item.GetAttribute("Question");

                    if (questionType == "Identification")
                    {
                        string answer = item.GetAttribute("CorrectAnswer");

                        AnswerIdentification identificationItem = new AnswerIdentification(question, points, questionType, answer);
                        QuizAttempt.Add(identificationItem);
                    }
                    else if (questionType == "MultipleChoice")
                    {
                        string choiceDesc1 = item.GetAttribute("ChoiceDesc1");
                        string choiceDesc2 = item.GetAttribute("ChoiceDesc2");
                        string choiceDesc3 = item.GetAttribute("ChoiceDesc3");
                        string choiceDesc4 = item.GetAttribute("ChoiceDesc4");
                        bool choiceCorrect1 = Convert.ToBoolean(item.GetAttribute("ChoiceCorrect1"));
                        bool choiceCorrect2 = Convert.ToBoolean(item.GetAttribute("ChoiceCorrect2"));
                        bool choiceCorrect3 = Convert.ToBoolean(item.GetAttribute("ChoiceCorrect3"));
                        bool choiceCorrect4 = Convert.ToBoolean(item.GetAttribute("ChoiceCorrect4"));

                        AnswerMultipleChoice multiplechoiceItem = new AnswerMultipleChoice(question, points, questionType, choiceDesc1, choiceDesc2, choiceDesc3, choiceDesc4, choiceCorrect1, choiceCorrect2, choiceCorrect3, choiceCorrect4);
                        QuizAttempt.Add(multiplechoiceItem);
                    }

                    lbxAnswerQuestionList.Items.Add($"Question {questionNumber}");
                    questionNumber++;
                }
                ViewQuestionIndex(currentAttemptIndex);
            }
        }

        private void btnEditQuiz_Click(object sender, EventArgs e)
        {
            int selectedQuizIndex = lbxQuizList.SelectedIndex;

            if (selectedQuizIndex < 0)
            {
                MessageBox.Show("Please select a quiz.",
                    "No Quiz Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                editState = true;
                pnlLibrary.Visible = false;
                pnlCreate.Visible = true;

                pnlCreate.BringToFront();
                lblCreate.Text = "Edit Quiz";
                lbxQuestionList.Items.Clear();
                Quiz.Clear();

                XmlDocument doc = new();
                doc.Load(path);
                XmlElement rootNode = doc.DocumentElement;

                XmlElement selectedQuiz = (XmlElement)rootNode.ChildNodes[selectedQuizIndex];

                string quizName = selectedQuiz.GetAttribute("QuizName");
                tbxQuizName.Text = quizName;

                foreach (XmlElement item in selectedQuiz.ChildNodes)
                {
                    string questionType = item.GetAttribute("QuestionType");
                    int points = Convert.ToInt32(item.GetAttribute("Points"));
                    string question = item.GetAttribute("Question");

                    if (questionType == "Identification")
                    {
                        string answer = item.GetAttribute("CorrectAnswer");

                        Identification identificationItem = new Identification(question, points, questionType, answer);
                        Quiz.Add(identificationItem);
                    }
                    else if (questionType == "MultipleChoice")
                    {
                        string choiceDesc1 = item.GetAttribute("ChoiceDesc1");
                        string choiceDesc2 = item.GetAttribute("ChoiceDesc2");
                        string choiceDesc3 = item.GetAttribute("ChoiceDesc3");
                        string choiceDesc4 = item.GetAttribute("ChoiceDesc4");
                        bool choiceCorrect1 = Convert.ToBoolean(item.GetAttribute("ChoiceCorrect1"));
                        bool choiceCorrect2 = Convert.ToBoolean(item.GetAttribute("ChoiceCorrect2"));
                        bool choiceCorrect3 = Convert.ToBoolean(item.GetAttribute("ChoiceCorrect3"));
                        bool choiceCorrect4 = Convert.ToBoolean(item.GetAttribute("ChoiceCorrect4"));

                        MultipleChoice multiplechoiceItem = new MultipleChoice(question, points, questionType, choiceDesc1, choiceDesc2, choiceDesc3, choiceDesc4, choiceCorrect1, choiceCorrect2, choiceCorrect3, choiceCorrect4);
                        Quiz.Add(multiplechoiceItem);
                    }
                }
                UpdateQuestionList();
            }
        }

        private void btnDeleteQuiz_Click(object sender, EventArgs e)
        {
            int selectedQuizIndex = lbxQuizList.SelectedIndex;

            if (selectedQuizIndex < 0)
            {
                MessageBox.Show("Please select a quiz.",
                    "No Quiz Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult resultDeleteMessage = MessageBox.Show($"Are you sure you want to delete this Quiz?",
                    "Confirm Quiz Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (resultDeleteMessage == DialogResult.Yes)
                {
                    // Delete Quiz in xml
                    XmlDocument doc = new();
                    doc.Load(path);
                    XmlElement rootNode = doc.DocumentElement;
                    rootNode.RemoveChild(rootNode.ChildNodes[selectedQuizIndex]);
                    doc.Save(path);

                    UpdateQuizList();
                    pnlIdentification.Visible = false;
                    pnlMultiple.Visible = false;

                    MessageBox.Show("Quiz successfully deleted",
                    "Quiz Deleted",
                    MessageBoxButtons.OK);
                }
            }
        }

        private void lblLibrary_Click(object sender, EventArgs e)
        {

        }

        private void lblCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnAddQuiz_Click(object sender, EventArgs e)
        {
            pnlLibrary.Visible = false;
            pnlCreate.Visible = true;
            pnlCreate.BringToFront();
            lblCreate.Text = "Create Quiz";
            Quiz.Clear();
        }

        private void btnAddMultipleChoice_Click(object sender, EventArgs e)
        {
            ViewMultiple();
            MultipleChoice newMultipleChoice = new MultipleChoice();
            newMultipleChoice.questionType = "MultipleChoice";
            Quiz.Add(newMultipleChoice);
            AddMultipleChoiceItem();
            UpdateQuestionList();
        }

        private void btnAddIdentification_Click(object sender, EventArgs e)
        {
            ViewIdentification();
            Identification newIdentification = new Identification();
            newIdentification.questionType = "Identification";
            Quiz.Add(newIdentification);
            AddIdentificationItem();
            UpdateQuestionList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Quiz.Count < 1)
            {
                MessageBox.Show("Add at least one question to be able to save.",
                    "Empty Quiz",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbxQuizName.Text))
                {
                    MessageBox.Show("Please add a quiz title to be able to save.",
                        "Empty Quiz Name",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                foreach (QuizItem item in Quiz)
                {
                    if (string.IsNullOrWhiteSpace(item.question))
                    {
                        MessageBox.Show("All questions must have text to be able to save.",
                            "Empty Question",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if (item.points <= 0)
                    {
                        MessageBox.Show("All questions must have at least one point to be able to save.",
                            "Empty Points",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                    else if (item.questionType == "Identification")
                    {
                        Identification itemIdentification = (Identification)item;
                        if (string.IsNullOrWhiteSpace(itemIdentification.correctAnswer))
                        {
                            MessageBox.Show("All answers for identification questions must have text to be able to save.",
                                "Empty Identification Question Answer",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else if (item.questionType == "MultipleChoice")
                    {
                        MultipleChoice itemMultipleChoice = (MultipleChoice)item;
                        if (itemMultipleChoice.optionCorrect1 == false && itemMultipleChoice.optionCorrect2 == false && itemMultipleChoice.optionCorrect3 == false && itemMultipleChoice.optionCorrect4 == false)
                        {
                            MessageBox.Show("All multiple choice questions must have at least 1 correct answer to be able to save.",
                                "No Correct Answer Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        else if (string.IsNullOrWhiteSpace(itemMultipleChoice.optionDesc1) || string.IsNullOrWhiteSpace(itemMultipleChoice.optionDesc2) || string.IsNullOrWhiteSpace(itemMultipleChoice.optionDesc3) || string.IsNullOrWhiteSpace(itemMultipleChoice.optionDesc4))
                        {
                            MessageBox.Show("All choices for multiple choice questions must have text to be able to save.",
                                "Empty Choice in Multiple Choice Question",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            XmlDocument doc = new();
            doc.Load(path);
            XmlElement rootNode = doc.DocumentElement;

            //Create Quiz Element
            XmlElement quiz = doc.CreateElement("Quiz");
            XmlAttribute quizName = doc.CreateAttribute("QuizName");
            quizName.Value = tbxQuizName.Text;
            quiz.SetAttributeNode(quizName);

            //Create QuizItems
            foreach (QuizItem quizItem in Quiz)
            {
                XmlElement newQuizItem = doc.CreateElement("QuizItem");
                XmlAttribute newQuizQuestion = doc.CreateAttribute("Question");
                XmlAttribute newQuizPoints = doc.CreateAttribute("Points");
                XmlAttribute newQuizQuestionType = doc.CreateAttribute("QuestionType");
                newQuizQuestion.Value = quizItem.question;
                newQuizPoints.Value = quizItem.points.ToString();
                newQuizQuestionType.Value = quizItem.questionType;
                newQuizItem.SetAttributeNode(newQuizQuestion);
                newQuizItem.SetAttributeNode(newQuizPoints);
                newQuizItem.SetAttributeNode(newQuizQuestionType);
                if (quizItem.questionType == "MultipleChoice")
                {
                    MultipleChoice multipleChoiceItem = (MultipleChoice)quizItem;
                    XmlAttribute choiceDesc1 = doc.CreateAttribute("ChoiceDesc1");
                    XmlAttribute choiceDesc2 = doc.CreateAttribute("ChoiceDesc2");
                    XmlAttribute choiceDesc3 = doc.CreateAttribute("ChoiceDesc3");
                    XmlAttribute choiceDesc4 = doc.CreateAttribute("ChoiceDesc4");
                    XmlAttribute choiceCorrect1 = doc.CreateAttribute("ChoiceCorrect1");
                    XmlAttribute choiceCorrect2 = doc.CreateAttribute("ChoiceCorrect2");
                    XmlAttribute choiceCorrect3 = doc.CreateAttribute("ChoiceCorrect3");
                    XmlAttribute choiceCorrect4 = doc.CreateAttribute("ChoiceCorrect4");
                    choiceDesc1.Value = multipleChoiceItem.optionDesc1;
                    choiceDesc2.Value = multipleChoiceItem.optionDesc2;
                    choiceDesc3.Value = multipleChoiceItem.optionDesc3;
                    choiceDesc4.Value = multipleChoiceItem.optionDesc4;
                    choiceCorrect1.Value = multipleChoiceItem.optionCorrect1.ToString();
                    choiceCorrect2.Value = multipleChoiceItem.optionCorrect2.ToString();
                    choiceCorrect3.Value = multipleChoiceItem.optionCorrect3.ToString();
                    choiceCorrect4.Value = multipleChoiceItem.optionCorrect4.ToString();
                    newQuizItem.SetAttributeNode(choiceDesc1);
                    newQuizItem.SetAttributeNode(choiceDesc2);
                    newQuizItem.SetAttributeNode(choiceDesc3);
                    newQuizItem.SetAttributeNode(choiceDesc4);
                    newQuizItem.SetAttributeNode(choiceCorrect1);
                    newQuizItem.SetAttributeNode(choiceCorrect2);
                    newQuizItem.SetAttributeNode(choiceCorrect3);
                    newQuizItem.SetAttributeNode(choiceCorrect4);
                }
                else
                {
                    Identification identificationItem = (Identification)quizItem;
                    XmlAttribute correctAnswer = doc.CreateAttribute("CorrectAnswer");
                    correctAnswer.Value = identificationItem.correctAnswer;
                    newQuizItem.SetAttributeNode(correctAnswer);
                }
                quiz.AppendChild(newQuizItem);
            }

            if (editState == false)
            {
                rootNode.AppendChild(quiz);
            }
            else
            {
                // If the user is editing a quiz, overwrite the previous one's xml with the edits
                int selectedQuizIndex = lbxQuizList.SelectedIndex;
                XmlElement quizToEdit = (XmlElement)rootNode.ChildNodes[selectedQuizIndex];

                rootNode.ReplaceChild(quiz, quizToEdit);
                editState = false;
            }


            doc.Save(path);
            UpdateQuizList();

            pnlMultiple.Visible = false;
            pnlIdentification.Visible = false;
            tbxQuizName.Clear();
            lbxQuestionList.Items.Clear();
            MessageBox.Show("Quiz successfully saved",
                "Quiz Saved",
                MessageBoxButtons.OK);
        }

        private void btnBackToLibrary1_Click(object sender, EventArgs e)
        {
            if (editState == true)
            {
                MessageBox.Show("Save your edits to the Quiz first before returning to Library.",
                "Unsaved Changes Detected",
                MessageBoxButtons.OK);
            }
            else
            {
                pnlMultiple.Visible = false;
                pnlLibrary.Visible = true;
                pnlLibrary.BringToFront();
            }

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
            int currentQuestionIndex = Convert.ToInt32(tbxIdentificationNumber.Text) - 1;
            if (nudIdentificationPoints.Value != 0)
            {
                Quiz[currentQuestionIndex].points = (int)nudIdentificationPoints.Value;
            }
        }

        private void tbxIdentificationQuestion_TextChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxIdentificationNumber.Text) - 1;
            if (!string.IsNullOrWhiteSpace(tbxIdentificationQuestion.Text))
            {
                Quiz[currentQuestionIndex].question = tbxIdentificationQuestion.Text;
            }
        }

        private void tbxIdentificationAnswer_TextChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxIdentificationNumber.Text) - 1;
            if (!string.IsNullOrWhiteSpace(tbxIdentificationAnswer.Text))
            {
                Identification currentQuestion = (Identification)Quiz[currentQuestionIndex];
                currentQuestion.correctAnswer = tbxIdentificationAnswer.Text;
            }
        }

        private void tbxMultipleNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudMultiplePoints_ValueChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxMultipleNumber.Text) - 1;
            if (nudMultiplePoints.Value != 0)
            {
                Quiz[currentQuestionIndex].points = (int)nudMultiplePoints.Value;
            }
        }

        private void tbxMultipleQuestion_TextChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxMultipleNumber.Text) - 1;
            if (!string.IsNullOrWhiteSpace(tbxMultipleQuestion.Text))
            {
                Quiz[currentQuestionIndex].question = tbxMultipleQuestion.Text;
            }
        }

        private void cbxMultipleOption1_CheckedChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxMultipleNumber.Text) - 1;
            MultipleChoice currentQuestion = (MultipleChoice)Quiz[currentQuestionIndex];
            if (cbxMultipleOption1.Checked)
            {
                currentQuestion.optionCorrect1 = true;
            }
            else
            {
                currentQuestion.optionCorrect1 = false;
            }
        }

        private void cbxMultipleOption2_CheckedChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxMultipleNumber.Text) - 1;
            MultipleChoice currentQuestion = (MultipleChoice)Quiz[currentQuestionIndex];
            if (cbxMultipleOption2.Checked)
            {
                currentQuestion.optionCorrect2 = true;
            }
            else
            {
                currentQuestion.optionCorrect2 = false;
            }

        }

        private void cbxMultipleOption3_CheckedChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxMultipleNumber.Text) - 1;
            MultipleChoice currentQuestion = (MultipleChoice)Quiz[currentQuestionIndex];
            if (cbxMultipleOption3.Checked)
            {
                currentQuestion.optionCorrect3 = true;
            }
            else
            {
                currentQuestion.optionCorrect3 = false;
            }
        }

        private void cbxMultipleOption4_CheckedChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxMultipleNumber.Text) - 1;
            MultipleChoice currentQuestion = (MultipleChoice)Quiz[currentQuestionIndex];
            if (cbxMultipleOption4.Checked)
            {
                currentQuestion.optionCorrect4 = true;
            }
            else
            {
                currentQuestion.optionCorrect4 = false;
            }
        }

        private void tbxMultipleOption1_TextChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxMultipleNumber.Text) - 1;
            if (!string.IsNullOrWhiteSpace(tbxMultipleOption1.Text))
            {
                MultipleChoice currentQuestion = (MultipleChoice)Quiz[currentQuestionIndex];
                currentQuestion.optionDesc1 = tbxMultipleOption1.Text;
            }
        }

        private void tbxMultipleOption2_TextChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxMultipleNumber.Text) - 1;
            if (!string.IsNullOrWhiteSpace(tbxMultipleOption2.Text))
            {
                MultipleChoice currentQuestion = (MultipleChoice)Quiz[currentQuestionIndex];
                currentQuestion.optionDesc2 = tbxMultipleOption2.Text;
            }
        }

        private void tbxMultipleOption3_TextChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxMultipleNumber.Text) - 1;
            if (!string.IsNullOrWhiteSpace(tbxMultipleOption3.Text))
            {
                MultipleChoice currentQuestion = (MultipleChoice)Quiz[currentQuestionIndex];
                currentQuestion.optionDesc3 = tbxMultipleOption3.Text;
            }
        }

        private void tbxMultipleOption4_TextChanged(object sender, EventArgs e)
        {
            int currentQuestionIndex = Convert.ToInt32(tbxMultipleNumber.Text) - 1;
            if (!string.IsNullOrWhiteSpace(tbxMultipleOption4.Text))
            {
                MultipleChoice currentQuestion = (MultipleChoice)Quiz[currentQuestionIndex];
                currentQuestion.optionDesc4 = tbxMultipleOption4.Text;
            }
        }

        private void btnViewQuestion_Click(object sender, EventArgs e)
        {
            int selectedQuestionIndex = lbxQuestionList.SelectedIndex;

            if (selectedQuestionIndex < 0)
            {
                MessageBox.Show("Please select a question.",
                    "No Question Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                QuizItem selectedQuestion = Quiz[selectedQuestionIndex];

                if (selectedQuestion.questionType == "Identification")
                {
                    ViewIdentification();
                    Identification selectedIdentification = (Identification)selectedQuestion;
                    tbxIdentificationNumber.Text = (selectedQuestionIndex + 1).ToString();
                    tbxIdentificationQuestion.Text = selectedIdentification.question;
                    tbxIdentificationAnswer.Text = selectedIdentification.correctAnswer;
                    nudIdentificationPoints.Value = selectedIdentification.points;
                }
                else if (selectedQuestion.questionType == "MultipleChoice")
                {
                    ViewMultiple();
                    MultipleChoice selectedMultiple = (MultipleChoice)selectedQuestion;
                    tbxMultipleNumber.Text = (selectedQuestionIndex + 1).ToString();
                    tbxMultipleQuestion.Text = selectedMultiple.question;
                    nudMultiplePoints.Value = selectedMultiple.points;

                    tbxMultipleOption1.Text = selectedMultiple.optionDesc1;
                    tbxMultipleOption2.Text = selectedMultiple.optionDesc2;
                    tbxMultipleOption3.Text = selectedMultiple.optionDesc3;
                    tbxMultipleOption4.Text = selectedMultiple.optionDesc4;

                    cbxMultipleOption1.Checked = selectedMultiple.optionCorrect1;
                    cbxMultipleOption2.Checked = selectedMultiple.optionCorrect2;
                    cbxMultipleOption3.Checked = selectedMultiple.optionCorrect3;
                    cbxMultipleOption4.Checked = selectedMultiple.optionCorrect4;
                }
            }
        }

        private void btnDeleteQuestion_Click_1(object sender, EventArgs e)
        {
            int selectedQuestionIndex = lbxQuestionList.SelectedIndex;

            if (selectedQuestionIndex < 0)
            {
                MessageBox.Show("Please select a question.",
                    "No Question Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult resultDeleteMessage = MessageBox.Show($"Are you sure you want to delete Question {selectedQuestionIndex + 1}?",
                    "Confirm Question Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (resultDeleteMessage == DialogResult.Yes)
                {
                    Quiz.RemoveAt(selectedQuestionIndex);
                    UpdateQuestionList();
                    pnlIdentification.Visible = false;
                    pnlMultiple.Visible = false;

                    MessageBox.Show("Question successfully deleted",
                    "Question Deleted",
                    MessageBoxButtons.OK);
                }
            }
        }

        private void lblCreate1_Click(object sender, EventArgs e)
        {

        }

        private void lbxAnswerQuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnswerQuestionJumpTo_Click(object sender, EventArgs e)
        {
            int selectedQuestionIndex = lbxAnswerQuestionList.SelectedIndex;

            if (selectedQuestionIndex < 0)
            {
                MessageBox.Show("Please select a question.", "No Question Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int selectedIndex = lbxAnswerQuestionList.SelectedIndex;
                ViewQuestionIndex(selectedIndex);
                currentAttemptIndex = selectedIndex;
            }
        }

        private void btnAnswerSubmit_Click(object sender, EventArgs e)
        {
            bool validSubmission = true;
            foreach (QuizItem attemptItem in QuizAttempt)
            {
                if (attemptItem.questionType == "MultipleChoice")
                {
                    AnswerMultipleChoice multipleItem = (AnswerMultipleChoice)attemptItem;
                    if (!(multipleItem.optionSelected1 || multipleItem.optionSelected2 || multipleItem.optionSelected3 || multipleItem.optionSelected4))
                    {
                        validSubmission = false;
                    }
                }
                else
                {
                    AnswerIdentification identificationItem = (AnswerIdentification)attemptItem;
                    if (string.IsNullOrEmpty(identificationItem.inputtedAnswer))
                    {
                        validSubmission = false;
                    }
                }
            }
            if (validSubmission)
            {
                // XML Stuff
                XmlDocument doc = new();
                doc.Load(pathAttempts);
                XmlElement rootNode = doc.DocumentElement;

                //Create Attempt Element
                XmlElement attempt = doc.CreateElement("Attempt");
                XmlAttribute quizName = doc.CreateAttribute("QuizName");
                quizName.Value = QuizAnsweredName;
                attempt.SetAttributeNode(quizName);

                foreach (QuizItem item in QuizAttempt)
                {
                    XmlElement attemptItem = doc.CreateElement("AttemptItem");
                    XmlAttribute question = doc.CreateAttribute("Question");
                    question.Value = item.question;
                    XmlAttribute points = doc.CreateAttribute("Points");
                    points.Value = item.points.ToString();
                    XmlAttribute questionType = doc.CreateAttribute("QuestionType");
                    questionType.Value = item.questionType;
                    attemptItem.SetAttributeNode(question);
                    attemptItem.SetAttributeNode(points);
                    attemptItem.SetAttributeNode(questionType);
                    if (item.questionType == "MultipleChoice")
                    {
                        AnswerMultipleChoice multipleChoiceItem = (AnswerMultipleChoice)item;
                        XmlAttribute choiceDesc1 = doc.CreateAttribute("ChoiceDesc1");
                        XmlAttribute choiceDesc2 = doc.CreateAttribute("ChoiceDesc2");
                        XmlAttribute choiceDesc3 = doc.CreateAttribute("ChoiceDesc3");
                        XmlAttribute choiceDesc4 = doc.CreateAttribute("ChoiceDesc4");
                        XmlAttribute choiceCorrect1 = doc.CreateAttribute("ChoiceCorrect1");
                        XmlAttribute choiceCorrect2 = doc.CreateAttribute("ChoiceCorrect2");
                        XmlAttribute choiceCorrect3 = doc.CreateAttribute("ChoiceCorrect3");
                        XmlAttribute choiceCorrect4 = doc.CreateAttribute("ChoiceCorrect4");
                        XmlAttribute choiceSelected1 = doc.CreateAttribute("ChoiceSelected1");
                        XmlAttribute choiceSelected2 = doc.CreateAttribute("ChoiceSelected2");
                        XmlAttribute choiceSelected3 = doc.CreateAttribute("ChoiceSelected3");
                        XmlAttribute choiceSelected4 = doc.CreateAttribute("ChoiceSelected4");
                        choiceDesc1.Value = multipleChoiceItem.optionDesc1;
                        choiceDesc2.Value = multipleChoiceItem.optionDesc2;
                        choiceDesc3.Value = multipleChoiceItem.optionDesc3;
                        choiceDesc4.Value = multipleChoiceItem.optionDesc4;
                        choiceCorrect1.Value = multipleChoiceItem.optionCorrect1.ToString();
                        choiceCorrect2.Value = multipleChoiceItem.optionCorrect2.ToString();
                        choiceCorrect3.Value = multipleChoiceItem.optionCorrect3.ToString();
                        choiceCorrect4.Value = multipleChoiceItem.optionCorrect4.ToString();
                        choiceSelected1.Value = multipleChoiceItem.optionSelected1.ToString();
                        choiceSelected2.Value = multipleChoiceItem.optionSelected2.ToString();
                        choiceSelected3.Value = multipleChoiceItem.optionSelected3.ToString();
                        choiceSelected4.Value = multipleChoiceItem.optionSelected4.ToString();
                        attemptItem.SetAttributeNode(choiceDesc1);
                        attemptItem.SetAttributeNode(choiceDesc2);
                        attemptItem.SetAttributeNode(choiceDesc3);
                        attemptItem.SetAttributeNode(choiceDesc4);
                        attemptItem.SetAttributeNode(choiceCorrect1);
                        attemptItem.SetAttributeNode(choiceCorrect2);
                        attemptItem.SetAttributeNode(choiceCorrect3);
                        attemptItem.SetAttributeNode(choiceCorrect4);
                        attemptItem.SetAttributeNode(choiceSelected1);
                        attemptItem.SetAttributeNode(choiceSelected2);
                        attemptItem.SetAttributeNode(choiceSelected3);
                        attemptItem.SetAttributeNode(choiceSelected4);
                    }
                    else
                    {
                        AnswerIdentification identificationItem = (AnswerIdentification)item;
                        XmlAttribute correctAnswer = doc.CreateAttribute("CorrectAnswer");
                        XmlAttribute inputtedAnswer = doc.CreateAttribute("InputtedAnswer");
                        correctAnswer.Value = identificationItem.correctAnswer;
                        inputtedAnswer.Value = identificationItem.inputtedAnswer;
                        attemptItem.SetAttributeNode(correctAnswer);
                        attemptItem.SetAttributeNode(inputtedAnswer);
                    }
                    attempt.AppendChild(attemptItem);
                }
                rootNode.AppendChild(attempt);
                doc.Save(pathAttempts);

                QuizAttempt.Clear();
                tbxAnswerQuizName.Clear();
                tbxAnswerQuestion.Clear();
                tbxAnswerQuestionNumber.Clear();
                tbxAnswerQuestionPoints.Clear();
                tbxAnswerIdentification.Clear();
                lbxAnswerQuestionList.Items.Clear();
                pnlAnswer.Visible = false;
                pnlLibrary.Visible = true;
            }
            else
            {
                MessageBox.Show("Provide an answer to all questions.", "Missing Answers.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAnswerNext_Click(object sender, EventArgs e)
        {
            if (currentAttemptIndex < QuizAttempt.Count())
            {
                currentAttemptIndex++;
                ViewQuestionIndex(currentAttemptIndex);
            }
        }

        private void btnAnswerPrevious_Click(object sender, EventArgs e)
        {
            if (currentAttemptIndex > 0)
            {
                currentAttemptIndex--;
                ViewQuestionIndex(currentAttemptIndex);
            }
        }

        private void lblAnswerQuizName_Click(object sender, EventArgs e)
        {

        }

        private void lblAnswerQuestion_Click(object sender, EventArgs e)
        {

        }

        private void tbxAnswerQuestionNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxAnswerQuestionPoints_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxAnswerQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlAnswerQuestion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAnswerIdentification_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAnswerMultiple_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxAnswerChoice1_CheckedChanged(object sender, EventArgs e)
        {
            QuizItem attemptItem = QuizAttempt[currentAttemptIndex];
            if (attemptItem.questionType == "MultipleChoice")
            {
                AnswerMultipleChoice currentQuestion = (AnswerMultipleChoice)attemptItem;
                if (cbxAnswerChoice1.Checked)
                {
                    currentQuestion.optionSelected1 = true;
                }
                else
                {
                    currentQuestion.optionSelected1 = false;
                }
            }

        }

        private void cbxAnswerChoice2_CheckedChanged(object sender, EventArgs e)
        {
            QuizItem attemptItem = QuizAttempt[currentAttemptIndex];
            if (attemptItem.questionType == "MultipleChoice")
            {
                AnswerMultipleChoice currentQuestion = (AnswerMultipleChoice)attemptItem;
                if (cbxAnswerChoice2.Checked)
                {
                    currentQuestion.optionSelected2 = true;
                }
                else
                {
                    currentQuestion.optionSelected2 = false;
                }
            }
        }

        private void cbxAnswerChoice3_CheckedChanged(object sender, EventArgs e)
        {
            QuizItem attemptItem = QuizAttempt[currentAttemptIndex];
            if (attemptItem.questionType == "MultipleChoice")
            {
                AnswerMultipleChoice currentQuestion = (AnswerMultipleChoice)attemptItem;
                if (cbxAnswerChoice3.Checked)
                {
                    currentQuestion.optionSelected3 = true;
                }
                else
                {
                    currentQuestion.optionSelected3 = false;
                }
            }
        }
        private void cbxAnswerChoice4_CheckedChanged(object sender, EventArgs e)
        {
            QuizItem attemptItem = QuizAttempt[currentAttemptIndex];
            if (attemptItem.questionType == "MultipleChoice")
            {
                AnswerMultipleChoice currentQuestion = (AnswerMultipleChoice)attemptItem;
                if (cbxAnswerChoice4.Checked)
                {
                    currentQuestion.optionSelected4 = true;
                }
                else
                {
                    currentQuestion.optionSelected4 = false;
                }
            }
        }

        private void tbxAnswerIdentification_TextChanged(object sender, EventArgs e)
        {
            if (-1 < currentAttemptIndex && currentAttemptIndex < QuizAttempt.Count())
            {
                QuizItem attemptItem = QuizAttempt[currentAttemptIndex];
                if (currentAttemptIndex < QuizAttempt.Count() && attemptItem.questionType == "Identification")
                {
                    AnswerIdentification currentQuestion = (AnswerIdentification)attemptItem;
                    if (!string.IsNullOrWhiteSpace(tbxAnswerIdentification.Text))
                    {
                        currentQuestion.inputtedAnswer = tbxAnswerIdentification.Text;
                    }
                }
            }
        }

        private void pnlAnswer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxAnswerQuizName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnViewAttemptFromList_Click(object sender, EventArgs e)
        {
            int selectedAttemptIndex = -1;

            if (lsvAttemptList.SelectedItems.Count > 0)
            {
                selectedAttemptIndex= lsvAttemptList.SelectedItems[0].Index;
            }
                
            
            if (selectedAttemptIndex < 0)
            {
                MessageBox.Show("Please select an attempt to view.",
                    "No Attempt Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {

            }
        }

        private void btnBackToLibraryAttempts_Click(object sender, EventArgs e)
        {
            pnlAttempts.Visible = false;
            pnlLibrary.Visible = true;
            pnlLibrary.BringToFront();
        }


        private void lbxAttemptList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlAttempts_Paint(object sender, PaintEventArgs e)
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
        public MultipleChoice(String question, int points, String questionType, String optionDesc1, String optionDesc2, String optionDesc3, String optionDesc4, bool optionCorrect1, bool optionCorrect2, bool optionCorrect3, bool optionCorrect4)
        {
            this.question = question;
            this.points = points;
            this.questionType = questionType;
            this.optionDesc1 = optionDesc1;
            this.optionDesc2 = optionDesc2;
            this.optionDesc3 = optionDesc3;
            this.optionDesc4 = optionDesc4;
            this.optionCorrect1 = optionCorrect1;
            this.optionCorrect2 = optionCorrect2;
            this.optionCorrect3 = optionCorrect3;
            this.optionCorrect4 = optionCorrect4;
        }
    }
    public class AnswerIdentification : Identification
    {
        public String inputtedAnswer = "";
        public AnswerIdentification() {}
        public AnswerIdentification(String question, int points, String questionType, String correctAnswer)
        {
            this.question = question;
            this.points = points;
            this.questionType = questionType;
            this.correctAnswer = correctAnswer;
        }
    }
    public class AnswerMultipleChoice : MultipleChoice
    {
        public bool optionSelected1 = false;
        public bool optionSelected2 = false;
        public bool optionSelected3 = false;
        public bool optionSelected4 = false;
        public AnswerMultipleChoice() {}
        public AnswerMultipleChoice(String question, int points, String questionType, String optionDesc1, String optionDesc2, String optionDesc3, String optionDesc4, bool optionCorrect1, bool optionCorrect2, bool optionCorrect3, bool optionCorrect4)
        {
            this.question = question;
            this.points = points;
            this.questionType = questionType;
            this.optionDesc1 = optionDesc1;
            this.optionDesc2 = optionDesc2;
            this.optionDesc3 = optionDesc3;
            this.optionDesc4 = optionDesc4;
            this.optionCorrect1 = optionCorrect1;
            this.optionCorrect2 = optionCorrect2;
            this.optionCorrect3 = optionCorrect3;
            this.optionCorrect4 = optionCorrect4;
        }
    }
}
