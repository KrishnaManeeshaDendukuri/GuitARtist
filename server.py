import socket 
import webScrape             

soc = socket.socket()         
print ("Socket successfully created")

port = 5204               
soc.bind(('', port))        
print ("socket binded to %s" %(port))
 
soc.listen(1)     
print ("socket is listening")          
 

conn, addr = soc.accept()     
print ('Got connection from', addr)

while True:
	try:
		print ('Receiving')
		data = conn.recv(1028)
		if data:
			data = data.decode().rstrip("\n\r")
			print("to send "+data, ", length: ", len(data))

			if len(data)!=0:
				newData = data.split(',')
				song_data = newData[0]
				artist_data = newData[1]
				webScrape.main(song_data, artist_data)
		else:
			break
	finally:
		pass

def sendToUnity(chords):
	if (len(chords)!=0):
		try:
			chords = chords + "\n\r"
			conn.send(chords)
		except:
			conn.close()
				