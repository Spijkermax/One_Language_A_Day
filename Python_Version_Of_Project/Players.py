""" Player Class """

class Player:
    def __init__(self, firstName, lastName, position, dob, team):
        self.firstName = firstName
        self.lastName = lastName
        self.position = position
        self.dob = dob
        self.team = team
        self.playerinfo = {'First name ': firstName, 'Last name ': lastName, 'Position ': position, 'Date of Birth ': dob, 'Team ': team}

def createPlayer(players):
    fnameinput = input('First name of player')
    lnameinput = input('Last name of player')
    positioninput = input('Player position')
    ageinput = input('Player date of birth')
    teaminput = input('Enter players team')
    newplayer = Player(fnameinput, lnameinput, positioninput, ageinput, teaminput)
    players.append(newplayer)
    print("Player created: ", newplayer.playerinfo);


def viewPlayers(players):
    filterOutput = (int(input('do you want to filter by first name(1), last name(2), position(3), Date of birth(4) or team(5)?')))
    for i in players:
        if (filterOutput == 1):
            searchFirstName = input('search first name')
            if (i.firstName in searchFirstName):
                print(i.playerinfo)
        if (filterOutput == 2):
            searchLastName = input('search last name:')
            if (i.lastName in searchLastName):
                print(i.playerinfo)
        if (filterOutput == 3):
            searchPosition = input('search new position')
            if (i.position in searchPosition):
                print(i.playerinfo)
        if (filterOutput == 4):
            searchDob = input('search DOB')
            if (i.dob in searchDob):
                print(i.playerinfo)         
        if (filterOutput == 5):
            searchTeam = input('search Team')
            if (i.team in searchTeam):
                print(i.playerinfo)
        

def editPlayer(players):
    firstNameEdit = input('first name of player')
    lastNameEdit = input('last name of player')
    for i in players:
        if (i.firstName in firstNameEdit and i.lastName in lastNameEdit):
            editChoice = input('do you want do edit first name(1), last name(2), position(3), Date of birth(4) or team(5)?')
        if (editChoice in '1'):
            newFirstName = input('Enter the new first name:')
            i.firstName = newFirstName
            print("First name changed to: ", newFirstName)
        if (editChoice in '2'):
            newLastName = input('Enter the new last name:')
            i.lastName = newLastName
            print("Last name changed to: ", newLastName)
        if (editChoice in '3'):
            newPosition = input('Enter new position')
            i.position = newPosition
            print("Position changed to: ", newPosition)
        if (editChoice in '4'):
            newDob = input('Enter new DOB')
            i.dob = newDob
            print("Date of Birth changed to: ", newDob)
        if (editChoice in '5'):
            newTeam = input('Enter new Team')
            i.team = team
            print("Team changed to: ", newTeam)


def removePlayer(players):
    firstNameEdit = input('first name of player')
    lastNameEdit = input('last name of player')
    for i in players:
        if (i.firstName in firstNameEdit and i.lastName in lastNameEdit):
            index = players.index(i)
            print('located at index: ', index, ' ', i.playerinfo)
            indexRemoval = (int(input('What is the index of the player you want to remove?')))
            players.pop(indexRemoval)
            print("Player removed: ", i.playerinfo)
        else:
            print("That Player doesnt exist")





            








