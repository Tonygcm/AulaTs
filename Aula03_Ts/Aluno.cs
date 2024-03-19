class Aluno
{
    // 1o princípio da OO: Encapsulamento (proteção)
    public string matricula { get; set; }
    public string nome { get; set; }
    public float nota1 { get; set; }
    public float nota2 { get; set; }


    public Aluno()
    {

    }

    public Aluno(string nome)
    {
        this.nome = nome;
    }

    public Aluno(string matricula, string nome)
    {
        this.matricula = matricula;
        this.nome = nome;
    }

    public override string ToString()
    {
        return "Nome: " + nome + ", Matrícula:" + matricula;
    }

}
