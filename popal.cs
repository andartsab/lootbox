using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popal : MonoBehaviour
{
    static int num = 0;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        print("Got it!");
            num = num + 1;
            if (num == 1)
        {
            print(num + " " + "point");
        }
        else
        {
            print(num + " " + "points");
        }
            Destroy(gameObject);
            
    }
}
