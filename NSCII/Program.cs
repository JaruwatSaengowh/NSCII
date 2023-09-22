namespace NSII.Service
{
    public class NSII
    {
        static void Main(string[] args)
        {
            var Line = "---------------------------------------------------------------------------------";

            Console.WriteLine(Line);

            Console.WriteLine("Please enter information to encrypt NSCII : ");

            string inputNSCII = Console.ReadLine();

            Console.WriteLine(Line);

            Console.WriteLine("Is the information you entered to encode NSCII correct?");

            Console.WriteLine(Line);

            Console.WriteLine("NSCII is : " + inputNSCII);

            Console.WriteLine(Line);

            Console.WriteLine("Yes OR No");

            Console.WriteLine(Line);

            string checkNSCII = Console.ReadLine();

            Console.WriteLine(Line);

            if (checkNSCII == "Yes")
            {
                var encrypt = inputNSCII;

                var encoder = "9876543210ABCDEFGHIJKLMNOPQRSTUVWXYZzyxwvutsrqponmlkjihgfedcba";

                var encrypt_nscii = "";

                var num_plus = 1;

                for (int i = 0; i < encrypt.Length; i++)
                {
                    var index = encoder.IndexOf(encoder[i]);

                    if (num_plus == 27)
                    {
                        num_plus = 1;
                    }

                    var int_nscii = index + num_plus;

                    encrypt_nscii = encrypt_nscii + "" + encoder[int_nscii].ToString();

                    num_plus++;


                    Console.WriteLine(encoder);

                    Console.WriteLine(encrypt_nscii);

                    Console.WriteLine(num_plus);

                }


                Console.WriteLine("Successfully Encrypted");

                Console.WriteLine(Line);

                Console.WriteLine("NSCII : " + encrypt_nscii);

                Console.WriteLine(Line);

                Console.WriteLine("Do you want to decode it?");

                Console.WriteLine(Line);

                Console.WriteLine("Yes OR No");

                Console.WriteLine(Line);

                string checkNsciiDECODING = Console.ReadLine();

                Console.WriteLine(Line);

                if (checkNsciiDECODING == "Yes")
                {
                    var decode = encrypt_nscii;

                    var decode_nscii = "";


                    for (int i = 0; i < decode.Length; i++)
                    {
                        var index = encoder.IndexOf(encoder[i]);

                        if (num_plus == 27)
                        {
                            num_plus = 1;
                        }

                        var int_nscii = index + num_plus;

                        decode_nscii = decode_nscii + "" + encoder[int_nscii].ToString();

                        num_plus++;
                    }


                    Console.WriteLine("Successfully Decode");

                    Console.WriteLine(Line);

                    Console.WriteLine("NSCII : " + decode_nscii);

                    Console.WriteLine(Line);
                }
                else
                {
                    Console.WriteLine("Thank you.");
                    Console.WriteLine(Line);
                    return;
                }

                Console.WriteLine(Line);

            }
            else
            {
                Console.WriteLine("Please restart the program to enter the new NSCII encryption information.");
                Console.WriteLine(Line);
                return;

            }
        }
    }
}