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
		
	}

	public void receive(string chor)
	{
		revChord = chor;
		WaitForSeconds wait = new WaitForSeconds (2f);
		yield return wait;
		foreach (char c in revChord) 
		{
			chord.text = c.ToString();

			if (c.ToString() == "-") 
			{
				chord.text = "Non Guitar tones here";
			}

			yield return wait;
		}
	}
}
