using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 하샤드수 : MonoBehaviour
{
    public bool solution(int x)
    {
        bool answer = true;
        string n = x.ToString();
        int xx = 0;

        for (int i = 0; i < n.Length; i++)
        {
            xx += int.Parse(n.Substring(i, 1));
        }

        if (x % xx != 0)
        {
            answer = false;
        }

        return answer;
    }
}
