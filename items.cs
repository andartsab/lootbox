using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items : MonoBehaviour
{
    static int num = 0;

    void OnMouseDown()
    {
        if (num < 3)
        {
            num = num + 1;
            print(num);
            Destroy(gameObject);
            print("Ты выбрал" + gameObject);
        }
        else
        {
            print("Твой рюкзак полный");
        }
    }
}
