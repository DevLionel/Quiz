using Quiz.Application.Interfaces;
using Quiz.Domain.Entities;
using Quiz.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Quiz.Infrastructure.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly QuizDbContext _context;

        public QuizRepository(QuizDbContext context)
        {
            _context = context;
        }

        public async Task<List<Question>> GetAllQuestionsAsync()
        {
            return await _context.Questions
                .Include(q => q.Answers)   // Include answers for each question
                .OrderBy(q => q.Id)         // Optional: order by question ID
                .ToListAsync();
        }

        public async Task<Question> GetQuestionById(int questionId)
        {
            return await _context.Questions
                .Include(q => q.Answers)
                .Where(predicate: q => q.Id == questionId)
                .SingleAsync();
        }
    }
}
