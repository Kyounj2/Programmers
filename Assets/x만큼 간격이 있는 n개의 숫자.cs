using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x만큼간격이있는n개의숫자 : MonoBehaviour
{
    public class Solution
    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];

            for (long i = 1; i <= n; i++)
            {
                answer[i - 1] = x * i;
            }
            return answer;
        }
    }
}
