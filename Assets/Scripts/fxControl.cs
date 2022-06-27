using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class fxControl : MonoBehaviour
{
    public float Speed = 4.5f;
    public int upOrDown=1;


    void Update()
    {
        transform.position +=upOrDown*transform.up * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "barrier")
        {
            
            Destroy (gameObject);
        }
            
        
    }
}
