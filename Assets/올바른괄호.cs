using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 올바른괄호 : MonoBehaviour
{
    public bool solution(string s)
    {
        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                j++;
            else
            {
                if (j == 0)
                    return false;
                else
                    j--;
            }
        }

        return j == 0;
    }
}
