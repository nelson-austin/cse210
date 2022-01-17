'''
Tic-Tac-Toe Game
Author: Austin Nelson
'''

def main():
    ''' Holds the main game loop logic
        Selects a player
        Builds the board
        Loops through Players until a winner is found or game is over
        Displays results to user
        Thanks them for playing
        return: None
    '''
    # assign/get the first player​
    # create a board

    # loop if there isn't a winner or if the game isn't a draw​
        # display the board

        # allow the player to make a move​
        # pick the next player

    # display the final board​
    # show message for winner and thanks for playing
    
    player = next_player('')
    print('\nA game of tic-tac-toe:')
    board = create_board()
    
    while not (is_winner(board) or is_draw(board)):
        display_board(board)
        make_move(player, board)
        player = next_player(player)
    
    display_board(board)
    
    if is_winner(board):
        print(f'{next_player(player)} won! Thanks for playing!')
    else:
        print(f'Good game! Game ended in a tie!')

def create_board():
    ''' Creates a list that holds the spots on the board
        It initializes the positions with the numbers for the person to pick
        return: the board as a list
    '''
    board = []
    for square in range(9):
        board.append(square + 1)
    return board

def display_board(board):
    ''' Displays the current board
        return: None
    '''
    print(f'\n{board[0]} | {board[1]} | {board[2]}')
    print('- + - + -')
    print(f'{board[3]} | {board[4]} | {board[5]}')
    print(f'- + - + -')
    print(f'{board[6]} | {board[7]} | {board[8]}\n')
    pass
def is_draw(board):
    ''' return: True if board is a draw, False if board is still playable '''
    for square in range(9):
        if board[square] != 'X' and board[square] != 'O':
            return False
    return True


def is_winner(board):
    ''' return: True if someone won, False if there is no winner '''
    return (board[0] == board[1] == board[2] or
            board[3] == board[4] == board[5] or
            board[6] == board[7] == board[8] or
            board[0] == board[3] == board[6] or
            board[1] == board[4] == board[7] or
            board[2] == board[5] == board[8] or
            board[0] == board[4] == board[8] or
            board[2] == board[4] == board[6])

def make_move(player, board):
    ''' Prompts player to select a square to play
        Assigns the player to that board location if it is a legal move
        return: None
    '''
    i = 0
    while i < 1:
        square = int(input(f"{player.upper()}'s turn to choose a square (1-9): "))
        if type(board[square - 1]) == int:
            board[square - 1] = player.upper()
            i += 1
        else:
            print('Square already taken! Please choose another spot!')     


def next_player(current):
    ''' return: x if current is o, otherwise x '''
    if current == '' or current == 'O':
        return 'X'
    else:
        return 'O'

# run main if this has been called from the command line
if __name__ == "__main__":
    main()