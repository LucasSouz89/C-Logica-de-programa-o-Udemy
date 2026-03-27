namespace FuncoesInteressantesString {
    internal class Program {
        static void Main(string[] args) {
            string original = "ADSO KDSAOAKKD SPSÓLK abcde ksaokdsa        ";
            string original2 = "";

            // Converte todas as letras da string para MAIÚSCULAS
            string s1 = original.ToUpper();
            Console.WriteLine($"Original {original}");
            Console.WriteLine($"To upper {s1}");

            // Converte todas as letras da string para minúsculas
            s1 = original.ToLower();
            Console.WriteLine($"To lower:        -{s1}-       ");

            // Remove todos os espaços em branco apenas das BORDAS (início e fim)
            s1 = original.Trim();
            Console.WriteLine($"Trim: {s1}");

            // Busca a PRIMEIRA posição em que o texto "KD" aparece (retorna o índice)
            int posicao = original.IndexOf("KD");
            Console.WriteLine($"PRIMEIRA Posicao: {posicao}");

            // Busca a ÚLTIMA posição em que o texto "KD" aparece (retorna o índice)
            posicao = original.LastIndexOf("KD");
            Console.WriteLine($"ULTIMA Posicao: {posicao}");

            // Corta a string: começa do índice 3 e pega todo o resto até o final
            s1 = original.Substring(3);
            Console.WriteLine("Substring(3): " + s1);

            // Corta a string: começa do índice 3 e recorta EXATAMENTE os próximos 9 caracteres
            s1 = original.Substring(3, 9);
            Console.WriteLine("Substring(3,9): " + s1);

            // Substitui um caractere ou texto específico por outro em toda a string
            s1 = original.Replace("A", "X");
            Console.WriteLine("Replace(A,X);: " + s1);
            s1 = original.Replace("SAO", "JKLY");
            Console.WriteLine("Replace(SAO,JKLY);: " + s1);

            // Verifica se a variável é nula (null) ou se está completamente vazia ("")
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrEmpty(original2);
            Console.WriteLine($"original:{b1}  original2:{b2}");

            // Verifica se a variável é nula, vazia, ou se contém APENAS espaços em branco
            bool b3 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine(b3);

            string rastreio = "   BR-9988-SP   ";
            Console.WriteLine(rastreio.Trim().Replace("SP","RJ"));
        }
    }
}