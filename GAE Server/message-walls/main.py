import webapp2
import json
import logging

from google.appengine.ext import db
from google.appengine.api import users
from datetime import datetime

class User(db.Model):
        username = db.StringProperty()
	password = db.StringProperty()
	name = db.StringProperty()
	walls = db.ListProperty(db.Key)
	date_created = db.DateTimeProperty(auto_now_add=True)

class MessageWall(db.Model):
        name = db.StringProperty()
        date_created = db.DateTimeProperty(auto_now_add=True)
        author = db.ReferenceProperty(User, collection_name='walls_created')

class Message(db.Model):
        content = db.TextProperty()
        date_created = db.DateTimeProperty(auto_now_add=True)        
        wall = db.ReferenceProperty(MessageWall, collection_name='messages')
        author = db.ReferenceProperty(User, collection_name='messages')

class Request(object):
        def __init__(self, j=""):
                if j != "": 
                        self.__dict__ = json.loads(j)
        def to_JSON(self):
                return json.dumps(self, default=lambda o: o.__dict__, sort_keys=True, indent=4)

class Utility():
        @staticmethod
        def userExists(username):
                count = User.gql("WHERE username = :1", username).count()
                if count == 1 :
                        return True
                else:
                        return False

        @staticmethod
        def getUser(username, password):
                count = User.gql("WHERE username = :1 AND password = :2", username, password).count()
                if count == 1:
                        userList = User.gql("WHERE username = :1 AND password = :2", username, password).fetch(limit=1)
                        if userList != None:
                                user = userList[0]
                                return user
                        else:
                                return None
                else:
                        return None

        @staticmethod
        def messageWallExists(wallname):
                count = MessageWall.gql("WHERE name = :1", wallname).count()
                if count == 1 :
                        return True
                else:
                        return False

        @staticmethod
        def getMessageWall(wallname):
                wallList = MessageWall.gql("WHERE name = :1", wallname).fetch(limit=1)
                if wallList != None:
                        wall = wallList[0]
                        return wall
                else:
                        return None

        @staticmethod
        def isValidUsername(username):
                return True
        
        @staticmethod
        def isValidPassword(username):
                return True

        @staticmethod
        def isValidName(username):
                return True

        @staticmethod
        def isValidMessage(username):
                return True

class MainHandler(webapp2.RequestHandler):
    def get(self):
        self.response.write('Hello Diana! What\'s up!')

class CreateUser(webapp2.RequestHandler):
    def post(self):
        request = Request()
        try:
                user = Request(self.request.body)
        except ValueError, e:
                request.value = "fail"
                request.details = "Request body is not a valid json"
                return webapp2.Response(request.to_JSON())        

        if not hasattr(user, 'username') or user.username == None:
                request.value = "fail"
                request.details = "Username is missing from the create user request"
                return webapp2.Response(request.to_JSON())
        
        if not hasattr(user, 'password') or user.password == None:
                request.value = "fail"
                request.details = "Password is missing from the create user request"
                return webapp2.Response(request.to_JSON())
                     
        if not hasattr(user, 'name') or user.name == None:
                request.value = "fail"
                request.details = "Name is missing from the create user request"
                return webapp2.Response(request.to_JSON())
        
        if Utility.userExists(user.username):
                request.value = "fail"
                request.details = "Username already exists"
                return webapp2.Response(request.to_JSON())

        newUser = User()
        newUser.username = user.username
        newUser.password = user.password
        newUser.name = user.name
        newUser.put()
                                        
        request.value = "success"
        request.details = "User "+newUser.name+" has been added successfully"
        request.date = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
        return webapp2.Response(request.to_JSON())        


class GetUser(webapp2.RequestHandler):
    def post(self):
        request = Request()
        try:
                user = Request(self.request.body)
        except ValueError, e:
                request.value = "fail"
                request.details = "Request body is not a valid json"
                return webapp2.Response(request.to_JSON())
       
        if not hasattr(user, 'username') or user.username == None:
                request.value = "fail"
                request.details = "Username is missing from the get user request"
                return webapp2.Response(request.to_JSON())
        
        if not hasattr(user, 'password') or user.password == None:
                request.value = "fail"
                request.details = "Password is missing from the get user request"
                return webapp2.Response(request.to_JSON())
        
        if not Utility.userExists(user.username):
                request.value = "fail"
                request.details = "User doesn't exists from the get user request"
                return webapp2.Response(request.to_JSON())
        
        userDB = Utility.getUser(user.username, user.password)
        if userDB == None:
                request.value = "fail"
                request.details = "Password is wrong from the get user request"
                return webapp2.Response(request.to_JSON())

        lastUpdate = None
        if not hasattr(user, 'date') or user.date == None:
                lastUpdate = datetime.strptime('1970-01-01 12:00:00.000000','%Y-%m-%d %H:%M:%S.%f')
        else:
                lastUpdate = datetime.strptime(user.date,'%Y-%m-%d %H:%M:%S.%f')
        logging.info("last date"+str(lastUpdate))

        newLastUpdate = lastUpdate

        returnUser = Request()
        returnUser.name = userDB.name
        returnUser.walls = []
        for wallKey in userDB.walls:
                wall = db.get(wallKey)
                newWall = Request()
                newWall.name = wall.name
                newWall.author = wall.author.name
                newWall.date = wall.date_created.strftime('%Y-%m-%d %H:%M:%S.%f')
                newWall.messages = []
                   
                for mess in sorted(wall.messages, key=lambda message: message.date_created):
                        if (mess.date_created-lastUpdate).total_seconds() <= 0:
                                continue
                        if ((mess.date_created-newLastUpdate).total_seconds() > 0) :
                                newLastUpdate =  mess.date_created

                        newMessage = Request()
                        newMessage.id = str(mess.key().id_or_name())
                        newMessage.content = mess.content
                        newMessage.author = mess.author.name
                        newMessage.date = mess.date_created.strftime('%Y-%m-%d %H:%M:%S.%f')
                        newWall.messages.append(newMessage)
                        
                returnUser.walls.append(newWall)
                
        returnUser.date = newLastUpdate.strftime('%Y-%m-%d %H:%M:%S.%f')                                                      
        request.user = returnUser
        request.value = "success"
        request.details = "User "+returnUser.name+" has been retrieved"
        return webapp2.Response(request.to_JSON())                                                


