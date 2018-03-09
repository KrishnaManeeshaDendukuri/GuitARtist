using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chordScript : MonoBehaviour 
{
	public Text chord;
	public GameObject frame;
	public GameObject A;
	public GameObject aminor;
	public GameObject bminor;
	public GameObject C;
	public GameObject D;
	public GameObject E;
	public GameObject eminor;
	public GameObject F;
	public GameObject fminor;
	public GameObject G;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (chord.text == "A") 
		{
			A.SetActive (true);
			frame.SetActive (false);
			aminor.SetActive (false);
			bminor.SetActive (false);
			C.SetActive (false);
			D.SetActive (false);
			E.SetActive (false);
			eminor.SetActive (false);
			F.SetActive (false);
			fminor.SetActive (false);
			G.SetActive (false);
		} 

		else if (chord.text == "a") 
		{
			aminor.SetActive (true);
			frame.SetActive (false);
			A.SetActive (false);
			bminor.SetActive (false);
			C.SetActive (false);
			D.SetActive (false);
			E.SetActive (false);
			eminor.SetActive (false);
			F.SetActive (false);
			fminor.SetActive (false);
			G.SetActive (false);
		} 

		else if (chord.text == "b") 
		{
			bminor.SetActive (true);
			frame.SetActive (false);
			aminor.SetActive (false);
			A.SetActive (false);
			C.SetActive (false);
			D.SetActive (false);
			E.SetActive (false);
			eminor.SetActive (false);
			F.SetActive (false);
			fminor.SetActive (false);
			G.SetActive (false);
		} 

		else if (chord.text == "C") 
		{
			C.SetActive (true);
			frame.SetActive (false);
			aminor.SetActive (false);
			bminor.SetActive (false);
			A.SetActive (false);
			D.SetActive (false);
			E.SetActive (false);
			eminor.SetActive (false);
			F.SetActive (false);
			fminor.SetActive (false);
			G.SetActive (false);
		} 

		else if (chord.text == "D") 
		{
			D.SetActive (true);
			frame.SetActive (false);
			aminor.SetActive (false);
			bminor.SetActive (false);
			C.SetActive (false);
			A.SetActive (false);
			E.SetActive (false);
			eminor.SetActive (false);
			F.SetActive (false);
			fminor.SetActive (false);
			G.SetActive (false);
		} 

		else if (chord.text == "E") 
		{
			E.SetActive (true);
			frame.SetActive (false);
			aminor.SetActive (false);
			bminor.SetActive (false);
			C.SetActive (false);
			D.SetActive (false);
			A.SetActive (false);
			eminor.SetActive (false);
			F.SetActive (false);
			fminor.SetActive (false);
			G.SetActive (false);
		} 

		else if (chord.text == "e") 
		{
			eminor.SetActive (true);
			frame.SetActive (false);
			aminor.SetActive (false);
			bminor.SetActive (false);
			C.SetActive (false);
			D.SetActive (false);
			E.SetActive (false);
			A.SetActive (false);
			F.SetActive (false);
			fminor.SetActive (false);
			G.SetActive (false);
		}

		else if (chord.text == "F") 
		{
			F.SetActive (true);
			frame.SetActive (false);
			aminor.SetActive (false);
			bminor.SetActive (false);
			C.SetActive (false);
			D.SetActive (false);
			E.SetActive (false);
			eminor.SetActive (false);
			A.SetActive (false);
			fminor.SetActive (false);
			G.SetActive (false);
		}

		else if (chord.text == "f") 
		{
			fminor.SetActive (true);
			frame.SetActive (false);
			aminor.SetActive (false);
			bminor.SetActive (false);
			C.SetActive (false);
			D.SetActive (false);
			E.SetActive (false);
			eminor.SetActive (false);
			F.SetActive (false);
			A.SetActive (false);
			G.SetActive (false);
		}

		else if (chord.text == "G") 
		{
			G.SetActive (true);
			frame.SetActive (false);
			aminor.SetActive (false);
			bminor.SetActive (false);
			C.SetActive (false);
			D.SetActive (false);
			E.SetActive (false);
			eminor.SetActive (false);
			F.SetActive (false);
			fminor.SetActive (false);
			A.SetActive (false);
		}
	}
}
