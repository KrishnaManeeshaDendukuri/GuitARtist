using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Net.Sockets;
using System.Threading;
using System.IO;
using System;

public class textSocket : MonoBehaviour 
{
	//Variables to set up the client
	TcpClient client;
	Stream s;
	StreamReader sr;
	StreamWriter sw;
	Thread recvT;
	public bool ready = false;
	public bool running = true;
	public string message;
	string temp;

	//Variables to recieve song name
	public InputField iField;
	public string text;
	public string song;

	//Variables to implement the received chords
	private string disp;
	public streamChords sendChords;
	// Use this for initialization
	void Start () 
	{
		new Thread(initThread).Start();
		sendChords = GameObject.FindObjectOfType (typeof(streamChords)) as streamChords;
		sendChords.receive (disp);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void initThread()
	{
		TcpClient client = new TcpClient("192.168.43.13", 5204); //127.0.0.1 for local machine
		s = client.GetStream();
		sr = new StreamReader(s);
		sw = new StreamWriter(s);
		sw.AutoFlush = true;

		recvT = new Thread(recvThread);
		recvT.Start();

		ready = true;
	}

	public void send(string message)
	{
		temp = message;
		new Thread(sendThread).Start();
	}

	public void sendThread()
	{
		try
		{
			string name = temp;
			sw.WriteLine(name);
		}
		catch
		{
		}
	}

	public void recvThread()
	{
		print("RecvThread started...");
		while (running)
		{
			try
			{
				message = sr.ReadLine();
				print("Recieved : " + message);

				disp = message;
			}
			catch (Exception e)
			{
				print(e);
			}
		}
	}


	public void getText()
	{
		Debug.Log (iField.text);
		song = iField.text;
		send (song);
	}
}
