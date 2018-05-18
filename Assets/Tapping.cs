using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tapping : MonoBehaviour {
    [SerializeField] float logs;
    [SerializeField] float maxLogs;
    [SerializeField] int hits;
    [SerializeField] CashManager cashManager;
    [SerializeField] int cashIncrease = 10;
    public Text hitsText;



    void Start ()
    {


	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void TreeHit()
    {
        hits += 1;
        hitsText.text = "Hits: " + hits.ToString();



    }
    public void CashIncrease()
    {
        cashManager.CurrentCash += cashIncrease;
    }
}
