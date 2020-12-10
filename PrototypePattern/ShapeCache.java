import java.util.HashMap;

public class ShapeCache {
    private static HashMap<String, Shape> shapeMap = new HashMap<>();
    public static Shape getShape(String shapeId) {
        Shape shape = shapeMap.get(shapeId);
        return (Shape)shape.clone();
    }
    public static void loadCache()
    {
        Circle circle = new Circle();
        circle.setId("1");
        shapeMap.put(circle.getId(), circle);

        Rectangle rectangle = new Rectangle();
        rectangle.setId("2");
        shapeMap.put(rectangle.getId(), rectangle);

        Square square = new Square();
        square.setId("3");
        shapeMap.put(square.getId(), square);
    }
}
