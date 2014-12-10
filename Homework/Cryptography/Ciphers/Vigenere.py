import Caesar
def Encrypt(message, key):
	message=message.upper()
	key=key.upper()
	ciphertext=''
	
	alphabet="ABCDEFGHIJKLMNOPQRSTUVWXYZ"
	for character in message:
		if alphabet.find(character)==-1:
			ciphertext+=character			
		else:
			ciphertext+=Caesar.Encrypt(character, alphabet.index(key[(len(ciphertext)) % len(key)]))
	return ciphertext

def Decrypt(message, key):
	message=message.upper()
	key=key.upper()
	plaintext=''
	alphabet="ABCDEFGHIJKLMNOPQRSTUVWXYZ"
	for character in message:
		if alphabet.find(character)==-1:
			plaintext+=character
		else:
			plaintext+=Caesar.Decrypt(character, alphabet.index(key[(len(plaintext)) % len(key)]))
	return plaintext
if __name__ == '__main__':
	print Decrypt(Encrypt("explanation", "leg"), "leg")
