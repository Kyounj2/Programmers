using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 피보나치수 : MonoBehaviour
{
    public int solution(int n)
    {
        int[] answer = new int[n + 1];
        answer[0] = 0;
        answer[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            answer[i] = answer[i - 1] % 1234567 + answer[i - 2] % 1234567;
        }

        return answer[n] & 1234567;
    }
}
