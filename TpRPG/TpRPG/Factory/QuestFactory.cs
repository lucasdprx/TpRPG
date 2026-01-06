namespace TpRPG.Factory;

public class QuestFactory
{
    private Quest quest = new("", "");

    public QuestFactory WithName(string name)
    {
        quest.name = name;
        return this;
    }

    public QuestFactory WithDescription(string description)
    {
        quest.description = description;
        return this;
    }

    public QuestFactory WithIsCompleted(bool isCompleted)
    {
        quest.isCompleted = isCompleted;
        return this;
    }

    public Quest Build()
    {
        return quest;
    }
}