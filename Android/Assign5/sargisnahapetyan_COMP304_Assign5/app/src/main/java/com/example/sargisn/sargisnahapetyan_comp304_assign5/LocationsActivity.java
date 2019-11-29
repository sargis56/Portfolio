package com.example.sargisn.sargisnahapetyan_comp304_assign5;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.RatingBar;
import android.widget.Switch;
import android.widget.TextView;
import android.widget.Toast;

public class LocationsActivity extends AppCompatActivity {

    private TextView showroomTV;
    private RatingBar rating;
    private RadioGroup radioBtnGroup;
    private Switch sateSwitch;
    private int sateSwitchCheck;
    private String showroomSelected;
    private String address;
    private double v = 50;
    private double v1 = 50;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_locations);

        showroomTV = (TextView) findViewById(R.id.textViewShowroomSelected2);
        rating = (RatingBar) findViewById(R.id.ratingBar2);
        radioBtnGroup = (RadioGroup) findViewById(R.id.radioGroup);
        sateSwitch = (Switch) findViewById(R.id.switch1);
        showroomSelected = getIntent().getExtras().getString("showroomKey");
        showroomTV.setText(showroomSelected);
        rating.setRating(getIntent().getExtras().getFloat("ratingKey"));
    }

    public void goToMap(View view) {
        Intent intent = new Intent(this, MapsActivity.class);

        if (sateSwitch.isChecked())
        {
            sateSwitchCheck = 1;
        }
        else
        {
            sateSwitchCheck = 0;
        }

        RadioButton radioButton1 = (RadioButton) findViewById(R.id.radioButton);
        RadioButton radioButton2 = (RadioButton) findViewById(R.id.radioButton2);
        RadioButton radioButton3 = (RadioButton) findViewById(R.id.radioButton3);
        RadioButton radioButton4 = (RadioButton) findViewById(R.id.radioButton4);
        RadioButton radioButton5 = (RadioButton) findViewById(R.id.radioButton5);
        //Toronto
        if (radioButton1.isChecked())
        {
            if (showroomSelected.equals(getResources().getString(R.string.str_tommy_hilfigar)))
            {
                //43.655991, -79.433959
                v = 43.655991;
                v1 = -79.433959;
                address = "900 Dufferin St, Toronto, ON M6H 4A9";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_gap)))
            {
                //43.670659, -79.389338
                v = 43.670659;
                v1 = -79.389338;
                address = "60 Bloor St W, Toronto, ON M4W 3B8";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_guess)))
            {
                //43.654130, -79.380434
                v = 43.654130;
                v1 = -79.380434;
                address = "CF Toronto Eaton Center, 306 Yonge St, Toronto, ON M5B 1R4";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_zara)))
            {
                //43.655170, -79.381034
                v = 43.655170;
                v1 = -79.381034;
                address = "CF TORONTO EATON CENTRE, 220 Yonge St, Toronto, ON M5B 2H1";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_cleo)))
            {
                //43.649083, -79.380906
                v = 43.649083;
                v1 = -79.380906;
                address = "66 Wellington St W #0001, Toronto, ON M5K 1A1";
            }
        }
        //Scarborough
        else if (radioButton2.isChecked())
        {
            if (showroomSelected.equals(getResources().getString(R.string.str_tommy_hilfigar)))
            {
                //43.776140, -79.257225
                v = 43.776140;
                v1 = -79.257225;
                address = "SCARBOROUGH TOWN CENTRE, 300 Borough Dr UNIT #17, Scarborough, ON M1P 4P5";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_gap)))
            {
                //43.775094, -79.257938
                v = 43.775094;
                v1 = -79.257938;
                address = "300 Borough Dr, Scarborough, ON M1P 4P5";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_guess)))
            {
                //43.776355, -79.257730
                v = 43.776355;
                v1 = -79.257730;
                address = "300 Borough Dr Unit 270, Scarborough, ON M1P 4P5";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_zara)))
            {
                //43.775703, -79.258682
                v = 43.775703;
                v1 = -79.258682;
                address = "SCARBOROUGH TOWN CENTRE, 300 Borough Dr #248, Scarborough, ON M1P 4P5";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_cleo)))
            {
                //43.727519, -79.292342
                v = 43.727519;
                v1 = -79.292342;
                address = "1900 Eglinton Ave E #22, Scarborough, ON M1L 2L9";
            }
        }
        //Mississauga
        else if (radioButton3.isChecked())
        {
            if (showroomSelected.equals(getResources().getString(R.string.str_tommy_hilfigar)))
            {
                //43.592952, -79.569241
                v = 43.592952;
                v1 = -79.569241;
                address = "1250 S Service Rd, Mississauga, ON L5E 1V4";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_gap)))
            {
                //43.594348, -79.640948
                v = 43.594348;
                v1 = -79.640948;
                address = "City Centre Dr, Mississauga, ON L5B 2G6";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_guess)))
            {
                //43.592805, -79.641574
                v = 43.592805;
                v1 = -79.641574;
                address = "100 City Centre Drive Units #2206 & 2007, Mississauga, ON L5B 2C9";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_zara)))
            {
                //43.593334, -79.641809
                v = 43.593334;
                v1 = -79.641809;
                address = "100 City Centre Dr, Mississauga, ON L5B 2C9";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_cleo)))
            {
                //43.592949, -79.643536
                v = 43.592949;
                v1 = -79.643536;
                address = "100 City Centre Dr #2-147A, Mississauga, ON L5B 2C9";
            }
        }
        //Oakville
        else if (radioButton4.isChecked())
        {
            if (showroomSelected.equals(getResources().getString(R.string.str_tommy_hilfigar)))
            {
                //43.398318, -79.750140
                v = 43.398318;
                v1 = -79.750140;
                address = "BURLOAK CENTRE, 3499 Wyecroft Rd UNIT L6, Oakville, ON L6L 0B6";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_gap)))
            {
                //43.325784, -79.820169
                v = 43.325784;
                v1 = -79.820169;
                address = "900 Maple Ave, Burlington, ON L7S 2J8";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_guess)))
            {
                //43.397895, -79.752009
                v = 43.397895;
                v1 = -79.752009;
                address = "3527 Wyecroft Road Unit K3D, Oakville, ON L6L 0B6";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_zara)))
            {
                //43.329356, -79.820372

                //no zara in oakville

                v = 43.329356;
                v1 = -79.820372;
                address = "900 Maple Ave, Burlington, ON L7S 2J8";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_cleo)))
            {
                //43.482982, -79.721893
                v = 43.482982;
                v1 = -79.721893;
                address = "Smart Centres Oakville Unit #K4, 202 Oak Walk Dr, Oakville, ON L6H 0H4";
            }
        }
        //North York
        else if (radioButton5.isChecked())
        {
            if (showroomSelected.equals(getResources().getString(R.string.str_tommy_hilfigar)))
            {
                //43.777192, -79.345743
                v = 43.777192;
                v1 = -79.345743;
                address = "FAIRVIEW MALL. UNIT #120E North York ON M2J 5A7 CA, 1800 Sheppard Ave E, North York, ON M2J 5A7";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_gap)))
            {
                //43.769523, -79.384060
                v = 43.769523;
                v1 = -79.384060;
                address = "BAYVIEW VILLAGE, 2901 Bayview Ave, North York, ON M2K 1E6";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_guess)))
            {
                //43.735855, -79.344822
                v = 43.735855;
                v1 = -79.344822;
                address = "28 Karl Fraser Rd, Toronto, ON M3C 0E8";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_zara)))
            {
                //43.778631, -79.345103
                v = 43.778631;
                v1 = -79.345103;
                address = "1800 Sheppard Ave E, North York, ON M2J 5A7";
            }
            else if (showroomSelected.equals(getResources().getString(R.string.str_cleo)))
            {
                //43.648957, -79.381869

                //no cleo in north york

                v = 43.648957;
                v1 = -79.381869;
                address = "66 Wellington St W #0001, Toronto, ON M5K 1A1";
            }
        }


        if (radioBtnGroup.getCheckedRadioButtonId() == -1)
        {
            Toast.makeText(this, "No location selected", Toast.LENGTH_LONG).show();
        }
        else
        {
            intent.putExtra("showroomKey_Map", showroomSelected);
            intent.putExtra("ratingKey_Map", getIntent().getExtras().getFloat("ratingKey"));
            intent.putExtra("sateSwitchKey", sateSwitchCheck);
            intent.putExtra("vKey", v);
            intent.putExtra("v1Key", v1);
            intent.putExtra("addressKey", address);
            //Toast.makeText(this, "v: " + v + " v1: " + v1, Toast.LENGTH_LONG).show();
            startActivity(intent);
        }
    }
}
