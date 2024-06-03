namespace all_active_nodes.Models
{
    public class Node
    {
        public int NodeId { get; set; }
        public string NodeName { get; set; }
        public int? ParentNodeId { get; set; }
        public bool IsActive { get; set; }
    }
}
