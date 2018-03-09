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
	//Thread recvT;
	public bool ready = false;
	public bool running = false;
	public string message;
	string temp;

	//Variables to recieve song name
	public InputField iField;
	public string text;
	public string song;

	// Use this for initialization
	void Start () 
	{
		new Thread(initThread).Start();
		running = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void initThread()
	{
		TcpClient client = new TcpClient("192.168.43.13", 12345); //Change the IP here; Not the port.
		s = client.GetStream();
		sw = new StreamWriter(s);
		sw.AutoFlush = true;

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
		catch (Exception e)
		{
			print (e);
		}
	}

	public void getText()
	{
		Debug.Log (iField.text);
		song = iField.text;
		send (song);
	}
}
