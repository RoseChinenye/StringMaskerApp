
namespace StringMaskerApp
{
    public class implementation
    {
        public static void usingMaskedString()
        {
            string Input = "Chinenye";

           
            if (Input.Length <= (int)wordsUnmasked.UnmaskedWords)
            {
                Console.WriteLine(Input);
                Console.WriteLine("There is nothing to unmask.");
            }
            else
            {

                string ShowString(string OriginalString, int lastDigit)
                {
                    string Result = new String('#', OriginalString.Length - lastDigit) +
                            OriginalString.Substring(OriginalString.Length - lastDigit);
                    return Result;
                }
                Console.WriteLine(ShowString(Input, (int)wordsUnmasked.UnmaskedWords));
            }
        }
    }
}
