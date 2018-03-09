using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class streamChords : MonoBehaviour 
{
	public Text chord;
	private string revChord;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		chord.text = revChord;
		if (chord.text == "-") 
		{
			chord.text = "Non-Guitar tones here";
		}
	}

	public void receive(string chor)
	{
		revChord = chor;
	}
}
