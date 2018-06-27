using System.Collections.Generic;

namespace Anagranimals
{
    public class Anagram
    {
        private string _originalWord;
        //private string _wordToCompare;

        public Anagram(string originalWord)
        {
            _originalWord = originalWord;
        }

        public string GetOriginalWord()
        {
            return _originalWord;
        }

        public void SetOriginalWord(string newWord)
        {
            _originalWord = newWord;
        }

        public char[] StringToArray(string word)
        {
            char[] newArray = word.ToCharArray();
            return newArray;
        }


        public List<char> ArrayToList(char[] charArray)
        {
            List<char> letterList = new List<char>(charArray);
            return letterList;
 
        }

        public bool IsPartOfAlphabet(char letter)
        {
            bool answer = char.IsLetter(letter);
            return answer;
        }

        public int TestArrayLength(char[] array)
        {
            int length = array.Length;
            return length;
        }

        //public bool TestIfAnagram(char[] originalArray, char[] newArray)
        //{
        //    for (x = 0; x < originalArray.Length; x++)
        //    {
        //        for (y = 0; y < newArray.Length, y++)
        //        {
        //            if (originalArray[x] == newArray[y])
        //            {
                        
        //            }
        //        }
        //    }
        //}


    }
}