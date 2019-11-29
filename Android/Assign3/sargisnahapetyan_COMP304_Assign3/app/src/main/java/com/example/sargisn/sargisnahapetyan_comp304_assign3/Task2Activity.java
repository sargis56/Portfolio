package com.example.sargisn.sargisnahapetyan_comp304_assign3;

import android.graphics.drawable.AnimationDrawable;
import android.graphics.drawable.BitmapDrawable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

public class Task2Activity extends AppCompatActivity {

    AnimationDrawable mframeAnimation = null;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_task2);

        final Button onButton = (Button) findViewById(R.id.ButtonStart);
        onButton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                startAnimation();
            }
        });

        final Button offButton = (Button) findViewById(R.id.ButtonStop);
        offButton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                stopAnimation();
            }
        });
    }

    private void startAnimation()
    {
        ImageView img = (ImageView)findViewById(R.id.ImageView_Seal);

        BitmapDrawable frame1 = (BitmapDrawable)getResources().getDrawable(R.drawable.frame1);
        BitmapDrawable frame2 = (BitmapDrawable)getResources().getDrawable(R.drawable.frame2);
        BitmapDrawable frame3 = (BitmapDrawable)getResources().getDrawable(R.drawable.frame3);
        BitmapDrawable frame4 = (BitmapDrawable)getResources().getDrawable(R.drawable.frame4);
        BitmapDrawable frame5 = (BitmapDrawable)getResources().getDrawable(R.drawable.frame5);
        BitmapDrawable frame6 = (BitmapDrawable)getResources().getDrawable(R.drawable.frame6);
        BitmapDrawable frame7 = (BitmapDrawable)getResources().getDrawable(R.drawable.frame7);
        BitmapDrawable frame8 = (BitmapDrawable)getResources().getDrawable(R.drawable.frame8);
        BitmapDrawable frame9 = (BitmapDrawable)getResources().getDrawable(R.drawable.frame9);
        BitmapDrawable frame10 = (BitmapDrawable)getResources().getDrawable(R.drawable.frame10);

        int reasonableDuration = 250;
        mframeAnimation = new AnimationDrawable();
        mframeAnimation.setOneShot(false);
        mframeAnimation.addFrame(frame1, reasonableDuration);
        mframeAnimation.addFrame(frame2, reasonableDuration);
        mframeAnimation.addFrame(frame3, reasonableDuration);
        mframeAnimation.addFrame(frame4, reasonableDuration);
        mframeAnimation.addFrame(frame5, reasonableDuration);
        mframeAnimation.addFrame(frame6, reasonableDuration);
        mframeAnimation.addFrame(frame7, reasonableDuration);
        mframeAnimation.addFrame(frame8, reasonableDuration);
        mframeAnimation.addFrame(frame9, reasonableDuration);
        mframeAnimation.addFrame(frame10, reasonableDuration);

        img.setBackgroundDrawable(mframeAnimation);

        mframeAnimation.setVisible(true,true);
        mframeAnimation.start();
    }

    private void stopAnimation()
    {
        mframeAnimation.stop();
        mframeAnimation.setVisible(false,false);
    }
}
