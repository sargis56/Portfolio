package com.example.sargisn.sargisnahapetyan_comp304_assign3;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ListView tasksView = (ListView) findViewById(R.id.taskListView);

        String[] values = new String[] { "Task1", "Task2", "Task3"};
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, values);

        tasksView.setAdapter(adapter);

        tasksView.setOnItemClickListener(
                new AdapterView.OnItemClickListener() {
                    @Override
                    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                        if (position == 0)
                        {
                            goToTask1();
                        }
                        else if (position == 1)
                        {
                            goToTask2();
                        }
                        else if (position == 2)
                        {
                            goToTask3();
                        }
                    }
                }
        );

    }

    public void goToTask1() {

        Intent intent = new Intent(this, Task1Activity.class);
        startActivity(intent);

    }

    public void goToTask2() {

        Intent intent = new Intent(this, Task2Activity.class);
        startActivity(intent);

    }

    public void goToTask3() {

        Intent intent = new Intent(this, Task3Activity.class);
        startActivity(intent);

    }

}
