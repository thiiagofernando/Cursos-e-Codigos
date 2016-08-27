package com.thiago.aula03.listanomes;

import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        String[] nomes ={
                "Nome 1", "Nome 1", "Nome 1", "Nome 1",
                "Nome 1", "Nome 1", "Nome 1", "Nome 1",
                "Nome 1", "Nome 1", "Nome 1", "Nome 1",
                "Nome 1", "Nome 1", "Nome 1", "Nome 1"
        };
        List<String> nomeList = new ArrayList<>(Arrays.asList(nomes));
        final ArrayAdapter<String> adapter = new ArrayAdapter<String>(MainActivity.this,
               R.layout.list_item_nome,
                R.id.list_item_nome,
                nomeList);
        ListView listView = (ListView) findViewById(R.id.listView);
        listView.setAdapter(adapter);

        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int position, long id) {

                AlertDialog.Builder dialog = new AlertDialog.Builder(view.getContext());
                dialog.setTitle(adapter.getItem(position));
                dialog.setMessage("Nome na posição" + position);
                dialog.show();
            }

        });


    }
}
