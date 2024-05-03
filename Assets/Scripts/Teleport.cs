using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform dest;

    // Start is called before the first frame update
    public Transform GetDest()
    {
        return dest;
    }
}
