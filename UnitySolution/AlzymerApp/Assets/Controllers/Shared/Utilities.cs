namespace UnityApp
{
    public class Utilities
    {
        public enum ScreensScenes
        {
            StartUpPage = 0,
            LoginAuthMainForm = 1,
            LoginForm = 2,
            Screen1Menu = 3,
            Dashboard = 4,
            DashboardGames = 5,
            DashboardStats = 6,
            DashboardMore = 7,
            CompleteSentenceMMSE = 8,
            LocationMMSE = 9,
            NameObjectMMSE = 10,
            RecallImageMMSE = 11,
            SerialSevenMMSE = 12,
            NameObject2MMSE = 13,
            ConnectDotsMoca = 14,
            DrawCubeMoca = 15,
            DrawCircleMoca = 16,
            NumberOnClockMoca = 17,
            ClockArmsMoca = 18,
            RecognizeAnimalMoca = 19,
            DragFruitsMoca = 20,
            SnakesAndLaddersGame = 21,
            MemoryTrainGame = 22,
            AnimalDragging = 23,
            AnimalDraggingWithVoice = 24,
            AnimalDraggingWithPhrase = 25,
            RecallImages2MMSE = 26,
        }

        public static string DatabaseName
        {
            get
            {
                return "existing.db";
            }
        }
    }
}