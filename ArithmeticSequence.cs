using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {

            if (count <= 0)
            {
                throw new ArgumentException("count <= 0");
            }
            int result = 0;
            for (int a = 0; a < count; a++)
            {
                try
                {
                    checked
                    {
                        result += number;
                    }
                    if (a > 0)
                    {
                        for (int i = 0; i < a; i++)
                        {
                            checked
                            {
                                result += add;
                            }

                        }
                    }
                } catch (OverflowException ex)
                { 
                    throw new OverflowException();
                }
            }
            return result;
        }
    }
}
