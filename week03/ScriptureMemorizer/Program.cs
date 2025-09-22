/*
Scripture Memorizer Program

This program helps memorize scripture by hiding words little by little.

Extras:
- Small library of scriptures, pick one random
- Hide only words not hidden yet
- Keep punctuation, only letters become _
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScriptureMemorizer
{
    // Reference class: stores book/chapter/verse(s)
    public class Reference
    {
        public string Book { get; }
        public int Chapter { get; }
        public int StartVerse { get; }
        public int EndVerse { get; }

        // Single verse
        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = verse;
            EndVerse = verse;
        }

        // Verse range
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse;
        }

        // Show reference text
        public string GetDisplayText()
        {
            if (StartVerse == EndVerse)
                return $"{Book} {Chapter}:{StartVerse}";
            else
                return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }

    // Word class: stores a word and if hidden
    public class Word
    {
        private readonly string _text;
        private bool _hidden;

        public Word(string text)
        {
            _text = text;
            _hidden = false;
        }

        public void Hide() { _hidden = true; }
        public bool IsHidden => _hidden;
        public bool HasLetters() => _text.Any(char.IsLetter);

        public string GetDisplayText()
        {
            if (!_hidden) return _text;
            var sb = new StringBuilder();
            foreach (char c in _text)
            {
                if (char.IsLetter(c)) sb.Append('_');
                else sb.Append(c);
            }
            return sb.ToString();
        }
    }

    // Scripture class: store Reference + Words
    public class Scripture
    {
        private readonly Reference _reference;
        private readonly List<Word> _words;
        private readonly Random _random = new Random();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            var tokens = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            _words = tokens.Select(t => new Word(t)).ToList();
        }

        public string GetDisplayText()
        {
            var wordDisplays = _words.Select(w => w.GetDisplayText());
            return _reference.GetDisplayText() + "\n" + string.Join(" ", wordDisplays);
        }

        public void HideRandomWords(int count = 3)
        {
            var candidates = _words.Where(w => w.HasLetters() && !w.IsHidden).ToList();
            if (candidates.Count == 0) return;
            int toHide = Math.Min(count, candidates.Count);
            for (int i = 0; i < toHide; i++)
            {
                int idx = _random.Next(candidates.Count);
                candidates[idx].Hide();
                candidates.RemoveAt(idx);
            }
        }

        public bool IsCompletelyHidden() => _words.Where(w => w.HasLetters()).All(w => w.IsHidden);
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Small library of scriptures
            var library = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16),
                    "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),

                new Scripture(new Reference("Proverbs", 3, 5, 6),
                    "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),

                new Scripture(new Reference("Psalm", 23, 1),
                    "The Lord is my shepherd; I shall not want.")
            };

            var rnd = new Random();
            var scripture = library[rnd.Next(library.Count)]; // pick random

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine();
                    Console.WriteLine("All words are hidden. Press Enter to exit.");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
                var input = Console.ReadLine();
                if (input != null && input.Trim().ToLower() == "quit") break;

                scripture.HideRandomWords(3); // hide 3 words
            }
        }
    }
}

