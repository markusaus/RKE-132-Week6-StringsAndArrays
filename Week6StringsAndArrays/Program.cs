﻿string hello = " we are the champions?";

int stringlenght = hello.Length;

//string trimmedString = hello.Trim();

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);


hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?','!');


firstLetter = hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);

//int wordCounter = 0;
//for (int i = 0; i < hello.Length; i++)

//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter ++;
//    }
    
       
//}

//Console.WriteLine($"Wordcount in {hello}: {wordCounter} words.");
    
