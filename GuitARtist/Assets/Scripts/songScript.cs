using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class songScript : MonoBehaviour {
	public Text chordName; 
	public Text strum;
	private int dbNum;

	private string bob;
	private string beatle;

	// Use this for initialization
	void Start () 
	{
		if (dbNum == 1) 
		{
			strum.text = "D D U D for each chord displayed";
			StartCoroutine (bobDylan ());
		}

		if (dbNum == 2) 
		{
			strum.text = "D D U U D U for each chord displayed";
			StartCoroutine (beatles ());
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void dbSong(int db)
	{
		dbNum = db;
	}

	IEnumerator bobDylan()
	{
		bob = "G D C ; G D a- G D C- G D a- G D C; G D C- G D C- G D C- G D C. G D a- G D C- G D a- G D C; G D C- G D C- G D C- G D C";
		WaitForSeconds wait = new WaitForSeconds (2f);
		foreach (char c in bob) 
		{
			chordName.text = c.ToString();
			if (c.ToString() == ";") 
			{
				if (chordName.text == "Verse") 
				{
					chordName.text = "Chorus";
				} else 
				{
					chordName.text = "Verse";
				}
			}

			if (c.ToString() == ".") 
			{
				chordName.text = "Keep Repeating";
			}
			yield return wait;

			if (c.ToString() == "-") 
			{
				chordName.text = "Next Line";
			}
		}
	}

	IEnumerator beatles()
	{
		beatle = "G C. ; G C- G C- G C- C C G- G C- G C- G C- C C G; D CFG- D CFG. G C. ; G C- G C- G C- C C G- G C- G C- G C- C C G";
		WaitForSeconds wait = new WaitForSeconds (2f);
		foreach (char c in beatle) 
		{
			chordName.text = c.ToString();
			if (c.ToString() == ";") 
			{
				if (chordName.text == "Verse") 
				{
					chordName.text = "Chorus";
				} else 
				{
					chordName.text = "Verse";
				}
			}

			if (c.ToString() == ".") 
			{
				chordName.text = "Keep Repeating";
			}
			yield return wait;

			if (c.ToString() == "-") 
			{
				chordName.text = "Next Line";
			}
		}

	}
}
