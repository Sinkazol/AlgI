# ACODE – Alfakód
### dinamikus programozás
https://www.spoj.com/problems/ACODE/

## Feledat
Alice-nek és Bobnak titkos üzeneteket kell küldeniük egymásnak, és az üzeneteik kódolásának módjait tárgyalják:<br>

Alice: „Használjunk egy nagyon egyszerű kódot: 'A'-hoz rendeljük az 1-es kódszót, a 'B'-hez 2 lesz, és így tovább egészen a 'Z'-hez 26-ig.

Bob: „Ez egy hülye kód, Alice. Tegyük fel, hogy elküldöm neked a 'BEAN' szót 25114 kóddal. Ezt sokféleképpen dekódolhatod!

Alice: „Persze, hogy megtehetné, de milyen szavakat kapna? A „BEAN”-on kívül a „BEAAD”, „YAAD”, „YAN”, „YKD” és „BEKD” kifejezéseket kapja. Szerintem kitalálnád a helyes dekódolást. És egyáltalán miért küldenéd nekem a „BEAN” szót?”

Bob: "Rendben, ez talán rossz példa, de lefogadom, hogy ha egy 5000 hosszúságú karakterláncot kapna, rengeteg különböző dekódolás lenne, és ennyivel legalább két különbözőt találna, aminek értelme lenne."

Alice: "Hány különböző dekódolás?"

Bob: „Jilliók!”

Valamiért Alice-t még mindig nem győzi meg Bob érvelése, ezért szüksége van egy olyan programra, amely meghatározza, hogy a kódja segítségével hány dekódolás lehetséges egy adott karakterlánchoz.

## Bemenet
A bemenet több bemeneti készletből áll. Mindegyik készlet egy, legfeljebb 5000 számjegyből álló sorból áll, amely érvényes titkosítást jelent (például egy sor sem kezdődik 0-val). A számjegyek között nem lesz szóköz. A '0' bemeneti sor befejezi a bevitelt, és nem szabad feldolgozni.

## Kimenet
Minden bemeneti készlethez adja ki a lehetséges dekódolások számát a bemeneti karakterlánchoz. Minden válasz egy 64 bites előjelű egész tartományon belül lesz.

## Példa
Bemenet:
25114<br>
1111111111<br>
3333333333<br>
0<br>

## Kimenet:
6<br>
89<br>
1<br>
