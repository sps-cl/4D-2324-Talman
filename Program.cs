using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Hello World!");
    }
}

class Rectangle {
    public: {
        float width;
        float height;
    }

    public Rectangle(float width, float height) {
        this.width = width;
        this.height = height;
    }

    public void Draw() {
        Console.WriteLine("Drawing a rectangle with width {0} and height {1}", width, height);
    }
}