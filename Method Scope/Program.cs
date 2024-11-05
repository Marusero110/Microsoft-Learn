// Method to print out an array of students

string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

DisplayStudents(students);
DisplayStudents(new[] { "Robert", "Vanya" });

void DisplayStudents(string[] students) {
    foreach (string student in students) {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

Console.WriteLine();

// Method to calculate and print out the area and circumference of a circle

double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius) {
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius) {
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius) {
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}