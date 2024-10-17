Keressünk ikerprímeket egy kezdetével (k) és végével (v) megadott intervallumban

## [Specifikáció](https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACnWQTW7CMBCFrzLyKgYTlNB2MVKQWpVKFTSL%2Fm1KFwYcyQm4KAlWJH7WXKXn6E04STUOAVUqWThvPM%2FfPM2aFUs11YmeylJ%2FGYbsTiFkh%2F0%2BFmDpN87HZqgRrDSH%2FX4kQNbNSdN8sAjLXC8w7vRHwkmv4pFRC3i%2Fjb00Cn2%2F6gQi3VSc%2FN0WPD3G9%2BcGkNWjNm91yTFIEGw%2Fawf9kMq3BMGz0gjJo%2BHgefDi6SjzfdsJj9M0h5%2Fv4qjbIXclvQQAmESy7TD1bDodTJvZGad8fyVePc1dQhLgvh3oTOUEvjCK7EQDbWZkd1rSLSEbSJ22CWGlif7djJWG3LSO4xZPoB3U3jpeymEH6aaiqtVlgpWqKAuGH2s2k6VkyCBDcAPBIlzXQhqEMl8pV0mEnhMThGsmmJELxZAxwXJVrOYlw2Ar%2FuCCXsMLbs7ARM6LEzFsiFcXiJ%2FbXyjAOgVxAgAA)
```
Be: k∈N, v∈N
Ki: van∈L, a∈N, b∈N
Fv: prim:N->L, prim(x)=nem VAN(j=2..x-1,j|x)
/* MIND(j=2..x-1, nem (j|x))*/
Ef: v>k+1>2
Uf: (van,a)=KERES(i=k..v-2, prim(i) és prim(i+2)) és
    b=a+2

/*
(van,ind)=KERES(i=e..u,T(i))
T(i)      ~ ikerprim, prim(i) és prim(i+2)
van, ind  ~ van, a
e..u      ~ k..v-2

van=VAN(j=2..x-1,j|x)
van  ~ nem prim(x)
e..u ~ 2..x-1
T(j) ~ j|x
*/
```

## [Algoritmus](https://progalap.elte.hu/stuki/?data=H4sIAAAAAAAACq1W227bOBD9lWACFDbKLGQ5vqnwQ%2BPm4t20zbZNu4siDzQ1kllJpCPRjpOsPqjf0R8rKIcU3bobCKlfTBwPzzlz8Uj3wEMIwPvD7%2Fn9fq83HPq9waB%2FOOwDgblcYT4NIRDLNCVQYIpMYVgjQoZYQHAPs9Hb0Vu5%2FlufK0ILEFjQHIWqL815GKKAIKJpgQTU7QIhgAKvlygYAgE252mYo5iGBQSfYTId8en1XBsanvL005E4BgLJy0J0P2QKCAwmyUkopghXJamjjRPneu3E9fcLP4oqzFBoAYVrBQHQYJxASeDTRCXqzr%2B0EhbYknDMNk056Z6w60T6VUaWx8g5xE0yupnztNKSIuSKS6FTepaqF%2BPW6sBv7337WuwJzPZai5xnLboBNufnfrsNBGYyvH3%2FYHq6lXhJas%2FGpgW2bDq1alJ4%2BrxTiZiuW5F6DJ7Y3RUVwbjlFKStBTP554Sq5MwKWmBLUPmd6y8xk78UFFIuNJ8NNHzOTYfPjnTz2aEnpxE9X51Vs%2FOa8u4r77RuigW25LrnqyyLp%2FNH7dtAw%2Bfc%2FD32rUFt3%2FIYOYe4Sbt59MPcr6jQnc%2BXeJRTweZbU%2B20pKLZEWLTLkldcGPSAs1GZMdMzvTg%2B1rkNf4zu7x4360baYAtkQteeMuTzsdHG2kDDZ9z86kLO73NuueDi3%2BBgJ8N3i0XxY3e0vwNi9%2FJSdVYG2LknTtN0tlRMx6Mq4rl8SkuXh7%2BZSUssCVxfDS8e%2FUmWTxaMRto%2BJybDp%2BTcdO6nV3irTrOvlQVsjxGziFuUqFdW59XS2590Kl3Pv9vvXPD2yRLUvszlizQrKK7m8Y3G96Oif3LG%2BDJk6GfZcG4xZ%2FF6sX6oNOGsiRQqHzJlIxzmukm3IOgGW4WpV4RK5pzOkv1Ww4AgVzKn1ZOMZc3H%2BuwBxsaPUMaYg6B3jMlsdTVM3UdHMffvhZ37eBcxjyh%2FH%2FEnGR%2FpN0tX17phqcyr17ONul%2Fhv0o8jzPAwL7%2BjvSS3E%2FipjFZl7PnqLqNPC6Hq1ODGk0HMDVpppHlCVxLpcifCCe%2BTP9TNnX34YYmcFwwKg5RdUpPGQe%2BppOv0P%2BRjqnnz%2Bx6s9DzoyxKivGmMEi32AYhWyDjUabXz1vyEY9fULEw7DvVqQsvwO4GrsnRQsAAA%3D%3D)
![image](https://github.com/user-attachments/assets/ede95bda-54b3-427a-ac4d-b76e1b68a7b6)
![image](https://github.com/user-attachments/assets/d5350bea-c88c-4b44-9433-b429817cc61a)


## Kód


```c#
   static bool prim(int x) {
      int i = 2;
       while(i<=(x-1) && (x % i !=0)) { i++; }
       return (i>(x-1));
    }
     static void Main(string[] args) {
        int k = 3, v = 7;
        int a, b;
        a = k;
        while (a<=(v-2) && !(prim(a) && prim(a+2))) {a++;}
        if (a<=(v-2)) {
           b = a + 2;
           Console.WriteLine($"a két ikerprim: {a} és {b}");
        } else { Console.WriteLine("nincs ebben az interv..."); }
    }
```
