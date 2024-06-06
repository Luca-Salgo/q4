
using UnityEngine;

public class spheres : MonoBehaviour
{
    public GameObject mySphere;




    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Vector3 randomlySpawn = new Vector3(Random.Range(-5, 5), 5, Random.Range(-5, 5));
            Instantiate(mySphere, randomlySpawn, Quaternion.identity);


        }





    }








}
