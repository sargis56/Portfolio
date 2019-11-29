package com.example.sargisn.sargisnahapetyan_comp304_final;

import android.Manifest;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.support.v4.app.ActivityCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.telephony.SmsManager;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class CheckoutActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_checkout);
        ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.SEND_SMS}, 1);
        ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.RECEIVE_SMS}, 1);
    }

    private BroadcastReceiver intentReceiver = new BroadcastReceiver() {
        //override the onReceive to receive messages
        @Override
        public void onReceive(Context context, Intent intent) {
            //�-display the SMS received in the TextView�-
            TextView SMSes = (TextView) findViewById(R.id.textView21);
            //display the content of the received message in text view
            SMSes.setText("Message Received:"+ intent.getExtras().getString("sms"));
        }
    };

    public void onConfirmOrder (View v) {

        TextView editTextPhoneNumber = (TextView) findViewById(R.id.editText5);

        String phoneNumber = editTextPhoneNumber.getText().toString();

        String SENT = "Message Sent";
        String DELIVERED = "Message Delivered";

        SmsManager sms = SmsManager.getDefault();

        PendingIntent sentPI = PendingIntent.getBroadcast(this, 0, new Intent(SENT),0);
        PendingIntent deliveredPI = PendingIntent.getBroadcast(this, 0, new Intent(DELIVERED),0);

        //this code works for 4.4 or higher versions
        Uri uri = Uri.parse("smsto:" + phoneNumber);
        //Intent it = new Intent(Intent.ACTION_SENDTO, uri);

        //
        Intent i = new
                Intent(android.content.Intent.ACTION_SENDTO,uri);
        //i.putExtra("address", "5556");

        i.putExtra("sms_body", "Thank you for your purchase");
        //i.setType("vnd.android-dir/mms-sms");


        TextView orderTextView = (TextView) findViewById(R.id.textView19);



        if (editTextPhoneNumber.getText().toString().matches("")){
            Toast.makeText(getApplicationContext(), "Cell Number is invalid",  Toast.LENGTH_LONG).show();
        }
        else
        {
            sms.sendTextMessage(phoneNumber, null, "Your order has been confirmed. Your SWAG is being prepared.", sentPI, deliveredPI);
            Toast.makeText(getApplicationContext(), "SMS Sent",  Toast.LENGTH_LONG).show();
            startActivity(i);
            orderTextView.setText("Your order has been confirmed");
        }

    }


}
