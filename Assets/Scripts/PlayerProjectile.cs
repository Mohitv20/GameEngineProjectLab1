using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerProjectile : MonoBehaviour

{
    public MeshRenderer Bee;
    public MeshRenderer Shiny;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "BeeEnemy")
        {
            {
                other.collider.GetComponent<EnemyBehavior>().beeH.DealDamage(20);
                //Object.GetComponent<MeshRenderer>().material = Shiny;
            }
        }
    }


}