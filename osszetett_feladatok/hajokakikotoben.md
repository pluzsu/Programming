Bíró gyakorló feladat:
# Hajók a kikötőben  
Egy tengeri kikötőbe hajók érkeznek, érkezési időpontjaikat (nap sorszám) ismerjük időrendben. Az érkezéseket M napon át figyelték. Készíts programot, ...

**Bemenet:** A standard bemenet első sorában a hajók száma (1≤N≤1000) és a napok száma (1≤M≤1000) van. A következő N sorban egy-egy hajó érkezésének napja van (1≤Ei≤M).


## Megoldás
**Ötlet:**: Alakítsuk át a bemenetet. Tároljuk le minden napra, hány hajó érkezett aznap.  
Megvalósítása másolással és ebben egy megszámolással.  
Ebből már könnyebben kivitelezhetőek a megoldások az egyes alfeladatokra.

### [Specifikáció](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACk1PzUrDQBB%2BlWVOCYwlmyrCQIQW9aJGUDylOSx1g9u4m7IbBS0FvaXv0YvP0TfJk5TdSAkD8%2FPNzDffbMCt5VJVaila1RggmEtipu%2B6HJkegrS1Two%2BmZhyYRfmThEzYt2cYB3g209ib8J8ue%2FGUn52leOpjFScXc%2BeZvNolXkalLYuVmWmYr94UxHj%2FW5v%2Bt2eJ0nCDn8uAHoM9N2P6rtukEGR73sWVfrBwPNS%2FevKHg6%2Fz4%2F3kfLHNI5UxIDQStc6oGIDr6IVQMAMsUtPwDQxnoZM2ppYMcUpcjxHnmKKF%2BHL4QKxgiPHFL1PRsbDECAYoSUQAIKV7uO9BeLbcnsEGAUigXABAAA%3D)
az általános bemenetre és az átalakításra:
```
Be: n∈N, m∈N, erk∈N[1..n]
Ki: napok∈N[1..m]
Fv: hanyszor:N->N, hanyszor(i)=DARAB(j=1..n,erk[j]=i)
Ef: 1≤n≤1000 és 1≤m≤1000 és ∀i∈[1..n]:(1≤erk[i]≤m)
Uf: napok=MÁSOL(i=1..m,hanyszor(i))
```
a napok később mint Sa valósul meg, hiszen a konkrét feladatoknál nem kell, hogy kimenetként szerepeljen
 ### [Algoritmus](https://progalap.elte.hu/stuki/?data=H4sIAAAAAAAACq1W627aMBh9lemrNK2ahUKgkGTix3qZylZ62drugvjh2A5xm9iQhHZNlQfaC%2BwF%2BmKTAzZmpdVQx59Yh8%2FnnO9iJ%2FfAKQTgNFp%2Bx3GbXtf3XL%2FVabYAQSxvWNanEIhZkiDIWcJIwegSEZKyHIJ7GETO3Xv3ZKrWNZ8BEExwxkSx3BRzSpmAIMJJzhAUdxMGAeRsOmOCMEBAYp7QjIk%2BzSEYgric7bX96AZGFQI87eyLH8W1ETLAy4WOiquDjt%2FfU5l%2FvfbYdbsABEdut3nktZu1vAnR8taepbxt6gkTBS5YyoQSKNjPAgJIeciGI6gQfKf%2BTr8z3TEiBlgRcdLzWdIqLjcW4aOgF2Nxl5cye5PyUCaIbythw6iFLQlL2CrOpiU2mahiGh4tZxFvUszbmCe1lhSUF1wKCID3mo1GLPO8nGe4DQhCSe%2B%2BLKytVrCy2mw6q4GXdxbnMgl6qvZKaRxdTsofBx2jZICXj%2FBxHH7MxmceILgID6V3ODlVPvaPT5Py4FtddROi5a09VqKWqX9OlIZBz1EpnoW7JZ%2Fi5QQbYEXDsrhpolkppCzdSZ2S4dFyFvEmKa0bpKvlIMVPjJFJrkLg5l7%2F%2FGKvb6wYYMWKsb955jcnbIA%2FH17Mm3na%2FfApbyfLZmpgRa7MBvutk%2B9PZy6knCj7JlDzWTv%2Fj31jUNk3PFrOIrbkrOlZL8ejv7oWy2R4NeqlvJ7ObMZ2MyxIvNI2qzM125oQk32FlnXXXg2w4tVi3ejc0PBtU8mYs6plDPDi46nvfCWmpMyLVUsZYEXKepU%2FNzwVgrzIZqSQ4wynqtf3IHCqAgaYC0BwgzOOw0R9MQAgyKR8JJDH8vZyGbbQUeghw5RlC6hChru%2BXOd3fPDq%2FOF3Gg6bjUZwMH74lZej7TXYaxHmk3fP%2BLHueFtZjdF6h5Yd816N1%2FpBKS8W6%2B3F8xkjVpP%2F0chIHYNEZvVH2bztQ9iKIsdxHECwpZ6ROixbUUQMFjo7ZhXVq67TcnC9IgxHXhdG8ynaxeR6nMmZoAvi0A1dFaaempgRjbEuwXoV1SvaJg5zFZ36dvyPdNbsPWJVv0XOhJA6K0KIxiJXYyyiZI75%2Fvxfx%2FGIr%2B6dLcZYm3bsilTVH%2B%2FNMKo8CwAA)

