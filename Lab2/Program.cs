using Lab2.Dictionary;
using Lab2.View;

public class Program {
    public static void Main(String[] args) {
        View v = new View(new dictionary());
        v.start();
    }
}