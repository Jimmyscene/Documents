def Encrypt(plaintext, key):
	alphabet = list('ABCDEFGHIJKLMNOPQRSTUVWXYZ')
	cipher=list('')
	key=key.upper()
	for character in key:
		if(character in alphabet):
			alphabet.remove(character)
			cipher.append(character)
		else:
			pass
	cipher=cipher+alphabet
	alphabet = list('ABCDEFGHIJKLMNOPQRSTUVWXYZ')
	plaintext=list(plaintext.upper())
	cryptotext= ''
	for character in plaintext:
		if character!=' ':
			cryptotext+= alphabet[cipher.index(character)]
		else:
			cryptotext+=" "
	return cryptotext

def Decrypt(cryptotext, key):
	alphabet = list('ABCDEFGHIJKLMNOPQRSTUVWXYZ')
	cipher=list('')
	key=key.upper()
	for character in key:
		if(character in alphabet):
			alphabet.remove(character)
			cipher.append(character)
		else:
			pass

	cipher=cipher+alphabet
	print cipher
	alphabet = list('ABCDEFGHIJKLMNOPQRSTUVWXYZ')
	cryptotext=list(cryptotext.upper())
	plaintext= ''
	for character in cryptotext:
		if character!=' ':
			plaintext+= cipher[alphabet.index(character)]
		else:
			plaintext+=" "
	return plaintext
if __name__ == '__main__':
		print Encrypt("basilisk to leviathan blake is contact","The snow lay thick on the steps and the snowflakes driven by the wind looked black in the headlights of the cars.")