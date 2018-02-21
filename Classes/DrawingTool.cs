namespace Classes
{
    public class DrawingTool
    {
        private IShape shape;

        public DrawingTool(IShape s)
        {
            shape = s;
        }
        public void Draw()
        {
            shape.Draw();
        }
    }
}
