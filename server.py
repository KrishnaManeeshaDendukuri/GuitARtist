import socket 
import webScrape             

s = socket.socket()         
print ("Socket successfully created")

port = 5204               
s.bind(('', port))        
print ("socket binded to %s" %(port))
 
s.listen(1)     
print ("socket is listening")          
 

c, addr = s.accept()     
print ('Got connection from', addr)

while True:
	try:
		print ('Receiving')
		data = c.recv(1028)
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
			c.send(chords)
		except:
			c.close()
				