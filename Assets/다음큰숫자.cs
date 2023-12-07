using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 다음큰숫자 : MonoBehaviour
{
    public int solution(int n)
    {
        int originOne = 0;
        int returnOne = 0;
        int answer = n;

        string s = Convert.ToString(n, 2);
        foreach (var num in s)
        {
            if (num == '1') originOne++;
        }

        while (originOne != returnOne)
        {
            returnOne = 0;
            answer++;

            s = Convert.ToString(answer, 2);
            foreach (var num in s)
            {
                if (num == '1') returnOne++;
            }
        }

        return answer;
    }

}
