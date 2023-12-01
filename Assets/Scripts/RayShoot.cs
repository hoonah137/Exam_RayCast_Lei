using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayShoot : MonoBehaviour
{

    Transform _cam;
    public int count;
    Text _text;


    // Start is called before the first frame update
    void Start()
    {
        _cam = Camera.main.transform;
        count = 5;
        _text = GetComponentInChildren<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        RayCasting();
        _text.text = count.ToString();
    }

    void RayCasting()
    {
       if (Input.GetButtonDown("Fire1"))
       {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            count --;
            

            if (count == 0)
            {
               if (hit.transform.gameObject.layer == 6)
               {
                Debug.Log("cubo1");
               }

               if (hit.transform.gameObject.layer == 7)
               {
                Debug.Log("cubo2");
               }

               if (hit.transform.gameObject.layer == 8)
               {
                Debug.Log("pelota");
               }
            }
        }
       }
        
       
    }
}
