namespace Game.Casting
{
    class Score : Actor{
        private int score;

        public Score() {
        }
        
        public int getScore() {
            return score;
        }

        public void changeScore(int velocity) {
            score += velocity;
            updateScoreText();
        }   

        private void updateScoreText() {
            this.setText($"Score: {this.score}");
        }
    }
}