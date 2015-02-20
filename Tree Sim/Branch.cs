namespace Tree_Sim
{
  public class Branch
  {
    public Branch ParentBranch { get; set; }
    public double Length { get; set; }
    public Position Start { get; set;}
    public int Depth { get; set; }
    public float Width { get; set; }
  }
}
