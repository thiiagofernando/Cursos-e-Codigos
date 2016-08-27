package com.thiago.aula03.calculadoraspinner;

import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import static android.support.v7.app.AlertDialog.*;

public class MainActivity extends AppCompatActivity {

    Spinner operacao;
    ArrayAdapter<CharSequence> adapter;
    EditText numero1, numero2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        numero1 = (EditText) findViewById(R.id.edtValor1);
        numero2 = (EditText) findViewById(R.id.edtValor2);
        adapter = ArrayAdapter.createFromResource(this,R.array.operacoes,
                android.R.layout.simple_spinner_dropdown_item);

        operacao = (Spinner) findViewById(R.id.spnOperacao);
        operacao.setAdapter(adapter);
    }

    public void calcular(View v)
    {
        int posicao  = operacao.getSelectedItemPosition();
        CharSequence op = adapter.getItem(posicao);
        try {
            float n1 = Float.parseFloat(numero1.getText().toString());
            float n2 = Float.parseFloat(numero2.getText().toString());
            float res = 0;

            switch (op.toString())
            {
                case "Somar":
                    res = n1 + n2;
                    break;
                case "Subtrair":
                    res = n1-n2;
                    break;
                case "Multiplicar":
                    res = n1*n2;
                    break;
                case "Dividir":
                    res = n1/n2;
                    break;
            }
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            dialog.setTitle(op);
            dialog.setMessage(n1 + " e " + n2 + " = " + res);
            dialog.setNeutralButton("OK", null);
            dialog.show();

        }catch (NumberFormatException e)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            dialog.setMessage("Numero Invalido");
            dialog.setNeutralButton("OK", null);
            dialog.show();

        }
    }
}
