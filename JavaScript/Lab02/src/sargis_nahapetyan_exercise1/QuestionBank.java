package sargis_nahapetyan_exercise1;

import java.security.SecureRandom;
import java.util.Scanner; 

public class QuestionBank {
	Scanner userInput = new Scanner(System.in);
	SecureRandom randomObject = new SecureRandom();      
	//Question[] question = new Question[5];
	Question[] question = new Question[6];
	int correctAnswers = 0;
	int incorrectAnswers = 0;
	
	public QuestionBank(Question question1, 
			Question question2, 
			Question question3, 
			Question question4,
			Question question5,
			Question question6) {
		this.question[0] = question1;
		this.question[1] = question2;
		this.question[2] = question3;
		this.question[3] = question4;
		this.question[4] = question5;
		this.question[5] = question6;
	}
	
	//Methods
	public void simulateQuestion(int index) { 
		System.out.printf("%n"+ (index + 1) + ": "+ "%s", question[index].getQuestion());	
	      for (int q = 0; q < 4; q++) {
	    	  
	    	  System.out.printf("%n	" + (q + 1) + ": "+ "%s%n", question[index].getOptions(q));
	       }      
	} 
	
	public void checkAnswer(int inNum, int qIndex) { 
		if (inNum == question[qIndex].getAnswer())
		{
			System.out.printf("%s%n", generateMessage());
			correctAnswers = correctAnswers + 1;
		}
		else
		{
			System.out.printf("%nThe correct answer is %s%n Please try agein", question[qIndex].getAnswer());	
			incorrectAnswers = incorrectAnswers + 1;
		}
	} 
	
	public String generateMessage() { 
		switch ( randomObject.nextInt( 4 ) )
		{
		case 0:
		return( "Nice work!" );
		case 1:
		return( "Excellent!" );
		case 2:
		return( "Good!" );
		case 3:
		return( "Keep up the good work!" );
		default:
		return( "Very good!" );
		}
	} 
	
	public void inputAnswer() {
		
	      for (int q = 0; q < question.length; q++) {
	  		simulateQuestion(q);
			System.out.println("Please enter a number");
			
		    while (!userInput.hasNextInt()) {
		        System.out.println("ERROR: Input not a number, please try agein");
		        
		        userInput.next();
		    }
		    int inNum = userInput.nextInt();
			checkAnswer(inNum, q);
	    	  
	       }     
	      
	      System.out.printf("%nThe test is finished %nCorrect Answers: %d"
	    		  + "%nIncorrect Answers: %d"
	    		  + "%nPercentage Answers: %.2f%%", correctAnswers, incorrectAnswers, calcPercentage());
	} 
	
	public float calcPercentage()
	{		
		float percent = (correctAnswers * 100.0f) / question.length;
		return percent;
		
	}
	
}
