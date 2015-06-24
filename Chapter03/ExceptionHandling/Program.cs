using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            HandleNullReference();
            HandleUncaughtException();
            ThrowException();

            Console.ReadKey();
        }

        static void HandleNullReference()
        {
            Program prog = null;

            try
            {
                Console.WriteLine(prog.ToString());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void HandleUncaughtException()
        {
            Program prog = null;

            try
            {
                Console.WriteLine(prog.ToString());
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("From ArgumentNullException: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("From ArgumentException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("From Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally always executes.");
            }
        }

        static void ThrowException()
        {
            try
            {
                ValidateInput("something", new Company());
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "inputString")
            {
                Console.WriteLine("From ArgumentNullException: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("From ArgumentException: " + ex.Message);
            }
        }

        static void ValidateInput(string inputString, Company cmp)
        {
            if (inputString == null)
                throw new ArgumentNullException(nameof(inputString));

            if (cmp?.Address?.City == null)
                throw new ArgumentNullException(nameof(cmp));
        }

    }
}
