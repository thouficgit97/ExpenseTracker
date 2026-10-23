namespace ExpenseTracker.Api.Models;

public class TransactionCategory
{
  public virtual int Categoryid { get; set; }
  public virtual string Category { get; set; }
  public virtual string Description { get; set; }
  public virtual User CreatedBy { get; set; }
}