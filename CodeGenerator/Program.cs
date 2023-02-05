// See https://aka.ms/new-console-template for more information

//generate correct code
var code = CodeGenerator.CodeGenerator.GenerateCode();
//generated code check
var isCorrect = CodeGenerator.CodeGenerator.CheckCode(code);
Console.WriteLine(isCorrect.ToString());

//check not correct code
isCorrect = CodeGenerator.CodeGenerator.CheckCode("E9ELH75A");
Console.WriteLine(isCorrect.ToString());

//check not correct code
isCorrect = CodeGenerator.CodeGenerator.CheckCode("E9BLH74A");
Console.WriteLine(isCorrect.ToString());

//check not correct code
isCorrect = CodeGenerator.CodeGenerator.CheckCode("E9LH74A");
Console.WriteLine(isCorrect.ToString());