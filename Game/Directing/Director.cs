using Game.Services;

namespace Game.Directing
{
    public class Director {
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;

        public Director(KeyboardService keyboardService, VideoService videoService) {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }
    }
}