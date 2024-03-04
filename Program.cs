/*
 * Author:Fatima Oronia
 * Course:COMP-003A
 * Purpose: Assignment7
 * 
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Array - CharacterCounter Section
        SectionSeparator("Array - CharacterCounter Section");
        Console.Write("Enter a single letter: ");
        char letter = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter a word: ");
        string inputWord = Console.ReadLine();
        int count = CharacterCounter(letter, inputWord);
        Console.WriteLine($"The character '{letter}' appears {count} times in the word '{inputWord}'.");

        // Array - IsPalindrome Section
        SectionSeparator("Array - IsPalindrome Section");
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        bool isPalindrome = IsPalindrome(word);
        Console.WriteLine($"The word '{word}' is {(isPalindrome ? "a palindrome." : "not a palindrome.")}");

        // List - Add Section
        SectionSeparator("List - Add Section");
        List<string> names = new List<string>();
        char userInput = default;
        do
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            names.Add(name);
            Console.Write("Press any key to add more or (e) to exit: ");
            userInput = Convert.ToChar(Console.ReadLine());
        } while (userInput != 'e');

        // Add "Fatima Oronia" to the list
        names.Add("Fatima Oronia");

        // List - Traversal Section
        SectionSeparator("List - Traversal Section");
        TraverseList(names);

        // List - Reverse Traversal Section
        SectionSeparator("List - Reverse Traversal Section");
        TraverseListReverse(names);
    }

    static void SectionSeparator(string sectionName)
    {
        Console.WriteLine($"\n\n========== {sectionName} ==========\n");
    }

    static int CharacterCounter(char characterInput, string word)
    {
        characterInput = char.ToLower(characterInput);
        word = word.ToLower();
        int count = 0;
        foreach (char ch in word)
        {
            if (ch == characterInput)
            {
                count++;
            }
        }
        return count;
    }

    static bool IsPalindrome(string word)
    {
        word = word.ToLower();
        string reversedWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }
        return word == reversedWord;
    }

    static void TraverseList(List<string> list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void TraverseListReverse(List<string> list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list[i]);
        }
    }
}