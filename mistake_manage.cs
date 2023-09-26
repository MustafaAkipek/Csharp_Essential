namespace ConsoleApp {

    class mistake_manage{
        

        static void password_control(string password)
        {
            if(password.Length < 6 || password.Length > 10)
            {
                throw new Exception("The password must be in the 6-10 character range");
            }

            if(!password.Any(char.IsDigit))
            {
                throw new Exception("The password must be contain at least one number");
            }

            if(!password.Any(char.IsLetter))
            {
                throw new Exception("The password must be contain at least one letter");
            }
        }

        static void Main(string[] args)
        {

            try{
            Console.Write("1. number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var result = number1 / number2;
            Console.WriteLine(result);
            }

            catch(FormatException) {
                Console.WriteLine("Please enter a number");
            }

            catch(DivideByZeroException) {
                Console.WriteLine("number2 cannot be zero");
            }

            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }

            Console.Write("password: ");
            string password = Console.ReadLine();

            try{
                password_control(password);
                Console.WriteLine("The password is correct");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}