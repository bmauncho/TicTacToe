using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 Rot_x;
    Vector3 Rot_o;
    Vector3 Rot;

    // Start is called before the first frame update
    void Start()
    {
        Rot = new Vector3 (0,0,90);
        Rot_o = new Vector3(0,0,180);
        Rot_x = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            // Debug.Log("mouseDown");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if(Physics.Raycast(ray,out Hit))
            {
                if(Hit.transform.GetComponentInParent<BoxController>() != null)
                {
                    Debug.Log("hit");
                    //rotate cube
                    
                    Hit.transform.GetComponentInParent<BoxController>().Rotate(Rot_x,.9f);
                }
                
            }
            Debug.DrawRay(ray.origin, ray.direction * 15,Color.black);
        }
    }
    

}
