def Decrypt(message,key):
	alphabet="ABCDEFGHIJKLMNOPQRSTUVWXYZ"
	key=__toChar(key).upper()
	plaintext=''
	message=message.upper()
	for counter in range(len(message)):
		plaintext+= alphabet[(alphabet.index(message[counter])-alphabet.index(key[counter])) % len(alhpabet)]
	return plaintext
def Encrypt(message, key):
	alphabet="ABCDEFGHIJKLMNOPQRSTUVWXYZ"
	key=__toChar(key).upper()
	ciphertext=''
	message=message.upper()
	for counter in range(len(message)):
		ciphertext+=alphabet[(alphabet.index(message[counter])+alphabet.index(key[counter])) % len(alphabet)]
	return ciphertext

def __toChar(stream):
	returned=''
	alphabet="ABCDEFGHIJKLMNOPQRSTUVWXYZ"
	for integer in stream.split():
		returned+=alphabet[int(integer)]
	return returned
if __name__ == '__main__':
	
	print Encrypt("sendmoremoney", "9 0 1 7 23 15 21 14 11 11 2 8 9")
	