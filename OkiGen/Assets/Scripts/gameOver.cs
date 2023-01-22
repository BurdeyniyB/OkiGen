using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    public static gameOver instance;
    [SerializeField] private GameObject Conveyor;
    [SerializeField] private GameObject ConveyorAudio;
    [SerializeField] private GameObject NextLevel;
    [SerializeField] private GameObject Session;
    [SerializeField] private GameObject PlayerAnim;
    [SerializeField] private GameObject CameraAnim;
    [SerializeField] private float time;

	void Awake () {
        if (instance == null)
            instance = this;
	}

    public void Over()
    {
      Conveyor.SetActive(false);
      ConveyorAudio.SetActive(false);
      Session.SetActive(false);

      NextLevel.SetActive(true);
      StartCoroutine(Dance());
    }

    IEnumerator Dance()
    {
        CameraAnim.GetComponent<Animator>().Play("Camera");

        yield return new WaitForSeconds(time);

        PlayerAnim.SetActive(false);
        PlayerAnim.SetActive(true);
        PlayerAnim.GetComponent<Animator>().Play("Dance");
        PlayerPrefs.SetInt("Win", 1);
    }
}
