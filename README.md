# MyDictionary Project

This project is a simple implementation of a dictionary in C#. It provides basic functionalities like adding, removing, and displaying key-value pairs.

## Usage

To use the MyDictionary class, follow these steps:

1. Create an instance of the MyDictionary class:

    ```csharp
    MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
    ```

2. Add key-value pairs using the `Add` method:

    ```csharp
    myDictionary.Add("Enes", 2022);
    myDictionary.Add("Kaan", 2023);
    myDictionary.Add("Kerem", 2024);
    ```

3. Retrieve the count of key-value pairs using the `Count` method:

    ```csharp
    int count = myDictionary.Count();
    Console.WriteLine($"Number of entries: {count}");
    ```

4. Display a specific key-value pair using the `Show` method:

    ```csharp
    myDictionary.Show("Enes");
    ```

5. Remove a key-value pair using the `RemoveAt` method:

    ```csharp
    myDictionary.RemoveAt("Enes");
    ```

6. Show the updated dictionary:

    ```csharp
    myDictionary.Show("Enes");
    myDictionary.Show("Kerem");
    ```

## Example

```csharp
MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

myDictionary.Add("Enes", 2022);
myDictionary.Add("Kaan", 2023);
myDictionary.Add("Kerem", 2024);

int count = myDictionary.Count();
Console.WriteLine($"Number of entries: {count}");

myDictionary.Show("Enes");
myDictionary.RemoveAt("Enes");

myDictionary.Show("Enes"); // This should print that the key couldn't be found
myDictionary.Show("Kerem");

myDictionary.Add("Erdem", 2025);
myDictionary.Show("Erdem");
