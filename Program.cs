﻿string fraseDigitada, fraseComNumero;

Console.Write("Digite uma frase: ");
fraseDigitada = Console.ReadLine()!;

fraseComNumero = fraseDigitada
    .Replace("a","4")
    .Replace("A","4")
    .Replace("e","3")
    .Replace("E","3")
    .Replace("i","1")
    .Replace("I","1")
    .Replace("o","0")
    .Replace("O","0")
    .Replace("t","7")
    .Replace("T","7")
    .Replace("s","5")
    .Replace("S","5");

    Console.WriteLine(fraseComNumero);
