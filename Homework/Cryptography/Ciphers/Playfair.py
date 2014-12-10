
def Encrypt(message, key):
	key=__toMatrix(__genKey(key))				#Generates the complete key from the keyword, then converts it to a matrix
	message=__toDiagraph(message.upper())		#Converts the message to diagraphs
	encrypted=''
	for element in message:	
		#Standard Playfair encryption
		a=__getIndex(key,element[0])
		b=__getIndex(key,element[1])
		if (a[0]==b[0]):
			if(a[1]==4):
				encrypted+=key[a[0]][a[1]-4]
			else:
				encrypted+=key[a[0]][a[1]+1]
			if(b[1]==4):
				encrypted+=key[b[0]][b[1]-4]
			else:
				encrypted+=key[b[0]][b[1]+1]
			continue
		if (a[1]==b[1]):
			if(a[0]==4):
				encrypted+=key[a[0]-4][a[1]]
			else:
				encrypted+=key[a[0]+1][a[1]]
			if(b[0]==4):
				encrypted+=key[b[0]-4][b[1]]
			else:
				encrypted+=key[b[0]+1][b[1]]
			continue
		else:
			encrypted+= key[a[0]][b[1]]+key[b[0]][a[1]]
	return encrypted
def Decrypt(message,key): 
	key=__toMatrix(__genKey(key))				#Generates the complete key from the keyword, then converts it to a matrix
	message=__toDiagraph(message.upper())		#Converts the message to diagraphs
	encrypted=''
	for element in message:					#Standard Playfair encryption
		a=__getIndex(key,element[0])
		b=__getIndex(key,element[1])
		if (a[0]==b[0]):
			if(a[1]==0):
				encrypted+=key[a[0]][a[1]+4]
			else:
				encrypted+=key[a[0]][a[1]-1]
			if(b[1]==0):
				encrypted+=key[b[0]][b[1]+4]
			else:
				encrypted+=key[b[0]][b[1]-1]
			continue
		if (a[1]==b[1]):
			if(a[0]==0):
				encrypted+=key[a[0]+4][a[1]]
			else:
				encrypted+=key[a[0]-1][a[1]]
			if(b[0]==0):
				encrypted+=key[b[0]+4][b[1]]
			else:
				encrypted+=key[b[0]-1][b[1]]
			continue
		else:
			encrypted+= key[a[0]][b[1]]+key[b[0]][a[1]]
	return encrypted


def __toMatrix(key):
	row1=()
	for x in range(0,5):
		row1+=(key[x],)
	row2=()
	for x in range(5,10):
		row2+=(key[x],)
	row3=()
	for x in range(10,15):
		row3+=(key[x],)
	row4=()
	for x in range(15,20):
		row4+=(key[x],)
	row5=()
	for x in range(20,25):
		row5+=(key[x],)
	Matrix=[row1,row2,row3,row4,row5]
	return Matrix

def __genKey(keyword):
	string = ''
	string+=keyword.upper()
	alphabet='ABCDEFGHIKLMNOPQRSTUVWXYZ'
	for y in range(25-len(string)):
		for x in alphabet:
			if(string.find(x)==-1):
				string+=x

	return string

def __removeJ(message):
	string=''
	for character in message:
		if character=='J':
			string+='I'
		else:
			string+=character
	return string

def __toDiagraph(message):
	string= ''
	spacecount=0
	for character in __removeJ(message):
		if (character == ' ') or (character == '.'):
			#Punctuation not implemented
			continue
		
		if(((len(string) - spacecount) % 2 == 0)):
			#print "String is even"
			string += character
			continue
		elif(((len(string) - spacecount) % 2 == 1)):
			#print "String is odd"
			string += character + ' '
			spacecount+=1
			continue
	if (len(string)- spacecount )% 2==1:
		string+='Z'
	splitstring=string.split()
	for element in splitstring:
		if (element[0]==element[1]):
			splitstring[splitstring.index(element)]=element[0]+'X'
	return splitstring

def __getIndex(matrix,character):
	for row in range(5):
		for col in range(5):
			if(matrix[row][col]==character):
				return (row, col)

if __name__ == '__main__':
	print Encrypt("Must see you over Cadogan West. Coming at once.","MFHIKUNOPQZVWXYELARGDSTBC")