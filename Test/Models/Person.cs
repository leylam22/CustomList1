using Test.Interface;

namespace Test.Models;

public class Person : IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
}
