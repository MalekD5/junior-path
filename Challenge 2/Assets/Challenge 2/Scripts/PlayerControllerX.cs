using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool cooldown = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cooldown)
            {
                return;
            }


            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = true;
            Invoke("clearCooldown", 1);
        }
    }

    void clearCooldown()
    {
        cooldown = false;
    }
}
