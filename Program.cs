namespace Program
{
    class NumberGen
    {
        static void Main(String[] args)
        {   
         CalcArgue();
        }
        static void CalcArgue()
        {
           Random rnd = new Random();
          
          string _Ask = "Many: ";
          Console.WriteLine(_Ask);

          int RandPass = Convert.ToInt32(Console.ReadLine());

          for (int J = 0; J < RandPass; J++)
          {
             Console.WriteLine(rnd.Next());
          }
        }
    }
}
