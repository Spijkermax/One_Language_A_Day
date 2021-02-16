import Players

def main():
    players = []
    while True:
        print('The Player Management Program')
        userInput = input('What would you like to do?\n- Create a Player(1)\n- Edit a Player(2)\n- Remove a Player(3)\n- View Players(4)')
    
        if (userInput == '1'):
            Players.createPlayer(players)
        
        if (userInput == '2'):
            Players.editPlayer(players)
            main()

        if (userInput == '3'):
            Players.removePlayer(players)
            main()

        if (userInput == '4'):
            Players.viewPlayers(players)


main()
