package com.thiago.aula03.calculadora02;

import android.icu.text.NumberFormat;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    EditText num1, num2;
    Button calcular;
    RadioGroup rdOP;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        num1 = (EditText) findViewById(R.id.editNumero1);
        num2 = (EditText) findViewById(R.id.editNumero2);
        rdOP = (RadioGroup) findViewById(R.id.radioOP);
        calcular = (Button) findViewById(R.id.btn_Calcular);
    }

    public void calcular(View v) {
        try {
            float n1 = Float.parseFloat(num1.getText().toString());
            float n2 = Float.parseFloat(num2.getText().toString());
            float resultado = 0;
            RadioButton radio = (RadioButton) findViewById(rdOP.getCheckedRadioButtonId());
            String op = radio.getText().toString();
            switch (rdOP.getCheckedRadioButtonId()) {
                case R.id.radioSomar:
                    resultado = n1 + n2;
                    break;
                case R.id.radioSubtrair:
                    resultado = n1 - n2;
                    break;
                case R.id.radioMultiplicar:
                    resultado = n1 * n2;
                    break;
                case R.id.radioDividir:
                    resultado = n1 / n2;
                    break;
            }

            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            dialog.setTitle("Resultado");
            dialog.setMessage(n1 + op + n2 + " = " + resultado);
            dialog.setNeutralButton("OK", null);
            dialog.show();


        } catch (NumberFormatException e) {
            Toast.makeText(MainActivity.this, "Numero Invalido", Toast.LENGTH_LONG).show();
        }
    }
}