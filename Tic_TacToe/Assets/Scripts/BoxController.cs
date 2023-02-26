using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Rotate(Vector3 Rot,float rotTime)
    {
        Pump();
        Vector3 NewRot = new Vector3(Rot.x,Rot.y,Rot.z); 
        transform.eulerAngles = Vector3.Slerp(transform.eulerAngles,NewRot,rotTime);
        Invoke("DePump",.5f);
    }

    public void Pump()
    {
        transform.DOScale(1.3f,.5f);
    }

    public void DePump(){
        transform.DOScale(1f,.5f);
    }
}
