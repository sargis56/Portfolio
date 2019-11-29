package com.example.sargisn.sargisnahapetyan_comp304_final;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

public class StoreActivity extends AppCompatActivity {

    private float stars;
    private TextView discountTV;
    private TextView doritosTV;
    private TextView doritos2TV;
    private TextView doritos3TV;
    private TextView mountainDewTV;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_store);

        discountTV = (TextView) findViewById(R.id.textView18);
        mountainDewTV = (TextView) findViewById(R.id.textView16);
        doritosTV = (TextView) findViewById(R.id.textView13);
        doritos2TV = (TextView) findViewById(R.id.textView14);
        doritos3TV = (TextView) findViewById(R.id.textView15);

        stars = getIntent().getExtras().getFloat("pointsKey_store");

        if (stars == 1)
        {
            discountTV.setText("5% Discount");
            doritosTV.setText("$3.99");
            mountainDewTV.setText("$3.99");
            doritos2TV.setText("$3.42");
            doritos3TV.setText("$5.98");
        }
        else if (stars == 2)
        {
            discountTV.setText("10% Discount");
            doritosTV.setText("$3.78");
            mountainDewTV.setText("$3.78");
            doritos2TV.setText("$3.24");
            doritos3TV.setText("$5.67");
        }
        else if (stars == 3)
        {
            discountTV.setText("25% Discount");
            doritosTV.setText("$3.15");
            mountainDewTV.setText("$3.15");
            doritos2TV.setText("$2.70");
            doritos3TV.setText("$4.72");
        }
        else
        {
            discountTV.setText("0% Discount");
            doritosTV.setText("$4.20");
            mountainDewTV.setText("$4.20");
            doritos2TV.setText("$3.60");
            doritos3TV.setText("$6.30");
        }

    }

    public void goToLogInActivity(View view) {
        Intent intent = new Intent(this, LogInActivity.class);

        CheckBox checkBox1 = (CheckBox) findViewById(R.id.checkBox);
        CheckBox checkBox2 = (CheckBox) findViewById(R.id.checkBox3);
        CheckBox checkBox3 = (CheckBox) findViewById(R.id.checkBox4);
        CheckBox checkBox4 = (CheckBox) findViewById(R.id.checkBox6);


        if ((checkBox1.isChecked()== false) && (checkBox2.isChecked()== false)
                && (checkBox3.isChecked()== false) && (checkBox4.isChecked()== false))
        {
            Toast.makeText(this, "No items selected", Toast.LENGTH_LONG).show();
        }
        else
        {
            startActivity(intent);
        }


    }
}
