﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tapping : MonoBehaviour {
    [SerializeField] float maxLogs;
    [SerializeField] int hits;
    [SerializeField] CashManager cashManager;
    [SerializeField] LogsManager logsManager;
    [SerializeField] int cashIncrease = 10;
    [SerializeField] int logsIncrease = 1;
    [SerializeField] float secondsToSell = 1;
    public Text hitsText;
    public Text logsText;
    public Text cashText;

    void Start ()
    {
        InvokeRepeating("LogSell", 0f, secondsToSell);

    }

    void Update ()
    {
       
	}

    public void TreeHit()
    {
        if (hits <= 1)
        {
            hits += 1;
            hitsText.text = "Hits: " + hits.ToString();
        }
        else
        {
            hits = 0;
            hitsText.text = "Hits: " + hits.ToString();
            LogsIncrease();

        }

    }
    public void CashIncrease()
    {
        cashManager.CurrentCash += cashIncrease;
        cashText.text = "Cash: " + cashManager.CurrentCash.ToString() + "$";
        PlayerPrefs.SetInt("CurrentCash", cashManager.CurrentCash);


    }
    public void LogsIncrease()
    {
        logsManager.CurrentLogs += logsIncrease;
        logsText.text = "Logs: " + logsManager.CurrentLogs.ToString();

    }
    public void LogSell()
    {
        if (logsManager.CurrentLogs >= 1)
        {
            logsManager.CurrentLogs--;
            logsText.text = "Logs: " + logsManager.CurrentLogs.ToString();
            CashIncrease();
        }
    }
}
