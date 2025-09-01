using MunicipalQuizGame.Models;

namespace MunicipalQuizGame.Services
{
    public class QuizService
    {
        public List<QuizQuestion> GetShuffledQuestions(int count = 12)
        {
            var allQuestions = QuizData.GetQuestions();
            var random = new Random();
            return allQuestions.OrderBy(x => random.Next()).Take(count).ToList();
        }

        public double CalculatePercentage(int score, int totalQuestions)
        {
            return (double)score / totalQuestions * 100;
        }

        public string GetPerformanceMessage(double percentage)
        {
            return percentage switch
            {
                >= 90 => "Fantastisk! Du er en ekte kommune-ekspert!",
                >= 70 => "Meget bra! Du har god kunnskap om norske kommuner!",
                >= 50 => "Ikke verst! Du har grunnleggende kunnskap!",
                _ => "Du bør lese mer om norske kommuner!"
            };
        }

        public string GetPerformanceClass(double percentage)
        {
            return percentage switch
            {
                >= 90 => "performance-excellent",
                >= 70 => "performance-good",
                >= 50 => "performance-ok",
                _ => "performance-poor"
            };
        }
    }
}