using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 약수의합 : MonoBehaviour
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    answer += i;
                }
                else
                {
                    continue;
                }

            }

            return answer;
        }
    }
}
