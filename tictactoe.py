'''
sdf
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
    board = create_board()
    display_board(board)

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
    print('- - - - -')
    print(f'{board[3]} | {board[4]} | {board[5]}')
    print(f'- - - - -')
    print(f'{board[6]} | {board[7]} | {board[8]}\n')
    pass
def is_draw(board):
    ''' return: True if board is a draw, False if board is still playable '''
    pass

def is_winner(board):
    ''' return: True if someone won, False if there is no winner '''
    pass

def make_move(player, board):
    ''' Prompts player to select a square to play
        Assigns the player to that board location if it is a legal move
        return: None
    '''
    pass      

def next_player(current):
    ''' return: x if current is o, otherwise x '''
    pass

# run main if this has been called from the command line
if __name__ == "__main__":
    main()