.text
main:

la $a0, array			# $t0 is start of array
lw $a1, count			# $t1 is size of array

jal min
move $t0, $v0
la $a0, ans1
li $v0, 4
syscall

move $a0, $t0
li $v0, 1
syscall

la $a0, array			# $t0 is start of array
lw $a1, count			# $t1 is size of array
jal max
move $t0, $v0
la $a0, ans2
li $v0, 4
syscall

move $a0, $t0
li $v0, 1
syscall
la $a0, endl
li $v0, 4
syscall

li $v0, 10
syscall

###################################################################
min:
move $t0,$a0
move $t1,$a1
lw $t2, ($t0)			# $t2 is first element of array(3)
lw $t3, ($t0)			# $t3 is first element of array(3)
li $t5, 1 				# $t5 is 1
Loop:
slt $t6, $t5, $t1 		# If $t5<$t1
beq $t6, $0, EndLoop	# Goto EndLoop
sll $t6, $t5, 2 		# Shift left 2, $t6=4, the next array index 
add $t6, $t0, $t6		# $t6 = array[$t0+$t6]
lw $t7, 0($t6)			# $t7 = array[$t6]
bge $t7, $t2, notMin	# if $t7>$t2, go to notMin
move $t2, $t7			# else, 
notMin:
addi $t5, $t5, 1 
j Loop
EndLoop:
move $v0, $t2
jr $ra

###################################################################

max:
move $t0,$a0
move $t1,$a1
lw $t2, ($t0)			# $t2 is first element of array(3)
lw $t3, ($t0)			# $t3 is first element of array(3)
li $t5, 1 				# $t5 is 1
LLoop:
slt $t6, $t5, $t1 		# If $t5<$t1
beq $t6, $0, EndLLoop	# Goto EndLoop
sll $t6, $t5, 2 		# Shift left 2, $t6=4, the next array index 
add $t6, $t0, $t6		# $t6 = array[$t0+$t6]
lw $t7, 0($t6)			# $t7 = array[$t6]
ble $t7, $t3, notMax	#If $t3 is greater than $t7
move $t3, $t7
notMax:
addi $t5, $t5, 1 
j LLoop
EndLLoop:
move $v0, $t3
jr $ra


.data


array:	.word 3,4,2,6,12,7,18,26,2,14,19,7,8,12,13

count:	.word 15

endl:	.asciiz "\n"

ans1:	.asciiz "min = "

ans2:	.asciiz "\nmax = "
