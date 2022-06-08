namespace Game.Casting
{
    class Score : Actor{
        private int score;

        public Score() {
        }
        
        public getScore() {
            return score;
        }

        public changeScore(FallingObject fallingObject) {
            score += fallingObject.scoreIncrement;
        }

        private updateScoreText() {
            this.text = $"Score: {this.score}";
        }
    }
}