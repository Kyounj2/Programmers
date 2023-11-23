using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 두정수사이의합 : MonoBehaviour
{
        public long solution(int a, int b)
        {
            long c = 0;

            for (int i = b>=a? a:b ; i < (a >= b ? a : b); i++)
            {
                c += i;
            }

            return c;
        }
}
