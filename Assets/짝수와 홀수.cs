using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 짝수와홀수 : MonoBehaviour
{
    public class Solution
    {
        public string solution(int num)
        {
            string answer = "";

            if (num % 2 == 0)
            {
                answer = "Even";
            }
            else
            {
                answer = "Odd";
            }

            return answer;
        }
    }
}
