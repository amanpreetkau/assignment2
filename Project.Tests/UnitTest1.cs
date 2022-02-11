using Xunit;
using RectangleProject;
namespace Project.Tests;

public class Program_DoTests
{
    [Fact]
    public void TestGetLen1()
    {
        Rectangle rect = new Rectangle(10,20);
        int result = Program.ShowLength(rect);
        Assert.True(result,20);
    }
    public void TestGetLen2()
    {
        Rectangle rect = new Rectangle(10,13);
        int result = Program.ShowLength(rect);
        Assert.True(result,13);
    }
    public void TestGetLen3()
    {
        Rectangle rect = new Rectangle();
        int result = Program.ShowLength(rect);
        Assert.True(result,1);
    }
    public void TestGetWidth1()
    {
        Rectangle rect = new Rectangle(10,20);
        int result = Program.ShowWidth(rect);
        Assert.True(result,10);
    }
    public void TestGetWidth2()
    {
        Rectangle rect = new Rectangle(10,13);
        int result = Program.ShowWidth(rect);
        Assert.True(result,10);
    }
    public void TestGetWidth3()
    {
        Rectangle rect = new Rectangle();
        int result = Program.ShowWidth(rect);
        Assert.True(result,1);
    }
    public void TestGetPeri1()
    {
        Rectangle rect = new Rectangle(10,20);
        int result = Program.ShowPerimeter(rect);
        Assert.True(result,60);
    }
    public void TestGetPeri2()
    {
        Rectangle rect = new Rectangle(10,13);
        int result = Program.ShowPerimeter(rect);
        Assert.True(result,46);
    }
    public void TestGetPeri3()
    {
        Rectangle rect = new Rectangle();
        int result = Program.ShowPerimeter(rect);
        Assert.True(result,4);
    }
    public void TestGetArea1()
    {
        Rectangle rect = new Rectangle(10,20);
        int result = Program.ShowArea(rect);
        Assert.True(result,200);
    }
    public void TestGetArea2()
    {
        Rectangle rect = new Rectangle(10,13);
        int result = Program.ShowArea(rect);
        Assert.True(result,130);
    }
    public void TestGetArea3()
    {
        Rectangle rect = new Rectangle();
        int result = Program.ShowArea(rect);
        Assert.True(result,1);
    }
    
}