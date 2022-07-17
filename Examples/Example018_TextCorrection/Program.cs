// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.

string text = "- I think, - said the prinCe, smiling, - that,"
            + "if you were sent instead of our beloved Winzengerode,"
            + "you would have taken by storm the Consent of the Prussian king."
            + "You are so eloquent. Will you give me tea?";

// string s = "qwerty"
//             012
// s[3] // r

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) 
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }
    return result;
}

Console.WriteLine();
string newText = Replace (text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace (newText, 'k', 'K');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace (newText, 'C', 'c');
Console.WriteLine(newText);
Console.WriteLine();