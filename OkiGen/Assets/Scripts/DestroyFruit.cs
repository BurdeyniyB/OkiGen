using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFruit : MonoBehaviour
{
       void OnCollisionEnter(Collision col)
       {
           if (col.gameObject.tag == "Destroy")
           {
             Destroy(this.gameObject);
           }
       }
}
