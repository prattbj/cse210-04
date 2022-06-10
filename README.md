# cse210-04

Authors:
        Jake Edwards
        Ben Pratt
        Josh Johnson

Description:
        A game in which the user will collect gems and avoid rocks to get the highest possible score.
        This game is endless, with scaling difficulty. Objects that move faster help or hurt more.

Class overviews:
        KeyboardService     - handles inputs from the user
        VideoService        - creates the game window and pushes changes to it
        Program             - initializes the game
        Director            - directs play, contains gameplay loop (input, update, output)
        Cast                - holds and manipulates a dictionary containing objects to be drawn to the screen
        Color               - holds color values for use elsewhere
        Actor               - generic class for an object that will be drawn to the screen
            Score           - holds and manipulates the score
            Player          - the character that responds to user input
            FallingObject   - an object that falls from the top of the screen
                Rock        - an object that decrements the score when touched
                Gem         - an object that increments the score when touched