class AddWall(webapp2.RequestHandler):
    def post(self):
        request = Request()
        logging.info(self.request.body)
        user = Request(self.request.body)

        if not hasattr(user, 'username') or user.username == None:
                request.value = "fail"
                request.details = "Username is missing from the add wall request"
                return webapp2.Response(request.to_JSON())                
                
        if not hasattr(user, 'password') or user.password == None:
                request.value = "fail"
                request.details = "Password is missing from the add wall request"
                return webapp2.Response(request.to_JSON())
        
        if not hasattr(user, 'name') or user.name == None:
                request.value = "fail"
                request.details = "New wall name is missing from the add wall request"
                return webapp2.Response(request.to_JSON())
        
        if not Utility.userExists(user.username):
                request.value = "fail"
                request.details = "User doesn't exists from the add wall request"
                return webapp2.Response(request.to_JSON())
        
        userDB = Utility.getUser(user.username, user.password)
        if userDB == None:
                request.value = "fail"
                request.details = "Password is wrong from the add wall request"
                return webapp2.Response(request.to_JSON())
        
        wall = None
        if Utility.messageWallExists(user.name):
                wall = Utility.getMessageWall(user.name)
        else:       
                wall = MessageWall()
                wall.name = user.name
                wall.author = userDB.key()
                wall.put()
                                                
        userDB.walls.append(wall.key())
        userDB.put()

        request.user = Request()
        request.user.name = userDB.name
        request.user.walls = []
        
        newWall = Request()
        newWall.author = wall.author.name
        newWall.name = wall.name
        newWall.date = wall.date_created.strftime('%Y-%m-%d %H:%M:%S.%f')

        request.user.walls.append(newWall)
                                                
        request.value = "success"
        request.details = "Wall "+wall.name+" was added successfully"
        return webapp2.Response(request.to_JSON())                                        
                     

class CreateMessage(webapp2.RequestHandler):
    def post(self):
        request = Request()
        try:
                user = Request(self.request.body)
        except ValueError, e:
                request.value = "fail"
                request.details = "Request body is not a valid json"
                return webapp2.Response(request.to_JSON())        

        if not hasattr(user, 'username') or user.username == None:
                request.value = "fail"
                request.details = "Username is missing from the create message request"
                return webapp2.Response(request.to_JSON())
        
        if not hasattr(user, 'password') or user.password == None:
                request.value = "fail"
                request.details = "Password is missing from the create message request"
                return webapp2.Response(request.to_JSON())
                     
        if not hasattr(user, 'name') or user.name == None:
                request.value = "fail"
                request.details = "Wall name is missing from the create message request"
                return webapp2.Response(request.to_JSON())

        if not hasattr(user, 'content') or user.content == None:
                request.value = "fail"
                request.details = "Message content is missing from the create message request"
                return webapp2.Response(request.to_JSON())

        if not Utility.userExists(user.username):
                request.value = "fail"
                request.details = "User doesn't exists from the create message request"
                return webapp2.Response(request.to_JSON())

        userDB = Utility.getUser(user.username, user.password)
        if userDB == None:
                request.value = "fail"
                request.details = "Password is wrong from the create message request"
                return webapp2.Response(request.to_JSON())
       
        if not Utility.messageWallExists(user.name):
                request.value = "fail"
                request.details = "Message wall doesn't exists from the create message request"
                return webapp2.Response(request.to_JSON())
        
        wall = Utility.getMessageWall(user.name)

        message = Message()
        message.content = user.content
        message.wall = wall
        message.author = userDB
        message.put()

        request.user = Request()
        request.user.name = userDB.name
        request.user.walls = []
        
        newWall = Request()
        newWall.author = wall.author.name
        newWall.name = wall.name
        newWall.messages = []
        
        newMessage = Request()
        newMessage.id = str(message.key().id_or_name())
        newMessage.author = message.author.name
        newMessage.date = message.date_created.strftime('%Y-%m-%d %H:%M:%S.%f')
        newMessage.content = message.content
        newWall.messages.append(newMessage)

        request.user.walls.append(newWall)
        
        request.value = "success"
        request.details = "Message "+message.content+" was added successfully"
        return webapp2.Response(request.to_JSON())
        

app = webapp2.WSGIApplication([
    ('/', MainHandler),
    ('/createuser', CreateUser),
    ('/getuser', GetUser),
    ('/addwall', AddWall),
    ('/createmessage', CreateMessage),
], debug=True)
