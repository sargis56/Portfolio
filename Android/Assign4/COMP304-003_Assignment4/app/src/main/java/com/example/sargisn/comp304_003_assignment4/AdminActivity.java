package com.example.sargisn.comp304_003_assignment4;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class AdminActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_admin);

        final DatabaseManager db = new DatabaseManager(this);
        final TextView display = (TextView) findViewById(R.id.textView20);

        List table = db.getTable("tbl_candidate");

        for (Object o : table) {
            ArrayList row = (ArrayList)o;
            // Writing table to log
            String output="Job Seekers:\n";
            for (int i=0;i<row.size();i++)
            {
                output+= row.get(i).toString() + " ";
                output+="\n";
            }
            display.setText(output + "");

        }
    }
}
