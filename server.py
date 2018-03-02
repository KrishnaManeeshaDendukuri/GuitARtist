import socket               

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
			#if len(data)!=0:
		else:
			break
	finally:
		pass
				