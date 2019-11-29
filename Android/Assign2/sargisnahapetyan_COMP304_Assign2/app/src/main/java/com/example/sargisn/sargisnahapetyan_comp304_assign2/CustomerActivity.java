package com.example.sargisn.sargisnahapetyan_comp304_assign2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class CustomerActivity extends AppCompatActivity {

    private double orderID;
    private TextView textViewName;
    private TextView textViewAddress;
    private TextView textViewCardNum;
    private TextView textViewExpDate;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_customer);

        textViewName = (TextView) findViewById(R.id.editText2);
        textViewAddress = (TextView) findViewById(R.id.editText3);
        textViewCardNum = (TextView) findViewById(R.id.editText4);
        textViewExpDate = (TextView) findViewById(R.id.editText5);

        TextView cuisineTextView = (TextView) findViewById(R.id.textView11);
        cuisineTextView.setText("Cuisine: " + getIntent().getExtras().getString("radioCuisineKey_Customer"));

        TextView restTextView = (TextView) findViewById(R.id.textView12);
        restTextView.setText("Restaurant: " + getIntent().getExtras().getString("restKey_Customer"));

        orderID = getRandomNumber(10000, 99999);
        TextView orderIDTextView = (TextView) findViewById(R.id.textViewOrderID);
        orderIDTextView.setText("Order ID: " + orderID);

        Spinner spinnerED = (Spinner) findViewById(R.id.spinnerED1);

        List<String> months = new ArrayList<String>();
        months.add("January");
        months.add("February");
        months.add("March");
        months.add("April");
        months.add("May");
        months.add("June");
        months.add("July");
        months.add("August");
        months.add("September");
        months.add("October");
        months.add("November");
        months.add("December");

        ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_item, months);
        spinnerED.setAdapter(dataAdapter);
    }

    public void goBack(View view) {
        Intent intent = new Intent(this, CuisinesActivity.class); //FoodActivity //CuisinesActivity
        startActivity(intent);
    }

    public void goToCheckOut(View view) {

        Intent intent = new Intent(this, CheckoutActivity.class);

        if ((textViewName.getText().toString().matches("")))
        {
            Toast.makeText(this, "Name is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewAddress.getText().toString().matches("")))
        {
            Toast.makeText(this, "Address is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewCardNum.getText().toString().matches("")) || (textViewCardNum.getText().length() != 16))
        {
            Toast.makeText(this, "Card Number is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewExpDate.getText().toString().matches(""))|| (textViewExpDate.getText().length() != 2)
                || (textViewExpDate.getText().toString().matches("00")))
        {
            Toast.makeText(this, "Expiration Date is invalid", Toast.LENGTH_LONG).show();
        }
        else
        {
            intent.putExtra("radioCuisineKey_Checkout", getIntent().getExtras().getString("radioCuisineKey_Customer"));
            intent.putExtra("restKey_Checkout", getIntent().getExtras().getString("restKey_Customer"));
            intent.putExtra("nameKey", textViewName.getText().toString());
            intent.putExtra("addressKey", textViewAddress.getText().toString());
            intent.putExtra("orderIDKey", orderID);

            intent.putExtra("checkBox1Key_Checkout", getIntent().getExtras().getString("checkBox1Key"));
            intent.putExtra("checkBox2Key_Checkout", getIntent().getExtras().getString("checkBox2Key"));
            intent.putExtra("checkBox3Key_Checkout", getIntent().getExtras().getString("checkBox3Key"));

            intent.putExtra("textVPrice1Key_Checkout", getIntent().getIntExtra("textVPrice1Key", 0));
            intent.putExtra("textVPrice2Key_Checkout", getIntent().getIntExtra("textVPrice2Key", 0));
            intent.putExtra("textVPrice3Key_Checkout", getIntent().getIntExtra("textVPrice3Key", 0));

            startActivity(intent);
        }

    }


    public static double getRandomNumber(double min, double max){
        double x = (int)(Math.random()*((max-min)+1))+min;
        return x;
    }
}
