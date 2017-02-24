using NUnit.Framework;
using System;
using System.Text;
using System.Linq;

public class HelloWorldTest
{
  
	public void Main(string[] args){
		//say something to bobby
		do{
		string player = Console.ReadLine();
		
		Console.WriteLine (BobHey(player));
		}
		while(true);
	}
		
		public string BobHey(string word){
		// Tell bob
		
			if (word.EndsWith("?")){
				return "sure";
				
			}else if (word.EndsWith("!") || word.Any(c=> char.IsUpper(c)) ){
			return "Whoa,ChillOut";
				
			}else if(String.IsNullOrEmpty(word)){
				
				return "Fine, Be That way!";
			}
			else{return "whatever";}
			
			
		}



	}

