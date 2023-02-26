using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 Rot_x;
    Vector3 Rot_o;
    Vector3 Rot;
    public int Rotation;
    public bool iSPlayerPlaying = false;
    public float rotSpeed = 100f;
    RaycastHit Hit;

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
        if(Input.GetMouseButtonDown(0))
        {
            iSPlayerPlaying = true;
            // Debug.Log("mouseDown");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if(Physics.Raycast(ray,out Hit))
            {
                if(Hit.transform.GetComponentInParent<BoxController>() != null)
                {
                    Debug.Log("hit");
                    //rotate cube
                    switch(Rotation)
                    {
                        case 1:// x
                        Hit.transform.GetComponentInParent<BoxController>().Rotate(Rot_x,rotSpeed*Time.deltaTime);
                            break;
                        case 2:// o
                        Hit.transform.GetComponentInParent<BoxController>().Rotate(Rot_o,rotSpeed*Time.deltaTime);
                            break;
                    }     
                }
                
            }
            Debug.DrawRay(ray.origin, ray.direction * 15,Color.black);
        }

        if(Input.GetMouseButtonUp(0) && iSPlayerPlaying)
        {
            iSPlayerPlaying = false;
        }   
    }
    

}
