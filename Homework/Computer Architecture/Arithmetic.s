########################################################################
#	Performs Various Arithmetic Operations on Given Integers
########################################################################




main:


la	$a0, prompt1 			# load address of prompt1 into register $a0
li	$v0,4					# load immediate value->4 into register $v0
syscall						# syscall 4 prints string value of $a0
li $v0,5 					# load immediate value->5 into register
syscall						# syscall 5 reads an integer into $v0
add $t0, $v0, $zero			# $t0 = $v0+$zero
la $a0, prompt2				# print prompt2 onto terminal
li $v0,4					# load immediate value->4 into register
syscall						# syscall 4 prints value of $v0
li $v0,5					# syscall 5 reads an integer
syscall				 		# syscall 5 reads an integer into $v0
move	$t1,$v0				# move $v0 into $t1
# Addition
add	$t2,$t0,$t1 			# add $t2=$t0+$t1
la	$a0,ans1				# load address of ans1 into register $a0
li	$v0,4					# load immediate value->4 into register $v0
syscall						# syscall 4 prints value of $v0
move $a0,$t2				# move value of $t2 into $a0
li $v0,1 					# load immedate value->1 into register $v0
syscall						# syscall 1 prints integer value of $a0
la $a0, endl 				# print endline character
li	$v0,4					# load immediate value->4 into register $v0
syscall	
# Subtraction
sub	$t2,$t0,$t1 			# sub $t2=$t0-$t1
la	$a0,ans3				# load address of ans1 into register $a0
li	$v0,4					# load immediate value->4 into register $v0
syscall						# syscall 4 prints value of $v0
move $a0,$t2				# Move difference into $a0
li $v0,1 					# load immedate value->1 into register $v0
syscall						# syscall 1 prints integer value of $a0
la $a0, endl 				# print endline character
li	$v0,4					# load immediate value->4 into register $v0
syscall						# syscall 4 prints value of $v0
# Multiplication			
mult $t0,$t1 				# multiply $HILO=$T0*$T1
la	$a0,ans2				# load address of ans1 into register $a0
li	$v0,4					# load immediate value->4 into register $v0
syscall						# syscall 4 prints value of $v0
mflo $a0					# Move product from $Lo into $ao
li $v0,1 					# load immedate value->1 into register $v0
syscall						# syscall 1 prints integer value of $a0
la $a0, endl 				# print endline character
li	$v0,4					# load immediate value->4 into register $v0
syscall						# syscall 4 prints value of $v0
# Division
div $t0,$t1 				# divide $t0/$t1, quotient into $Lo, remainder into $Hi
la	$a0,ans4				# load address of ans1 into register $a0
li	$v0,4					# load immediate value->4 into register $v0
syscall						# syscall 4 prints value of $v0
mflo $a0					# Move quotient from $Lo into Hi
li $v0,1 					# load immedate value->1 into register $v0
syscall						# syscall 1 prints integer value of $a0
la $a0, endl 				# print endline character
li	$v0,4					# load immediate value->4 into register $v0
syscall						# Syscall 4 pritns value of $v0
# Remainder
div $t0,$t1 				# divide $t0/$t1, quotient into $Lo, remainder into $Hi
la	$a0,ans5				# load address of ans1 into register $a0
li	$v0,4					# load immediate value->4 into register $v0
syscall						# syscall 4 prints value of $v0
mfhi $a0					# Move remainder from hi into $aO
li $v0,1 					# load immedate value->1 into register $v0
syscall						# syscall 1 prints integer value of $a0
la $a0, endl 				# print endline character
li	$v0,4					# load immediate value->4 into register $v0
syscall						# Syscall 4 pritns value of $v0
li $v0,10					# load immediate value->10 into register $v0
syscall						# syscall 10 ends program

.data

prompt1:.asciiz "Enter the first integer: "

prompt2:.asciiz "Enter the second integer: "

ans1:	.asciiz "The result is: "
ans2:	.asciiz "The product is: "
ans3:	.asciiz "The difference is: "
ans4:	.asciiz "The quotient is: "
ans5:	.asciiz "The remainer is: "
endl:	.asciiz "\n"



##
## end of file temp.s
