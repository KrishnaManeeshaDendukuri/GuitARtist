import socket 
import webScrape 
import chordServer            

soc = socket.socket(socket.AF_INET, socket.SOCK_STREAM)         
print ("Socket successfully created")

port = 12345               
soc.bind(("", port))        
print ("socket binded to %s" %(port))
 
soc.listen(5)     
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
			chordServer

			if len(data)!=0:
				newData = data.split(',')
				song_data = newData[0]
				artist_data = newData[1]
				Result = webScrape.main(song_data, artist_data)
				print(type(Result))
				conn.close()
				print('1st closed')
				break
	except:
		print("error")
		break

chordServer.receive(Result)