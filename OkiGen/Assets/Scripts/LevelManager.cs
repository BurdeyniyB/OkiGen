using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private string SceneName;
        [SerializeField] private Button PlayButton;

        void Start()
        {
            PlayButton = GetComponent<Button>();
            PlayButton.onClick.AddListener (Task);
        }

        public void Task()
        {
            PlayerPrefs.SetInt("Level manager click", 1);
            SceneManager.LoadScene(SceneName);
        }

    }
