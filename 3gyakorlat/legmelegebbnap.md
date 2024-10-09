## legmelegebb nap ##
n napon mért hőmérsékletek alapján mikor volt a legmelegebb?
**Maximumkiválasztás** - csak az index

**[Specifikáció:](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAAClWOwWrDMAyGX0XolATPWXc0dNBBT2U7DAaDNAenVRqz2C6xOwqlPee6h9qL9EmG4sI2HYTg%2B6RfJwx72pjWbHQ03qHCsgAHTu%2Bh%2B%2F6yEqz58AN8%2Bj6Chp52lnraUdNAUa6HtXsiBe46ji8COm%2Bv4%2FhazaR0NbOVUWC1cdvEraYhssFs2Spwj%2Fc8vrUKsskTk5LPnxfvmZnznbuZ0E3IOm8rU%2BdslwX3zOpjWjj%2B2SApD6LNTD6ZNwWSA5f0y%2B0PFliH37oAJzLgE%2F9AymdUlCgwUogBVXXCrY4aFaJApy2laaBw6COqh3N9%2FgF%2B%2BlXsXwEAAA%3D%3D)**
```
Be: n∈N, hom∈R[1..n]
Ki: maind∈N, maert∈R
Ef: n>0
Uf: (maind,maert)=MAX(i=1..n-1,abs(hom[i])
/*
(maxind,maxert)=MAX(i=e..u,f(i))
maxind, maxert ~ maind, maert
e..u           ~ 1..n
f(i)           ~ hom[i]
*/
```
**Algotitmus**

![image](https://github.com/user-attachments/assets/f9f5de1d-dc7d-4843-b800-29757ebe9ec1)

![image](https://github.com/user-attachments/assets/f5f208c1-2efc-498a-b79b-2dda1fd137eb)

**Kód**
