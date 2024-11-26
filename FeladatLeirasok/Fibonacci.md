## Keresés Rendezés
#ASCDFIB – Növekvő Fibonacci-számok



John megpróbálja megtanulni a Fibonacci sorozatot. Ezt tanulta eddig. A sorozat első két tagja: f(1) = 0 és f(2) = 1. A következő f(n) tagot ezután az előző két f(n-1) és f(n-2) tag összeadásával számítjuk ki.  Ezért,

f(1) = 0

f(2) = 1

f(3) = f(2) + f(1) = 1 + 0 = 1

f(4) = f(3) + f(2) = 1 + 1 = 2

f(5) = f(4) + f(3) = 2 + 1 = 3

f(6) = f(5) + f(4) = 3 + 2 = 5

Miután ezt egy ideig számolgatta, John rájött, hogy az értékek túl nagyokká válnak. Annak érdekében, hogy az értékek alacsonyak legyenek, John megváltoztatta az algoritmusát. Az f(n) = f(n-1)+f(n-2) kiszámítása helyett úgy döntött, hogy f(n) = ( f(n-1)+f(n-2) ) % 10^ 5.

Most John kutatni akar az új módosított Fibonacci-szekvenciáján. Ad egy A (A<=10^5) és egy B egész számot (B<=10^6). Az összes kifejezést f(A)-tól f(A+B)-ig növekvő sorrendben (nem csökkenő sorrendben) kell kiadnia. De ennyi szám nyomtatása túl sok gondot okoz. Tehát, ha 100-nál több kifejezés van a kimenetben, akkor csak az első 100-at nyomtassa ki.

### Bemenet
Az első sor egy T egész számot tartalmaz ( T <=100), ami a tesztesetek száma.
Minden teszteset két pozitív A és B egész számot tartalmaz , amint azt korábban említettük.

### Kimenet
Minden tesztesethez nyomtassa ki az esetszámot (Ellenőrizze a minta kimenetét), majd nyomtassa ki a kifejezéseket f(A)-tól f(A+B)-ig növekvő sorrendben (nem csökkenő sorrendben). Ha több mint 100 kifejezés van a kimenetben, akkor csak az első 100-at nyomtassa ki.

### Példa

Bemenet:
3       <br>
1 3     <br>
3 3     <br>
100 1   <br>

Kimenet:
1. eset: 0 1 1 2
2. eset: 1 2 3 5
3. eset: 15075 69026




https://www.spoj.com/problems/ASCDFIB/
