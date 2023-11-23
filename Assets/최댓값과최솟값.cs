using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 최댓값과최솟값 : MonoBehaviour
{
    public string solution(string s)
    {
        int[] ints = Array.ConvertAll(s.Split(" ") , int.Parse);
        int min = 0;
        int max = 0;

        for (int i = 0; i < ints.Length; i++)
        {
            if (i<1)
            {
                min = ints[i];
                max = ints[i];
            }

            min = min < ints[i] ? min : ints[i];
            max = max > ints[i] ? max : ints[i];
        }

        return $"{min} {max}";
    }
}
