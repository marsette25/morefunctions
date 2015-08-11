using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFunctions
{
    public class CoolFunctions
    {
        public static int iterfactorial(int n)
        {
            int answer = 1;
            for (var i = n; i >= 1; i--)
            {
                answer *= i;
            }
            return answer;
        }

        public static int recurfactorial(int n)
        {
            if (n != 1)
            {
                return n*recurfactorial(n - 1);
            } else
            {
                // This is the base case
                return n;
            }
        }

        public static int[] InsertionSort(int[] inputs)
        {
            var answer = new int[inputs.Length];
            var temp = new int[inputs.Length];
            int[] copy_of_inputs = inputs.Clone() as int[];
            for (var i = 0;i < inputs.Length; i++) {
                var item = inputs[i];
                for (var j = 0;j < temp.Length; j++)
                {
                    var second_item = inputs[j];
                    if (item > second_item)
                    {
                        var tmp1 = item;
                        var tmp2 = second_item;
                        item = tmp2;
                        second_item = tmp1;
                    } else
                    {
                        // Leave it?
                    }

                }

                //var item2 = inputs[i+1];
            }
            return answer;
        }
    }
}
