using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 자릿수더하기 : MonoBehaviour
{
    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            string s = n.ToString();

            for (int i = 0; i < s.Length; i++)
            {
                string t = s.Substring(i, 1);
                answer += int.Parse(t);
            }

            return answer;
        }
    }
}
