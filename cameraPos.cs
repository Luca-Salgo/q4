using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    private void Update()
    {

        transform.position = player.position;         
    }
}
