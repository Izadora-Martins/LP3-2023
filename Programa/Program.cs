namespace Programa;
class Programa{
   
    static void Main(String[] args){

        bool continuar = false;
        string n1= " ";
        string n2= " ";
        string n3= " ";
        double nota1= 0;
        double nota2= 0;
        double nota3= 0;
        double result= 0;
        double turma= 0;
        int i = 0;

        Console.Write("Avaliação do Primeiro Bimestre - SUB");
        Console.WriteLine("\n---------------------------------------------------");

        while( !continuar ){

            Console.Write("Digite a nota 1: ");
            n1 = Console.ReadLine();

            while( ! double.TryParse(n1, out nota1) ){                            
                 Console.Write("Nota Inválida. Digite uma nota válida: ");    
                 n1= Console.ReadLine();                                            
             }

            Console.Write("Digite a nota 2: ");
            n2 = Console.ReadLine();

            while( ! double.TryParse(n2, out nota2) ){                            
                 Console.Write("Nota Inválida. Digite uma nota válida: ");    
                 n2= Console.ReadLine();                                            
             }

            Console.Write("Digite a nota 3: ");
            n3 = Console.ReadLine();

            while( ! double.TryParse(n3, out nota3) ){                            
                 Console.Write("Nota Inválida. Digite uma nota válida: ");    
                 n3= Console.ReadLine();                                            
             }

            try{
               
                result= Media.Calculo( nota1, nota2, nota3) ;

                if( double.IsNaN(result) ) {
                    Console.WriteLine("Esta operação resultará em um erro matemático.\n");
                }
                else
                     Console.WriteLine("A média do aluno foi: {0:0.##}\n", result);
            }
            catch (Exception e){
                Console.WriteLine("Ocorreu uma exceção.\n -Detalhes: " +e.Message);
            }      

            Console.Write("Deseja continuar ('s' ou 'n')?");
            ++i;
            turma=turma+result;
            
             if( Console.ReadLine() == "n"){
                continuar = true;
                turma=turma/i;
                Console.WriteLine("A média da turma foi: {0:0.##}", turma);
            }
        }
        return;      
}
}