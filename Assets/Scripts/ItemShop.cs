using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemShop : MonoBehaviour {
    [SerializeField] float idleAxeSpeed;
    [SerializeField] CashManager cashManager;
    public Tapping theTappingScript;
    public GameObject ShopView;
    public GameObject IdleAxeBuyButton;
    public Text hitsText;
    public Text logsText;
    public Text cashText;

    private void Start()
    {
        
    }
    public void shopView()
    {
        if (ShopView.activeInHierarchy == true)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            ShopView.SetActive(false);

            ShopView.SetActive (false);

=======
            shopView.SetActive (false);
>>>>>>> parent of 14d6347... Renamed tree asset
=======
            shopView.SetActive (false);
>>>>>>> parent of 14d6347... Renamed tree asset
        }
        else
        {
            ShopView.SetActive(true);
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
