String SenhaDigitada, SenhaCorreta;
 
SenhaCorreta = "Bombardilo Crocodilo";

Console.Clear();
Console.Write(@"Seja bem vindo, caro Web Navegador! É sempre um prazer te ver por aqui. 
Mas antes de tudo é necessário que você confirme a seu login para sabermos que realmente é você, caro navegador.
Digite sua senha: ");
SenhaDigitada = Console.ReadLine()!;

if(SenhaDigitada==SenhaCorreta)

{
//Alternativa Correta.
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Acesso Concedido.");
}


else

{
//Alternativa Incorreta.
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Acesso Negado.");
}

Console.ResetColor();