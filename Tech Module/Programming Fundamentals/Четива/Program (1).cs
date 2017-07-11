using System;
using System.Linq;
using System.Numerics;

namespace Important_information
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Arrays have fixed size (Array.Length) - cannot be resized.If we want to resize, we should copy in a new array.

			//int[] numbers = new int[100]; // - creating an int array;
			//bool[] booleans = new bool[50]; // - creating a boolean array;

			//Initialize an array with elements:
			//var number = new int[] {1, 2, 3, 4}; or int[] number = {1, 2, 3, 4};

			//Writing a specific number in a specific cell in the array:
			//var numbers = new int[5];
			//numbers[2] = 43;
			//numbers[4] = 67;
			//numbers[2] = 100; // - we can override a value in a specific cell;
			//can see what number we have in a specific cell by:
			//Console.WriteLine(numbers[2]);

			//var numbers = new int[5];
			//numbers[2] = 43;
			//var secondNumber = numbers[2]; // - create a variable where we store a value from the array;
			//Console.WriteLine(secondNumber);

			//Using the .Trim() method:
			//string text = " abc "; // this method trims only the empty space at the beginning and at the end of the string!
			//Console.WriteLine(text.Trim()); // - in this case the Trim() method removes the blank space at the beginning and at the end of the string;

			//Creating array with undefined length of values:
			//var numberOfElements = int.Parse(Console.ReadLine());
			//var numbers = new int[numberOfElements];

			//Writing the numbers from 1 to 5 in an array:
			//var numberOfElements = int.Parse(Console.ReadLine());
			//var numbers = new int[numberOfElements];
			// //saving values:
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	numbers[i] = i + 1;
			//}
			// //reading values:
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			//Reversing numbers:
			//var numberOfElements = int.Parse(Console.ReadLine());
			//var numbers = new int[numberOfElements];
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	var currentNumber = int.Parse(Console.ReadLine());
			//	numbers[i] = currentNumber;
			//}
			//for (int i = numbers.Length - 1; i >= 0; i--)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			//The .Split() method:
			//string text = "1 2 3 4";
			//string[] arrayOfNumbers = text.Split(' ');
			//Console.WriteLine(string.Join(" ", arrayOfNumbers));

			//Reading the numbers 1,2,3,4,5 and putting them in real array.
			//In this case we gonna make an int array from a string array:
			//string text = "1,2,3,4,5";
			//var splitText = text.Split(','); //if we add .Select(int.Parse).ToArray(), this is a substitute to the code below!;
			//var numbers = new int[splitText.Length]; //the .Select() method requires "using System.Ling"
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	var currentText = splitText[i];
			//	var currentNumber = int.Parse(currentText);
			//	numbers[i] = currentNumber;
			//}

			//Taking the digits and putting them to array:
			//string text = "12345";
			//var textArray = new char[text.Length];
			//for (int i = 0; i < text.Length; i++)
			//{
			//	textArray[i] = text[i];
			//}

			//String is array. And the proof is:
			//var text = "12345";
			//Console.WriteLine(text[2]);

			//Array from the letters in the alphabet:
			//var alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper(); // Console.WriteLine(alphabet.Length) - check if it is 26 symbols!
			//for (int i = 0; i < alphabet.Length; i++)
			//{
			//	Console.Write(alphabet[i] + " ");
			//}

			//Another way to make an array from the letters in the alphabet: 	NB!!!!!!!  - (i - 'a') ? ? ?
			//var alphabet = new char[26];
			//for (char i = 'a'; i <= 'z'; i++) 
			//{
			//	alphabet[i - 'a'] = i;
			//}
			//Console.WriteLine(string.Join(" ", alphabet));

			//Splitting strings based on more than 1 symbol:
			//var text = "Zdrasti, za sum Drago! Vsichki manekenki me jelaqt.";
			//var separators = new char[] { ',', '!', '.', ' ' };
			//var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
			//foreach (var word in words)
			//{
			//	Console.WriteLine(word);
			//}

			//We cannot substitute letter in a string:
			//var text = "abcd";
			//text[2] = 't'; //it says: read-only!!! To do that, we shoud use:
			//var text = "abcd".ToCharArray();    //If we want to create a string array again: var secondText = new string(text); 
			//text[2] = 't';                       
			//Console.WriteLine(text);

			//Creating '-' many times:
			//var text = new string('-', 150);
			//Console.WriteLine(text);

			//Convert a string to int:
			//string values = Console.ReadLine();
			//string[] items = values.Split(' ');
			//int[] arr = new int[items.Length];
			//for (int i = 0; i < items.Length; i++)
			//{
			//	arr[i] = int.Parse(items[i]);
			//}
			//for (int i = 0; i < items.Length; i++)
			//{
			//	Console.WriteLine(arr[i]);
			//}

			//Using the Join method:
			//var numbers = new int[] { 1, 2, 3, 4 };
			//var result = string.Join(Environment.NewLine, numbers);
			//Console.WriteLine(result); //if we want to print on a different line, we should use the Environment.NewLine action, or "\n"!

			//Using the name0f() method:
			//var arr = new int[] {1, 2, 3, 4};
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.WriteLine($"{nameof(arr)}[{i}] = {arr[i]}");
			//}

			//Creating two arrays with the same, but reversed numbers:
			//int n = int.Parse(Console.ReadLine());
			//var numbers = new int[n];
			//var reverse = new int[numbers.Length];
			//for (int i = 0; i < n; i++)
			//{
			//	numbers[i] = int.Parse(Console.ReadLine());
			//  reverse[numbers.Length - 1 - i] = numbers[i];
			//}

			//Printing arrays with the foreach() method:
			//var numbers = new int[] { 1, 2, 3, 4 };
			//foreach (var number in numbers)
			//{
			//	Console.WriteLine(number); //or Console.WriteLine(string.Join(", "), numbers);
			//}

			//Using the Reverse() method: 
			//var numbers = new int[] {1, 2, 3, 4};
			//var reversed = numbers.Reverse(); //this method required the using System.Linq action!
			//Console.WriteLine(string.Join(", ", reversed));

			//Swapping the places of the slots in the array:
			//var numbers = new int[] {1, 2, 3, 4};
			//for (int i = 0; i < numbers.Length / 2; i++)
			//{
			//	var temp = numbers[i];
			//	var reversedIndex = numbers.Length - 1 - i;
			//	numbers[i] = numbers[reversedIndex];
			//	numbers[reversedIndex] = temp;
			//}

			//The task with the bunny "Pesho":
			//int n = int.Parse(Console.ReadLine());
			//int jumps = int.Parse(Console.ReadLine());
			//var solution = jumps % n; // a way to go through an array!
			//Console.WriteLine(solution);
		











		}
	}
}
