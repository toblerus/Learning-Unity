using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemShop : MonoBehaviour {
    [SerializeField] float idleAxeSpeed;
    public Tapping theTappingScript;
    public GameObject ShopView;
    public GameObject IdleAxeBuyButton;
    private void Start()
    {
        
    }
    public void shopView()
    {
        if (ShopView.activeInHierarchy == true)
        {
            ShopView.SetActive (false);
        }
        else
        {
            ShopView.SetActive(true);
        }
    }
    public void IdleAxeBuy()
    {
        int cashCheck = PlayerPrefs.GetInt("CurrentCash");
        if (cashCheck >= 50)
        {
            IdleAxeBuyButton.SetActive(false);
            InvokeRepeating("IdleAxeFunction", 0f, idleAxeSpeed);
        }
    }
    void IdleAxeFunction()
    {
        theTappingScript.TreeHit();
    }
}
