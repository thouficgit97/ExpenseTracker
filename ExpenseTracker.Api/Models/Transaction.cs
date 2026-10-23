namespace ExpenseTracker.Api.Models;

public class Transaction
{
  public virtual int TransactionId { get; set; }
  public virtual int TransactionAmount { get; set; }
  public virtual string Title { get; set; }
  public virtual string Description { get; set; }
  public virtual TransactionType Type { get; set; }
  public virtual DateTime TransactionedAt { get; set; }
  public virtual User CreatedBy { get; set; }
  public virtual TransactionCategory Category { get; set; }
}
public enum TransactionType
{
  Income,
  Expense
}