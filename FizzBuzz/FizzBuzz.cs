namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static string FizzBuzzEvaluate(int v)
        {
            var result = "";
            
            if (v % 3 == 0)
                result += "Fizz ";
            if (v % 5 == 0)
                result += "Buzz";
            return result == "" ? v.ToString() : result.Trim();
        }
    }
}