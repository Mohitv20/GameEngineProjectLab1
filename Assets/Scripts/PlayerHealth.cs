using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public float pHealth = 100.0f;

    public void DealDamage(float a)
    {
        pHealth -= a;

        if (pHealth <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
 

    // Update is called once per frame
    void Update()
    {

    }
}
