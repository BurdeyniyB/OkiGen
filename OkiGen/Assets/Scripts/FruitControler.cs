using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitControler : MonoBehaviour
{
    public static FruitControler instance;
    [SerializeField] private GameObject[] SpawnObjPrefabs;
    [SerializeField] private Transform transformX;
    [SerializeField] private List<GameObject> create = new List<GameObject>();
    [SerializeField] private float Forse;
    [SerializeField] private float time;

    private int random;
    int i = 0;
    bool x = true;

	void Awake () {
        if (instance == null)
            instance = this;
	}

    public void StartGame()
    {
        StartCoroutine(Spawn_and_set_velocity());
    }

    public void ListUpdate()
    {
        Debug.Log("Null");
        for(int a = 0; a < create.Count; a++)
        {
          if(a != create.Count-1)
          {
            create[a] = create[a+1];
          }
        }
    }

    IEnumerator Spawn_and_set_velocity()
    {
      while(x)
      {
          random = Random.Range(0, SpawnObjPrefabs.Length);
          create.Add(Instantiate(SpawnObjPrefabs[random], transformX));
          create[i].transform.position = transformX.position;

          create[i].GetComponent<Rigidbody>().velocity = new Vector3(-Forse, 0, 0);

          i++;

          yield return new WaitForSeconds(time);
      }
    }
}
