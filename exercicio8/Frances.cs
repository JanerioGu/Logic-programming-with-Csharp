//8.	Crie uma aplicação para uma escola de idiomas que oferece diferentes tipos de cursos, como inglês, espanhol e francês. Utilize herança para representar a relação entre as classes de cursos e implemente métodos específicos para cada tipo de curso, como calcular a média de notas para cursos avançados e gerar certificados para cursos concluídos.

class Frances : Ingles{
    public Frances(string nome, int matricula) : base(nome, matricula)
    {
        this.nomeAluno = nome;
        this.matricula = matricula;
    }
    public void calcularMedia(int n1, int n2, int n3){
        int media = (n1+n2+n3)/3;

        if(media >= 8){
            System.Console.WriteLine("Você está apto para os cursos superiores");
        }
    }

    public void gerarCertificado(){
        System.Console.WriteLine("Você está certificado no curos de FRANCES!");
    }

}