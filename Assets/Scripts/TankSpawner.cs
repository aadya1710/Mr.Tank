using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankprefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tankprefab, transform.position, Quaternion.identity);//quaternion is used to avoid any rotation
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
