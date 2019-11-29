package com.example.sargisn.sargisnahapetyan_comp304_assign2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class CheckoutActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_checkout);

        TextView cuisineTextView = (TextView) findViewById(R.id.textView4);
        TextView restTextView = (TextView) findViewById(R.id.textView13);
        TextView orderIDeTextView = (TextView) findViewById(R.id.textView17);
        TextView nameTextView = (TextView) findViewById(R.id.textView15);
        TextView addressTextView = (TextView) findViewById(R.id.textView16);

        TextView orderItemsTextView = (TextView) findViewById(R.id.textView18);

        TextView totalTextView = (TextView) findViewById(R.id.textView19);

        cuisineTextView.setText("Cuisine: " + (getIntent().getExtras().getString("radioCuisineKey_Checkout")));
        restTextView.setText("Restaurant: " + (getIntent().getExtras().getString("restKey_Checkout")));
        orderIDeTextView.setText("Order ID: " + (getIntent().getExtras().getDouble("orderIDKey")));
        nameTextView.setText("Name: " + (getIntent().getExtras().getString("nameKey")));
        addressTextView.setText("Address: " + (getIntent().getExtras().getString("addressKey")));

        orderItemsTextView.setText("Order Items: \n(" + (getIntent().getExtras().getString("checkBox1Key_Checkout")) + ")  \n("
                + (getIntent().getExtras().getString("checkBox2Key_Checkout")) + ")  \n("
                + (getIntent().getExtras().getString("checkBox3Key_Checkout")) + ")");

        Integer order1 = getIntent().getIntExtra("textVPrice1Key_Checkout", 0);
        Integer order2 = getIntent().getIntExtra("textVPrice2Key_Checkout", 0);
        Integer order3 = getIntent().getIntExtra("textVPrice3Key_Checkout", 0);
        Integer totalOrder = order1 + order2 + order3;
        totalTextView.setText("Total : $" + totalOrder);
    }

    public void onClickOrder(View view) {
        Toast.makeText(this, "Your order has been confirmed", Toast.LENGTH_LONG).show();

        TextView orderTextView = (TextView) findViewById(R.id.textView3);

        orderTextView.setText("Your order has been confirmed");
    }

    public void goBack(View view) {
        Intent intent = new Intent(this, CuisinesActivity.class);
        startActivity(intent);
    }
}
