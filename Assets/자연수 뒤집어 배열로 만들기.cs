using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 자연수뒤집어배열로만들기 : MonoBehaviour
{
    public class Solution
    {
        public int[] solution(long n)
        {

            string s = n.ToString();

            int[] answer = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                answer[i] = int.Parse(s.Substring(s.Length - i - 1, 1));
            }

            return answer;
        }
    }
}
