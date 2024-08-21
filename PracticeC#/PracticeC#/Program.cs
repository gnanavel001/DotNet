using System;
using thiskeyword;

namespace practice
{
    public class practice
    {
        public int loading;
        public int total;
        public practice()
        {
            loading = 0;
            total = 0;
        }
        public static int AbsoluteOfSum(int a, int b)
        {
            int sum1 = Math.Abs(a);
            return sum1;
        }

        List<int> returnpostive(int[] number)
        {
            List<int> values = [];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 0)
                {
                    values.Add(number[i]);
                }
            }
            return values;
        }



        static void Main(string[] args)
        {
            practice practiceobj = new practice();
            int[] sampleArray = [10, 1, 1, -2, -5, -10];
           var outputValue = practiceobj.returnpostive(sampleArray);
            foreach(int i in outputValue)
            {
                Console.WriteLine(i);
            }
          
        }
    }
}
