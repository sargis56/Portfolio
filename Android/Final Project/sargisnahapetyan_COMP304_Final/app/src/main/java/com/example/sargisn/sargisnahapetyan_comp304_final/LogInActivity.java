package com.example.sargisn.sargisnahapetyan_comp304_final;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class LogInActivity extends AppCompatActivity {

    private TextView textViewName;
    private TextView textViewAddress;
    private TextView textViewCardNum;
    private TextView textViewExpDate;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_log_in);

        textViewName = (TextView) findViewById(R.id.editText);
        textViewAddress = (TextView) findViewById(R.id.editText2);
        textViewCardNum = (TextView) findViewById(R.id.editText3);
        textViewExpDate = (TextView) findViewById(R.id.editText4);

        Spinner spinnerED = (Spinner) findViewById(R.id.spinner);

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

    public void goToCheckoutActivity(View view) {
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
            startActivity(intent);
        }

    }
}
