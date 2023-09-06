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
    public QuestionRepository(AntriebsContext antriebsContext) : base(antriebsContext)
    {
    }
}

public class ScoresRepository : ARepository<Scores>
{
    public ScoresRepository(AntriebsContext antriebsContext) : base(antriebsContext)
    {
    }
}
