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
**1. Kimenet:** Azon napok száma, amikor nem érkezett hajó.


Vegyük észre, hogy a napok sorozat előállításához használt _hanyszor_ függvény ugyanazt csinálja, mint az 1. feladat _darab_ függvénye. A különbség a "mivel" történő hasonlításban van. Azaz ez is átadható paraméterként, és akkor egy függvény elég.

![image](https://github.com/user-attachments/assets/b146c973-16cf-4dfd-aab6-277c746f53fe)

