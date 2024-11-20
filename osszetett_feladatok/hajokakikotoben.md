# Hajók a kikötőben  
Egy tengeri kikötőbe hajók érkeznek, érkezési időpontjaikat (nap sorszám) ismerjük időrendben. Az érkezéseket M napon át figyelték. Készíts programot, amely megadja azon napok számát, amikor nem érkezett hajó.
**Bemenet:** A standard bemenet első sorában a hajók száma (1≤N≤1000) és a napok száma (1≤M≤1000) van. A következő N sorban egy-egy hajó érkezésének napja van (1≤Ei≤M).
**1. Kimenet:** Azon napok száma, amikor nem érkezett hajó.

## Megoldás
**Ötlet:**: Alakítsuk át a bemenetet. Tároljuk le minden napra, hány hajó érkezett aznap.  
Megvalósítása másolással és ebben egy megszámolással.  
Ebből már könnyebben kivitelezhetőek a megoldások az egyes alfeladatokra.

### [Specifikáció]()
az általános bemenetre és az átalakításra:
```
Be: n∈N, m∈N, erk∈N[1..n]
Sa: napok∈N[1..m]
Ki: ...
Fv: hanyszor:N->N, hanyszor(i)=DARAB(j=1..n,erk[j]=i)
Ef: 1≤n≤1000 és 1≤m≤1000 és ∀i∈[1..n]:(1≤erk[i]≤m)
Uf: napok=MÁSOL(i=1..m,hanyszor(i)) 
```
