## feladat

## Specifikáció
```
Be: n∈N, Adatok=(hely:S x lelekszam:N x resztvevok:N), nevezesek∈Adatok[1..n], 
    Tt=N[1..], kateg∈N[]=[700,1500,3000,8000,25000,70000,200001]
Sa: kategoriak∈Tt[1..7]
Ki: rv∈N[1..7]
Fv: ttul: N x N -> L, ttul(ind,j)={0≤nevezesek[j].lelekszam<kateg[ind], ha ind=1;
                                   kateg[ind-1]≤nevezesek[j].lelekszam<kateg[ind] egyébként}
Fv: kivalogat: N -> N[], 
    kivalogat(ind)=KIVÁLOGAT(j=1..n,ttul(ind,j),nevezesek[j].resztvevok).y
Fv: osszeg: N[] -> N, osszeg(lista)=SZUMMA(j=1..hossz(lista),lista[j])
Ef: (1≤n≤1000) és ∀i∈[1..n]:((1≤nevezesek[i].lelekszam≤200000) és (1≤nevezesek[i].resztvevok≤10000))
Uf: kategoriak=MÁSOL(i=1..7,kivalogat(i)) és
    rv=MÁSOL(i=1..7, osszeg(kategoriak[i]))
```

## Algoritmus
