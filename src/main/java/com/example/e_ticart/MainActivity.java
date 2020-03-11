package com.example.e_ticart;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.FragmentTransaction;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.google.firebase.database.ChildEventListener;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        final EditText Isim = findViewById(R.id.isim);
        final EditText Soyisim = findViewById(R.id.soyisim);
        final EditText kullaniciAdi = findViewById(R.id.kadi);
        final EditText Sifre = findViewById(R.id.sifre);
        final EditText ePosta = findViewById(R.id.eposta);
        final EditText Adres = findViewById(R.id.adres);

        findViewById(R.id.kaydet).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String isimStr = Isim.getText().toString();
                String soyisimStr = Soyisim.getText().toString();
                String kullaniciAdiStr = kullaniciAdi.getText().toString();
                String sifreStr = Sifre.getText().toString();
                String epostaStr = ePosta.getText().toString();
                String adresStr = Adres.getText().toString();


                FirebaseDatabase firebaseDatabase = FirebaseDatabase.getInstance();
                DatabaseReference userReference = firebaseDatabase.getReference("user");

                user user = new user(isimStr,soyisimStr,kullaniciAdiStr,sifreStr,epostaStr,adresStr );
                userReference.child(isimStr).setValue(user);
            }
        });

        FirebaseDatabase firebaseDatabase = FirebaseDatabase.getInstance();
        DatabaseReference userReference = firebaseDatabase.getReference("user");

        userReference.addChildEventListener(new ChildEventListener() {
            @Override
            public void onChildAdded(@NonNull DataSnapshot dataSnapshot, @Nullable String s) {
                user user = dataSnapshot.getValue(user.class);
            }

            @Override
            public void onChildChanged(@NonNull DataSnapshot dataSnapshot, @Nullable String s) {

            }

            @Override
            public void onChildRemoved(@NonNull DataSnapshot dataSnapshot) {

            }

            @Override
            public void onChildMoved(@NonNull DataSnapshot dataSnapshot, @Nullable String s) {

            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {

            }
        });

            fragregister register = new fragregister();
        FragmentTransaction transaction =
                getSupportFragmentManager().beginTransaction();
        transaction.replace(R.id.frame,register);

        //transaction.addToBackStack(null); // geri ye basınca referensı kaybetmiyoruz tekrar sayfa 1 i açacak.
        transaction.commit();

        findViewById(R.id.kayıt).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                fragregister register = new fragregister();
                FragmentTransaction transaction =
                        getSupportFragmentManager().beginTransaction();
                transaction.replace(R.id.frame,register);
                transaction.addToBackStack(null);
                transaction.commit();

                ((Button) findViewById(R.id.kayıt)).setText("Onayla");
            }
        });

    }
}
