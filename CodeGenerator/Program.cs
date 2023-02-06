// See https://aka.ms/new-console-template for more information

//generate correct code
var code = CodeGenerator.CodeGenerator.GenerateCode();
//generated code check
var isCorrect = CodeGenerator.CodeGenerator.CheckCode(code);
Console.WriteLine("code: "+ code + " is correct: "+isCorrect);

//check not correct code
code = "E9ELH75A";
isCorrect = CodeGenerator.CodeGenerator.CheckCode(code);
Console.WriteLine("code: "+ code + " is correct: "+isCorrect);

//check not correct code
code = "E9BLH74A";
isCorrect = CodeGenerator.CodeGenerator.CheckCode(code);
Console.WriteLine("code: "+ code + " is correct: "+isCorrect);

//check not correct code
code = "E9LH74A";
isCorrect = CodeGenerator.CodeGenerator.CheckCode(code);
Console.WriteLine("code: "+ code + " is correct: "+isCorrect);