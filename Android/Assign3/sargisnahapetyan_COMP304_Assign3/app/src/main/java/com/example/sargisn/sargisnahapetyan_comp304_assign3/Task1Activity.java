package com.example.sargisn.sargisnahapetyan_comp304_assign3;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.KeyEvent;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class Task1Activity extends AppCompatActivity {

    ImageView reusableImageView;
    TextView textViewY;
    TextView textViewX;

    int startx = 10;
    int starty = 10;
    int endx=10;
    int endy=10;

    Paint paint;
    Bitmap bitmap;
    Canvas canvas;
    Spinner spinnerThick;

    Handler mHandler = new Handler();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_task1);

        paint = new Paint();
        paint.setColor(Color.RED);
        paint.setStrokeWidth(10);

        bitmap = Bitmap.createBitmap((int) getWindowManager()
                .getDefaultDisplay().getWidth(), (int) getWindowManager()
                .getDefaultDisplay().getHeight(), Bitmap.Config.ARGB_8888);
        canvas = new Canvas(bitmap);
        canvas.drawColor(Color.BLACK);

        reusableImageView = (ImageView)findViewById(R.id.ImageViewForDrawing);
        reusableImageView.setImageBitmap(bitmap);

        textViewX = (TextView) findViewById(R.id.textViewX);
        textViewY = (TextView) findViewById(R.id.textViewY);

        spinnerThick = (Spinner) findViewById(R.id.spinner4);

        List<String> thickness = new ArrayList<String>();
        thickness.add("10");
        thickness.add("20");
        thickness.add("30");
        thickness.add("40");
        thickness.add("50");

        ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_item, thickness);
        spinnerThick.setAdapter(dataAdapter);
    }

    public void clearCanvas(View v)
    {
        canvas.drawColor(Color.BLACK);
        startx = 10;
        starty = 10;
        endx=10;
        endy=10;
        textViewY.setText(String.valueOf(10));
        textViewX.setText(String.valueOf(10));
        final RadioButton radio1 = (RadioButton)findViewById(R.id.radioButtonRed);
        radio1.setChecked(true);
        spinnerThick.setSelection(0);
    }

    public void moveRect(Canvas canvas)
    {
        reusableImageView.setTranslationX(endx - startx);
        reusableImageView.setTranslationY(endy - starty);
        reusableImageView.setColorFilter(Color.GREEN);
    }

    public void drawLine(Canvas canvas)
    {
        textViewY.setText(String.valueOf(endy));
        textViewX.setText(String.valueOf(endx));

        canvas.drawLine(startx, starty, endx, endy, paint);
        startx=endx;
        starty=endy;
        final RadioGroup group= (RadioGroup) findViewById(R.id.RadioGroupColors);
        int id = group.getCheckedRadioButtonId();
        switch (id) {
            case R.id.radioButtonRed:
                paint.setColor(Color.RED);
                break;
            case R.id.radioButtonGreen:
                paint.setColor(Color.GREEN);
                break;
            case R.id.radioButtonYellow:
                paint.setColor(Color.YELLOW);
                break;
        }

        String textThink = spinnerThick.getSelectedItem().toString();
        int thickness = Integer.parseInt(textThink);
        paint.setStrokeWidth(thickness);
    }

    public void drawLineDown(View v)
    {
        reusableImageView.setFocusable(true);
        reusableImageView.requestFocus();
        endy=endy+5;
        drawLine(canvas);
        reusableImageView.invalidate();
    }
    public void drawLineUp(View v)
    {
        reusableImageView.setFocusable(true);
        reusableImageView.requestFocus();
        endy=endy-5;
        drawLine(canvas);
        reusableImageView.invalidate();
    }
    public void drawLineRight(View v)
    {
        reusableImageView.setFocusable(true);
        reusableImageView.requestFocus();
        endx=endx+5;
        drawLine(canvas);
        reusableImageView.invalidate();
    }
    public void drawLineLeft(View v)
    {
        reusableImageView.setFocusable(true);
        reusableImageView.requestFocus();
        endx=endx-5;
        drawLine(canvas);
        reusableImageView.invalidate();
    }

    public boolean onKeyDown(int keyCode, KeyEvent event)
    {
        switch(keyCode)
        {
            case KeyEvent.KEYCODE_DPAD_DOWN:
                //reusableImageView.setVisibility(View.VISIBLE);
                //reusableImageView.setFocusable(true);
                //reusableImageView.requestFocus();
                endy=endy+5;
                drawLine(canvas);
                //moveRect(canvas);
                //reusableImageView.invalidate();

                return true;

            case KeyEvent.KEYCODE_DPAD_UP:
                //reusableImageView.setVisibility(View.VISIBLE);
                reusableImageView.setFocusable(true);
                reusableImageView.requestFocus();
                endy=endy-5;
                drawLine(canvas);
                //moveRect(canvas);
                reusableImageView.invalidate();

                return true;
            case KeyEvent.KEYCODE_DPAD_RIGHT:
                //reusableImageView.setVisibility(View.VISIBLE);
                reusableImageView.setFocusable(true);
                reusableImageView.requestFocus();
                endx=endx+5;
                drawLine(canvas);
                //moveRect(canvas);
                reusableImageView.invalidate();

                return true;
            case KeyEvent.KEYCODE_DPAD_LEFT:
                //reusableImageView.setVisibility(View.VISIBLE);
                reusableImageView.setFocusable(true);
                reusableImageView.requestFocus();
                endx=endx-5;
                drawLine(canvas);
                //moveRect(canvas);
                reusableImageView.invalidate();

                return true;
        }
        return false;
    }

}
