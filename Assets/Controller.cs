using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("bat dau");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Press.A");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Press.D");
        }
    }
}
