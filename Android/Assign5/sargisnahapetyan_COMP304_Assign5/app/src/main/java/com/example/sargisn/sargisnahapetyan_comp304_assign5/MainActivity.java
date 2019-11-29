package com.example.sargisn.sargisnahapetyan_comp304_assign5;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.RatingBar;
import android.widget.Switch;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private RatingBar rating;
    private TextView showroomTV;
    private String showroomK;
    private float ratingK = 3.5f;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        rating = (RatingBar) findViewById(R.id.ratingBar);
        showroomTV = (TextView) findViewById(R.id.textViewShowroomSelected);
    }

    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.showrooms_menu, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.tommy_hilfigar_menu:
                rating.setRating(4.5f);
                ratingK = 4.5f;
                showroomTV.setText("Showroom: " + getResources().getString(R.string.str_tommy_hilfigar));
                showroomK = getResources().getString(R.string.str_tommy_hilfigar);
                break;
            case R.id.gap_menu:
                rating.setRating(4);
                ratingK = 4;
                showroomTV.setText("Showroom: " + getResources().getString(R.string.str_gap));
                showroomK = getResources().getString(R.string.str_gap);
                break;
            case R.id.guess_menu:
                rating.setRating(5);
                ratingK = 5;
                showroomTV.setText("Showroom: " + getResources().getString(R.string.str_guess));
                showroomK = getResources().getString(R.string.str_guess);
                break;
            case R.id.zara_menu:
                rating.setRating(3.5f);
                ratingK = 3.5f;
                showroomTV.setText("Showroom: " + getResources().getString(R.string.str_zara));
                showroomK = getResources().getString(R.string.str_zara);
                break;
            case R.id.cleo_menu:
                rating.setRating(3);
                ratingK = 3;
                showroomTV.setText("Showroom: " + getResources().getString(R.string.str_cleo));
                showroomK = getResources().getString(R.string.str_cleo);
                break;
        }

        return true;
    }

    public void goToLocations(View view) {
        Intent intent = new Intent(this, LocationsActivity.class);

        if (showroomK == null)
        {
            Toast.makeText(this, "No showroom selected", Toast.LENGTH_LONG).show();
        }
        else
        {
            intent.putExtra("showroomKey", showroomK);
            intent.putExtra("ratingKey", ratingK);
            startActivity(intent);
        }
    }
}
