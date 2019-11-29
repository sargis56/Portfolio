package com.example.sargisn.sargisnahapetyan_comp304_final;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.RatingBar;
import android.widget.TextView;

public class ResultsActivity extends AppCompatActivity {

    private RatingBar rating;
    private float stars;
    private TextView discountTV;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_results);

        discountTV = (TextView) findViewById(R.id.textView10);

        rating = (RatingBar) findViewById(R.id.ratingBar);
        stars = getIntent().getExtras().getFloat("pointsKey");
        rating.setRating(stars);

        if (stars == 1)
        {
            discountTV.setText("5% Discount");
        }
        else if (stars == 2)
        {
            discountTV.setText("10% Discount");
        }
        else if (stars == 3)
        {
            discountTV.setText("25% Discount");
        }
        else
        {
            discountTV.setText("0% Discount");
        }
    }

    public void goToStoreActivity(View view) {
        Intent intent = new Intent(this, StoreActivity.class);

        intent.putExtra("pointsKey_store", stars);
        startActivity(intent);
    }
}
