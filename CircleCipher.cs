class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to encode with Circle Cipher: ");
            string input = Console.ReadLine();
            string message = Encode(input);
            Console.WriteLine("Here you go - the encoded message: {0}", message);
            Console.WriteLine("Do you wish to decode it?(Y/N)");
            string confirm = Console.ReadLine();
            if(confirm.ToUpper()=="Y")
                Console.WriteLine("Here is your decoded string back: {0}",Decode(message));
            else if(confirm.ToUpper()=="N")
                Console.WriteLine("Goodbye");

            Console.ReadKey();

         }
        public static string Encode(string s)
        {
            string encodedMessage = "";
            int len = s.Length;
            for (int i = 0, j = len - 1; i < len / 2; i++, j--)
            {
                encodedMessage += s[i];
                encodedMessage += s[j];
            }
            if (len % 2 != 0)
                encodedMessage += s[len / 2];
            return encodedMessage;
        }

        public static string Decode(string s)
        {
            string decodedMessage = "";
            int len = s.Length;
            for (int i = 0; i < len; i += 2)
            {
                decodedMessage += s[i];
            }
            int k = 1;
            if (len % 2 != 0)
                k = 2;
            for (int j = len - k; j > 0; j -= 2)
            {
                decodedMessage += s[j];
            }
            return decodedMessage;
        }

    }
