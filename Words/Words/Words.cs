using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    public class Word
    {
        public string Text { get; }
        public string Translate { get; }
        public Difficulty Difficulty { get; }
        public Language Language { get; }

        public Word(string text, string translate, Difficulty difficulty, Language language)
        {
            Text = text;
            Translate = translate;
            Difficulty = difficulty;
            Language = language;
        }

        public override string ToString()
        {
            return $"{Text} - {Translate}";
        }
    }
}
