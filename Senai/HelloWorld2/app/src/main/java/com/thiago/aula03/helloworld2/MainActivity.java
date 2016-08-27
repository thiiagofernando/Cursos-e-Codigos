package com.thiago.aula03.helloworld2;

import android.graphics.Color;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.TextView;
import android.widget.Toast;

import org.w3c.dom.Text;

public class MainActivity extends AppCompatActivity {

    CheckBox vermelho, verde, azul;
    TextView textSelecionarCor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        vermelho = (CheckBox) findViewById(R.id.ckb_vermelho);
        verde = (CheckBox) findViewById(R.id.ckb_verde);
        azul = (CheckBox) findViewById(R.id.ckb_azul);
        textSelecionarCor = (TextView) findViewById(R.id.textSelecionarCor);

    }

    public void checkBoxOnClick(View v)
    {
        CheckBox selecionado = (CheckBox) v;
        switch (v.getId())
        {
            case  R.id.ckb_vermelho:
                if (selecionado.isChecked())
                {
                    selecionado .setTextColor(Color.RED);
                    //selecionado.setTextColor(Color.parseColor("#FF0000"));
                    textSelecionarCor.setTextColor(Color.RED);
                    Toast.makeText(MainActivity.this, "Checkbox Vermelho Marcado.", Toast.LENGTH_SHORT).show();
                }else{
                    selecionado.setTextColor(Color.BLACK);
                    textSelecionarCor.setTextColor(Color.BLACK);
                    Toast.makeText(MainActivity.this, "Checkbox Vermelho Desmarcado.", Toast.LENGTH_SHORT).show();
                }
                break;

            case  R.id.ckb_verde:
                if (selecionado.isChecked())
                {
                    selecionado.setTextColor(Color.GREEN);
                    textSelecionarCor.setTextColor(Color.GREEN);
                    Toast.makeText(MainActivity.this, "Checkbox Verde Marcado.", Toast.LENGTH_SHORT).show();
                }else{
                    selecionado .setTextColor(Color.BLACK);
                    textSelecionarCor.setTextColor(Color.BLACK);
                    Toast.makeText(MainActivity.this, "Checkbox Verde Desmarcado.", Toast.LENGTH_SHORT).show();
                }
                break;

            case  R.id.ckb_azul:
                if (selecionado.isChecked())
                {
                    selecionado.setTextColor(Color.BLUE);
                    textSelecionarCor.setTextColor(Color.BLUE);
                    Toast.makeText(MainActivity.this, "Checkbox Azul Marcado.", Toast.LENGTH_SHORT).show();
                }else{
                    selecionado.setTextColor(Color.BLACK);
                    textSelecionarCor.setTextColor(Color.BLACK);
                    Toast.makeText(MainActivity.this, "Checkbox Azul Desmarcado.", Toast.LENGTH_SHORT).show();
                }
                break;

        }
    }
}
