**feladat:** Adott egy egész számokat tartalmazó vektor, és annak egy k indexe úgy, hogy legyenek a vektorban a k-adik előtt is elemek. (A vektor hossza tehát legalább kettő.) Igaz-e, hogy van olyan elem a megadott k index előtt a vektorban, amelyik nagyobb vagy egyenlő a k indextől kezdődő elemek mindegyikénél

## [Specifikáció](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACoWRsW7bMBRFf%2BWCk2XQcpU0C1EHSNEWCJp6ajPE8fAcPSs0ZaqwGENykMzO6E8I0A6eu3UV%2FCP%2BkoK0EyRAiw4Cxfv4zr18vBXld77SY31FThdWKNFt4yQtnANnNThr1uUC5aJ5nBaGHBzNHOVTWjS%2FMGfjiplEsy5B1pIJLQbaplwxmt9ZLXFdZDVyzmq2bEC4nF3aXeOILAimQ6k24Hyzcg66BOc8ZROjdbI3wHVRlguC4%2Bvm0XkW5c3jaATDzm1WcYTTjBYd3nvNyQaTIq%2FJBhoIU84oXGqf7smP8JxFhi6acl5rA0tZXYxGmFOYQs0236x83F2%2F26xyGF6km1W6We0zY%2BprWa1Ns7bNOm93PfE9K9jtctmXqLbL5cUgiWM7lMZLvv5ZK595u1ye%2Be2nuXoyV%2BijwsVg2Dk%2Bk09iS9tUVlHvy2n%2FQ2vSM3EcxtOqIlkNtE2H24ef1WAyjDzs41jBHifhhZJ3Zvvww3r52zhY9s5P%2Bi3dS%2BLYdBL5zJdVFIUO2wunu%2B0XhzmOb%2BTXlo4C3%2B9wjx3BC76Ce7xkedl%2Ffji71P%2BgmDi2O8bEM17dxusaAO4x8f%2FtrpDCcelKoQa3IiVHQgmrcOSrRuHQr5XC4EC%2BlUfyQB4GxpyswpjykoUU%2FrGFEkKKGZc3uRMquZP%2FhSWvYW5283fWm7vh3R9qw5kdXgMAAA%3D%3D)
```
Be: n∈N, x∈Z[1..n],k∈N
Ki: van∈L
Fv: nagyobb: N x Z[]->L, nagyobb(ind,x)=MIND(j=k..hossz(x),x[ind]≥x[j])
Ef: n>1 és 1<k≤n
Uf: van=VAN(i=1..k-1,nagyobb(i,x)) és n=n
```
## Visszavezetési táblázat
```
van=VAN(i=e..u,T(i))
e..u ~ 1..k-1
T(i) ~ nagyobb(i,x)

mind=MIND(i=e..u,T(i))
e..u ~ k..n
T(j) ~ x[ind]≥x[j]
i    ~ j
```
## [Algoritmus](https://progalap.elte.hu/stuki/?data=H4sIAAAAAAAACq1WXXIaORC%2BCtWuSuFarWv4N5PiwU7wGtbrGDs2G1M8aCTNIBgkPDNgWBcHyEHy4AvkAr5JTpKSQELeOClThJfp%2BpC%2B7%2BtWq2cegFPwwTuol6sVr%2BhValWv4NXrgGAgZyxpUfDFNI4RpCxmJGN0gwhJWQr%2BA5zVy8PzqDlUsaazAIIJTpjINpsGnFImwA9xnDIE2WLCwIeU3U2ZIAwQkAGPacJEi6bg9%2BA0%2FHSS3pYqgOBkgs%2FP4vsm9JdogxtNZ%2BFG03XyE%2BUMZ2zMRAYIMjbPwIdjJuMZTvMCzXt9NNqHpaNt5Cyws9wMC79xc3Se10Kz6idy3O68s0IW2L2WzeYHr%2FsX8QDBYtbuHg0uFOuscvWunVbUkU8CPq6VCpe6woK1x%2B3otGSdWGB3J8NDejTtdG8BQWd29KFVaF0AgtHfFxfNUbem5e0SI%2B%2FscSrumHp1xbnfKKhazwv8inUKZ1bCAs8kHIfb5hkey2qyOCnpjCyPkXOIt8nofsBjrSUF5RmXQqX0Js7eNkZ%2FFnKCjXMCRwsZBHmO5vuAIJB0cbX22HqW5xJtLBpXFnjmyinNNnXmf%2BhK25M1IhbY%2BTD19cnb%2FPUlso1u5JzOd%2BScq%2FVquaHfGCmJ68Py9fvFzbmVsMAzidake3s9Lf%2F7Uwkh5UTx2YWGz9np8Dn3dtteFO%2BjzmX3%2Fk73ouUxcg7xNhV6qReH%2BixE7ukxzc17XND%2Bt89f5r1h%2F6VWtGmqiWMc2oljgO1q%2BvKxDVetaMedHbDO%2FNutN8ZcUL%2BRH76JsrdCN6IdqEbMAjuLre%2B431CqsFwiSLNkSjIZJXisDvwBBB6rzf9gLtScxwnHQaxe2QAIEil%2FeGelA3l%2Fs1m29qDQU4YpS8DPkilbIkttB42gfjN6ekz%2FQ7m5%2F%2FHp6zjoFQ4O%2Bmtw3z%2BTER9h%2FgsbTg3%2BL%2FiyMceGfnu%2BQsOZL6%2FU6KvWjmWiv3NWle%2FBXhh6nqeGyZ56hqGKwpBYLPAqNgp1VPNKHtYRYTg8rEF%2FdZDHmIyiRE4FXRMHxaColqmnIWbEYKxGsIlCHdEy8VhR0anPsd9I53TTD6zqt86ZEKKzIoQYLCwajIWUrLB6ffWv5x2SuvpG22OMlWnVrchy%2BR13Yxp%2FjgoAAA%3D%3D)

![image](https://github.com/user-attachments/assets/1439e3cc-8b39-4768-bbc1-d99050fb9188)

**NB:** Az n, x, k globális  

## Kód
```c#

```
