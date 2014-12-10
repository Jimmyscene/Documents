import sys
import wx
import wx.lib.platebtn as pbtn
import wx.lib.agw.gradientbutton as gbtn
import Ciphers.Playfair as Playfair
import Ciphers.Caesar as Caesar
import Ciphers.Vigenere as Vigenere
import Ciphers.OneTimePad as OneTimePad
import Ciphers.Monoalphabetic as Monoalphabetic
import Ciphers.Transposition as Transposition
import Ciphers.RSA as RSA
class Cryptosystem(wx.Frame):
	def __init__(self):
		wx.Frame.__init__(self, wx.GetApp().TopWindow, size=wx.DefaultSize, title = "Cryptosystem")
		
		window_size=wx.GetDisplaySize()
		xsize=.30*window_size[0]
		ysize=.30*window_size[1]
		
		self.SetSize(wx.Size(xsize,ysize))
		self.panel = wx.Panel(self)
		self.button1 = gbtn.GradientButton(self.panel, label = "Encrypt >>", pos=(.4*xsize, .25*ysize))
		self.button2 = gbtn.GradientButton(self.panel, label = "<< Decrypt", pos=(.4*xsize, .6*ysize))
		self.text_ctrl1= wx.TextCtrl(self.panel, value="Text", size= wx.Size(.105*wx.GetDisplaySize()[0], .34*wx.GetDisplaySize()[1]), style= wx.TE_MULTILINE)
		self.text_ctrl2= wx.TextCtrl(self.panel, value= "More Text", size= wx.Size(.105*wx.GetDisplaySize()[0], .34*wx.GetDisplaySize()[1]), style= wx.TE_MULTILINE, pos= (.63*xsize, 0))
		self.button1.Bind(wx.EVT_BUTTON, self.UIEncrypt)
		self.button2.Bind(wx.EVT_BUTTON, self.UIDecrypt)
		self.child = keyWindow(self)
		self.child.Show()
		self.Bind(wx.EVT_CLOSE, self.Close)
		self.modules={
		'Playfair': Playfair,
		'Monoalphabetic' : Monoalphabetic,
		'Caesar': Caesar,
		'One Time Pad': OneTimePad,
		'Vigenere' : Vigenere,
		'Transposition' : Transposition,
		'RSA' : RSA
		}

		self.cipher= wx.ComboBox(self.panel, choices=sorted(self.modules.keys()), pos=(.40*xsize, 0), size = wx.Size(.2*xsize,.2*ysize), style= wx.CB_READONLY)
		self.cipher.SetValue(sorted(self.modules.keys())[0])


	def Close(self, event):
		self.child.Close()
		self.Destroy()

	def UIEncrypt(self, event):
		self.text_ctrl2.Clear()
		#key = self.child.getKey()
		message= self.text_ctrl1.GetValue()
		try:
			self.text_ctrl2.write(self.modules[self.cipher.GetValue()].Encrypt(message))
		except ValueError:
			wx.MessageBox('Incorrect Key Type.\n Please Try Again', "Error", wx.OK)
	def UIDecrypt(self, event):
		self.text_ctrl1.Clear()
		key = self.child.getKey()
		message= self.text_ctrl2.GetValue()
		self.text_ctrl1.write(self.modules[self.cipher.GetValue()].Decrypt(message))

	

class keyWindow(wx.Frame):
	def __init__(self, parent):
		wx.Frame.__init__(self, None, size=(400, 400), title = "Key Window",  style=wx.DEFAULT_FRAME_STYLE & ~(wx.MINIMIZE_BOX | wx.MAXIMIZE_BOX | wx.CLOSE_BOX))
		self.parent=parent
		self.panel = wx.Panel(self)
		self.key=wx.TextCtrl(self.panel, value="Type Your Key Here...", size= wx.GetDisplaySize(), style=wx.TE_MULTILINE)

	def getKey(self):
		return self.key.GetValue()

	def close(self,evt):
		self.Close()

class Launcher(wx.App):
	def OnInit(self):
		self.frame = Cryptosystem()
		self.frame.Show()
		return True


if __name__ == '__main__':
	Launcher(False).MainLoop()
	
		
