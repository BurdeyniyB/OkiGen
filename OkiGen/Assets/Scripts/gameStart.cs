using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{
    [SerializeField] private GameObject Exercise;
    [SerializeField] private GameObject collected;
    [SerializeField] private GameObject Start_Button;

    public void StartFruitControler()
    {
        FruitControler.instance.StartGame();
        PlayerPrefs.SetInt("Click", 1);
        Exercise.SetActive(true);
        collected.SetActive(true);
        Start_Button.SetActive(false);
    }
}
