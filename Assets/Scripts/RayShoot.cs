using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShoot : MonoBehaviour
{

    Transform _cam;
    public int count;


    // Start is called before the first frame update
    void Start()
    {
        _cam = Camera.main.transform;
        count = 5;

    }

    // Update is called once per frame
    void Update()
    {
        RayCasting();
    }

    void RayCasting()
    {
       if (Input.GetButtonDown("Fire1"))
       {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Debug.Log("Shoot");
        }
       }
        
       
    }
}
