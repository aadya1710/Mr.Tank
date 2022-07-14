using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankControl tankControl;
    private float movement;
    private float rotation;
    public Rigidbody rb;
    public MeshRenderer[] childs;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (movement != 0)
        {
            tankControl.Move(movement, tankControl.GetTankModel().movementSpeed);
        }
        if(rotation != 0)
        {
            tankControl.Rotate(rotation, tankControl.GetTankModel().rotationSpeed);
        }
    }
    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }
    public void SetUpTankController(TankControl _tankControl)
    {
        tankControl = _tankControl;
    }

    public Rigidbody getrigidbody()
    {
        return rb;
    }

    public void ChangeColor(Material color)
    {
        for(int i = 0; i < childs.Length; i++)
        {
            childs[i].material = color;
        }
    }
}
