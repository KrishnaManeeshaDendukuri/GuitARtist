using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchScenes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void settings()
	{
		Application.LoadLevel ("Settings");
	}

	public void instructions()
	{
		Application.LoadLevel ("Instructions");
	}

	public void input()
	{
		Application.LoadLevel ("Input");
	}

	public void menu()
	{
		Application.LoadLevel ("Main");
	}

	public void ar()
	{
		Application.LoadLevel ("AR");
	}
}
