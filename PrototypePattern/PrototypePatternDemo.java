public class PrototypePatternDemo {
    public static void main(String[] args) {
        ShapeCache.loadCache();

        Shape cloneShape1 = ShapeCache.getShape("1");
        Shape cloneShape11 = ShapeCache.getShape("1");
        cloneShape1.draw();
        cloneShape11.draw();

        cloneShape11.setType("Circle2");
        cloneShape1.draw();
        cloneShape11.draw();

        Shape cloneShape2 = ShapeCache.getShape("2");
        cloneShape2.draw();

        Shape cloneShape3 = ShapeCache.getShape("3");
        cloneShape3.draw();
    }
}
