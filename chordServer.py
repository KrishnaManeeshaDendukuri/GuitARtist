import socket

socket_connection = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
socket_connection.bind(("", 5204))
socket_connection.listen(5)
print ('Started 5204')

def receive(Result):
	while True:
		client_connection, client_address = socket_connection.accept()
		print ('Connected to', client_address)
		if (len(Result)!=0):
			try:
				print('Trying')
				Result = Result + "\n\r"
				print (Result)
				client_connection.send(Result.encode('utf-8'))
				print("Sent to unity")
				break
			except Exception as e:
				print("Quit with" + e)
				client_connection.close()
				break