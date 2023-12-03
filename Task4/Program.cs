namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            GraphicsEditor editor = new GraphicsEditor();

            Circle circle = new Circle { X = 10, Y = 20, Radius = 5 };
            Rectangle rectangle = new Rectangle { X = 30, Y = 40, Width = 8, Height = 12 };
            Triangle triangle = new Triangle { X = 50, Y = 60 };

            Group group = new Group();
            group.AddPrimitive(circle);
            group.AddPrimitive(rectangle);

            editor.AddPrimitive(circle);
            editor.AddPrimitive(rectangle);
            editor.AddPrimitive(triangle);
            editor.AddPrimitive(group);

            editor.DrawAll();

            foreach (var primitive in editor.GraphicPrimitives)
            {
                primitive.Move(5, 5);
            }

            circle.Scale(2.0f);
            rectangle.Scale(1.5f);

            editor.DrawAll();
        }
    }
}