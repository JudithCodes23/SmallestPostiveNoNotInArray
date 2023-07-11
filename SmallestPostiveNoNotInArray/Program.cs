using System;
using System.Collections;
using System.Collections.Generic;

class Solution
{

    public static void Main ()
    {
        int[] A = new int[] { 1, 2,3, 5, 7, 9 };

        solution(A);
    }
    public static int solution(int[] A)
    {

        int smallestPostive = 1;

        //sort the given array
        Array.Sort(A);

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] <= 0)
                continue;
            else if (A[i] == smallestPostive)
            {
                smallestPostive++;
            }
        }

        return smallestPostive;
    }

}