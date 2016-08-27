package br.com.senai.myapplication;

import android.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    EditText editText1,editText2;
    Button Button1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        editText1 = (EditText) findViewById(R.id.editText_Valor1);
        editText2 = (EditText) findViewById(R.id.editText_Valor2);
        Button1 = (Button) findViewById(R.id.button_1);

    }
    public void somar(View view){

        double valor1 = Double.parseDouble(editText1.getText().toString());
        double valor2 = Double.parseDouble(editText2.getText().toString());


        double soma = valor1 + valor2;


        AlertDialog.Builder dialog  = new AlertDialog.Builder(MainActivity.this);
        dialog.setTitle("Soma");
        dialog.setMessage("Resultado " + soma);
        dialog.setNeutralButton("OK", null);
        dialog.show();



    }
    public void subtrair(View view){

        double valor1 = Double.parseDouble(editText1.getText().toString());
        double valor2 = Double.parseDouble(editText2.getText().toString());


        double sub = valor1 - valor2;


        AlertDialog.Builder dialog  = new AlertDialog.Builder(MainActivity.this);
        dialog.setTitle("Subtracao");
        dialog.setMessage("Resultado " + sub);
        dialog.setNeutralButton("OK", null);
        dialog.show();



    }
    public void multiplicar(View view){

        double valor1 = Double.parseDouble(editText1.getText().toString());
        double valor2 = Double.parseDouble(editText2.getText().toString());


        double multiplica = valor1 * valor2;


        AlertDialog.Builder dialog  = new AlertDialog.Builder(MainActivity.this);
        dialog.setTitle("Multiplicar");
        dialog.setMessage("Resultado " + multiplica);
        dialog.setNeutralButton("OK", null);
        dialog.show();



    }
    public void dividir(View view){

        double valor1 = Double.parseDouble(editText1.getText().toString());
        double valor2 = Double.parseDouble(editText2.getText().toString());


        double divide = valor1 / valor2;


        AlertDialog.Builder dialog  = new AlertDialog.Builder(MainActivity.this);
        dialog.setTitle("Subtracao");
        dialog.setMessage("Resultado " + divide);
        dialog.setNeutralButton("OK", null);
        dialog.show();



    }


}
