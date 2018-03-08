using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class noARPlease : MonoBehaviour {

	void Start () 
	{
			if( GetComponent<VuforiaBehaviour>( ) != null )
			{
				GetComponent<VuforiaBehaviour>().enabled = false;
			}
			if( GetComponent<VideoBackgroundBehaviour>( ) != null )
			{
				GetComponent<VideoBackgroundBehaviour>().enabled = false;
			}
			if( GetComponent<DefaultInitializationErrorHandler>( ) != null )
			{
				GetComponent<DefaultInitializationErrorHandler>().enabled = false;
			}
	}  
}
