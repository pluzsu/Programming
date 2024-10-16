feladat:
Tanulókat névsor szerint sorrendbe rendeztük. Adjuk meg azokat a tanulókat, aki magasabb, mint az utána következő.

## [Specifikáció](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACoWRwU6DQBCGX2WyJ6hbWvC2CSaaGGM09dDqBTjslqXZVLam0MamwegN38OLz9E34UnM7JZa1MQDBOaf%2Bf5%2Fd7akeJJTlakpL9VCE0YuJAPd1PWIwiRVfB46Wq7ZGJ4h5zM2cinEy1gDAKC6mDd1bfoi3%2FN0gtqNYpAKi9ByLbFljHIqjH6ZMdBnYQC7z8LAmvpVNXVtCH0%2FYY4lRyrxtFw37x%2Ft%2F4lvKi4O3WcMnFRQ4%2BCGxvj6Yfd2e3d1PnFUaGH0G5Xz2Q9Uzme0Y2XA%2BAx6xxYbN%2Bygpeet6MRRLs0c5ZohLAG8gHXFCupY%2BScAtma%2FWrVco5AKChsUxP4msdgb4JtQUsqiLAiLtiTlJSeMgGYQmO1YEttvqo%2FDDHi7OLNJ8IOuLLpycGpJgoE5jw3wjYwJjwmhRPNcEoZfS1msHkvC%2FIoeIrWJ7DBEZnxr%2FAyAtmYV7UjiIPlBhUpySDM8ShMlfyYYVkn1BeaMeLvaAgAA)
```
Be: n∈N, Tdiak=(nev:S x mag:N), diakok∈Tdiak[1..n]
Ki: db∈N, nevek∈S[1..db]
Ef: n>=2 és ∀i∈[1..n-1]:(diakok[i].nev≤diakok[i+1].nev)
Uf: (db,nevek)=KIVÁLOGAT(i=1..n-1,diakok[i].mag≤diakok[i+1].mag,diakok[i].nev)

/*
Uf: (db,y)=KIVÁLOGAT(i=e..u,T(i),f(i))
e..u  ~ 1..n-1
T(i)  ~ diakok[i].mag≤diakok[i+1].mag
f(i)  ~ diakok[i].nev
db, y ~ db, nevek
*/
```

## [Algoritmus](https://progalap.elte.hu/stuki/?data=H4sIAAAAAAAACq1VUXLaMBC9y%2FIZlRHEBNsz%2BWgmCWUSkpSkmRSGD1lag4ORiWwIlPEBeo%2BerCfpyESyadLJMA0%2Flh%2B7b%2Fe9leQNRAJ8oPW223CdltN2Gw499GgLCEySJaquAF8u4phAijHyDEWJyERgCv4GjmT%2F4co59fS64LMAgTlTKDOdBKsAr2%2F6%2FSfNHQmBEvyQxSkSyNZzBB9kkswhJ2Wg4atklnzbJt5mSvFpgZIjEOCTKBYKZVek4A9h5j26wcXgCggMBtdfe527LoxyUuKmZiVwHw1pxjKcocyAQIarDHwQgX9Mta51wDj%2BOL%2B0NSywU0NmF1MVtx7e9ckGGr5KZoXP6tzfLfW9M3A%2B324tsjymXIV4H4ueJ1Fc1EqkiLIokeBDdNyo1%2BWnBhAIErG%2Bfelo14%2BcQH%2FdEzdnnVKyBXYlnzrz6KLXftdCG2g1lZkVPuvD%2FhbG8%2FT6aMXvgcBKiQ5nq2%2BFm97Yfby8Oz%2BzlS2wUzntPWVdp7t4V4kNNHyVzI9RYhvU7VseU65CvM9ejsK%2FdoKI2DSZDqNRfcbGv3%2F%2BMu8HjQLRx0ot8EQxySc726QyuaLEGyHWkpyUczECKoPaZyf948CL4KBR3GVm5vYuM8B%2Fl5G4xOlQBCP%2FuDRN4hJyvR0yteBZMlZspoe3AclmmgcILJmKWBDru1u%2FqiR5dXDTSfL8BZlAZfvQ0H2ZWaD5SM8uTlTxGdi2NYRaGFJKKRCo6WeoJ1wLQ26xgLbsKixWbXpIWbHiyEK3DaOtyhPGp2OVLKR4IQ6aQVOH6achRm4wbHNmVmGxEg6n2NR0%2Bmv1gXQVf1%2Bx6t%2BLZs55oYpzbrCwaTAMBd9inrf9l1KXe%2FrjW0NERxxVHcnzPxad5Y2uBwAA)

![image](https://github.com/user-attachments/assets/5b589142-3a77-44de-b8ca-cc234f057981)


## Kód
megoldás: kiválogatás -> mekkora lesz a kimeneti tömb? -> használjunk listát

```c#
struct Tdiak {
            public string nev;
            public int mag;
        };
        static void Main(string[] args) {
            //deklar.
            int n=3; 
            //n beolvasása TODO
            /*Tdiak[] diakok=new Tdiak[n];*/
            List<Tdiak> diakok = new List<Tdiak>();

            //beolvas
/* MÓDOSÍTÁS: Bemenet: 1 sorban név;magasság
              Ef: ellenőrzés */
            for (int i=0; i<n; i++) {
                /* diakok[i].nev=Console.ReadLine();
                 int.TryParse(Console.ReadLine(), out diakok[i].mag);*/
                Tdiak sv;
                sv.nev = Console.ReadLine();
                int.TryParse(Console.ReadLine(), out sv.mag);
                diakok.Add(sv);

            }
            int db = 0;
            List<string> nevek=new List<string>();
            for (int i=0; i < diakok.Count -1; i++) {
                if (diakok[i].mag<= diakok[i+1].mag) {
                    db++;
                    nevek.Add(diakok[i].nev);  // diakok.ElementAt(i).nev;
                }
            }
            /*string[] nevek=new string[n];*/
            //kiir
            Console.Write($"{nevek.Count} ilyen van: ");
            for (int i=0; i<db; i++) {
                Console.Write(nevek[i]);
            }
        }
    }

```
