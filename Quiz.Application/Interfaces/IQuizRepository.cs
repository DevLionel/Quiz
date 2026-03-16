namespace Quiz.Application.Interfaces
{
    using Quiz.Domain.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IQuizRepository
    {
        Task<List<Question>> GetQuestionsByTemplateId(int templateId);
    }
}
