using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 이진변환반복하기 : MonoBehaviour
{
    public int[] solution(string s)
    {
        int[] answer = new int[2] {0,0};

        while (s != "1")
        {
            answer[0]++;

            int one = 0;
            foreach (var num in s)
            {
                if (num == '1') one++;
                else answer[1]++;
            }

            s = Convert.ToString(one, 2);
        }

        return answer;
    }
}
