#!/usr/bin/python
from gi.repository import Notify
Notify.init ("Hello world")
Hello=Notify.Notification.new ("Hello world", "This is a notification example.", "dialog-information")
Hello.show()

