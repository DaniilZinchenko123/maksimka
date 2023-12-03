namespace Task4
{
    public class Group : GraphicPrimitive
    {
        private List<GraphicPrimitive> primitives;

        public Group()
        {
            primitives = new List<GraphicPrimitive>();
        }

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Group at ({X}, {Y})");
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
            foreach (var primitive in primitives)
            {
                primitive.Move(x, y);
            }
        }

        public override void Scale(float factor)
        {
            foreach (var primitive in primitives)
            {
                primitive.Scale(factor);
            }
        }
    }
}