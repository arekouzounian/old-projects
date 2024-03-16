using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ike_test_bot
{
    class MarkovChain
    {
        Dictionary<string, Node> wordDictionary = new Dictionary<string, Node>();
        string[] words;

        private void Markov(string text)
        {
            text = text.ToLower();
            words = text.Split(" ");

            wordDictionary.Add(words[0], new Node(new Dictionary<string, int>()));
            for (int i = 1; i < words.Length; i++)
            {
                //checking if the word is not in word dictionary
                if (!wordDictionary.ContainsKey(words[i]))
                {
                    wordDictionary.Add(words[i], new Node(new Dictionary<string, int>()));
                }

                if (wordDictionary[words[i - 1]].MarkovPossibilities.ContainsKey(words[i]))
                {
                    wordDictionary[words[i - 1]].MarkovPossibilities[words[i]]++;
                }
                else
                {
                    wordDictionary[words[i - 1]].MarkovPossibilities.Add(words[i], 1);
                }
            }
        }

        private string generateWord(string currWord)
        {
            Random random = new Random();
            if (currWord == words[words.Length - 1])
            {
                currWord = words[random.Next(0, words.Length)];
            }



            Node currWordNode;
            if (wordDictionary.ContainsKey(currWord))
            {
                currWordNode = wordDictionary[currWord];
            }
            else
            {
                throw new Exception("either wordDictionary is empty or the current word doesn't exist in it.");
            }

            List<string> possibleWords = new List<string>();

            foreach (var word in currWordNode.MarkovPossibilities.Keys)
            {
                for (int i = 0; i < currWordNode.MarkovPossibilities[word]; i++)
                {
                    possibleWords.Add(word);
                }
            }
            int randomIndex = random.Next(0, possibleWords.Count);

            return possibleWords[randomIndex];
        }

        public string generateText(int amount, string txt)
        {
            Markov(txt);

            string currWord = "the";
            StringBuilder strB = new StringBuilder();
            strB.Append(currWord + " ");
            for (int i = 0; i < amount; i++)
            {
                currWord = generateWord(currWord);
                strB.Append(currWord + ' ');
            }

            return strB.ToString();
        }
    }

    public class Node
    {
        public Dictionary<string, int> MarkovPossibilities;

        public Node(Dictionary<string, int> markovProbs)
        {
            MarkovPossibilities = markovProbs;
        }
    }
}
