using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mimo : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
        print("Miss!");
    }
}
