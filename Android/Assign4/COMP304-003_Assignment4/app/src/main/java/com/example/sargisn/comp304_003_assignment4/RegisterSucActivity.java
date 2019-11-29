package com.example.sargisn.comp304_003_assignment4;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class RegisterSucActivity extends AppCompatActivity {
//getIntent().getExtras().getString("nameJSKey");
    private TextView textViewUserName;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register_suc);

        final DatabaseManager db = new DatabaseManager(this);

        textViewUserName = (TextView) findViewById(R.id.textView17);

        textViewUserName.setText("ID: " + db.getCell(getIntent().getExtras().getString("userNameJSKey"), "candidatetId", "tbl_candidate", "userName"));
    }
}
