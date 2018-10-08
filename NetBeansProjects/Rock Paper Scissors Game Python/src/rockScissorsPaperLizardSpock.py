# I, Shubham Hirpara, student number 000770045, certify that all code submitted is my own work; that I have not copied it from any other source.  I also certify that I have not allowed my work to be copied by others.
#DEFINE modual to count score
def play_start( choice_one, choice_two ):
    if( choice_one == "rock" ):
        if( choice_two == "paper" or choice_two == "spock" ):
            return False
        else:
            return True
    elif( choice_one == "scissors" ):
        if( choice_two == "paper" or choice_two == "spock" ):
            return False
        else:
            return True
    elif( choice_one == "spock" ):
        if( choice_two == "paper" or choice_two == "lizard" ):
            return False
        else:
            return True
    elif( choice_one == "lizard" ):
        if( choice_two == "rock" or choice_two == "scissors" ):
            return False
        else:
            return True
    elif( choice_one == "paper" ):
        if( choice_two == "lizard" or choice_two == "scissors" ):
            return False
        else:
            return True
#DEFINE modual to count action
def action_string( choice_one, choice_two ):
    choice_list = [ choice_one, choice_two ]
    msg = ""
    if( ( "rock" in choice_list ) and ( ( "lizard" in choice_list ) or ("scissors" in choice_list ) ) ):
        msg = " crushes " 
        return msg
    elif( ( "rock" in choice_list ) and ("paper" in choice_list ) ):
        msg = " covers "
        return msg
    elif( ( "rock" in choice_list ) and ( "spock" in choice_list ) ):
        msg = " vaporizes "
        return msg
    elif( ( "scissors" in choice_list ) and ( "paper" in choice_list) ):
        msg = " cuts "
        return msg
    elif( ( "scissors" in choice_list ) and ( "lizard" in choice_list ) ):
        msg = " decapitates "
        return msg
    elif( ( "scissors" in choice_list ) and ( "spock" in choice_list ) ):
        msg = " smashes "
        return msg
    elif( ( "spock" in choice_list ) and ( "lizard" in choice_list ) ):
        msg = " poisons "
        return msg
    elif( ( "spock" in choice_list ) and ( "paper" in choice_list ) ):
        msg = " disproves "
        return msg
    elif( ( "lizard" in choice_list ) and ( "paper" in choice_list ) ):
        msg = " eats "
        return msg
    else:
        print( "Error obtain." )
    

#GET name from players
player1 = input( "Player 1 enter your name: " )
player2 = input( "Player 2 enter your name: " )
#DEFINE list of choices
choices = [ "rock" , "scissors" , "paper" , "lizard" , "spock" , "i quit!" ]
#INITIALIZE score of both player as 0
score_one = 0
score_two = 0
#INITIALIZE flags to control the loop
flag = False
flag1 = False
flag2 = False
#loop for continue game
while True :
#INITIALIZE the loop for control quit and valip input   
    while True :
        choice_one = input( player1 + " Pick one of rock, scissors, paper, lizard, Spock: " )
        if( choice_one.lower() in choices ):  
            flag1 = True
            break
        else:
            print( "Invalid choice, Please try again !" )
    if( choice_one.lower() == "i quit!" ):
        print( "Final Total: " , player1 ," ", score_one , player2 ," ", score_two )
        if( score_one > score_two ):
            print( player1 + " wins!" )
        elif( score_two > score_one ):
            print( player2 + " wins!" )
        else:
            print( "both score is equal , this is draw" )
        break
        flag = True
#INITIALIZE the loop for control quit and valid input
    while True :
        choice_two = input( player2 + " Pick one of rock, scissors, paper, lizard, Spock: " )
        if( ( choice_two.lower() in choices ) and ( choice_two.lower( ) != choice_one.lower( ) ) ):
            flag2 = True
            break
            
        else:
            print( "Invalid choice, Please try again !" )
    if( choice_two.lower( ) == "i quit!" ):
        break
        flag = True
#CALLING PLAY_START to obtain score
    score = play_start( choice_one, choice_two )
#CALLING action_string to obtain action
    action = action_string( choice_one, choice_two )
##CALCULATE score of player and to DISPLAY  result
    if(score):
        score_one = score_one + 1
        print( choice_one , action , choice_two , "," , player1 , " wins!" )
        print( "Total: " , player1 ," ", score_one , player2 ," ", score_two )
    else:
        score_two = score_two + 1
        print( choice_two , action , choice_one , "," , player2 , " wins!" )
        print( "Total: " , player1 ," ", score_one , player2 ," ", score_two )
    
    

