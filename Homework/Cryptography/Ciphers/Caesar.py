def Encrypt(plaintext, key):
	plaintext=plaintext.upper()
	key=int(key)
	alphabet = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
	cipher =''
	for character in plaintext:
		if character== ' ':
			cipher+=character
		else:
			cipher+= alphabet[(alphabet.index(character)+key)%(len(alphabet))]

	return cipher

def Decrypt(cryptotext,key):
	key=int(key)
	alphabet = list('ABCDEFGHIJKLMNOPQRSTUVWXYZ')
	plaintext= ''
	for character in cryptotext:
		if character== ' ':
			plaintext+=character
		else:
			plaintext+= alphabet[(alphabet.index(character)-key)%(len(alphabet))]



	return plaintext

if __name__ == '__main__':
	print Decrypt(Encrypt("These are the things I should probably know", 1),1)


