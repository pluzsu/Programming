## Feladat
Adott két számsorozat. HAtározzuk meg a közös elemeiket

### [Specifikáció](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACl1QsW7bMBD9lQdOkkBLUJN0IKAAKZoWRYx0STtY0UBFVEPLpAqLNiwHCZDNa5buGfMD%2FQEhP5IvKU6ynSYDecd779473g1rfqsrXeor6XRtmWBRgJOidg5V9%2BTQrLtH09Tzei0dRpDFdFHBqF%2BQMNoWlXLu%2BSFXFmr2%2FFCGA7%2BupEMQXc4v7SclYF82m3MOM4TVy2YzSeMwtBlvd7nJiHymBYp8oFXa7MAi79EvS4FcWauW0gpMsMIkzTA6xpgTDGAPe0Zzo3Nl%2FeR0%2FLn7c37h6SQOw%2Bu6adbegHCjkz5LdeaTwGkpMKLkRyngFTmvtPGTs28%2Fu%2Fvx968nWwnLX11Wqc5463OKPrqnBiYxiAIYNXeQoNWGUM266v6uca27R9vWs6mEGblhPXSigG4ybN%2FZqTBc8AtP%2B7z0tN8PWeQcLe5AsdKGSsQC7kDD0Zsa6P1%2BTMLKLUalnf9S2v%2B2tPf0t9gbKX9v2PuZwW%2FqbyWTNp32ukHEOHOqcQ0T6Q0rpJNMMCtwRKgROKS4Ekhjjg8cBxxHHB%2F73lYgHUoxx2E2%2FFrggJJKm9eejHFmpVFMMMbZXDWLmWMivs1u%2FwEGh6dx1gIAAA%3D%3D)
```
Be: n∈N, m∈N, x∈Z[1..n],y∈Z[1..m]
Ki: db∈N, kim∈Z[1..db]
Fv: bennevan: Z x Z[] -> L,
    bennevan(mi,miben)=ELDÖNT(i=1..hossz(miben),mi=miben[i])
Ef: -
Uf: (db,kim)=KIVÁLOGAT(i=1..n, bennevan(x[i],y),x[i]) és m=m /* mert a spec. eszköz hiányolja m-t*/
```
### Viszavezetési táblázat
<pre>
(db,y)=KIVÁLOGAT(i=e..u,T(i),f(i))
  db, y ~ db, kim
  e..u  ~ 1..n
  T(i)  ~ bennevan(x[i],y)
  f(i)  ~ x[i]

van=ELDÖNT(i=e..u,T(i))
  van  ~ bennevan()
  e..u ~ 1..m
  T(j) ~ x[i]=y[j]
</pre>

