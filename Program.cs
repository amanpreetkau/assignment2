using System;
namespace RectangleProject {

public class Program
{
	public static void Main()
	{
		int width = EnterWidth();
		int length = EnterLength();
		Rectangle rect = new Rectangle(width,length);
		int option=DisplayMenu();
		while(option!=7){
			switch (option) 
			{
			  case 1:
				ShowLength(rect);
				break;
			  case 2:
				UpdateLength(rect);
				break;
			  case 3:
				ShowWidth(rect);
				break;
			  case 4:
				UpdateWidth(rect);
				break;
			  case 5:
				ShowPerimeter(rect);
				break;
			  case 6:
				ShowArea(rect);
				break;				
			}
			option=DisplayMenu();
		}
	}
	public static int ShowLength(Rectangle rect){
		Console.WriteLine("Rectangle Length "+ rect.GetLength());
        return rect.GetLength();
	}
	public static int ShowWidth(Rectangle rect){
		Console.WriteLine("Rectangle Width "+ rect.GetWidth());
        return rect.GetWidth();
	}
	public static int ShowPerimeter(Rectangle rect){
		Console.WriteLine("Rectangle Perimeter "+ rect.GetPerimeter());
        return rect.GetPerimeter();
	}
	public static int ShowArea(Rectangle rect){
		Console.WriteLine("Rectangle Area "+ rect.GetArea());
        return rect.GetArea();
	}
	public static int UpdateLength(Rectangle rect){
		int length = EnterLength();
		rect.SetLength(length);
        return length;
	}
	public static int UpdateWidth(Rectangle rect){
		int width = EnterWidth();
		rect.SetWidth(width);
        return width;
	}
	static int EnterLength(){
		Console.WriteLine("Enter Length");
		int length = Convert.ToInt32(Console.ReadLine());
		if(length<=0){
			Console.WriteLine("Enter Length Greater than Zero");
		    EnterLength();
		}
		return length;
	}
	static int EnterWidth(){
		Console.WriteLine("Enter Width");
		int width = Convert.ToInt32(Console.ReadLine());
		if(width<=0){
			Console.WriteLine("Enter Width Greater than Zero");
		    EnterWidth();
		}
		return width;
	}
	static int DisplayMenu(){
		Console.WriteLine("Select:- \n1. Get Rectangle Length\n2. Change Rectangle Length\n3. Get Rectangle Width\n4. Change Rectangle Width\n5. Get Rectangle Perimeter\n6. Get Rectangle Area\n7. Exit ");
		int option = Convert.ToInt32(Console.ReadLine());
		if(option<1 || option>7){
			Console.WriteLine("Select Valid Entry");
			DisplayMenu();
		}
		return option;
	}
}
}
