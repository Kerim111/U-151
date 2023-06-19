using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.U2D;
using UnityEngine;

public class Inretaction : MonoBehaviour
{
    [SerializeField]
    float ButtonDistance;
    Camera camera;
    bool transfer = false;
    private void Awake()
    {
        camera = GetComponent<Camera>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
        }
        if (Input.GetButtonUp("Fire1")) 
        {
            transfer = false;
        }
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Interact_Button();
        }
    }
    void Interact_Button() 
    {
        RaycastHit LookForButton;
        if (Physics.Raycast(transform.position,camera.transform.TransformDirection(Vector3.forward), out LookForButton, ButtonDistance, LayerMask.GetMask("Button")))
        {
            LookForButton.rigidbody.gameObject.GetComponent<Button>().Button_interaction();
        }
    }
    void MoveMovableObject() 
    {
        RaycastHit LookForMovable;
        if (Physics.Raycast(transform.position, camera.transform.TransformDirection(Vector3.forward), out LookForMovable, ButtonDistance, LayerMask.GetMask("Button")))
        {
            float Distance = LookForMovable.distance;
            //Vector3 target = Vector3.Clam
        }
    }

}
