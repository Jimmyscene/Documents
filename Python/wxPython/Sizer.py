import wx
class MyFrame(wx.Frame):
	def __init__(self):
		wx.Frame.__init__(self, None, size=wx.DefaultSize, title = "MyFrame")
		self.panel = wx.Panel(self)

		self.btn1 = wx.Button(self.panel, label = "Push Me")
		self.btn2 = wx.Button(self.panel, label = "Push Me Too")

		sizer = wx.BoxSizer(wx.HORIZONTAL)
		sizer.Add(self.btn1, 0, wx.ALL, 10)
		sizer.Add(self.btn2, 0, wx.ALL, 10)
		self.panel.SetSizer(sizer)

		self.Bind(wx.EVT_BUTTON, self.OnButton, self.btn1)
		self.Bind(wx.EVT_BUTTON,
			lambda event:
			self.btn1.Enable(not self.btn1.Enabled), self.btn2)
	def OnButton(self, event):
		"""Called when self.btn1 is clicked"""
		event_id = event.GetId()
		event_obj = event.GetEventObject()
		print "Button 1 Clicked:"
		print "ID=%d" % event_id
		print "object=%s" % event_obj.GetLabel()
class Launcher(wx.App):
	def OnInit(self):
		self.frame = MyFrame()
		self.SetTopWindow(self.frame)
		self.frame.Show()
		return True
if __name__ == '__main__':
	Launcher(False).MainLoop()
	