package application;

import javafx.fxml.FXML;
import javafx.event.ActionEvent;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;

public class MainController {

    @FXML
    private TextField txtPrice;

    @FXML
    private TextField txtDP;

    @FXML
    private TextField txtAI;

    @FXML
    private Label lbl2Y;

    @FXML
    private Label lbl3Y;

    @FXML
    private Label lbl4Y;

    @FXML
    private Label lbl5Y;

    @FXML
    void onCalcClick(ActionEvent event) {
    	
		try {
			double price = Double.parseDouble(txtPrice.getText());
			double downPayment = Double.parseDouble(txtDP.getText());
			double annualInterst = Double.parseDouble(txtAI.getText()) / 100;
			
			price = price - downPayment;
			
			
    		double twoYears = (price*((annualInterst*Math.pow((1+annualInterst), 2)))/((Math.pow((1+annualInterst), 2) - 1)))/12;
    		double threeYears = (price*((annualInterst*Math.pow((1+annualInterst), 3)))/((Math.pow((1+annualInterst), 3) - 1)))/12;
    		double fourYears = (price*((annualInterst*Math.pow((1+annualInterst), 4)))/((Math.pow((1+annualInterst), 4) - 1)))/12;
    		double fiveYears = (price*((annualInterst*Math.pow((1+annualInterst), 5)))/((Math.pow((1+annualInterst), 5) - 1)))/12;
        	
    		lbl2Y.setText(String.format("$%.2f", twoYears));
			lbl3Y.setText(String.format("$%.2f", threeYears));
			lbl4Y.setText(String.format("$%.2f", fourYears));
			lbl5Y.setText(String.format("$%.2f", fiveYears));
			
		} catch(Exception e) {
			lbl2Y.setText("error");
			lbl3Y.setText("error");
			lbl4Y.setText("error");
			lbl5Y.setText("error");
			
		}
    }

}
