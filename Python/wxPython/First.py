import wx

class MyApp(wx.App):
	def OnInit(self):
		wx.MessageBox("Hello wxPython", "wxApp")
		return True
if __name__ == '__main__':
	test = MyApp(False) 
	'''
	We pass False to tell wxPython whether to redirect output or not. When developing an application, it is advised to always set this to False , and to run scripts from the command line so that you can see any error output that might be missed when running the script by double clicking on it.
	'''
	test.MainLoop()