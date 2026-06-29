using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Words
{
    public partial class FormPlay : Form
    {
        int cellSize { get; }
        Difficulty levelDifficulty { get; }
        Language receivedLanguage { get; }
        Word rightWord;
        int currentRow = 0;
        
        public FormPlay(Language language, Difficulty difficulty)
        {
            InitializeComponent();
            receivedLanguage = language;
            levelDifficulty = difficulty;
            cellSize = GetCellSize();
            ApplyLanguage(receivedLanguage);
        }

        int GetCellSize()
        {
            if (levelDifficulty == Difficulty.Easy) 
                return 3;
            else if (levelDifficulty == Difficulty.Medium) 
                return 4;
            else 
                return 5;
        }

        private void ApplyLanguage(Language language)
        {
            if (language == Language.Ossetian)
            {
                labelName.Text = "5 Дзырды";
                labelName.Location = new Point(145, 3);
            }
            else
            {
                labelName.Text = "5 букв";
                labelName.Location = new Point(169, 3);
            }
        }

        public FormPlay()
        {
            InitializeComponent();
        }

        private void FormPlay_Load(object sender, EventArgs e)
        {
            rightWord = RightWord();
            Field();
            EditRow();
            //MessageBox.Show(rightWord.Text);
        }

        Word RightWord()
        {
            WordsRepository repository = new WordsRepository();
            Word word = repository.GetRandomWord(levelDifficulty, receivedLanguage);
            return word;
        }

        void EditRow()
        {
            for( int i = 0; i < dataGridViewField.Rows.Count; i++)
            {
                if (i != currentRow) dataGridViewField.Rows[i].ReadOnly = true;
            }
        }

        private void Field()
        {
            dataGridViewField.Width = cellSize * 70 + 2;
            dataGridViewField.Height = 352;
            dataGridViewField.Location = new Point(135 - (int)levelDifficulty * 35, 70);

            for (int i = 0; i < cellSize; i++)
            {
                dataGridViewField.Columns.Add(new DataGridViewTextBoxColumn { Width = 70 });
            }

            dataGridViewField.Rows.Add(5);

            foreach (DataGridViewRow row in dataGridViewField.Rows)
            {
                row.Height = 70;
            }

        }

        private void dataGridViewField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'ё' || e.KeyChar == 'Ё')
            {
                dataGridViewField.CurrentCell.Style.Font = new Font("Impact", 20, FontStyle.Bold);
                dataGridViewField.CurrentCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewField.CurrentCell.Value = "æ".ToUpper();

                MoveToNextCell();
            }
            else if (IsCyrillicChar(e.KeyChar))
            {
                dataGridViewField.CurrentCell.Style.Font = new Font("Impact", 20, FontStyle.Bold);
                dataGridViewField.CurrentCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewField.CurrentCell.Value = e.KeyChar.ToString().ToUpper();

                MoveToNextCell();
            }
            e.Handled = true;
        }

        bool IsCyrillicChar(char c)
        {
            return (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я');
        }

        void MoveToNextCell()
        {
            int nextCol = dataGridViewField.CurrentCell.ColumnIndex + 1;

            if (nextCol >= dataGridViewField.ColumnCount)
            {
                nextCol = dataGridViewField.ColumnCount - 1;
            }

            dataGridViewField.CurrentCell = dataGridViewField[nextCol, currentRow];
        }

        private void dataGridViewField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && IsRowFull())
            {
                CheckWord();
                if (currentRow <= 3) currentRow++;
                else
                {
                    MessageBox.Show($"Вы не угадали\nБыло загадно слово: {rightWord.Text}");
                    Final();
                }
                dataGridViewField.CurrentCell = dataGridViewField[0, currentRow];
                EditRow();
            }
            e.Handled = true;

            if (e.KeyCode == Keys.Back)
            {
                dataGridViewField.CurrentCell.Value = null;
                if (dataGridViewField.CurrentCell.ColumnIndex > 0)
                    dataGridViewField.CurrentCell = dataGridViewField[dataGridViewField.CurrentCell.ColumnIndex - 1, currentRow];
            }
        }

        bool IsRowFull()
        {
            for (int col = 0; col < dataGridViewField.Columns.Count; col++)
            {
                if (dataGridViewField[col, currentRow].Value == null) return false;
            }

            return true;
        }

        void CheckWord()
        {
            int count = 0;
            for (int i = 0; i < dataGridViewField.ColumnCount; i++)
            {
                for (int j = 0; j < rightWord.Text.Length; j++)
                {
                    if (dataGridViewField[i, currentRow].Value.ToString() == rightWord.Text[j].ToString().ToUpper())
                    {
                        if (dataGridViewField[i, currentRow].Value.ToString() == rightWord.Text[i].ToString().ToUpper())
                            dataGridViewField[i, currentRow].Style.BackColor = Color.Green;

                        else
                            dataGridViewField[i, currentRow].Style.BackColor = Color.Yellow;

                    }
                }
            }

            for (int i = 0; i < dataGridViewField.ColumnCount; i++)
            {
                if (dataGridViewField[i, currentRow].Style.BackColor == Color.Green) count++; 
            }
            
            if (count == dataGridViewField.ColumnCount)
            {
                MessageBox.Show($"Вы угадали слово!\nВот его перевод: {rightWord.Translate}");
                Final();
            }
        }

        void Final()
        {
            DialogResult result = MessageBox.Show("Начать заново?", "5 слов", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FormPlay formPlay = new FormPlay(receivedLanguage, levelDifficulty);
                this.Hide();
                formPlay.ShowDialog();
            }
            else
            {
                FormGame formGame = new FormGame();
                this.Hide();
                formGame.ShowDialog();
            }
        }
    }
}
