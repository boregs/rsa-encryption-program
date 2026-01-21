using System;
using System.Numerics;

// tentando fazer um algoritimo de criptografia, mais especificadamente o RSA

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ________                                                      __                         \r\n/        |                                                    /  |                        \r\n$$$$$$$$/  _______    _______   ______   __    __   ______   _$$ |_     ______    ______  \r\n$$ |__    /       \\  /       | /      \\ /  |  /  | /      \\ / $$   |   /      \\  /      \\ \r\n$$    |   $$$$$$$  |/$$$$$$$/ /$$$$$$  |$$ |  $$ |/$$$$$$  |$$$$$$/   /$$$$$$  |/$$$$$$  |\r\n$$$$$/    $$ |  $$ |$$ |      $$ |  $$/ $$ |  $$ |$$ |  $$ |  $$ | __ $$ |  $$ |$$ |  $$/ \r\n$$ |_____ $$ |  $$ |$$ \\_____ $$ |      $$ \\__$$ |$$ |__$$ |  $$ |/  |$$ \\__$$ |$$ |      \r\n$$       |$$ |  $$ |$$       |$$ |      $$    $$ |$$    $$/   $$  $$/ $$    $$/ $$ |      \r\n$$$$$$$$/ $$/   $$/  $$$$$$$/ $$/        $$$$$$$ |$$$$$$$/     $$$$/   $$$$$$/  $$/       \r\n                                        /  \\__$$ |$$ |                                    \r\n                                        $$    $$/ $$ |                                    \r\n                                         $$$$$$/  $$/                                     ");
        Console.WriteLine("===================================================================================================================");
        Console.WriteLine(">> What will we encrypt?");

        string userinput = Console.ReadLine();

        Console.WriteLine(">> What is the key for the encryption?");

        string encryptKey = Console.ReadLine();

    }

    public static int keyGeneration(/*aqui iriam argumentso que iriam nas variaveis "p" e "q"*/)
    {
        BigInteger p = 896717; // numeros primos
        BigInteger q = 549863;

        // modulo para gerar a chave
        BigInteger n = p * q; // n = 493.071.499.771

        BigInteger phi = (p - 1) * (q - 1); // esse é o phi(n) mencionado abaixo | phi = 493.070.053.192



        // =========================================================================================================
        /* para gerar a variavel "e" precisamos seguir duas regras 
           1- o numero precisa ser maior que 1 mas menor que phi(n) (1 < e < phi(n))
           2 - o MDC entre "e" e phi(n) precisa ser 1, ou sejam não podem ter divisores em comum

           o padrão da industria para a variavel "e" é 65537 (2^16 + 1), pois é um numero primo que funciona muito bem

           EX:
           se phi(n) for 20, posso escolher "e = 3", pois 20 e 3 não possuem divisores em comum (MDC = 1)
         */

        BigInteger e = 65537;

        /* =========================================================================================================
         Para calcular o d é um pouco mais complicado, a variavel "d" precisa seguir a seguinte regra:
         1 - quando multiplicarmos "d" por "e" e depois dividirmos por phi(n) o resto PRECISA ser 1
         
         a Formula que usariamos para calcular a variavel "d" é a seguinte:
         
         (d * e) % phi(n) = 1
         - que traduz para
         (d * 65537) % 493.070.053.192 = 1
         

         */

        BigInteger d = ;

        return 0;
    }


    public static int encryption(string frase, string key)
    {
        return 0;
    }


    public static BigInteger ModInverse(BigInteger a, BigInteger m)
    {
        BigInteger m0 = m;
        BigInteger y = 0, x = 1;
        if (m == 1)
        {
            return 0;
        }

        while (a > 1)
        {
            // q é o quociente
            BigInteger q = a / m;
            BigInteger t = m;
            // m é o resto agora, processa como o algoritmo Euclidiano
            m = a % m;
            a = t;
            t = y;

            y = x - q * y;
            x = t;
        }
        // torna x positivo
        if (x < 0)
            x += m0;
        return x;
    }
}
