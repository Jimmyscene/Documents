import facebook

token = 'CAAIWCXbcAKYBANKiVxNp37xkLw53XeHIIi8AZCIGJXZAVcxEnzIifHWkbkfBKngGqwh1Q907JG707a5ZAb0QeIq0U6etpm1iZC7qfCfU6gxpZBneMRX0WbagaY66pD3VMzTG5oHhUy77R5IkPj4us0cavegyy8NTTiLVMzxJzfZBiceckYERxHUf2d8HKZBkzqiYyY2c2wijitxN3dOo9Aw'

graph = facebook.GraphAPI(token)
profile = graph.get_object("me")
friends = graph.get_connections("me", "friends")
print type(friends)
print type(friends['data'])
print friends['summary'].keys()
friend_list = [friend['name'] for friend in friends['data']]	
print friend_list
