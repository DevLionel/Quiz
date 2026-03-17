namespace Quiz.Application.Interfaces
{
    using Quiz.Domain.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IQuizRepository
    {
        Task<Question> GetQuestionById(int questionId);

        Task<List<Question>> GetAllQuestionsAsync();
    }
}
