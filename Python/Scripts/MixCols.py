def MixCols(Element, shift):
	a=Element
	for x in range(1, int(shift)):
		a=a<<1
		
	



def Shift(Element, Range):
	a=int(Element, 16)
	for x in range(1, Range):
		a=a<<1
		length=len(bin(a))
		a= int(bin(a)[(length-8):],2)
		if(a>127):
			a=a^27
	return a





if __name__=='__main__':
	print  hex(Shift("87",2))
	print  hex(Shift("6E",3))
	print  hex(Shift("46",1))
	print  hex(Shift("A6",1))
	#print MixCols(87,2)^MixCols(6E,3)^MixCols(46,1)^MixCols(A6,1)
	
