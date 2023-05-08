// Declaração de variáveis booleana "move" e "dev" e uma string "alerta".
bool move, dev;
string alerta;

// Exibe duas mensagens em branco e um título na tela.
Console.WriteLine();
Console.WriteLine("--- FLUXOGRAMA DA ENGENHARIA ---");

// Solicita ao usuário informações sobre o objeto em questão.
Console.Write("O objeto está se movendo 'S/N' ?");
// Armazena a resposta na variável "move", verificando se a primeira letra da resposta é 'S' ou 's'.
move = Console.ReadLine()!.Substring(0, 1).ToUpper() == "S";

Console.Write("Deveria ?");
// Armazena a resposta na variável "dev", verificando se a primeira letra da resposta é 'S' ou 's'.
dev = Console.ReadLine()!.Substring(0, 1).ToUpper() == "S";

// Verifica as informações sobre o objeto para gerar uma mensagem de alerta.
if (!move)
{
    if(!dev)
    {
        alerta = "Ótimo";// Caso o objeto não esteja se movendo e não deva estar, a mensagem é "Ótimo".
    }
    else
    {
        alerta = "Use WD-40";// Caso o objeto não esteja se movendo, mas deva estar, a mensagem é "Use WD-40".
    }
}

else 
{
    if(dev)
    {
        alerta = "Ótimo";// Caso o objeto esteja se movendo e deva estar, a mensagem é "Ótimo".
    }
    else
    {
        alerta = "Use Silver Tape"; // Caso o objeto esteja se movendo, mas não deva estar, a mensagem é "Use Silver Tape".
    }
}

// Exibe uma mensagem em branco e a mensagem de alerta na tela.
Console.WriteLine();
Console.Write(alerta);
