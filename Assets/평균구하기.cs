using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 평균구하기 : MonoBehaviour
{
    public class Solution
    {
        public double solution(int[] arr)
        {

            double answer = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                answer += arr[i];
            }

            answer = answer / arr.Length;

            return answer;
        }
    }
}
