package com.example.sargisn.sargisnahapetyan_comp304_assign2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioButton;

public class CuisinesActivity extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cuisines);
    }

    public void goBack(View view) {
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
    }

    public void goToFoodActivity(View view) {
       // RadioButton radioButton1 = (RadioButton) findViewById(R.id.radioButton);
        Intent intent = new Intent(this, FoodActivity.class);

        String foodChosen = "none";

        switch(view.getId()) {
            case R.id.radioButton:
                foodChosen = getString(R.string.str_american);
                break;
            case R.id.radioButton2:
                foodChosen = getString(R.string.str_italian);
                break;
            case R.id.radioButton3:
                foodChosen = getString(R.string.str_international);
                break;
        }

        intent.putExtra("radioCuisineKey", foodChosen);

        startActivity(intent);
    }
}
