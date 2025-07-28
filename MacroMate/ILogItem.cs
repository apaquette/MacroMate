namespace MacroMate;

interface ILogItem
{
    public string Name { get; }
    public DateTime Date { get; }
    void Display();
}