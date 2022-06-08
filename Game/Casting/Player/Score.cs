namespace Game.Casting
{
    class Score : Actor{
        private int score;

        public Score() {
        }

        
        public getScore() {
            return score;
        }

        public addScore(int score) {
            this.score += score;
            updateScoreText();
        }

        public minusScore(int score) {
            this.score -= score;
            updateScoreText();
        }

        private updateScoreText() {
            this.text = $"Score: {this.score}";
        }
    }
}