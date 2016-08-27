package com.thiago.aula03.hellointent;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class SalvarActivity extends AppCompatActivity {

    public static final String EXTRA_NOME = "hellointent.EXTRA_NOME";

    TextView salvar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_salvar);
        salvar = (TextView) findViewById(R.id.txtSalvar);
        Intent intent = getIntent();
        if(intent.hasExtra(EXTRA_NOME))
        {
            String nome = intent.getStringExtra(EXTRA_NOME);
            salvar.setText("Olá " + nome);
        }else
        {
            salvar.setText("Nome Não Informado");
        }

    }
}
