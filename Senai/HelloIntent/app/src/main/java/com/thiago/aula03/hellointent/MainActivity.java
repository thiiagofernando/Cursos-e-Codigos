package com.thiago.aula03.hellointent;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    EditText nome;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        nome = (EditText) findViewById(R.id.edtNome);
    }

    public void salvar(View v){
        String texto = nome.getText().toString();
        Intent intent = new Intent(this,SalvarActivity.class);
        intent.putExtra(SalvarActivity.EXTRA_NOME, texto);
        startActivity(intent);
    }
}
