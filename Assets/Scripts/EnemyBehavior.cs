using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public PlayerHealth beeH;
    public GameObject PM = null;
    public float walkSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (PM == null)
        {
            PM = GameObject.Find("Player"); //Finds the Player Object FBX
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * walkSpeed, Space.Self);
        transform.LookAt(PM.transform);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            {
                other.collider.GetComponent<PlayerController>().PM.DealDamage(10); 
            }
        }
    }
}
