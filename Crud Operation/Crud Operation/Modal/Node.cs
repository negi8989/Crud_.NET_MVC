namespace Crud_Operation.Modal
{
    public class Node
    {
        public int NodeId { get; set; }
        public string NodeName { get; set; } = "";
        public int? ParentNodeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
    }
}
