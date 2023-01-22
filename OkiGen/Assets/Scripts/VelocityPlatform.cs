using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityPlatform : MonoBehaviour
{
        [SerializeField] private float Forse;
        [SerializeField] private Transform transformX;
        [SerializeField] private Transform transformX2;

        void Start()
        {
          GetComponent<Rigidbody>().velocity = new Vector3(-Forse, 0, 0);
        }

       void Update()
       {
         if(transform.position.x < transformX2.position.x)
         {
           transform.position = transformX.position;
         }
       }
}
