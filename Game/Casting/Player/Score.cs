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
            score += fallingObject.getScore();
            updateScoreText();
        }   

        private void updateScoreText() {
            this.setText($"Score: {this.score}");
        }
    }
}