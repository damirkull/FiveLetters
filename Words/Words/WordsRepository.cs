using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    public class WordsRepository
    {
        List<Word> words = new List<Word>();
         
        public WordsRepository()
        {
            string[] easyRus = File.ReadAllText("easyWordsRus.txt").Split(' ');
            string[] midRus = File.ReadAllText("midWordsRus.txt").Split(' ');
            string[] hardRus = File.ReadAllText("hardWordsRus.txt").Split(' ');
            string[] easyRusTrans = File.ReadAllText("easyWordsRusTranslate.txt").Split(' ');
            string[] midRusTrans = File.ReadAllText("midWordsRusTranslate.txt").Split(' ');
            string[] hardRusTrans = File.ReadAllText("hardWordsRusTranslate.txt").Split(' ');

            string[] easyOss = File.ReadAllText("easyWords.txt").Split(' ');
            string[] midOss = File.ReadAllText("midWords.txt").Split(' ');
            string[] hardOss = File.ReadAllText("hardWords.txt").Split(' ');
            string[] easyOssTrans = File.ReadAllText("easyWordsTranslate.txt").Split(' ');
            string[] midOssTrans = File.ReadAllText("midWordsTranslate.txt").Split(' ');
            string[] hardOssTrans = File.ReadAllText("hardWordsTranslate.txt").Split(' ');

            AddWords(easyRus, easyRusTrans, Difficulty.Easy, Language.Russian);
            AddWords(midRus, midRusTrans, Difficulty.Medium, Language.Russian);
            AddWords(hardRus, hardRusTrans, Difficulty.Hard, Language.Russian);
            AddWords(easyOss, easyOssTrans, Difficulty.Easy, Language.Ossetian);
            AddWords(midOss, midOssTrans, Difficulty.Medium, Language.Ossetian);
            AddWords(hardOss, hardOssTrans, Difficulty.Hard, Language.Ossetian);
        }

        void AddWords(string[] texts, string[] translates, Difficulty difficulty, Language language)
        {
            int count = texts.Length;

            for (int i = 0; i < count; i++)
                words.Add(new Word(texts[i], translates[i], difficulty, language));
        }

        public Word GetRandomWord(Difficulty difficulty, Language language)
        {
            List<Word> newWords = new List<Word>();

            foreach (Word word in words)
            {
                if (word.Difficulty == difficulty && word.Language == language)
                    newWords.Add(word);
            }

            Random rand = new Random();
            int randIndex = rand.Next(newWords.Count);
            return newWords[randIndex];
        }
    }
}
