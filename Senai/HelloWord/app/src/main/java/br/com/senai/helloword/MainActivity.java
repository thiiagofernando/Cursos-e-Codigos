package br.com.senai.helloword;

;
import android.app.Activity;
import android.app.AlertDialog;
import android.os.Bundle;
import android.view.View;
import android.util.Log;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends Activity {

    EditText editText;
    TextView textView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        textView = (TextView) findViewById(R.id.textView);
        editText = (EditText) findViewById(R.id.editTextNome);

    }

    public void acao(View view) {

        String nome = editText.getText().toString();
        textView.setText("Ola " + nome);

        Log.d("Teste", "EditText " + nome);
        Toast.makeText(MainActivity.this, "Ola" + nome, Toast.LENGTH_SHORT).show();

        AlertDialog.Builder dialog  = new AlertDialog.Builder(MainActivity.this);
        dialog.setTitle("Bem Vindo");
        dialog.setMessage("Ola " + nome);
        dialog.setNeutralButton("OK", null);
        dialog.show();


    }
}
