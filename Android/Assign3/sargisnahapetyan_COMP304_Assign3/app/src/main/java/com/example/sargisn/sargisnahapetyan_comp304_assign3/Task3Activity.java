package com.example.sargisn.sargisnahapetyan_comp304_assign3;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Paint;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.Button;
import android.widget.ImageView;

public class Task3Activity extends AppCompatActivity {

    ImageView earthImageView;
    ImageView moonImageView;
    Animation an1;
    Animation an2;

    Paint paint;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_task3);

        paint = new Paint();

        final Button onButton = (Button) findViewById(R.id.ButtonStartT3);
        onButton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                startAnimation();
            }
        });

        final Button offButton = (Button) findViewById(R.id.ButtonStopT3);
        offButton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                stopAnimation();
            }
        });
    }

    private void startAnimation()
    {
        earthImageView = (ImageView)findViewById(R.id.ImageViewEarth);
        moonImageView = (ImageView)findViewById(R.id.ImageViewMoon);

        an1 =  AnimationUtils.loadAnimation(this, R.anim.translate_earth);
        an2 =  AnimationUtils.loadAnimation(this, R.anim.translate_moon);

        earthImageView.startAnimation(an1);
        moonImageView.startAnimation(an2);
    }

    private void stopAnimation()
    {
        earthImageView.clearAnimation();
        moonImageView.clearAnimation();
    }
}
