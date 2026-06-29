using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Words
{
    public enum Difficulty
    {
        Easy = 0,
        Medium = 1,
        Hard = 2
    }
    public enum Language
    {
        Russian = 0,
        Ossetian = 1
    }

    public partial class FormGame : Form
    {
        /* 0 - легкий       русский
         * 1 - средний      осетинский
         * 2 - сложный */

        Difficulty levelDifficulty;
        Language language;
        public static int cellSize = 4;
        string[,] namesOfDifficulties =
        {
            { "Легкая", "Средняя", "Сложная" },
            { "Хъæлдзæг", "Астæууон", "Зын"}
        };

        public FormGame()
        {
            InitializeComponent();
            levelDifficulty = Difficulty.Medium;
            language = Language.Russian;
        }

        private void buttonDifficulty_Click(object sender, EventArgs e)
        {
            if (levelDifficulty == Difficulty.Easy)
                levelDifficulty = Difficulty.Medium;
            else if (levelDifficulty == Difficulty.Medium)
                levelDifficulty = Difficulty.Hard;
            else
                levelDifficulty = Difficulty.Easy;

            buttonDifficulty.Text = namesOfDifficulties[(int)language, (int)levelDifficulty];
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            FormPlay formPlay = new FormPlay(language, levelDifficulty);
            this.Hide();
            formPlay.ShowDialog();
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            if (language == Language.Russian)
                language = Language.Ossetian;
            else
                language = Language.Russian;
            ChangeLanguage(language);
        }

        private void ChangeLanguage(Language language)
        {
            if (language == Language.Ossetian)
            {
                labelName.Text = "5 Дзырды";
                labelName.Location = new Point(66, 34);
                labelLanguage.Text = "Æвзаг:";
                labelDifficulty.Text = "Зынхалад:";
                buttonPlay.Text = "Хъазын";
                buttonLanguage.Text = "Ирон";
                buttonDifficulty.Text = namesOfDifficulties[(int)language, (int)levelDifficulty];
            }

            else
            {
                labelName.Text = "5 Слов";
                labelName.Location = new Point(111, 34);
                labelLanguage.Text = "Язык:";
                labelDifficulty.Text = "Сложность:";
                buttonPlay.Text = "Играть";
                buttonLanguage.Text = "Русский";
                buttonDifficulty.Text = namesOfDifficulties[(int)language, (int)levelDifficulty];
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