![image](https://github.com/user-attachments/assets/c33516d2-9eb7-4d7f-b4de-e514fe98db91)

## Feladatok
## 1. Kimenet:  Azon napok száma, amikor nem érkezett hajó.
### [Specifikáció](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACk1Qy2rDMBD8lWVPNmyD5fQBCy4ktL20TaGhJ8cHJZap4loJtltoQ6C9Of%2BRS74jf%2BIvKZJNCILV7mhmdtAGq7Va6EwvZK1XBhnHisG0TTMhKLpLlbltYjEYmGRWzsxUMhi5Xp3gwsGPmiGdW8xOD18M79J8Vz%2BrkicXtxM6jZ72o7vR62jsLSNrSqrM42USad8K7zMG0e72pt3tRRAEcDxUDijOgbb51W3TdKHYs%2B%2FWRSeW6Hzesj5l9Hz8m748edouK%2BgshW%2BtLBcAIJ33oXqe08Y6iQIfCWtV1RVyvMFU1hIZwTDcOG3BIELXqTJniIc0JEGXJEIK6cp9TReEIRYkKCRbg7MjOlI6Z7hGQiMLhYxIWKrq86NGFttk%2Bw9evS88qwEAAA%3D%3D)
```
Be: n∈N, m∈N, erk∈N[1..n]
Sa: napok∈N[1..m]
Ki: db∈N
Fv: hanyszor:N->N, hanyszor(i)=DARAB(j=1..n,erk[j]=i)
Ef: 1≤n≤1000 és 1≤m≤1000 és ∀i∈[1..n]:(1≤erk[i]≤m)
Uf: napok=MÁSOL(i=1..m,hanyszor(i)) és
    db=DARAB(i=1..m,napok[i]=0)
```
### Algoritmus  
Vegyük észre, hogy a napok sorozat előállításához használt _hanyszor_ függvény ugyanazt csinálja, mint az 1. feladat _darab_ függvénye. A különbség a "mivel" történő hasonlításban van. Azaz ez is átadható paraméterként, és akkor egy függvény elég.

![image](https://github.com/user-attachments/assets/b146c973-16cf-4dfd-aab6-277c746f53fe)
## 2. kimenet: egy olyan nap (a 2. és az M-1. nap között), amelyen érkezett hajó, az előző és a következő napon pedig nem;
### Specifikáció
```
Be: n∈N, m∈N, erk∈N[1..n]
Sa: napok∈N[1..m]
Ki: db∈N,
    van∈L, ind∈Z
Fv: hanyszor:N->N, hanyszor(i)=DARAB(j=1..n,erk[j]=i)
Fv: t2: N->L, t2(i)=(napok[i]>0 és napok[i-1]=0 és napok[i+1]=0)
Ef: 1≤n≤1000 és 1≤m≤1000 és ∀i∈[1..n]:(1≤erk[i]≤m)
Uf: napok=MÁSOL(i=1..m,hanyszor(i)) és
    db=DARAB(i=1..m,napok[i]=0) és
    (van,ind)=KERES(i=2..m-1,t2(i))
```
### Algoritmus

## 3. kimenet: az M nap alatti leghosszabb időszak hossza, amikor nem érkezett hajó;
### Specifikáció
```
```
### Algoritmus

## 4. kimenet: annak a napnak a sorszáma, amikor a legtöbb hajó érkezett (több megoldás esetén az elsőt);
### Specifikáció
```
```
### Algoritmus


## 5. kimenet: a leghosszabb időszak első és utolsó napja, amikor minden nap érkezett hajó (több megoldás esetén az elsőt)!
### Specifikáció
```
```
### Algoritmus


## Kód
```c#
namespace hajok {
    internal class Program {
        static void beolvas(out int n, out int m, out int[] erk) {
            string sv = Console.ReadLine();
            n = int.Parse(sv.Split()[0]);
            m = int.Parse(sv.Split()[1]);
            erk = new int[n];
            for (int i = 0; i < n; i++) {
                erk[i] = int.Parse(Console.ReadLine());
            }
        }
        static int darab(int[] hol, int mit) {
            int db = 0;
            for(int j = 0; j < hol.Length; j++) {
                if (hol[j] == mit) db++;
            }
            return db;
        }
        static int[] masol(int[] mibol,int m) {
            int[] mibe = new int[m];
            for (int i=0;i<m;i++) {
                mibe[i] = darab(mibol,i+1);
            }
            return mibe;
        }

        static void Main(string[] args) {
            int n, m;
            int[] erk;
            beolvas(out n, out m, out erk);
            int[] napok = masol(erk,m);
            for (int i = 0; i < napok.Length; i++) {
                Console.Error.Write($"{napok[i]} ");
            }
            int db = darab(napok,0);
            Console.WriteLine("#");
            Console.WriteLine(db);
            Console.WriteLine("#");
Console.WriteLine("-1");
            Console.WriteLine("#");

            Console.WriteLine("#");
            Console.WriteLine("#");
        }
    }
}
```
