package com.example.sargisn.sargisnahapetyan_comp304_assign2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.CheckBox;
import android.widget.RatingBar;
import android.widget.TextView;
import android.widget.Toast;

public class FoodActivity extends AppCompatActivity {

    private String message;
    private CheckBox checkBoxOp1;
    private CheckBox checkBoxOp2;
    private CheckBox checkBoxOp3;
    private RatingBar rating;
    private TextView restaurant;
    private TextView textVPrice1;
    private TextView textVPrice2;
    private TextView textVPrice3;
    private String rest;

    private String checkBoxOp1Text = "";
    private String checkBoxOp2Text = "";
    private String checkBoxOp3Text = "";

    private Integer textVPrice1Text;
    private Integer textVPrice2Text;
    private Integer textVPrice3Text;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_food);
        checkBoxOp1 = (CheckBox) findViewById(R.id.checkBox);
        checkBoxOp2 = (CheckBox) findViewById(R.id.checkBox2);
        checkBoxOp3 = (CheckBox) findViewById(R.id.checkBox3);
        rating = (RatingBar) findViewById(R.id.ratingBar);
        restaurant = (TextView) findViewById(R.id.textView10);
        textVPrice1 = (TextView) findViewById(R.id.textViewPrice1);
        textVPrice2 = (TextView) findViewById(R.id.textViewPrice2);
        textVPrice3 = (TextView) findViewById(R.id.textViewPrice3);

    }

