public abstract class Operation
{
  private int number;

  protected abstract int CvLoadOperationInt();

  private int CvOperationId{get; set;}

  public Operation()
  {

  }

  public void Initoperation()
  {
    Console.WriteLine("Initoperation");
  }

  public void Cloneoperation()
  {
    Console.WriteLine("Cloneoperation");
  }

  public void TestOperation()
  {
    Console.WriteLine("Completation");
  }
}
