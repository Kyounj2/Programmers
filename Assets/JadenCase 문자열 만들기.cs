using UnityEngine;

public class JadenCase문자열만들기 : MonoBehaviour
{
    public string solution(string s)
    {
        string[] strings = s.Split(" ");
        string answer = "";

        for (int i = 0; i < strings.Length; i++)
        {
            for (int j = 0; j < strings[i].Length; j++)
            {
                string subs = strings[i].Substring(j, 1);

                if (j < 1)
                    answer += subs.ToUpper();
                else
                    answer += subs.ToLower();
            }
            if (i != strings.Length - 1)
                answer += " ";
        }
        return answer;
    }
}
