namespace Ticket.API.Models;
public class Column
{
    public double StartX { get; set; }
    public string Text { get; set; }
}
public class Row
{
    public bool BeforeSeperator { get; set; }
    public double StartY { get; set; }
    public List<Column> Columns { get; set; }
}