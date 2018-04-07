using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WhiteBoardQuestion
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
      

        public MainPage()
        {
            this.InitializeComponent();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int[] randomQuestion = new int[30];
            for (int i = 1; i < randomQuestion.Length; i++)
            {
                rand = new Random();
                int results = rand.Next(randomQuestion.Length);
                #region
                if (results == 1)
                {
                    result.Text = "Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8. ";
                }
                else if (results == 2)
                {
                    result.Text = "Write a program that reads from the console the radius r of a circle and prints its perimeter and area.";
                }
                else if (results == 3)
                {
                    result.Text = "Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, " +
                        "such that the remainder of their division by 5 is 0.Example: in the range(14, 25) there are 3 such numbers: 15, 20 and 25.";
                }
                else if (results == 4)
                {
                    result.Text = "Write a program that reads two numbers from the console and prints the greater of them.Solve the problem without using conditional statements.";
                }
                else if (results == 5)
                {
                    result.Text = "Write a program that reads an integer number n from the console and prints all numbers in the range[1…n], each on a separate line.";
                }
                else if (results == 6)
                {
                    result.Text = "Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …";
                }
                else if (results == 7)
                {
                    result.Text = "Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1 / 2 - 1 / 3 + 1 / 4 - 1 / 5 + ";
                }
                else if (results == 8)
                {
                    result.Text = "Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.The number N should be read from the standard input.";
                }
                else if (results == 9)
                {
                    result.Text = "Write a program that reads from the console a series of integers and prints the smallest and largest of them.";
                }
                else if (results == 10)
                {
                    result.Text = "Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …";
                }
                else if (results == 11)
                {
                    result.Text = "Write a program, which creates an array of 20 elements of typeinteger and initializes each of the elements with a value equals to the index of the element multiplied by 5.Print the elements to the console. ";
                }
                else if (results == 12)
                {
                    result.Text = "Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, " +
                        "such that the remainder of their division by 5 is 0.Example: in the range(14, 25) there are 3 such numbers: 15, 20 and 25.";
                }
                else if (results == 13)
                {
                    result.Text = "Write a program, which reads two arrays from the console and checks whether they are equal(two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).";
                }
                else if (results == 14)
                {
                    result.Text = "Write a program, which compares two arrays of type char lexicographically(character by character) and checks, which one is first in the lexicographical order.";
                }
                else if (results == 15)
                {
                    result.Text = "Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: { 1, 1, 2, 3, 2, 2, 2, 1}  { 2, 2, 2}";
                }
                else if (results == 16)
                {
                    result.Text = "Write a program, which finds the maximal sequence of consecutively placed increasing integers.Example: { 3, 2, 3, 4, 2, 2, 4}  { 2, 3, 4}.";
                }
                else if (results == 17)
                {
                    result.Text = "Write a program, which finds the maximal sequence of increasing elements in an array arr[n].It is not necessary the elements to be consecutively placed. E.g.: { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  { 2, 4, 6, 8}.";
                }
                else if (results == 18)
                {
                    result.Text = "Write a program, which finds a subsequence of numbers with maximal sum. E.g.: { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11";
                }
                else if (results == 19)
                {
                    result.Text = "Write a program, which finds the most frequently occurring element in an array. Example: { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4(5 times).";
                }
                else if (results == 20)
                {
                    result.Text = "Write a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S. Example: { 4, 3, 1, 4, 2, 5, 8}, S = 11 -> { 4, 2, 5}.";
                }
                else if (results == 21)
                {
                    result.Text = "Write a program, which creates an array containing all Latin letters. The user inputs a word from the console and as result the program prints to the console the indices of the letters from the word.";
                }
               
                #endregion
            }
            
        }
    }
}