### [Algoritmus](https://progalap.elte.hu/stuki/?data=H4sIAAAAAAAACq1W227iOhT9lZ5d6ajVsVCgLZcc8UJvdETLGcpcWsSDYzvEJbFpEihQ5YPmB%2BYH%2BmMjB2zMlJ4q6vCCWWyvtb329k6egVNwwSk5lXq5XK04lXKjcnJSK9cAQSBnLL6i4IppGCJIWMhIyugGEZKyBNxn6EZk3mnjqlrnhAZAMMExE%2BlmU8ApZQJcH4cJQ5AuJgxcSNjjlAnCAAEJeEhjJq5oAu4ALuSlN6Lfe4CgOkoiOj6dwTBDG1xrWoEbTTuTN5RTnLKIiRQQpGyeggvUc5sOZAh6F%2F3GmN2FRsMAWxoPV%2B1Of1L79qaGkHKi%2BEyg5rN2WnzmnMXdCtr9m5nfD3KLDI%2BWs4iLWPQU8DDXkoLylEsBLvBmuVQSgMCTdHG7zmfbjQzBp8kDXnZ7nsnAAFsZxPWuCNpV510DTaDms3ZafMaF4gZOW505xzdTQNC9bMmz9GySe1nufb9ZfIm7RtkAW8qNVhr9582P3j2JCdR81s4%2FcxKToErf8Gg5i7hIJ3P%2Ftz7wmBBshsXBfMCHaHGoblE8Za0YCxJs9YVVqpxzR4jxIEObQuiMrcoUaZ037jf1%2FikrGVNkM7o08GGZMY8G1Bu6TWWN0qovv5yT7mhhtAywrXX9uSceW%2FT926ADzW3Y7Pzo2H0SyX33a68NCDrRuH%2Fj3ylHHpzk9uL07DjvKROi5a09RY6zwzruNvPq1FqtxvT2fmkkDLAlcfrt%2BvTcZ8fvOmYCNZ%2B10%2BKzTlzUt8sLfLSsPfZzhwyPlrOIizi0cwD%2FHab%2FNgOZJMuDiHtMHO69%2FEj2Iv5XM%2F%2Bpem7HdDYHztAmV52eAYq5u7uAfHXBTMuYZ54GPtwleva4zYPXbhxCliFI0nhKUjmKcaTK8wwCR4rtGnP18JrhmGMvVG8xAAhiKV89EpNAPn3dhK2TUmibYcriNZQhw21GYsTd89HLj2SJ9vKc3P7Lz8gblEslO9F1zPDQ7cgRH2P%2BP3lZLtkZqIm7O9NsqLomlHH%2BnrbybQD7vu84jhpm%2B%2BrbV0N93%2FeJwTznxKz8fFVzjhycrwjDfr0Gw1UZWpiMR7GcCrom9ipeRYWpb03MiMZYjWC98vMVPSYOqyg69Tr5B%2Bms0r9iVZ%2F1mQkh%2BakIIRrzKxpjPiUrrNFY%2Fes4ddI4USvG2DGt2o5k2S%2BizXRHUAsAAA%3D%3D)
![image](https://github.com/user-attachments/assets/806fd204-e4b2-4cce-9895-a370bde2fb8e)


## Variációk
1. Dinamikus lista megoldással
2. Előfeltétel ellenőrzés - bennevan fv. használatával

### Specifikáció
```
Be: x∈Z[1..],y∈Z[1..]
Ki: kim∈Z[1..]
Fv: bennevan: Z x Z[] x N -> L, bennevan(mi,miben,meddig)=ELDÖNT(i=1..meddig,mi=miben[i])
Ef: ∀i∈[1..hossz(x)]:(nem bennevan(x[i],x,i-1)) és
    ∀i∈[1..hossz(y)]:(nem bennevan(y[i],y,i-1))
Uf: (,kim)=KIVÁLOGAT(i=1..hossz(x),bennevan(x[i],y,hossz(y)),x[i])
```
### [Algoritmus](https://progalap.elte.hu/stuki/?data=H4sIAAAAAAAACq1W7W7aMBR9le5WmlrNQoG2fGTiD%2F2iEy0bZZ%2BIH47tEJfEpkmgQJUH2gvsBfpikwM2ZqOroo4%2FmMP1OdfnXt%2FkETgFF5ySU6mXy9WKUyk3KicntXINEARyxuIrCq6YhiGChIWMpIxuECEpS8B9hG5E5p02rqp1TmgABBMcM5FuNgWcUibA9XGYMATpYsLAhYTdT5kgDBCQgIc0ZuKKJuAO4EJeeiP6rQcIqqMkouPTGQwztMG1phW40bQzeUY5xSmLmEgBQcrmKbhAPbfpQIagd9FvjNn30GgYYEvj7qrd6U9qX5%2FVEFJOFJ8J1HzWTovPnLO4W0G7fzPz%2B0FukeHRchZxEYseAh7mWlJQnnIpwAXeLJdKAhB4ki5u1%2Flsu5Eh%2BDC5w8tuzzMZGGArg7jeFUG76rxooAnUfNZOi8%2B4UNzAaasz5%2FhmCgi6ly15lp5Nci%2FLvW83i89x1ygbYEu50Uqjj9786MWTmEDNZ%2B38PycxCar0DY%2BWs4iLdDL3%2F%2BgDjwnBZlgczAd8iBYoOlT3KJ6yVowFCbY6wypWzrojxLiQoU0pdM5WbYo0zzM3nHrvykrGlNkMLw28WmbMowH1hm5TmaO06svP56Q7WhgtA2xrXX%2FqifsWffk%2B6EBzHzY7Xzt4H0Tyo%2Ful1wYEnWjcv%2FG%2FK0funOT24vTsOO8qE6LlrT1FjrPDOu428%2BrUWq3G9PbH0kgYYEvi9Ov16bnPjl90zARqPmunxWeduKhvlxf4aFm77%2BcOGR4tZxEXcWjnCH4bpu%2BbEaOUj%2FaefiZ7EU%2FfNCPuMaHabcdoNmfN0CZNnZkBihm7u3Z8dbdMt5gHngZe3SB68LjNA9uIQ8gyBEkaT0kqRzGOVE0eQeBI8Vxjrp5ZMxxz7IXq5QUAQSzlX0%2FCJJAPXzZh63QU2maYsngNZchwm0kY8dQ9Hz39TJZoL6%2BG23%2F6FXmDcqkUyCRZHuTg4TpmiFaJr38euh054mPM%2F5GmZZedkJq6uxPPhqpzQhnnb2srAwew7%2FuO46iBtq%2B%2BfTXa932fGMxzTszKz1c158jB%2BYow7NdrMFzVo4XJeBTLqaBrYq%2FiVVSY%2BtbEjGiM1QjWKz9f0WPisIqiUy%2BV%2F5HO6oS%2FWNVnfWZCSH4qQojG%2FIrGmE%2FJCms0Vv86Tp00TtSKMXZMq7YjWfYbj4RlqFYLAAA%3D)
![image](https://github.com/user-attachments/assets/178b30a6-4eed-4b8d-a574-8a3b3a9b015c)


