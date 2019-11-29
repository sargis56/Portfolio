package com.example.sargisn.sargisn_comp304_midterm;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;

public class StockActivity extends AppCompatActivity {

    private CheckBox checkBox1;
    private CheckBox checkBox2;
    private CheckBox checkBox3;
    private CheckBox checkBox4;
    private CheckBox checkBox5;

    private String checkBox1Text = null;
    private String checkBox2Text = null;
    private String checkBox3Text = null;
    private String checkBox4Text = null;
    private String checkBox5Text = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_stock);

        checkBox1 = (CheckBox) findViewById(R.id.checkBox);
        checkBox2 = (CheckBox) findViewById(R.id.checkBox2);
        checkBox3 = (CheckBox) findViewById(R.id.checkBox3);
        checkBox4 = (CheckBox) findViewById(R.id.checkBox4);
        checkBox5 = (CheckBox) findViewById(R.id.checkBox5);

        String[] stockArray = getResources().getStringArray(R.array.stocks);
        checkBox1.setText(stockArray[0]);
        checkBox2.setText(stockArray[1]);
        checkBox3.setText(stockArray[2]);
        checkBox4.setText(stockArray[3]);
        checkBox5.setText(stockArray[4]);


    }

    public void goToChartActivity(View view)
    {
        if (checkBox1.isChecked())
        {
            checkBox1Text = "IBM, ";
        }
        if (checkBox2.isChecked())
        {
            checkBox2Text = "AAPL, ";
        }
        if (checkBox3.isChecked())
        {
            checkBox3Text = "ORCL, ";
        }
        if (checkBox4.isChecked())
        {
            checkBox4Text = "MSFT, ";
        }
        if (checkBox5.isChecked())
        {
            checkBox5Text = "GOOG, ";
        }

        Intent intent = new Intent(this, ChartActivity.class);
        intent.putExtra("checkBox1Key", checkBox1Text);
        intent.putExtra("checkBox2Key", checkBox2Text);
        intent.putExtra("checkBox3Key", checkBox3Text);
        intent.putExtra("checkBox4Key", checkBox4Text);
        intent.putExtra("checkBox5Key", checkBox5Text);
        startActivity(intent);
    }
}
