namespace Aula1203
{

    class Program
    {
        public static void Main(string[] args)
        {

            Ex01();

        }





        static void Exemplo()
        {

            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a nota 1 do aluno");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota 2 do aluno");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Nota: " + nota1);
            Console.WriteLine("Nota: " + nota2);

            Console.WriteLine("Soma: " + Calculadora.Somar(nota1, nota2));
            Console.WriteLine("Subtrair: " + Calculadora.Subtrair(nota1, nota2));
            Console.WriteLine("Multiplicacao: " + Calculadora.Multiplicar(nota1, nota2));
            Console.WriteLine("Dividir: " + Calculadora.Dividir(nota1, nota2));

        }
        /*
        Exercício de fixação 1
        ▪ Criar um programa para processar as seguintes informações de um aluno:
        matrícula, nome , nota1, nota2 e se ele está aprovado ou reprovado;
        ▪ Durante a execução calcular a nota final do aluno utilizando a seguinte regra: 
        notaFinal = (nota1 + nota2) / 2. 
        Se a nota final for igual ou superior a 6 o aluno está aprovado, caso contrário estará reprovado;
        ▪ O programa deverá imprimir o seguinte relatório: 
        Matrícula: xxxxx
        Nome: xxxxx xxxxx
        Aprovado: ( x ) Sim ( ) Não
        Nota final: xxxxx
        */

        static void Ex01()
        {

            float notaFinal;

            Aluno o1 = new Aluno();
            o1.matricula = "A";
            o1.nome = "Fulano";
            o1.nota1 = 7;
            o1.nota2 = 9;

            notaFinal = Calculadora.Media(o1.nota1, o1.nota2);

            Console.WriteLine("Matrícula: " + o1.matricula + "\n" +
            "Nome: " + o1.nome);

            if (notaFinal >= 6)
                Console.WriteLine("Aprovado: ( x ) Sim ( ) Não");
            else
                Console.WriteLine("Aprovado: ( ) Sim ( x ) Não");

            Console.WriteLine("Nota final: " + notaFinal);

        }

        /* 
        Exercício de fixação 2
        ▪ Transformar o programa do exercício 1 para um sistema que permita ler aentrada de dados pelo usuário em um vetor durante execução;
        ▪ Permitir que o usuário informe, primeiro, os dados de 5 (cinco) alunos e depoisde capturados os dados, imprimir o relatório final com todos os dados:
        Matrícula: xxxxx
        Nome: xxxxx xxxxx
        Aprovado: ( x ) Sim ( ) Não
        Nota final: xxxxx
        */

        static void Ex02()
        {
            Aluno o1 = new Aluno();
            o1.matricula = "A";
            o1.nome = "Nome1";
            o1.nota1 = 7;
            o1.nota2 = 9;
            Aluno o2 = new Aluno();
            Aluno o3 = new Aluno();
            Aluno o4 = new Aluno();
            Aluno o5 = new Aluno();

            Aluno[] alunos = new Aluno[5];
            alunos[0] = o1;
            alunos[1] = o2;
            alunos[2] = o3;
            alunos[3] = o4;
            alunos[4] = o5;



        }

        /*
        Exercício de fixação 3
        ▪ Criar um programa para processar as seguintes informações de um aluno:matrícula, nome , nota 1, nota 2, nota 3, nota 4 e nota 5;
        ▪ O sistema deverá ler as notas do aluno em um vetor e a entrada de dados pelo usuário só poderá ser nos valores de 0 a 10;
        ▪ No final da execução imprimir o seguinte relatório:
        Matrícula: xxxxx
        Nome: xxxxx xxxxx
        Nota (x) : xxxxx
        Nota (y) : yyyyy
        (...)
        */
        static void Ex03()
        {

        }

    }

}