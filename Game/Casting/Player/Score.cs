namespace Game.Casting
{
    // Score class inherits Actor because it will be drawn to the screen
    // Holds and manipulates the score
    class Score : Actor{
        // Initiate score without a value
        private int score;

        // Constructor
        public Score() {
        }
        
        // Getter to return the value of the score
        public int getScore() {
            return score;
        }

        // Setter to apply changes to score based on the scoreIncrement of the object that collided with the player
        public void changeScore(int scoreValue) {
            score += scoreValue;
            updateScoreText();
        }   

        // Setter to change the value of the score directly
        public void setScore(int score) {
            this.score = score;
            updateScoreText();
        }

        // Sets the text value of the score object to equal "Score: ", followed by the value of score
        private void updateScoreText() {
            this.setText($"Score: {this.score}");
        }
    }
}