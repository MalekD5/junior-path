using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PropellerControllerX : MonoBehaviour
{

    private float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime, Space.Self);
    }

}
