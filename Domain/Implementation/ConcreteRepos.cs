using Model.Configurations;
using Model.Entities;
using Repos.Interface;

namespace Repos.Implementation;

public class AnswerRepository : ARepository<Answers>
{
    public AnswerRepository(AntriebsContext antriebsContext) : base(antriebsContext)
    {
    }
}

public class QuestionRepository : ARepository<Questions>
{
    public QuestionRepository(AntriebsContext AntriebsContext) : base(AntriebsContext)
    {
    }
}

public class ScoresRepository : ARepository<Scores>
{
    public ScoresRepository(AntriebsContext AntriebsContext) : base(AntriebsContext)
    {
    }
}
