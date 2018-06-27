using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagranimals;

namespace Anagranimals.Tests
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void IsPartOfAlphabet_CheckIfLetter_Bool()
        {
            char test = 's';
            Anagram newAnalgram = new Anagram("any string");
            bool answer = newAnalgram.IsPartOfAlphabet(test);
            Assert.AreEqual(answer, true);
        }

        [TestMethod]
        public void TestArrayLength_FindLengthOfArray_Int()
        {
            char[] testArray = { 't', 'e', 's', 't' };
            Anagram newAnalgram = new Anagram("any string");
            int length = newAnalgram.TestArrayLength(testArray);
            Assert.AreEqual(length, 4);
        }

        [TestMethod]
        public void StringToArray_StringConvertedToCharArray_CharArray()
        {
            string word = "test";
            char[] charArray = { 't', 'e', 's', 't' };
            Anagram newAnalgram = new Anagram(word);
            char[] methodCharArray = newAnalgram.StringToArray(word);
            CollectionAssert.AreEqual(methodCharArray, charArray);
        }

        [TestMethod]
        public void SetOriginalWord_TestSetOGWord_String()
        {
            string word = "catch";
            Anagram newAnalgram = new Anagram(word);
            string anotherWord = "hatch";
            newAnalgram.SetOriginalWord(anotherWord);
            string yetAnotherWord = newAnalgram.GetOriginalWord();
            Assert.AreEqual(anotherWord, yetAnotherWord);
        }

        [TestMethod]
        public void GetOriginalWord_TestGettingOriginalWord_String()
        {
            string word = "catch";
            Anagram newAnagram = new Anagram(word);
            string actualWord = newAnagram.GetOriginalWord();
            Assert.AreEqual(actualWord, word);
        }
    }
}
 