def multinv(Z):
	for a in range(1,Z):
		for b in range(a,Z):
			uni='\u208'+hex(Z)[2:]
			uni=unicode(uni)
			if(((a*b))%Z==1 ):
				
				print("["+str(a)+"]"+" is the inverse of " +"["+str(b)+"]" +" base: "+str(Z))
			else:
				pass
if __name__ == '__main__':
	multinv(int(raw_input()))
