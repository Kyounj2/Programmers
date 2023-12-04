using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 최솟값만들기 : MonoBehaviour
{
    public int solution(int[] A, int[] B)
    {
        int answer = 0;
        Array.Sort(A);
        Array.Sort(B);
        Array.Reverse(B);

        for (int i = 0; i < A.Length; i++)
        {
            answer += A[i] * B[i];
        }

        return answer;
    }
}
