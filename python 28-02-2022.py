#q = False

#while(q == False):
    #print("Program is running")
    #user_input = input("would you like to quit?")
    #if user_input == 'y'):
        #q = true

 #animals_a  = {"fish", "Bird", "Bear", "dog", "Cat", "unicorn", "dragon"}
#
 #for animal in animals_a:
  #   print (animal)
#
 #animals_b  = {"fish", "Bird", "Bear", "dog", "Cat", "unicorn", "dragon"}
#
 #for animal in animals_b:
  #   print (animal)
#
#for x in range(len(animals_)):
 #   print(str(x) + "" + animals_b[x])

#content = "This is a bunch of content."

#content += "\nHere is some more content."

#file = open ("text.txt","w")#opening the file stream in 'write' mode
#file.write("this is a bunch of test text.")#writing text to a file
#file.close() #closing the file stream

#file = open("test.txt, "r") #opening the file stream in 'read' mode
#print(file.read()) #reading file content and printing to console
#file.close() #closing the file stream

#file = open("test.txt", "a") #opening the file 'append' mode
#file.write("This is some extra stuff that has beem added.") #adding more content
#file.close()#closing the file stream

def sum(a,b):
    return a + b

collection = ["a" , "b", "c", "d",  "e", "f", "g",]

def linear_search(search_term):
    for x in collection:#for every element in 'collection' array
        if(x == str(search_term)): #compare element value to asearch parameter
            return True# return True because term has been found
        return False #if the for loop ends,return false

print (linear_search("c"))
