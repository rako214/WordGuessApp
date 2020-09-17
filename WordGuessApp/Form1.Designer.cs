namespace WordGuessApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxGuessWord = new System.Windows.Forms.TextBox();
            this.labelGuess = new System.Windows.Forms.Label();
            this.buttonSendAnswer = new System.Windows.Forms.Button();
            this.richTextBoxHistory = new System.Windows.Forms.RichTextBox();
            this.buttonSetPuzzleWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGuessWord
            // 
            this.textBoxGuessWord.Location = new System.Drawing.Point(132, 79);
            this.textBoxGuessWord.Name = "textBoxGuessWord";
            this.textBoxGuessWord.Size = new System.Drawing.Size(198, 20);
            this.textBoxGuessWord.TabIndex = 0;
            this.textBoxGuessWord.TextChanged += new System.EventHandler(this.textBoxGuessWord_TextChanged);
            this.textBoxGuessWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGuessWord_KeyDown);
            // 
            // labelGuess
            // 
            this.labelGuess.AutoSize = true;
            this.labelGuess.Location = new System.Drawing.Point(43, 79);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(71, 13);
            this.labelGuess.TabIndex = 1;
            this.labelGuess.Text = "Я думаю это";
            // 
            // buttonSendAnswer
            // 
            this.buttonSendAnswer.Location = new System.Drawing.Point(373, 77);
            this.buttonSendAnswer.Name = "buttonSendAnswer";
            this.buttonSendAnswer.Size = new System.Drawing.Size(75, 22);
            this.buttonSendAnswer.TabIndex = 2;
            this.buttonSendAnswer.Text = "Отправить";
            this.buttonSendAnswer.UseVisualStyleBackColor = true;
            this.buttonSendAnswer.Click += new System.EventHandler(this.buttonSendAnswer_Click);
            // 
            // richTextBoxHistory
            // 
            this.richTextBoxHistory.Location = new System.Drawing.Point(132, 147);
            this.richTextBoxHistory.Name = "richTextBoxHistory";
            this.richTextBoxHistory.Size = new System.Drawing.Size(198, 213);
            this.richTextBoxHistory.TabIndex = 3;
            this.richTextBoxHistory.Text = "";
            this.richTextBoxHistory.VScroll += new System.EventHandler(this.textBoxGuessWord_TextChanged);
            // 
            // buttonSetPuzzleWord
            // 
            this.buttonSetPuzzleWord.Location = new System.Drawing.Point(132, 12);
            this.buttonSetPuzzleWord.Name = "buttonSetPuzzleWord";
            this.buttonSetPuzzleWord.Size = new System.Drawing.Size(198, 28);
            this.buttonSetPuzzleWord.TabIndex = 4;
            this.buttonSetPuzzleWord.Text = "Загадать слово";
            this.buttonSetPuzzleWord.UseVisualStyleBackColor = true;
            this.buttonSetPuzzleWord.Click += new System.EventHandler(this.buttonSetPuzzleWord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 391);
            this.Controls.Add(this.buttonSetPuzzleWord);
            this.Controls.Add(this.richTextBoxHistory);
            this.Controls.Add(this.buttonSendAnswer);
            this.Controls.Add(this.labelGuess);
            this.Controls.Add(this.textBoxGuessWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGuessWord;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.Button buttonSendAnswer;
        private System.Windows.Forms.RichTextBox richTextBoxHistory;
        private System.Windows.Forms.Button buttonSetPuzzleWord;
    }
}

