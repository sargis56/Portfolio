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
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import android.support.v7.app.AppCompatActivity;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {


    private TextView textViewName;
    private TextView textViewPassord;
    private static final String tables[]={"tbl_candidate","tbl_admin","tbl_jobOffer","tbl_payment"};

    private static final String tableCreatorString[] =
            {"CREATE TABLE tbl_candidate (candidatetId INTEGER PRIMARY KEY AUTOINCREMENT , userName TEXT, password TEXT, firstName TEXT, lastName TEXT, address TEXT, city TEXT, postalCode TEXT, qualification TEXT, experience TEXT);",
                    "CREATE TABLE tbl_admin (employeeId INTEGER PRIMARY KEY AUTOINCREMENT , userName TEXT, password TEXT, firstName TEXT, lastName TEXT);",
                    "CREATE TABLE tbl_jobOffer (interviewDate TEXT, interviewStatus TEXT, companyName TEXT, positionName TEXT, recruitmentStatus TEXT);",
                    "CREATE TABLE tbl_payment (candidatetId INTEGER PRIMARY KEY AUTOINCREMENT, paymentDate TEXT, amountPaid TEXT, creditCardNo TEXT, expiryDate TEXT);"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        textViewName = (TextView) findViewById(R.id.editText);
        textViewPassord = (TextView) findViewById(R.id.editText2);

        final DatabaseManager db = new DatabaseManager(this);
        //db.createDatabase(getApplicationContext());
        db.dbInitialize( tables,tableCreatorString);
/*
        final String fields[] = {"employeeId","userName", "password", "firstName","lastName"};
        final String record[] = new String[5];

        record[1]="joe21";
        record[2]="1";
        record[3]="joe";
        record[4]="Madden";
        Log.d("Name: ", record[1]);
        //populate the row with some values
        ContentValues values = new ContentValues();
        //add the row to the database
        db.addRecord(values, "tbl_admin", fields,record);
*/
    }

    public void goToRegisterActivity(View view) {
        Intent intent = new Intent(this, RegisterActivity.class);
        startActivity(intent);
    }

    public void goToJobSeekerActivity(View view) {
        Intent intent = new Intent(this, JobSeekerActivity.class);

        if ((textViewName.getText().toString().matches("")))
        {
            Toast.makeText(this, "Please enter name", Toast.LENGTH_LONG).show();
        }
        else if ((textViewPassord.getText().toString().matches("")))
        {
            Toast.makeText(this, "Please enter password", Toast.LENGTH_LONG).show();
        }
        else if (checkLogin(textViewName.getText().toString(), textViewPassord.getText().toString(), "tbl_candidate"))
        {
            startActivity(intent);
        }
        else
        {
            intent.putExtra("nameJSKey", textViewName.getText().toString());
            intent.putExtra("passwordJSKey", textViewPassord.getText().toString());
            Toast.makeText(this, "Login Error", Toast.LENGTH_LONG).show();
        }
    }

    public void goToAdminActivity(View view) {
        Intent intent = new Intent(this, AdminActivity.class);

        if ((textViewName.getText().toString().matches("")))
        {
            Toast.makeText(this, "Please enter name", Toast.LENGTH_LONG).show();
        }
        else if ((textViewPassord.getText().toString().matches("")))
        {
            Toast.makeText(this, "Please enter password", Toast.LENGTH_LONG).show();
        }
        else if (checkLogin(textViewName.getText().toString(), textViewPassord.getText().toString(), "tbl_admin"))
        {
            startActivity(intent);
        }
        else
        {
            Toast.makeText(this, "Login Error", Toast.LENGTH_LONG).show();
        }

    }

    public Boolean checkLogin(String userName, String password, String tableName){
        final DatabaseManager db = new DatabaseManager(this);
        boolean login = db.getLogin(userName, password, tableName);
        Toast.makeText(this, "Login successful", Toast.LENGTH_LONG).show();
        return login;
    }

    public void checkLoginTest(View view){
        String userName = "joe21";
        String password = "1";
        String tableName = "tbl_admin";
        final DatabaseManager db = new DatabaseManager(this);
        boolean login = db.getLogin(userName, password, tableName);
        Toast.makeText(this, "Login: " + login, Toast.LENGTH_LONG).show();
    }

    public void checkCellTest(View view){
        String cell = "joe21";
        String cul = "lastName";
        String tableName = "tbl_admin";
        String find = "userName";
        final DatabaseManager db = new DatabaseManager(this);
        String login = db.getCell(cell, cul, tableName, find);
        Toast.makeText(this, "Login: " + login, Toast.LENGTH_LONG).show();
    }

}

