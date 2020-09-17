using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace WordGuessApp
{
    public partial class Form1 : Form
    {
        //Массив загаданных слов
        static readonly string[] words = new string[] { "кошка", "огонь", "стул", "велосипед", "глагол", "солнце", "гора", "волна", "вода", "ветер", "воздух", "музыка", "еда" };
        //Загаданное слово
        private string setWord;
        //Счётчик попыток
        private int tryCounter = 0;
        //Счётчик подсказываемых букв
        private int charCounter = 0;
        //Рандом для выбора случайной подсказки
        Random randomHintNumber = new Random();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonSendAnswer_Click(object sender, EventArgs e)
        {
            //Обновляем цвет в случае победы
            richTextBoxHistory.BackColor = Color.White;

            //Читаем введённое слово
            string wordCompare = textBoxGuessWord.Text;
            
            //Проверяем наличие загаданного слова, если нет, загадываем автоматически
            if (setWord == null)
            {
                buttonSetPuzzleWord.PerformClick();
            }

            //Приводим к общему виду для сравнения
            wordCompare = wordCompare.ToLower();
            wordCompare = wordCompare.Replace(" ", "");

            //Сравниваем слова
            bool result = CheckWord(wordCompare, setWord);

            //Выводим вариант игрока
            richTextBoxHistory.Text += $"Вы: {textBoxGuessWord.Text}\n";

            //Если игрок угадал
            if (result)
            {
                //Задаём зелёный фон
                richTextBoxHistory.BackColor = Color.LightGreen;
                richTextBoxHistory.Text += "Верно! Поиграем ещё? Я загадал новое слово!\n";
                setWord = SetPuzzleWord();
            }
            //Если игрок не угадал
            else
            {
                tryCounter++;
                richTextBoxHistory.Text += "Нет, не то слово\n";
                if (tryCounter > 3)
                {
                    //Задаём номер подсказки
                    int hintNumber = randomHintNumber.Next(1, 3);

                    switch (hintNumber)
                    {
                        case 1:
                            //Сравниваем слова по длинне
                            if(wordCompare.Length > setWord.Length)
                            {

                                richTextBoxHistory.Text += "Окей, загаданное слово короче...\n";
                            }
                            else if (wordCompare.Length == setWord.Length)
                            {
                                richTextBoxHistory.Text += "Окей, загаданное слово такой же длинны...\n";
                            }
                            else
                            {
                                richTextBoxHistory.Text += "Окей, загаданное слово длиннее...\n";
                            }
                            break;
                        case 2:
                            for (int i = charCounter; i < setWord.Length; )
                            {
                                //Подсказываем первую букву
                                if (i == 0)
                                {
                                    richTextBoxHistory.Text += $"Подсказка: первая буква - {setWord.Substring(i, 1)}\n";
                                    charCounter++;
                                    break;
                                }
                                //Подсказываем слудующие буквы
                                else
                                {
                                    richTextBoxHistory.Text += $"Лааадно, добавляем буквы... - {setWord.Substring(0, i+1)}\n";
                                    charCounter++;
                                    break;
                                }
                            }
                            break;
                    }
                }
            }
            //Очищаем поле ввода
            textBoxGuessWord.Clear();
        }

        private void textBoxGuessWord_TextChanged(object sender, EventArgs e)
        {
        }

 
            //Метод для сравнения строк
            public static bool CheckWord(string wordAnswer, string wordPuzzle)
            {
                if (wordAnswer == wordPuzzle)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

 
        //Загадывание случайного слова из массива
        private static string SetPuzzleWord() {
            Random randomNumber = new Random();
            int wordIndex = randomNumber.Next(0, words.Length);
            return words[wordIndex];
        }

        private void buttonSetPuzzleWord_Click(object sender, EventArgs e)
        {
            setWord = SetPuzzleWord();
        }
        /// <summary>
        /// По нажатию на Enter нажимаем на кнопку "Отправить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxGuessWord_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonSendAnswer.PerformClick();
            }
        }
    }


}
