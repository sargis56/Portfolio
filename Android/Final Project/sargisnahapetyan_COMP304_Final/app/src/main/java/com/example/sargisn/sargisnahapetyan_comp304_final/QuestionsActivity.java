package com.example.sargisn.sargisnahapetyan_comp304_final;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Toast;

public class QuestionsActivity extends AppCompatActivity {

    private float points;
    private RadioGroup radioBtnGroup1;
    private RadioGroup radioBtnGroup2;
    private RadioGroup radioBtnGroup3;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_questions);

        radioBtnGroup1 = (RadioGroup) findViewById(R.id.radioGroup);
        radioBtnGroup2 = (RadioGroup) findViewById(R.id.radioGroup2);
        radioBtnGroup3 = (RadioGroup) findViewById(R.id.radioGroup3);
    }

    public void goToResultsActivity(View view) {
        points = 0;

        RadioButton rBCorrect1 = (RadioButton) findViewById(R.id.radioButton5);
        RadioButton rBCorrect2 = (RadioButton) findViewById(R.id.radioButton10);
        RadioButton rBCorrect3 = (RadioButton) findViewById(R.id.radioButton14);

        if (rBCorrect1.isChecked())
        {
            points = points + 1;
        }
        if (rBCorrect2.isChecked())
        {
            points = points + 1;
        }
        if (rBCorrect3.isChecked())
        {
            points = points + 1;
        }

        Intent intent = new Intent(this, ResultsActivity.class);

        if (radioBtnGroup1.getCheckedRadioButtonId() == -1)
        {
            Toast.makeText(this, "Question 1 has not been answered", Toast.LENGTH_LONG).show();
        }
        else if (radioBtnGroup2.getCheckedRadioButtonId() == -1)
        {
            Toast.makeText(this, "Question 2 has not been answered", Toast.LENGTH_LONG).show();
        }
        else if (radioBtnGroup3.getCheckedRadioButtonId() == -1)
        {
            Toast.makeText(this, "Question 3 has not been answered", Toast.LENGTH_LONG).show();
        }
        else
        {
            intent.putExtra("pointsKey", points);
            startActivity(intent);
        }
    }
}
