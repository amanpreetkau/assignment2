using System;
namespace RectangleProject {
public class Rectangle
{
    private int width,length;
    public Rectangle(){
        this.width=1;
        this.length=1;
    }
    public Rectangle(int width,int length){
        this.width=width;
        this.length=length;
    }
    public int GetWidth(){
        return this.width;
    }
    public int GetLength(){
        return this.length;
    }
    public int SetWidth(int width){
        this.width=width;
        return this.width;
    }
    public int SetLength(int length){
        this.length=length;
        return this.length;
    }
    public int GetPerimeter(){
        return 2*(this.width+this.length);
    }
    public int GetArea(){
        return (this.width*this.length);
    }
}
}
