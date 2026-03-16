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

        public async Task<List<Question>> GetQuestionsByTemplateId(int templateId)
        {
            return await _context.Questions
                .Include(q => q.Answers)
                .Where(q => q.QuizTemplateId == templateId)
                .ToListAsync();
        }
    }
}
