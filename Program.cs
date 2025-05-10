double emprestimo, renda, parcelas, valorParcela, limite;
string decisao;

while(true){

Console.WriteLine("Bem-vindo ao analise de credito da Creditos&Finanças");
Console.WriteLine("Por favor nos fale o valor que deseja para o emprestimo");

while(true){

emprestimo = Convert.ToDouble(Console.ReadLine()!);


Console.WriteLine($"O valor solicitado para emprestimo foi de: {emprestimo:C2}, Confirma esse valor?");
Console.WriteLine("Por favor diga S para confirmar e N para cancelar esse valor");

decisao = Console.ReadLine()!.ToUpper();

if(decisao == "S"){
    Console.WriteLine("Otimo, agora preciso de só mais algumas informações suas");
    break;
}
else{
    Console.WriteLine("Por favor digite o novo valor desejado para o emprestimo");
}}

Console.WriteLine("Em quantas parcelas deseja pagar?");
parcelas = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Por favor agora me diga qual a sua renda MENSAL");
Console.WriteLine("Isso é uma informação mmuito importante para o nosso processo");

renda = Convert.ToDouble(Console.ReadLine()!);

valorParcela = emprestimo / parcelas;

limite = renda * 0.30;


if(valorParcela <= limite){
    Console.WriteLine("Seu emprestimo foi aprovado com sucesso, muito obrigado pela prefencia");
    break;
}
else if(valorParcela > limite) {
    Console.WriteLine("Sentimos muito porem seu emprestimo não foi aprovado");
    Console.WriteLine("Deseja tentar pedir o emprestimo novamente?");
    Console.WriteLine("Digite S para sim e N para não");
    decisao = Console.ReadLine()!.ToUpper();
    
if(decisao == "S"){
    Console.WriteLine("Tudo bem, vamo começar novamente o processo, o processo começara automaticamente");
    Console.Clear();
    continue;
}
else{
    Console.WriteLine("Tudo bem, esperamos ver você futuramente por aqui ;)");
    break;
}

}

}