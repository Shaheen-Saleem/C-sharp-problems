/*
Write code to reverse each word in a message

1. Select and delete all code lines in the Visual Studio Code Editor.

2. Update your code in the Visual Studio Code Editor as follows: 

      string pangram = "The quick brown fox jumps over the lazy dog";

3. Write the code necessary to reverse the letters of each word in place and display the result.
In other words, don't just reverse every letter in the variable pangram. Instead, you need to reverse just the letters in each word, but print the reversed word in its original position in the message.
Your code must produce the following output:

  Output

    ehT kciuq nworb xof spmuj revo eht yzal god
*/

string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramArr = pangram.Split();
string result = "";
for (int i = 0; i < pangramArr.Length; i++)
{
    string val = pangramArr[i];
    char[] valArr = val.ToCharArray();
    Array.Reverse(valArr);
    string valResult = new string(valArr);
    result += valResult + " ";
}
Console.WriteLine(result);
