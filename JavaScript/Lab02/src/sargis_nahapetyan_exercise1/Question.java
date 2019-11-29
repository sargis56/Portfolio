package sargis_nahapetyan_exercise1;

public class Question {
	
	private String question;
	
	private String[] option = new String[4];
	
	private int answer;
	
	public Question(String question, String option1, String option2, String option3, 
			String option4, int answer) {
		this.question = question;
		this.option[0] = option1;
		this.option[1] = option2;
		this.option[2] = option3;
		this.option[3] = option4;
		this.answer = answer;
	}
	
		//Getters
	   public String getQuestion() {
		   return question;         
	   } 
	
	   public String getOptions(int index) {
		   return option[index];         
	   } 
	   
	   public int getAnswer() {
		   return answer;         
	   } 
}
