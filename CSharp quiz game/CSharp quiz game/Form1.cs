using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_quiz_game
{
    public partial class Form1 : Form
    {

        // Variáveis do jogo
        int correctAnswer, questionNumber = 1, score = 0, percentage, totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 7;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }
            if(questionNumber == totalQuestions)
            {
                // Aqui vai aparecer a porcentagem de acertos

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);


                MessageBox.Show(
                    "O quiz chegou ao fim!" + Environment.NewLine + 
                    "Você acertou corretamente " + score + " questões" + Environment.NewLine +
                    "Sua porcentagem de acertos foi de: " + percentage + "%" + Environment.NewLine +
                    "Clique em OK para jogar novamente."

                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }


            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int numQuest) // Método que mostrará corretamente na tela a image, label e buttons referentes a cada pergunta.
        {
            switch (questionNumber)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.imgImprimir; // "img.Imprimir é o nome da imagem"

                    lblQuestion.Text = "Questão 1";

                    // Cada um desses botões possue uma tag(1,2,3,4)
                    button1.Text = "Console.WriteText()"; 
                    button2.Text = "WriteLine()";
                    button3.Text = "Console.WriteLine()";
                    button4.Text = "Console.TextLine()";

                    // A resposta correta é a 3, logo, o botão com tag 3.
                    correctAnswer = 3;
                    
                    break;
                case 2:

                    pictureBox1.Image = Properties.Resources.imgLer; // "img.... é o nome da imagem"

                    lblQuestion.Text = "Questão 2";

                    // Cada um desses botões possue uma tag(1,2,3,4)
                    button1.Text = "Console.ReadText()";
                    button2.Text = "ReadLine()";
                    button3.Text = "Console.WriteLine()";
                    button4.Text = "Console.ReadLine()";

                    // A resposta correta é a 4, logo, o botão com tag 4.
                    correctAnswer = 4;

                    break;
                case 3:

                    pictureBox1.Image = Properties.Resources.imgDeclaraConst; // "img.... é o nome da imagem"

                    lblQuestion.Text = "Questão 3";

                    // Cada um desses botões possue uma tag(1,2,3,4)
                    button1.Text = "def constante = NOME_DA_CONST";
                    button2.Text = "const int NOME_DA_CONST";
                    button3.Text = "#define constant = NOME_DA_CONST";
                    button4.Text = "int const NOME_DA_CONST";
                    
                    correctAnswer = 2;

                    break;
                case 4:
                    
                    pictureBox1.Image = Properties.Resources.imgCriarClass; // "img.... é o nome da imagem"
                    lblQuestion.Text = "Questão 4";

                    // Cada um desses botões possue uma tag(1,2,3,4)
                    button1.Text = "create class NomeDaClass";
                    button2.Text = "definirTipo class NomeDaClass()";                    
                    button3.Text = "visibilidade class NomeDaClass()";
                    button4.Text = "visibilidade class NomeDaClass";
                    
                    correctAnswer = 4;

                    break;
                case 5:

                    pictureBox1.Image = Properties.Resources.imgVisibClass; // "img.... é o nome da imagem"
                    lblQuestion.Text = "Questão 5";

                    // Cada um desses botões possue uma tag(1,2,3,4)
                    button1.Text = "public, private, static";
                    button2.Text = "int, double, char";
                    button3.Text = "define,main, void";
                    button4.Text = "private, void, long";
                    
                    correctAnswer = 1;

                    break;
                case 6:

                    pictureBox1.Image = Properties.Resources.imgCriarMet; // "img.... é o nome da imagem"

                    lblQuestion.Text = "Questão 6";

                    // Cada um desses botões possue uma tag(1,2,3,4)
                    button1.Text = "tipoDoMet NomeDoMet(param)";
                    button2.Text = "visibilidade met NomeDoMet";
                    button3.Text = "visibilidade NomeDoMet()";
                    button4.Text = "class NomeDoMet()";
                    
                    correctAnswer = 1;

                    break;

                case 7:
                    
                    pictureBox1.Image = Properties.Resources.imgInstObj; // "img.... é o nome da imagem"

                    lblQuestion.Text = "Questão 7";

                    // Cada um desses botões possue uma tag(1,2,3,4)
                    button1.Text = "objectName ClassName = new tipo;";
                    button2.Text = "ClassName objectName = new ClassName(); ";
                    button3.Text = "tipo objectName();";
                    button4.Text = "ClassName tipo objectName = new ClassName;";
                    
                    correctAnswer = 2;

                    break;

            }
        }

    }
}
                    