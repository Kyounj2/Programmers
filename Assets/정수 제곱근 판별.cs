using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 정수제곱근판별 : MonoBehaviour
{
    public class Solution
    {
        public long solution(long n)
        {
            long answer = 0;

            for (long i = 1; i <= n; i++)
            {
                if (i * i == n)
                {
                    answer = (i + 1) * (i + 1);
                    break;
                }
                else if (i == n)
                {
                    answer = -1;
                    break;
                }
            }
            return answer;
        }
    }
}
