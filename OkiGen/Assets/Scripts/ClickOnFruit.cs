using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnFruit : MonoBehaviour
{
    public static ClickOnFruit instance;
    [SerializeField] private GameObject Child;
    [SerializeField] private GameObject RAIK;
    [SerializeField] private GameObject RAIK_start_position;
    [SerializeField] private GameObject basketObj;
    [SerializeField] private string name;
    float time = 0.85f;
    bool transformAnim = false;
    bool IsnotAnim = true;

	void Awake () {
        if (instance == null)
            instance = this;
	}

    void Start()
    {
      basketObj = GameObject.Find("CubeBasket");
      RAIK = GameObject.Find("RAIK_target");
      RAIK_start_position = GameObject.Find("RAIK_start_position");
    }

    private void OnMouseDown()
    {
      if(IsnotAnim)
       {
          IsnotAnim = false;
          PlayerPrefs.SetInt("Set", 1);

          GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
          transformAnim = true;

          StartCoroutine(Waiting());
       }
    }

    IEnumerator Waiting()
    {
      RAIK.transform.position = transform.position;
      yield return new WaitForSeconds(0.1f);

      RAIK.transform.position = RAIK_start_position.transform.position;
      Exercise.instance.AnimBasket();
      Exercise.instance.FruitsForAnimationTrue(name);
      Child.SetActive(false);
      yield return new WaitForSeconds(time);

      Child.SetActive(true);
      transform.position = basketObj.transform.position;
      GetComponent<Rigidbody>().useGravity = true;
      Exercise.instance.FruitsForAnimationFalse(name);

      yield return new WaitForSeconds(time * 1.25f);
      transform.SetParent(basketObj.transform);
      Exercise.instance.Take(name);
    }

    public void IsAnim()
    {
      IsnotAnim = true;
    }

    public void StartPosition()
    {
      RAIK.transform.position = RAIK_start_position.transform.position;
    }
}
