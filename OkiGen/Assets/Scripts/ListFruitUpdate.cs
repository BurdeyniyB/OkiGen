using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListFruitUpdate : MonoBehaviour
{
       void OnCollisionEnter(Collision col)
       {
           if (col.gameObject.tag == "Fruit")
           {
             FruitControler.instance.ListUpdate();
           }
       }
}
