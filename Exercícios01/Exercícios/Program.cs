using System.Linq.Expressions;

class Program
{
    
    static void Main()
    {
// ------------Exercicio 1-------------------

        Console.WriteLine("1) Escreva um algoritmo que armazene o valor 10 em uma" + "\r\n" + "variável A e o valor 20 em uma variável B. A seguir (utilizando apenas atribuições entre variáveis)" + "\r\n" + "troque os seus conteúdos fazendo com que o valor que está em A passe para B e vice-versa." + "\r\n" + "Ao final, escrever os valores que ficaram armazenados nas variáveis." +"\r\n");
        int A = 10;
        int B = 20;

        Console.WriteLine(" 'A' vale: " + A);
        Console.WriteLine(" 'B' vale: " + B);

        A = 20;
        Console.WriteLine(" Agora o valor de 'A' é: " + A);

        B = 10;
        Console.WriteLine(" Agora o valor de 'B' é: " + B);

        Console.WriteLine();

// ------------Exercicio 2-------------------

        Console.WriteLine("2) Escreva um algoritmo para ler o número total de eleitores de um município," + "\r\n" + "o número de votos brancos, nulos e válidos." + "\r\n" + "Calcular e escrever o percentual que cada um representa em relação ao total de eleitores." + "\r\n");

        int brancos;
        int nulos;
        int validos;
        //int total;


// ------------Exercicio 3-------------------

        Console.WriteLine("3) Ler um valor e escrever se é positivo ou negativo (considere o valor zero como positivo)." + "\r\n");

        int num;

        Console.Write(" Digite um valor: ");
        num = Int32.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine(" O número " + num + " é negativo!");
        }
        else
        {
            Console.WriteLine(" O número " + num + " é positivo!");
        }

        Console.WriteLine(" ");

        // ------------Exercicio 4-------------------
        Console.WriteLine("4) Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa." + "\r\n" + "Sabendo-se que ele recebe uma comissão de 3% sobre o total das vendas" + "\r\n" + "até R$ 1.500,00 mais 5% sobre o que ultrapassar este valor, calcular e escrever o seu salário total." + "\r\n");

        //int vendas;
        int total

        Console.WriteLine("Digite o valor do salário: ");
        //int salario = Int32.Parse(Console.ReadLine());
        double salario = Console.ReadLine();

        Console.WriteLine("Digite o valor das vendas: ");
        //int vendas = Int32.Parse(Console.ReadLine());
        double vendas = Console.ReadLine();

        Console.WriteLine("Seu salário é: " + salario + " e suas vendas foram: " + vendas);

        


        // ------------Exercicio 5-------------------
        Console.WriteLine("5) Ler o nome de 2 times e o número de gols marcados na partida (para cada time). Escrever \r\no nome do vencedor. Caso não haja vencedor deverá ser impressa a palavra EMPATE.\r\n");
        // ------------Exercicio 6-------------------
        Console.WriteLine("6) Escreva um algoritmo para ler 2 valores e se o segundo valor informado for ZERO, deve \r\nser lido um novo valor, ou seja, para o segundo valor não pode ser aceito o valor zero e \r\nimprimir o resultado da divisão do primeiro valor lido pelo segundo valor lido.\r\n");
        // ------------Exercicio 7-------------------
        Console.WriteLine("7) Escreva um algoritmo que calcule e imprima a tabuada do 8 (1 a 10).\r\n");
        // ------------Exercicio 8-------------------
        Console.WriteLine("8) Ler 10 valores, calcular e escrever a média aritmética desses valores lidos.");
        // ------------Exercicio 9-------------------
        Console.WriteLine("9) Escreva um procedimento que recebe as 3 notas de um aluno por parâmetro e uma letra. \r\nSe a letra for A o procedimento calcula a média aritmética das notas do aluno, se for P, a sua \r\nmédia ponderada (pesos: 5, 3 e 2) e se for H, a sua média harmônica. A média calculada \r\ntambém deve retornar por parâmetro.\r\n");
        // ------------Exercicio 10-------------------
        Console.WriteLine("10) Faça uma função que recebe, por parâmetro, a altura (alt) e o sexo de uma pessoa e \r\nretorna o seu peso ideal. Para homens, calcular o peso ideal usando a fórmula peso ideal = \r\n72.7 x alt - 58 e, para mulheres, peso ideal = 62.1 x alt - 44.7.\r\n");













    }
}