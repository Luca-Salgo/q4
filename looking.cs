using System.Collections;
using System.Collections.Generic;
using UnityEngine;







public class looking : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform player;

    float Xrotation;
    float Yrotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    private void Update()
    {
        float MouseX = Input.GetAxisRaw("Mouse X")*Time.deltaTime*sensX;
        float MouseY = Input.GetAxisRaw("Mouse Y")*Time.deltaTime*sensY;

        Yrotation += MouseX;
        Xrotation -= MouseY;
        Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(Xrotation, Yrotation, 0);
        player.rotation = Quaternion.Euler(0, Yrotation, 0);

        player.Rotate(Vector3.up * MouseX);

    }








}
