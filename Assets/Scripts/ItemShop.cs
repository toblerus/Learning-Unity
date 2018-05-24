using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemShop : MonoBehaviour {
    [SerializeField] float idleAxeSpeed;
    [SerializeField] CashManager cashManager;
    public Tapping theTappingScript;
    public GameObject shopView;
    public GameObject IdleAxeBuyButton;
    public Text hitsText;
    public Text logsText;
    public Text cashText;

    private void Start()
    {
        
    }
    public void ShopView()
    {
        if (shopView.activeInHierarchy == true)
        {
            shopView.SetActive (false);
        }
        else
        {
            shopView.SetActive(true);
        }
    }
    public void IdleAxeBuy()
    {
        if (cashManager.CurrentCash >= 50)
        {
            IdleAxeBuyButton.SetActive(false);
            cashManager.CurrentCash -= 50;
            cashText.text = "Cash: " + cashManager.CurrentCash.ToString() + "$";
            InvokeRepeating("IdleAxeFunction", 0f, idleAxeSpeed);

        }
    }
    void IdleAxeFunction()
    {
        theTappingScript.TreeHit();
    }
}
