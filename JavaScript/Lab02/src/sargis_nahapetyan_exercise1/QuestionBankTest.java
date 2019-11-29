package sargis_nahapetyan_exercise1;

public class QuestionBankTest {

	public static void main(String[] args) {
		
		Question question1 = new Question("What is the method toString() commonly used for?", 
				"Converting a variable to a string", 
				"Used to display the object’s data", 
				"Returns a string", 
				"Converting a object to a string", 2);
		
		Question question2 = new Question("How would you print \"Hello World\" in java?", 
				"System.out.println(\"Hello World\");", 
				"Console.WriteLine(\"Hello World\")", 
				"ouput(\"Hello World\")", 
				"print(\"Hello World\")", 1);
		
		Question question3 = new Question("What is a class in terms of Object-oriented programming?", 
				"A room you goto in school", 
				"A type of data type", 
				"An extensible program-code-template for creating objects", 
				"A method used for storing objects", 3);
		
		Question question4 = new Question("How would you commonly store a variable related to money in java?", 
				"using a string", "using a int", "using a system32", "using a double", 4);
		
		Question question5 = new Question("How do you define a method called \"Calculate Answer\" that returns a double in java?", 
				"public double CalculateAnswer()", 
				"public void calculateAnswer()", 
				"public double calculateAnswer()", 
				"double public \"Calculate Answer\"()", 3);
		
		Question question6 = new Question("What is the name of our teacher?", "Frank Horrigan", "Sujeet Lohan", "Surendranath Nandi", "Sayana Navathe", 2);
		
		QuestionBank bank = new QuestionBank(question1, question2, question3, question4, question5, question6);
		
		bank.inputAnswer();
		
		
	}

}
