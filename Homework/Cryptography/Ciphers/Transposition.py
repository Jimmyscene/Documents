def __toMatrix(message, columns):
	message=message.upper()
	text = list(''.join(message.split()))					#message with no spaces
	rows=(len(text)/columns)+1				

	text=fillMatrix(text,columns)
	matrix=[map(lambda a: text[a], 
		range(b*columns,b*columns+columns)) 
			for b in range(rows)] 							#if you're reading this i'm sorry
	return (matrix,rows)

def fillMatrix(message,columns):
	alphabet="ABCDEFGHIJKLMNOPQRSTUVWXYZ"	
	additional=''
	if (len(message)% columns)!=0:								
		for x in reversed(range(columns- len(message)%columns)):
			additional+=alphabet[25-x]						
	return message+list(additional)

def Encrypt(message, key):
	ciphertext=''
	key=''.join(key.split())
	(matrix,rows)=__toMatrix(message, int(key[0]))
	
	for col in range(1,int(key[0])+1):
		for row in range(rows):
			ciphertext+=matrix[row][key[1:].find(str(col))]
	return ciphertext
if __name__ == '__main__':

	print Encrypt("ATTACK POSTPONE UNTIL TWO AM", "7 4 3 1 2 5 6 7")