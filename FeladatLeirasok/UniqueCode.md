# BLUNIQ - Egyedi kód
### fa

Lapak városában minden turista egyedi kódot kap a kedvenc száma alapján. Ha a kedvenc számát már egyedi kódként használják, akkor az adott turista a legkisebb fel nem használt egyedi kódot kapja, amely nagyobb, mint a kedvenc szám. Például egy turista, akinek 42 a kedvenc száma, Lapak városába látogat. A 42-es egyedi kód azonban már használatban van. Tehát az a turista a 43-as egyedi kódot kapja. Ha a 43-at is használjuk, akkor az a turista a 44-es egyedi kódot, stb.

Minden turista, aki elhagyja Lapak városát, törli az egyedi kódját, ami azt jelenti, hogy a kódja szükség esetén más újonnan érkezők számára is használható. Folytatva az előző példát, ha a 43-as egyedi kódú turista elhagyta Lapak városát, és egy 43-as kedvenc számmal rendelkező turista lép be, az új turista a 43-as egyedi kódot kapja.

Kezdetben az összes kód használaton kívül van, és nincs turista Lapak városában. Egy napon N turisztikai esemény van Lapak városában. Segíts Lapak városának egyedi kód meghatározásában a turista számára.

## Bemenet
A bemenet első sora N, az esemény száma (1 <  N <  100000). A következő N sor tartalmazza az eseményeket. Minden Lapak városba látogató turista esetében a bemenet "1 x", ahol x az adott turista kedvenc száma (1 <  x <  1 000 000 000). Minden Lapak várost elhagyó turista esetében a bevitel „2 x”, ahol az x az adott turista egyedi kódja.

## Kimenet
Minden látogató turista esetében adja meg egyedi kódját.

## Példa
### Bemenet: 
5           <br>  
1 42    <br>
1 42    <br>
1 43    <br>
2 43    <br>
1 42    <br>
### Kimenet: 
42       <br> 
43       <br>
44       <br>
43       <br>