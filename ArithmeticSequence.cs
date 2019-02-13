using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
           
            if(count<1)
            {
                throw new NotImplementedException();
            }
            int result=0;
            for (int a=0;a<count;a++)
            {
                result += number;
                if (a > 0)
                {
                    for (int i=0;i<a;i++)
                    {
                        result += add;
                    }
                }
            }
            return result;
        }
    }
}
