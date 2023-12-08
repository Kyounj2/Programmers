using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 피보나치수 : MonoBehaviour
{
    public int solution(int n)
    {
        int answer = 0;

        for (int i = 1; i < n; i++)
        {
            answer += answer + n;
        }

        return answer;
    }
}
