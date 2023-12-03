namespace Task4
{
    public class GraphicsEditor
    {
        public List<GraphicPrimitive> GraphicPrimitives { get; set; }

        public GraphicsEditor()
        {
            GraphicPrimitives = new List<GraphicPrimitive>();
        }

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            GraphicPrimitives.Add(primitive);
        }

        public void DrawAll()
        {
            foreach (var primitive in GraphicPrimitives)
            {
                primitive.Draw();
            }
        }
    }
}