//use intent (indent) to persfer data across
    public void goBack(View view) {
        Intent intent = new Intent(this, CuisinesActivity.class);
        startActivity(intent);
    }


    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.foodmenuactivity, menu);

        MenuItem italianAntanios = menu.findItem(R.id.italian_antanios);
        MenuItem italianMama = menu.findItem(R.id.italian_mama);
        MenuItem italianMario = menu.findItem(R.id.italian_mario);

        MenuItem americanMcdonalds = menu.findItem(R.id.american_mcdonalds);
        MenuItem americanKgc = menu.findItem(R.id.american_kgc);
        MenuItem americanPizzaHut = menu.findItem(R.id.american_pizzahut);

        MenuItem internationalTurkish = menu.findItem(R.id.international_turkish);
        MenuItem internationalDevil = menu.findItem(R.id.international_devil);
        MenuItem internationalPubg = menu.findItem(R.id.international_pubg);

        Intent intent = getIntent();
        String message = getIntent().getExtras().getString("radioCuisineKey");

        if (message.equals(getString(R.string.str_american)))
        {
            italianAntanios.setVisible(false);
            italianMama.setVisible(false);
            italianMario.setVisible(false);
            internationalTurkish.setVisible(false);
            internationalDevil.setVisible(false);
            internationalPubg.setVisible(false);
        }
        else if (message.equals(getString(R.string.str_italian)))
        {
            americanMcdonalds.setVisible(false);
            americanKgc.setVisible(false);
            americanPizzaHut.setVisible(false);
            internationalTurkish.setVisible(false);
            internationalDevil.setVisible(false);
            internationalPubg.setVisible(false);
        }
        else if (message.equals(getString(R.string.str_international)))
        {
            italianAntanios.setVisible(false);
            italianMama.setVisible(false);
            italianMario.setVisible(false);
            americanMcdonalds.setVisible(false);
            americanKgc.setVisible(false);
            americanPizzaHut.setVisible(false);
        }

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item)
    {

        switch (item.getItemId())
        {
            //Italian foods
            case R.id.italian_mama:
                checkBoxOp1.setText("Big Mama Pizza");
                checkBoxOp2.setText("Daddy Pizza");
                checkBoxOp3.setText("Daughter Pasta");
                rating.setRating(3.5f);
                restaurant.setText(getResources().getString(R.string.str_italian_mama));
                textVPrice1.setText("20");
                textVPrice2.setText("15");
                textVPrice3.setText("12");
                break;
            case R.id.italian_mario:
                checkBoxOp1.setText("Meat Lovers Pizza");
                checkBoxOp2.setText("Marios Special Pizza");
                checkBoxOp3.setText("Veggie Pizza");
                rating.setRating(4);
                restaurant.setText(getResources().getString(R.string.str_italian_mario));
                textVPrice1.setText("17");
                textVPrice2.setText("14");
                textVPrice3.setText("10");
                break;
            case R.id.italian_antanios:
                checkBoxOp1.setText("Mushroom Pasta");
                checkBoxOp2.setText("Crab Pasta");
                checkBoxOp3.setText("Antanios Pizza");
                rating.setRating(4.5f);
                restaurant.setText(getResources().getString(R.string.str_italian_antanios));
                textVPrice1.setText("16");
                textVPrice2.setText("13");
                textVPrice3.setText("15");
                break;
            //American foods
            case R.id.american_mcdonalds:
                checkBoxOp1.setText("Big Mac");
                checkBoxOp2.setText("Mcnuggets");
                checkBoxOp3.setText("Happy Meal");
                rating.setRating(1);
                restaurant.setText(getResources().getString(R.string.str_american_mcdonalds));
                textVPrice1.setText("110");
                textVPrice2.setText("5");
                textVPrice3.setText("8");
                break;
            case R.id.american_kgc:
                checkBoxOp1.setText("Popcorn Chicken");
                checkBoxOp2.setText("Signature Fries");
                checkBoxOp3.setText("Chicken Bucket");
                rating.setRating(1.5f);
                restaurant.setText(getResources().getString(R.string.str_american_kgc));
                textVPrice1.setText("7");
                textVPrice2.setText("4");
                textVPrice3.setText("12");
                break;
            case R.id.american_pizzahut:
                checkBoxOp1.setText("House Pizza");
                checkBoxOp2.setText("Cheese Pizza");
                checkBoxOp3.setText("Chicken Pizza");
                rating.setRating(3);
                restaurant.setText(getResources().getString(R.string.str_american_pizzahut));
                textVPrice1.setText("17");
                textVPrice2.setText("14");
                textVPrice3.setText("16");
                break;
            //International foods
            case R.id.international_turkish:
                checkBoxOp1.setText("Beef Kebab");
                checkBoxOp2.setText("Olivier Salad");
                checkBoxOp3.setText("Lamb Chop");
                rating.setRating(4);
                restaurant.setText(getResources().getString(R.string.str_international_turkish));
                textVPrice1.setText("15");
                textVPrice2.setText("8");
                textVPrice3.setText("14");
                break;
            case R.id.international_devil:
                checkBoxOp1.setText("Sinners Sandwich");
                checkBoxOp2.setText("Grave Salad");
                checkBoxOp3.setText("Painkiller Soup");
                rating.setRating(5);
                restaurant.setText(getResources().getString(R.string.str_international_devil));
                textVPrice1.setText("666");
                textVPrice2.setText("666");
                textVPrice3.setText("666");
                break;
            case R.id.international_pubg:
                checkBoxOp1.setText("Camper Sandwich");
                checkBoxOp2.setText("Stream Snipe Soup");
                checkBoxOp3.setText("Noobs Breakfast");
                rating.setRating(3);
                restaurant.setText(getResources().getString(R.string.str_international_pubg));
                textVPrice1.setText("12");
                textVPrice2.setText("11");
                textVPrice3.setText("13");
                break;
        }

        rest = restaurant.getText().toString();
        checkBoxOp1Text = checkBoxOp1.getText().toString();
        checkBoxOp2Text = checkBoxOp2.getText().toString();
        checkBoxOp3Text = checkBoxOp3.getText().toString();

        textVPrice1Text = Integer.parseInt(textVPrice1.getText().toString());
        textVPrice2Text = Integer.parseInt(textVPrice2.getText().toString());
        textVPrice3Text = Integer.parseInt(textVPrice3.getText().toString());

        return true;
    }

    public void goToCustomer(View view) {

        if (checkBoxOp1.isChecked() == false)
        {
            checkBoxOp1Text = "";
            textVPrice1Text = 0;
        }
        if (checkBoxOp2.isChecked() == false)
        {
            checkBoxOp2Text = "";
            textVPrice2Text = 0;
        }
        if (checkBoxOp3.isChecked() == false)
        {
            checkBoxOp3Text = "";
            textVPrice3Text = 0;
        }



        Intent intent = new Intent(this, CustomerActivity.class);

        if (checkBoxOp1.getText() == getString(R.string.str_norestaurant))
        {
            Toast.makeText(this, getString(R.string.str_norestaurant), Toast.LENGTH_LONG).show();
        }
        else if ((checkBoxOp1.isChecked() == false) && (checkBoxOp2.isChecked() == false)&& (checkBoxOp3.isChecked() == false))
        {
            Toast.makeText(this, "No order selected", Toast.LENGTH_LONG).show();
        }
        else
        {
            intent.putExtra("radioCuisineKey_Customer", getIntent().getExtras().getString("radioCuisineKey"));
            intent.putExtra("restKey_Customer", rest);
            intent.putExtra("checkBox1Key", checkBoxOp1Text);
            intent.putExtra("checkBox2Key", checkBoxOp2Text);
            intent.putExtra("checkBox3Key", checkBoxOp3Text);
            intent.putExtra("textVPrice1Key", textVPrice1Text);
            intent.putExtra("textVPrice2Key", textVPrice2Text);
            intent.putExtra("textVPrice3Key", textVPrice3Text);
            startActivity(intent);
        }
    }
}
