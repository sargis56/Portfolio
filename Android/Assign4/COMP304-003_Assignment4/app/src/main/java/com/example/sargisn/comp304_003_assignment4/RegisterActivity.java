package com.example.sargisn.comp304_003_assignment4;

import java.util.ArrayList;
import java.util.List;

import android.app.Activity;

import android.app.Activity;
import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;

import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Toast;

public class RegisterActivity extends AppCompatActivity {

    private TextView textViewUserName;
    private TextView textViewPassord;
    private TextView textViewFirstName;
    private TextView textViewLastName;
    private TextView textViewAddress;
    private TextView textViewCity;
    private TextView textViewPostalCode;
    private TextView textViewQualification;
    private TextView textViewExperience;

    private TextView textViewCreditCardNo;
    private TextView textViewED;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);
    }

    public void register(View view) {

        textViewUserName = (TextView) findViewById(R.id.editText3);
        textViewPassord = (TextView) findViewById(R.id.editText4);
        textViewFirstName = (TextView) findViewById(R.id.editText5);
        textViewLastName = (TextView) findViewById(R.id.editText6);
        textViewAddress = (TextView) findViewById(R.id.editText7);
        textViewCity = (TextView) findViewById(R.id.editText8);
        textViewPostalCode = (TextView) findViewById(R.id.editText9);
        textViewQualification = (TextView) findViewById(R.id.editText10);
        textViewExperience = (TextView) findViewById(R.id.editText11);

        textViewCreditCardNo = (TextView) findViewById(R.id.editText12);
        textViewED = (TextView) findViewById(R.id.editText13);

        final DatabaseManager db = new DatabaseManager(this);

        final String fields[] = {"candidatetId","userName", "password", "firstName", "lastName", "address", "city", "postalCode", "qualification", "experience"};
        final String record[] = new String[10];

        final String fields2[] = {"candidatetId","paymentDate", "amountPaid", "creditCardNo","expiryDate"};
        final String record2[] = new String[5];

        record[1]= textViewUserName.getText().toString();
        record[2]= textViewPassord.getText().toString();
        record[3]= textViewFirstName.getText().toString();
        record[4]= textViewLastName.getText().toString();
        record[5]= textViewAddress.getText().toString();
        record[6]= textViewCity.getText().toString();
        record[7]= textViewPostalCode.getText().toString();
        record[8]= textViewQualification.getText().toString();
        record[9]= textViewExperience.getText().toString();

        record2[1]= "00-00-00";
        record2[2]= "0";
        record2[3]= textViewCreditCardNo.getText().toString();
        record2[4]= textViewED.getText().toString();

        ContentValues values = new ContentValues();
        ContentValues values2 = new ContentValues();
        Intent intent = new Intent(this, RegisterSucActivity.class);

        if ((textViewUserName.getText().toString().matches("")))
        {
            Toast.makeText(this, "User Name is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewPassord.getText().toString().matches("")))
        {
            Toast.makeText(this, "Password is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewFirstName.getText().toString().matches("")))
        {
            Toast.makeText(this, "First Name is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewLastName.getText().toString().matches("")))
        {
            Toast.makeText(this, "Last Name is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewAddress.getText().toString().matches("")))
        {
            Toast.makeText(this, "Address is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewCity.getText().toString().matches("")))
        {
            Toast.makeText(this, "City is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewPostalCode.getText().toString().matches("")))
        {
            Toast.makeText(this, "Postal Code is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewQualification.getText().toString().matches("")))
        {
            Toast.makeText(this, "Qualification is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewExperience.getText().toString().matches("")))
        {
            Toast.makeText(this, "Experience is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewCreditCardNo.getText().toString().matches("")) || (textViewCreditCardNo.getText().length() != 16))
        {
            Toast.makeText(this, "Card Number is invalid", Toast.LENGTH_LONG).show();
        }
        else if ((textViewED.getText().toString().matches(""))|| (textViewED.getText().length() != 2)
                || (textViewED.getText().toString().matches("00")))
        {
            Toast.makeText(this, "Expiration Date is invalid", Toast.LENGTH_LONG).show();
        }
        else
        {
            db.addRecord(values, "tbl_candidate", fields,record);
            db.addRecord(values2, "tbl_payment", fields2,record2);
            intent.putExtra("userNameJSKey", textViewUserName.getText().toString());
            intent.putExtra("userPasswordJSKey", textViewPassord.getText().toString());
            Toast.makeText(this, "Registration Successful", Toast.LENGTH_LONG).show();
            startActivity(intent);
        }
    }
}
