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
    public GameObject AxeModelInScene;
    public Text hitsText;
    public Text logsText;
    public Text cashText;

    private void Start()
    {
        
    }
    public void UpdateShopDisplay()
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
        if (cashManager.CurrentCash >= 50)
        {
            IdleAxeBuyButton.SetActive(false);
            AxeModelInScene.SetActive(true);
            cashManager.CurrentCash -= 50;
            cashText.text = "Cash: " + cashManager.CurrentCash.ToString() + "$";
            InvokeRepeating("IdleAxeFunction", 0f, idleAxeSpeed);

        }
    }
    void IdleAxeFunction()
    {
        theTappingScript.TreeHit();
    }

	public void Buy("Insert class here") //Maybe add a tag to the button, that states, which Item I want to buy?
	{
		if (cashManager.CurrentCash >= InsertedClass.price)
		{
			if (InsertedClass.currentLevel == upgradeLevelMax)
			{
			IdleAxeBuyButton.SetActive(false);
			}
			cashManager.CurrentCash -= InsertedClass.price;
			cashText.text = "Cash: " + cashManager.CurrentCash.ToString() + "$";

		}
}
