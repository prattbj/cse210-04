namespace Game.Casting
{
    class Score : Actor{
        private int score;

        public Score() {
        }
        
        public int getScore() {
            return score;
        }

        public void changeScore(FallingObject fallingObject) {
            score += fallingObject.scoreIncrement;
        }   

        private void updateScoreText() {
            this.text = $"Score: {this.score}";
        }
    }
}