#!/bin/bash
dmcs Mortgage.cs
if [[ $? -ne 0 ]]
then
	echo -e "Compilation Failed!\n"
	exit -1
fi
mono Mortgage.exe



