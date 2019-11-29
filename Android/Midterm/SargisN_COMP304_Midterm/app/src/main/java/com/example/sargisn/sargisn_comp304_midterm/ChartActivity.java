package com.example.sargisn.sargisn_comp304_midterm;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ImageView;
import android.widget.TextView;

public class ChartActivity extends AppCompatActivity {

    ImageView imageView;

    Paint paintIBM;
    Paint paintAAPL;
    Bitmap bitmap;
    Canvas canvas;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_chart);

        paintIBM = new Paint();
        paintIBM.setColor(Color.RED);
        paintIBM.setStrokeWidth(5);

        paintAAPL = new Paint();
        paintAAPL.setColor(Color.BLUE);
        paintAAPL.setStrokeWidth(5);

        imageView = (ImageView)findViewById(R.id.imageView);
        int width = (int) getResources().getDimension(R.dimen.image_width);
        int height = (int) getResources().getDimension(R.dimen.image_height);
        //
        //prepare drawing environment
        //create a bitmap as content view for the canvas
        bitmap = Bitmap.createBitmap(width, height, Bitmap.Config.ARGB_8888);
        canvas = new Canvas(bitmap);
        canvas.drawColor(Color.BLACK);
        imageView.setImageBitmap(bitmap);
        imageView.draw(canvas);

        TextView textBoxHeader = (TextView) findViewById(R.id.textView2);

        TextView textBox1 = (TextView) findViewById(R.id.textView3);
        TextView textBox2 = (TextView) findViewById(R.id.textView4);
        TextView textBox3 = (TextView) findViewById(R.id.textView5);
        TextView textBox4 = (TextView) findViewById(R.id.textView6);
        TextView textBox5 = (TextView) findViewById(R.id.textView7);

        String[] stockArray = getResources().getStringArray(R.array.stocks);
        textBox1.setText(stockArray[0]);
        textBox2.setText(stockArray[1]);
        textBox3.setText(stockArray[2]);
        textBox4.setText(stockArray[3]);
        textBox5.setText(stockArray[4]);

        textBoxHeader.setText("Charts:" + (getIntent().getExtras().getString("checkBox1Key"))
                + (getIntent().getExtras().getString("checkBox2Key"))
                + (getIntent().getExtras().getString("checkBox3Key"))
                + (getIntent().getExtras().getString("checkBox4Key"))
                + (getIntent().getExtras().getString("checkBox5Key")));


        String[] stockIBMArray = getResources().getStringArray(R.array.ibmStockValues);
        String[] stockAAPLArray = getResources().getStringArray(R.array.aaplStockValues);

        if ((getIntent().getExtras().getString("checkBox1Key")) !=  null)
        {
            canvas.drawLine(0, Float.parseFloat(stockIBMArray[0]), 100, Float.parseFloat(stockIBMArray[1]), paintIBM);
            canvas.drawLine(100, Float.parseFloat(stockIBMArray[1]), 200, Float.parseFloat(stockIBMArray[2]), paintIBM);
            canvas.drawLine(200, Float.parseFloat(stockIBMArray[2]), 300, Float.parseFloat(stockIBMArray[3]), paintIBM);
            canvas.drawLine(300, Float.parseFloat(stockIBMArray[3]), 400, Float.parseFloat(stockIBMArray[4]), paintIBM);
            canvas.drawLine(400, Float.parseFloat(stockIBMArray[4]), 500, Float.parseFloat(stockIBMArray[5]), paintIBM);
        }
        if ((getIntent().getExtras().getString("checkBox2Key")) !=  null)
        {
            canvas.drawLine(0, Float.parseFloat(stockAAPLArray[0]), 100, Float.parseFloat(stockAAPLArray[1]), paintAAPL);
            canvas.drawLine(100, Float.parseFloat(stockAAPLArray[1]), 200, Float.parseFloat(stockAAPLArray[2]), paintAAPL);
            canvas.drawLine(200, Float.parseFloat(stockAAPLArray[2]), 300, Float.parseFloat(stockAAPLArray[3]), paintAAPL);
            canvas.drawLine(300, Float.parseFloat(stockAAPLArray[3]), 400, Float.parseFloat(stockAAPLArray[4]), paintAAPL);
            canvas.drawLine(400, Float.parseFloat(stockAAPLArray[4]), 500, Float.parseFloat(stockAAPLArray[5]), paintAAPL);
        }
        if ((getIntent().getExtras().getString("checkBox3Key")) !=  null)
        {

        }
        if ((getIntent().getExtras().getString("checkBox4Key")) !=  null)
        {

        }
        if ((getIntent().getExtras().getString("checkBox5Key")) !=  null)
        {

        }



    }
}
