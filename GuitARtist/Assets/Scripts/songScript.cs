using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class songScript : MonoBehaviour {
	public Text chordName; 
	public Text strum;
	private int dbNum;
	static float spLev = 2f;

	private string bob;
	private string beatle;
	private string tut;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void dbSong(int db)
	{
		dbNum = db;

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

		if (dbNum == 3) 
		{
			StartCoroutine (warmUpS ());
		}
	}

	public void waitSpeed(float sp)
	{
		spLev = sp;
		Debug.Log ("Speed set" + spLev);
	}

	IEnumerator bobDylan()
	{
		bob = "G D C ; G D a: G D C- G D a- G D C; G D C: G D C: G D C: G D C. G D a: G D C: G D a: G D C; G D C: G D C: G D C: G D C";
		WaitForSeconds wait = new WaitForSeconds (spLev);
		print ("Waiting for time: " + spLev);
		yield return wait;
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

			if (c.ToString() == ":") 
			{
				chordName.text = "Next Line";
			}

			yield return wait;
		}
	}

	IEnumerator beatles()
	{
		beatle = "G C. ; G C- G C- G C- C C G- G C- G C- G C- C C G; D CFG- D CFG. G C. ; G C- G C- G C- C C G- G C- G C- G C- C C G";
		WaitForSeconds wait = new WaitForSeconds (spLev);
		yield return wait;
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

			if (c.ToString() == "-") 
			{
				chordName.text = "Next Line";
			}

			yield return wait;
		}
	}

	IEnumerator warmUpS()
	{ 
		WaitForSeconds wait = new WaitForSeconds (3f);
		yield return wait;
		strum.text = "D - Strum all strings DOWN in one swipe";
		yield return wait;
		strum.text = "U - Strum all strings UP in one swipe";
		yield return wait;
		strum.text = "Alternate between D and U for practice";
		StartCoroutine(warmUpC());
	}

	IEnumerator warmUpC()
	{
		tut = "A a b C D E e F f G. A a b C D E e F f G";
		WaitForSeconds wait = new WaitForSeconds (3f);
		yield return wait;

		foreach (char c in tut) 
		{
			chordName.text = c.ToString ();
			if (c.ToString () == ".") 
			{
				chordName.text = "Keep Repeating";
			}

			yield return wait;
		}
	}
}
