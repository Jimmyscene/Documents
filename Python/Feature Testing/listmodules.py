import os
import sys
import wx
import Playfair
import Monoalphabetic
# mods=[key for key in globals().keys()
#        		if isinstance(globals()[key], type(sys)) and not key.startswith('__')]
# mods.remove('wx')
# mods.remove('sys')
# mods.remove('os')
# print [getattr(vars()[x], 'Encrypt')("message","key") for x in mods]
# print vars()

modules= {
'Playfair': Playfair,
'Monoalphabetic' : Monoalphabetic,
}
print modules['Playfair'].Encrypt("message","key")

'''
Need to standardize input and output, set all returns to allcaps, set all functions except Encrypt, Decrypt, to __funcname
'''