main:
la $a0, prompt1				# $a0=prompt1
li $v0, 4					# $v0=4
syscall						# syscall 4 prints value of a0
li $v0, 5					# $v0=5
syscall						# syscall 5 reads an integer into $v0
move $t0,$v0				# $t0 = user input
li $t1, 32					# $t1 = 32
sub $t0, $t0, $t1			# $t0 = user input-32
li $t1, 5					# $t1 = 5
mult $t0, $t1				# $lo = $t1*$t2
mflo $t0					# $t0 = (User Input-32)*5
li $t1, 9					# $t1 = 9
div $t0, $t1				# $lo = $t0/{$t1}(9) 
la $a0, prompt1				# $a0=prompt1
li $v0, 4					# $v0=4
syscall						# syscall 4 prints value of a0
mflo $a0					# $ao = Celsius 
li $v0, 1 					# $v0 = 1
syscall						# syscall 1 prints an integer
la $a0, endl 				# print endline character
li	$v0,4					# load immediate value->4 into register $v0
syscall						# syscall 4 prints value of $v0
li $v0, 10
syscall

.data
prompt1:	.asciiz "Enter temperature to convert to celsius: "
result:		.asciiz "The result is: "
endl:		.asciiz "\n"


################################################
#       Pseudocode                             #
# raw_input(x)                                 #
# x=(x-32)                                     #
# x=(9*x)/5                                    #
#                                              #
#                                              #
#                                              #
#                                              #
#                                              #
#                                              #
#                                              #
#                                              #
#                                              #
#                                              #
################################################
