Bíró gyakorló feladat: 
## 46. Sípályák
Magyarországon valahány napon keresztül megmértük valahány sípálya hóvastagságát.
Készíts programot, amely megoldja az alábbi feladatokat!
1. Adj meg egy sípályát az első napon, amelyen több, mint 50 cm-es a hó (itt nem kell hóágyúzni). Ha nem lenne ilyen, akkor írd ki a -1 számot! Ha több ilyen lenne, akkor a bemenetben való előfordulásuk sorrendjében az elsőt add meg!
2. Add meg, hogy az első sípályán melyik napon van 50 cm alatti legvastagabb hóréteg! Ha
több ilyen lenne, akkor a bemenetben való előfordulásuk sorrendjében az elsőt add meg!
Ha nem lenne ilyen, akkor írd ki a -1 számot!
3. Melyek azok a napok, amikor minden sípályán volt hó? Ha nem volt ilyen nap, akkor írd ki
a 0 számot! A kimenet a bemenetben való előfordulásuk sorrendjében tartalmazza a sípályákat!
4. Sípályánként add meg, hogy hány alkalommal nőtt a hó vastagsága egyik napról a másikra!
Az adatokat a bemenetben való előfordulásuk sorrendjében kell kiírnod.

**Bemenet**: A standard bemenet első sora a napok számát (2≤napdb≤1000) és a pályák számát (1≤pályadb≤1000) tartalmazza. A másodiktól az napdb+1. sorig a hóvastagság-mérések adatait tároljuk (min. 0, max. 100).

## [Specifikáció](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACn1S22rbQBD9lWGfpDB2tLJd6FIZHOKU4EsgSUupood1JNO1vStjKaFtCCRvyl%2B0kJd%2Bh%2F9EX1J2JDkOKRUSmtGZOWf2jO5Ytk6u1Vxdy1ylhgl2lAgwZVFMEXT1%2BpYukpUNQ95uG%2BTtto7g8ABMYOQ6XSLoIGuv5eqHXEL2c%2Ftby4PDq82VGSkBt9LwsijGCMrENvqKFgIAC%2FkVpOV3ZWKfUGjgeFapL5VutONZ9IKTYFUU0kgWOLkVoFMB01bf8qaOcoPJ6fTYWQS2BukoocJFVD798tymJZYbOTPprYAptPpT3H1wlInd4HhwPjhyVODb4zcUysRRv05anFLiG84FlMWDKouC%2FIqEUxYPizrVkXC88ul5f5Bn7nku9X6aC3CsZZaOu8FoeD68cNT%2B7BxV1O95Lmz%2FZDsv6HJMoslvaPXJ7aDFqaypssw%2B1majG5wMx5eTwZeK%2F%2BVgPNoLP%2FxXyrdSNeEbtXiGS6XdYHT6efs4Pvs4uGyUaC%2BoXpXX6wwm28eLs3Gzr90eFq4LDFmeZHnGRHjHYplLJhgYAV3i0AJ6FNDwAsLQ99FHD995%2BD7CV%2FOHvR520MPePyDuYxe7nr3fYF3s2R5qo%2F%2BN%2FBaQb24SSq3tzUDWnz2otkkApzSeCfApWiotIOxgt2KsjRAQcuygjxw9AuzDkBmpEyYYQ7ZJsptVzgS%2Fj%2B7%2FAk4A3cDHAwAA)
```
Be: n∈N, m∈N, hojel∈N[1..n,1..m] /* n=napok, m=s.palyak száma*/
Ki: van1∈L, ind1∈Z,
    van2∈L, maxind2∈Z, 
    db∈N, kim∈N[1..db], 
    palyadb∈N[1..m]
Fv: mo: N->L, mo(i)=MIND(j=1..m,hojel[i,j]≠0)
Fv: darabnov: N ->N, darabnov(ind)=DARAB(i=2..n,hojel[i,ind]>hojel[i-1,ind])
Ef: ∀i∈[1..n]:(∀j∈[1..m]:(0≤hojel[i,j]≤100))
Uf: (van1,ind1)=KERES(i=1..m,hojel[1,i]>50) és (nem van1 -> ind1=-1) és
    (van2,maxind2,)=FELTMAX(i=1..n,hojel[i,1],hojel[i,1]<50) és (nem van2 -> maxind2=-1) és
    (db,kim)=KIVÁLOGAT(i=1..n,mo(i),i) és
    palyadb=MÁSOL(j=1..m,darabnov(j)) 
```
## [Algoritmus]()

## Kód
### 1. verzió: globális deklaráció 
- a fv-ekhez "megússzuk" a paraméterátadás problémáját
```c#
namespace sipalyak {
    internal class Program {
/* globálisan deklaráljuk a főbb elemeket */
        static int[,] hoh;
        static int palyadb;
        static int napdb;
/* beolvas fv. - adatok beolvasása */
        static void beolvas() {
            string[] sv = Console.ReadLine().Split();
            napdb = int.Parse(sv[0]);
            palyadb = int.Parse(sv[1]);
            hoh = new int[napdb, palyadb];
            for(int i = 0; i < napdb; i++) {
                string[] sv1 = Console.ReadLine().Split(' ');
                for (int j=0; j < palyadb; j++) {
                    hoh[i, j] = int.Parse(sv1[j]);
                }
            }
        }
/* 1. feladat, keresés megoldása */
        static (bool, int) keres() {
            int ind = -1;
            bool van = false;
            int i = 0;
            while (i< palyadb && hoh[0, i]<=50) {
                i++;
            }
            van=(i<palyadb);
            if (van) { ind=i+1; }

            return (van, ind);
        }
/* fő program bíró-megfelelő kimenettel */
        static void Main(string[] args) {
            beolvas();
            int ind1;
            bool van1;
            (van1, ind1) = keres();
            // kiirás
            Console.WriteLine("#");
            Console.WriteLine(ind1);
            Console.WriteLine("#");
            Console.WriteLine("#");
            Console.WriteLine("#");
          }
    }
}
```
### 2. verzió: paraméterek átadásával
```c#
```
