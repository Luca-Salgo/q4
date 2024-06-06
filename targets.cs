using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targets : MonoBehaviour
{

    public float health = 1f;


    public void onHit(float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Delete();
        }
       
        


    }

    void Delete()
    {
        Destroy(gameObject);
    }

}
