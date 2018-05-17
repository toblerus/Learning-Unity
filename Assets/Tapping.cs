using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tapping : MonoBehaviour {
    [SerializeField] float logs;
    [SerializeField] float maxLogs;
    [SerializeField] float cashearnings;
    [SerializeField] float currentcash;
    [SerializeField] int hits;
    public Text hitsText;
    [SerializeField] public Button HitButton;


    void Start ()
    {
        Button HitButton = HitButton.GetComponent<Button>();

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void treehit()
    {
        hits += 1;
        hitsText.text = "Hits: " + hits.ToString();

    }
}
