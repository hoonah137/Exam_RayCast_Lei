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
            RaycastHit hit;   

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                if (hit == true)
                {
                    count --;

                    if (count == 0 && hit.layer == 6)
                    {
                        Debug.Log("Open scene 1");
                    }

                    if (count == 0 && hit.layer == 7)
                    {
                        Debug.Log("Open scene 3");
                    }

                    if (count == 0 && hit.layer == 8)
                    {
                        Debug.Log("Open scene 2");
                    }
                    
                }
            }
        }

    }
}
