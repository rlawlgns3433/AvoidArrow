using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hpGage;
    private float remainHp;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGage = GameObject.Find("hpGage");
        remainHp = this.hpGage.GetComponent<Image>().fillAmount;
    }

    public void DecreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;

        if (this.hpGage.GetComponent<Image>().fillAmount <= 0)
        {
            Application.Quit(0);
        }
    }
}
