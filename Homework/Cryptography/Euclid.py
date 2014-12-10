def Euclid(a,b):
	if(a==0):
		return b;
	if(b==0):
		return a;
	else:
		r=a%b
		return Euclid(b,r)

if __name__ == "__main__":	
	a=raw_input()
	b=raw_input()
	print Euclid(int(a),int(b))
