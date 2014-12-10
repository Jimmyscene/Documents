def parallel(a,b):
	s = (a*b)/(a+b)
	return s


if __name__ == '__main__':
	R=0
	while True:
		s=raw_input("Please Input the resistors, Enter P for parallel, C To Quit\n")
		if (s=='P' or s=='p'):
			a= raw_input("Please input first resistor\n")
			b= raw_input("Please input second resistor\n")
			print str(parallel(repr(a),repr(b))
		elif False:
			print R
		
		
