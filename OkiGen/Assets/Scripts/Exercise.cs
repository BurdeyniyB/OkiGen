using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise : MonoBehaviour
{
    public static Exercise instance;
    [SerializeField] private Text exerciseText;
    [SerializeField] private Text CollectedText;
    [SerializeField] private Color color;
    [SerializeField] private GameObject anim;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject[] FruitsForAnimation;
    [SerializeField] private string[] fruts;
    int randomCount;
    int randomFruit;
    int collect;

	void Awake () {
        if (instance == null)
            instance = this;
	}

	void Update()
	{
	   CollectedText.text = collect + " / " + randomCount;

	  if(collect == randomCount)
	  {
	    CollectedText.color = color;
	    ClickOnFruit.instance.StartPosition();

	    gameOver.instance.Over();
	  }
	}

    void Start()
    {
      randomFruit = Random.Range(0, 3);
      randomCount = Random.Range(1, 6);

      exerciseText.text = "Collect " + randomCount + " " + fruts[randomFruit];
    }

    public void Take(string name)
    {
      if(name == fruts[randomFruit])
      {
        anim.SetActive(false);
        anim.SetActive(true);
        anim.GetComponent<Animator>().Play("Text +");

        collect++;
        ClickOnFruit.instance.IsAnim();
      }
    }

    public void AnimBasket()
    {
      Player.GetComponent<Animator>().Play("basket");
    }

    public void FruitsForAnimationTrue(string name)
    {
      for(int i = 0; i < fruts.Length; i++)
      {
        if(name == fruts[i])
        {
           FruitsForAnimation[i].SetActive(true);
        }
      }
    }

    public void FruitsForAnimationFalse(string name)
    {
      for(int i = 0; i < fruts.Length; i++)
      {
        if(name == fruts[i])
        {
           FruitsForAnimation[i].SetActive(false);
        }
      }
    }
}
