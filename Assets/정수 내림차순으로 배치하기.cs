using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class 정수내림차순으로배치하기 : MonoBehaviour
{
    public class Solution
    {
        public long solution(long n)
        {
            long answer = 0;
            char[] s;

            s = n.ToString().ToCharArray();

            Array.Sort(s);
            Array.Reverse(s);

            answer = long.Parse(s);

            return answer;
        }
    }
}
