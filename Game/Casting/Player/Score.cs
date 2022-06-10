namespace Game.Casting
{
    class Score : Actor{
        private int score;

        public Score() {
            this.setX(50);
            this.setY(50);
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